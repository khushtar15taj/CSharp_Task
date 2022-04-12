using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11th_April_2022_Join
{
    internal class Join
    {
        IList<Doctor> doctorlist = new List<Doctor>()
            {
                new Doctor(){doctorID=1,FName="Suresh", LName = "Kumar",specialistID=1},
                new Doctor(){doctorID=1,FName="Lata", LName = "Jawahar",specialistID=2},
                new Doctor(){doctorID=1,FName="Gnanabalan", LName = "Kumar",specialistID=3},
                new Doctor(){doctorID=1,FName="Geetanjali", LName = "kumari",specialistID=4},
                new Doctor(){doctorID=1,FName="vasikumaran", LName = "raghavendra",specialistID=5}
            };
        IList<Specialist> specialityList = new List<Specialist>()
            {
                new Specialist(){SpecialistID=1, SpecialityIn="ENT"},
                new Specialist(){SpecialistID=2, SpecialityIn="Gynaecology"},
                new Specialist(){SpecialistID=3, SpecialityIn="Paediatrics"},
                new Specialist(){SpecialistID=4, SpecialityIn="Neurology"}
            };
        public void JoinMethod()
        {
            var result = doctorlist.Join(
           specialityList,
           d => d.specialistID,
           s => s.SpecialistID,
           (d, s) => new
           {
               firstName = d.FName,
               lastName = d.LName,
               Specialist = s.SpecialityIn
           }
           ).ToList();
            result.ForEach(x => Console.WriteLine(x.firstName + " " + x.lastName + " " + x.Specialist));
            Console.ReadLine();
        }
    }
}
