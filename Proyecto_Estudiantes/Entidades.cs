
var lista_grupos = new List<Grupos>();
lista_grupos.Add(new Grupos(){ id = 1, nombre = "<18",descuento =0.25m,activo= true  });
lista_grupos.Add(new Grupos(){ id = 2, nombre = "50>",descuento =0.35m,activo= true  });
lista_grupos.Add(new Grupos(){ id = 3, nombre = "Lgtb",descuento =0.0m,activo= true  });
lista_grupos.Add(new Grupos(){ id = 4, nombre = "Indigena",descuento =0.05m,activo= true  });
lista_grupos.Add(new Grupos(){ id = 5, nombre = "therian",descuento =0.0m,activo= true  });
Console.WriteLine("ESTUDIANTES");

var lista_Materias = new List<Materias>();
lista_Materias.Add(new Materias(){ })
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
    public decimal? nota1 { get; set; }
    public decimal? nota2 { get; set; }
    public decimal? nota3 { get; set; }
    public decimal? nota4 { get; set; }
    public decimal? nota5 { get; set; }
    public decimal? notaF { get; set; }

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


