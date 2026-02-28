// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

namespace TsxCode.SampleODataApi.Core.Aggregates.CustomerAggregate
{
    /// <summary>
    ///     Contains constant values used for validation of <see cref="Customer"/> entities.
    /// </summary>
    public static class CustomerConstants
    {
        /// <summary>
        ///     The minimum allowed length for a <see cref="Customer.Name"/>.
        /// </summary>
        public const int NameMinLength = 1;

        /// <summary>
        ///     The maximum allowed length for a <see cref="Customer.Name"/>.
        /// </summary>
        public const int NameMaxLength = 100;
    }
}
