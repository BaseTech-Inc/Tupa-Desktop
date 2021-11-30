
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tupa.Data
{
 
    public class Auxilio
    {   

        public static string classLogo { get; set; } = "logo open";
        public static string classBotao { get; set; } = "bx bx-menu-alt-right";
        public static string classSideBar { get; set; } = "sidebar open";
        

        public static void reduzirMenu()
        {
            if (classBotao == "bx bx-menu-alt-right")
            {
                classBotao = "bx bx-menu";
                classSideBar = "sidebar";
                classLogo = "logo";

            }
            else
            {
                classBotao = "bx bx-menu-alt-right";
                classSideBar = "sidebar open";
                classLogo = "logo open";
            }
        }



 

    }


  
        
   
}

