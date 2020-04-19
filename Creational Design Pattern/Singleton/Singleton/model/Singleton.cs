using System;

namespace Singleton.model
{
    public class Singleton
    {
        public static int counter=0;
        public static Singleton instance=null;
        public static Singleton GetSingleton {  // meka field ekak 
            get {
                    if(instance==null){
                        instance=new Singleton();
                    }

                    else{
                        return instance;
                    }
                    return instance;
            }
        }

        private Singleton() // console kiyana eka ganne using system kiyana eken

        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());  
        }

        public  void InstanceMessage(string st){
            Console.WriteLine(st);
        }


    }
}