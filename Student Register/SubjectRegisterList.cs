using System;
using System.Collections.Generic;

namespace Student_Register
{
    class SubjectRegisterList
    {
        private List<SubjectRegister> subjectRegisters = new List<SubjectRegister>();
        private int lastId = 0;

        private bool SubjectRegisterHeaderAtributes()
        {
            if (subjectRegisters.Count == 0)
            {
                Console.WriteLine("\n *****************************************************");
                Console.Write("\t No posee datos de registro de asignatura actualmente");
                Console.WriteLine("\n *****************************************************");
                return false;
            }
            else
            {
                Console.WriteLine("\n" + "\t" + SubjectRegister.ShortFormat, "ID:", "Asignatura:", "Profesor:", "Cantidad de estudiantes:" + "\n");
                foreach (var subjectRegister in subjectRegisters)
                {
                    subjectRegister.PrintAtributesShortFormat();
                }
                return true;
            }

        }
        public void AddSubjectRegister(SubjectList aSubjectList)
        {
            if (aSubjectList.getCount() == 0)
            {
                Console.WriteLine("\n *********************************************************");
                Console.WriteLine("\t Para utilizar esta opcion debe agregar asignaturas.");
                Console.WriteLine("\n *********************************************************");
            }
            else
            {
                var newSubjectRegister = new SubjectRegister();

                Console.WriteLine("\n Agregar registro de asignatura \n");
                Console.WriteLine("\t Asignaturas disponibles para creacion de registro de asignatura: \n");
                aSubjectList.ListSubjects();
                Console.WriteLine("Escriba el ID de la asignatura con que desea crear nuevo registro de asignatura: ");
                int id = Convert.ToInt32(Console.ReadLine());
                newSubjectRegister.SetSubject(aSubjectList.SearchAndReturn(id));

                newSubjectRegister.SetAtributes(lastId + 1);
                lastId++;

                this.subjectRegisters.Add(newSubjectRegister);
            }
        }

        public void AddStudentToRegister(StudentList aStudentList)
        {
            if (aStudentList.getCount() == 0)
            {
                Console.WriteLine("\n *********************************************************");
                Console.WriteLine("\t No hay datos de estudiante.");
                Console.WriteLine("\n *********************************************************");
                return;
            }
            else if (this.SubjectRegisterHeaderAtributes())
            {
                Console.WriteLine("Escriba el ID del registro de asignatura que desea editar: ");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (var subjectRegister in subjectRegisters)
                {
                    if (subjectRegister.Id == id)
                    {
                        Console.WriteLine("\n Agregar estudiante a registro de asignatura \n");
                        Console.WriteLine("\t Estudiantes disponibles para agregar a registro de asignatura: \n");
                        aStudentList.PrintListIdNameCareer();
                        Console.WriteLine("Escriba el ID del estudiante que desea agregar al registro de asignatura: ");
                        int idEst = Convert.ToInt32(Console.ReadLine());
                        subjectRegister.AddStudentToSubjectRegister(aStudentList.SearchAndReturn(idEst));
                        return;
                    }
                }
            }

        }
        public void DeleteStudentFromSubjectRegister(StudentList aStudentList)
        {
            if (aStudentList.getCount() == 0)
            {
                Console.WriteLine("\n *********************************************************");
                Console.WriteLine("\t No hay datos de estudiante.");
                Console.WriteLine("\n *********************************************************");
                return;
            }
            else if (this.SubjectRegisterHeaderAtributes())
            {
                Console.WriteLine("Escriba el ID del registro de asignatura que desea editar: ");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (var subjectRegister in subjectRegisters)
                {
                    if (subjectRegister.Id == id)
                    {
                        subjectRegister.DeleteStudentFromRegister();
                        return;
                    }
                }
            }
        }
        public void ListStudentsFromSubjectRegister(StudentList aStudentList)
        {
            if (aStudentList.getCount() == 0)
            {
                Console.WriteLine("\n *********************************************************");
                Console.WriteLine("\t No hay datos de estudiante.");
                Console.WriteLine("\n *********************************************************");
                return;
            }
            else if (this.SubjectRegisterHeaderAtributes())
            {
                Console.WriteLine("Escriba el ID del registro de asignatura que desea editar: ");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (var subjectRegister in subjectRegisters)
                {
                    if (subjectRegister.Id == id)
                    {
                        subjectRegister.ListStudentsFromRegister();
                        return;
                    }
                }
            }
        }
    }
}
