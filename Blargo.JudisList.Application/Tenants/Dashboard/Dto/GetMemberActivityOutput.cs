﻿using System.Collections.Generic;

namespace Blargo.JudisList.Tenants.Dashboard.Dto
{
    public class GetMemberActivityOutput
    {
        public List<int> TotalMembers { get; set; }

        public List<int> NewMembers { get; set; }
    }
}