﻿using Intro.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        
        void Update(Course course);
        void Delete(int id);

        List<Course> GetAll();
    }
}
