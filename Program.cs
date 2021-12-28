﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceRest_097_Faysal_Fadel_Maulana;

namespace ServerConfigRest_097_Faysal_Fadel_Maulana
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObj = null;

            try
            {
                hostObj = new ServiceHost(typeof(TI_UMY));
                hostObj.Open();
                Console.WriteLine("Server Config is Ready ....");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception e)
            {
                hostObj = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
