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
            p.Add(new MySqlParameter("@time_from", TimeRange.Min));
            p.Add(new MySqlParameter("@time_to", TimeRange.Max));

            return new Tuple<string, List<MySqlParameter>>(filter, p);
        }

        public MySqlCommand GetSQLCommand(MySqlConnection conn)
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT `call`.*, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `call` INNER JOIN `dispatcher` ON `call`.dispatcher_id = `dispatcher`.dispatcher_id {filter.Item1}", conn);
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
            var cmd = new MySqlCommand($"SELECT * FROM `substation` {filter.Item1}", conn);
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
            var cmd = new MySqlCommand($"SELECT b.*, s.`substation_address`, s.`substation_code`, COUNT(worker_id) as brigade_worker_count FROM `brigade` b LEFT JOIN `worker` w ON w.`brigade_id` = b.`brigade_id` inner join `substation` s on s.`substation_id` = b.`substation_id` {filter.Item1} GROUP BY b.`brigade_id`", conn);
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }
}
