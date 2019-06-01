using System;
using System.Collections.Generic;

namespace Student_Register
{
    class SubjectRegister
    {
        private int id;
        private List<int> startDate = new List<int>();
        private List<int> endDate = new List<int>();
        private string classRoom, professor;
        private StudentList subjectRegisterStudents = new StudentList();
        private Subject subject;
        
        public int Id { get { return this.id; } }
        public string Subject { get { return this.subject.Name; } }
        public string ClassRoom { get { return this.classRoom; } }
        public string Professor { get { return this.professor; } }
        public DateTime StartDate()
        {
            return new DateTime(this.startDate[2], this.startDate[1], this.startDate[0]);
        }
        public string StartDateString()
        {
            return Convert.ToString(this.startDate[0]) + "/" + Convert.ToString(this.startDate[1]) + "/" + Convert.ToString(this.startDate[2]);
        }
        public DateTime EndDate()
        {
            return new DateTime(this.endDate[2], this.endDate[1], this.endDate[0]);
        }
        public string EndDateString()
        {
            return Convert.ToString(this.endDate[0]) + "/" + Convert.ToString(this.endDate[1]) + "/" + Convert.ToString(this.endDate[2]);
        }

        public void SetId(int newId)
        {
            this.id = newId;           
        }
        public void SetStartDate()
        {
            SetDate("Fecha de inicio: ", this.startDate);
        }
        public void SetEndeDate()
        {
            SetDate("Fecha de finalizacion: ", this.startDate);
        }
        public void SetClassroom()
        {
            Console.Write("Aula: ");
            this.classRoom = Console.ReadLine();
        }
        public void SetProfessor()
        {
            Console.Write("Profesor: ");
            this.professor = Console.ReadLine();
        }
        public void SetSubject(Subject aSubject)
        {
            this.subject = aSubject;
        }

        private void SetDate(string prompt, List<int> dateList)
        {
            Console.Write(prompt);
            string captureData = Console.ReadLine() + "$";
            List<int> dayMonthYear = new List<int>() { 0, 0, 0 };
            int position = 0;
            string numbers = "";

            foreach (var number in captureData)
            {
                if (number == '/')
                {
                    dayMonthYear[position] = Convert.ToInt32(numbers);
                    numbers = "";
                    position++;
                    if (position > dayMonthYear.Count - 1) { break; }
                }
                else if (!Char.IsDigit(number) & number != '\n' & number != '/')
                {
                    if (numbers != "") { dayMonthYear[position] = Convert.ToInt32(numbers); }
                    break;
                }
                else { numbers += Convert.ToString(number); }
            }
            dateList = dayMonthYear;
        }
        public void SetAtributes(int newId)
        {
            SetId(newId);
            SetStartDate();
            SetEndeDate();
            SetProfessor();
        }

    }
}
