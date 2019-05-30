using System;
using System.Collections.Generic;

namespace Student_Register
{
    class Program
    {
        static StudentList Students = new StudentList();

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

            Students.ListStudents();

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
            int addOption = 1;

            Console.Clear();

            while (addOption == 1)
            {
                Students.AddStudent();

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
            int editOption = 1;
            Console.Clear();
            while (editOption == 1)
            {
                Students.EditStudent();

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
                Students.DeleteStudent();

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
                Students.SearchStudent();

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
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Menu();
        }
    }
}
