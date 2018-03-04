using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentProject.Common
{
    public static class CommonFunctions
    {
        /// <summary>
        /// Method to convert designation object into select list item.
        /// </summary>
        /// <param name="designationList">List of designation object</param>
        /// <returns>List of select list item</returns>
        public static List<SelectListItem> ConvertDesignationToListItem(List<Designation> designationList)
        {
            List<SelectListItem> designationListItem = new List<SelectListItem>();

            if (designationList != null && designationList.Count > 0)
            {
                foreach (var designation in designationList)
                {
                    designationListItem.Add(new SelectListItem
                    {
                        Text = designation.DesignationName,
                        Value = Convert.ToString(designation.DesignationID)
                    });
                }
            }

            return designationListItem;
        }

        /// <summary>
        /// Method to convert employment status object into select list item.
        /// </summary>
        /// <param name="employmentStatusList">List of employment status list object</param>
        /// <returns>List of select list item</returns>
        public static List<SelectListItem> ConvertEmpStatusToListItem(List<EmploymentStatus> employmentStatusList)
        {
            List<SelectListItem> employmentStatusListItem = new List<SelectListItem>();

            if (employmentStatusList != null && employmentStatusList.Count > 0)
            {
                foreach (var empStatus in employmentStatusList)
                {
                    employmentStatusListItem.Add(new SelectListItem
                    {
                        Text = empStatus.EmploymentStatusName,
                        Value = Convert.ToString(empStatus.EmploymentStatusID)
                    });
                }
            }

            return employmentStatusListItem;
        }
    }
}