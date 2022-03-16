using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.Dictionary
{
    public class Tabular
    {
        public List<Dictionary<string, string>> Method1(List<Dictionary<string, string>> map, string groupBy, string countField)
        {

            List<Dictionary<string, string>> resultMap = new List<Dictionary<string, string>>();
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var element  in map)
            {
                updateNumberOfItemsAvailable(result, element[groupBy], Convert.ToInt32(element[countField]));
            }

            foreach(var element in result)
            {
                Dictionary<string, string> item = new Dictionary<string, string>();
                item.Add(groupBy, element.Key);
                item.Add(countField, element.Value.ToString());
                resultMap.Add(item);
            }

            return resultMap;
        }

        public void updateNumberOfItemsAvailable(Dictionary<string, int> result, string groupBy, int num)
        {
            if (!result.ContainsKey(groupBy))
                result.Add(groupBy, 0);

            result[groupBy] = result[groupBy] + num;
        }


    }
}
