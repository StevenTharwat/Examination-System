using Newtonsoft.Json;

namespace Examination.QuestionGroup
{
    internal class QuestionList : List<Question>
    {
        readonly static string BaseDir = AppContext.BaseDirectory;
        public string FullPath { get; private set; }
        public QuestionList(string fileName)
        {
            FullPath = Path.Combine(BaseDir, $"{fileName}.json");
            FileHelper();
            //ReadFromFile();
        }
        public new void Add(Question question)
        {
            base.Add(question);

            //Write
            string newJson = JsonConvert.SerializeObject(this);
            WriteToFile(newJson);
        }
        public void FileHelper()
        {
            if (!File.Exists(FullPath))
            {
                File.Create(FullPath).Close();
            }
        }
        public void WriteToFile(string newJson)
        {
            File.WriteAllText(FullPath, newJson);
        }

        //public QuestionList ReadFromFile()
        //{
        //    QuestionList questionsFromDb = JsonConvert.DeserializeObject<QuestionList>(File.ReadAllText(FullPath)) ?? new QuestionList(FullPath);
        //    return questionsFromDb;
        //}

    }
}
