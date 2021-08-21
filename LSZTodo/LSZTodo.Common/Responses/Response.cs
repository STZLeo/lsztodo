using System;
using System.Collections.Generic;
using System.Text;

namespace LSZTodo.Common.Responses
{
    public class Response
    {
        public Boolean IsSuccess { get; set; }
        public String Message { get; set; }

        public Object Result { get; set; }
    }
}
