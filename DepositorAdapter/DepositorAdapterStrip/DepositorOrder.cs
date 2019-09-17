using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositorAdapterStrip
{
    class DepositorOrder
    {
 
        protected DateTime? creationDate;
        protected string deliveryNo;
        protected DateTime? deliveryDateFrom;
        protected DateTime? deliveryDateTo;
        protected string wareHouse;
        protected string comments;
        protected string payerCode;
 
        protected string document;
        public Customer customer;
        public List<Product> products;
 


        
        /// <summary>
        /// The CreationDate property
        ///
        /// </summary>
        ///
        public virtual DateTime? CreationDate
        {
            get
            {
                return creationDate;
            }
            set
            {
                creationDate = value;
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
        /// The DeliveryDateFrom property
        ///
        /// </summary>
        ///
        public virtual DateTime? DeliveryDateFrom
        {
            get
            {
                return deliveryDateFrom;
            }
            set
            {
                deliveryDateFrom = value;
            }
        }
        /// <summary>
        /// The DeliveryDateTo property
        ///
        /// </summary>
        ///
        public virtual DateTime? DeliveryDateTo
        {
            get
            {
                return deliveryDateTo;
            }
            set
            {
                deliveryDateTo = value;
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
        /// The PayerCode property
        ///
        /// </summary>
        ///
        public virtual string PayerCode
        {
            get
            {
                return payerCode;
            }
            set
            {
                payerCode = value;
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
        
        public DepositorOrder() { }
    }
}
