using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoDAdapterStrip
{
    class ProofOfDelivery
    {
        

        protected string pODNumber;
        protected DateTime? dateIssued;
        protected string qualityStatus;
        protected string quantityStatus;
        protected string deliveryStatus;
        protected string pODAttachment;
        protected string comments;

       
        /// <summary>
        /// The PODNumber property
        ///
        /// </summary>
        ///
        public virtual string PODNumber
        {
            get
            {
                return pODNumber;
            }
            set
            {
                pODNumber = value;
            }
        }
        /// <summary>
        /// The DateIssued property
        ///
        /// </summary>
        ///
        public virtual DateTime? DateIssued
        {
            get
            {
                return dateIssued;
            }
            set
            {
                dateIssued = value;
            }
        }
        /// <summary>
        /// The QualityStatus property
        ///
        /// </summary>
        ///
        public virtual string QualityStatus
        {
            get
            {
                return qualityStatus;
            }
            set
            {
                qualityStatus = value;
            }
        }
        /// <summary>
        /// The QuantityStatus property
        ///
        /// </summary>
        ///
        public virtual string QuantityStatus
        {
            get
            {
                return quantityStatus;
            }
            set
            {
                quantityStatus = value;
            }
        }
        /// <summary>
        /// The DeliveryStatus property
        ///
        /// </summary>
        ///
        public virtual string DeliveryStatus
        {
            get
            {
                return deliveryStatus;
            }
            set
            {
                deliveryStatus = value;
            }
        }
        /// <summary>
        /// The PODAttachment property
        ///
        /// </summary>
        ///
        public virtual string PODAttachment
        {
            get
            {
                return pODAttachment;
            }
            set
            {
                pODAttachment = value;
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
        /// The VersionTimestamp property
        ///Provides concurrency control for the class
        /// </summary>
        ///
       
        public ProofOfDelivery() { }
    }
}
