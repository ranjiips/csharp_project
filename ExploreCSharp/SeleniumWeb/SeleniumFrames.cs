using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace ExploreCSharp.SeleniumWeb
{
    public class SeleniumFrames:SeleniumBaseWebInteractions
    {
        By frameElementLocator = By.XPath("//frame[@name='frame-bottom']");
        public void SwitchToFrameAction()
        {
            var frames = Driver.FindElements(frameElementLocator);
            foreach (var frame in frames)
            {
                SwitchToFrame(frame);
                string text = GetText(By.XPath("//html//body"));
                Console.WriteLine($"Frame text: {text}");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                // Switch to the default document
                SwitchToDefaultWindow();
            }
        }
    }
}
