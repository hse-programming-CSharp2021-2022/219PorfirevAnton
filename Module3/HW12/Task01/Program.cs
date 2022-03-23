using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Task01
{
    [Serializable]
    [XmlInclude(typeof(Professor)),
    XmlType]
    [KnownTypeAttribute(typeof(Professor))]
    public class Human
    {
        [DataMember]
        public string Name { get; set; }
        public Human(string name)
        {
            Name = name;
        }
        public Human() { }
    }
    [Serializable]
    public class Professor: Human
    {
        // "Вот удивительно, сколько супер-злодеев имеют докторскую степень. Аспирантуре следует проводить более тщательный отбор" - Шелдон, Теория большого взрыва.
        [DataMember]
        public bool IsVillain { get; set; } 
        public Professor(string name, bool isVillain): base(name)
        {
            IsVillain = isVillain;
        }
        public Professor() { }
    }
    [Serializable]
    [XmlInclude(typeof(List<Human>)),
    XmlType]
    public class Departament
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public List<Human> Workers { get; set; }
        public Departament(string title)
        {
            Title = title;
            Workers = new List<Human>();
        }
        public Departament() { }
    }
    [Serializable]
    [XmlInclude(typeof(List<Departament>)),
    XmlType]
    public class University
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public List<Departament> Departaments { get; set; }
        public University(string title, List<Departament> departaments)
        {
            Title = title;
            Departaments = departaments;
        }
        public University() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human spiderMan = new Human("Peter Parker");
            Professor DoctorOctopus = new Professor("Otto Octavius", true);
            Human bruceHelper = new Human("Betty Ross");
            Professor Hulk = new Professor("Bruce Banner", false);
            Departament OttosDepartment = new Departament("Spider Team");
            OttosDepartment.Workers.Add(spiderMan);
            OttosDepartment.Workers.Add(DoctorOctopus);
            Departament BrucesDepartment = new Departament("Hulk Team");
            BrucesDepartment.Workers.Add(bruceHelper);
            BrucesDepartment.Workers.Add(Hulk);
            University MarvelUniversity = new University("Marvel", new List<Departament>() { OttosDepartment, BrucesDepartment });

            Human spiderMan2 = new Human("Peter Parker 2");
            Professor DoctorOctopus2 = new Professor("Otto Octavius 2", true);
            Human bruceHelper2 = new Human("Betty Ross 2");
            Professor Hulk2 = new Professor("Bruce Banner 2", false);
            Departament OttosDepartment2 = new Departament("Spider Team 2");
            OttosDepartment2.Workers.Add(spiderMan2);
            OttosDepartment2.Workers.Add(DoctorOctopus2);
            Departament BrucesDepartment2 = new Departament("Hulk Team 2");
            BrucesDepartment2.Workers.Add(bruceHelper2);
            BrucesDepartment2.Workers.Add(Hulk2);
            University MarvelMultiverseUniversity = new University("Marvel 2", new List<Departament>() { OttosDepartment2, BrucesDepartment2 });

            List<University> arr = new List<University>() { MarvelUniversity, MarvelMultiverseUniversity};

            DataContractJsonSerializer format = new DataContractJsonSerializer(typeof(List<University>));
            using (FileStream fs = new FileStream("info.json", FileMode.OpenOrCreate))
            {
                format.WriteObject(fs, arr);
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<University>));
            using (FileStream fs = new FileStream("info.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, arr);
            }
        }
    }
}
