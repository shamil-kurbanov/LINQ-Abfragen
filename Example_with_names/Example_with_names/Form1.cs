
namespace Example_with_names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Das Strig-Array, welches wir mit LINQ abfragen wollen
        private string[] namen =
        {
            "Müller",
            "Meier",
            "Kurbanov",
            "Kurze",
            "Schneider",
            "Merkel",
            "Krause",
            "Baumann",
            "Hofmann"
        };

        //Eine einfache LINQ-Abfrage:
        /*
         * Wir selektieren die Eintrge, die länger als fünf Zeichen sind, und sortieren das Ergebnis der Länge nach.
         * Auf lokaler Ebene können wir von der sogennanten "Typinferenz" Gebrauch machen und den Ergebnis der Abfrage
         * mit dem Schlüsselwort "var" anstatt mit "IEnumerable<string>" deklarieren
         */
        private void button1_Click(object sender, EventArgs e)
        {
            var linqRes = from ps in namen
                          where ps.Length > 5
                          orderby ps.Length
                          select ps;
            Anzeigen(linqRes);
        }

        /*
         * Dasselbe Ergebnis produziert die folgende Abfrage auf der Basis von Erweiterungsmethoden und
         * Lambda-Ausdrücken
         */
        private void button2_Click(object sender, EventArgs e)
        {
            var linqRes = namen.Where(ps => ps.Length > 5).OrderBy(ps => ps.Length);
            Anzeigen(linqRes);
        }

        /*
         * Für sehr große Collections und Arrays bietet sich Parallel LINQ (PLINQ) an, welches Ihre
         * Abfrage zwischen mehreren Threads aufteilt, um sie parallel zu verarbeiten.
         * PLINQ aktivieren Sie, indem Sie die AsParallel-Methode auf das Array anwenden
         */
        private void button3_Click(object sender, EventArgs e)
        {
            var linqRes = from ps in namen.AsParallel()
                          where ps.Length > 5
                          orderby ps.Length
                          select ps;
        }

        /*
         * Die folgende Hilfsmethode erwarted als Übergabeparameter ein IEnumerable<string>, 
         * sie konvertiert die IEnumerable<string> in eine generische Liste vom Typ string und weist diese
         * der ListBox als Datenquelle zu:
         */
        private void Anzeigen(IOrderedEnumerable<string> linqRes)
        {
            listBox1.DataSource = linqRes.ToList();
        }

    }
}
