using System;
using SinglenonLib.singletonNormal;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            Singletoncls fromTeachaer =  Singletoncls.GetSingleton;
            fromTeachaer.InstanceMessage("From Tacher");
            
            Singletoncls fromStudent =  Singletoncls.GetSingleton;
            fromStudent.InstanceMessage("From Student");
            Console.ReadLine();

        }
    }
}
