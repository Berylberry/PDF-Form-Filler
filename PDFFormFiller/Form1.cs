using PDFFormFiller.APIObject;
using PDFFormFiller.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFFormFiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formatPDF = new FormatPDF();
            formatPDF.fillPDF();
            MessageBox.Show("The form has been sucessfully filled and can be found on your desktop with the name filledForm");
        }
    }
}
