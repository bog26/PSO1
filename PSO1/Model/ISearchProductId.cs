using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public interface ISearchProductId: IPSOEntity
    {
       int ProductId { get; set; }
    }
}
