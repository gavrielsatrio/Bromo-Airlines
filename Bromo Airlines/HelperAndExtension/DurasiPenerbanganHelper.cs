using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bromo_Airlines.HelperAndExtension
{
    public static class DurasiPenerbanganHelper
    {
        public static string ToJamMenitFormat(this int totalMenit)
        {
            var jam = Math.Floor((double)totalMenit / 60);
            var menit = totalMenit - (jam * 60);

            //if (jam > 0)
            //{
            //    return $"{jam.ToString().PadLeft(2, '0')} jam {menit.ToString().PadLeft(2, '0')} menit";
            //}
            //else
            //{
            //    return $"{menit.ToString().PadLeft(2, '0')} menit";
            //}

            return $"{jam.ToString().PadLeft(2, '0')} jam {menit.ToString().PadLeft(2, '0')} menit";
        }

        public static int ToTotalMenitFormat(this string jamMenitFormat)
        {
            //if (jamMenitFormat.Contains("jam"))
            //{
            //    var jam = int.Parse(jamMenitFormat.Split(' ')[0]);
            //    var menit = int.Parse(jamMenitFormat.Split(' ')[2]);

            //    return (jam * 60) + menit;
            //}
            //else
            //{
            //    var menit = int.Parse(jamMenitFormat.Split(' ')[0]);

            //    return menit;
            //}

            var jam = int.Parse(jamMenitFormat.Split(' ')[0]);
            var menit = int.Parse(jamMenitFormat.Split(' ')[2]);

            return (jam * 60) + menit;
        }
    }
}
