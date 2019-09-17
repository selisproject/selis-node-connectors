using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositorAdapterStrip
{
    class Invoice
    {
        protected string orderMeasurementUnit;
        protected int? invoiceQuantity;
        protected string invoiceMeasurementUnit;
        protected string document;
        protected decimal? totalValue;
        protected bool _isTDA;
        protected byte[] versionTimestamp;
        protected string supplierVATNo;
        protected string retailerEANLocNo;
        protected string invoiceCodeNo;
        protected string retailerVATNo;
        protected string supplierEANLocNo;
        protected string agentEANLocNo;
        protected string issuerEANLocNo;
        protected string agentVATNo;
        protected string issuerVATNo;
        protected string storeEANLocNo;
        protected int? documentLine;
        protected string documentNo;
        protected DateTime documentIssuedDate;
        protected DateTime documentDeliveredDate;
        protected int? orderLine;
        protected DateTime orderDate;
        protected string deliveryLocation;
        protected string meansOfPayment;
        protected int? correspondingDocumentLine;
        protected string correspondingDocumentNo;
        protected DateTime relatedDocumentDate;
        protected string paymentDescription;
        protected int? paymentDayNo;
        protected decimal netValue;
        protected decimal? discountValue;
        protected decimal? otherDiscountPercentage;
        protected decimal? otherDiscountValue;
        protected decimal? totalDiscounts;
        protected decimal? valueOfCharges;
        protected decimal? otherChargesPercentage;
        protected decimal? otherChargesValue;
        protected decimal? totalCharges;
        protected decimal? vATPercentage;
        protected decimal? taxedAmount;
        protected decimal? vATValue;
        protected string vATDescription;
        protected decimal? totalUnderlyingValue;
        protected decimal? totalTaxedAmount;
        protected decimal? totalVAT;
        protected decimal? mixedValue;
        protected string transportationValue;
        protected decimal? transportationVAT;
        protected string transporterName;
        protected string meansofTransport;
        protected decimal? guarantee;
        protected decimal? totalPaymentAmount;
        protected decimal? totalItems;
        protected decimal? totalBoxes;
        protected decimal? totalKilosGross;
        protected decimal? totalKilosNet;
        protected string comments;
        protected string legalDoc_DA;
        protected string deliveryNo;
        protected string billingNo;
        protected DateTime billingDate;
        protected string billingLine_No;
        protected string legalDoc_TIM;
        protected string deliveryLegalDoc;
        protected string billingLegalDoc;
        protected DateTime deliveryDate;
        protected string orderNo;
        protected string deliveryLine_No;
        protected decimal? grossValue;
        private Customer customer;
        private List<Product> products;

        /// <summary>
        /// The SupplierVATNo property
        ///
        /// </summary>
        ///
        public virtual string SupplierVATNo
        {
            get
            {
                return supplierVATNo;
            }
            set
            {
                supplierVATNo = value;
            }
        }
        /// <summary>
        /// The RetailerEANLocNo property
        ///
        /// </summary>
        ///
        public virtual string RetailerEANLocNo
        {
            get
            {
                return retailerEANLocNo;
            }
            set
            {
                retailerEANLocNo = value;
            }
        }
        /// <summary>
        /// The InvoiceCodeNo property
        ///
        /// </summary>
        ///
        public virtual string InvoiceCodeNo
        {
            get
            {
                return invoiceCodeNo;
            }
            set
            {
                invoiceCodeNo = value;
            }
        }
        /// <summary>
        /// The RetailerVATNo property
        ///
        /// </summary>
        ///
        public virtual string RetailerVATNo
        {
            get
            {
                return retailerVATNo;
            }
            set
            {
                retailerVATNo = value;
            }
        }
        /// <summary>
        /// The SupplierEANLocNo property
        ///
        /// </summary>
        ///
        public virtual string SupplierEANLocNo
        {
            get
            {
                return supplierEANLocNo;
            }
            set
            {
                supplierEANLocNo = value;
            }
        }
        /// <summary>
        /// The AgentEANLocNo property
        ///
        /// </summary>
        ///
        public virtual string AgentEANLocNo
        {
            get
            {
                return agentEANLocNo;
            }
            set
            {
                agentEANLocNo = value;
            }
        }
        /// <summary>
        /// The IssuerEANLocNo property
        ///
        /// </summary>
        ///
        public virtual string IssuerEANLocNo
        {
            get
            {
                return issuerEANLocNo;
            }
            set
            {
                issuerEANLocNo = value;
            }
        }
        /// <summary>
        /// The AgentVATNo property
        ///
        /// </summary>
        ///
        public virtual string AgentVATNo
        {
            get
            {
                return agentVATNo;
            }
            set
            {
                agentVATNo = value;
            }
        }
        /// <summary>
        /// The IssuerVATNo property
        ///
        /// </summary>
        ///
        public virtual string IssuerVATNo
        {
            get
            {
                return issuerVATNo;
            }
            set
            {
                issuerVATNo = value;
            }
        }
        /// <summary>
        /// The StoreEANLocNo property
        ///
        /// </summary>
        ///
        public virtual string StoreEANLocNo
        {
            get
            {
                return storeEANLocNo;
            }
            set
            {
                storeEANLocNo = value;
            }
        }
        /// <summary>
        /// The DocumentLine property
        ///
        /// </summary>
        ///
        public virtual int? DocumentLine
        {
            get
            {
                return documentLine;
            }
            set
            {
                documentLine = value;
            }
        }
        /// <summary>
        /// The DocumentNo property
        ///
        /// </summary>
        ///
        public virtual string DocumentNo
        {
            get
            {
                return documentNo;
            }
            set
            {
                documentNo = value;
            }
        }
        /// <summary>
        /// The DocumentIssuedDate property
        ///
        /// </summary>
        ///
        public virtual DateTime DocumentIssuedDate
        {
            get
            {
                return documentIssuedDate;
            }
            set
            {
                documentIssuedDate = value;
            }
        }
        /// <summary>
        /// The DocumentDeliveredDate property
        ///
        /// </summary>
        ///
        public virtual DateTime DocumentDeliveredDate
        {
            get
            {
                return documentDeliveredDate;
            }
            set
            {
                documentDeliveredDate = value;
            }
        }
        /// <summary>
        /// The OrderLine property
        ///
        /// </summary>
        ///
        public virtual int? OrderLine
        {
            get
            {
                return orderLine;
            }
            set
            {
                orderLine = value;
            }
        }
        /// <summary>
        /// The OrderDate property
        ///
        /// </summary>
        ///
        public virtual DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }
        /// <summary>
        /// The DeliveryLocation property
        ///
        /// </summary>
        ///
        public virtual string DeliveryLocation
        {
            get
            {
                return deliveryLocation;
            }
            set
            {
                deliveryLocation = value;
            }
        }
        /// <summary>
        /// The MeansOfPayment property
        ///
        /// </summary>
        ///
        public virtual string MeansOfPayment
        {
            get
            {
                return meansOfPayment;
            }
            set
            {
                meansOfPayment = value;
            }
        }
        /// <summary>
        /// The CorrespondingDocumentLine property
        ///
        /// </summary>
        ///
        public virtual int? CorrespondingDocumentLine
        {
            get
            {
                return correspondingDocumentLine;
            }
            set
            {
                correspondingDocumentLine = value;
            }
        }
        /// <summary>
        /// The CorrespondingDocumentNo property
        ///
        /// </summary>
        ///
        public virtual string CorrespondingDocumentNo
        {
            get
            {
                return correspondingDocumentNo;
            }
            set
            {
                correspondingDocumentNo = value;
            }
        }
        /// <summary>
        /// The RelatedDocumentDate property
        ///
        /// </summary>
        ///
        public virtual DateTime RelatedDocumentDate
        {
            get
            {
                return relatedDocumentDate;
            }
            set
            {
                relatedDocumentDate = value;
            }
        }
        /// <summary>
        /// The PaymentDescription property
        ///
        /// </summary>
        ///
        public virtual string PaymentDescription
        {
            get
            {
                return paymentDescription;
            }
            set
            {
                paymentDescription = value;
            }
        }
        /// <summary>
        /// The PaymentDayNo property
        ///
        /// </summary>
        ///
        public virtual int? PaymentDayNo
        {
            get
            {
                return paymentDayNo;
            }
            set
            {
                paymentDayNo = value;
            }
        }
        /// <summary>
        /// The NetValue property
        ///
        /// </summary>
        ///
        public virtual decimal NetValue
        {
            get
            {
                return netValue;
            }
            set
            {
                netValue = value;
            }
        }
        /// <summary>
        /// The DiscountValue property
        ///
        /// </summary>
        ///
        public virtual decimal? DiscountValue
        {
            get
            {
                return discountValue;
            }
            set
            {
                discountValue = value;
            }
        }
        /// <summary>
        /// The OtherDiscountPercentage property
        ///
        /// </summary>
        ///
        public virtual decimal? OtherDiscountPercentage
        {
            get
            {
                return otherDiscountPercentage;
            }
            set
            {
                otherDiscountPercentage = value;
            }
        }
        /// <summary>
        /// The OtherDiscountValue property
        ///
        /// </summary>
        ///
        public virtual decimal? OtherDiscountValue
        {
            get
            {
                return otherDiscountValue;
            }
            set
            {
                otherDiscountValue = value;
            }
        }
        /// <summary>
        /// The TotalDiscounts property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalDiscounts
        {
            get
            {
                return totalDiscounts;
            }
            set
            {
                totalDiscounts = value;
            }
        }
        /// <summary>
        /// The ValueOfCharges property
        ///
        /// </summary>
        ///
        public virtual decimal? ValueOfCharges
        {
            get
            {
                return valueOfCharges;
            }
            set
            {
                valueOfCharges = value;
            }
        }
        /// <summary>
        /// The OtherChargesPercentage property
        ///
        /// </summary>
        ///
        public virtual decimal? OtherChargesPercentage
        {
            get
            {
                return otherChargesPercentage;
            }
            set
            {
                otherChargesPercentage = value;
            }
        }
        /// <summary>
        /// The OtherChargesValue property
        ///
        /// </summary>
        ///
        public virtual decimal? OtherChargesValue
        {
            get
            {
                return otherChargesValue;
            }
            set
            {
                otherChargesValue = value;
            }
        }
        /// <summary>
        /// The TotalCharges property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalCharges
        {
            get
            {
                return totalCharges;
            }
            set
            {
                totalCharges = value;
            }
        }
        /// <summary>
        /// The VATPercentage property
        ///
        /// </summary>
        ///
        public virtual decimal? VATPercentage
        {
            get
            {
                return vATPercentage;
            }
            set
            {
                vATPercentage = value;
            }
        }
        /// <summary>
        /// The TaxedAmount property
        ///
        /// </summary>
        ///
        public virtual decimal? TaxedAmount
        {
            get
            {
                return taxedAmount;
            }
            set
            {
                taxedAmount = value;
            }
        }
        /// <summary>
        /// The VATValue property
        ///
        /// </summary>
        ///
        public virtual decimal? VATValue
        {
            get
            {
                return vATValue;
            }
            set
            {
                vATValue = value;
            }
        }
        /// <summary>
        /// The VATDescription property
        ///
        /// </summary>
        ///
        public virtual string VATDescription
        {
            get
            {
                return vATDescription;
            }
            set
            {
                vATDescription = value;
            }
        }
        /// <summary>
        /// The TotalUnderlyingValue property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalUnderlyingValue
        {
            get
            {
                return totalUnderlyingValue;
            }
            set
            {
                totalUnderlyingValue = value;
            }
        }
        /// <summary>
        /// The TotalTaxedAmount property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalTaxedAmount
        {
            get
            {
                return totalTaxedAmount;
            }
            set
            {
                totalTaxedAmount = value;
            }
        }
        /// <summary>
        /// The TotalVAT property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalVAT
        {
            get
            {
                return totalVAT;
            }
            set
            {
                totalVAT = value;
            }
        }
        /// <summary>
        /// The MixedValue property
        ///
        /// </summary>
        ///
        public virtual decimal? MixedValue
        {
            get
            {
                return mixedValue;
            }
            set
            {
                mixedValue = value;
            }
        }
        /// <summary>
        /// The TransportationValue property
        ///
        /// </summary>
        ///
        public virtual string TransportationValue
        {
            get
            {
                return transportationValue;
            }
            set
            {
                transportationValue = value;
            }
        }
        /// <summary>
        /// The TransportationVAT property
        ///
        /// </summary>
        ///
        public virtual decimal? TransportationVAT
        {
            get
            {
                return transportationVAT;
            }
            set
            {
                transportationVAT = value;
            }
        }
        /// <summary>
        /// The TransporterName property
        ///
        /// </summary>
        ///
        public virtual string TransporterName
        {
            get
            {
                return transporterName;
            }
            set
            {
                transporterName = value;
            }
        }
        /// <summary>
        /// The MeansofTransport property
        ///
        /// </summary>
        ///
        public virtual string MeansofTransport
        {
            get
            {
                return meansofTransport;
            }
            set
            {
                meansofTransport = value;
            }
        }
        /// <summary>
        /// The Guarantee property
        ///
        /// </summary>
        ///
        public virtual decimal? Guarantee
        {
            get
            {
                return guarantee;
            }
            set
            {
                guarantee = value;
            }
        }
        /// <summary>
        /// The TotalPaymentAmount property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalPaymentAmount
        {
            get
            {
                return totalPaymentAmount;
            }
            set
            {
                totalPaymentAmount = value;
            }
        }
        /// <summary>
        /// The TotalItems property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalItems
        {
            get
            {
                return totalItems;
            }
            set
            {
                totalItems = value;
            }
        }
        /// <summary>
        /// The TotalBoxes property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalBoxes
        {
            get
            {
                return totalBoxes;
            }
            set
            {
                totalBoxes = value;
            }
        }
        /// <summary>
        /// The TotalKilosGross property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalKilosGross
        {
            get
            {
                return totalKilosGross;
            }
            set
            {
                totalKilosGross = value;
            }
        }
        /// <summary>
        /// The TotalKilosNet property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalKilosNet
        {
            get
            {
                return totalKilosNet;
            }
            set
            {
                totalKilosNet = value;
            }
        }
        /// <summary>
        /// The Comments property
        ///
        /// </summary>
        ///
        public virtual string Comments
        {
            get
            {
                return comments;
            }
            set
            {
                comments = value;
            }
        }
        /// <summary>
        /// The LegalDoc_DA property
        ///
        /// </summary>
        ///
        public virtual string LegalDoc_DA
        {
            get
            {
                return legalDoc_DA;
            }
            set
            {
                legalDoc_DA = value;
            }
        }
        /// <summary>
        /// The DeliveryNo property
        ///
        /// </summary>
        ///
        public virtual string DeliveryNo
        {
            get
            {
                return deliveryNo;
            }
            set
            {
                deliveryNo = value;
            }
        }
        /// <summary>
        /// The BillingNo property
        ///
        /// </summary>
        ///
        public virtual string BillingNo
        {
            get
            {
                return billingNo;
            }
            set
            {
                billingNo = value;
            }
        }
        /// <summary>
        /// The BillingDate property
        ///
        /// </summary>
        ///
        public virtual DateTime BillingDate
        {
            get
            {
                return billingDate;
            }
            set
            {
                billingDate = value;
            }
        }
        /// <summary>
        /// The BillingLine_No property
        ///
        /// </summary>
        ///
        public virtual string BillingLine_No
        {
            get
            {
                return billingLine_No;
            }
            set
            {
                billingLine_No = value;
            }
        }
        /// <summary>
        /// The LegalDoc_TIM property
        ///
        /// </summary>
        ///
        public virtual string LegalDoc_TIM
        {
            get
            {
                return legalDoc_TIM;
            }
            set
            {
                legalDoc_TIM = value;
            }
        }
        /// <summary>
        /// The DeliveryLegalDoc property
        ///
        /// </summary>
        ///
        public virtual string DeliveryLegalDoc
        {
            get
            {
                return deliveryLegalDoc;
            }
            set
            {
                deliveryLegalDoc = value;
            }
        }
        /// <summary>
        /// The BillingLegalDoc property
        ///
        /// </summary>
        ///
        public virtual string BillingLegalDoc
        {
            get
            {
                return billingLegalDoc;
            }
            set
            {
                billingLegalDoc = value;
            }
        }
        /// <summary>
        /// The DeliveryDate property
        ///
        /// </summary>
        ///
        public virtual DateTime DeliveryDate
        {
            get
            {
                return deliveryDate;
            }
            set
            {
                deliveryDate = value;
            }
        }
        /// <summary>
        /// The OrderNo property
        ///
        /// </summary>
        ///
        public virtual string OrderNo
        {
            get
            {
                return orderNo;
            }
            set
            {
                orderNo = value;
            }
        }
        /// <summary>
        /// The DeliveryLine_No property
        ///
        /// </summary>
        ///
        public virtual string DeliveryLine_No
        {
            get
            {
                return deliveryLine_No;
            }
            set
            {
                deliveryLine_No = value;
            }
        }
        /// <summary>
        /// The GrossValue property
        ///
        /// </summary>
        ///
        public virtual decimal? GrossValue
        {
            get
            {
                return grossValue;
            }
            set
            {
                grossValue = value;
            }
        }


        /// <summary>
        /// The OrderMeasurementUnit property
        ///
        /// </summary>
        ///
        public virtual string OrderMeasurementUnit
        {
            get
            {
                return orderMeasurementUnit;
            }
            set
            {
                orderMeasurementUnit = value;
            }
        }
        /// <summary>
        /// The InvoiceQuantity property
        ///
        /// </summary>
        ///
        public virtual int? InvoiceQuantity
        {
            get
            {
                return invoiceQuantity;
            }
            set
            {
                invoiceQuantity = value;
            }
        }
        /// <summary>
        /// The InvoiceMeasurementUnit property
        ///
        /// </summary>
        ///
        public virtual string InvoiceMeasurementUnit
        {
            get
            {
                return invoiceMeasurementUnit;
            }
            set
            {
                invoiceMeasurementUnit = value;
            }
        }
        /// <summary>
        /// The Document property
        ///
        /// </summary>
        ///
        public virtual string Document
        {
            get
            {
                return document;
            }
            set
            {
                document = value;
            }
        }
        /// <summary>
        /// The TotalValue property
        ///
        /// </summary>
        ///
        public virtual decimal? TotalValue
        {
            get
            {
                return totalValue;
            }
            set
            {
                totalValue = value;
            }
        }
        /// <summary>
        /// The isTDA property
        ///
        /// </summary>
        ///
        public virtual bool isTDA
        {
            get
            {
                return _isTDA;
            }
            set
            {
                _isTDA = value;
            }
        }

        internal List<Product> Products { get => products; set => products = value; }
        internal Customer Customer { get => customer; set => customer = value; }

        /// <summary>
        /// The VersionTimestamp property
        ///Provides concurrency control for the class
        /// </summary>
        ///


        public Invoice() { }
    }
}
