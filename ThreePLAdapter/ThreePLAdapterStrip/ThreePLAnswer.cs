using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreePLAdapterStrip
{
    class ThreePLAnswer
    {
       
       
        protected DateTime? deliveryDate;
       
        protected string materialNumber;
       
        protected string wareHouse;
        protected int? quantity;
        protected string deliveryNo;
        protected string pickingListNo;
        protected string vehiclePlateNo;
        protected string noOfColli;
        protected string document;
        protected string lineNo;
        protected string customerCode;
        protected string orderNo;
        private string threePL;
        private List<Product> products;
        private ShippingDocument shippingDocument;



        /// <summary>
        /// The DeliveryDate property
        ///
        /// </summary>
        ///
        public virtual DateTime? DeliveryDate
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
        /// The MaterialNumber property
        ///
        /// </summary>
        ///
        public virtual string MaterialNumber
        {
            get
            {
                return materialNumber;
            }
            set
            {
                materialNumber = value;
            }
        }
        /// <summary>
        /// The WareHouse property
        ///
        /// </summary>
        ///
        public virtual string WareHouse
        {
            get
            {
                return wareHouse;
            }
            set
            {
                wareHouse = value;
            }
        }
        /// <summary>
        /// The Quantity property
        ///
        /// </summary>
        ///
        public virtual int? Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
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
        /// The PickingListNo property
        ///
        /// </summary>
        ///
        public virtual string PickingListNo
        {
            get
            {
                return pickingListNo;
            }
            set
            {
                pickingListNo = value;
            }
        }
        /// <summary>
        /// The VehiclePlateNo property
        ///
        /// </summary>
        ///
        public virtual string VehiclePlateNo
        {
            get
            {
                return vehiclePlateNo;
            }
            set
            {
                vehiclePlateNo = value;
            }
        }
        /// <summary>
        /// The NoOfColli property
        ///
        /// </summary>
        ///
        public virtual string NoOfColli
        {
            get
            {
                return noOfColli;
            }
            set
            {
                noOfColli = value;
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
        /// The LineNo property
        ///
        /// </summary>
        ///
        public virtual string LineNo
        {
            get
            {
                return lineNo;
            }
            set
            {
                lineNo = value;
            }
        }
        /// <summary>
        /// The CustomerCode property
        ///
        /// </summary>
        ///
        public virtual string CustomerCode
        {
            get
            {
                return customerCode;
            }
            set
            {
                customerCode = value;
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

        public List<Product> Products { get => products; set => products = value; }
        protected string ThreePL { get => threePL; set => threePL = value; }
        internal ShippingDocument ShippingDocument { get => shippingDocument; set => shippingDocument = value; }

        /// <summary>
        /// The VersionTimestamp property
        ///Provides concurrency control for the class
        /// </summary>
        ///
        public ThreePLAnswer() { }
    }
}
