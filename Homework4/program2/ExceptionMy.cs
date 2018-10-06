using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class ExceptionMy:ApplicationException
    {
        private int idnumber;
        public ExceptionMy(string message,int id)
            :base(message)
        {
            this.idnumber = id;
        }
        public int getId()
        {
            return idnumber;
        }

    }
}
