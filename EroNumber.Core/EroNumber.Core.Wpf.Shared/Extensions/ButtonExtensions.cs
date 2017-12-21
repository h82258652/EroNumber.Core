using System;
using System.Diagnostics;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls.Primitives;

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
                var automationPeer = UIElementAutomationPeer.CreatePeerForElement(button);
                var invokeProvider = (IInvokeProvider)automationPeer.GetPattern(PatternInterface.Invoke);
                Debug.Assert(invokeProvider != null);
                invokeProvider.Invoke();
            }
        }
    }
}