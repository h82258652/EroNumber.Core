using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Controls.Primitives;

namespace EroNumber.Extensions
{
    public static class PopupExtensions
    {
        public static void UpdatePosition(this Popup popup)
        {
            if (popup == null)
            {
                throw new ArgumentNullException(nameof(popup));
            }

            var type = popup.GetType();
            var method = type.GetMethod("UpdatePosition", BindingFlags.Instance | BindingFlags.NonPublic);
            Debug.Assert(method != null);
            method.Invoke(popup, null);
        }
    }
}