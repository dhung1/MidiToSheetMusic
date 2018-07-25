using MidiSheetMusic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiToSheet
{
    class SheetMusicPage
    {
        public List<Staff> staffs;
        public int StartTime { get { return staffs.First().StartTime; } }
        public int EndTime { get { return staffs.Last().EndTime; } }

        public SheetMusicPage()
        {
            staffs = new List<Staff>();
        }

        public bool IsEmpty()
        {
            return staffs.Count == 0;
        }
    }
}
