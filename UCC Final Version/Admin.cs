using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCC
{
    public partial class Admin : Form
    {
        FileStream indexFile;
        StreamReader indexFileReader;
        StreamWriter indexFileWriter;
        public string imagePath = "../../../Resources/Images/",filePath= "../../../Resources/Files/",videoPath= "../../../Resources/Videos/",iconPath= "../../../Resources/Icons/";
        public Admin()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(imagePath + "mainBG.png");
            profilePicture.Image = Image.FromFile(imagePath + "profilePicture.png");
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Location = Location;
            signUpForm.Show();
            Hide();
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            indexFile = new FileStream(filePath + "Criminal_Data_File.txt", FileMode.Open, FileAccess.Write);
            indexFileReader = new StreamReader(indexFile);
            indexFileWriter = new StreamWriter(indexFile);
            indexFile.Seek(0, SeekOrigin.Begin);
            indexFile.Flush();
            indexFileWriter.Flush();
            string line;
            string[] field;
            int count = 0;
            while ((line = indexFileReader.ReadLine()) != null)
            {
                field = line.Split(',');

                if (field[0] == input.Text)
                {
                    indexFile.Seek(count, SeekOrigin.Begin);
                    indexFileWriter.Write("*");
                    indexFileWriter.Flush();
                    indexFile.Flush();
                }
                count += line.Length + 2;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            indexFile = new FileStream(filePath+"IndexFile.txt", FileMode.Open, FileAccess.Read);
            indexFileReader = new StreamReader(indexFile);
        }

        private void squeeze_Click(object sender, EventArgs e)
        {
            string line;
            indexFile.Seek(0, SeekOrigin.Begin);
            FileStream SQfile = new FileStream(filePath+"Squeeze.txt", FileMode.Create, FileAccess.Write);
            StreamWriter SQwriter = new StreamWriter(SQfile);
            while ((line = indexFileReader.ReadLine()) != null)
            {
                if (line[0] != '*')
                {
                    SQwriter.WriteLine(line);
                    SQwriter.Flush();
                }
            }
            SQwriter.Close();
            SQfile.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            input.Text = string.Empty;

        }
    }
}
