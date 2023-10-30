namespace PilotoAutomatico
{
    internal abstract class Aeronave : IAeronave
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string TipoTremDePouso { get; set; }
        public int QtdePassageiros { get; set; }
        public int QtdeTripulantes { get; set; }
        public double PesoVazioKG {get; set;}
        public double PesoMaximoKG { get; set; }
        public int QtdeMotores { get; set; }
        public string TipoMotores { get; set; }
        public string TipoCombustivel { get; set; }
        public double CapacidadeCombustivelKG { get; set; }
        public double VelocidadeMaximaKTS { get; set; }
        public double VelocidadeAtual {get; set;} = 0;
        public double EixoX {get; set;} = 0;
        public double EixoY {get; set;} = 0;
        public double EixoZ {get; set;} = 0;

        public abstract void RolarDireita(double grausPM); // graus por minuto seria o sinal recebido do manche, ou do piloto automatico, de acordo com o movimento feito pelo piloto ou solicitado pelo PA
        public abstract void RolarEsquerda(double grausPM);
        public abstract void GuinarDireita(double grausPM);
        public abstract void GuinarEsquerda(double grausPM);
        public abstract void SubirNariz(double grausPM);
        public abstract void DescerNariz(double grausPM);
        public abstract void Acelerar(double porcentagem); // porcentagem seria porcentagem da potencia, recebida da manete de aceleracao
        public abstract void Freiar(double porcentagem);


    }
}