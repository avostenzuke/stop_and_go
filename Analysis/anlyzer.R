addToReport = function(message){
  outputStr = paste(message, sep="")
  write.table(outputStr, file=REPORT_FILE, append=T, col.names=F, row.names=F, sep=';', fileEncoding = "UTF-8")
  cat(paste('\n',outputStr))
}

analyzeBin = function(filepath, reportdir){
  
  setwd(reportdir)
  
  toread = filepath
  finfo = file.info(toread)
  alldata = readBin(toread, integer(), size=1, n = finfo$size, signed = F, endian='little')  
      
  allFreq = matrix(data = NA, nrow = 256, ncol = 2)
  allFreq[, 1] = 0:255
  
  allFreq = apply(X = allFreq, MARGIN = 1, FUN = function(row){
    v = row[1]
    f = sum(alldata == v)
    return(c(v,f))
  })
  
  allFreq = t(allFreq)
  colnames(allFreq) = c("Value", "Frequency")
  
  expectedFrequency = length(alldata)/256
  addToReport(paste("File ", basename(INPUT_FILE), ", size: ", file.info(INPUT_FILE)$size, " bytes", sep=""))
  addToReport(paste("Theoretical frequency: ", expectedFrequency, sep=""))
  addToReport(paste("Real frequency of byte values (times from ", length(alldata), "):", sep=""))
  cat(allFreq[,"Frequency"])
  suppressWarnings(write.table(allFreq, REPORT_FILE, row.names = F, sep = ";", append = T, fileEncoding = "UTF-8"))

  addToReport(paste("Pearson's chi-squared, chisq.test(allFreq[,'Frequency']): ", sep=""))
  x = chisq.test(allFreq[,"Frequency"])$statistic
  addToReport(chisq.test(allFreq[,"Frequency"])$statistic)
  addToReport(paste("Pearson's chi-squared critical, qchisq(p = 0.95, df = 255): ", sep=""))
  addToReport(qchisq(p = 0.95, df = 255))
  
  
  svg("autocorrelation.svg")  
  acf = acf(alldata, plot = F, lag.max = 300)
  plot(1:length(acf$acf),
       as.vector(acf$acf),
       type = "l",
       col = "dark red",
       main = "Autocorrelation",
       xlab = paste("distance between bytes", sep=""),
       ylab= paste("ACF", sep=""),
       ylim = c(0, 0.01))

  dev.off()
  
  svg("first_1000_byte_values.svg")
  plot(
    1:1000,
    alldata[1:1000],
    type = 'p',
    col = "dark red",
    main = "first 1000 byte values",
    xlab = paste("byte index", sep=""),
    ylab= "byte value")  
  
  dev.off()
  
  svg(file.path(reportdir,"byte_frequency.svg"))
  plot(
    0:255,
    allFreq[,"Frequency"],
    type = 'p',
    col = "dark red",
    main = "Frequency",
    xlab = paste("byte value", sep=""),
    ylab= paste("times", sep=""))  
  
  lines(0:255, rep(expectedFrequency, 256), col = "black")
  lines(0:255, allFreq[,"Frequency"], col = "dark red")
        
  legend("bottom",
         bty = "n",
         legend = c("theoretical frequency",
                    paste("real values", sep="")),
         box.lty = 2,
         pch = c(NA, 21),
         lty = c(1, 1),
         col=c("black", "dark red"))
  
  dev.off()
}

REPORT_DIR = "C:\\R"
REPORT_FILE = "report.txt"
INPUT_FILE = file.choose()

doWork = function(){
  file.create(REPORT_FILE)
  analyzeBin(INPUT_FILE, REPORT_DIR)  
}

doWork()