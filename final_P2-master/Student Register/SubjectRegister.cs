using System;
using System.Collections.Generic;

namespace Student_Register
{
    class SubjectRegister
    {
        private int id;
        private List<int> startDate = new List<int>();
        private List<int> endDate = new List<int>();
        private string classRoom, professor, subject;
        //private Subject
        private StudentList subjectRegisterStudents = new StudentList();

        public int Id { get { return this.id; } }
        public string Subject { get { return this.subject; } }
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
    }
}
