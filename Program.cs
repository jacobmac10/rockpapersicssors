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

        /// <summary>
        /// se selecciona opcion aleatoria entre 1,2 o 3
        /// </summary>
        /// <returns>la opcion seleccionada, 1-piedra, 2-papel, 3-tijera</returns>

        static int SelectRandomOption()
        {
          
            Random rnd = new Random();
            int option  = rnd.Next(1, 4);  // 1,2 0 3
            return option;
            
        }
        static void checkWinner(int option, int gameOption)
        {
          // 1: piedra
            // 2: papel
            // 3: tijera
            switch (option)
            {
                case 1:
                    Console.WriteLine("Jugador: Piedra");
                    break;
                case 2:
                    Console.WriteLine("Jugador: Papel");
                    break;
                case 3: 
                    Console.WriteLine("Jugador: Tijera");
                    break;
                
            }

            switch (gameOption)
            {
                case 1:
                    Console.WriteLine("AI: Piedra");
                    break;
                case 2:
                    Console.WriteLine("AI: Papel");
                    break;
                case 3: 
                    Console.WriteLine("AI: Tijera");
                    break;
                
            }

            //piedra < tijera < papel < piedra
            // 1 < 2 < 3 < 1

            if (option == 1) // Jugador: Piedra
            {
                switch (gameOption)
                {
                    case 1: // AI: Piedra
                        Console.WriteLine("Eempate");
                        break;
                    case 2: // AI: Papel
                        Console.WriteLine("Gana AI");
                        break;
                    case 3: // AI: Tijera
                        Console.WriteLine("Gana Jugador");
                        break;
                    
                }
            }
            else if (option == 2) // Jugador: Papel
            {
                switch (gameOption)
                {
                    case 1: // AI: Piedra
                        Console.WriteLine("Gana Jugador");
                        break;
                    case 2: // AI: Papel
                        Console.WriteLine("Empate");
                        break;
                    case 3: // AI: Tijera
                        Console.WriteLine("Gana AI");
                        break;
                    
                }
            }
            else if (option == 3) // Jugador: Tijera
            {
                switch (gameOption)
                {
                    case 1: // AI: Piedra
                        Console.WriteLine("Gana AI");
                        break;
                    case 2: // AI: Papel
                        Console.WriteLine("Gana Jugador");
                        break;
                    case 3: // AI: Tijera
                        Console.WriteLine("Empate");
                        break;
                    
                }
            }

        }
        static void Main(string[] args)
        {

            // selecciona la opcion para jugar
            // 1: piedra
            // 2: papel
            // 3: tijera
            // piedra < papel < tijera < piedra
            // 1 < 2 < 3 < 1
            int option = selectOption();
            Console.WriteLine("Opcion seleccionada:" + option);
            //TODO: La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)
            int gameOption = SelectRandomOption();
            Console.WriteLine("valor seleccionado aleatoriamente:" + gameOption);


            //TODO: Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador
            checkWinner(option, gameOption);

           // piedra > tijera > papel > piedra 

            //TODO [cancelado por falta de tiempo]: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora) 

        }
    }
}
