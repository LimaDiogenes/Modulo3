namespace PilotoAutomatico
{
    internal class FordTrimotor : Aeronave, IAviao
    {
        public override string TipoTremDePouso { get; set; }
        public override int QtdePassageiros { get; set; }
        public override int QtdeTripulantes { get; set; }
        public override double PesoVazioKG { get; set; }
        public override double PesoMaximoKG { get; set; }
        public override int QtdeMotores { get; set; }
        public override string TipoMotores { get; set; }
        public override string TipoCombustivel { get; set; }
        public override double CapacidadeCombustivelKG { get; set; }
        public override string Fabricante { get; set; }
        public override double VelocidadeAtual { get; set; }
        public override double VelocidadeMaximaKTS { get; set; }
        public override double AltitudeMaximaFT { get; set; }
        public override double AltitudeAtual { get; set; }
        public override string Modelo { get; set; }
        public override double Roll_EixoX { get; set; }
        public override double Pitch_EixoY { get; set; }
        public override double Yaw_EixoZ { get; set; }

        // IAviao
        public int QuantidadeAsas { get; set; }
        public bool Flaps { get; set; }
        public bool Pressurizado { get; set; }
        public string Matricula { get; set; }

        internal FordTrimotor()
        {
            QuantidadeAsas = 2;
            Flaps = false;
            Pressurizado = false;
            Matricula = "NC8407";
            Fabricante = "Ford";
            Modelo = "Trimotor 4-AT";
            TipoTremDePouso = "Fixo, convencional";
            QtdeMotores = 3;
            TipoMotores = "Radial à pistão";
            TipoCombustivel = "Gasolina";
            CapacidadeCombustivelKG = 546;
            QtdePassageiros = 11;
            QtdeTripulantes = 3;
            PesoMaximoKG = 4595;
            PesoVazioKG = 2950;
            VelocidadeMaximaKTS = 115;
            VelocidadeAtual = new Sensor(0, VelocidadeMaximaKTS).ObterPosicaoAtual(); // pitot
            AltitudeMaximaFT = 15000;
            AltitudeAtual = new Sensor(-1412.0, AltitudeMaximaFT).ObterPosicaoAtual(); // sensores altitude
            Roll_EixoX = new Sensor(-180.0, 180.0).ObterPosicaoAtual(); // giroscopio
            Pitch_EixoY = new Sensor(-180.0, 180.0).ObterPosicaoAtual(); // sensor AOA
            Yaw_EixoZ = new Sensor(0.0, 359.9999).ObterPosicaoAtual(); // giroscopio
        }


    public override void Acelerar(double porcentagem)
    {
        if (VelocidadeAtual < VelocidadeMaximaKTS)
        {
            VelocidadeAtual += VelocidadeMaximaKTS * (porcentagem / 100);
            if (VelocidadeAtual > VelocidadeMaximaKTS)
            {
                VelocidadeAtual = VelocidadeMaximaKTS;
            }
        }
        Console.WriteLine($"Acelerando o {Modelo}. Velocidade Atual: {VelocidadeAtual :f2} nós");
    }

    public override void Freiar(double porcentagem)
    {
        if (VelocidadeAtual > 0)
        {
            VelocidadeAtual -= VelocidadeAtual * (porcentagem / 100);
            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }

        Console.WriteLine($"Freiando o {Modelo}. Velocidade Atual: {VelocidadeAtual :f2} nós");
    }

    public override void RolarDireita(double grausPM)
    {
        // logica com graus por minuto, receberia input to manche
        Console.WriteLine($"{Modelo} rolando para direita");
    }

    public override void RolarEsquerda(double grausPM)
    {
        // logica com graus por minuto, receberia input to manche
        Console.WriteLine($"{Modelo} rolando para esquerda");
    }

    public override void GuinarDireita(double grausPM)
    {
        // logica com graus por minuto, receberia input to manche
        Console.WriteLine($"{Modelo} guinando para direita");
    }

    public override void GuinarEsquerda(double grausPM)
    {
        // logica com graus por minuto, receberia input to manche
        Console.WriteLine($"{Modelo} guinando para esquerda");
    }

    public override void SubirNariz(double grausPM)
    {
        Console.WriteLine($"{Modelo} cabrando");
    }

    public override void DescerNariz(double grausPM)
    {
        Console.WriteLine($"{Modelo} picando");
    }



}
}