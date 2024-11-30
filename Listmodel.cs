using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceBusiness.Tote
{
    public class Listmodel : Result
    {
        public Listmodel()
        {
            incomplete_tote = new List<incomplete_tote>();
        }
        public string Gi_NO { get; set; }
        public int? Pick_PC { get; set; }
        public int? Pick_PNC { get; set; }
        public int? Pick_NP { get; set; }
        public int? total { get; set; }

        public List<incomplete_tote> incomplete_tote { get; set; }
    }

    public class incomplete_tote 
    {
        public string incomplete_tagout_no { get; set; }
        public string message { get; set; }
    }

    public class Result
    {
        public bool resultIsUse { get; set; }

        public string resultMsg { get; set; }

       
    }
}
