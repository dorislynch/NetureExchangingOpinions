using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Neture.Exchanging.Opinions.RNNetureExchangingOpinions
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNetureExchangingOpinionsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNetureExchangingOpinionsModule"/>.
        /// </summary>
        internal RNNetureExchangingOpinionsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNetureExchangingOpinions";
            }
        }
    }
}
