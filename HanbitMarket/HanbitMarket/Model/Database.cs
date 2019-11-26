namespace HanbitMarket.Model
{
    public class Database
    {
        public override bool Equals(object obj)
        {
            Database other = obj as Database;
            return Equals(other);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public bool Equals(Database other)
        {
            if (other == null)
                return false;

            return true;
        }
    }
}
