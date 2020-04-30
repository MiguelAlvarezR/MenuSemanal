using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuSemanal.Clases
{
    public class DataAccess : IDisposable
    {
        //protected LiteDatabase connection;

        public DataAccess()
        {
          // connection = new LiteDatabase(@"MenuSemanal.db");
        }

        public void Insert<T>(T model)
        {
            // connection.
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
