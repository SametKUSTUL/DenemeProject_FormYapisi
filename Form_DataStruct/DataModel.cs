using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_DataStruct
{
    public class DataModel
    {
        private DataModel()
        {

        }
        private static DataModel _dataModel;

        public static DataModel getInstance()
        {
            if (_dataModel == null)
            {
                _dataModel = new DataModel();
            }
            return _dataModel;
        }

        public static void setInstance(DataModel model)
        {
            _dataModel = model;
        }

        public string Date { get; set; }
        public string Time { get; set; }
        public string SerialNumber { get; set; }

    }
}
