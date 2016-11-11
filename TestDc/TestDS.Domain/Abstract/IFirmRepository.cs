using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDS.Domain.Enteties;

namespace TestDS.Domain.Abstract
{
    public interface IFirmRepository
    {
        IEnumerable<Firm> Firms { get; }
    }
}
