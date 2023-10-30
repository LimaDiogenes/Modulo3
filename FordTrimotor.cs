namespace PilotoAutomatico
{
    internal class FordTrimotor : Aeronave
    {
        internal FordTrimotor()
        {
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
        }
            
        public override void Acelerar(double porcentagem)
        {
            if (VelocidadeAtual < VelocidadeMaximaKTS)
            {
            VelocidadeAtual += VelocidadeMaximaKTS * (porcentagem / 100);
            if(VelocidadeAtual > VelocidadeMaximaKTS)
            {
                VelocidadeAtual = VelocidadeMaximaKTS;
            }
            }
            Console.WriteLine($"Acelerando o {Modelo}. Velocidade Atual: {VelocidadeAtual}");
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
                
            Console.WriteLine($"Freiando o {Modelo}. Velocidade Atual: {VelocidadeAtual}");
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