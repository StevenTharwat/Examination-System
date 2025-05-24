using Examination.AnswerGroup;
using Examination.QuestionGroup;

namespace Examination.ExamGroup
{
    internal abstract class Exam
    {
        public TimeSpan Duration { get; set; }
        public QuestionList Questions { get; set; }
        public Dictionary<Question, AnswerList> UserAnswersDic = [];
        public Exam(TimeSpan _Duration, QuestionList _Questions)
        {
            Duration = _Duration;
            Questions = _Questions;
        }

        public virtual void Show()
        {
            Console.WriteLine("Enter the Right Answers Number seperated by , (if one just type it's Number) or b for back");

            for (int i = 0 ; i < Questions.Count ; i++)
            {
                Question q = Questions[i];
                Console.WriteLine(q.Show());
                AnswerList? userAnswers = GetUserAnswers(q.Answers);
                if (userAnswers == null)
                {
                    //if first question
                    if (i == 0)
                    {
                        WriteError("this is the first Question can't back");
                        i -= 1;
                        continue;
                    }
                    else
                    {
                        i -= 2;
                        continue;
                    }
                }
                if (userAnswers.Count == 0)
                {
                    WriteError("invalid input try aagin");
                    i -= 1;
                    continue;
                }
                UserAnswersDic[q] = userAnswers;
            }
        }

        private void WriteError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public virtual AnswerList? GetUserAnswers(AnswerList QuestionAnswers)
        {
            string input = ( Console.ReadLine() ?? "" ).Trim().ToLower();
            if (input == "b") return null;
            AnswerList userAnswers = [];
            string[] userInputStr = input.Split(',');
            foreach (var i in userInputStr)
            {
                bool canConvert = int.TryParse(i, out int AnswerNumber);
                if (!canConvert || AnswerNumber < 0 || AnswerNumber > QuestionAnswers.Count)
                {
                    userAnswers.Clear();
                    return [];
                }
                userAnswers.Add(QuestionAnswers[int.Parse(i) - 1]);
            }
            return userAnswers;
        }

        //must make all user input and output in the same place
        public virtual double CorrectExam()
        {
            double totalMarks = 0;
            foreach (KeyValuePair<Question, AnswerList> QA in UserAnswersDic)
            {
                totalMarks += QA.Key.Correct(QA.Value);
            }
            return totalMarks;
        }
    }
}
