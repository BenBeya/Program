using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Logo
    {
        public void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(" _____ __  __ _____ ____  ____  _   _ ___    _    _   _ ");
            Console.WriteLine("| ____|  \\/  | ____|  _ \\|  _ \\| | | |_ _|  / \\  | \\ | |");
            Console.WriteLine("|  _| | |\\/| |  _| | |_) | |_) | |_| || |  / _ \\ |  \\| |");
            Console.WriteLine("| |___| |  | | |___|  _ <|  __/|  _  || | / ___ \\| |\\  |");
            Console.WriteLine("|_____|_|  |_|_____|_| \\_\\_|   |_| |_|___/_/   \\_\\_| \\_|");

            Console.ResetColor();
        }
    }
}

