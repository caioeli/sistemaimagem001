using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaimagem001
{
    public partial class IMAGEM : Form
    {
        public IMAGEM()
        {
            InitializeComponent();
        }

        private void IMAGEM_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Arquivos mbp | *.bmp|Arquivos jpg | *.jpg";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
