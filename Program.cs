using _241007weiszmate;
using System.Text;

List<Verseny> versenyzok = [];

using StreamReader sr = new(@"..\..\..\forras.txt", Encoding.UTF8);
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

//1.feladat
Console.WriteLine($"A versenyen résztvevők száma: {versenyzok.Count()}");

//2.feladat
var fel2 = versenyzok.Count(v => v.kategoria == "25-29");
Console.WriteLine($"versenyzők száma 25-29-es kat-ban: {fel2}");

//3. feladat
var fel3 = versenyzok.Average(v => 2024 - v.ev);
Console.WriteLine($"Átlag életkor: {fel3:0} év");

//7.feladat
var fel7 = versenyzok.GroupBy(v =>  v.kategoria);
foreach (var fel in fel7)
{
    Console.WriteLine($"Kategória: {fel.Key}\n\t{fel.Count()} db játékos");
}

Console.ReadKey();