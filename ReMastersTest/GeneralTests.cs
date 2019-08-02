using ReMastersLib;
using Xunit;
using FluentAssertions;
using ReMastersTest.Properties;

namespace ReMastersTest
{
    public static class GeneralTests
    {
        [Theory]
        [InlineData("_10259522396886124101")]
        [InlineData("assetdb_shard")]
        public static void TestABND(string file)
        {
            var data = (byte[])Resources.ResourceManager.GetObject(file);
            var abndo = new ABND(data);

            var f0 = abndo.GetFileInfo(0);
            var d0 = abndo.GetFileData(f0);

            d0.Should().NotBeNull("expected a valid data result");
            d0.Length.Should().Be(f0.DecompressedLength, "expected specified length");
        }

        [Theory]
        [InlineData("Monster")]
        public static void TestProto(string file)
        {
            var data = (byte[])Resources.ResourceManager.GetObject(file);
            var table = MonsterTable.Parser.ParseFrom(data);
            table.Entries.Count.Should().Be(0x4E, "expected data!");

            var dump = table.DumpAll();
            dump.Length.Should().BeGreaterThan(9000, "expected data in the table!");
        }
    }
}
