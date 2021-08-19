using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml;

namespace OnlineAuction.XML
{
    public class QueryManager
    {
        public string LoadSqlFile(string query,string location)
        {
            try
            {
                string sqlQuery = "";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(System.Web.HttpContext.Current.Server.MapPath("~/XML/" + location + ".xml"));
                XmlElement elt = xmlDoc.SelectSingleNode(location) as XmlElement;
                if (elt != null)
                {
                    XmlElement element = elt.SelectSingleNode(query) as XmlElement;
                    sqlQuery = element.InnerText;
                }
                sqlQuery = sqlQuery.Replace("\r\n", " ");
                return sqlQuery;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}