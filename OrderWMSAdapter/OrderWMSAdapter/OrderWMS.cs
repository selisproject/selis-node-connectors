using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWMSAdapter
{
    public class OrderWMS 
    {
        #region OrderWMS's Fields

        protected int ordID;

        protected int ordOrderID_Remote;
        protected string ordOrderExternalCode;
        protected string ordOrderDescr;
        protected DateTime ordRegDateTime;
        protected DateTime ordDateTime;
        protected DateTime ordDeliveryDateTime;
        protected string ordDepositorCode;
        protected string ordDepositorFullName;
        protected string ordCustomerCode;
        protected string ordCustomerFullName;
        protected int ordStatus;
        protected string ordMemo;
        protected string ordPurpose;
        protected float ordDeliveryValue;
        protected string ordDeliveryNotes;
        protected int ordIsReturn;
        protected string ordPrdTypeDescr;
        protected string ordWrhRoutingCode;
        protected int ordDlsId;
        protected string ordDlsDescr;
        protected string ordDlsAddress;
        protected string ordDlsZipCode;
        protected string ordDlsCity;
        protected string ordDlsArea;
        protected int ordRoutingStatus;
        protected float ordLfdWeight;
        protected float ordLfdVol;
        protected int ordLfdCtn;
        protected int ordLfdBar;
        protected int ordLfdPalEuro;
        protected int ordLfdPalInd;
        protected int ordLfdPalElsa;
        protected int ordLfdParOU;
        protected int ordLfdVar;
        protected DateTime ordVoucherDateTime;
        protected string ordVoucherNumber;
        protected string ordVoucherSeries;
        protected int ordVoucherId;
        protected string ordAgencyCode;
        protected string ordAgencyDescr;
        protected string ordAgencyAddress;
        protected long ordTelRouteId;
        protected string ordVchPlateNr;
        protected int ordVchRouteNr;
        protected DateTime ordVhrDate;
        protected long ordVhrID;
        protected DateTime ordLastUpdateDateTime;
        protected int ordReadyForLoading;
        #endregion
        #region OrderWMS's Properties
        /// <summary>
        /// The Id property
        ///
        /// </summary>
        ///
       
        /// <summary>
        /// The OrdID property
        ///
        /// </summary>
        ///
        public virtual int OrdID
        {
            get
            {
                return ordID;
            }
            set
            {
                ordID = value;
            }
        }
        /// <summary>
        /// The OrdOrderID_Remote property
        ///
        /// </summary>
        ///
        public virtual int OrdOrderID_Remote
        {
            get
            {
                return ordOrderID_Remote;
            }
            set
            {
                ordOrderID_Remote = value;
            }
        }
        /// <summary>
        /// The OrdOrderExternalCode property
        ///
        /// </summary>
        ///
        public virtual string OrdOrderExternalCode
        {
            get
            {
                return ordOrderExternalCode;
            }
            set
            {
                ordOrderExternalCode = value;
            }
        }
        /// <summary>
        /// The OrdOrderDescr property
        ///
        /// </summary>
        ///
        public virtual string OrdOrderDescr
        {
            get
            {
                return ordOrderDescr;
            }
            set
            {
                ordOrderDescr = value;
            }
        }
        /// <summary>
        /// The OrdRegDateTime property
        ///
        /// </summary>
        ///
        public virtual DateTime OrdRegDateTime
        {
            get
            {
                return ordRegDateTime;
            }
            set
            {
                ordRegDateTime = value;
            }
        }
        /// <summary>
        /// The OrdDateTime property
        ///
        /// </summary>
        ///
        public virtual DateTime OrdDateTime
        {
            get
            {
                return ordDateTime;
            }
            set
            {
                ordDateTime = value;
            }
        }
        /// <summary>
        /// The OrdDeliveryDateTime property
        ///
        /// </summary>
        ///
        public virtual DateTime OrdDeliveryDateTime
        {
            get
            {
                return ordDeliveryDateTime;
            }
            set
            {
                ordDeliveryDateTime = value;
            }
        }
        /// <summary>
        /// The OrdDepositorCode property
        ///
        /// </summary>
        ///
        public virtual string OrdDepositorCode
        {
            get
            {
                return ordDepositorCode;
            }
            set
            {
                ordDepositorCode = value;
            }
        }
        /// <summary>
        /// The OrdDepositorFullName property
        ///
        /// </summary>
        ///
        public virtual string OrdDepositorFullName
        {
            get
            {
                return ordDepositorFullName;
            }
            set
            {
                ordDepositorFullName = value;
            }
        }
        /// <summary>
        /// The OrdCustomerCode property
        ///
        /// </summary>
        ///
        public virtual string OrdCustomerCode
        {
            get
            {
                return ordCustomerCode;
            }
            set
            {
                ordCustomerCode = value;
            }
        }
        /// <summary>
        /// The OrdCustomerFullName property
        ///
        /// </summary>
        ///
        public virtual string OrdCustomerFullName
        {
            get
            {
                return ordCustomerFullName;
            }
            set
            {
                ordCustomerFullName = value;
            }
        }
        /// <summary>
        /// The OrdStatus property
        ///
        /// </summary>
        ///
        public virtual int OrdStatus
        {
            get
            {
                return ordStatus;
            }
            set
            {
                ordStatus = value;
            }
        }
        /// <summary>
        /// The OrdMemo property
        ///
        /// </summary>
        ///
        public virtual string OrdMemo
        {
            get
            {
                return ordMemo;
            }
            set
            {
                ordMemo = value;
            }
        }
        /// <summary>
        /// The OrdPurpose property
        ///
        /// </summary>
        ///
        public virtual string OrdPurpose
        {
            get
            {
                return ordPurpose;
            }
            set
            {
                ordPurpose = value;
            }
        }
        /// <summary>
        /// The OrdDeliveryValue property
        ///
        /// </summary>
        ///
        public virtual float OrdDeliveryValue
        {
            get
            {
                return ordDeliveryValue;
            }
            set
            {
                ordDeliveryValue = value;
            }
        }
        /// <summary>
        /// The OrdDeliveryNotes property
        ///
        /// </summary>
        ///
        public virtual string OrdDeliveryNotes
        {
            get
            {
                return ordDeliveryNotes;
            }
            set
            {
                ordDeliveryNotes = value;
            }
        }
        /// <summary>
        /// The OrdIsReturn property
        ///
        /// </summary>
        ///
        public virtual int OrdIsReturn
        {
            get
            {
                return ordIsReturn;
            }
            set
            {
                ordIsReturn = value;
            }
        }
        /// <summary>
        /// The OrdPrdTypeDescr property
        ///
        /// </summary>
        ///
        public virtual string OrdPrdTypeDescr
        {
            get
            {
                return ordPrdTypeDescr;
            }
            set
            {
                ordPrdTypeDescr = value;
            }
        }
        /// <summary>
        /// The OrdWrhRoutingCode property
        ///
        /// </summary>
        ///
        public virtual string OrdWrhRoutingCode
        {
            get
            {
                return ordWrhRoutingCode;
            }
            set
            {
                ordWrhRoutingCode = value;
            }
        }
        /// <summary>
        /// The OrdDlsId property
        ///
        /// </summary>
        ///
        public virtual int OrdDlsId
        {
            get
            {
                return ordDlsId;
            }
            set
            {
                ordDlsId = value;
            }
        }
        /// <summary>
        /// The OrdDlsDescr property
        ///
        /// </summary>
        ///
        public virtual string OrdDlsDescr
        {
            get
            {
                return ordDlsDescr;
            }
            set
            {
                ordDlsDescr = value;
            }
        }
        /// <summary>
        /// The OrdDlsAddress property
        ///
        /// </summary>
        ///
        public virtual string OrdDlsAddress
        {
            get
            {
                return ordDlsAddress;
            }
            set
            {
                ordDlsAddress = value;
            }
        }
        /// <summary>
        /// The OrdDlsZipCode property
        ///
        /// </summary>
        ///
        public virtual string OrdDlsZipCode
        {
            get
            {
                return ordDlsZipCode;
            }
            set
            {
                ordDlsZipCode = value;
            }
        }
        /// <summary>
        /// The OrdDlsCity property
        ///
        /// </summary>
        ///
        public virtual string OrdDlsCity
        {
            get
            {
                return ordDlsCity;
            }
            set
            {
                ordDlsCity = value;
            }
        }
        /// <summary>
        /// The OrdDlsArea property
        ///
        /// </summary>
        ///
        public virtual string OrdDlsArea
        {
            get
            {
                return ordDlsArea;
            }
            set
            {
                ordDlsArea = value;
            }
        }
        /// <summary>
        /// The OrdRoutingStatus property
        ///
        /// </summary>
        ///
        public virtual int OrdRoutingStatus
        {
            get
            {
                return ordRoutingStatus;
            }
            set
            {
                ordRoutingStatus = value;
            }
        }
        /// <summary>
        /// The OrdLfdWeight property
        ///
        /// </summary>
        ///
        public virtual float OrdLfdWeight
        {
            get
            {
                return ordLfdWeight;
            }
            set
            {
                ordLfdWeight = value;
            }
        }
        /// <summary>
        /// The OrdLfdVol property
        ///
        /// </summary>
        ///
        public virtual float OrdLfdVol
        {
            get
            {
                return ordLfdVol;
            }
            set
            {
                ordLfdVol = value;
            }
        }
        /// <summary>
        /// The OrdLfdCtn property
        ///
        /// </summary>
        ///
        public virtual int OrdLfdCtn
        {
            get
            {
                return ordLfdCtn;
            }
            set
            {
                ordLfdCtn = value;
            }
        }
        /// <summary>
        /// The OrdLfdBar property
        ///
        /// </summary>
        ///
        public virtual int OrdLfdBar
        {
            get
            {
                return ordLfdBar;
            }
            set
            {
                ordLfdBar = value;
            }
        }
        /// <summary>
        /// The OrdLfdPalEuro property
        ///
        /// </summary>
        ///
        public virtual int OrdLfdPalEuro
        {
            get
            {
                return ordLfdPalEuro;
            }
            set
            {
                ordLfdPalEuro = value;
            }
        }
        /// <summary>
        /// The OrdLfdPalInd property
        ///
        /// </summary>
        ///
        public virtual int OrdLfdPalInd
        {
            get
            {
                return ordLfdPalInd;
            }
            set
            {
                ordLfdPalInd = value;
            }
        }
        /// <summary>
        /// The OrdLfdPalElsa property
        ///
        /// </summary>
        ///
        public virtual int OrdLfdPalElsa
        {
            get
            {
                return ordLfdPalElsa;
            }
            set
            {
                ordLfdPalElsa = value;
            }
        }
        /// <summary>
        /// The OrdLfdParOU property
        ///
        /// </summary>
        ///
        public virtual int OrdLfdParOU
        {
            get
            {
                return ordLfdParOU;
            }
            set
            {
                ordLfdParOU = value;
            }
        }
        /// <summary>
        /// The OrdLfdVar property
        ///
        /// </summary>
        ///
        public virtual int OrdLfdVar
        {
            get
            {
                return ordLfdVar;
            }
            set
            {
                ordLfdVar = value;
            }
        }
        /// <summary>
        /// The OrdVoucherDateTime property
        ///
        /// </summary>
        ///
        public virtual DateTime OrdVoucherDateTime
        {
            get
            {
                return ordVoucherDateTime;
            }
            set
            {
                ordVoucherDateTime = value;
            }
        }
        /// <summary>
        /// The OrdVoucherNumber property
        ///
        /// </summary>
        ///
        public virtual string OrdVoucherNumber
        {
            get
            {
                return ordVoucherNumber;
            }
            set
            {
                ordVoucherNumber = value;
            }
        }
        /// <summary>
        /// The OrdVoucherSeries property
        ///
        /// </summary>
        ///
        public virtual string OrdVoucherSeries
        {
            get
            {
                return ordVoucherSeries;
            }
            set
            {
                ordVoucherSeries = value;
            }
        }
        /// <summary>
        /// The OrdVoucherId property
        ///
        /// </summary>
        ///
        public virtual int OrdVoucherId
        {
            get
            {
                return ordVoucherId;
            }
            set
            {
                ordVoucherId = value;
            }
        }
        /// <summary>
        /// The OrdAgencyCode property
        ///
        /// </summary>
        ///
        public virtual string OrdAgencyCode
        {
            get
            {
                return ordAgencyCode;
            }
            set
            {
                ordAgencyCode = value;
            }
        }
        /// <summary>
        /// The OrdAgencyDescr property
        ///
        /// </summary>
        ///
        public virtual string OrdAgencyDescr
        {
            get
            {
                return ordAgencyDescr;
            }
            set
            {
                ordAgencyDescr = value;
            }
        }
        /// <summary>
        /// The OrdAgencyAddress property
        ///
        /// </summary>
        ///
        public virtual string OrdAgencyAddress
        {
            get
            {
                return ordAgencyAddress;
            }
            set
            {
                ordAgencyAddress = value;
            }
        }
        /// <summary>
        /// The OrdTelRouteId property
        ///
        /// </summary>
        ///
        public virtual long OrdTelRouteId
        {
            get
            {
                return ordTelRouteId;
            }
            set
            {
                ordTelRouteId = value;
            }
        }
        /// <summary>
        /// The OrdVchPlateNr property
        ///
        /// </summary>
        ///
        public virtual string OrdVchPlateNr
        {
            get
            {
                return ordVchPlateNr;
            }
            set
            {
                ordVchPlateNr = value;
            }
        }
        /// <summary>
        /// The OrdVchRouteNr property
        ///
        /// </summary>
        ///
        public virtual int OrdVchRouteNr
        {
            get
            {
                return ordVchRouteNr;
            }
            set
            {
                ordVchRouteNr = value;
            }
        }
        /// <summary>
        /// The OrdVhrDate property
        ///
        /// </summary>
        ///
        public virtual DateTime OrdVhrDate
        {
            get
            {
                return ordVhrDate;
            }
            set
            {
                ordVhrDate = value;
            }
        }
        /// <summary>
        /// The OrdVhrID property
        ///
        /// </summary>
        ///
        public virtual long OrdVhrID
        {
            get
            {
                return ordVhrID;
            }
            set
            {
                ordVhrID = value;
            }
        }
        /// <summary>
        /// The OrdLastUpdateDateTime property
        ///
        /// </summary>
        ///
        public virtual DateTime OrdLastUpdateDateTime
        {
            get
            {
                return ordLastUpdateDateTime;
            }
            set
            {
                ordLastUpdateDateTime = value;
            }
        }
        /// <summary>
        /// The OrdReadyForLoading property
        ///
        /// </summary>
        ///
        public virtual int OrdReadyForLoading
        {
            get
            {
                return ordReadyForLoading;
            }
            set
            {
                ordReadyForLoading = value;
            }
        }
        /// <summary>
        /// The VersionTimestamp property
        ///Provides concurrency control for the class
        /// </summary>
        ///
        
        #endregion
        #region Constructors
        /// <summary>
        /// Public constructors of the OrderWMS class
        /// </summary>
        /// <returns>New OrderWMS object</returns>
        /// <remarks></remarks>
        public OrderWMS() { }
        #endregion
       


    }
}
