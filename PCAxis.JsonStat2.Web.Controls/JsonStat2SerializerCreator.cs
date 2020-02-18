﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PCAxis.Paxiom;
using System.Configuration;

namespace PCAxis.JsonStat2.Web.Controls
{
    public class JsonStatSerializerCreator : PCAxis.Web.Core.ISerializerCreator
    {
        public PCAxis.Paxiom.IPXModelStreamSerializer Create(string fileInfo)
        {
            var ser = new PCAxis.Serializers.JsonStat2.JsonStat2Serializer();

            //var geoVariablesStr = ConfigurationManager.AppSettings["geoVariables"];

            //if (!string.IsNullOrEmpty(geoVariablesStr))
            //{
            //    ser.GeoVariableCodes = geoVariablesStr.Split(",".ToCharArray());
            //}

            return ser;
        }
    }
}
