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
            if (int.TryParse(txtMinutes.Text, out minutes))
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

                // Skriv ut �r
                if (years > 0)
                {
                    lblResult.Text += $"{years} " + (years == 1 ? "�r" : "�r") + "\n";
                }

                // Skriv ut m�nader, gr�tt om 0
                if (months > 0)
                {
                    lblResult.Text += $"{months} " + (months == 1 ? "m�nad" : "m�nader") + "\n";
                }
                else if (years > 0)
                {
                    lblResult.Text += "0 m�nader\n";
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

        private void btnCalcIf_Click(object sender, EventArgs e)
        {
            //H�mta antalet minuter fr�n textrutan och omvandla till int
            int minutes;
            if(int.TryParse(txtMinutes.Text, out minutes) && minutes >= 0)
            {
                //Variabler f�r att spara resultaten
                int years = 0, months = 0, days = 0, hours = 0, remainingMinutes = 0;
                int totalMinutes = minutes;

                //konventera minuter till �r (ett �r = 525600 minuter) 
                if(minutes >= 60 * 24 * 365)
                {
                    years = minutes / (60 * 24 * 365);
                    minutes -= years * (60  * 24 * 365);
                }
                // Konvertera minuter till m�nader (en m�nad = 43200 minuter)
                if (minutes >= 60 * 24 * 30)
                {
                    months = minutes / (60 * 24 * 30);
                    minutes -= months * (60 * 24 * 30);
                }

                // Konvertera minuter till dagar (en dag = 1440 minuter)
                if (minutes >= 60 * 24)
                {
                    days = minutes / (60 * 24);
                    minutes -= days * (60 * 24);
                }

                // Konvertera minuter till timmar (en timme = 60 minuter)
                if (minutes >= 60)
                {
                    hours = minutes / 60;
                    minutes -= hours * 60;
                }

                // �terst�ende minuter
                remainingMinutes = minutes;

                //Visa resultatet p� etiketten (lbl Result)
                lblResult.Text = "";
                // Skriv ut �r
                if (years > 0)
                {
                    lblResult.Text += $"{years} " + (years == 1 ? "�r" : "�r") + "\n";
                }

                // Skriv ut m�nader, gr�tt om 0
                if (months > 0)
                {
                    lblResult.Text += $"{months} " + (months == 1 ? "m�nad" : "m�nader") + "\n";
                }
                else if (years > 0)
                {
                    lblResult.Text += "0 m�nader\n";
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
                else if (remainingMinutes > 0) // Om inga timmar men minuter finns
                {
                    lblResult.Text += $"{remainingMinutes} " + (remainingMinutes == 1 ? "minut" : "minuter");
                }
            }
            else
            {
                //Hantera fel vid inmatning
                MessageBox.Show("Ange ett giltigt antal minuter.");
            }
        }
    }
}
