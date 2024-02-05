using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void escribaAquíToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = comboBox1.Text.ToString();
            if (!url.Contains("http"))
            {
                url = "http://" + url;   
            }
            webBrowser1.Navigate(new Uri(url));
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();

        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
