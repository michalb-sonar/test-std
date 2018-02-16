using Newtonsoft.Json.Linq;
using System;

namespace standard
{
    public class ClassStd
    {

        public string Do()
        {
            string jsonString = @"{ 'status': 'all fine!' }";
            var json = JObject.Parse(jsonString);
            return json["status"].ToString();
        }

    }
}
