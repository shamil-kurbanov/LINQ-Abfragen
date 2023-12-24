namespace Dublikate_entfernen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> persons = new List<Person>()
        {
            new Person("M�ller", "Kurt"),
            new Person("Neier", "Timo"),
            new Person("Scneider", "Alois"),
            new Person("Kurbanov", "Shaml"),
            new Person("M�ller", "Kurt"),
            new Person("Schr�der", "Thomas"),
            new Person("M�ller", "Kurt"),
            new Person("M�ller", "Max"),
            new Person("M�ller", "Thomas"),
            new Person("Brezner", "Dr. "),
            new Person("Doberenz", "Walter")
        };

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Personendublikate werden mittels Distinct-Methode entfernt
            var persoons1 = persons.Distinct();

            foreach (Person person in persoons1)
            {
                listBox1.Items.Add(person);
            }
        }

    }
}
