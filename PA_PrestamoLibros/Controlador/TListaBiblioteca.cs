using PA_PrestamoLibros.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_PrestamoLibros.Controlador
{
    public class TListaBiblioteca
    {
        public static List<Libro> ListaLibros = new List<Libro>();
        public static List<Estudiante> ListaEstudiantes = new List<Estudiante>();
        public static List<Prestamo> ListaPrestamos = new List<Prestamo>();

        public static void AgregarLibro(Libro libro)
        {
            ListaLibros.Add(libro);
        }

        //public Libro(string codigoLibro, string tipo, string categoria, string editorial, string nombreLibro, string autor, DateTime fechaPublicacion, bool disponible)

        public static void LibrosDisponibles()
        {
            Libro l1 = new Libro("11037", "Libro", "Realismo Magico", "Editorial Sudamericana", "100 años de soledad", "Gabriel Garcia Marquez",1967,true);
            ListaLibros.Add(l1);

            Libro r = new Libro("38090", "Revista", "Informatica", "WWW.web", "100 años de soledad", "Gabriel Garcia Marquez", 2022, true);
            ListaLibros.Add(r);

            Libro l2 = new Libro("00123", "Libro", "Literatura", "Editorial Planeta", "Cien sonetos de amor", "Pablo Neruda", 1959, true);
            ListaLibros.Add(l2);

            Libro l3 = new Libro("00234", "Libro", "Salud", "McGraw-Hill Education", "Anatomía Humana", "Frank H. Netter", 2010, true);
            ListaLibros.Add(l3);

            Libro l4 = new Libro("00345", "Libro", "Informática", "O'Reilly Media", "Eloquent JavaScript", "Marijn Haverbeke", 2018, true);
            ListaLibros.Add(l4);

            Libro r1 = new Libro("00456", "Revista", "Ciencia", "National Geographic Society", "National Geographic", "Varios Autores", 2023, true);
            ListaLibros.Add(r1);

            Libro r2 = new Libro("00567", "Revista", "Tecnología", "IEEE Publications", "IEEE Spectrum", "Varios Autores", 2022, true);
            ListaLibros.Add(r2);
        }

        public static void rellenarcomboboxCLibros(ComboBox combo)
        {
            for (int i = 0; i < ListaLibros.Count; i++)
            {
                combo.Items.Add(ListaLibros[i].CodigoLibro1);
            }
        }

        public static void rellenarcomboboxCedula(ComboBox combo)
        {
            for (int i = 0; i < ListaEstudiantes.Count; i++)
            {
                combo.Items.Add(ListaEstudiantes[i].Cedula1);
            }
        }


        public void ModificarLibro(string codigo, string nuevaCategoria, string nuevoNombre)
        {
            var libro = ListaLibros.FirstOrDefault(l => l.CodigoLibro1 == codigo);
            if (libro != null)
            {
                libro.Categoria1 = nuevaCategoria;
                libro.NombreLibro1 = nuevoNombre;
            }
        }

        public static void EliminarLibro(string codigo)
        {
            ListaLibros.RemoveAll(l => l.CodigoLibro1 == codigo);
        }

        public static void AgregarEstudiante(Estudiante estudiante)
        {
            ListaEstudiantes.Add(estudiante);
        }


        public static void AgregarPrestamo(Prestamo pres)
        {
            ListaPrestamos.Add(pres);
        }


        public static void ModificarEstudiante(string cedula, string nuevoNombre, string nuevoApellido)
        {
            var estudiante = ListaEstudiantes.FirstOrDefault(e => e.Cedula1 == cedula);
            if (estudiante != null)
            {
                estudiante.Nombre1 = nuevoNombre;
                estudiante.Apellido1 = nuevoApellido;
            }
        }

        public static void EliminarEstudiante(string cedula)
        {
            ListaEstudiantes.RemoveAll(e => e.Cedula1 == cedula);
        }




        public static int BuscarEstudiante(string ced)
        {
            int pos = -1;
            for (int i = 0; i < ListaEstudiantes.Count; i++)
            {
                if (ListaEstudiantes[i].Cedula1 == ced)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static Estudiante getEstudiante(int pos)
        {
            return ListaEstudiantes[pos];
        }

        public static int BuscarLibro(string cod)
        {
            int pos = -1;
            for (int i = 0; i < ListaLibros.Count; i++)
            {
                if (ListaLibros[i].CodigoLibro1 == cod)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static Libro getLibro(int pos)
        {
            return ListaLibros[pos];
        }

        public static bool LibroDisponible(string codigoLibro)
        {
            // Busca el libro en la lista
            var libro = ListaLibros.FirstOrDefault(l => l.CodigoLibro1 == codigoLibro);

            // Devuelve true si el libro existe y está disponible, false en caso contrario
            return libro != null && libro.Disponible1;
        }

        public static string ObtenerNombreEstudiantePorCedula(string cedula)
        {
            var estudiante = ListaEstudiantes.FirstOrDefault(e => e.Cedula1 == cedula);
            return estudiante != null ? estudiante.Nombre1 : null;  // Retorna el nombre del estudiante o null si no se encuentra
        }

        public static string ObtenerNombreLibroPorCodigo(string codigoLibro)
        {
            var libro = ListaLibros.FirstOrDefault(l => l.CodigoLibro1 == codigoLibro);
            return libro != null ? libro.NombreLibro1 : null;  // Retorna el nombre del libro o null si no se encuentra
        }

        //CONSULTAS:

        public static int CantidadPrestamosLibrosYRevistas()
        {
            return ListaPrestamos.Count(p => ListaLibros.Any(l => l.CodigoLibro1 == p.CodigoLibro));
        }

        // 2. Porcentaje de préstamos realizados según la categoría de libros y revistas
        public static Dictionary<string, double> PorcentajePrestamosPorCategoria()
        {
            var totalPrestamos = ListaPrestamos.Count();
            var prestamosPorCategoria = ListaPrestamos
                .GroupBy(p => ListaLibros.FirstOrDefault(l => l.CodigoLibro1 == p.CodigoLibro)?.Categoria1)
                .Where(g => g.Key != null) // Evita los nulos si no hay categoría
                .ToDictionary(g => g.Key, g => g.Count());

            var porcentajePorCategoria = prestamosPorCategoria.ToDictionary(
                p => p.Key,
                p => (double)p.Value / totalPrestamos * 100);

            return porcentajePorCategoria;
        }


        // 3. Cantidad de estudiantes sancionados
        public static int CantidadEstudiantesSancionados()
        {
            // Contar los estudiantes sancionados de los préstamos
            var estudiantesSancionados = ListaPrestamos
                .Select(p => ListaEstudiantes.FirstOrDefault(e => e.Cedula1 == p.CedulaEstudiante)) // Encuentra al estudiante por cédula
                .Where(e => e != null && e.Sancionado1) // Filtra los estudiantes sancionados
                .Distinct() // Evita contar dos veces al mismo estudiante
                .Count();

            return estudiantesSancionados;
        }


        // 4. Total de libros prestados según el sexo del estudiante
        public static Dictionary<string, int> TotalLibrosPrestadosPorSexo()
        {
            var prestamosPorSexo = ListaPrestamos
                .GroupBy(p => ListaEstudiantes.FirstOrDefault(e => e.Cedula1 == p.CedulaEstudiante)?.Sexo)  // Encuentra al estudiante y agrupa por sexo
                .Where(g => g.Key != null)  // Evita los valores nulos
                .ToDictionary(g => g.Key, g => g.Count());

            return prestamosPorSexo;
        }
        public static int CantidadLibrosPrestadosEnMes(int mes)
        {
            // Filtra los préstamos que fueron realizados en el mes específico
            var prestamosEnMes = ListaPrestamos
                .Where(p => p.FechaPrestamo.Month == mes) // Verifica si el mes del préstamo es el especificado
                .Count();

            return prestamosEnMes;
        }

        public static int CantidadEstudiantesQueAgarranLibrosEnSuCumple()
        {
            var estudiantesConPrestamos = ListaEstudiantes
                .Where(e => ListaPrestamos
                    .Any(p => p.CedulaEstudiante == e.Cedula1 && p.FechaPrestamo.Month == e.FechaNacimiento.Month)) // Verifica que el estudiante haya tomado un libro en su mes de cumpleaños
                .Count();

            return estudiantesConPrestamos;
        }




    }
}
