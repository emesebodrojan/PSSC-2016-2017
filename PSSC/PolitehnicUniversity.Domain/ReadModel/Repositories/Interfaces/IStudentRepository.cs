﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitehnicUniversity.Domain.ReadModel.Repositories.Interfaces
{
    public interface IStudentRepository : IBaseRepository<StudentRM>
    {
        IEnumerable<StudentRM> GetAll();
    }
}