// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;
using Практическая__9;
Mathanalysis math = new Mathanalysis(4.7, "Математический анализ");
History his = new History(4, "История");
Programming prog = new Programming(8, "Программирование");

Student s1 = new Student(); s1.Name = "Антон Мамонтов";
Student s2 = new Student(); s2.Name = "Дмитрий Алабаев";
Student s3 = new Student(); s3.Name = "Лиза Мартынова";
Student s4 = new Student(); s4.Name = "Евгений Ожегов";

s1.FinalControll.Add(math, 4.6); s1.Practices.Add(his, 3); s1.Practices.Add(prog, 9);
s2.FinalControll.Add(math, 4.8); s2.Practices.Add(his, 5); s2.Practices.Add(prog, 8);
s3.FinalControll.Add(math, 4.2); s3.Practices.Add(his, 2); s3.Practices.Add(prog, 5);

Student st = new Student();
st.Students.Add(s1);
st.Students.Add(s2);
st.Students.Add(s3);

Student dp = new Student();
dp.Disciplines.Add(math);
dp.Disciplines.Add(his);
dp.Disciplines.Add(prog);

string fs = "";

for (int i = 0; i < dp.Disciplines.Count; i++)
{
    fs += $"\n{dp.Disciplines[i].NameOfDis}\n<><><><><><><><><><><>\n";
    if (dp.Disciplines[i] is IHaveAngryTeacher)
    {
        fs += "Этот препод не даёт автоматов\n";
        continue;
    }
    for (int j = 0; j < st.Students.Count; j++)
    {
        fs += $"{dp.Disciplines[i].Check(st.Students[j], dp.Disciplines[i])}";
    }
}

Console.WriteLine(fs);
