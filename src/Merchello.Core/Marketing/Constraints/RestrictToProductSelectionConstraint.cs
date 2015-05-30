﻿namespace Merchello.Core.Marketing.Discounts.Constraints
{
    using System;
    using System.ComponentModel;

    using Merchello.Core.Marketing.Offer;
    using Merchello.Core.Models;

    using Umbraco.Core;

    /// <summary>
    /// A discount validation rule to restrict this discount to a selection of products.
    /// </summary>
    [OfferComponent("15DDF0EA-9C60-489A-96A8-D2AAADBEF328", "Restrict to certain products", "This discount is only offered for certain products.")]
    public class RestrictToProductSelectionConstraint : OfferConstraintComponentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictToProductSelectionConstraint"/> class.
        /// </summary>
        /// <param name="settings">
        /// The settings.
        /// </param>
        public RestrictToProductSelectionConstraint(OfferComponentDefinition settings)
            : base(settings)
        {
        }


        /// <summary>
        /// Validates the constraint against the <see cref="ILineItemContainer"/>
        /// </summary>
        /// <param name="customer">
        /// The <see cref="ICustomerBase"/>.
        /// </param>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <returns>
        /// The <see cref="Attempt{ILineItemContainer}"/> indicating whether or not the constraint can be enforced.
        /// </returns>
        public override Attempt<ILineItemContainer> Validate(ICustomerBase customer, ILineItemContainer collection)
        {
            throw new NotImplementedException();
        }
    }
}