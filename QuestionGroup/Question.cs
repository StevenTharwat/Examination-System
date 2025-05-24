using Examination.AnswerGroup;
using System.Text;

namespace Examination.QuestionGroup
{
    internal abstract class Question
    {
        public string Type { get; set; }
        public string Body { get; set; }
        public double Marks { get; set; }
        public AnswerList Answers { get; set; }

        protected Question(string _Type, string _Title, double _Marks, AnswerList _Answers)
        {
            if (_Marks < 0) throw new Exception("Marks can not be less than Zero");
            //check if null or empty
            Type = _Type;
            Body = _Title;
            Marks = _Marks;
            Answers = _Answers;
        }

        public virtual string Show()
        {
            StringBuilder sb = new();
            sb.AppendLine();
            sb.AppendLine(this.ToString());
            for (int i = 0 ; i < Answers.Count ; i++)
            {
                sb.AppendLine($"{i + 1} => {Answers[i]}");
            }
            return sb.ToString();
        }

        public virtual double Correct(AnswerList userAnsewrs)
        {
            if (userAnsewrs == null || userAnsewrs.Count == 0) return 0;

            if (userAnsewrs.Equals(GetCorrectAnswers())) return Marks;
            else return 0;
        }

        public virtual AnswerList GetCorrectAnswers()
        {
            return new AnswerList(Answers.FindAll(qu => qu.IsCorret == true));
        }

        public override string ToString()
        {
            return $"{Type}\n==> {Body} (Marks -> {Marks})";
        }
        public override int GetHashCode()
        {
            return Body.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;
            Question q = (Question) obj;
            return q.Body == Body && q.Type == Type && q.Answers == Answers;

        }
    }
}
