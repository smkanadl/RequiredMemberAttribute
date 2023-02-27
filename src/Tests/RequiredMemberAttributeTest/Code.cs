namespace RequiredMemberAttributeTest
{
    public class Code
    {
        public required int Required { get; set; }
    }

    public static class Main
    {
        public static void Use()
        {
            var _ = new Code() { Required = 2 };
            // var _ = new Code(); is compiler error
        }
    }
}
