using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1;
        double number2;

        private void plus_Click(object sender, EventArgs e)
        {
            if (BothNumbersAreValid()) //Check at begge værdier er korrekte.
            {
                double result = number1 + number2; //Angive et fortegn og udregne.
                resultat.Text = result.ToString(); //Give resultat til brugeren.
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (BothNumbersAreValid()) //Check at begge værdier er korrekte.
            {
                double result = number1 - number2; //Angive et fortegn og udregne.
                resultat.Text = result.ToString(); //Give resultat til brugeren.
            }
        }

        private void gange_Click(object sender, EventArgs e)
        {
            if (BothNumbersAreValid()) //Check at begge værdier er korrekte.
            {
                double result = number1 * number2; //Angive et fortegn og udregne.
                resultat.Text = result.ToString(); //Give resultat til brugeren.
            }
        }

        private void divider_Click(object sender, EventArgs e)
        {
            if (BothNumbersAreValid()) //Check at begge værdier er korrekte.
            {
                if (number1 == 0 || number2 == 0)
                    return;

                double result = number1 / number2; //Angive et fortegn og udregne.
                resultat.Text = result.ToString(); //Give resultat til brugeren.
            }
        }

        private bool BothNumbersAreValid()
        {
            bool number1correct = double.TryParse(talfeltEt.Text, out number1);
            bool number2correct = double.TryParse(talfeltTo.Text, out number2);



            if (number1correct == true && number2correct == true) //Check at begge værdier er korrekte.
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}