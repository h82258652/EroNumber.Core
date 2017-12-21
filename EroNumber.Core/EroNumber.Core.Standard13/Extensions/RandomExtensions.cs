using System;
using System.Globalization;
using System.Text;

namespace EroNumber.Extensions
{
    public static class RandomExtensions
    {
        public static char NextChinese(this Random rand)
        {
            if (rand == null)
            {
                throw new ArgumentNullException(nameof(rand));
            }

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var gb2312 = Encoding.GetEncoding("gb2312");

            var r1 = rand.Next(11, 14);
            var r2 = r1 == 13 ? rand.Next(0, 7) : rand.Next(0, 16);
            var r3 = rand.Next(10, 16);
            int r4;
            switch (r3)
            {
                case 10:
                    r4 = rand.Next(1, 16);
                    break;

                case 15:
                    r4 = rand.Next(0, 15);
                    break;

                default:
                    r4 = rand.Next(0, 16);
                    break;
            }

            var sr1 = r1.ToString("X", CultureInfo.InvariantCulture);
            var sr2 = r2.ToString("X", CultureInfo.InvariantCulture);
            var sr3 = r3.ToString("X", CultureInfo.InvariantCulture);
            var sr4 = r4.ToString("X", CultureInfo.InvariantCulture);

            var b1 = Convert.ToByte(sr1 + sr2, 16);
            var b2 = Convert.ToByte(sr3 + sr4, 16);

            return gb2312.GetString(new[] { b1, b2 }, 0, 2)[0];
        }

        public static string NextChinese(this Random rand, int length)
        {
            if (rand == null)
            {
                throw new ArgumentNullException(nameof(rand));
            }
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            if (length == 0)
            {
                return string.Empty;
            }

            var builder = new StringBuilder(length);
            for (var i = 0; i < length; i++)
            {
                builder.Append(rand.NextChinese());
            }
            return builder.ToString();
        }
    }
}