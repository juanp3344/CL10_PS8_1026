// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Restaurante");

var lista_clientes = new List<Clientes>();
lista_clientes.Add(new Clientes() { Id = 1, Cedula = "721", Nombre = "Pepito", Correo = "Pepito@email.com", Fecha = new DateTime(1995, 1, 1), Estado = false });
lista_clientes.Add(new Clientes() { Id = 2, Cedula = "842", Nombre = "Susana", Correo = "Susana@email.com", Fecha = new DateTime(2010, 12, 24), Estado = true });
lista_clientes.Add(new Clientes() { Id = 3, Cedula = "952", Nombre = "Felipe", Correo = "Felipe@email.com", Fecha = new DateTime(1954, 6, 13), Estado = true });

Console.WriteLine("Clientes activos");
foreach (var cliente in lista_clientes.Where(x => x.Estado))
{
    Console.WriteLine(cliente.Id + "|" + 
        cliente.Cedula + "|" + 
        cliente.Nombre + "|" + 
        cliente.Correo + "|" +  
        cliente.Fecha + "|" + 
        cliente.Estado);  
}

var lista_productos = new List<Productos>();
lista_productos.Add(new Productos() { Id = 1, Codigo = "P01", Nombre = "Papitas", Cantidad = 73.0m, Valor = 10000.0m });
lista_productos.Add(new Productos() { Id = 2, Codigo = "P02", Nombre = "Gaseosa", Cantidad = 22.0m, Valor = 4200.0m });
lista_productos.Add(new Productos() { Id = 3, Codigo = "P03", Nombre = "Brownie", Cantidad = 5.0m, Valor = 1000.0m });

Console.WriteLine("Mostrar el Menu");
foreach (var producto in lista_productos)
{
    Console.WriteLine(producto.Id + "|" + 
        producto.Codigo + "|" + 
        producto.Nombre + "|" + 
        producto.Cantidad + "|" + 
        producto.Valor);  
}

var lista_ventas = new List<Ventas>();
lista_ventas.Add(new Ventas() { Id = 1, Codigo = "FA001", Cliente = 1, Fecha = new DateTime(2025, 1 ,1), Descuento = 0.0m, Total = 19000.0m });
lista_ventas.Add(new Ventas() { Id = 2, Codigo = "FA002", Cliente = 3, Fecha = new DateTime(2026, 1 ,1), Descuento = 250.0m, Total = 750.0m });
lista_ventas.Add(new Ventas() { Id = 3, Codigo = "FA003", Cliente = 1, Fecha = new DateTime(2026, 1 ,1), Descuento = 0.0m, Total = 10000.0m });

var lista_ventas_productos = new List<Ventas_Productos>();
lista_ventas_productos.Add(new Ventas_Productos() { Id = 1, Venta = 1, Producto = 1, Cantidad = 2.0m, Valor = 8000.0m, SubTotal = 16000.0m });
lista_ventas_productos.Add(new Ventas_Productos() { Id = 2, Venta = 1, Producto = 2, Cantidad = 1.0m, Valor = 3000.0m, SubTotal = 3000.0m });
lista_ventas_productos.Add(new Ventas_Productos() { Id = 3, Venta = 2, Producto = 3, Cantidad = 1.0m, Valor = 1000.0m, SubTotal = 1000.0m });
lista_ventas_productos.Add(new Ventas_Productos() { Id = 4, Venta = 3, Producto = 1, Cantidad = 1.0m, Valor = 10000.0m, SubTotal = 10000.0m });

public class Calculos
{
    public static decimal Total(Ventas venta)
    {
        var respuesta = 0.0m;
        if (venta.Ventas_Productos == null || venta.Ventas_Productos.Count() == 0)
            return respuesta;
        foreach (var elemento in venta.Ventas_Productos)
        {
            if (elemento._Producto == null)
                continue;
            respuesta += elemento.Cantidad * elemento._Producto.Valor;
        }
        return respuesta;
    }
}

public class Clientes
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public String? Correo { get; set; }
    public DateTime Fecha { get; set; }
    public bool Estado { get; set; }

    public List<Ventas>? Ventas { get; set; }
}

public class Productos
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public decimal Cantidad { get; set; }
    public decimal Valor { get; set; }

    public List<Ventas_Productos>? Ventas_Productos { get; set; }
}

public class Ventas
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public int Cliente { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Descuento { get; set; }
    public decimal Total { get; set; }

    public Clientes? _Cliente { get; set; }
    public List<Ventas_Productos>? Ventas_Productos { get; set; }
}

public class Ventas_Productos
{
    public int Id { get; set; }
    public int Venta { get; set; }
    public int Producto { get; set; }
    public decimal Cantidad { get; set; }
    public decimal Valor { get; set; }
    public decimal SubTotal { get; set; }

    public Ventas? _Venta { get; set; }
    public Productos? _Producto { get; set; }
}