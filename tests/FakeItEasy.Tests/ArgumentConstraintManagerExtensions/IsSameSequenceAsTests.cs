namespace FakeItEasy.Tests.ArgumentConstraintManagerExtensions
{
    using System.Collections.Generic;

    public class IsSameSequenceAsTests
        : ArgumentConstraintTestBase<IEnumerable<int>>
    {
        protected override string ExpectedDescription => "specified sequence";

        public static IEnumerable<object[]> InvalidValues()
        {
            return TestCases.FromObject(
                new[] { 1, 2 },
                new int[] { },
                null,
                new[] { 1, 2, 3, 4 },
                new[] { 9, 8 });
        }

        public static IEnumerable<object[]> ValidValues()
        {
            return TestCases.FromObject(
                new[] { 1, 2, 3 },
                new List<int> { 1, 2, 3 });
        }

        protected override void CreateConstraint(IArgumentConstraintManager<IEnumerable<int>> scope)
        {
            scope.IsSameSequenceAs(new[] { 1, 2, 3 });
        }
    }
}
