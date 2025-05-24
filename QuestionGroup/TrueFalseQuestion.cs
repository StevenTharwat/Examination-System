using Examination.AnswerGroup;

namespace Examination.QuestionGroup
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string _Title, double _Marks, bool IsTrue)
            : base("True and False Question", _Title, _Marks, GetTFList(IsTrue))
        { }

        public static AnswerList GetTFList(bool IsTrue)
        {
            AnswerList TFQuestion =
            [
                new Answer("True", IsTrue),
                new Answer("False", !IsTrue)
            ];
            return TFQuestion;
        }
    }
}
