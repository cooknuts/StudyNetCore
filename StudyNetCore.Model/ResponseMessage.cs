using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyNetCore.Model
{
    public enum ResultCode
    {

    }
    public class Result<T>
    {
        private ResultCode code;
        private string message;
        private T data;
        public Result(ResultCode code, string message, T data)
        {
            this.code = code;
            this.message = message;
            this.data = data;
        }
    }
}
