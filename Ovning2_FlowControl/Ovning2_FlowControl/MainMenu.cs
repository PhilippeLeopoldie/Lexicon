﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2_FlowControl;

internal static class MainMenu
{
    static Dictionary<string,string> menu = new Dictionary<string, string>
    {
        {"1","Youth or Senior Citizen" },
        {"2","Repeat Ten Times" },
        {"3","The Third Word" },
        {"0","Exit" }
    };
    
    internal static void ShowMainMenu()
    {
        Console.WriteLine("------- Main Menu -------");
        Console.WriteLine("Choose a function :");

        foreach (var option in menu)
        {
            Console.WriteLine($"Enter {option.Key} for {option.Value}");
        }

    }

    
}
