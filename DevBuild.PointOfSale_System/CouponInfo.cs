using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.PointOfSale_System {
    public class CouponInfo {
        public string Description { get; set; }
        public ProductCategory ApplicableCategory { get; set; }
        public string ApplicableSKU { get; set; }

        public CouponInfo() {

        }

        public CouponInfo(string description, ProductCategory category, string ProductSKU) {
            Description = description;
            ApplicableCategory = category;
            ApplicableSKU = ProductSKU;
        }


    }
}
