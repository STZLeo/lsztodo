using System;
using System.Collections.Generic;
using System.Text;

namespace LSZTodo.Test.Helpers
{
    public class NullScope : IDisposable
    {
        public void Dispose(){ }
        public static NullScope Instace { get; set; }

        private NullScope() { }
    }
}
