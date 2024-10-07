using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241007weiszmate
{
    internal class Verseny
    {
        public string nev { get; set; }
        public int ev { get; set; }
        public int rajtszam { get; set; }
        public string nem { get; set; }
        public string kategoria { get; set; }
        public TimeOnly uszasideje { get; set; }
        public TimeOnly elsodepobantoltottido { get; set; }
        public TimeOnly kerekparozasideje { get; set; }
        public TimeOnly masodikdepobantoltottido { get; set; }
        public TimeOnly futasideje { get; set; }

        public override string ToString()
        {
            return $"Név: {nev} szülév: {ev} száma: {rajtszam} neme:{nem} kati: {kategoria} idok: {uszasideje}, {elsodepobantoltottido}, {kerekparozasideje}, {masodikdepobantoltottido} futás idő: {futasideje}";
        }

        public Verseny(string sor)
        {
            var v = sor.Split(';');
            nev = v[0];
            ev = int.Parse(v[1]);
            rajtszam = int.Parse(v[2]);
            nem = v[3];
            kategoria = v[4];
            uszasideje = TimeOnly.Parse(v[5]);
            elsodepobantoltottido = TimeOnly.Parse(v[6]);
            kerekparozasideje = TimeOnly.Parse(v[7]);
            masodikdepobantoltottido= TimeOnly.Parse(v[8]);
            futasideje = TimeOnly.Parse(v[9]);
        }
    }
}
