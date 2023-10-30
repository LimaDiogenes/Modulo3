namespace PilotoAutomatico
{
    internal interface IAeronave
    {
        string Fabricante { get; set; }
        string Modelo { get; set; }        
        double VelocidadeAtual {get; set;}
        double EixoX {get; set;}  // rolagem
        double EixoY {get; set;} // arfagem 
        double EixoZ {get; set;} // guinada 

        void RolarDireita(double grausPM);
        void RolarEsquerda(double grausPM);
        void GuinarDireita(double grausPM);
        void GuinarEsquerda(double grausPM);
        void SubirNariz(double grausPM);
        void DescerNariz(double grausPM);
        void Acelerar(double porcentagem);
        void Freiar(double porcentagem);
        


    }
}