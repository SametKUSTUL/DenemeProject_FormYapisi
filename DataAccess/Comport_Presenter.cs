using Form_DataStruct;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Comport_Presenter
    {
        

        private Comport_Presenter()
        {
            string stringjson = File.ReadAllText("C:/Users/Bt-skustul/Desktop/deneme1.json");
            DataModel json= JsonConvert.DeserializeObject<DataModel>(stringjson);
            DataModel.setInstance(json);
        }
        private static Comport_Presenter _comportPresenter;

        public static Comport_Presenter getInstance()
        {
            if (_comportPresenter == null)
            {
                _comportPresenter = new Comport_Presenter();
            }
            return _comportPresenter;
        }
       
    }
}
