using System.Resources;
using System;

namespace UCC
{
    public partial class DashBoard : Form
    {
        public string imagePath = "../../../Resources/Images/", filePath = "../../../Resources/Files/", videoPath = "../../../Resources/Videos/", iconPath = "../../../Resources/Icons/",name,photoPath;
        
        public DashBoard(string name,string photoPath=@"C:\Users\User\source\repos\UCC Final Version\UCC Final Version\Resources\Images\profilePicture.png")
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(imagePath + "mainBG.png");
            mathsChallenge.Image = Image.FromFile(imagePath + "mathsChallenge.gif");
            codingChallenge.Image = Image.FromFile(imagePath + "codingChallenge.gif");
            mainStory.Image = Image.FromFile(imagePath + "mainStory.gif");
            profilePicture.Image = Image.FromFile(photoPath);
            name = this.name;
            photoPath = this.photoPath;
            nameLabel.Text = this.name;
        }
        private void mathsChallenge_Click(object sender, EventArgs e)
        {
            MathsChallenge mathsChallenge = new MathsChallenge(name,photoPath);
            mathsChallenge.Location = this.Location;
            mathsChallenge.Show();
            Hide();
        }
        private void mainStory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!!");
        }
        private void codingChallenge_Click(object sender, EventArgs e)
        {
            CodingChallenge codingChallenge = new CodingChallenge(name,photoPath);
            codingChallenge.Location = this.Location;
            codingChallenge.Show();
            Hide();
        }
    }
}
