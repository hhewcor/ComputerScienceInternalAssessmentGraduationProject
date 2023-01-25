using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.SwimmerGoalModel;

namespace ComputerScienceInternalAssessment.Models
{
    public class Swimmer : SwimmerMeetModel
    {
        //public SwimmerMeetModel sm;
        public String FirstName
        {
            get;
            set;
        }
        public String LastName
        {
            get;
            set;
        }

        public String Gender
        {
            get;
            set;
        }

        public String Grade
        {
            get;
            set;
        }

        //public <SwimmerMeetModel> meets = new <SwimmerMeetModel>();

        public Swimmer()
        {

        }

        

       /* public Swimmer(Swimmer s, SwimmerMeetModel m)
        {
            sm = m;
        }
       */

        public Swimmer(string fn, string ln, string gend, string grd)
        {
            FirstName = fn;
            LastName = ln;
            Gender = gend;
            Grade = grd;
            //swimmerMeet = sm;
        }


        /*public String SwimmerEventTime
       {
            get;
            set;
        }
        */

        //public SwimmerModel()
        //{

        // }

        /*
        public SwimmerModel(string n)
        {
            Swimmer = n;
        }

        public static List<SwimmerModel> GetSwimmerList()
        {
            return new List<SwimmerModel>
            {
                new SwimmerModel("Swimmer 1"),
                new SwimmerModel("Swimmer 2"),
                new SwimmerModel("Swimmer 3")
            };
        }
        */
    }
}
