using System;
namespace SinglenonLib.singletonNormal
{
    public class Singletoncls
    {
        public static int counter=0;
        public static Singletoncls instance=null;
        public static Singletoncls GetSingleton {  // meka field ekak 
            get {
                    if(instance==null){
                        instance=new Singletoncls();
                    }

                    else{
                        return instance;
                    }
                    return instance;
            }
        }

        private Singletoncls() // console kiyana eka ganne using system kiyana eken

        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());  
        }

        public  void InstanceMessage(string st){
            Console.WriteLine(st);
        }

    }
}