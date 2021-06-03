using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
namespace json_mvc
{
    public class item
    {
        public int itemID
        {
            get;
            set;
        }

        public string Itemname
        {
            get;
            set;
        }

        public int Itemprice
        {
            get;
            set;
        }

    }
}
