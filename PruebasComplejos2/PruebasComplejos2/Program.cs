using System;
using System.Collections.Generic;
using Complejos;
namespace PruebasComplejos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Complejos.Complejos uno = new Complejos.Complejos();
            uno.Real = 1;
            uno.Imaginario = 0;
            Complejos.Complejos prueba = new Complejos.Complejos();
            prueba.Real = 2.2;
            prueba.Imaginario = -1.75;
            Complejos.Complejos prueba1 = new Complejos.Complejos();
            prueba1.Real = 0;
            prueba1.Imaginario = -0.156;
            Complejos.Complejos prueba2 = new Complejos.Complejos();
            prueba2.Real = 36.9;
            prueba2.Imaginario = -2.25;

            Complejos.Complejos radicando = new Complejos.Complejos();
            radicando = Complejos.Complejos.PuntoFijoPositivo(prueba);
            Console.WriteLine(radicando.Real);
            Console.WriteLine(radicando.Imaginario);
            Complejos.Complejos.MostrarEnpantallaUnComplejo(radicando);
            Complejos.Complejos origen = new Complejos.Complejos(0, 0);
            List<Complejos.Complejos> julia = new List<Complejos.Complejos>();
            julia = Complejos.Complejos.IteradaInversaPuntoFijoNegativa(prueba);

            List<Complejos.Complejos> julia1 = new List<Complejos.Complejos>();
            julia1 = Complejos.Complejos.IntroduceEltoEnLtcomplejosSiDistanciaMayorP(julia, prueba, 2.27);
            Complejos.Complejos.ImprimeListaComplejos(julia1);


            double distancia1 = Complejos.Complejos.DistanciaEntreComplejos(julia[0], prueba);
            Console.WriteLine(distancia1);



            List<Complejos.Complejos> elementosjulia = new List<Complejos.Complejos>();
            elementosjulia = Complejos.Complejos.IteradaInversaPuntoFijoPositivo(prueba);
            Complejos.Complejos.ImprimeListaComplejos(elementosjulia);


            Complejos.Complejos c = new Complejos.Complejos();
            c = prueba;
            double distancia = 3;
            List<Complejos.Complejos> puntosJulia = new List<Complejos.Complejos>();
            puntosJulia.Add(c);
            Console.WriteLine("prueba1");
            Complejos.Complejos.ImprimeListaComplejos(puntosJulia);
            Complejos.Complejos puntoFijoPositivo = new Complejos.Complejos();
            List<Complejos.Complejos> juliaPuntoFijoPos = new List<Complejos.Complejos>();
            juliaPuntoFijoPos = Complejos.Complejos.IteradaInversaPuntoFijoPositivo(c);
            if (Complejos.Complejos.CompruebaDistaciaAListaMayorP(puntosJulia, juliaPuntoFijoPos[0], distancia))
            {
                puntosJulia.Add(juliaPuntoFijoPos[0]);
            }
            if (Complejos.Complejos.CompruebaDistaciaAListaMayorP(puntosJulia, juliaPuntoFijoPos[1], distancia))
            {
                puntosJulia.Add(juliaPuntoFijoPos[1]);
            }

            Console.WriteLine("prueba2");
            Complejos.Complejos.ImprimeListaComplejos(puntosJulia);
            Console.WriteLine("prueba3");
            List<Complejos.Complejos> pruebaLista2 = new List<Complejos.Complejos>();
            Console.WriteLine("prueba4");
            pruebaLista2 = Complejos.Complejos.IteradaConDistanciaFijoPositivo(prueba, 0.4);
            Complejos.Complejos.ImprimeListaComplejos(pruebaLista2);
            Boolean pruebabol = Complejos.Complejos.CompruebaDistaciaAListaMayorP(pruebaLista2, prueba, 2);
            Console.WriteLine(pruebabol);

            Console.WriteLine("prueba addrange");
            List<Complejos.Complejos> pruebalista5 = new List<Complejos.Complejos>();
            pruebalista5.AddRange(puntosJulia);
            Console.WriteLine("prueba addrange");
            Complejos.Complejos.ImprimeListaComplejos(puntosJulia);
            Console.WriteLine("prueba addrange");
            Complejos.Complejos.ImprimeListaComplejos(pruebalista5);
            pruebalista5.AddRange(pruebaLista2);
            Console.WriteLine("prueba addrange");
            Complejos.Complejos.ImprimeListaComplejos(pruebaLista2);
            Console.WriteLine("prueba addrange");
            Complejos.Complejos.ImprimeListaComplejos(pruebalista5);

            Console.WriteLine("prueba iteradas");
            List<Complejos.Complejos> pruebaiteradas = new List<Complejos.Complejos>();
            int i = Complejos.Complejos.CantidadListaComplejos(pruebalista5);
            Console.WriteLine(i);
            pruebaiteradas = Complejos.Complejos.IteradaInversaPuntoFijoPositivo(prueba);
            Complejos.Complejos prueba6 = new Complejos.Complejos();
            prueba6 = Complejos.Complejos.PuntoFijoPositivo(prueba);
            //prueba2 = Complejos.Complejos.PuntoFijoPositivo(prueba1);
            //pruebaiteradas = Complejos.Complejos.IteradasInversasConDistanciaFijoPositivo(prueba1, 0.00015, 95);
            //Complejos.Complejos.ImprimeListaComplejos(pruebaiteradas);
            Complejos.Complejos.MostrarEnpantallaUnComplejo(prueba6);



            Console.WriteLine("prueba definitiva");
            List<Complejos.Complejos> listaprueba = new List<Complejos.Complejos>();
            Complejos.Complejos jul = new Complejos.Complejos(0, -0.156);
            listaprueba = Complejos.Complejos.IteradasInversasConDistanciaFijoPositivo(prueba, 0.00007, 5);
            Complejos.Complejos.ImprimeListaComplejos(listaprueba);
            Console.WriteLine(listaprueba.Count);

            


            Console.WriteLine("prueba puntodijo");
            List<Complejos.Complejos> listaprueba1 = new List<Complejos.Complejos>();
            //listaprueba1 = Complejos.Escaneado.PasoMalla(origen,10,5,5);
            //Complejos.Complejos.ImprimeListaComplejos(listaprueba1);


            //listaprueba = Complejos.Complejos.IteradasInversasConDistanciaFijoPositivo1(prueba, 0.00007, 5);
            //Complejos.Complejos.ImprimeListaComplejos(listaprueba);

            int dividi = 10;
            double p=Convert.ToDouble(dividi);
            Console.WriteLine(dividi);
            double cinco = 5;
            for (int v = 0; v < 5; v++)
            {
                cinco += 1 / p;
                Console.WriteLine(cinco);
            }

            Console.WriteLine("paso de malla");
            List<Complejos.Complejos> pruebamalla = new List<Complejos.Complejos>();
            pruebamalla = Complejos.Escaneado.PasoMalla(origen, 10, 5, 5);
            Complejos.Complejos.ImprimeListaComplejos(pruebamalla);
            Console.WriteLine(pruebamalla.Count);

            Complejos.Complejos prubajiter = new Complejos.Complejos();
            prubajiter = Complejos.Complejos.JuliaIterada(prueba, prueba1, 3);
            Complejos.Complejos.MostrarEnpantallaUnComplejo(prubajiter);


            Console.WriteLine("metodoescaneado");
            List<Complejos.Complejos> pruebamEsca = new List<Complejos.Complejos>();
            pruebamEsca = Complejos.Escaneado.MallaJulia(origen, 2);
            
            Complejos.Complejos.ImprimeListaComplejos(pruebamEsca);
            Console.WriteLine(pruebamEsca.Count);

            Complejos.Complejos tres = new Complejos.Complejos(3, 3);
            Console.WriteLine(Complejos.Complejos.ModuloComplejo(tres));

            Complejos.Complejos prueba3 = new Complejos.Complejos(0.8, 0.6);
            Console.WriteLine("Escaneado1");
            List<Complejos.Complejos> escaneado1 = new List<Complejos.Complejos>();
            escaneado1 = Complejos.Escaneado.MetodoEscaneado1(prueba3, 25, 1000, 100);
            Complejos.Complejos.ImprimeListaComplejos(escaneado1);
            Console.WriteLine(escaneado1.Count);
        }
    }
}
