using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace UCC
{
    public partial class SignInFailed : Form
    {
        public string imagePath = "../../../Resources/Images/", filePath = "../../../Resources/Files/", videoPath = "../../../Resources/Videos/", iconPath = "../../../Resources/Icons/";
        public SignInFailed()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(imagePath + "signBG.png");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
