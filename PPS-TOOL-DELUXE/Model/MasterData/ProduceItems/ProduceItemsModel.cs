using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace PPS_TOOL_DELUXE.Model.MasterData.ProduceItems
{
    public class ProduceItemsModel
    {
        private static readonly string DEFAULTFILE = "/masterdata/produce-items.xml";
        private static ProduceItemsModel _instance;
        private produceItems _produceItems;

        private ProduceItemsModel() => LoadXmlFile();

        public static ProduceItemsModel GetInstance()
        {
            return _instance ?? (_instance = new ProduceItemsModel());
        }

        public List<produceItemsItem> GetProduceItems() => _produceItems.item.ToList();

        private void LoadXmlFile()
        {
            var path = "." + DEFAULTFILE;
            /*if (File.Exists(path))
            {
                var reader = new FileStream(path, FileMode.Open);
            }
            else
            {
                //TODO read from ressources
            }*/

            var settings = new XmlReaderSettings();
            var xmlReader = XmlReader.Create(path, settings);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(produceItems));
            _produceItems = (produceItems)serializer.Deserialize(xmlReader);

            xmlReader.Close();

        }

        public void SaveXmlFile()
        {
            if (!Directory.Exists("./masterdata/"))
                Directory.CreateDirectory("./masterdata/");

            var path = "." + DEFAULTFILE;
            var settings = new XmlWriterSettings();
            var xmlWriter = XmlWriter.Create(path, settings);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(produceItems));
            serializer.Serialize(xmlWriter, _produceItems);

            xmlWriter.Close();
        }
    }

    
}
