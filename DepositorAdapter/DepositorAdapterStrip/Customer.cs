using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositorAdapterStrip
{
    class Customer
    {
        public Customer() { }
       
        protected int? id = 0;
        
        protected string customerCode;
        
        protected string companyName;
        
        protected string occupation;
        
        protected string taxOfficeCode;
        
        protected string taxOfficeName;
        
        protected string vATNo;
        
        protected string region;
        
        protected string city;
        
        protected string address;
        
        protected string postalCode;
        
        protected string dOY;
        
        protected string region_2;
        
        protected string city_2;
        
        protected string address_2;
        
        protected string postalCode_2;
        
        protected string telephone;

        protected string document;

        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
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
        /// The CompanyName property
        ///
        /// </summary>
        ///
        public virtual string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }
        /// <summary>
        /// The Occupation property
        ///
        /// </summary>
        ///
        public virtual string Occupation
        {
            get
            {
                return occupation;
            }
            set
            {
                occupation = value;
            }
        }
        /// <summary>
        /// The TaxOfficeCode property
        ///
        /// </summary>
        ///
        public virtual string TaxOfficeCode
        {
            get
            {
                return taxOfficeCode;
            }
            set
            {
                taxOfficeCode = value;
            }
        }
        /// <summary>
        /// The TaxOfficeName property
        ///
        /// </summary>
        ///
        public virtual string TaxOfficeName
        {
            get
            {
                return taxOfficeName;
            }
            set
            {
                taxOfficeName = value;
            }
        }
        /// <summary>
        /// The VATNo property
        ///
        /// </summary>
        ///
        public virtual string VATNo
        {
            get
            {
                return vATNo;
            }
            set
            {
                vATNo = value;
            }
        }
        /// <summary>
        /// The Region property
        ///
        /// </summary>
        ///
        public virtual string Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }
        /// <summary>
        /// The City property
        ///
        /// </summary>
        ///
        public virtual string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        /// <summary>
        /// The Address property
        ///
        /// </summary>
        ///
        public virtual string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        /// <summary>
        /// The PostalCode property
        ///
        /// </summary>
        ///
        public virtual string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }
        /// <summary>
        /// The DOY property
        ///
        /// </summary>
        ///
        public virtual string DOY
        {
            get
            {
                return dOY;
            }
            set
            {
                dOY = value;
            }
        }
        /// <summary>
        /// The Region_2 property
        ///
        /// </summary>
        ///
        public virtual string Region_2
        {
            get
            {
                return region_2;
            }
            set
            {
                region_2 = value;
            }
        }
        /// <summary>
        /// The City_2 property
        ///
        /// </summary>
        ///
        public virtual string City_2
        {
            get
            {
                return city_2;
            }
            set
            {
                city_2 = value;
            }
        }
        /// <summary>
        /// The Address_2 property
        ///
        /// </summary>
        ///
        public virtual string Address_2
        {
            get
            {
                return address_2;
            }
            set
            {
                address_2 = value;
            }
        }
        /// <summary>
        /// The PostalCode_2 property
        ///
        /// </summary>
        ///
        public virtual string PostalCode_2
        {
            get
            {
                return postalCode_2;
            }
            set
            {
                postalCode_2 = value;
            }
        }
        /// <summary>
        /// The Telephone property
        ///
        /// </summary>
        ///
        public virtual string Telephone
        {
            get
            {
                return telephone;
            }
            set
            {
                telephone = value;
            }
        }


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


    }
       

    }

