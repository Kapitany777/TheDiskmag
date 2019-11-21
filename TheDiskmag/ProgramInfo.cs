using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiskmag
{
    public static class ProgramInfo
    {
        #region Static properties
        public static string ProgramName { get; set; }
        public static string ProgramVersion { get; set; }
        public static string ProgramAuthor { get; set; }
        #endregion

        public static string GetProgramTitle()
        {
            return $"{ProgramName} ({ProgramVersion})";
        }
    }
}
