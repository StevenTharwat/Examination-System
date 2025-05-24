namespace Examination.AnswerGroup
{
    internal class AnswerList : List<Answer>
    {
        public AnswerList(IEnumerable<Answer> collection) : base(collection) { }
        public AnswerList() { }
        public override string ToString()
        {
            return $"[{string.Join(",", this)}]";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;
            AnswerList other = (AnswerList) obj;
            bool res = true;
            if (Count != other.Count) res = false;
            foreach (var answer in other)
            {
                if (!Contains(answer)) res = false;
            }
            return res;

        }
    }
}
