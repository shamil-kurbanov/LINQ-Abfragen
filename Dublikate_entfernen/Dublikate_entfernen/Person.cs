using System;

namespace Dublikate_entfernen;

public record Person(string Nachname, string Vorname)
{

    //Eine überschriebene ToString() Methode zur Ausgabe:
    public override string ToString()
    {
        return $"{Vorname} {Nachname}";
    }
}
