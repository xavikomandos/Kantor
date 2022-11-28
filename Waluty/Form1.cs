using System.Xml.Linq;

namespace Waluty
{
    public partial class Form1 : Form
    {
        private Dictionary<string, float> _rates = new Dictionary<string, float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument api = XDocument.Load("https://api.nbp.pl/api/exchangerates/tables/a/?format=xml");

            // richTextBox1.Text = api.ToString();

            var rates = api.Descendants("Rate");

            foreach (var rate in rates)
            {
                string code = rate.Element("Code").Value;
                float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);

                _rates[code] = mid;
            }
          //richTextBox1.Text = _rates.ToString();
            
            textBoxUSD.Text = _rates["USD"].ToString();
            textBoxEURO.Text = _rates["EUR"].ToString();
            textBoxCHF.Text = _rates["CHF"].ToString();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exchange(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            string code = radio.Text;
            float pln = float.Parse(textBoxPLN.Text);
            float exchanged = pln / _rates[code];
            textBox1.Text = exchanged.ToString();
        }
    }
}