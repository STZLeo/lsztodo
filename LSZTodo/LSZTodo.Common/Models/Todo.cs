using System;
using System.Collections.Generic;
using System.Text;

namespace LSZTodo.Common.Models
{
    public class todo
    {
        public DateTime CreatedTime { get; set; }
        public String TaskDescription { get; set; }
        public Boolean IsCompleted { get; set; }
    }
}
