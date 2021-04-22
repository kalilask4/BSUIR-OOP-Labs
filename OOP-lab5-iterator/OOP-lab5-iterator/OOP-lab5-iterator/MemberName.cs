using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab5_iterator
{
    class MemberName
    {
        int end;
        string[] memberNames =
        {
            "BNikita",
            "GSamanta",
            "GVadim",
            "JNatalia",
            "JAndrey",
            "ZVladimir",
            "KAndrey",
            "Kvladimir",
            "KNadegda",
            "KVitaliy",
            "11"
        };

        public MemberName()
        {
            this.end = 21;
        }

        public IEnumerable MyMemberName(int begin, int end)
        {
            for (int i=begin; i <= end; i++)
                {

                if (i < 1 || i > memberNames.Length)
                        yield break;
                yield return (string)(memberNames[i - 1]);

            }
        }


    }
}
