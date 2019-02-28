using System;



    class Dulces
    {
        public int codigo,cantidad;
        public string nombre;

        public Dulces(int codigo,int cantidad,string nombre)
        {
            this.cantidad=cantidad;
            this.codigo=codigo;
            this.nombre=nombre;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombre: {0} Cantidad:{1}",nombre,cantidad+" \nPAGO:"+ Precio.total(this));
        }
    }
    class Precio
    {
        public int precio;
        public Precio(int precio)
        {
            this.precio=precio;
        }
        public static double total(Dulces d)
        {
            return 12.5* d.cantidad;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dulces c=new Dulces(1254, 3 , "lucas");
            c.Imprimir();
            
        }
    }
