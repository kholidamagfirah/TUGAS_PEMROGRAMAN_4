using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_3_1204003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbHuruf_Leave(object sender, EventArgs e)
        {
            if (tbHuruf.Text == "")
            {
                epWarning.SetError(tbHuruf, "TextBox Huruf Tidak Boleh Kosong!!!");
                epWrong.SetError(tbHuruf, "");
                epCorrect.SetError(tbHuruf, "");
            }
            else
            {

                if ((tbHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbHuruf, "");
                    epWrong.SetError(tbHuruf, "");
                    epCorrect.SetError(tbHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbHuruf, "Inputan Hanya Boleh Huruf !!!");
                    epWarning.SetError(tbHuruf, "");
                    epCorrect.SetError(tbHuruf, "");
                }
            }
        }

        private void tbAngka_TextChanged(object sender, EventArgs e)
        {
            if (tbAngka.Text == "")
            {
                epWarning.SetError(tbAngka, "TextBox Angka Tidak Boleh Kosong!!!");
                epWrong.SetError(tbAngka, "");
                epCorrect.SetError(tbAngka, "");
            }
            else
            {
                if ((tbAngka.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(tbAngka, "");
                    epWrong.SetError(tbAngka, "");
                    epCorrect.SetError(tbAngka, "Betul!!!");
                }
                else
                {
                    epWrong.SetError(tbAngka, "Inputan Hanya Boleh Angka !!!");
                    epWarning.SetError(tbAngka, "");
                    epCorrect.SetError(tbAngka, "");
                }
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "TextBox Email Tidak Boleh Kosong!!!");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "Betul!!!");
                }
                else
                {
                    epWrong.SetError(tbEmail, "Format email salah! \nContoh : a@b.c");
                    epWarning.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "");
                }
            }
        }

        private void tbAngka1_TextChanged(object sender, EventArgs e)
        {
            if (tbAngka1.Text == "")
            {
                epWarning.SetError(tbAngka1, "Textbox Angka 1 tidak boleh kosong!");
                epWrong.SetError(tbAngka1, "");
                epCorrect.SetError(tbAngka1, "");
            }
            else
            {
                if ((tbAngka2.Text).All(Char.IsNumber))
                {
                    if (tbAngka2.Text == "")
                    {
                        epWarning.SetError(tbAngka2, "Angka 2 Belum terisi");
                    }

                    else
                    {
                        epCorrect.SetError(tbAngka2, "Angka 2 Terisi");
                    }
                }

                else if (tbAngka1.Text == "")
                {
                    epWarning.SetError(tbAngka1, "Textbox Angka tidak boleh kosong");

                }

                else
                {
                    epWrong.SetError(tbAngka1, "inputan hanya boleh Angka!");
                }
            }
        }

        private void tbAngka2_TextChanged(object sender, EventArgs e)
        {
            if ((tbAngka2.Text).All(Char.IsNumber))
            {
                int Angka1 = int.Parse(tbAngka1.Text);
                int Angka2 = tbAngka2.Text == ""?0: int.Parse(tbAngka2.Text);
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(tbAngka2, "Angka 1 lebih besar dari angka 2 ");
                }
            }

            else if ((tbAngka2.Text == ""))
            {
                epWarning.SetError(tbAngka2, "Textbox tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(tbAngka2, "inputan hanya boleh Angka!");
            }
        }
        }
    }

