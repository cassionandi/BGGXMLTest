using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BGGXMLTest
{
    [TestFixture]
    public class TestClass
    {

        static string BASE_URL = "https://www.boardgamegeek.com/xmlapi2/";

        [Test]
        public async Task TestHttpConnection()
        {

            var content = await BGGClient.GetURLContent("");
            System.Diagnostics.Trace.WriteLine("################# " + content);
            Assert.NotNull(content);

        }

        [Test]
        public async Task TestHotRPGContent()
        {
            var content = await BGGClient.GetURLContent(BASE_URL);

            System.Diagnostics.Trace.WriteLine("################# " + content);

            Assert.NotNull(content);
        }

        [Test]
        public async Task TestHotRPGItems()
        {
            var items = await BGGClient.GetItems();

            System.Diagnostics.Trace.WriteLine("################# " + items);

            Assert.IsNotNull(items);

            Assert.That(items.Lista, Has.Count.EqualTo(50));

        }

        [Test]
        public async Task TestItemDetalhe()
        {

            var detalhe = await BGGClient.GetItemDetalhe(44383);

            Assert.IsNotNull(detalhe);

            Assert.AreEqual(detalhe.Item.Id, "44383");

            Assert.That(detalhe.Item.Nome, Has.Count.EqualTo(4));

            Assert.AreEqual(detalhe.Item.Nome[0].Type, "primary");

            Assert.AreEqual(detalhe.Item.Nome[0].Value, "Trail of Cthulhu");

            Assert.That(detalhe.Item.Link, Has.Count.EqualTo(20));

            Assert.AreEqual(detalhe.Item.Link[14].Type, "rpgdesigner");

            Assert.AreEqual(detalhe.Item.Link[14].Value, "Kenneth Hite");

        }


        [Test]
        public async Task TestBusca()
        {

            var items = await BGGClient.GetItems("Trail of Cthulhu: Player's Guide");

            Assert.That(items.Lista, Has.Count.EqualTo(1));

            Assert.AreEqual(items.Lista[0].Id, "65602");

        }
    }
}
