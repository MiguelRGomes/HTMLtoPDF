using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Pdfa;
using iText.StyledXmlParser;
using iText.StyledXmlParser.Node;
using iText.StyledXmlParser.Node.Impl.Jsoup;
using iText.Html2pdf;
using iText.Kernel.Geom;

namespace HTML2PDF
{
    public class ConvertHTML2PDF
    {
        // Método principal para converter HTML para PDF
        /*public static void Main(string[] args)
        {
            // Lê o conteúdo do arquivo HTML especificado
            string Html = File.ReadAllText(args[0]);
            // Chama o método para converter HTML para PDF e salva o PDF no local especificado
            HTML2PDF(Html, args[1]);
        }
        */
        
        // Método para converter HTML para PDF
        public static void HTML2PDF(string HTMLtext, string CaminhoPDF)
        {
            // Escreve os bytes do PDF gerado a partir do HTML no caminho especificado
            File.WriteAllBytes(CaminhoPDF, GeneratePDF(HTMLtext, PageSize.A4));
        }
        
        // Método para gerar o PDF a partir do HTML
        private static byte[] GeneratePDF(string html, Rectangle pageSize) 
        {
            // Array de bytes que conterá o PDF final
            Byte[] bytes;

            // Usando um MemoryStream para escrever os dados temporariamente
            using (MemoryStream ms = new MemoryStream())
            {   
                // Cria um escritor de PDF vinculado ao MemoryStream
                PdfWriter writer = new PdfWriter(ms); 
                // Cria um documento PDF
                PdfDocument pdfDoc = new PdfDocument(writer);
                
                // Converte o HTML em PDF e escreve no MemoryStream
                HtmlConverter.ConvertToPdf(html, writer);
                
                // Obtém os bytes do MemoryStream
                bytes = ms.ToArray();
            }
            // Retorna os bytes do PDF gerado
            return bytes;
        }
    }
}
