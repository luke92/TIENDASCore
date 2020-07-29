using System;
using System.Collections.Generic;
using System.Text;

namespace TIENDAS.Data.Entities
{
    public abstract class EntityBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
