using Examination.AnswerGroup;

namespace Examination.QuestionGroup
{
    internal class ChooseOne : Question
    {
        public ChooseOne(string _Title, double _Marks, AnswerList list) : base("Choose One Answer", _Title, _Marks, CheckChooseOne(list))
        {

        }

        private static AnswerList CheckChooseOne(AnswerList list)
        {
            if (list.FindAll(li => li.IsCorret == true).Count > 1)
                throw new Exception("ChooseOne question must have only one correct answer");
            else
                return list;
        }
    }
}
