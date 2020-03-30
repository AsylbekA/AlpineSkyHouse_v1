using System;
using System.Collections.Generic;

namespace Alpine_Sky_House_v1._0._0.Models
{
    public class DigiatalAsset
    {
        public Guid AssetId { get; set; }
        public Guid AssetOwnerId { get; set; }
        public string  Titile { get; set; }
        public string Descrption { get; set; }
        public Uri AccessUri { get; set; }

    }
}
