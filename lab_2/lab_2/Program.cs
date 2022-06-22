using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Serialization;
using System.Text.Json;

namespace lab_2
{


    class Program
    {
        static void Main(string[] args)
        {
            
            Kit ryadok = new Kit();
            
            ryadok.GetInfo();
            Console.WriteLine("");
         
            var RyadokToJson = DeserializeObject(); 
            Console.WriteLine(ryadok.Concatenatsiya());
            Console.WriteLine(ryadok.Vyrizannya());

            ryadok.Rivnist();
            ryadok.NeRivnist();
            ryadok.Menshe();
            ryadok.Bilshe(); 

            SaveToJson(ryadok);
            

        }

        static void SaveToJson(Kit json)
        {
            var ObjectJSON = JsonConvert.SerializeObject(json);
            File.WriteAllText("C:/1/lab_2.txt", ObjectJSON);
        }

        static  Kit DeserializeObject()
        {
            string filePath = @"C:/1/lab_2.json";
            if (File.Exists(filePath))
            {
                Console.WriteLine("JSON file found");
                var DeserializationObj = JsonConvert.DeserializeObject<Kit>(File.ReadAllText(filePath));

                return DeserializationObj;
            }
            else
            {
                return null;
            }
            Console.ReadLine();
        }


    }
    
}
