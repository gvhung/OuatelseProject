﻿using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Singleton qui gère les congés
    /// </summary>
    public class HolidayManager : BaseManager<Holiday>
    {
        private static HolidayManager _instance = null;

        public static HolidayManager Instance
        {
            get { return _instance ?? (_instance = new HolidayManager()); }
        }

        private HolidayManager()
        {
            this.TableName = "conge";
        }

        public Holiday FilterAllByDateByEmployee(DateTime date, Employee emp)
        {
           Holiday holiday = HolidayManager.Instance.First("WHERE salaries_id='"+ emp.Id +"' AND accepte = 0 AND '" + String.Format("{0:yyyy-MM-dd}", date) + "' BETWEEN date_debut AND date_fin");
            return holiday;
        }

        public List<Holiday> FilterAllByDate(DateTime date)
        {
            List<Holiday> holidaysList = HolidayManager.Instance.Filter("WHERE '" + String.Format("{0:yyyy-MM-dd}", date) + "' BETWEEN date_debut AND date_fin").ToList();
            return holidaysList;
        }

        public Holiday FilterByDate(DateTime date)
        {
            return HolidayManager.Instance.First("WHERE salaries_id = " + AuthManager.Instance.User.Id + " AND '" + String.Format("{0:yyyy-MM-dd}", date) + "' BETWEEN date_debut AND date_fin");          
        }

        public Holiday FilterByDateAndNotCurrent(int id, DateTime date)
        {
            return HolidayManager.Instance.First("WHERE salaries_id = " + AuthManager.Instance.User.Id + " AND conge.id <> " + id +" AND '" +
                                          String.Format("{0:yyyy-MM-dd}", date) + "' BETWEEN date_debut AND date_fin");
        }

        public List<Holiday> FilterByEmployeesInSameStore()
        {
            return HolidayManager.Instance.Filter("INNER JOIN salaries ON conge.salaries_id = salaries.id INNER JOIN magasin ON salaries.magagin_id = magasin.id WHERE salaries_id <>" + AuthManager.Instance.User.Id  + "AND magasin.id =" + AuthManager.Instance.User.Store.Id).ToList();
        }

        public List<Holiday> FilterByYearForCurrentEmployee(int currentYear)
        {
            return HolidayManager.Instance.Filter("WHERE salaries_id =" + AuthManager.Instance.User.Id + " AND " + currentYear + " = YEAR(date_debut)").ToList();
        }

        public List<Holiday> FilterByYearByEmployee(int currentYear, int idEmployee)
        {
            return HolidayManager.Instance.Filter("WHERE salaries_id =" + idEmployee + " AND " + currentYear + " = YEAR(date_debut)").ToList();
        }

        public static string CreationQuery()
        {
            string query = "DROP TABLE IF EXISTS \"conge\";" + Environment.NewLine;
            query += " CREATE TABLE \"conge\" ( " + Environment.NewLine;
            query += " \"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + Environment.NewLine;
            query += " \"date_debut\" TEXT NOT NULL, " + Environment.NewLine;
            query += "\"date_fin\" TEXT NOT NULL, " + Environment.NewLine;
            query += " \"salaries_id\" INTEGER(11,0) NOT NULL, " + Environment.NewLine;
            query += " \"accepte\" INTEGER(1,0) NOT NULL);";
            return query;
        }

        public static string CreationIndex()
        {
            return " CREATE INDEX \"fk_conge_salaries1_idx\" ON conge (salaries_id);";
        }

        public static string Fixtures()
        {
            return "INSERT INTO conge VALUES (1,\"2015-08-02\", \"2015-08-09\", 15, 0);";
        }
    }
}
