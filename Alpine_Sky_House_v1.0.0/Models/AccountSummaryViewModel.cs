using System;
using System.Collections.Generic;

namespace Alpine_Sky_House_v1._0._0.Models
{
    public class AccountSummaryViewModel
    {
        public Guid UserId { get; set; }
        public int YearsOfMembership { get; set; }
        public bool IsCurrentSeasonPassHolder { get; set; }
        public List<string> IncludeFamilyMembers { get; set; }
    }
}
