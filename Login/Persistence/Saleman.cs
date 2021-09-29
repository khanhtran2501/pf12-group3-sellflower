using System;

namespace Persistence
{
    public class Saleman
    (
        public string SaleName{set;get;};
        public int SaleId{set;get;};
        public string UserName{set;get;};
        public string Password{set;get;};
        public string Phone{get;set;};
        public int Role {set;get;}
        public static int SALEMAN_ROLE = 1;
    )
}