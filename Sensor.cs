
namespace PilotoAutomatico
{
    /// <summary>
    /// "simula" dados gerados por um sensor físico
    /// </summary>
    internal class Sensor
    {
        private double Posicao { get; set; }
        private double Max {  get; set; }
        private double Min { get; set; }
        /// <summary>
        /// retorna a posicao atual do objeto (aronave)
        /// criar um para cada eixo da aeronave e 1 para cada direcao        
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        internal Sensor(double min, double max) 
        { 
            Max = max; 
            Min = min;
            Posicao = ObterPosicaoAtual();    
        }

        internal double ObterPosicaoAtual()
        {
            Random random = new Random();
            Posicao = Min + (random.NextDouble() * (Max - Min));
            return Posicao;
        }

        /// <summary>
        /// Utilizar para passar novo valor para o objeto
        /// </summary>
        /// <param name="posicao"></param>
        /// <returns></returns>
        internal double AtualizarPosicao(double posicao)
        {
            return Posicao = posicao;
        }

       
    }
}
