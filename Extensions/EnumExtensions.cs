using System.ComponentModel;
using System.Reflection;

namespace CRUD_Angular.Extensions
{
    public static class EnumExtensions
    {
        /* API Reflection è un potente insieme di risorse che ci consente 
         * di estrarre e manipolare i metadati. Molti framework e librerie 
         * (incluso lo stesso ASP.NET Core) utilizzano queste risorse 
         * per gestire molte cose dietro le quinte. 
         * https://www.tutorialspoint.com/csharp/csharp_reflection.htm */

        public static string ToDescriptionString<TEnum>(this TEnum @enum)
        {
            FieldInfo info = @enum.GetType().GetField(@enum.ToString());
            var attributes = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes?[0].Description ?? @enum.ToString();
        }
    }
}
