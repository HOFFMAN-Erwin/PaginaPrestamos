using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrestamosBD.Data
{
    [Index(nameof(Id), Name = "IdUsuario_UQ", IsUnique = true)]
    public class EntityBase
    {
        public int Id { get; set; }
    }
}
