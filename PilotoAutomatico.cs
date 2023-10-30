namespace PilotoAutomatico
{
    class PilotoAutomatico : INavegacao
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double AltitudeFT { get; set; }
        Aeronave Aeronave { get; set; }

        

        public PilotoAutomatico(Aeronave aeronave)
        {
            Aeronave = aeronave;
            Sensor sensorLat = new(-90.0, 90.0);
            Sensor sensorLon = new(-180.0, 180.0);
            Sensor sensorAlt = new(-1412.0, aeronave.AltitudeMaximaFT);
            Sensor sensorRoll = new(-180.0, 180.0);
            Sensor sensorPitch = new(-180.0, 180.0);
            Sensor sensorYaw = new(0.0, 359.9999);
            Latitude = sensorLat.ObterPosicaoAtual();
            Longitude = sensorLon.ObterPosicaoAtual();
            AltitudeFT = sensorAlt.ObterPosicaoAtual();
            Aeronave.Roll_EixoX = sensorRoll.ObterPosicaoAtual();
            Aeronave.Pitch_EixoY = sensorPitch.ObterPosicaoAtual();
            Aeronave.Yaw_EixoZ = sensorYaw.ObterPosicaoAtual();

        }

        public void Subir(double altitudeSelecionada)
        {
            double novaAltitude = altitudeSelecionada;

            if (novaAltitude > Aeronave.AltitudeMaximaFT)
            {
                Console.WriteLine($"Altitude selecionada maior que teto operacional. Ajustando para {Aeronave.AltitudeMaximaFT:f2} p�s");
                novaAltitude = Aeronave.AltitudeMaximaFT;
            }

            if (Aeronave.VelocidadeAtual > 60 && Aeronave.AltitudeAtual < novaAltitude)
            {
                Console.WriteLine($"Altitude selecionada: {novaAltitude:f2} p�s");
                Console.WriteLine($"Altitude inicial: {Aeronave.AltitudeAtual:f2} p�s");
                Aeronave.Pitch_EixoY = 8.0;
                Console.WriteLine($"Novo �ngulo de ataque: {Aeronave.Pitch_EixoY}�");
                Console.WriteLine($"{Aeronave.Modelo} subindo");
                Thread.Sleep(2500);
                Aeronave.Pitch_EixoY = 0.0;
                Console.WriteLine($"Novo �ngulo de ataque: {Aeronave.Pitch_EixoY}�. Aeronave nivelada.");
                Aeronave.AltitudeAtual = novaAltitude;
                Console.WriteLine($"Nova altitude � de {Aeronave.AltitudeAtual} p�s");
            }
            else
            {
                if (Aeronave.AltitudeAtual > novaAltitude)
                {
                    Console.WriteLine("Imposs�vel subir. Altitude selecionada mais baixa que a atual!");
                }
                else
                {
                    Console.WriteLine("Imposs�vel subir. Velocidade baixa!");
                }
            }
        }
        public void Subir(int pesPorMinuto, int minutos)
        {
            double novaAltitude = 0;

            if (Aeronave.VelocidadeAtual > 60)
            {
                Console.WriteLine($"Altitude inicial: {Aeronave.AltitudeAtual}");
                novaAltitude = Aeronave.AltitudeAtual + (pesPorMinuto * minutos);

                if (novaAltitude > Aeronave.AltitudeMaximaFT)
                {
                    Console.WriteLine($"Razao de subida selecionada gera altitude maior que teto operacional. Ajustando para nivelar em {Aeronave.AltitudeMaximaFT:f2} p�s");
                    novaAltitude = Aeronave.AltitudeMaximaFT;
                    Aeronave.AltitudeAtual = novaAltitude;
                }

                // calculos para angulo de ataque, considerando velocidade, peso, etc.
                // para exemplo, estou usando 10�, mas seria variavel de acordo com os calculos
                Aeronave.Pitch_EixoY = 10.0;
                Console.WriteLine($"Novo �ngulo de ataque: {Aeronave.Pitch_EixoY}�");
                Console.WriteLine($"{Aeronave.Modelo} subindo");
                Thread.Sleep(2500);

                Aeronave.Pitch_EixoY = 0.0;
                Console.WriteLine($"Novo �ngulo de ataque: {Aeronave.Pitch_EixoY}�. Aeronave nivelada.");
                Console.WriteLine($"Nova altitude � de {Aeronave.AltitudeAtual} p�s ap�s {minutos} minutos");
            }

            else
            {
                Console.WriteLine("Imposs�vel subir. Velocidade baixa!");
            }
        }
        public void Descer(double altitudeSelecionada)
        {
            double novaAltitude = altitudeSelecionada;

            if (novaAltitude < 0)
            {
                Console.WriteLine($"Atencao! Altitude selecionada resulta em descida abaixo do n�vel do mar. Ajustando nova altitude para 500 p�s!");
                novaAltitude = Aeronave.AltitudeMaximaFT;
            }

            if (Aeronave.VelocidadeAtual > 60 && Aeronave.AltitudeAtual > novaAltitude)
            {
                Console.WriteLine($"Altitude selecionada: {novaAltitude:f2} p�s");
                Console.WriteLine($"Altitude inicial: {Aeronave.AltitudeAtual:f2} p�s");
                Aeronave.Pitch_EixoY = -1.5;
                Console.WriteLine($"Novo �ngulo de ataque: {Aeronave.Pitch_EixoY}�");
                Console.WriteLine($"{Aeronave.Modelo} descendo");
                Thread.Sleep(2500);
                Aeronave.Pitch_EixoY = 0.0;
                Console.WriteLine($"Novo �ngulo de ataque: {Aeronave.Pitch_EixoY}�. Aeronave nivelada.");
                Aeronave.AltitudeAtual = novaAltitude;
                Console.WriteLine($"Nova altitude � de {Aeronave.AltitudeAtual} p�s");
            }
            else
            {
                if (Aeronave.AltitudeAtual < novaAltitude)
                {
                    Console.WriteLine("Imposs�vel descer. Altitude selecionada maior que a atual!");
                }
                else
                {
                    Console.WriteLine("Atencao! Imposs�vel ativar modo de descida. Velocidade baixa!");
                }
            }

        }
        public void Descer(int pesPorMinuto, int minutos)
        {

            double novaAltitude = 0;

            if (Aeronave.VelocidadeAtual > 60)
            {
                Console.WriteLine($"Altitude inicial: {Aeronave.AltitudeAtual}");
                novaAltitude = Aeronave.AltitudeAtual - (pesPorMinuto * minutos);
                if (novaAltitude < 0)
                {
                    Console.WriteLine("Atencao! Razao de descida selecionada resulta em descida abaixo do n�vel do mar. Ajustando descida para parar em 500 p�s!");
                    novaAltitude = 500;
                }
                // calculos para angulo de ataque, considerando velocidade, peso, etc.
                // para exemplo, estou usando -1�, mas seria variavel de acordo com os calculos
                Aeronave.AltitudeAtual = novaAltitude;
                Aeronave.Pitch_EixoY = -1.0;
                Console.WriteLine($"Novo �ngulo de ataque: {Aeronave.Pitch_EixoY}�");
                Console.WriteLine($"{Aeronave.Modelo} descendo");
                Thread.Sleep(2500);
                Aeronave.Pitch_EixoY = 0.0;
                Console.WriteLine($"Novo �ngulo de ataque: {Aeronave.Pitch_EixoY}�. Aeronave nivelada.");
                Console.WriteLine($"Nova altitude � de {Aeronave.AltitudeAtual} p�s ap�s {minutos} minutos");
            }

            else
            {
                Console.WriteLine("Alerta! Velocidade baixa! Imposs�vel ativar modo descida!");
            }

        }
        public void Curvar(int proa)
        {
            if (proa >= 0 && proa < 360)
            {
                Aeronave.Yaw_EixoZ = proa;
                Console.WriteLine($"Aeronave curvou para a proa {Aeronave.Yaw_EixoZ}");
            }
        }
        public void Acelerar(double porcentagem)
        {
            
            Aeronave.Acelerar(porcentagem);
        }

        public void Freiar(double porcentagem)
        {            
            Aeronave.Freiar(porcentagem);
        }
    }
        
}