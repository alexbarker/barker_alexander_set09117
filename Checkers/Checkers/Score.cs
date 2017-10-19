﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Score
    {
        public void SetScores()
        {
            Console.SetCursorPosition(104, 7);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  .oooo.     .oooo.  ");
            Console.SetCursorPosition(104, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" d8P'`Y8b   d8P'`Y8b ");
            Console.SetCursorPosition(104, 9);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("888    888 888    888");
            Console.SetCursorPosition(104, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("888    888 888    888");
            Console.SetCursorPosition(104, 11);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("888    888 888    888");
            Console.SetCursorPosition(104, 12);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("`88b  d88' `88b  d88'");
            Console.SetCursorPosition(104, 13);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" `Y8bd8P'   `Y8bd8P' ");

            Console.SetCursorPosition(104, 18);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  .oooo.     .oooo.  ");
            Console.SetCursorPosition(104, 19);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" d8P'`Y8b   d8P'`Y8b ");
            Console.SetCursorPosition(104, 20);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("888    888 888    888");
            Console.SetCursorPosition(104, 21);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("888    888 888    888");
            Console.SetCursorPosition(104, 22);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("888    888 888    888");
            Console.SetCursorPosition(104, 23);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("`88b  d88' `88b  d88'");
            Console.SetCursorPosition(104, 24);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" `Y8bd8P'   `Y8bd8P' ");
        }

        public void SetScores2()
        {
            Console.SetCursorPosition(104, 7);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("     .o     .oooo.   ");
            Console.SetCursorPosition(104, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   o888   .dP\"\"Y88b  ");
            Console.SetCursorPosition(104, 9);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    888         ]8P' ");
            Console.SetCursorPosition(104, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    888       .d8P'  ");
            Console.SetCursorPosition(104, 11);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    888     .dP'     ");
            Console.SetCursorPosition(104, 12);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    888   .oP     .o ");
            Console.SetCursorPosition(104, 13);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   o888o  8888888888 ");

            Console.SetCursorPosition(104, 18);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  .oooo.    ooooooooo");
            Console.SetCursorPosition(104, 19);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" d8P'`Y8b  d\"\"\"\"\"\"\"8'");
            Console.SetCursorPosition(104, 20);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("888    888       .8' ");
            Console.SetCursorPosition(104, 21);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("888    888      .8'  ");
            Console.SetCursorPosition(104, 22);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("888    888     .8'   ");
            Console.SetCursorPosition(104, 23);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("`88b  d88'    .8'    ");
            Console.SetCursorPosition(104, 24);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" `Y8bd8P'    .8'     ");
        }

        public void ClearPlayerOneScores()
        {
            Console.SetCursorPosition(104, 7);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 8);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 9);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 10);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 11);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 12);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 13);
            Console.Write("                     ");
        }

        public void ClearPlayerTwoScores()
        {
            Console.SetCursorPosition(104, 18);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 19);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 20);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 21);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 22);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 23);
            Console.Write("                     ");
            Console.SetCursorPosition(104, 24);
            Console.Write("                     ");
        }

        /*
            "  .oooo.     .oooo.  ");
            " d8P'`Y8b   d8P'`Y8b ");
            "888    888 888    888");
            "888    888 888    888");
            "888    888 888    888");
            "`88b  d88' `88b  d88'");
            " `Y8bd8P'   `Y8bd8P' ");

            "  .oooo.       .o    ");
            " d8P'`Y8b    o888    ");
            "888    888    888    ");
            "888    888    888    ");
            "888    888    888    ");
            "`88b  d88'    888    ");
            " `Y8bd8P'    o888o   ");

            "  .oooo.     .oooo.  ");
            " d8P'`Y8b  .dP\"\"Y88b ");
            "888    888       ]8P'");
            "888    888     .d8P' ");
            "888    888   .dP'    ");
            "`88b  d88' .oP     .o");
            " `Y8bd8P'  8888888888");

            "  .oooo.     .oooo.  ");
            " d8P'`Y8b  .dP\"\"Y88b ");
            "888    888       ]8P'");
            "888    888     <88b. ");
            "888    888      `88b.");
            "`88b  d88' o.   .88P ");
            " `Y8bd8P'  `8bd88P'  ");

            "  .oooo.         .o  ");
            " d8P'`Y8b      .d88  ");
            "888    888   .d'888  ");
            "888    888 .d'  888  ");
            "888    888 88ooo888oo");
            "`88b  d88'      888  ");
            " `Y8bd8P'      o888o ");

            "  .oooo.     oooooooo");
            " d8P'`Y8b   dP\"\"\"\"\"\"\"");
            "888    888 d88888b.  ");
            "888    888     `Y88b ");
            "888    888       ]88 ");
            "`88b  d88' o.   .88P ");
            " `Y8bd8P'  `8bd88P'  ");

            "  .oooo.       .ooo  ");
            " d8P'`Y8b    .88'    ");
            "888    888  d88'     ");
            "888    888 d888P\"Ybo.");
            "888    888 Y88[   ]88");
            "`88b  d88' `Y88   88P");
            " `Y8bd8P'   `88bod8' ");

            "  .oooo.    ooooooooo");
            " d8P'`Y8b  d\"\"\"\"\"\"\"8'");
            "888    888       .8' ");
            "888    888      .8'  ");
            "888    888     .8'   ");
            "`88b  d88'    .8'    ");
            " `Y8bd8P'    .8'     ");

            "  .oooo.    .ooooo.  ");
            " d8P'`Y8b  d88'   `8.");
            "888    888 Y88..  .8'");
            "888    888  `88888b. ");
            "888    888 .8'  ``88b");
            "`88b  d88' `8.   .88P");
            " `Y8bd8P'   `boood8' ");

            "  .oooo.    .ooooo.  ");
            " d8P'`Y8b  888' `Y88.");
            "888    888 888    888");
            "888    888  `Vbood888");
            "888    888       888'");
            "`88b  d88'     .88P' ");
            " `Y8bd8P'    .oP'    ");

            "     .o     .oooo.   ");
            "   o888    d8P'`Y8b  ");
            "    888   888    888 ");
            "    888   888    888 ");
            "    888   888    888 ");
            "    888   `88b  d88' ");
            "   o888o   `Y8bd8P'  ");

            "     .o       .o     ");
            "   o888     o888     ");
            "    888      888     ");
            "    888      888     ");
            "    888      888     ");
            "    888      888     ");
            "   o888o    o888o    ");

            "     .o     .oooo.   ");
            "   o888   .dP\"\"Y88b  ");
            "    888         ]8P' ");
            "    888       .d8P'  ");
            "    888     .dP'     ");
            "    888   .oP     .o ");
            "   o888o  8888888888 ");
        
        */

        /*
        #    .oooo.         
        #   d8P'`Y8b        
        #  888    888       
        #  888    888       
        #  888    888       
        #  `88b  d88'       
        #   `Y8bd8P'        

        #    .o             
        #  o888             
        #   888             
        #   888             
        #   888             
        #   888             
        #  o888o            

        #    .oooo.         
        #  .dP""Y88b        
        #        ]8P'       
        #      .d8P'        
        #    .dP'           
        #  .oP     .o       
        #  8888888888    
        
        #    .oooo.         
        #  .dP""Y88b        
        #        ]8P'       
        #      <88b.        
        #       `88b.       
        #  o.   .88P        
        #  `8bd88P'         

        #        .o         
        #      .d88         
        #    .d'888         
        #  .d'  888         
        #  88ooo888oo       
        #       888         
        #      o888o        
        
        #    oooooooo       
        #   dP"""""""       
        #  d88888b.         
        #      `Y88b        
        #        ]88        
        #  o.   .88P        
        #  `8bd88P'          

        #      .ooo         
        #    .88'           
        #   d88'            
        #  d888P"Ybo.       
        #  Y88[   ]88       
        #  `Y88   88P       
        #   `88bod8'        

        #   ooooooooo       
        #  d"""""""8'       
        #        .8'        
        #       .8'         
        #      .8'          
        #     .8'           
        #    .8'            

        #   .ooooo.         
        #  d88'   `8.       
        #  Y88..  .8'       
        #   `88888b.        
        #  .8'  ``88b       
        #  `8.   .88P       
        #   `boood8'        

        #   .ooooo.         
        #  888' `Y88.       
        #  888    888       
        #   `Vbood888       
        #        888'       
        #      .88P'        
        #    .oP'           

        #    .o    .oooo.   
        #  o888   d8P'`Y8b  
        #   888  888    888 
        #   888  888    888 
        #   888  888    888 
        #   888  `88b  d88' 
        #  o888o  `Y8bd8P'  
         
        #    .o    .o       
        #  o888  o888       
        #   888   888       
        #   888   888       
        #   888   888       
        #   888   888       
        #  o888o o888o      
         
        #    .o    .oooo.   
        #  o888  .dP""Y88b  
        #   888        ]8P' 
        #   888      .d8P'  
        #   888    .dP'     
        #   888  .oP     .o 
        #  o888o 8888888888  
        */
    }
}
