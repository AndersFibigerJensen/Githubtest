namespace Githubtest.Models
{
    public class Student
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public Student(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
