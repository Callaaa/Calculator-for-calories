using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForCalories
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                double minuti = int.Parse(txtMinutes.Text);
                double resultat = 0;
                switch (cmbSports.SelectedItem)
                {
                    case "Аеробика":
                        resultat = Math.Round((500 / 60) * minuti);
                        break;
                    case "Боулинг":
                        resultat = Math.Round((200 / 60) * minuti);
                        break;
                    case "Волейбол":
                        resultat = Math.Round((220 / 60) * minuti);
                        break;
                    case "Тенис на корт":
                        resultat = Math.Round((540 / 60) * minuti);
                        break;
                    case "Футбол":
                        resultat = Math.Round((420 / 60) * minuti);
                        break;
                    case "Ски":
                        resultat = Math.Round((300 / 60) * minuti);
                        break;
                    case "Баскетбол":
                        resultat = Math.Round((570 / 60) * minuti);
                        break;
                }

                if (cmbSports.SelectedIndex == -1)
                {
                    MessageBox.Show("Невъведени данни!", "Грешка!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    txtResult.Text = resultat.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невъведени данни!", "Грешка!",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtMinutes.Clear();
            cmbSports.SelectedIndex = -1;
        }
    }
}
