//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.BD
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// DSE.
    /// </summary>
    //  *** Start programmer edit section *** (DSE CustomAttributes)

    //  *** End programmer edit section *** (DSE CustomAttributes)
    [AutoAltered()]
    [Caption("ДСЕ")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class DSE : ICSSoft.STORMNET.DataObject
    {
        
        private int fCode;
        
        private string fName;
        
        //  *** Start programmer edit section *** (DSE CustomMembers)

        //  *** End programmer edit section *** (DSE CustomMembers)

        
        /// <summary>
        /// Code.
        /// </summary>
        //  *** Start programmer edit section *** (DSE.Code CustomAttributes)

        //  *** End programmer edit section *** (DSE.Code CustomAttributes)
        [NotNull()]
        public virtual int Code
        {
            get
            {
                //  *** Start programmer edit section *** (DSE.Code Get start)

                //  *** End programmer edit section *** (DSE.Code Get start)
                int result = this.fCode;
                //  *** Start programmer edit section *** (DSE.Code Get end)

                //  *** End programmer edit section *** (DSE.Code Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (DSE.Code Set start)

                //  *** End programmer edit section *** (DSE.Code Set start)
                this.fCode = value;
                //  *** Start programmer edit section *** (DSE.Code Set end)

                //  *** End programmer edit section *** (DSE.Code Set end)
            }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        //  *** Start programmer edit section *** (DSE.Name CustomAttributes)

        //  *** End programmer edit section *** (DSE.Name CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Name
        {
            get
            {
                //  *** Start programmer edit section *** (DSE.Name Get start)

                //  *** End programmer edit section *** (DSE.Name Get start)
                string result = this.fName;
                //  *** Start programmer edit section *** (DSE.Name Get end)

                //  *** End programmer edit section *** (DSE.Name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (DSE.Name Set start)

                //  *** End programmer edit section *** (DSE.Name Set start)
                this.fName = value;
                //  *** Start programmer edit section *** (DSE.Name Set end)

                //  *** End programmer edit section *** (DSE.Name Set end)
            }
        }
    }
}
