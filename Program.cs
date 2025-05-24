using Examination.AnswerGroup;
using Examination.ExamGroup;
using Examination.QuestionGroup;

namespace Examination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestionList questions = new("list1");
            questions.Add(new TrueFalseQuestion("Is 0 before 1 ?", 2, true));

            AnswerList q2Answers =
            [
                new Answer("1", false),
                new Answer("2", false),
                new Answer("3", false),
                new Answer("4", true),
            ];
            questions.Add(new ChooseOne("Choose the highest Number.", 3, q2Answers));

            AnswerList q3Answers =
            [
                new Answer("1", false),
                new Answer("2", true),
                new Answer("3", false),
                new Answer("4", true),
            ];
            questions.Add(new ChooseAll("Choose even numbers.", 3, q3Answers));

            Exam exam = new FinalExam(new TimeSpan(0, 2, 0), questions);
            exam.Show();

        }
    }
}
