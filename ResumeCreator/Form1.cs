using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeCreator
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        // personal info
        private void UploadImagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "icon";
            ofd.Filter = "icon (*.png;*.jpg;*.jpeg;) | *.png;*.jpg;*.jpeg;";
            ofd.ShowDialog();
            PictureBox.Image = new Bitmap(ofd.FileName);
        }


        private void FirstNamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void MiddleNamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void LastNamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void DateOfBirthbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '-' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void EmailAddbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void HomeAddbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void MobileNumbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '-' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        // Education Background //

        private void Gradtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void GradYrtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void HighSchooltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void HSYrtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void Collegetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void CollegeYrtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Coursetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        // Skills Expertise

        private void Skill1txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Skill2txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Skill3txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        // Employment History

        private void CompanyName1txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void From1txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void To1txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void CompanyName2txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void WorkPosition1txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void From2txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void To2txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void WorkPosition2txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))
            && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '#' && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

    }
}
