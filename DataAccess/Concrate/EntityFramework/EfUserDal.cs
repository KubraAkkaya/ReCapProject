using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfUserDal : EfEntityRepository<User, ReCapProjectDbContext>,IUserDal
    {
       
    }
}
