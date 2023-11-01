namespace PilotoAutomatico
{
    class Program
    {
        public static void Main()
        {
            Aeronave Ford4AT = new FordTrimotor();
            Console.WriteLine($"Aeronave: {Ford4AT.Modelo}");
            // forcando altitude de inicio. isso seria encapsulado para proteger, mas
            // como o "sensor" utiliza valor aleatorio, deixei publico para poder forcar aqui
            Ford4AT.AltitudeAtual = 500.00;
            Console.WriteLine($"Altitude atual:{Ford4AT.AltitudeAtual}");
            Console.WriteLine();
            // acelerando e freiando o aviao
            Ford4AT.Acelerar(100); // 100 por cento de velocidade         
            Ford4AT.Freiar(10); // freiar 10 por cento em cima da velocidade atual
            // criacao do piloto automatico
            Console.WriteLine();
            PilotoAutomatico PilAut = new(Ford4AT);
            // primeira subida
            PilAut.Subir(5000);
            //Thread.Sleep(2000);
            Console.WriteLine();
            // segunda subida para gerar erro de altitude
            PilAut.Subir(3000);
            //Thread.Sleep(2000);
            Console.WriteLine();
            // subida utilizando segunda versao, para provocar erro de altitude maior que permitido pela aeronave
            PilAut.Subir(15000, 5);
            //Thread.Sleep(2000);
            Console.WriteLine();
            // subida com erro velocidade baixa
            Ford4AT.Freiar(70);
            PilAut.Subir(100, 7);
            Console.WriteLine();

            PilAut.Acelerar(100);
            Console.WriteLine();

            // descida selecionando razao de descida
            PilAut.Descer(400, 3);
            Console.WriteLine();
            //Thread.Sleep(2000);
            // descida selecionando razao de descida - invalida
            PilAut.Descer(7000, 15);
            Console.WriteLine();
            Thread.Sleep(2000);
            // versao selecionando altitude - invalida
            PilAut.Descer(-250);
            Console.WriteLine();
            //Thread.Sleep(2000);

            PilAut.Subir(12500);
            Console.WriteLine();

            // versao selecionando altitude
            PilAut.Descer(1300);
            Console.WriteLine();
            //Thread.Sleep(2000);

            Console.ReadLine();

        }
    }
}
