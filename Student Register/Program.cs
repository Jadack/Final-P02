using System;
using System.Collections.Generic;

namespace Student_Register
{
    class Program
    {
        static List<Student> Students = new List<Student>();

        static void Menu()
        {
            int menuOption = 0;
            Console.Clear();

            while (menuOption == 0)
            {
                Console.WriteLine("\n ***********************************");
                Console.Write("\t Menú de Opciones");
                Console.WriteLine("\n ***********************************");
                Console.WriteLine(" 1- Listar Estudiante ");
                Console.WriteLine(" 2- Agregar Estudiante ");
                Console.WriteLine(" 3- Editar Estudiante ");
                Console.WriteLine(" 4- Borrar Estudiante ");
                Console.WriteLine(" 5- Buscar Estudiante ");
                Console.WriteLine(" 6- Salir");
                Console.Write("\n Elija una opción: ");
                menuOption = Convert.ToInt32(Console.ReadLine());
                switch (menuOption)
                {
                    case 1:
                        ListStudent();
                        break;
                    case 2:
                        AddStudent();
                        break;
                    case 3:
                        EditStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        SearchStudent();
                        break;
                    case 6:
                        Exit();
                        break;
                }
            }

        }
        static void ListStudent()
        {
            Console.Clear();
            if (Students.Count == 0)
            {
                Console.WriteLine("\n ******************************************");
                Console.Write("\t No posee datos actualmente");
                Console.WriteLine("\n ******************************************");
            } else
            {
                string mensaje = "{0, -5}{1, -10}{2,-30}{3,-15}{4,-15}{5,-10}{6,-30}{7,-10}";
                Console.WriteLine("\n" + "\t" + mensaje, " # ", "ID:", "Nombre Completo:", "Cédula:", "Celular:", "Carrera:", "Email:", "Fecha de Nacimiento:" + "\n");

                for (var s = 0; s < Students.Count; s++ )
                {
                    Console.WriteLine("\t" + mensaje, (s + 1), Students[s].Id, Students[s].FullName, Students[s].DocumentNumber, Students[s].Phone, Students[s].Career, Students[s].Email, Students[s].BirthDate.ToString("dd/MM/yyyy"));
                }

            }

            Console.WriteLine("\n\n ¿Qué desea hacer? \n");
            Console.WriteLine("1- Mantenerse en Lista");
            Console.WriteLine("2- Menú Principal");
            Console.Write("\n Elija una opción: ");

            int listOption = Convert.ToInt32(Console.ReadLine());
            switch(listOption)
            {
                case 1:
                    ListStudent();
                    break;
                case 2:
                    Menu();
                    break;
            }
        }
        static void AddStudent()
        {
            int day, month, year;
            int addOption = 1;
            Student newStudent = new Student();

            Console.Clear();

            while (addOption == 1)
            {
                Console.WriteLine("\n Ingrese los datos del estudiante \n");
                Console.Write("ID: ");
                newStudent.Id = Console.ReadLine();
                Console.Write("Nombre Completo: ");
                newStudent.FullName = Console.ReadLine();
                Console.Write("Cédula: ");
                newStudent.DocumentNumber = Console.ReadLine();
                Console.Write("Carrera: ");
                newStudent.Career = Console.ReadLine();
                Console.Write("Teléfono: ");
                newStudent.Phone = Console.ReadLine();
                Console.Write("Email: ");
                newStudent.Email = Console.ReadLine();
                Console.Write("Día de Nacimiento: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mes de Nacimiento: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Año de Nacimiento: ");
                year = Convert.ToInt32(Console.ReadLine());
                newStudent.BirthDate = new DateTime(year, month, day);
                Students.Add(newStudent);

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Agregar otro estudiante");
                Console.WriteLine("2- Menú Principal");
                Console.Write("\n Elija una opción: ");
                addOption = Convert.ToInt32(Console.ReadLine());
                switch(addOption)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        Menu();
                        break;
                }
            }
        }
        static void EditStudent()
        {
            int day, month, year;
            int editOption = 1;
            Console.Clear();
            while (editOption == 1)
            {
                Console.WriteLine("\n Editar estudiantes \n");
                if (Students.Count == 0)
                {
                    Console.WriteLine("\n ******************************************");
                    Console.Write("\t No posee datos para editar");
                    Console.WriteLine("\n ******************************************");
                }
                else
                {
                    string mensaje = "{0, -5}{1, -10}{2,-30}";
                    Console.WriteLine("\n" + "\t" + mensaje, " # ", "ID:", "Nombre Completo:" + "\n");

                    for (var s = 0; s < Students.Count; s++)
                    {
                        Console.WriteLine("\t" + mensaje, (s + 1), Students[s].Id, Students[s].FullName);
                    }

                    Console.Write("\n Escriba la posición del estudiante que desea editar: ");
                    int id = Convert.ToInt32(Console.ReadLine()); ;
                    id = id - 1;
                    Console.WriteLine("\n Ingrese los nuevos datos del estudiante \n");
                    Console.Write("ID: ");
                    Students[id].Id = Console.ReadLine();
                    Console.Write("Nombre Completo: ");
                    Students[id].FullName = Console.ReadLine();
                    Console.Write("Cédula: ");
                    Students[id].DocumentNumber = Console.ReadLine();
                    Console.Write("Carrera: ");
                    Students[id].Career = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    Students[id].Phone = Console.ReadLine();
                    Console.Write("Email: ");
                    Students[id].Email = Console.ReadLine();
                    Console.Write("Día de Nacimiento: ");
                    day = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Mes de Nacimiento: ");
                    month = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Año de Nacimiento: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    Students[id].BirthDate = new DateTime(year, month, day);
                }

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Editar otro estudiante");
                Console.WriteLine("2- Menú Principal");
                Console.Write("\n Elija una opción: ");
                editOption = Convert.ToInt32(Console.ReadLine());
                switch (editOption)
                {
                    case 1:
                        EditStudent();
                        break;
                    case 2:
                        Menu();
                        break;
                }

            }
        }
        static void DeleteStudent()
        {
            int deleteOption = 1;
            Console.Clear();
            while (deleteOption == 1)
            {
                Console.WriteLine("\n Eliminar estudiantes \n");
                if (Students.Count == 0)
                {
                    Console.WriteLine("\n ******************************************");
                    Console.Write("\t No posee datos para borrar");
                    Console.WriteLine("\n ******************************************");
                }
                else
                {
                    string mensaje = "{0, -5}{1, -10}{2,-30}";
                    Console.WriteLine("\n" + "\t" + mensaje, " # ", "ID:", "Nombre Completo:" + "\n");

                    for (var s = 0; s < Students.Count; s++)
                    {
                        Console.WriteLine("\t" + mensaje, (s + 1), Students[s].Id, Students[s].FullName);
                    }

                    Console.Write("\n Escriba la posición del estudiante que desea eliminar: ");
                    int id = Convert.ToInt32(Console.ReadLine()); ;
                    Students.RemoveAt(id - 1);
                }

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Eliminar otro estudiante");
                Console.WriteLine("2- Menú Principal");
                Console.Write("\n Elija una opción: ");
                deleteOption = Convert.ToInt32(Console.ReadLine());
                switch (deleteOption)
                {
                    case 1:
                        DeleteStudent();
                        break;
                    case 2:
                        Menu();
                        break;
                }
            }

        }
        static void SearchStudent()
        {
            int searchOption = 1;
            Console.Clear();
            while (searchOption == 1)
            {
                Console.WriteLine("\n ¿Por qué opción desea buscar? \n");
                Console.WriteLine("1- Por ID");
                Console.WriteLine("2- Por Nombre");
                Console.WriteLine("3- Por Carrera");
                Console.Write("Elija una opción: ");
                int sOpt = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el valor de busqueda: ");
                string searchValue = Console.ReadLine();
                bool flag = true;
                bool flagHeader = true;
                for (var s = 0; s < Students.Count; s++)
                {
                    switch (sOpt)
                    {
                        case 1:
                            if (Students[s].Id.Contains(searchValue))
                            {
                                flag = false;
                                string mensaje = "{0, -5}{1, -10}{2,-30}{3,-10}";
                                if (flagHeader)
                                {
                                    Console.WriteLine("\n" + "\t" + mensaje, " # ", "ID:", "Nombre Completo:", "Carrera:" + "\n");
                                    flagHeader = false;
                                }
                                
                                Console.WriteLine("\t" + mensaje, (s + 1), Students[s].Id, Students[s].FullName, Students[s].Career);
                            }
                            break;
                        case 2:
                            if (Students[s].FullName.Contains(searchValue))
                            {
                                flag = false;
                                string mensaje = "{0, -5}{1, -10}{2,-30}{3,-10}";
                                if (flagHeader)
                                {
                                    Console.WriteLine("\n" + "\t" + mensaje, " # ", "ID:", "Nombre Completo:", "Carrera:" + "\n");
                                    flagHeader = false;
                                }
                                Console.WriteLine("\t" + mensaje, (s + 1), Students[s].Id, Students[s].FullName, Students[s].Career);
                            }
                            break;
                        case 3:
                            if (Students[s].Career.Contains(searchValue))
                            {
                                flag = false;
                                string mensaje = "{0, -5}{1, -10}{2,-30}{3,-10}";
                                if (flagHeader)
                                {
                                    Console.WriteLine("\n" + "\t" + mensaje, " # ", "ID:", "Nombre Completo:", "Carrera:" + "\n");
                                    flagHeader = false;
                                }
                                Console.WriteLine("\t" + mensaje, (s + 1), Students[s].Id, Students[s].FullName, Students[s].Career);
                            }
                            break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("\n ******************************************");
                    Console.Write("\t No se encontraron registros");
                    Console.WriteLine("\n ******************************************");
                }
                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Buscar otro estudiante");
                Console.WriteLine("2- Menú Principal");
                Console.Write("\n Elija una opción: ");
                searchOption = Convert.ToInt32(Console.ReadLine());
                switch (searchOption)
                {
                    case 1:
                        SearchStudent();
                        break;
                    case 2:
                        Menu();
                        break;
                }
            }
        }
        static void Exit()
        {
            int option = 0;
            Console.WriteLine("\n ¿Seguro que quiere salir del programa? \n");
            Console.WriteLine("1- Si");
            Console.WriteLine("2- No");
            Console.Write("Elije una opción: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n ***********************************");
                    Console.Write("\t Hasta Luego");
                    Console.WriteLine("\n ***********************************");
                    Environment.Exit(1);
                    break;
                case 2:
                    Menu();
                    break;
            }

        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Menu();
        }
    }
}
