namespace Stringabfrafgen_mit_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "XY34/w = abc-12";
            listBox1.Items.Add(s);
            listBox1.Items.Add(String.Empty); listBox1.SelectedIndex = 0;

            //Nur die Zeichen ausw�hlen, die Zahlen darstellen
            var query1 = from c in s
                         where char.IsDigit(c)
                         select c;

            //Erst jetzt wird die Abfrage ausgef�hrt
            foreach (char c in query1)
            {
                listBox1.Items.Add(c);
                
            }
            listBox1.Items.Add(String.Empty);


            //Die Count Methode:
            int count = query1.Count();
            listBox1.Items.Add($"Anzahl = {count}"); listBox1.Items.Add(String.Empty);

            //Alle Zeichen vor dem ersten "=" ausw�hlen:
            var query2 = s.TakeWhile(c => c != '=');

            //Die Zweite Abfrage ausf�hren:
            foreach(char c in query2)
            {
                listBox1.Items.Add(c.ToString());
            }
        }
    }
}
