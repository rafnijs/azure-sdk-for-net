// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingSubscriptionsOperations.
    /// </summary>
    public static partial class BillingSubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Lists billing subscriptions by billing account name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            public static IPage<BillingSubscriptionSummary> ListByBillingAccountName(this IBillingSubscriptionsOperations operations, string billingAccountName)
            {
                return operations.ListByBillingAccountNameAsync(billingAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists billing subscriptions by billing account name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingSubscriptionSummary>> ListByBillingAccountNameAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountNameWithHttpMessagesAsync(billingAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists billing subscriptions by billing profile name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            public static BillingSubscriptionsListResult ListByBillingProfileName(this IBillingSubscriptionsOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.ListByBillingProfileNameAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists billing subscriptions by billing profile name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscriptionsListResult> ListByBillingProfileNameAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileNameWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists billing subscription by invoice section name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            public static BillingSubscriptionsListResult ListByInvoiceSectionName(this IBillingSubscriptionsOperations operations, string billingAccountName, string invoiceSectionName)
            {
                return operations.ListByInvoiceSectionNameAsync(billingAccountName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists billing subscription by invoice section name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscriptionsListResult> ListByInvoiceSectionNameAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInvoiceSectionNameWithHttpMessagesAsync(billingAccountName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a single billing subscription by name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingSubscriptionName'>
            /// Billing Subscription Id.
            /// </param>
            public static BillingSubscriptionSummary Get(this IBillingSubscriptionsOperations operations, string billingAccountName, string invoiceSectionName, string billingSubscriptionName)
            {
                return operations.GetAsync(billingAccountName, invoiceSectionName, billingSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a single billing subscription by name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingSubscriptionName'>
            /// Billing Subscription Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscriptionSummary> GetAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, string invoiceSectionName, string billingSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, invoiceSectionName, billingSubscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Transfers the subscription from one invoice section to another within a
            /// billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingSubscriptionName'>
            /// Billing Subscription Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Transfer Billing Subscription operation.
            /// </param>
            public static TransferBillingSubscriptionResult Transfer(this IBillingSubscriptionsOperations operations, string billingAccountName, string invoiceSectionName, string billingSubscriptionName, TransferBillingSubscriptionRequestProperties parameters)
            {
                return operations.TransferAsync(billingAccountName, invoiceSectionName, billingSubscriptionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Transfers the subscription from one invoice section to another within a
            /// billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingSubscriptionName'>
            /// Billing Subscription Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Transfer Billing Subscription operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransferBillingSubscriptionResult> TransferAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, string invoiceSectionName, string billingSubscriptionName, TransferBillingSubscriptionRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TransferWithHttpMessagesAsync(billingAccountName, invoiceSectionName, billingSubscriptionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Transfers the subscription from one invoice section to another within a
            /// billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingSubscriptionName'>
            /// Billing Subscription Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Transfer Billing Subscription operation.
            /// </param>
            public static TransferBillingSubscriptionResult BeginTransfer(this IBillingSubscriptionsOperations operations, string billingAccountName, string invoiceSectionName, string billingSubscriptionName, TransferBillingSubscriptionRequestProperties parameters)
            {
                return operations.BeginTransferAsync(billingAccountName, invoiceSectionName, billingSubscriptionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Transfers the subscription from one invoice section to another within a
            /// billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingSubscriptionName'>
            /// Billing Subscription Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Transfer Billing Subscription operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransferBillingSubscriptionResult> BeginTransferAsync(this IBillingSubscriptionsOperations operations, string billingAccountName, string invoiceSectionName, string billingSubscriptionName, TransferBillingSubscriptionRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginTransferWithHttpMessagesAsync(billingAccountName, invoiceSectionName, billingSubscriptionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists billing subscriptions by billing account name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingSubscriptionSummary> ListByBillingAccountNameNext(this IBillingSubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListByBillingAccountNameNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists billing subscriptions by billing account name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingSubscriptionSummary>> ListByBillingAccountNameNextAsync(this IBillingSubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountNameNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}