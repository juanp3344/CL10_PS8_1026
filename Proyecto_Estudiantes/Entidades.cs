
var lista_grupos = new List<Grupos>();
lista_grupos.Add(new Grupos(){ id = 1, nombre = "<18",descuento =0.25m,activo= true  });
lista_grupos.Add(new Grupos(){ id = 2, nombre = "50>",descuento =0.35m,activo= true  });
lista_grupos.Add(new Grupos(){ id = 3, nombre = "Lgtb",descuento =0.0m,activo= true  });
lista_grupos.Add(new Grupos(){ id = 4, nombre = "Indigena",descuento =0.05m,activo= true  });
lista_grupos.Add(new Grupos(){ id = 5, nombre = "therian",descuento =0.0m,activo= true  });
Console.WriteLine("ESTUDIANTES");

var lista_Materias = new List<Materias>();
lista_Materias.Add(new Materias(){ id = 1, nombre = "calculo", codigo = "M1", activo = true});
lista_Materias.Add(new Materias(){ id = 2, nombre = "Logica", codigo = "M2", activo = true});
lista_Materias.Add(new Materias(){ id = 3, nombre = "Redes", codigo = "M3", activo = false});

var lista_Estudiantes = new List<Estudiantes>();
lista_Estudiantes.Add(new Estudiantes(){ id =1, cedula = "479", nombre = "Carla", activo = true, edad = 20, grupo = 3 });
lista_Estudiantes.Add(new Estudiantes(){ id =2, cedula = "854", nombre = "Andres", activo = false, edad = 15, grupo = 2 });
lista_Estudiantes.Add(new Estudiantes(){ id =99, cedula = "236", nombre = "Pedro", activo = true, edad = 70, grupo = 1 });

var lista_notas = new List<Notas>();
lista_notas.Add(new Notas(){id = 1, Materia = 1, estudiante= 2, nota1 = 3.0m, nota2= 4.5m, nota3 = 1.0m, nota4 = 2.9m, nota5 = 4.0m, notaF = 3.1m});
lista_notas.Add(new Notas(){id = 2, Materia = 3, estudiante= 99, nota1 = 2.0m, nota2= 3.0m, nota3 = 4.0m, nota4 = 2.0m, nota5 = 0.0m, notaF = 2.2m});
lista_notas.Add(new Notas(){id = 3, Materia = 2, estudiante= 2, nota1 = 3.5m, nota2= 4.0m, nota3 = 2.9m, nota4 = 1.3m, nota5 = 4.2m, notaF = 3.8m});

var estudiantes_activos = lista_Estudiantes.Count(x => x.activo);

Console.WriteLine("Estudiantes activos: "+ estudiantes_activos);

var nota = new Notas(){id = 4, Materia = 1, estudiante= 1, nota1 = 3.5m, nota2= 4.0m, nota3 = 2.9m, nota4 = 1.3m, nota5 = 4.2m};

nota.notaF = Calculos.Promedio(nota);

Console.WriteLine("Nota final: " + nota.notaF);

decimal descuento = Calculos.Descuento(lista_Estudiantes[1], lista_grupos);
Console.WriteLine("Descuento que se va aplicar al estudiante: " + lista_Estudiantes[1].nombre + "\nEs: "+ descuento);

public class Calculos
{
    public static decimal Promedio(Notas notas)
    {
        return (notas.nota1+notas.nota2+notas.nota3+notas.nota4+notas.nota5)/5;
    }

    public static decimal Descuento(Estudiantes estudiante, List<Grupos> grupos)
    {
        decimal descuento;

        var GrupoEncontrado = grupos.FirstOrDefault(Grupo => Grupo.id == estudiante.grupo);
        
        if(GrupoEncontrado!= null)
        {
            return GrupoEncontrado.descuento;
        }
        return 0m;
    }

}
public class Grupos
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public decimal descuento { get; set; }
    public bool activo { get; set; }

   public List<Estudiantes>? Estudiantes { get; set; }
}

public class Estudiantes
{
    public int id { get; set; }
    public string? cedula { get; set; }
    public string? nombre { get; set; }
    public bool activo { get; set; }
    public int edad { get; set; }
    public int grupo { get; set; }

    public Grupos? _grupo { get; set; }
    public List<Notas>? Notas { get; set; }
    
}


public class Notas
{
    public int id { get; set; }
    public int Materia { get; set; }
    public int estudiante { get; set; }
    public decimal nota1 { get; set; }
    public decimal nota2 { get; set; }
    public decimal nota3 { get; set; }
    public decimal nota4 { get; set; }
    public decimal nota5 { get; set; }
    public decimal notaF { get; set; }

    public Estudiantes? _estudiante {  get; set; }
    public Materias? _Materia { get; set; }

}

public class Materias
{
    public int id { get; set; }
    public string? codigo { get; set; }
    public string? nombre { get; set; }
    public bool activo { get; set; }

   public List<Notas>? Notas {  get; set; }
}


