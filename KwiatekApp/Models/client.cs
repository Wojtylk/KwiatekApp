using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KwiatekApp.Models
{
    public class client
    {

        
        public int kli_id { get; set; }
        public string kli_imie { get; set; }
        public string kli_nazwisko { get; set; }
        public string kli_NIP { get; set; }
        public string kli_REGON { get; set; }
        public int adr_id_kli { get; set; }
        

        /*
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public byte[] Photo { get; set; }
        */
        private bool connection_open;
        private MySqlConnection connection;


        public client(int kli_id)
        {
            Get_Connection();
            //    m_Person = new CPersonMaster();
            //  List<CPersonMaster> PersonList = new List<CPersonMaster>();
            //PersonList = CComs_PM.Fetch_PersonMaster(connection, 4, arg_id);

            //if (PersonList.Count==0)
            //  return "";

            //m_Person = PersonList[0];

            //DB_Connect.CloseTheConnection(connection);
            try
            {


                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =
           // string.Format("select concat (person_id, ') ', surname, ', ', forename) Person, Address1, Address2, photo, length(photo) from PersonMaster where Person_ID = '{0}'",
             //                                 PersonID);

                string.Format("Select * FROM klient where kli_id =" + kli_id);
                MySqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    reader.Read();

                    if (!reader.IsDBNull(1))
                        kli_imie = reader.GetString(1);
                    else
                        kli_imie = null;

                    if (!reader.IsDBNull(2))
                        kli_nazwisko = reader.GetString(2);
                    else
                        kli_nazwisko = null;
/*
                    if (!reader.IsDBNull(2))
                        Address2 = reader.GetString(2);
                    else
                        Address2 = null;
*/
                    reader.Close();

                }
                catch (MySqlException e)
                {

                    //MessageBox.Show(MessageString, "SQL Read Error");
                    reader.Close();

                }
            }
            catch (MySqlException e)
            {


            }




            connection.Close();


        

    }


        public void addClient(string s, string s2)
        {

            Get_Connection();
            try
            {


                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =

                string.Format("INSERT INTO klient (kli_imie, kli_nazwisko, kli_NIP, kli_REGON, adr_id_kli) VALUES: (" + s + "," + s2 + ", 123, 123, 1);");
                MySqlDataReader reader = cmd.ExecuteReader();
            }

            catch (MySqlException e)
            {


            }
        }

        private void Get_Connection()
        {
            connection_open = false;

            connection = new MySqlConnection();
            //connection = DB_Connect.Make_Connnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            //            if (db_manage_connnection.DB_Connect.OpenTheConnection(connection))
            if (Open_Local_Connection())
            {
                connection_open = true;
            }
            else
            {
                //					MessageBox::Show("No database connection connection made...\n Exiting now", "Database Connection Error");
                //					 Application::Exit();
            }

        }

        private bool Open_Local_Connection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
    }


/*
 * 
 * kurewstwo z addclient
 * 
 * 
 * 
@using (Html.BeginForm())
{
    <text>

        First name: <input type="text" name="FirstName" />
        Last name: <input type="text" name="LastName" />
        <input type="submit" value="Submit" />
    </text>
}

@using (Html.BeginForm())
{
    @Html.AntiForgeryToken()

    <div class="form-horizontal">
        <h4>PersonalDetail</h4>
        <hr />
        @Html.ValidationSummary(true, "", new { @class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class =
"control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.FirstName, new { htmlAttributes = new
{ @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.FirstName, "", new {
@class = "text-danger" })
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(model => model.LastName, htmlAttributes: new { @class =
"control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.LastName, new { htmlAttributes = new
{ @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.LastName, "", new { @class
= "text-danger" })
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(model => model.Age, htmlAttributes: new { @class =
"control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.Age, new { htmlAttributes = new {
@class = "form-control" } })
                @Html.ValidationMessageFor(model => model.Age, "", new { @class =
"text-danger" })
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(model => model.Active, htmlAttributes: new { @class =
"control-label col-md-2" })
            <div class="col-md-10">
                <div class="checkbox">
                    @Html.EditorFor(model => model.Active)
                    @Html.ValidationMessageFor(model => model.Active, "", new {
                    @class = "text-danger" })
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>
    @section Scripts {
        @Scripts.Render("~/bundles/jqueryval")
    }
*/