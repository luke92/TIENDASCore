using System;
using System.Collections.Generic;
using System.Text;

namespace TIENDAS.Business.Modules.Shared.Models
{
    public abstract class BaseModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
