namespace Proje05_OOP_Advanced
{
    internal class Inhetirance
    {
        // sınıfların birbirlerine özelliklerini ve/veya metotlarınını aktarmasına kalıtım/miras/inheritance denir
    }
    //class isminin yanına : miras alınacak class adı yazılır.
    //miras alan classa delivered class miras alınan class ise base class denir
    public interface Mavi
    {
        public string RenkTonu { get; set; }
    }
    public class  Yesil
    {
        public string Kontrast { get; set; }
    }
    public class KaraTasiti
    {
        public int TekerlekSayisi { get; set; }
    }
    public class HavaTasiti
    {
        public string KanatBoyu { get; set; }
    }
    public class DenizTasiti
    {
        public bool Yelkenli { get; set; }
    }
    public class Araba:KaraTasiti
    {
        public byte kapiSayisi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ModelYili { get; set; }
        public double Fiyat { get; set; }
    }
    public class ElektirikliAraba : Araba
    {
        public bool Hibrit { get; set; }
        public int Menzil { get; set; }
        public int GucTuketimi { get; set; }
    }
    public class BenzinliAraba : Araba
    {
        public int MotorGucu { get; set; }
        public string Sanziman { get; set; }
        public int CO2 { get; set; }
    }    
    public class Tekne : DenizTasiti
    {
        public int KisiKapasitesi { get; set; }
    }

}
