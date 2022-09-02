using DesafioPOO.Models;
class Program
{
    static void Main(string[] args)
    {
        // Novo Nokia
        Nokia meuNokia = new Nokia(numero: "91234-5678", modelo: "5.3", iMEI: "16542345235", memoria: "128GB");
        meuNokia.MostrarInfo();

        // Novo iphone
        Iphone meuIphone = new Iphone(numero: "91234-5678", iMEI: "16542345235", memoria: "1TB", modelo: "13 PRO MAX");
        meuIphone.MostrarInfo();

    }

}
