using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IggClient
{
    public partial class IGGResolver : Form
    {
        public IGGResolver()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unresolvedUrl = unresolvedBox.Text;
            string resolvedUrl = unresolvedUrl.Substring(unresolvedUrl.IndexOf('=') + 1);
            if (unresolvedBox.Text.Contains("bluemedia"))
            {
                resolvedBox.Text = "http" + resolvedUrl;
            }
            else
            {
                resolvedBox.Text = ("This is not an IGG link!");
            }

        }

        private void IGGResolver_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
