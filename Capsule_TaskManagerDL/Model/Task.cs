//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capsule_TaskManagerDL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int Task_ID { get; set; }
        public string Task1 { get; set; }
        public int Project_ID { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<int> Parent_ID { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<int> User_ID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Is_Active { get; set; }
        public string Action { get; set; }
    
        public virtual Parent_Task Parent_Task { get; set; }
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}
