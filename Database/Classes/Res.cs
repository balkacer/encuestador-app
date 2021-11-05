using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    public class Res
    {
        public dynamic Data { get; set; }
        public string Msg { get; set; }
        public bool IsError { get; set; }
        public Res(dynamic data, string message, bool isError)
        {
            this.Data = data;
            this.Msg = message;
            this.IsError = isError;
        }
    }
}
