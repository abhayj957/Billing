using BillingApplication.DBContexts;
using BillingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillingApplication.Context
{
    public class CustomerBl
    {  
        //linq query used to retrive customer details from (ImSS_Master_Client) 
        //public List<customer> GetCustomerList()
        //{
        //    try
        //    {
        //        using (var context = new Billing_StagingEntities1())
        //        {

        //            var CustomerList = (from a in context.ImSS_Client_Details
        //                                join b in context.ImSS_Cust_Emp_Details on a.Emp_Name equals b.Emp_Number
        //                                select new customer
        //                                {
        //                                    Emp_Name = a.Emp_Name,
        //                                    Client_Name = a.Client_Name,
        //                                    Email = a.Email,
        //                                    Reporting_Manager_at_client_place = a.Reporting_Manager_at_client_place,
        //                                    Cilent_Start_Date = b.Cilent_Start_Date,
        //                                    Shadow = a.Shadow,
        //                                    Location = a.Location,
        //                                    Status = a.Status
        //                                }).ToList();
        //            return CustomerList;
        //        }
        //    }

        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //}
        public List<ImSS_Client_Details> GetCustomerList()
        {
            try
            {
                using (var context = new Billing_StagingEntities1())
                {

                    var CustomerList = (from po in context.ImSS_Client_Details select po).ToList();

                    return CustomerList;
                }
            }

            catch (Exception e)
            {
                throw e;
            }

        }


        //linq query used to insert customer details into (ImSS_Master_Client)
        //public ImSS_Master_Client AddCustomer(ImSS_Master_Client Addcust)
        //{
        //    try
        //    {
        //        using (var context = new Billing_StagingEntities1())
        //        {
        //            ImSS_Cust_Emp_Details lst = new ImSS_Cust_Emp_Details();
        //            lst.Cilent_Start_Date = DateTime.Now;
        //            lst.Emp_Number = Addcust.Emp_Name;
        //            lst.Cilent_ID = Addcust.Client_Name;
        //            context.ImSS_Cust_Emp_Details.Add(lst);
        //            context.ImSS_Master_Client.Add(Addcust);
        //            context.SaveChanges();
        //            return Addcust;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //}

        public ImSS_Client_Details AddCustomer(ImSS_Client_Details Addcust)
        {
            try
            {
                using (var context = new Billing_StagingEntities1())
                {
                    ImSS_Cust_Emp_Details lst = new ImSS_Cust_Emp_Details();
                    Addcust.Cilent_Start_Date = DateTime.Now;
                    lst.Cilent_Start_Date = Addcust.Cilent_Start_Date;
                    lst.Emp_Number = Addcust.Emp_Name;
                    lst.Cilent_ID = Addcust.Client_Name;
                    context.ImSS_Cust_Emp_Details.Add(lst);
                    context.ImSS_Client_Details.Add(Addcust);
                    context.SaveChanges();
                    return Addcust;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        //linq query used to update employee details of (ImSS_Master_Emp_List)
        //public List<customer> UpdateCilent(customer cl)
        //{
        //    try
        //    {
        //        using (var context = new Billing_StagingEntities1())
        //        {
        //            ImSS_Master_Client Update = (from c in context.ImSS_Master_Client join o in context.ImSS_Cust_Emp_Details on c.Emp_Name equals o.Emp_Number select c).FirstOrDefault();
        //            Update.Emp_Name = cl.Emp_Name;
        //            Update.Client_Name = cl.Client_Name;
        //            Update.Email = cl.Email;
        //            Update.Reporting_Manager_at_client_place = cl.Reporting_Manager_at_client_place;
        //            Update = cl.Cilent_Start_Date;
        //            Update.Shadow = cl.Shadow;
        //            Update.Location = cl.Location;
        //            Update.Status = cl.Status;
        //            context.SaveChanges();
        //            return (from a in context.ImSS_Master_Client select a).ToList();

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        public List<ImSS_Client_Details> UpdateCilent(ImSS_Client_Details cl)
        {
            try
            {
                using (var context = new Billing_StagingEntities1())
                {
                    ImSS_Client_Details Update = (from c in context.ImSS_Client_Details select c).FirstOrDefault();
                    Update.Emp_Name = cl.Emp_Name;
                    Update.Client_Name = cl.Client_Name;
                    Update.Email = cl.Email;
                    Update.Reporting_Manager_at_client_place = cl.Reporting_Manager_at_client_place;
                    Update.Cilent_Start_Date = cl.Cilent_Start_Date;
                    Update.Shadow = cl.Shadow;
                    Update.Location = cl.Location;
                    Update.Status = cl.Status;
                    context.SaveChanges();
                    return (from a in context.ImSS_Client_Details select a).ToList();

                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }

        //linq query used to delete employee details of (ImSS_Master_Emp_List)
        public List<ImSS_Master_Client> Delete(int? Id)
        {
            try
            {
                using (var context = new Billing_StagingEntities1())
                {
                    ImSS_Master_Client DeleteCilent = (from c in context.ImSS_Master_Client where c.ID == Id select c).FirstOrDefault();
                    if (DeleteCilent != null)
                    {
                        context.ImSS_Master_Client.Remove(DeleteCilent);
                        context.SaveChanges();
                    }
                    return (from a in context.ImSS_Master_Client select a).ToList();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //ling query used to get cilent(ImSS_Client_List)
        public List<ImSS_Client_List> GetClientList()
        {
            try
            {
                using (var context = new Billing_StagingEntities1())
                {
                    var list = (from a in context.ImSS_Client_List select a).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //ling query used to get employee name(ImSS_Master_Emp_List)
        public List<ImSS_Master_Emp_List> GetEmployeeNameList()
        {
            try
            {
                using (var context = new Billing_StagingEntities1())
                {
                    var list = (from a in context.ImSS_Master_Emp_List select a).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //ling query used to shadow(ImSS_Shadow)
        public List<ImSS_Shadow> GetShadowList()
        {
            try
            {
                using (var context = new Billing_StagingEntities1())
                {
                    var list = (from a in context.ImSS_Shadow select a).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //ling query used to get status(ImSS_Cilent_Status)
        public List<ImSS_Cilent_Status> GetStatusList()
        {
            try
            {
                using (var context = new Billing_StagingEntities1())
                {
                    var list = (from a in context.ImSS_Cilent_Status select a).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        //ling query used to get location(ImSS_Location)
        public List<ImSS_Location> GetLocationList()
        {
            try
            {
                using (var context = new Billing_StagingEntities1())
                {
                    var list = (from a in context.ImSS_Location select a).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}