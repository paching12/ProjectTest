using System;

namespace projectTest.Util
{
    public static class Printer
    {

        /*
        *   This method prints lines with a specific size
        *   @params int size
        */
        public static void DrawLine( int size ) {
            System.Console.WriteLine();
            System.Console.WriteLine( " ".PadRight( size, '=' ) );
            System.Console.WriteLine();
        }

         /*
        *   This method prints titles
        *   @params string title
        */
        public static void DrawTitle( string title ) {
            int size = title.Length + 2;
            DrawLine( size );
            System.Console.WriteLine( $"| {title}|" );
            DrawLine( size );
        }

         /*
        *   This method prints the menu
        *   @params void
        */
        internal static void PrintMenu()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Basic Commands:");
            System.Console.WriteLine("list - Show the TV shows");
            System.Console.WriteLine("favorites - Show the Favorite TV shows");
            System.Console.WriteLine("Introduce id - Choose favorite/unfavorite TV Show");
            System.Console.WriteLine("exit - Finish the program");
        }
    }
}