using Examination.AnswerGroup;

namespace Examination.QuestionGroup
{
    internal class ChooseAll(string _Title, double _Marks, AnswerList list) : Question("Choose All Match Answer", _Title, _Marks, list)
    {
    }
}
