using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.DAO
{
    public class CrudProducto1
    {
        public void AgregarProducto(Producto1 ParametroProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                Producto1 producto = new Producto1();
                producto.Nombre = ParametroProducto.Nombre;
                producto.Descripcion = ParametroProducto.Descripcion;
                producto.Precio = ParametroProducto.Precio;
                producto.Stock = ParametroProducto.Stock;
                db.Add(producto);
                db.SaveChanges();

            }
        }
        public Producto1 ProductoIndividual(int id)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                var buscar = db.Productos.FirstOrDefault(x => x.Id == id);
                return buscar;
            }
        }
        public void ActualizarProducto(Producto1 ParametrosProducto, int Lector)
        {
            using (AlmacenContext db =
                new AlmacenContext())
            {

                var buscar = db.Productos.FirstOrDefault(x => x.Id == ParametrosProducto.Id);
                if (buscar == null)
                {

                    Console.WriteLine("El id no existe");

                }
                else
                {
                    if (Lector == 1)
                    {
                        buscar.Nombre = ParametrosProducto.Nombre;
                    }
                    if (Lector == 2)
                    {
                        buscar.Descripcion = ParametrosProducto.Descripcion;
                    }
                    if (Lector == 3)
                    {
                        buscar.Precio= ParametrosProducto.Precio;
                    }
                    else
                    {
                        buscar.Stock = ParametrosProducto.Stock;
                    }


                    db.Update(buscar);
                    db.SaveChanges();



                }

            }
        }
        public string EliminarProducto(int id)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                var buscar = ProductoIndividual(id);
                if (buscar == null)
                {
                    return "el producto no existe ";
                }
                else
                {
                    db.Productos.Remove(buscar);
                    db.SaveChanges();
                    return "El producto se elimino";
                }
            }
        }
        public List<Producto> ListarProductos()
        {
            using (AlmacenContext db = new AlmacenContext())
            { return db.Productos.ToList(); }
        }
    }
}
//{
//    public class CrudProducto1
//    {
//        public void AgregarProducto(Producto1 ParametroProducto)
//        {
//            using (AlmacenContext db = new AlmacenContext())
//            {
//                Producto1 producto = new Producto1();
//                producto.Nombre = ParametroProducto.Nombre;
//                producto.Descripcion = ParametroProducto.Descripcion;
//                producto.Precio = ParametroProducto.Precio;
//                producto.Stock = ParametroProducto.Stock;
//                db.Add(producto);
//                db.SaveChanges();

//            }
//        }


//    }
//}
