using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public class OtvalshikaPageFlyoutMenuItem
    {
        public OtvalshikaPageFlyoutMenuItem()
        {
            TargetType = typeof(OtvalshikaPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}