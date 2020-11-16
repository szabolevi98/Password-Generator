using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public List<string> letters = new List<string>();
        public List<string> capitalLetters = new List<string>();
        public List<string> numbers = new List<string>();
        public List<string> specialCharacters = new List<string>();
        public List<int> reservedPlaces = new List<int>();
        readonly Random rnd = new Random();
        readonly int ratio = 4; //Will be used as Length / 4

        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            //Lowercase Letters
            for (int i = 97; i <= 122; i++) //Lowercase letters are in 97 to 122 range in UTF-16 table
            {
                letters.Add(((char)i).ToString());
            }

            //Capital Letters
            for (int i = 65; i <= 90; i++) //Capital letters are in 65 to 90 range in UTF-16 table
            {
                capitalLetters.Add(((char)i).ToString());
            }

            //Numbers
            for (int i = 48; i <= 57; i++) //Numbers are in 48 to 57 range in UTF-16 table
            {
                numbers.Add(((char)i).ToString());
            }

            //Special Characters
            for (int i = 33; i <= 64; i++) //Special characters are in 33 to 64 range in UTF-16 table
            {
                if (i < 48 || i > 57) //Skip numbers, i already saved them
                {
                    specialCharacters.Add(((char)i).ToString());
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            int passLength = (int)lengthNumericUpDown.Value;
            bool captialLetters = capitalLetterCheckBox.Checked;
            bool numbers = numberCheckBox.Checked;
            bool specialCharacters = specialCheckBox.Checked;
            passWordTextBox.Text = GeneratePassword(passLength, captialLetters, numbers, specialCharacters);
        }

        private void PassWordTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = passWordTextBox.Text;
            if (text != "Jelszó" && text != string.Empty)
            {
                md5TextBox.Text = MD5(text);
                sha1TextBox.Text = SHA1(text);
            }
        }

        private void PassWordTextBox_Click(object sender, EventArgs e)
        {
            if (passWordTextBox.Text == "Jelszó")
            {
                passWordTextBox.Text = string.Empty;
            }
        }

        private string GeneratePassword(int length, bool capital, bool number, bool special)
        {
            if (reservedPlaces.Any())
            {
                reservedPlaces.Clear();
            }

            string password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                password += letters[rnd.Next(letters.Count)];
            }

            if (capital)
            {
                List<int> capitalPlaces = PlacesList(length);
                for (int i = 0; i < password.Length; i++)
                {
                    if (capitalPlaces.Contains(i))
                    {
                        StringBuilder sb = new StringBuilder(password);
                        sb[i] = Convert.ToChar(capitalLetters[rnd.Next(capitalLetters.Count)]);
                        password = sb.ToString();
                    }
                }
            }

            if (number)
            {
                List<int> numPlaces = PlacesList(length);
                for (int i = 0; i < password.Length; i++)
                {
                    if (numPlaces.Contains(i))
                    {
                        StringBuilder sb = new StringBuilder(password);
                        sb[i] = Convert.ToChar(numbers[rnd.Next(numbers.Count)]);
                        password = sb.ToString();
                    }
                }
            }

            if (special)
            {
                List<int> specialPlaces = PlacesList(length);
                for (int i = 0; i < password.Length; i++)
                {
                    if (specialPlaces.Contains(i))
                    {
                        StringBuilder sb = new StringBuilder(password);
                        sb[i] = Convert.ToChar(specialCharacters[rnd.Next(specialCharacters.Count)]);
                        password = sb.ToString();
                    }
                }
            }

            return password;
        }

        private List<int> PlacesList(int length)
        {
            int count = Math.Max(length / ratio, 1);
            List<int> places = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int tmp = rnd.Next(length);
                if (!places.Contains(tmp) && !reservedPlaces.Contains(tmp))
                {
                    places.Add(tmp);
                    reservedPlaces.Add(tmp);
                }
                else
                {
                    i--;
                }
            }
            return places;
        }

        private string SHA1(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(input);
                byteArray = sha1.ComputeHash(byteArray);
                return BitConverter.ToString(byteArray).Replace("-", "");
            }
        }

        private string MD5(string input)
        {
            using (MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(input);
                byteArray = md5.ComputeHash(byteArray);
                return BitConverter.ToString(byteArray).Replace("-", "");
            }
        }

        private void CopyButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(sender as Button, "Másolás");
        }

        private void CopyPassButton_Click(object sender, EventArgs e)
        {
            string text = passWordTextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                Clipboard.SetText(text);
            }
        }

        private void CopyMD5Button_Click(object sender, EventArgs e)
        {
            string text = md5TextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                Clipboard.SetText(text);
            }
        }

        private void CopySHA1Button_Click(object sender, EventArgs e)
        {
            string text = sha1TextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                Clipboard.SetText(text);
            }
        }
    }
}
