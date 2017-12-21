using System;
using System.Diagnostics;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;

namespace EroNumber.Extensions
{
    public static class ButtonExtensions
    {
        public static void PerformClick(this ButtonBase button)
        {
            if (button == null)
            {
                throw new ArgumentNullException(nameof(button));
            }

            if (button.IsEnabled)
            {
                var automationPeer = FrameworkElementAutomationPeer.CreatePeerForElement(button);
                var invokeProvider = (IInvokeProvider)automationPeer.GetPattern(PatternInterface.Invoke);
                Debug.Assert(invokeProvider != null);
                invokeProvider.Invoke();
            }
        }
    }
}