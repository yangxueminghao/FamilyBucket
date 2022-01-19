using FamilyBucket.Aop.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBucket.Aop.Client.Service
{
    public interface IStudentService
    {
        Student Get(long id);
    }
}
