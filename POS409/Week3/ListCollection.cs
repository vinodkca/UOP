using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    struct ListCollection
    {
        //Default is private
        public List<string> nameList;

        public List<string> CreateList()
        {
            nameList.Add("Chris");
            nameList.Add("Kathryn");
            nameList.Add("Bill");
            return nameList;
        }

        public void RemoveList(int iIndex)
        {
            nameList.RemoveAt(iIndex);
        }

        public void RemoveList(string strValue)
        {
            nameList.Remove(strValue);
        }

    }
}
