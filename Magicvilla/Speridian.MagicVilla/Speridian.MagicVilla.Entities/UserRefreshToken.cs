using System;
using System.Collections.Generic;

namespace Speridian.MagicVilla.Entities
{
    public partial class UserRefreshToken
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
