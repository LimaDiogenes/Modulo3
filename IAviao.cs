

namespace PilotoAutomatico
{
    internal interface IAviao
    {
        int QuantidadeAsas { get; set; } 
        bool Flaps { get; set; }
        bool Pressurizado { get; set; }
        string Matricula { get; set; }
    }
}
