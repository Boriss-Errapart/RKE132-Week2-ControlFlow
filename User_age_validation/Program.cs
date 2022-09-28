// Rakendus küsib kasutajalt tema sugu (m/n)
// Rakendus küsib kasutajalt tema perekon nanime
// Lähtudes kasutaja valikust tervitab kasutajat järgmiselt:
// "Tere, härra. [kasutaja perekonnanimi]" / "tere, proua [kasutaja perekonnanimi]"

Console.WriteLine("Palun sisestage sugu (m/n)");

// loek konsoolist maha andmeid (mõeldud sümboli või numbri jaoks)
char KasutajaSugu = Char.Parse(Console.ReadLine());

Console.WriteLine("Palun sisesta oma perekonna nimi:");
string kasutajaperekonnanimi = Console.ReadLine();

if (KasutajaSugu == 'm')

{ Console.WriteLine("Tere, härra!" + " " + kasutajaperekonnanimi + "!"); }

else if (KasutajaSugu == 'n')

{
Console.WriteLine($"Tere, proua! {kasutajaperekonnanimi}!");
}

else { Console.WriteLine($"Tere {kasutajaperekonnanimi}!"); }


