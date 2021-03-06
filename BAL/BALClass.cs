﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public static class BALClass
    {
        /// <summary>
        /// Method to get all designations.
        /// </summary>
        /// <returns>List of designation</returns>
        public static List<Designation> GetAllDesignation()
        {
            List<Designation> designationList = new List<Designation>();

            DataTable dt = new DataTable();
            dt = DALClass.GetAllDesignation();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    designationList.Add(new Designation
                    {
                        DesignationID = Convert.ToInt32(row[0]),
                        DesignationName = row[1].ToString()
                    });
                }
            }

            return designationList;
        }

        /// <summary>
        /// Method to get all employment status list.
        /// </summary>
        /// <returns>List of all employment status</returns>
        public static List<EmploymentStatus> GetAllEmploymentStatus()
        {
            List<EmploymentStatus> employmentStatusList = new List<EmploymentStatus>();

            DataTable dt = new DataTable();
            dt = DALClass.GetAllEmploymentStatus();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    employmentStatusList.Add(new EmploymentStatus
                    {
                        EmploymentStatusID = Convert.ToInt32(row[0]),
                        EmploymentStatusName = row[1].ToString()
                    });
                }
            }

            return employmentStatusList;
        }
    }
}
