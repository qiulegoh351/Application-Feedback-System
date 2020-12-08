using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationFeedbackSystem
{
    public class FeedBackPage
    {
        private int code;
        private string interviewee;
        private string email;
        private string describe;
        private string feebbackType;
        private string interviewer;
        

        public FeedBackPage()
        {

        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Interviewee
        {
            get { return interviewee; }
            set { interviewee = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Describe
        {
            get { return describe; }
            set { describe = value; }
        }

        public string Interviewer
        {
            get { return interviewer; }
            set { interviewer = value; }
        }

        public string FeedbackType
        {
            get { return feebbackType; }
            set { feebbackType = value; }
        }
    }
}
