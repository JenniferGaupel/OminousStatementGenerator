using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSGenerator.Models
{
    public class Statement
    {
        public List<string> firstStatement { get; set; }
        public List<string> secondStatement { get; set; }
        public List<string> thirdStatement { get; set; }
        public List<string> fourthStatement { get; set; }
    }

    public class Root
    {
        public List<Statement> statements { get; set; }
    }

}