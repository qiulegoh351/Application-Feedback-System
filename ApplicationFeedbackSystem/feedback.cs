using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationFeedbackSystem
{
    class feedback
    {
        private string Code;
        private string Interviewee;
        private string Email;
        private string Description;
        private string FeedbackType;
        private string Interviewer;

        public feedback()
        {

        }

        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        public string interviewee
        {
            get { return Interviewee; }
            set { Interviewee = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string feedbackType
        {
            get { return FeedbackType; }
            set { FeedbackType = value; }
        }

        public string interviewer
        {
            get { return Interviewee; }
            set { interviewer = value; }
        }
    }
}
