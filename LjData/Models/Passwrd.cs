using System;

namespace LjData.Models
{
    public partial class Passwrd
    {
        public string EmpnPsw { get; set; }
        public string PswdPsw { get; set; }
        public DateTime? EdatPsw { get; set; }
        public DateTime? CreaPsw { get; set; }
        public bool? LockPsw { get; set; }
        public DateTime? ExpdPsw { get; set; }
        public DateTime? LlgnPsw { get; set; }
    }
}
