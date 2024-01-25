using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;


namespace SportZifyAutomationTest
{
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void guiTestForFontSize()
        {
            app.Flash(x => x.Text("CRICKET"));
            app.Tap(x => x.Text("CRICKET"));
            Thread.Sleep(4000);
            app.Flash(x => x.Text("Rangers Club"));
            app.Tap(x => x.Text("Rangers Club"));
            Thread.Sleep(4000);

            int titleTextSize = Convert.ToInt32(app.Query(x => x.Text("Rangers Club").Invoke("getTextSize"))[1]);
            int cityNameTextSize = Convert.ToInt32(app.Query(x => x.Text("Bhilai").Invoke("getTextSize"))[0]);

            if (titleTextSize == 84 && cityNameTextSize == 56)
            {
                Console.WriteLine("Font Size is as expected");
            }
            else
            {
                Assert.Fail("Font Size is NOT as expected");
            }
        }

        [Test]
        public void guiTestForLabelOrientation()
        {
            app.Flash(x => x.Text("CRICKET"));
            app.Tap(x => x.Text("CRICKET"));
            Thread.Sleep(4000);
            app.Flash(x => x.Text("Rangers Club"));
            app.Tap(x => x.Text("Rangers Club"));

            Thread.Sleep(4000);
            app.ScrollDown();
            Thread.Sleep(4000);

            app.Flash(x => x.Text("Book Slot"));
            app.Tap(x => x.Text("Book Slot"));

            Thread.Sleep(4000);
            app.Flash(x => x.Text("Sport :"));
            int sportLabelXAxisCoordinate = Convert.ToInt32(app.Query(x => x.Text("Sport :")).First().Rect.X);

            Thread.Sleep(4000);
            app.Flash(x => x.Text("Centre :"));
            int centreLabelXAxisCoordinate = Convert.ToInt32(app.Query(x => x.Text("Centre :")).First().Rect.X);

            Thread.Sleep(4000);
            app.Flash(x => x.Text("Payment Method"));
            int paymentLabelXAxisCoordinate = Convert.ToInt32(app.Query(x => x.Text("Payment Method")).First().Rect.X);

            if (sportLabelXAxisCoordinate == centreLabelXAxisCoordinate && centreLabelXAxisCoordinate == paymentLabelXAxisCoordinate)
            {
                Console.WriteLine("Text Labels are aligned Parallely");
            }
            else
            {
                Assert.Fail("Text Labels are NOT aligned Parallely");
            }
        }

        [Test]
        public void guiTestForTextBoxLocation()
        {
            app.Flash(x => x.Text("CRICKET"));
            app.Tap(x => x.Text("CRICKET"));
            Thread.Sleep(4000);
            app.Flash(x => x.Text("Rangers Club"));
            app.Tap(x => x.Text("Rangers Club"));

            Thread.Sleep(4000);
            app.ScrollDown();
            Thread.Sleep(4000);

            app.Flash(x => x.Text("Book Slot"));
            app.Tap(x => x.Text("Book Slot"));

            Thread.Sleep(4000);

            int posTextBox1 = Convert.ToInt32(app.Query(x => x.Id("materialformsedittext"))[0].Rect.Y);
            int posTextBox2 = Convert.ToInt32(app.Query(x => x.Id("materialformsedittext"))[1].Rect.Y);
            int posTextBox3 = Convert.ToInt32(app.Query(x => x.Id("materialformsedittext"))[2].Rect.Y);

            if (posTextBox1 == 315 && posTextBox2 == 562 && posTextBox3 == 808)
            {
                Console.WriteLine("Location of Text Boxes is as expected");
            }
            else
            {
                Assert.Fail("Location of Text Boxes is NOT as expected");
            }
        }

        [Test]
        public void guiTestForPageNavigation()
        {
            app.Flash(x => x.Text("CRICKET"));
            app.Tap(x => x.Text("CRICKET"));
            Thread.Sleep(2000);
            if (app.Query(x => x.Text("Cricket")).Length > 0)
            {
                Console.WriteLine("Cricket Page Navigation is as expected");
            }
            else
            {
                Assert.Fail("Cricket Page Navigation is NOT as expected");
            }

            Thread.Sleep(4000);

            app.Flash(x => x.Text("GYM"));
            app.Tap(x => x.Text("GYM"));
            Thread.Sleep(2000);
            if (app.Query(x => x.Text("Gym")).Length > 0)
            {
                Console.WriteLine("Gym Page Navigation is as expected");
            }
            else
            {
                Assert.Fail("Gym Page Navigation is NOT as expected");
            }

            Thread.Sleep(4000);

            app.Flash(x => x.Text("SHUTTLE"));
            app.Tap(x => x.Text("SHUTTLE"));
            Thread.Sleep(2000);
            if (app.Query(x => x.Text("Shuttle")).Length > 0)
            {
                Console.WriteLine("Shuttle Page Navigation is as expected");
            }
            else
            {
                Assert.Fail("Shuttle Page Navigation is NOT as expected");
            }
        }

        [Test]
        public void guiTestForVerifyingPaymentMethodText()
        {
            app.Flash(x => x.Text("CRICKET"));
            app.Tap(x => x.Text("CRICKET"));
            Thread.Sleep(4000);
            app.Flash(x => x.Text("Rangers Club"));
            app.Tap(x => x.Text("Rangers Club"));

            Thread.Sleep(4000);
            app.ScrollDown();
            Thread.Sleep(4000);

            app.Flash(x => x.Text("Book Slot"));
            app.Tap(x => x.Text("Book Slot"));

            Thread.Sleep(4000);

            if (app.Query(x => x.Text("Cash")).Length > 0 &&
                app.Query(x => x.Text("Credit/Debit Card")).Length > 0 &&
                app.Query(x => x.Text("Paypal")).Length > 0)
            {
                Console.WriteLine("Payment Methods Label Text is as expected");
            }
            else
            {
                Assert.Fail("Payment Methods Label Text is NOT as expected");
            }
        }
    }
}
