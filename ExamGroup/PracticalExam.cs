using Examination.AnswerGroup;
using Examination.QuestionGroup;

namespace Examination.ExamGroup
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(TimeSpan _Duration, QuestionList _Questions) : base(_Duration, _Questions)
        {
        }

        public override void Show()
        {
            Console.WriteLine("(Practical Exam)");

            base.Show();
            foreach (KeyValuePair<Question, AnswerList> QA in UserAnswersDic)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                //you can use Action to send this line to the foreach of base
                Console.WriteLine($"correct answer for Question [{QA.Key.Body}] ==> {QA.Key.GetCorrectAnswers()}");
            }
            double totalMarks = base.CorrectExam();
            Console.WriteLine($"you have got {totalMarks} Marks");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
