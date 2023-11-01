namespace PilotoAutomatico
{
    internal abstract class Aeronave : IAeronave
    { 
        // info
        public abstract string TipoTremDePouso { get; set; }
        public abstract int QtdePassageiros { get; set; }
        public abstract int QtdeTripulantes { get; set; }
        public abstract double PesoVazioKG {get; set;}
        public abstract double PesoMaximoKG { get; set; }
        public abstract int QtdeMotores { get; set; }
        public abstract string TipoMotores { get; set; }
        public abstract string TipoCombustivel { get; set; }
        public abstract double CapacidadeCombustivelKG { get; set; }         
        public abstract string Fabricante { get; set; }        
        public abstract double VelocidadeMaximaKTS { get; set; }
        public abstract double AltitudeMaximaFT { get; set; }
        public abstract string Modelo { get; set; }

        // dados navegacao
        public abstract double AltitudeAtual { get; set; }
        public abstract double VelocidadeAtual { get; set; }
        public abstract double Roll_EixoX {get; set;}
        public abstract double Pitch_EixoY {get; set;}
        public abstract double Yaw_EixoZ {get; set;}

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