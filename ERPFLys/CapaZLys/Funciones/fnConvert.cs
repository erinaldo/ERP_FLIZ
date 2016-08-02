using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FiltroLys.ZLys.Funciones
{
    public static class fnConvert
    {
        public static List<Destination> EntityToObject<Source, Destination>(List<Source> sourceList) where Source : Destination
        {
            List<Destination> result = new List<Destination>();

            foreach (Source aSource in sourceList)
                result.Add(aSource);

            return result;
        }
        
        public static List<T> ObjectToEntity<T>(List<object> value) where T : class
        {
            List<T> newlist = value.Cast<T>().ToList();
            return newlist;
        }

    }
}
