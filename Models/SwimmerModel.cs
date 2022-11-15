using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScienceInternalAssessment.Models
{
    public class SwimmerModel
    {
        public String SwimmerFirstName
        {
            get;
            set;
        }
        public String SwimmerLastName
        {
            get;
            set;
        }

        public char SwimmerGender
        {
            get;
            set;
        }

        public int SwimmerGrade
        {
            get;
            set;
        }

        public String SwimmerEventTime
        {
            get;
            set;
        }

        public SwimmerModel()
        {

        }

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
