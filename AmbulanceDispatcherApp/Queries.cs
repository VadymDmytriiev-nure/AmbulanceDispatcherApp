using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceDispatcherApp
{
    public class Queries
    {
        public static string QUERY_RETRIEVE_USER_INFO = "SELECT `user_role`, `worker_id`, `dispatcher_id` FROM `emergencyhealthcare`.`Users` WHERE `user_login` = @userlogin;";
        public static string QUERY_RETRIEVE_CALLS = "SELECT `call`.*, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `call` LEFT JOIN `dispatcher` ON `call`.dispatcher_id = `dispatcher`.dispatcher_id";
        public static string QUERY_RETRIEVE_CALLOUTS_P1 = "SELECT * FROM `callout`";
        public static string QUERY_RETRIEVE_CALLOUTS_P2 = "ORDER BY `callout_time_created`";
        public static string QUERY_RETRIEVE_DISPATCHERS = "SELECT *, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `dispatcher`";
        public static string QUERY_RETRIEVE_SUBSTATIONS = "SELECT * FROM `substation` ORDER BY `substation`.`substation_code` ASC";
        public static string QUERY_RETRIEVE_BRIGADES_P1 = "SELECT b.*, s.`substation_address`, s.`substation_code`, COUNT(worker_id) as brigade_worker_count FROM `brigade` b LEFT JOIN `worker` w ON w.`brigade_id` = b.`brigade_id` LEFT join `substation` s on s.`substation_id` = b.`substation_id`";
        public static string QUERY_RETRIEVE_BRIGADES_P2 = "GROUP BY b.`brigade_id`";
        public static string QUERY_RETRIEVE_HOSPITALS = "SELECT * FROM `hospital`";
        public static string QUERY_RETRIEVE_WORKERS = "SELECT worker.*, CONCAT(worker_surname,' ',worker_name,' ',worker_patriarchic) AS worker_fullname, brigade_code FROM worker LEFT JOIN `brigade` ON `brigade`.brigade_id = `worker`.brigade_id";
        public static string QUERY_RETRIEVE_DEPARTURES_P1 = "SELECT * FROM `departure`";
        public static string QUERY_RETRIEVE_DEPARTURES_P2 = "ORDER BY `departure_time_departed` DESC";
        public static string QUERY_RETRIEVE_PATIENTS = "SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient`";
        public static string QUERY_RETRIEVE_USERS = "SELECT * FROM `users`";
    }
}
