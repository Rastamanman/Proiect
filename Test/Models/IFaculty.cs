﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public interface IFaculty
    {
        List<IStudent> GetStudsFor(ISpecialization spec);
        List<IStudent> GetAllStudents();
        IStudent GetStudById(int id);
        void RemoveStudent(int id);
        void AddStudent(IStudent stud);
        ISpecialization GetSpec(string name);
        void UpdateStudent(int index, IStudent stud);
    }
}
