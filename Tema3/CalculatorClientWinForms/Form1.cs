using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalculatorClientWinForms
{
    public partial class Form1 : Form
    {

        private Timer pulseTimer;
        private int pulseStep;
        private bool pulseIncreasing;
        private Color originalColor;

        public Form1()
        {
            InitializeComponent();
            originalColor = lblRezultat.ForeColor;  

            pulseTimer = new Timer();
            pulseTimer.Interval = 100; 
            pulseTimer.Tick += PulseTimer_Tick;
        }

        private void PulseTimer_Tick(object sender, EventArgs e)
        {
            if (pulseIncreasing)
            {
                pulseStep++;
                int val = Math.Min(255, pulseStep * 30);

                lblRezultat.ForeColor = Color.FromArgb(val, Color.Green);

                if (val >= 255)
                    pulseIncreasing = false;
            }
            else
            {
                pulseStep--;
                int val = Math.Max(0, pulseStep * 30);

                lblRezultat.ForeColor = Color.FromArgb(val, Color.Green);

                if (val <= 0)
                {
                    pulseTimer.Stop();
                    lblRezultat.ForeColor = originalColor;  
                }
            }
        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0, b = 0;
                bool necesitaB = true;

                
                if (!double.TryParse(txtA.Text, out a))
                {
                    MessageBox.Show("Introdu un număr valid în câmpul A.");
                    return;
                }

                string operatie = cmbOperatie.SelectedItem?.ToString();

                
                if (operatie != "Radical")
                {
                    if (!double.TryParse(txtB.Text, out b))
                    {
                        MessageBox.Show("Introdu un număr valid în câmpul B.");
                        return;
                    }
                }

                
                var client = new CalculatorServiceRef.CalculatorServiceSoapClient();

                double rezultat = 0;

                switch (operatie)
                {
                    case "Adunare":
                        rezultat = client.Adunare(a, b);
                        break;
                    case "Scădere":
                        rezultat = client.Scadere(a, b);
                        break;
                    case "Înmulțire":
                        rezultat = client.Inmultire(a, b);
                        break;
                    case "Împărțire":
                        rezultat = client.Impartire(a, b);
                        break;
                    case "Radical":
                        rezultat = client.Radical(a);
                        break;
                    case "Putere":
                        rezultat = client.RidicareLaPutere(a, b);
                        break;
                    default:
                        MessageBox.Show("Selectează o operație.");
                        return;
                }

                lblRezultat.Text = $"Rezultat: {rezultat}";
             
                pulseStep = 0;
                pulseIncreasing = true;
                pulseTimer.Start();


                string operatieText = "";

                if (operatie == "Adunare")
                    operatieText = $"{a} + {b} = {rezultat}";
                else if (operatie == "Scădere")
                    operatieText = $"{a} - {b} = {rezultat}";
                else if (operatie == "Înmulțire")
                    operatieText = $"{a} * {b} = {rezultat}";
                else if (operatie == "Împărțire")
                    operatieText = $"{a} / {b} = {rezultat}";
                else if (operatie == "Putere")
                    operatieText = $"{a} ^ {b} = {rezultat}";
                else if (operatie == "Radical")
                    operatieText = $"√{a} = {rezultat}";
                else
                    operatieText = $"Operație necunoscută";

                lstIstoric.Items.Add(operatieText);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            lstIstoric.Items.Clear();
            lblRezultat.Text = "Rezultat:";
            txtA.Clear();
            txtB.Clear();
            cmbOperatie.SelectedIndex = -1;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstIstoric.Items.Count == 0)
                {
                    MessageBox.Show("Nu există operații de salvat.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Istoric_Calcule.txt");

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("== Istoric Calcule ==");
                    sw.WriteLine($"Data: {DateTime.Now}");
                    sw.WriteLine("---------------------------");

                    foreach (var item in lstIstoric.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Fișierul a fost salvat cu succes pe Desktop!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la salvare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
