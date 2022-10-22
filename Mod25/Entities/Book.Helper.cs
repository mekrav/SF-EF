using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Entities
{
    public partial class Book
    {
        public override string ToString()
        {
            return
                "Название: " + Title + "\n" +
                "Автор:" + Author + "\n" +
                "Жпнр: " + Genre + ", Год издания:" + Year + ", Внутренний иденьтификатор: " + Id + "\n" +
                "----------";
        }
    }
}
