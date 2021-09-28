using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.Devices;
using Json.Net;
using Newtonsoft.Json;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace HotelProject1._0
{ 
    class SaveInfo
    {
        private static string pathUser = "UserDataBase.json";
        private static string pathHotel = "HotelDataBase.json";
        private static SaveInfo _instance = null;
        private SaveInfo() { }
        public static SaveInfo GetInstance()
        {
            if (_instance == null)
                _instance = new SaveInfo();   
            return _instance;
        }
        public void SaveUser<T>(T data)
        {
            string path = null;
            if (data is User)
                path = pathUser;
            else if (data is Hotel)
                path = pathHotel;

            if (!File.Exists(path))
                File.Create(path).Close();
            string content = File.ReadAllText(path);
            List<T> dataList = JsonConvert.DeserializeObject<List<T>>(content)
                ?? new List<T>();
            dataList.Add(data);
            string json = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            File.WriteAllText(path, json); 
        }
    }

    
}
