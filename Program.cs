using System;
using projectTest.Util;
using projectTest.App;

namespace projectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new CommandEngine();
            commands.init( 10 );

            Printer.DrawTitle( "TV Show Chanllenge C#" );

            string command = ""; 

            do {
                Printer.PrintMenu();
                command = "";

                Printer.DrawTitle("Put your option:");
                command = System.Console.ReadLine();

                int position = command.IndexOf("list");
                
                if (position >= 0) {
                    commands.PrintTvShows();
                    continue;
                } // end if

                position = command.IndexOf("favorites");
                
                if (position >= 0) {
                    commands.PrintTvShowsFav();
                    continue;
                } // end if

                position = command.IndexOf("exit");
                
                if (position >= 0) {
                    System.Console.WriteLine("Bye!");
                    break;
                } // end if
                    
                int id;
                bool isNumeric = int.TryParse( command, out id);
                if( !isNumeric ) {
                    System.Console.WriteLine("Incorrect command");
                    continue;
                } // end if

                commands.CheckFav( id );

            } while( true );
        }
    }
}
