using System;

namespace RockPaperScissors
{
    class Program
    {



        /// <summary>
        /// solicita al usuario una opcion a jugar
        /// </summary>
        /// <returns>la opcion seleccionada, 1-piedra, 2-papel, 3-tijera</returns>
        static int selectOption()
        {
           Console.WriteLine("selecciona la opcion para jugar:");
           Console.WriteLine("1) piedra");
           Console.WriteLine("2) papel");
           Console.WriteLine("3) tijera");

           int option = Convert.ToInt32(Console.ReadLine());
           return option;
        }
        static void Main(string[] args)
        {

            // selecciona la opcion para jugar
            // 1: piedra
            // 2: papel
            // 3: tijera
            int option = selectOption();
            Console.WriteLine("Opcion seleccionada"+ option);
            //TODO: La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)

            //TODO: Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador

            //TODO: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora) 

        }
    }
}
