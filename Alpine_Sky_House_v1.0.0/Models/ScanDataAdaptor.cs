using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpine_Sky_House_v1._0._0.Models
{
    public class ScanDataAdaptor
    {
        public Client.Scan Map(API.Scan scan)
        {
            var mapped = Mapper.Map(scan);
            mapped.ScanDate = ConvertToLocalDAte(mapper.ScanDate);
            return mapped;
        }
    }
}
