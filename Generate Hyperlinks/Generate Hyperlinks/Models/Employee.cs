//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Generate_Hyperlinks.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Nullable<int> AnuualSalary { get; set; }
        public Nullable<int> HourlyPay { get; set; }
        public Nullable<int> HoursWorked { get; set; }
        public string Discriminator { get; set; }
    }
}