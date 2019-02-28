using System;



    class Dados
    {
        public string  color;
        public int numero;
        public Dados(int numero, string color) //uso de la palabra this
        {
            this.numero=numero;
            this.color=color;
        }
        public Dados() //sobrecargado
        {
            numero=1;
            color="rojo";
        }
        
        /*public static bool operator < (Dados n1, Dados n2) /*menor 
        {
            if (n1.Dados<n2.Dados)
           {
               return true;
            }
            else 
            {
                return false;
            }
            
        }*/ 
        
         public static Dados operator > (int n1, int n2)
         {
             
            if (nu1.Dados>nu2.Dados)
                return true;
            else 
                return false;
        
         }
         /* 
         public static Dados operator > (int n1, int n2) 
        {
            Dados resultado=new;
            if (n1.Dados>n2.Dados)
            {
                resultado=n1.Dados;
            }
            else 
            {
                resultado=n2.Dados;
            }
            return resultado;
        } */ 
        public void Imprime()
        {
         Console.WriteLine("Mayor",numero);
        }
        public void Imprime(string s)  //sobrecargado
        {
            Console.WriteLine(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dados no1=new Dados(5);  
            Dados no2=new Dados(1);  
            Dados no3=new Dados(6);  
            
         
            if(n1<n2)
            Imprime();
            
        }
    }

