namespace Minutomvandlare_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int minutes;
            if(int.TryParse(txtMinutes.Text, out minutes))
            {
                int years = minutes / (60 * 24 * 365);
                minutes %= 60 * 24 * 365;
                int months = minutes / (60 * 24 * 30);
                minutes %= 60 * 24 * 30;
                int days = minutes / (60 * 24);
                minutes %= 60 * 24;
                int hours = minutes / 60;
                int remainingMinutes = minutes % 60;

                lblResult.Text = "";

                // Skriv ut år
                if (years > 0)
                {
                    lblResult.Text += $"{years} " + (years == 1 ? "år" : "år") + "\n";
                }

                // Skriv ut månader, grått om 0
                if (months > 0)
                {
                    lblResult.Text += $"{months} " + (months == 1 ? "månad" : "månader") + "\n";
                }
                else if (years > 0)
                {
                    lblResult.Text += "0 månader\n";
                    lblResult.ForeColor = Color.Gray;
                }

                // Skriv ut dagar
                if (days > 0)
                {
                    lblResult.Text += $"{days} " + (days == 1 ? "dag" : "dagar") + "\n";
                }

                // Skriv ut timmar och minuter om relevant
                if (hours > 0)
                {
                    lblResult.Text += $"{hours} " + (hours == 1 ? "timme" : "timmar");

                    if (remainingMinutes > 0)
                    {
                        lblResult.Text += $" och {remainingMinutes} " + (remainingMinutes == 1 ? "minut" : "minuter");
                    }
                }
                else if (remainingMinutes > 0) // Om inga timmar, men minuter finns
                {
                    lblResult.Text += $"{remainingMinutes} " + (remainingMinutes == 1 ? "minut" : "minuter");
                }
            }
            else
            {
                MessageBox.Show("Ange ett giltigt antal minuter.");
            }
        }
    }
}
