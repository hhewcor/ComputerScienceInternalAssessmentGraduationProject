using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScienceInternalAssessment.Models
{
    public class SwimmerMeetModel : SwimmerGoalModel
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

        public void addMeets(List<SwimmerMeetModel> m)
        {
            /*foreach (var swimmer in m) 
                //List<SwimmerMeetModel> SwimmerMeet = new List<SwimmerMeetModel>();
                SwimmerMeetName = "Rabbit Sprintoff",
              SwimmerMeetDate = "1 / 13 / 22",
                SwimmerResultName = "500 Free",
                SwimmerResultTime = "8:34.21"
            */
        }
        
        public SwimmerMeetModel()
        {

        }
    }
}
