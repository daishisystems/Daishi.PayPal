﻿namespace Daishi.PaySharp.Extensibility {
    /// <summary>
    ///     Provides a
    ///     <a href="http://www.dofactory.com/net/bridge-design-pattern">Bridge</a>
    ///     that allows downstream systems to interface with and expose PayPal
    ///     ExpressCheckout metadata.
    /// </summary>
    public abstract class PayPalPayload {
        /// <summary>The underlying <see cref="CustomerDetails" />
        ///     <a href="http://www.oodesign.com/bridge-pattern.html">Implementor</a>
        ///     that facilitates this
        ///     <a href="http://www.dofactory.com/net/bridge-design-pattern">Bridge</a>.</summary>
        protected readonly CustomerDetails customerDetails;

        /// <summary>Initializes a new instance of the <see cref="PayPalPayload" /> class.</summary>
        /// <param name="customerDetails">The underlying <see cref="CustomerDetails" />
        ///     <a href="http://www.oodesign.com/bridge-pattern.html">Implementor</a>
        ///     that facilitates this
        ///     <a href="http://www.dofactory.com/net/bridge-design-pattern">Bridge</a>.</param>
        protected PayPalPayload(CustomerDetails customerDetails) {

            this.customerDetails = customerDetails;
        }
    }
}