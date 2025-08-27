using System.Data;
using Vad.Magic.Logic.Data;
using Vad.Magic.Logic.Data.Table;
using Vad.Magic.Titan.Data;
using Vad.Magic.Titan.Logic.CSV;
using Vad.Magic.Titan.Logic.Debug;

namespace Vad.Magic.Logic.Data.Tables
{

    public class LogicDataTables
    {
        private static LogicDataTable[] _tables = new LogicDataTable[30];

        private const int COUNT = 52;

        public static LogicData? GetDataById(int id)
        {
            int classID = GlobalID.GetClassId(id) - 1;

            if (classID >= 0 && classID < COUNT && _tables[classID] != null)
            {
                return _tables[classID].GetItemById(id);
            }
            return null;
        }
    }
}