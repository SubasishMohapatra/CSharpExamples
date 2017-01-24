using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQExamples
{
    public class SampleClass
    {
        List<Person> persons = new List<Person>();
        public SampleClass()
        {

        }

        public void Initialize()
        {
            persons.Add(new Person() { Name = "ABC", JoiningDate = DateTime.Now.Date});
            persons.Add(new Person() { Name = "DEF", JoiningDate = DateTime.Now.Date.AddDays(-100) });
            persons.Add(new Person() { Name = "GH", JoiningDate = DateTime.Now.Date.AddDays(-200) });
            persons.Add(new Person() { Name = "IJK", JoiningDate = DateTime.Now.Date.AddDays(-300) });
            persons.Add(new Person() { Name = "LMN", JoiningDate = DateTime.Now.Date.AddDays(-100) });
            persons.Add(new Person() { Name = "OPQ", JoiningDate = DateTime.Now.Date.AddDays(-200) });
            persons.Add(new Person() { Name = "RST", JoiningDate = DateTime.Now.Date.AddDays(-400) });
            persons.Add(new Person() { Name = "UVW", JoiningDate = DateTime.Now.Date.AddDays(-500) });
            persons.Add(new Person() { Name = "XYZ", JoiningDate = DateTime.Now.Date.AddDays(-200) });
            persons.Add(new Person() { Name = "ALPHA", JoiningDate = DateTime.Now.Date.AddDays(-100) });
            persons.Add(new Person() { Name = "GAMMA", JoiningDate = DateTime.Now.Date.AddDays(-600) });
            persons.Add(new Person() { Name = "BETA", JoiningDate = DateTime.Now.Date.AddDays(-800) });
        }

        private List<Person> Persons
        {
            get { return persons; }
        }

        public dynamic GetPeopleByJoiningDate(int year)
        {
            return from p in persons
                          group p.Name by p.JoiningDate.Year into g
                          select new { JoiningDate = g.Key, Names = g.ToList() };
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
