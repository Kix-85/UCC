using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer;
//using AxWMPLib;
using WMPLib;

namespace UCC
{
    public partial class SignInPassed : Form
    {
        public string imagePath = "../../../Resources/Images/", filePath = "../../../Resources/Files/", videoPath = "../../../Resources/Videos/", iconPath = "../../../Resources/Icons/";
        public SignInPassed()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(imagePath + "signBG.png");
        }

        private void SignInPassed_Load(object sender, EventArgs e)
        {
            //youmWaraYoum.Ctlcontrols.play();
        }
    }
}
