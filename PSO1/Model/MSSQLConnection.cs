using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    //public class MSSQLConnection : IDbConnection<psDBContext>
    //public class MSSQLConnection<T> : IDbConnection<T> where T: psDBContext,IDbContext, new()
    //public class MSSQLConnection<T> where T : psDBContext, new() //psDBContext, IDbContext,  //ok
    public class MSSQLConnection<T> where T : IDbContext, new()
        //public class MSSQLConnection<T> where T : new() //ok
    {

        public T Context { get; set; }
        public MSSQLConnection()
        {
            Context = new T();
        }
        public T Connection()
        {
            return new T();
        }

    }
}
