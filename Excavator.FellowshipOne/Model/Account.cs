//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Excavator.F1
{
    using System;
    using System.Collections.Generic;

    public partial class Account
    {
        public Nullable<int> Individual_ID { get; set; }

        public Nullable<int> Household_ID { get; set; }

        public string Account_Type_Name { get; set; }

        // Summary:
        // Actual column name is Account, not Account_Name.  Renamed to avoid EF conflicts.
        public string Account_Name { get; set; }

        public Nullable<int> Routing_Number { get; set; }
    }
}
