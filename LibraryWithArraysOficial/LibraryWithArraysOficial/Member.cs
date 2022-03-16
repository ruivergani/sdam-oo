namespace LibraryWithArrays
{
    public class Member
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Name { get; }

        public Member(string name)
        {
            Id = nextId++;
            Name = name;
        }
    }
}
