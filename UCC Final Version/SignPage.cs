using System.Windows.Forms.Design;
using System.IO;
namespace UCC
{
    public partial class SignPage : Form
    {
        public string imagePath = "../../../Resources/Images/", filePath = "../../../Resources/Files/", videoPath = "../../../Resources/Videos/", iconPath = "../../../Resources/Icons/";
        string fileName = "SignInData.txt";
        FileStream signInFile;
        StreamReader signInReader;
        public SignPage()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(imagePath + "signBG.png");
        }

        private void SignPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            signInFile = new FileStream(filePath+"SignInData.txt", FileMode.OpenOrCreate, FileAccess.Read);
            signInReader = new StreamReader(signInFile);
            bool correct = true;
            if (criminalIDBox.Text == "admin")
            {
                if (passWordBox.Text == "admin")
                {
                    Admin admin = new Admin();
                    admin.Location = Location;
                    admin.Show();
                    Hide();
                    return;
                }
            }
            if (signInFile.Length < 5)
            {
                MessageBox.Show("You need to Sign Up");
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.Location = Location;
                signUpForm.Show();
                Hide();
                return;
            }
            else
            {
                string[] signInData = signInReader.ReadToEnd().Split("\n");
                for (int i = 0; i < signInData.Length; i++)
                {
                    string[] record = signInData[i].Split(",");
                    string criminalId = record[0];
                    string passWord = record[1].Trim();

                    if (criminalId == criminalIDBox.Text)
                    {
                        if (passWord == passWordBox.Text)
                        {
                            //Play the game
                            string name = record[2];
                            string photoPath = record[3];
                            DashBoard dashBoard = new DashBoard(name);
                            dashBoard.Location = Location;
                            dashBoard.Show();
                            signInFile.Close();
                            signInReader.Close();
                            Hide();
                            return;
                        }
                    }
                    if (i == signInData.Length - 1)
                    {
                        correct = false;
                    }
                }
                if (!correct)
                {
                    MessageBox.Show("Wrong");
                }
            }
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Location = Location;
            signUpForm.Show();
            Hide();
        }
    }
}
