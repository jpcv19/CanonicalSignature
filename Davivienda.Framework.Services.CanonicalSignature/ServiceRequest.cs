using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Davivienda.Framework.Services.CanonicalSignature
{
    public class ServiceRequest<T> where T : class
    {
        public T? Body { get; set; }
    }
}
