using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Models
{
    public class SetStatus{

        public SetStatus() { }

        public void Set(RequstStatus rs,Exception ex)
        {
            //switch(ex.GetType())
            //{ 
            //    case ex
            //}

            rs.error.errorCode = ex.GetType().ToString();
            rs.error.errorMessage = ex.Message;
            rs.success = false;
            rs.warning.warningMessage = ex.ToString();
            throw new NotImplementedException();
        }

    }

}
