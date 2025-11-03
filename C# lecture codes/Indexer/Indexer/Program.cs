using StaticClassExample;


// Indexer yazdigimiz classlara indexlerle daxil olmaga icaze veren property-dir
// indexerde yazdigimiz "this" keywordu classin ozunu gosterir yeni Group classi
// this[int index] => group[0]

Student student_1 = new Student {Name = "Ali", Fin = "a1" };
Student student_2 = new Student {Name = "Vali", Fin = "a2" };
Student student_3 = new Student {Name = "Mehseti", Fin = "a3" };

Student[] studentArr = new Student[] {student_1, student_2, student_3};

Group group = new Group { _students = studentArr , Name = "APA"};


// asagidaki kodu daha sade sekilde yazmaq isteyirik
//   group._students[2].Name => group[0].Name 

//Console.WriteLine(group._students[2].Name);

Console.WriteLine(group[1].Name);

Console.WriteLine(group["a3"].Name);

// exception evezine mesaj gormek

Student findStudent = group["a4"];
//Student findStudent = group["a3"];
if(findStudent is null)
{
    Console.WriteLine("Not found");
}
else
{
    {
        Console.WriteLine(findStudent.Name);
    }
}

// try catch ile ede bilerik eyni isi

try
{
    Student findStudentt = group["a5"];
    Console.WriteLine(findStudentt.Name);
}

catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

