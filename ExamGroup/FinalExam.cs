using Examination.QuestionGroup;

namespace Examination.ExamGroup
{
    internal class FinalExam : Exam
    {
        public FinalExam(TimeSpan _Duration, QuestionList _Questions) : base(_Duration, _Questions)
        {
        }

        public override void Show()
        {
            Console.WriteLine("(Final Exam)");
            base.Show();
            //double totalMarks = base.CorrectExam(); //=> goto database
            //Console.WriteLine($"you have got {totalMarks} Marks");
        }
    }
}
