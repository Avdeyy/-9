using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__9
{

    public abstract class Discipline
    {
        public string? NameOfDis;
        public abstract string Check(Student st, Discipline dp);
    }

    public interface IHaveAngryTeacher
    {

    }

    public interface IHavePractice
    {
        int PracticeCount { get; set; }
    }

    public interface IHaveFinalControll
    {
        double PassingScore { get; set; }
    }

    public class Mathanalysis : Discipline, IHaveFinalControll
    {
        public double PassingScore { get; set; }

        public Mathanalysis(double passingScore, string Name)
        {
            PassingScore = passingScore;
            NameOfDis = Name;
        }
        public override string Check(Student st, Discipline dp)
        {
            if (st.FinalControll[dp] >= PassingScore)
                return $"{st.Name} получил достаточный балл на итоговой аттестации и может расчитывать на получение автомата\n";

            return $"{st.Name} не получил достаточный балл на итоговой аттестации и НЕ может расчитывать на получение автомата\n";
        }
    }
    public class History : Discipline, IHavePractice, IHaveAngryTeacher
    {
        public int PracticeCount { get; set; }

        public History(int passingScore, string Name)
        {
            PracticeCount = passingScore;
            NameOfDis = Name;
        }
        public override string Check(Student st, Discipline dp)
        {
            if (st.Practices[dp] >= PracticeCount)
                return $"{st.Name} успел сдать все практические работы вовремя и может расчитывать на получение автомата\n";

            return $"{st.Name} не успел сдать все практические работы вовремя и НЕ может расчитывать на получение автомата\n";
        }
    }
    public class Programming : Discipline, IHavePractice
    {
        public int PracticeCount { get; set; }

        public Programming(int passingScore, string Name)
        {
            PracticeCount = passingScore;
            NameOfDis = Name;
        }
        public override string Check(Student st, Discipline dp)
        {
            if (st.Practices[dp] >= PracticeCount)
                return $"{st.Name} успел сдать все практические работы вовремя и может расчитывать на получение автомата\n";

            return $"{st.Name} не успел сдать все практические работы вовремя и НЕ может расчитывать на получение автомата\n";
        }
    }
    public class Student
    {
        public List<Student> Students = new List<Student>();
        public List<Discipline> Disciplines = new List<Discipline>();
        public Dictionary<Discipline, double> FinalControll = new Dictionary<Discipline, double>();
        public Dictionary<Discipline, double> Practices = new Dictionary<Discipline, double>();
        public string? Name { get; set; }
    }
}
