using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScienceInternalAssessment.Models
{
    public class SwimmerEventResultModel
    {

        public String SwimmerEventResultTime
        {
            get;
            set;
        }

        public String SwimmerEventResultName
        {
            get;
            set;
        }

        public SwimmerEventResultModel(string resultName, string resultTime)
        {
            SwimmerEventResultName = resultName;
            SwimmerEventResultTime = resultTime;
        }
    }
}
