using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScienceInternalAssessment.Models
{
    public class SwimmerMeetModel
    {
        //public SwimmerEventResultModel SwimmerResultName;
        //public SwimmerEventResultModel SwimmerResultTime;
        public String SwimmerMeetName
        {
            get;
            set;
        }

        public String SwimmerMeetDate
        {
            get;
            set;
        }

        public String SwimmerResultName
        {
            get;
            set;
        }

        public String SwimmerResultTime
        {
            get;
            set;
        }

        public SwimmerMeetModel(String meetName, String meetDate, String EventResultName, String EventResultTime)
        {
            SwimmerMeetName = meetName;
            SwimmerMeetDate = meetDate;
            SwimmerResultName = EventResultName;
            SwimmerResultTime = EventResultTime;
        }
        
        public SwimmerMeetModel()
        {

        }
    }
}
