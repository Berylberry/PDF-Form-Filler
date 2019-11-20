using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Pdf;
using PDFFormFiller.APIObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFFormFiller.Model
{
    public class FormatPDF
    {
        private Dictionary<string,string> GetValuePairs()
        {
            var formData = new FormData();
            Type myType = typeof(FormData);
            List<string> fieldNames = new List<string>(myType.GetFields().Select(x => x.Name));
            var dictionary = new Dictionary<string, string>();
            foreach(var name in fieldNames)
            {
                var field = myType.GetField(name);
                var toBeInserted = field.GetValue(formData);
                var att = field.GetCustomAttributes(typeof(DescriptionAttribute), true).FirstOrDefault() as DescriptionAttribute;
                dictionary.Add(att.Description, toBeInserted.ToString());
            }
            return dictionary;
        }

        public void fillPDF()
        {
            string fileName = @"\resources\ESDC-EMP5624.pdf";
            string src = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + fileName;
            string strPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string dest = strPath +  @"\filledForm.pdf";
            var pdfReader = new PdfReader(src);
            var pdfWriter = new PdfWriter(dest);
            var pdfDoc = new PdfDocument(pdfReader, pdfWriter);
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
            IDictionary<string, PdfFormField> fields = form.GetFormFields();
            var formData = GetValuePairs();
            foreach(var data in formData)
            {
                fields[data.Key].SetValue(data.Value);
            }

            pdfDoc.Close();
        }
    }
}
