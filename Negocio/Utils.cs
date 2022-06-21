using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Utils
    {
        public static void parse<T>(object sourceObject, ref T destObject)
        {
            if (sourceObject == null || destObject == null)
                return;

            Type sourceType = sourceObject.GetType();
            Type targetType = destObject.GetType();

            foreach (PropertyInfo p in sourceType.GetProperties())
            {
                PropertyInfo targetObj = targetType.GetProperty(p.Name);

                if(targetObj == null)
                    continue;

                targetObj.SetValue(destObject, p.GetValue(sourceObject, null), null);
            }

        }



    }
}
