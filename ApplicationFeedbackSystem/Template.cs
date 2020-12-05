using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationFeedbackSystem
{
    public class Template
    {
        private int code;
        private string interviewee;
        private string gender;
        private int age;
        private DateTime dateOfBirth;
        private string email;
        private string contactNum;
        private string city;
        private string state;
        private string address;
        private string type;
        private string positionApplication;
        private string interviewer;

        public Template()
        {
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public String Interviewee
        {
            get { return interviewee; }
            set { interviewee = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string ContactNum
        {
            get { return contactNum; }
            set { contactNum = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Position
        {
            get { return positionApplication; }
            set { positionApplication = value; }
        }

        public string Interviewer
        {
            get { return interviewer; }
            set { interviewer = value; }
        }
    }
}
