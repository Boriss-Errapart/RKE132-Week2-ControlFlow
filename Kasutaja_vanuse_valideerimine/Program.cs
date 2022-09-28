// rakendus palub kasutajal sisestada tema vanus.
// kui vanus on väiuksem kui 13, siis konsoolis kuvatakse:
// Te olete liiga noor, et kasutada instagrammi.
// Muul juhul kuvatakse "Teretulemast instagrammi"

Console.WriteLine("Sisestage oma vanus");

int Kasutajavanus = Int32.Parse(Console.ReadLine());

if (Kasutajavanus >= 13)
{
    Console.WriteLine("Tere tulemast instagrammi!");
}
else
{
    Console.WriteLine("Te olete liiga noor instagrammi kasutamiseks!");
}