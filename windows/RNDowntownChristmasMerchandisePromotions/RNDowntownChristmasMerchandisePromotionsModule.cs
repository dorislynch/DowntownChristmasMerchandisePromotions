using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Downtown.Christmas.Merchandise.Promotions.RNDowntownChristmasMerchandisePromotions
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDowntownChristmasMerchandisePromotionsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDowntownChristmasMerchandisePromotionsModule"/>.
        /// </summary>
        internal RNDowntownChristmasMerchandisePromotionsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDowntownChristmasMerchandisePromotions";
            }
        }
    }
}
