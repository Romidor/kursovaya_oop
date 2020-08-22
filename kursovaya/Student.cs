using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class Student
    {
        private string name;
        private List<Mark> marks;
        private int missedClassesCount;
        private float avgMark;

        public Student()
        {
            marks = new List<Mark>(10);
            avgMark = 0.0f;
            missedClassesCount = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        
        public void SetMissedClassesCount(int value)
        {
            this.missedClassesCount = value;
        }

        public int GetMissedClassesCount()
        {
            return missedClassesCount;
        }
        public float GetAverageMark()
        {
            return avgMark;
        }

        public void AddMark(int newMark)
        {
            marks.Add(new Mark(newMark));
            avgMark = CalculateAverageMark();
        }

        private float CalculateAverageMark()
        {
            int result = 0;
            for (int i = 0; i < marks.Count; i++)
            {
                result += marks[i].GetValue();
            }
            return result / marks.Count;
        }

        public void RemoveMarks()
        {
            marks.Clear();
            avgMark = 0.0f;
        }
    }
}
