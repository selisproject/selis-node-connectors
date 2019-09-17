using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositorAdapterStrip
{
    class Product
    {
        
        
        
        protected string code;
        
        protected string description;
        
        protected string price;
        
        protected string basicUnit;
        
        protected string conversionFactor;
        
        protected string saleUnit;
        
        protected decimal? volume;
        
        protected string eAN_Tem;
        
        protected string eAN_Kib;
        
        protected string type;
        
        protected string lifeDuration;
        
        protected string warning;
        
        protected decimal? grossWeight;
        
        protected int? stopSelling;

        protected int quantity;

        protected decimal billingQuantity;

        protected decimal orderQuantity;

        protected decimal grossValue;

        protected decimal netValue;

        protected decimal vatValue;

        protected decimal totalValue;

      
        
        
        #region Product's Properties
        /// <summary>
        /// The Id property
        ///
        /// </summary>
        ///
        /// <summary>
        /// The Code property
        ///
        /// </summary>
        ///
        public virtual string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        /// <summary>
        /// The Description property
        ///
        /// </summary>
        ///
        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        /// <summary>
        /// The Price property
        ///
        /// </summary>
        ///
        public virtual string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        /// <summary>
        /// The BasicUnit property
        ///
        /// </summary>
        ///
        public virtual string BasicUnit
        {
            get
            {
                return basicUnit;
            }
            set
            {
                basicUnit = value;
            }
        }
        /// <summary>
        /// The ConversionFactor property
        ///
        /// </summary>
        ///
        public virtual string ConversionFactor
        {
            get
            {
                return conversionFactor;
            }
            set
            {
                conversionFactor = value;
            }
        }
        /// <summary>
        /// The SaleUnit property
        ///
        /// </summary>
        ///
        public virtual string SaleUnit
        {
            get
            {
                return saleUnit;
            }
            set
            {
                saleUnit = value;
            }
        }
        /// <summary>
        /// The Volume property
        ///
        /// </summary>
        ///
        public virtual decimal? Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }
        /// <summary>
        /// The EAN_Tem property
        ///
        /// </summary>
        ///
        public virtual string EAN_Tem
        {
            get
            {
                return eAN_Tem;
            }
            set
            {
                eAN_Tem = value;
            }
        }
        /// <summary>
        /// The EAN_Kib property
        ///
        /// </summary>
        ///
        public virtual string EAN_Kib
        {
            get
            {
                return eAN_Kib;
            }
            set
            {
                eAN_Kib = value;
            }
        }
        /// <summary>
        /// The Type property
        ///
        /// </summary>
        ///
        public virtual string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        /// <summary>
        /// The LifeDuration property
        ///
        /// </summary>
        ///
        public virtual string LifeDuration
        {
            get
            {
                return lifeDuration;
            }
            set
            {
                lifeDuration = value;
            }
        }
        /// <summary>
        /// The Warning property
        ///
        /// </summary>
        ///
        public virtual string Warning
        {
            get
            {
                return warning;
            }
            set
            {
                warning = value;
            }
        }
        /// <summary>
        /// The GrossWeight property
        ///
        /// </summary>
        ///
        public virtual decimal? GrossWeight
        {
            get
            {
                return grossWeight;
            }
            set
            {
                grossWeight = value;
            }
        }
        /// <summary>
        /// The StopSelling property
        ///
        /// </summary>
        ///
        public virtual int? StopSelling
        {
            get
            {
                return stopSelling;
            }
            set
            {
                stopSelling = value;
            }
        }


        public virtual int Quantity
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

        public virtual decimal BillingQuantity
        {
            get
            {
                return billingQuantity;
            }
            set
            {
                billingQuantity = value;
            }
        }


        public virtual decimal OrderQuantity
        {
            get
            {
                return orderQuantity;
            }
            set
            {
                orderQuantity = value;
            }
        }

        public virtual decimal GrossValue
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


        public virtual decimal VatValue
        {
            get
            {
                return vatValue;
            }
            set
            {
                vatValue = value;
            }
        }

        public virtual decimal TotalValue
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

        #endregion

        /// <summary>
        /// Public constructors of the Product class
        /// </summary>
        /// <returns>New Product object</returns>
        /// <remarks></remarks>
        /// 
        public Product() { }
    }
}
