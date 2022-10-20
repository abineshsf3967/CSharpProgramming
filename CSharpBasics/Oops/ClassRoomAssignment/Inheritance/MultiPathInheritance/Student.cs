namespace MultiPathInheritance
{
    public class Student:ISport,IAcademic
    {
        public int AcademisMark { get; set; }

        public string Name { get; set; }
        public int SportMark { get; set; }


        public Student(string name,int academicMark,int sportMark)
        {
            Name=name;
            AcademisMark=academicMark;
            SportMark=sportMark;
        }

        public void Display()
        {
            System.Console.WriteLine("Name: "+Name+"\nTotal Mark: "+(SportMark+AcademisMark));
        }

    }
}