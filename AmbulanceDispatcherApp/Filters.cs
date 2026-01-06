using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AmbulanceDispatcherApp
{
    interface IFilters
    {
        public Tuple<string, List<MySqlParameter>> GetSQLFilter();
        public MySqlCommand GetSQLCommand(MySqlConnection conn);
    }

    public class CallFilters : IFilters
    {
        public (DateTime? Min, DateTime? Max) TimeRange;
        public (int? Min, int? Max) CallIDRange;
        public (int? Min, int? Max) CalloutIDRange;
        public int? DispatcherID;
        public string? CallerSurname;
        public string? CallerName;
        public string? CallerPatriarchic;
        public string? CallerTel;
        public string? Address;
        public string? Reason;
        public string? Channel;

        public CallFilters() {}

        public Tuple<string, List<MySqlParameter>> GetSQLFilter()
        {
            List<string> filters = new List<string>();

            if (Address != null)
                filters.Add("lower(`call`.call_address) LIKE lower(@address)");

            if (Channel != null)
                filters.Add("lower(`call`.call_channel) LIKE lower(@channel)");

            if (Reason != null)
                filters.Add("lower(`call`.call_reason) LIKE lower(@reason)");

            if (CallerSurname != null)
                filters.Add("lower(`call`.call_caller_surname) LIKE lower(@surname)");

            if (CallerName != null)
                filters.Add("lower(`call`.call_caller_name) LIKE lower(@name)");

            if (CallerPatriarchic != null)
                filters.Add("lower(`call`.call_caller_patriarchic) LIKE lower(@patriarchic)");

            if (CallerTel != null)
                filters.Add("`call`.call_caller_tel = @tel");

            if (DispatcherID != null)
                filters.Add("`call`.dispatcher_id = @dispatcher");

            if (CalloutIDRange.Min != null)
                filters.Add("`call`.callout_id >= @callout_min");

            if (CalloutIDRange.Max != null)
                filters.Add("`call`.callout_id <= @callout_max");

            if (CallIDRange.Min != null)
                filters.Add("`call`.call_id >= @call_min");

            if (CallIDRange.Max != null)
                filters.Add("`call`.call_id <= @call_max");

            filters.Add("`call`.call_time_created >= @time_from");
            filters.Add("`call`.call_time_created <= @time_to");

            string filter = "WHERE " + String.Join(" AND ", filters);
            if (filters.Count == 0)
                filter = "";

            List<MySqlParameter> p = new List<MySqlParameter>();

            p.Add(new MySqlParameter("@address", "%" + Address + "%"));
            p.Add(new MySqlParameter("@channel", "%" + Channel + "%"));
            p.Add(new MySqlParameter("@reason", "%" + Reason + "%"));
            p.Add(new MySqlParameter("@surname", "%" + CallerSurname + "%"));
            p.Add(new MySqlParameter("@name", "%" + CallerName + "%"));
            p.Add(new MySqlParameter("@patriarchic", "%" + CallerPatriarchic + "%"));
            p.Add(new MySqlParameter("@tel", CallerTel));
            p.Add(new MySqlParameter("@dispatcher", DispatcherID));
            p.Add(new MySqlParameter("@callout_min", CalloutIDRange.Min));
            p.Add(new MySqlParameter("@callout_max", CalloutIDRange.Max));
            p.Add(new MySqlParameter("@call_min", CallIDRange.Min));
            p.Add(new MySqlParameter("@call_max", CallIDRange.Max));
            p.Add(new MySqlParameter("@time_from", TimeRange.Min));
            p.Add(new MySqlParameter("@time_to", TimeRange.Max));

            return new Tuple<string, List<MySqlParameter>>(filter, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT `call`.*, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `call` INNER JOIN `dispatcher` ON `call`.dispatcher_id = `dispatcher`.dispatcher_id {filter.Item1} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", conn);
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }

    public class CalloutFilters : IFilters
    {
        public (DateTime? Min, DateTime? Max) CalloutTimeCreated;
        public (int? Min, int? Max) CalloutIDRange;
        public string? CalloutAddress;
        public string? CalloutReason;
        public string? CalloutComment;
        public bool? CalloutCanceled;

        public CalloutFilters() { }

        public Tuple<string, List<MySqlParameter>> GetSQLFilter()
        {
            List<string> filters = new List<string>();

            if (CalloutAddress != null)
                filters.Add("lower(`callout_address`) LIKE lower(@addy)");

            if (CalloutReason != null)
                filters.Add("lower(`callout_reason`) LIKE lower(@rs)");

            if (CalloutComment != null)
                filters.Add("lower(`callout_comment`) LIKE lower(@cm)");

            if (CalloutTimeCreated.Min.HasValue)
                filters.Add("`callout_time_created` >= @tc_min");

            if (CalloutTimeCreated.Max.HasValue)
                filters.Add("`callout_time_created` <= @tc_max");

            if (CalloutIDRange.Min.HasValue)
                filters.Add("`callout_id` >= @id_min");

            if (CalloutIDRange.Max.HasValue)
                filters.Add("`callout_id` <= @id_max");

            if (CalloutCanceled.HasValue)
                filters.Add("`callout_canceled` = @cc");

            string filter = "WHERE " + String.Join(" AND ", filters);
            if (filters.Count == 0)
                filter = "";

            List<MySqlParameter> p = new List<MySqlParameter>();

            p.Add(new MySqlParameter("@addy", "%" + CalloutAddress + "%"));
            p.Add(new MySqlParameter("@rs", "%" + CalloutReason + "%"));
            p.Add(new MySqlParameter("@cm", "%" + CalloutComment + "%"));
            p.Add(new MySqlParameter("@tc_min", CalloutTimeCreated.Min));
            p.Add(new MySqlParameter("@tc_max", CalloutTimeCreated.Max));
            p.Add(new MySqlParameter("@id_min", CalloutIDRange.Min));
            p.Add(new MySqlParameter("@id_max", CalloutIDRange.Max));
            p.Add(new MySqlParameter("@cc", CalloutCanceled));

            return new Tuple<string, List<MySqlParameter>>(filter, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT `callout`.* from `callout` {filter.Item1} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", conn);
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }

    public class SubstationFilters : IFilters
    {
        public string? SubstationCode;
        public string? SubstationAddress;

        public SubstationFilters() { }

        public Tuple<string, List<MySqlParameter>> GetSQLFilter()
        {
            List<string> filters = new List<string>();

            if (SubstationAddress != null)
                filters.Add("lower(`substation`.substation_address) LIKE lower(@address)");

            if (SubstationCode != null)
                filters.Add("lower(`substation`.substation_code) LIKE lower(@code)");

            string filter = "WHERE " + String.Join(" AND ", filters);
            if (filters.Count == 0)
                filter = "";

            List<MySqlParameter> p = new List<MySqlParameter>();

            p.Add(new MySqlParameter("@code", "%" + SubstationCode + "%"));
            p.Add(new MySqlParameter("@address", "%" + SubstationAddress + "%"));

            return new Tuple<string, List<MySqlParameter>>(filter, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT * FROM `substation` {filter.Item1} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", conn);
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }

    public class BrigadeFilters : IFilters
    {
        public string? BrigadeCode;
        public string? BrigadeType;
        public int? BrigadeSubstationId;

        public BrigadeFilters() { }

        public Tuple<string, List<MySqlParameter>> GetSQLFilter()
        {
            List<string> filters = new List<string>();

            if (BrigadeType != null)
                filters.Add("lower(b.`brigade_type`) = lower(@br_type)");

            if (BrigadeCode != null)
                filters.Add("lower(b.`brigade_code`) LIKE lower(@code)");

            if (BrigadeSubstationId != null)
                filters.Add("b.`substation_id` = @substation_id");

            string filter = "WHERE " + String.Join(" AND ", filters);
            if (filters.Count == 0)
                filter = "";

            List<MySqlParameter> p = new List<MySqlParameter>();

            p.Add(new MySqlParameter("@code", "%" + BrigadeCode + "%"));
            p.Add(new MySqlParameter("@br_type", BrigadeType));
            p.Add(new MySqlParameter("@substation_id", BrigadeSubstationId));

            return new Tuple<string, List<MySqlParameter>>(filter, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT b.*, s.`substation_address`, s.`substation_code`, COUNT(worker_id) as brigade_worker_count FROM `brigade` b LEFT JOIN `worker` w ON w.`brigade_id` = b.`brigade_id` inner join `substation` s on s.`substation_id` = b.`substation_id` {filter.Item1} GROUP BY b.`brigade_id` LIMIT {Program.SQL_MAX_ROWS_FILTERED}", conn);
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }

    public class PatientFilters : IFilters
    {
        public string? PatientSurname;
        public string? PatientName;
        public string? PatientPatriarchic;
        public string? PatientTel;
        public string? PatientSex;
        public (DateTime? Min, DateTime? Max) PatientDOB;

        public PatientFilters() { }

        public Tuple<string, List<MySqlParameter>> GetSQLFilter()
        {
            List<string> filters = new List<string>();

            if (PatientSurname != null)
                filters.Add("lower(`patient_name`) LIKE lower(@name)");

            if (PatientName != null)
                filters.Add("lower(`patient_surname`) LIKE lower(@surname)");

            if (PatientPatriarchic != null)
                filters.Add("lower(`patient_patriarchic`) LIKE lower(@patriarchic)");

            if (PatientTel != null)
                filters.Add("`patient_tel` = @tel");

            if (PatientSex != null)
                filters.Add("lower(`patient_sex`) = lower(@sex)");

            if (PatientDOB.Min != null)
                filters.Add("`patient_dob` >= @dob_min");

            if (PatientDOB.Max != null)
                filters.Add("`patient_dob` <= @dob_max");

            string filter = "WHERE " + String.Join(" AND ", filters);
            if (filters.Count == 0)
                filter = "";

            List<MySqlParameter> p = new List<MySqlParameter>();

            p.Add(new MySqlParameter("@name", "%" + PatientName + "%"));
            p.Add(new MySqlParameter("@surname", "%" + PatientSurname + "%"));
            p.Add(new MySqlParameter("@patriarchic", "%" + PatientPatriarchic + "%"));
            p.Add(new MySqlParameter("@tel", PatientTel));
            p.Add(new MySqlParameter("@dob_min", PatientDOB.Min));
            p.Add(new MySqlParameter("@dob_max", PatientDOB.Max));
            p.Add(new MySqlParameter("@sex", PatientSex));

            return new Tuple<string, List<MySqlParameter>>(filter, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` {filter.Item1} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", conn);
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }

    public class WorkerFilters : IFilters
    {
        public int? WorkerID;
        public string? WorkerName;
        public string? WorkerSurname;
        public string? WorkerPatriarchic;
        public string? WorkerSex;
        public string? WorkerTel;
        public string? WorkerRole;
        public string? WorkerKPP;
        public string? WorkerLicense;
        public int? BrigadeID;
        public (DateTime? Min, DateTime? Max) WorkerDOB;

        public Tuple<string, List<MySqlParameter>> GetSQLFilter()
        {
            List<string> f = new();

            if (WorkerID != null) f.Add("worker_id = @id");
            if (WorkerName != null) f.Add("lower(worker_name) LIKE lower(@name)");
            if (WorkerSurname != null) f.Add("lower(worker_surname) LIKE lower(@surname)");
            if (WorkerPatriarchic != null) f.Add("lower(worker_patriarchic) LIKE lower(@pat)");
            if (WorkerSex != null) f.Add("lower(worker_sex) = lower(@sex)");
            if (WorkerTel != null) f.Add("worker_tel = @tel");
            if (WorkerKPP != null) f.Add("lower(worker_kpp) LIKE lower(@kpp)");
            if (WorkerRole != null) f.Add("lower(worker_role) LIKE lower(@role)");
            if (WorkerLicense != null) f.Add("lower(worker_license) LIKE lower(@license)");
            if (BrigadeID != null) f.Add("brigade_id = @brigade");

            string where = f.Count > 0 ? "WHERE " + string.Join(" AND ", f) : "";

            List<MySqlParameter> p = new()
            {
                new("@id", WorkerID),
                new("@name", "%" + WorkerName + "%"),
                new("@surname", "%" + WorkerSurname + "%"),
                new("@pat", "%" + WorkerPatriarchic + "%"),
                new("@role", "%" + WorkerRole + "%"),
                new("@kpp", "%" + WorkerKPP + "%"),
                new("@license", "%" + WorkerLicense + "%"),
                new("@sex", WorkerSex),
                new("@tel", WorkerTel),
                new("@role", "%" + WorkerRole + "%"),
                new("@brigade", BrigadeID)
            };

            return new(where, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var f = GetSQLFilter();
            var cmd = new MySqlCommand(
                $"SELECT worker.*, CONCAT(worker_surname,' ',worker_name,' ',worker_patriarchic) AS worker_fullname, brigade_code FROM worker INNER JOIN `brigade` ON `brigade`.brigade_id = `worker`.brigade_id {f.Item1} LIMIT {Program.SQL_MAX_ROWS_FILTERED}",
                conn);
            cmd.Parameters.AddRange(f.Item2.ToArray());
            return cmd;
        }
    }

    public class HospitalFilters : IFilters
    {
        public string? HospitalName;
        public string? HospitalAddress;
        public string? HospitalSpecialization;

        public HospitalFilters() { }

        public Tuple<string, List<MySqlParameter>> GetSQLFilter()
        {
            List<string> filters = new List<string>();
            if (HospitalName != null)
                filters.Add("lower(`hospital_name`) LIKE lower(@nm)");

            if (HospitalAddress != null)
                filters.Add("lower(`hospital_address`) LIKE lower(@ad)");

            if (HospitalSpecialization != null)
                filters.Add("lower(`hospital_specialization`) LIKE lower(@sp)");

            string filter = "WHERE " + String.Join(" AND ", filters);
            if (filters.Count == 0)
                filter = "";

            List<MySqlParameter> p = new List<MySqlParameter>();

            p.Add(new MySqlParameter("@nm", "%" + HospitalName + "%"));
            p.Add(new MySqlParameter("@ad", "%" + HospitalAddress + "%"));
            p.Add(new MySqlParameter("@sp", "%" + HospitalSpecialization + "%"));

            return new Tuple<string, List<MySqlParameter>>(filter, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT `hospital`.* FROM `hospital` {filter.Item1} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", conn);
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }

    public class DispatcherFilters : IFilters
    {
        public string? DispatcherSurname;
        public string? DispatcherName;
        public string? DispatcherPatriarchic;
        public string? DispatcherTel;

        public DispatcherFilters() { }

        public Tuple<string, List<MySqlParameter>> GetSQLFilter()
        {
            List<string> filters = new List<string>();

            if (DispatcherSurname != null)
                filters.Add("lower(`dispatcher_name`) LIKE lower(@name)");

            if (DispatcherName != null)
                filters.Add("lower(`dispatcher_surname`) LIKE lower(@surname)");

            if (DispatcherPatriarchic != null)
                filters.Add("lower(`dispatcher_patriarchic`) LIKE lower(@patriarchic)");

            if (DispatcherTel != null)
                filters.Add("`dispatcher_tel` = @tel");

            string filter = "WHERE " + String.Join(" AND ", filters);
            if (filters.Count == 0)
                filter = "";

            List<MySqlParameter> p = new List<MySqlParameter>();

            p.Add(new MySqlParameter("@name", "%" + DispatcherName + "%"));
            p.Add(new MySqlParameter("@surname", "%" + DispatcherSurname + "%"));
            p.Add(new MySqlParameter("@patriarchic", "%" + DispatcherPatriarchic + "%"));
            p.Add(new MySqlParameter("@tel", DispatcherTel));

            return new Tuple<string, List<MySqlParameter>>(filter, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT `dispatcher`.*, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `dispatcher` {filter.Item1} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", conn);
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }

    public class DepartureFilters : IFilters
    {
        public (DateTime? Min, DateTime? Max) DepartureTimeDeparted;
        public (DateTime? Min, DateTime? Max) DepartureTimeArrived;
        public (float? Min, float? Max) DepartureMileageKM;
        public string? DepartureFromAddress;
        public string? DepartureToAddress;
        public (int? Min, int? Max) CalloutID;

        public Tuple<string, List<MySqlParameter>> GetSQLFilter()
        {
            List<string> filters = new List<string>();

            if (DepartureTimeDeparted.Min != null)
                filters.Add("`departure_time_departed` >= @dtd_min");

            if (DepartureTimeDeparted.Min != null)
                filters.Add("`departure_time_departed` <= @dtd_max");

            if (DepartureTimeArrived.Min != null)
                filters.Add("`departure_time_arrived` >= @dta_min");

            if (DepartureTimeArrived.Max != null)
                filters.Add("`departure_time_arrived` <= @dta_max");

            if (DepartureMileageKM.Min != null)
                filters.Add("`departure_mileage_km` >= @dm_min");

            if (DepartureMileageKM.Max != null)
                filters.Add("`departure_mileage_km` <= @dm_max");

            if (DepartureFromAddress != null)
                filters.Add("lower(`departure_from_address`) LIKE lower(@from_addy)");
            
            if (DepartureToAddress != null)
                filters.Add("lower(`departure_to_address`) LIKE lower(@to_addy)");

            if (CalloutID.Min.HasValue)
                filters.Add("`callout_id` >= @callout_min");

            if (CalloutID.Max.HasValue)
                filters.Add("`callout_id` <= @callout_max");

            string filter = "WHERE " + String.Join(" AND ", filters);
            if (filters.Count == 0)
                filter = "";

            List<MySqlParameter> p = new List<MySqlParameter>();

            p.Add(new MySqlParameter("@dtd_min", DepartureTimeDeparted.Min));
            p.Add(new MySqlParameter("@dtd_max", DepartureTimeDeparted.Max));
            p.Add(new MySqlParameter("@dta_min", DepartureTimeArrived.Min));
            p.Add(new MySqlParameter("@dta_max", DepartureTimeArrived.Max));
            p.Add(new MySqlParameter("@dm_min", DepartureMileageKM.Min));
            p.Add(new MySqlParameter("@dm_max", DepartureMileageKM.Max));
            p.Add(new MySqlParameter("@from_addy", "%" + DepartureFromAddress + "%"));
            p.Add(new MySqlParameter("@to_addy", "%" + DepartureToAddress + "%"));
            p.Add(new MySqlParameter("@callout_min", CalloutID.Min));
            p.Add(new MySqlParameter("@callout_max", CalloutID.Max));

            return new Tuple<string, List<MySqlParameter>>(filter, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT `departure`.* FROM `departure` {filter.Item1} ORDER BY `departure_time_departed` DESC LIMIT {Program.SQL_MAX_ROWS_FILTERED}", conn);
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }
}
