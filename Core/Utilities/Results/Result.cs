using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
 
        public Result(bool success, string message):this(success)//kendi diğer const. ını çağırıyor.
        {
            
            this.Message = message;
        }
        public Result(bool success)
        {
            this.Success = success;
            
        }
        //public Result(bool success)
        //{
        //    if (success)
        //    {
        //        this.Message = "Product Added";
        //    }
        //    else
        //    {
        //        this.Message = "Product didn't Add";
        //    }
        //    this.Success = success;
        //}


        public bool Success { get; }

        public string Message { get; }
    }
}
