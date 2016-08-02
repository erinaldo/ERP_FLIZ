using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FiltroLys.Domain.Funciones
{
    public static class negListData
    {
        public static DataTable ToDataTable<TSource>(this IList<TSource> data)
        {
            DataTable dataTable = new DataTable(typeof(TSource).Name);
            PropertyInfo[] props = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (TSource item in data)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        public static List<TSource> ToList<TSource>(this DataTable dataTable) where TSource : new()
        {
            var dataList = new List<TSource>();
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;
            
            var objFieldNames = (from FieldInfo aProp in typeof(TSource).GetFields(flags)
                                 select new { Name = aProp.Name, Type = Nullable.GetUnderlyingType(aProp.FieldType) ?? aProp.FieldType }).ToList();
            
            var dataTblFieldNames = (from DataColumn aHeader in dataTable.Columns
                                        select new { Name = aHeader.ColumnName, Type = aHeader.DataType }).ToList();
            
            var commonFields = from LstA in objFieldNames
                               join LstB in dataTblFieldNames on LstA.Name.ToString().ToUpper() equals LstB.Name.ToString().ToUpper()
                               select new { LstA.Name, LstA.Type };

            foreach (DataRow dataRow in dataTable.AsEnumerable().ToList())
            {
                var aTSource = new TSource();
                foreach (var aField in commonFields)
                {
                    String sfield = aField.Name.Substring(2, aField.Name.Length-2);
                    PropertyInfo propertyInfos = aTSource.GetType().GetProperty(sfield);
                    var value = (dataRow[aField.Name] == DBNull.Value) ? null : dataRow[aField.Name];                    
                    propertyInfos.SetValue(aTSource, value, null);
                }
                dataList.Add(aTSource);
            }
            return dataList;
        }
    
    }
}
