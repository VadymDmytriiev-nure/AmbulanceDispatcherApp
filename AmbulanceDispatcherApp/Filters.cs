using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AmbulanceDispatcherApp
{
    interface IFilters
    {
        public Tuple<string, List<MySqlParameter>> GetSQLFilter();
        public MySqlCommand GetSQLQuery();
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
                filters.Add("`call`.call_address LIKE @address");

            if (Channel != null)
                filters.Add("`call`.call_channel LIKE @channel");

            if (Reason != null)
                filters.Add("`call`.call_reason LIKE @reason");

            if (CallerSurname != null)
                filters.Add("`call`.call_caller_surname LIKE @surname");

            if (CallerName != null)
                filters.Add("`call`.call_caller_name LIKE @name");

            if (CallerPatriarchic != null)
                filters.Add("`call`.call_caller_patriarchic LIKE @patriarchic");

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

        public MySqlCommand GetSQLQuery()
        {
            var filter = GetSQLFilter();
            var cmd = new MySqlCommand($"SELECT `call`.*, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `call` INNER JOIN `dispatcher` ON `call`.dispatcher_id = `dispatcher`.dispatcher_id {filter.Item1}");
            cmd.Parameters.AddRange(filter.Item2.ToArray());

            return cmd;
        }
    }
}
