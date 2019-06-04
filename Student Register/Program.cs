using System;
using System.Collections.Generic;

namespace Student_Register
{
    class Program
    {
        static StudentList Students = new StudentList();
        static SubjectList Subjects = new SubjectList();
        static SubjectRegisterList SubjectsRegister = new SubjectRegisterList();
        
        static void MainMenu()
        {
            int menuOption = 0;
            Console.Clear();

            while (menuOption == 0)
            {
                Console.Clear();
                Console.WriteLine("\n ***********************************");
                Console.Write("\t Menú de Opciones");
                Console.WriteLine("\n ***********************************");
                Console.WriteLine(" 1- Estudiantes ");
                Console.WriteLine(" 2- Asignaturas ");
                Console.WriteLine(" 3- Registro de Asignaturas ");
                Console.WriteLine(" 4- Salir ");
                Console.Write("\n Elija una opción: ");
                menuOption = Convert.ToInt32("0" + Console.ReadLine());
                switch(menuOption)
                {
                    case 1:
                        StudentMenu();
                        break;
                    case 2:
                        SubjectMenu();
                        break;
                    case 3:
                        SubjectRegisterMenu();
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        MainMenu();
                        break;
                }
            }

        }

        static void StudentMenu()
        {
            int studentMenuOption = 0;
            Console.Clear();

            while (studentMenuOption == 0)
            {
                Console.Clear();
                Console.WriteLine("\n ***********************************");
                Console.Write("\t Menú de Opciones");
                Console.WriteLine("\n ***********************************");
                Console.WriteLine(" 1- Listar Estudiante ");
                Console.WriteLine(" 2- Agregar Estudiante ");
                Console.WriteLine(" 3- Editar Estudiante ");
                Console.WriteLine(" 4- Borrar Estudiante ");
                Console.WriteLine(" 5- Buscar Estudiante ");
                Console.WriteLine(" 6- Volver al Menu Principal");
                Console.Write("\n Elija una opción: ");
                studentMenuOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (studentMenuOption)
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
                        MainMenu();
                        break;
                    default:
                        StudentMenu();
                        break;
                }
            }

        }
        static void SubjectMenu()
        {
            int subjectMenuOption = 0;
            Console.Clear();

            while (subjectMenuOption == 0)
            {
                Console.Clear();
                Console.WriteLine("\n ***********************************");
                Console.Write("\t Menú de Opciones");
                Console.WriteLine("\n ***********************************");
                Console.WriteLine(" 1- Listar Asignatura ");
                Console.WriteLine(" 2- Agregar Asignatura ");
                Console.WriteLine(" 3- Editar Asignatura ");
                Console.WriteLine(" 4- Borrar Asignatura ");
                Console.WriteLine(" 5- Buscar Asignatura ");
                Console.WriteLine(" 6- Volver al Menu Principal");
                Console.Write("\n Elija una opción: ");
                subjectMenuOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectMenuOption)
                {
                    case 1:
                        ListSubject();
                        break;
                    case 2:
                        AddSubject();
                        break;
                    case 3:
                        EditSubject();
                        break;
                    case 4:
                        DeleteSubject();
                        break;
                    case 5:
                        SearchSubject();
                        break;
                    case 6:
                        MainMenu();
                        break;
                    default:
                        SubjectMenu();
                        break;
                }
            }
        }
        static void SubjectRegisterMenu()
        {
            int subjectRegisterMenuOption = 0;
            Console.Clear();

            while (subjectRegisterMenuOption == 0)
            {
                Console.Clear();
                Console.WriteLine("\n ***********************************");
                Console.Write("\t Menú de Opciones");
                Console.WriteLine("\n ***********************************");
                Console.WriteLine(" 1- Listar Registro de Asignaturas ");
                Console.WriteLine(" 2- Agregar Registro de Asignatura ");
                Console.WriteLine(" 3- Editar Registro de Asignatura ");
                Console.WriteLine(" 4- Borrar Registro de Asignatura ");
                Console.WriteLine(" 5- Buscar Registro de Asignatura ");
                Console.WriteLine(" 6- Volver al Menu Principal");
                Console.Write("\n Elija una opción: ");
                subjectRegisterMenuOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectRegisterMenuOption)
                {
                    case 1:
                        ListSubjectRegister();
                        break;
                    case 2:
                        AddSubjectRegister();
                        break;
                    case 3:
                        EditSubjectRegister();
                        break;
                    case 4:
                        DeleteSubjectRegister();
                        break;
                    case 5:
                        SearchSubjectRegister();
                        break;
                    case 6:
                        MainMenu();
                        break;
                    default:
                        SubjectRegisterMenu();
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
            Console.WriteLine("2- Menú Estudiantes");
            Console.Write("\n Elija una opción: ");

            int studentListOption = Convert.ToInt32("0" + Console.ReadLine());
            switch(studentListOption)
            {
                case 2:
                    StudentMenu();
                    break;
                default:
                    ListStudent();
                    break;
            }
        }
        static void ListSubject()
        {
            Console.Clear();
            Subjects.ListSubjects();

            Console.WriteLine("\n\n ¿Qué desea hacer? \n");
            Console.WriteLine("1- Mantenerse en Lista");
            Console.WriteLine("2- Menú Asignaturas");
            Console.Write("\n Elija una opción: ");

            int subjectListOption = Convert.ToInt32("0" + Console.ReadLine());
            switch (subjectListOption)
            {
                case 2:
                    SubjectMenu();
                    break;
                default:
                    ListSubject();
                    break;
            }
        }
        static void ListSubjectRegister()
        {
            Console.Clear();
            SubjectsRegister.ListSubjectRegister();

            Console.WriteLine("\n\n ¿Qué desea hacer? \n");
            Console.WriteLine("1- Mantenerse en Lista");
            Console.WriteLine("2- Menú Registro Asignaturas");
            Console.Write("\n Elija una opción: ");

            int subjectRegisterListOption = Convert.ToInt32("0" + Console.ReadLine());
            switch (subjectRegisterListOption)
            {
                case 2:
                    SubjectRegisterMenu();
                    break;
                default:
                    ListSubjectRegister();
                    break;
            }
        }
        static void AddStudent()
        {
            int studentAddOption = 1;
            Console.Clear();

            while (studentAddOption == 1)
            {
                Students.AddStudent();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Agregar otro estudiante");
                Console.WriteLine("2- Menú Estudiantes");
                Console.Write("\n Elija una opción: ");
                studentAddOption = Convert.ToInt32("0" + Console.ReadLine());
                switch(studentAddOption)
                {
                    case 1:
                        AddStudent();
                        break;
                    default:
                        StudentMenu();
                        break;
                }
            }
        }
        static void AddSubject()
        {
            int subjectAddOption = 1;
            Console.Clear();

            while (subjectAddOption == 1)
            {
                Subjects.AddSubject();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Agregar otra asignatura");
                Console.WriteLine("2- Menú Asignaturas");
                Console.Write("\n Elija una opción: ");
                subjectAddOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectAddOption)
                {
                    case 1:
                        AddSubject();
                        break;
                    default:
                        SubjectMenu();
                        break;
                }
            }
        }
        static void AddSubjectRegister()
        {
            int subjectRegisterAddOption = 1;
            Console.Clear();

            while (subjectRegisterAddOption == 1)
            {
                SubjectsRegister.AddSubjectRegister(Subjects);

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Agregar otro Registro de asignatura");
                Console.WriteLine("2- Menú Registro de Asignaturas");
                Console.Write("\n Elija una opción: ");
                subjectRegisterAddOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectRegisterAddOption)
                {
                    case 1:
                        AddSubjectRegister();
                        break;
                    default:
                        SubjectRegisterMenu();
                        break;
                }
            }
        }
        static void EditStudent()
        {
            int studentEditOption = 1;
            Console.Clear();

            while (studentEditOption == 1)
            {
                Students.EditStudent();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Editar otro estudiante");
                Console.WriteLine("2- Menú Estudiantes");
                Console.Write("\n Elija una opción: ");
                studentEditOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (studentEditOption)
                {
                    case 1:
                        EditStudent();
                        break;
                    default:
                        StudentMenu();
                        break;
                }
            }
        }
        static void EditSubject()
        {
            int subjectEditOption = 1;
            Console.Clear();

            while(subjectEditOption == 1)
            {
                Subjects.EditSubject();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Editar otra asignatura");
                Console.WriteLine("2- Menú Asignaturas");
                Console.Write("\n Elija una opción: ");
                subjectEditOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectEditOption)
                {
                    case 1:
                        EditSubject();
                        break;
                    default:
                        SubjectMenu();
                        break;
                }
            }
        }
        static void EditSubjectRegister()
        {
            int subjectRegisterMenuOption = 0;
            Console.Clear();

            while (subjectRegisterMenuOption == 0)
            {
                Console.Clear();
                Console.WriteLine("\n ***********************************");
                Console.Write("\t Menú de Opciones");
                Console.WriteLine("\n ***********************************");
                Console.WriteLine(" 1- Listar Estudiantes ");
                Console.WriteLine(" 2- Agregar Estudiantes ");
                Console.WriteLine(" 3- Borrar Estudiantes ");
                Console.WriteLine(" 4- Menu Registros de Asignatura");
                Console.Write("\n Elija una opción: ");
                subjectRegisterMenuOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectRegisterMenuOption)
                {
                    case 1:
                        Console.Clear();
                        SubjectsRegister.ListStudentsFromSubjectRegister(Students);
                        Console.WriteLine(" *Presione cualquier tecla para volver al menú* ");
                        Console.ReadLine();
                        EditSubjectRegister();
                        break;
                    case 2:
                        Console.Clear();
                        SubjectsRegister.AddStudentToRegister(Students);
                        Console.WriteLine(" *Presione cualquier tecla para volver al menú* ");
                        Console.ReadLine();
                        EditSubjectRegister();
                        break;
                    case 3:
                        Console.Clear();
                        SubjectsRegister.DeleteStudentFromSubjectRegister(Students);
                        Console.WriteLine(" *Presione cualquier tecla para volver al menú* ");
                        Console.ReadLine();
                        EditSubjectRegister();
                        break;
                    case 4:
                        Console.Clear();
                        SubjectRegisterMenu();
                        break;
                    default:
                        Console.Clear();
                        EditSubjectRegister();
                        break;
                }
            }
        }
        //static void EditSubjectRegister()
        //{
        //    int subjectRegisterEditOption = 1;
        //    Console.Clear();

        //    while (subjectRegisterEditOption == 1)
        //    {
        //        // SubjectsRegister;

        //        Console.WriteLine("\n ¿Qué desea hacer? \n");
        //        Console.WriteLine("1- Editar otro Registro de asignatura");
        //        Console.WriteLine("2- Menú Asignaturas");
        //        Console.Write("\n Elija una opción: ");
        //        subjectRegisterEditOption = Convert.ToInt32("0" + Console.ReadLine());
        //        switch (subjectRegisterEditOption)
        //        {
        //            case 1:
        //                EditSubjectRegister();
        //                break;
        //            default:
        //                SubjectRegisterMenu();
        //                break;
        //        }
        //    }
        //}
        static void DeleteStudent()
        {
            int studentDeleteOption = 1;
            Console.Clear();
            while (studentDeleteOption == 1)
            {
                Students.DeleteStudent();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Eliminar otro estudiante");
                Console.WriteLine("2- Menú Estudiantes");
                Console.Write("\n Elija una opción: ");
                studentDeleteOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (studentDeleteOption)
                {
                    case 1:
                        DeleteStudent();
                        break;
                    default:
                        StudentMenu();
                        break;
                }
            }

        }
        static void DeleteSubject()
        {
            int subjectDeleteOption = 1;
            Console.Clear();

            while (subjectDeleteOption == 1)
            {
                Subjects.DeleteSubject();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Eliminar otra asignatura");
                Console.WriteLine("2- Menú Asignaturas");
                Console.Write("\n Elija una opción: ");
                subjectDeleteOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectDeleteOption)
                {
                    case 1:
                        DeleteSubject();
                        break;
                    default:
                        SubjectMenu();
                        break;
                }
            }
        }
        static void DeleteSubjectRegister()
        {
            int subjectRegisterDeleteOption = 1;
            Console.Clear();

            while (subjectRegisterDeleteOption == 1)
            {
                SubjectsRegister.DeleteSubjectRegister();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Eliminar otro Registro asignatura");
                Console.WriteLine("2- Menú Registro de Asignaturas");
                Console.Write("\n Elija una opción: ");
                subjectRegisterDeleteOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectRegisterDeleteOption)
                {
                    case 1:
                        DeleteSubjectRegister();
                        break;
                    default:
                        SubjectRegisterMenu();
                        break;
                }
            }
        }
        static void SearchStudent()
        {
            int studentSearchOption = 1;
            Console.Clear();
            while (studentSearchOption == 1)
            {
                Students.SearchStudent();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Buscar otro estudiante");
                Console.WriteLine("2- Menú Estudiantes");
                Console.Write("\n Elija una opción: ");
                studentSearchOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (studentSearchOption)
                {
                    case 1:
                        SearchStudent();
                        break;
                    default:
                        StudentMenu();
                        break;
                }
            }
        }
        static void SearchSubject()
        {
            int subjectSearchOption = 1;
            Console.Clear();

            while (subjectSearchOption == 1)
            {
                Subjects.SearchSubject();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Buscar otra asignatura");
                Console.WriteLine("2- Menú Asignaturas");
                Console.Write("\n Elija una opción: ");
                subjectSearchOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectSearchOption)
                {
                    case 1:
                        SearchSubject();
                        break;
                    default:
                        SubjectMenu();
                        break;
                }
            }
        }
        static void SearchSubjectRegister()
        {
            int subjectRegisterSearchOption = 1;
            Console.Clear();

            while (subjectRegisterSearchOption == 1)
            {
                SubjectsRegister.SearchSubjectRegister();

                Console.WriteLine("\n ¿Qué desea hacer? \n");
                Console.WriteLine("1- Buscar otro Registro de asignatura");
                Console.WriteLine("2- Menú Registro de Asignaturas");
                Console.Write("\n Elija una opción: ");
                subjectRegisterSearchOption = Convert.ToInt32("0" + Console.ReadLine());
                switch (subjectRegisterSearchOption)
                {
                    case 1:
                        SearchSubjectRegister();
                        break;
                    default:
                        SubjectRegisterMenu();
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
            option = Convert.ToInt32("0" + Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n ***********************************");
                    Console.Write("\t Hasta Luego");
                    Console.WriteLine("\n ***********************************");
                    Environment.Exit(1);
                    break;
                default:
                    MainMenu();
                    break;
            }

        }
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetWindowSize(135, 40);
            MainMenu();
        }
    }
}
