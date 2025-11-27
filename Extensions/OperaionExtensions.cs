using System.ComponentModel;
using Backend2.Models;

namespace Backend2.Extensions
{
    public static class OperatorExtensions
    {
        public static string Description(this Operator value)
        {
            var attributes = (DescriptionAttribute[])typeof(Operator)
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes[0].Description;
        }
    }
}
