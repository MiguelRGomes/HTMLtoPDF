@echo off
cls

set NomeArquivo=HTML2PDF

C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.io.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.kernel.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.styledxmlparser.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.pdfa.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.pdfua.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.html2pdf.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.layout.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.barcodes.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.bouncy-castle-connector.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.forms.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.sign.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.svg.dll ^
/reference:C:\Users\miguel\Desktop\HtmlToPDFMiguel\packages\itext.commons.dll ^
/target:library ^
/out:%NomeArquivo%.dll ^
%NomeArquivo%.cs