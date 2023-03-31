﻿using ConsoleApp4.Models;
using ConsoleApp4.DAO;
using System.Runtime.CompilerServices;

CrudProducto1 CrudProducto = new CrudProducto1();
Producto1 Producto = new Producto1();

bool continuar = true;
while (continuar)
{

    Console.WriteLine("Menu");
    Console.WriteLine("pulse 1 para insertar un nuevo producto");
    Console.WriteLine("pulse 2 para Actuliazar un producto");
    Console.WriteLine("pulse 3 para eliminar un producto");
    Console.WriteLine("pulse 4 para listar los productos");

    var Menu = Convert.ToInt32(Console.ReadLine());

    switch (Menu)
    {

        case 1:
            int bucle = 1;
            while (bucle == 1)
            {
                Console.WriteLine("ingresa el nombre del producto");
                Producto.Nombre = Console.ReadLine();
                Console.WriteLine("ingrese la descripcion del producto");
                Producto.Descripcion = Console.ReadLine();
                Console.WriteLine("ingrese el precio del producto 00.00");
                Producto.Precio = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad en stock");
                Producto.Stock = Convert.ToInt32(Console.ReadLine());
                CrudProducto.AgregarProducto(Producto);
                Console.WriteLine("El producto se agrego correctamente ");
                Console.WriteLine("pulsa 1 para agregar otro producto");
                Console.WriteLine("pulsa 0 para salir");
                bucle = Convert.ToInt32(Console.ReadLine());
            }
            break;

        case 2:
            Console.WriteLine("actualizar datos");
            Console.WriteLine("ingrese el ID del producto a actualizar");
            var productoIndividual = CrudProducto.ProductoIndividual(Convert.ToInt32(Console.ReadLine()));
            if (productoIndividual == null)
            {
                Console.WriteLine("el producto no existe no extiste");
            }
            else
            {

                Console.WriteLine($"Nombre {productoIndividual.Nombre},descripcion {productoIndividual.Descripcion}, Precio {productoIndividual.Precio}, Stock{productoIndividual.Stock}");
                Console.WriteLine("para actualizar nombre coloca 1");
                Console.WriteLine("para actualizar la descripcion coloca el numero 2 ");
                Console.WriteLine("para actualizar el precio presione 3");
                Console.WriteLine("para actualizar la catidad en stock presione 4");

                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    Console.WriteLine("ingrese el nombre");
                    productoIndividual.Nombre = Console.ReadLine();
                }
                if (Lector == 2)
                {
                    Console.WriteLine("ingrese la descripcion");
                    productoIndividual.Descripcion = Console.ReadLine();
                }
                if (Lector == 3)
                {
                    Console.WriteLine("Ingrese el precio");
                    productoIndividual.Precio = Convert.ToDecimal(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("ingrese la cantidad en stock");
                    productoIndividual.Stock = Convert.ToInt32(Console.ReadLine());
                }
                CrudProducto.ActualizarProducto(productoIndividual, Lector);
            }
            break;
        case 3:
            Console.WriteLine("ingrese el id a eliminar");
            var ProductoIndividualD = CrudProducto.ProductoIndividual(Convert.ToInt32(Console.ReadLine()));
            if (ProductoIndividualD == null)
            {
                Console.WriteLine("este producto no existe");
            }
            else
            {
                Console.WriteLine("Eliminar producto");

                Console.WriteLine($"Nombre {ProductoIndividualD.Nombre},descripcion {ProductoIndividualD.Descripcion}, Precio {ProductoIndividualD.Precio}, Stock{ProductoIndividualD.Stock}");
                Console.WriteLine("el producto es correcto desea eliminarlo presio 1 para eliminar");

                var Lector = Convert.ToInt32(Console.ReadLine());
                if (Lector == 1)
                {
                    var id = Convert.ToInt32(ProductoIndividualD.Id);
                    Console.WriteLine(CrudProducto.EliminarProducto(id));
                }

            }

            break;
        case 4:
            Console.WriteLine("Lista de productos");
            var ListarProductos = CrudProducto.ListarProductos();
            foreach (var iteracionProductos in ListarProductos)
            {
                Console.WriteLine($"{iteracionProductos.Id},{iteracionProductos.Nombre},{iteracionProductos.Descripcion},{iteracionProductos.Precio},{iteracionProductos.Stock}");
            }
            break;



    }



    Console.WriteLine("desea continuar? Presione S para Si N para NO");
    var cont = Console.ReadLine();
    if (cont.Equals("N"))
    {
        continuar = false;
    }
}


//using ConsoleApp4.Models;
//using ConsoleApp4.DAO;

//CrudProducto1 CrudProducto = new CrudProducto1();
//Producto1 Producto = new Producto1();


//db.Producto1s.Add(producto);
//db.SaveChanges();

//Console.WriteLine("Menu");
//Console.WriteLine("pulse 1 para insertar un nuevo producto");
//Console.WriteLine("pulse 0 para cancelar");
//var Menu = Convert.ToInt32(Console.ReadLine());

//switch (Menu)
//{

//    case 1:
//        int bucle = 1;
//        while (bucle == 1)
//        {
//            Console.WriteLine("ingresa el nombre del producto");
//            Producto.Nombre = Console.ReadLine();
//            Console.WriteLine("ingrese la descripcion del producto");
//            Producto.Descripcion = Console.ReadLine();
//            Console.WriteLine("ingrese el precio del producto ");
//            Producto.Precio = Convert.ToDecimal(Console.ReadLine());
//            Console.WriteLine("ingrese la cantidad en stock");
//            Producto.Stock = Convert.ToInt32(Console.ReadLine());
//            CrudProducto.AgregarProducto(Producto);
//            Console.WriteLine("El producto se agrego correctamente ");
//            Console.WriteLine("pulsa 1 para agregar otro producto");
//            Console.WriteLine("pulsa 0 para salir");
//            bucle = Convert.ToInt32(Console.ReadLine());
//        }
//        break;
//}



#region Listar
//// See /*https://aka.ms/new-console-template*/ for more information
//using ConsoleApp4.Models;

//Console.WriteLine("Hello, World!");

//AlmacenContext db = new AlmacenContext();

//Console.WriteLine("Ingrese el nombre del producto: ");
//string nombre = Console.ReadLine();
//Console.WriteLine("Ingrese la descripción del producto: ");
//string descripcion = Console.ReadLine();
//Console.WriteLine("Ingrese el precio del producto: ");
//decimal precio = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese el stock del producto: ");
//int stock = int.Parse(Console.ReadLine());


//var producto = new Producto1 { Nombre = nombre, Descripcion = descripcion, Precio = precio, Stock = stock };
//db.Producto1s.Add(producto);
//db.SaveChanges();
#endregion
#region Listar
//var ListProducto1s = db.Producto1s.ToList();
//        foreach (var usu in ListProducto1s){
//            Console.WriteLine(usu.Nombre);
//        }
#endregion
#region Insertar
//Producto1 producto = new Producto1();
//producto.Nombre = "coca";
//producto.Descripcion = "gaseosa";
//producto.Precio = 34;
//producto.Stock = 2;

//db.Producto1s.Add(producto);
//db.SaveChanges();
#endregion