using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Runtime.Serialization;

namespace FitnessWeb
{
    public class FitnessClassOpportunities : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
    //[Serializable()]
    //public class FitnessClassOpportunity : ISerializable
    //{
    //    public string id = "";

    //    public string description = "";

    //    public string location = "";

    //    public int spaces = 0;

    //    // 0 - monday, 1 - tuesday, etc.
    //    public string day_of_week = "";

    //    public int time_hour = 0; //time_min = 0;

    //    public int duration_minutes = 0;

    //    public bool multiweek_class = false;

    //    public DateTime start_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

    //    public int number_of_sessions = 0;

    //    public FitnessClassOpportunity()
    //    {
    //    }

    //    public override string ToString()
    //    {
    //        return id + ":  " + location + ":  " + description + ": " + day_of_week;
    //    }

    //    // Prepares a full multiline string representing a class
    //    public string Present()
    //    {
    //        return string.Format("Class\nId: {0}\r\nDescription: {1}\r\n"
    //            + "Location: {2}\r\nSpaces: {3}\r\nDay of Week: {4}\r\nTime: {5}\r\n"
    //            + "Duration: {6} min.\r\nMultiple weeks: {7}\r\n"
    //            + "Start: {8}\r\nNumber of sessions: {9}",
    //            new object[] {
    //                id, description, location, spaces, day_of_week,
    //                time_hour, duration_minutes, multiweek_class,
    //                start_date.ToShortDateString(), number_of_sessions
    //                });
    //    } //time_min,
    //    //gets information from saved file.
    //    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    //    {
    //        info.AddValue("id", id);
    //        info.AddValue("description", description);
    //        info.AddValue("location", location);
    //        info.AddValue("spaces", spaces);
    //        info.AddValue("day_of_week", day_of_week);
    //        info.AddValue("time_hour", time_hour);
    //        //info.AddValue("time_min", time_min);
    //        info.AddValue("duration_minutes", duration_minutes);
    //        info.AddValue("multiweek_class", multiweek_class);
    //        info.AddValue("start_date", start_date);
    //        info.AddValue("number_of_sessions", number_of_sessions);
    //    }

    //    public FitnessClassOpportunity(SerializationInfo info,
    //    StreamingContext context)
    //    {
    //        id = info.GetString("id");
    //        description = info.GetString("description");
    //        location = info.GetString("location");
    //        spaces = info.GetInt32("spaces");
    //        day_of_week = info.GetString("day_of_week");
    //        time_hour = info.GetInt32("time_hour");
    //        //time_min = info.GetInt32("time_min");
    //        duration_minutes = info.GetInt32("duration_minutes");
    //        multiweek_class = info.GetBoolean("multiweek_class");
    //        start_date = info.GetDateTime("start_date");
    //        number_of_sessions = info.GetInt32("number_of_sessions");

    //    }

    //}
