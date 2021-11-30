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

namespace P4_4_1204003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "TextBox NAMA Tidak Boleh Kosong!!!");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
            else
            {
                if ((tbNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "Benar!!!");
                }
                else
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "Inputan Hanya Boleh Huruf !!!");
                    epCorrect.SetError(tbNama, "");
                }
            }
        }

        private void tbNPM_Leave(object sender, EventArgs e)
        {
            if (tbNPM.Text == "")
            {
                epWarning.SetError(tbNPM, "TextBox NPM Tidak Boleh Kosong!!!");
                epWrong.SetError(tbNPM, "");
                epCorrect.SetError(tbNPM, "");
            }
            else
            {
                if ((tbNPM.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(tbNPM, "");
                    epWrong.SetError(tbNPM, "");
                    epCorrect.SetError(tbNPM, "Benar!!!");
                }
                else
                {
                    epWarning.SetError(tbNPM, "");
                    epWrong.SetError(tbNPM, "Inputan Hanya Boleh Angka !!!");
                    epCorrect.SetError(tbNPM, "");
                }
            }
        }

        private void tbNoHP_Leave(object sender, EventArgs e)
        {
            tbNoHP.MaxLength = 12;

            if (tbNoHP.Text == "")
            {
                epWarning.SetError(tbNoHP, "TextBox NO.HP Tidak Boleh Kosong!!!");
                epWrong.SetError(tbNoHP, "");
                epCorrect.SetError(tbNoHP, "");
            }
            else
            {
                if ((tbNoHP.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(tbNoHP, "");
                    epWrong.SetError(tbNoHP, "");
                    epCorrect.SetError(tbNoHP, "Benar!!!");
                }
                else
                {
                    epWarning.SetError(tbNoHP, "");
                    epWrong.SetError(tbNoHP, "Inputan Hanya Boleh Angka !!!");
                    epCorrect.SetError(tbNoHP, "");
                }
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
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

        private void tbKapital_Leave(object sender, EventArgs e)
        {
            tbKapital.CharacterCasing = CharacterCasing.Upper;

            if (tbKapital.Text == "")
            {
                epWarning.SetError(tbKapital, "TextBox Tidak Boleh Kosong!!!");
                epWrong.SetError(tbKapital, "");
                epCorrect.SetError(tbKapital, "");
            }
            else
            {
                if ((tbKapital.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbKapital, "");
                    epWrong.SetError(tbKapital, "");
                    epCorrect.SetError(tbKapital, "");
                }
                else
                {
                    epWarning.SetError(tbKapital, "");
                    epWrong.SetError(tbKapital, "Inputan Hanya Tidak Boleh Angka !!!");
                    epCorrect.SetError(tbKapital, "");
                }
            }
        }

        private void tbKecil_Leave(object sender, EventArgs e)
        {
            tbKecil.CharacterCasing = CharacterCasing.Lower;

            if (tbKecil.Text == "")
            {
                epWarning.SetError(tbKecil, "TextBox Tidak Boleh Kosong!!!");
                epWrong.SetError(tbKecil, "");
                epCorrect.SetError(tbKecil, "");
            }
            else
            {
                if ((tbKecil.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbKecil, "");
                    epWrong.SetError(tbKecil, "");
                    epCorrect.SetError(tbKecil, "");
                }
                else
                {
                    epWarning.SetError(tbKecil, "");
                    epWrong.SetError(tbKecil, "Inputan Hanya Tidak Boleh Angka !!!");
                    epCorrect.SetError(tbKecil, "");
                }
            }
        }

        private void tbTinggi_TextChanged(object sender, EventArgs e)
        {
            if (tbTinggi.Text == "")
            {
                epWarning.SetError(tbTinggi, "Textbox tidak boleh kosong!");
                epWrong.SetError(tbTinggi, "");
                epCorrect.SetError(tbTinggi, "");
            }
            else
            {
                if ((tbBerat.Text).All(Char.IsNumber))
                {
                    if (tbBerat.Text == "")
                    {
                        epWarning.SetError(tbBerat, "Berat Belum terisi");
                    }

                    else
                    {
                        epCorrect.SetError(tbBerat, "Berat Terisi");
                    }
                }

                else if (tbTinggi.Text == "")
                {
                    epWarning.SetError(tbTinggi, "Textbox tidak boleh kosong");

                }

                else
                {
                    epWrong.SetError(tbTinggi, "inputan hanya boleh Angka!");
                }
            }
        }

        private void tbBerat_TextChanged(object sender, EventArgs e)
        {
            if ((tbBerat.Text).All(Char.IsNumber))
            {
                int Tinggi = int.Parse(tbTinggi.Text);
                int Berat = tbBerat.Text == "" ? 0 : int.Parse(tbBerat.Text);
                if (Tinggi > Berat)
                {
                    epCorrect.SetError(tbBerat, "Tinggi lebih besar dari Berat ");
                }
            }

            else if ((tbBerat.Text == ""))
            {
                epWarning.SetError(tbBerat, "Textbox tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(tbBerat, "inputan hanya boleh Angka!");
            }
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show
               ("NAMA : " + tbNama.Text +
                  "\nNPM : " + tbNPM.Text +
                  "\nNO HP : " + tbNoHP.Text +
                  "\nEMAIL : " + tbEmail.Text +
                  "\nNAMA (DENGAN HURUF KAPITAL) : " + tbKapital.Text +
                  "\nNAMA (DENGAN HURUF KECIL) : " + tbKecil.Text +
                  "\ntINGGI BADANG : " + tbTinggi.Text +
                  "\nBERAT : " + tbBerat.Text,
                  "BIODATA DIRI",
                  MessageBoxButtons.OK, MessageBoxIcon.Information
               );
        }
    }
}




