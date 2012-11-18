using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FinalBuilderMonitor.Test
{
    [TestFixture]
    public class SoundPlayerTests
    {
        [Test]
        [Ignore("Exploratory test.")]
        public void PlayASound()
        {
            SoundPlayer player = new SoundPlayer(@"TestData\AddonComplete.wav");
            player.Play();
        }
    }
}
