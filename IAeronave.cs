namespace PilotoAutomatico
{
    internal interface IAeronave
    {
        string TipoTremDePouso { get; set; }
        int QtdePassageiros { get; set; }
        int QtdeTripulantes { get; set; }
        double PesoVazioKG { get; set; }
        double PesoMaximoKG { get; set; }
        int QtdeMotores { get; set; }
        string TipoMotores { get; set; }
        string TipoCombustivel { get; set; }
        double CapacidadeCombustivelKG { get; set; }
        string Fabricante { get; set; }
        string Modelo { get; set; }        
        double VelocidadeAtual {get; set;}
        double VelocidadeMaximaKTS { get; set;}
        double AltitudeMaximaFT { get; set;}
        double AltitudeAtual { get; set; }
        double Roll_EixoX {get; set;}  // rolagem (bank angle)
        double Pitch_EixoY {get; set;}  // arfagem (angle of attack)
        double Yaw_EixoZ {get; set;}  // guinada (heading)               


    }
}