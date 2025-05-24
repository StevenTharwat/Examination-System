namespace Examination.AnswerGroup
{
    internal class Answer
    {
        public string Description { get; set; }
        public bool IsCorret { get; set; }
        public Answer(string _Description, bool _IsCorret)
        {
            Description = _Description;
            IsCorret = _IsCorret;
        }
        public override string ToString()
        {
            return Description;
        }
        public override int GetHashCode()
        {
            return Description.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;
            Answer q = (Answer) obj;
            return q.Description == Description;
        }
    }
}
