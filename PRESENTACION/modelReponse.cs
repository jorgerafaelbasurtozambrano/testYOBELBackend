using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class modelReponse<T>
    {
        public modelReponse(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
