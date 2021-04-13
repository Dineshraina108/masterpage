using System;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;
namespace Masterpagedesign
{
    class package
    {
        public OracleConnection con = new OracleConnection("Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false");
        public OracleDataAdapter oda;
        public string query;
        public void dbcon()
        {
            con.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false";
            con.Open();
        }
        public void dbclose()
        {
            con.Close();
        }
        #region user register  table
        public DataTable sel()
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM GARUREG";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable priv(string uname)
        {
            DataTable dt = new DataTable();
            query = "SELECT PRIVILAGE FROM GARUREG WHERE USERNAME= '" + uname + "'";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable uservalid(string uname, string pass)
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM GARUREG WHERE USERNAME = '" + uname + "' AND PASS = '" + pass + "'";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable usid(string uname)
        {
            DataTable dt = new DataTable();
            query = "SELECT USID FROM GARUREG WHERE UNAME= '" + uname + "'";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable Getname(string uname)
        {
            DataTable dt = new DataTable();
            query = "SELECT UNAME FROM GARUREG WHERE USERNAME= '" + uname + "'";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public void userinsert(int uid, string name, string usname, string pass, string repass, string dob, string gen, string mobno, string email, string address, string role)
        {
            int result = 0;
            query = "INSERT INTO GARUREG VALUES(" + uid + ",'" + name + "','" + usname + "','" + pass + "','" + repass + "',to_date('" + dob + "','dd/mm/yyyy'),'" + gen + "','" + mobno + "','" + email + "','" + address + "','" + role + "')";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //MessageBox.Show(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("User added");
            else
                Console.WriteLine("User not added");

        }
        public void userupdate(int uid, string name, string usname, string pass, string repass, string dob, string gen, string mobno, string email, string address, string role)
        {
            int result = 0;
            query = "UPDATE GARUREG SET UNAME ='" + name + "',USERNAME ='" + usname + "',PASS ='" + pass + "',REPASS ='" + repass + "',DOB = to_date('" + dob + "','dd/mm/yyyy'),GENDER ='" + gen + "',MOBILENO ='" + mobno + "',EMAILID ='" + email + "',ADDRESS ='" + address + "',PRIVILAGE ='" + role + "' WHERE USID =" + uid + "";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("VALUES UPDATED");
            else
                Console.WriteLine("VALUES NOT UPDATED");
        }
        public void passupdate(string usname, string pass, string repass)
        {
            int result = 0;
            query = "UPDATE GARUREG SET PASS ='" + pass + "',REPASS ='" + repass + "'WHERE USERNAME ='" + usname + "'";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("VALUES UPDATED");
            else
                Console.WriteLine("VALUES NOT UPDATED");
        }
        #endregion
        public void RunOracleTransaction()
        {
            con.Open();
            OracleCommand command = con.CreateCommand();
            OracleTransaction transaction;
            transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
            command.Transaction = transaction;
            try
            {
                transaction.Commit();
                Console.WriteLine("VALUE UPDATED IN DATABASE");
            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine(e.ToString());
                Console.WriteLine("VALUE TEMPORARYLY UPDATED IN DATABASE");
            }

        }
        #region profile table
        public void profileinsert(int uid, int carid,string dept, string proc,string posi)
        {
            DateTime date = DateTime.Now.Date;
            string dat =Convert.ToString (date.ToString("dd/MM/yyyy"));
            int result = 0;         
            query = "INSERT INTO TASKUSERDATA VALUES("+uid +","+ carid + ",'"+dept+"','" + proc +"','"+posi+"','"+ dat + "')";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //MessageBox.Show(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("User profile added");
            else
                Console.WriteLine("User profile not added");
        }
        public DataTable profilesel(int uid)
        {
            DataTable dt = new DataTable();
            query = "SELECT DEPT,PROCESS,POSITION FROM TASKUSERDATA WHERE USID="+ uid +"";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable profiledata(int uid)
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM profiledata where usid="+ uid +"";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        #endregion
        #region feedback table
        public void feedbackins(int id, string name,string pos,string proc,string dept, string desc)
        {
            int result = 0;
            DateTime date = DateTime.Now.Date;
            string dat = Convert.ToString(date.ToString("dd/MM/yyyy"));
            query = "INSERT INTO FEEDBACKDETAILS VALUES("+ id +",'" + dat + "','"+name+"','"+ pos +"','"+ proc +"','" +dept+"','"+desc+"')";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //MessageBox.Show(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("feedback added");
            else
                Console.WriteLine("feedback not added");
        }
        public DataTable Getfid()
        {
            DataTable dt = new DataTable();
            query = "SELECT MAX(FID) FROM FEEDBACKDETAILS";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        #endregion
        #region Project table
        public DataTable GetTable()
        {
            DataTable tabl = new DataTable();
            DataRow dr;
            tabl.Columns.Add("lid", typeof(Int32));
            tabl.Columns.Add("lan", typeof(string));
            dr = tabl.NewRow();
            dr["lid"] = 1;
            dr["lan"] = "C#";
            tabl.Rows.Add(dr);
            dr = tabl.NewRow();
            dr["lid"] = 2;
            dr["lan"] = "VB";
            tabl.Rows.Add(dr);
            return tabl;
        }
        public DataTable proid()
        {
            DataTable dt = new DataTable();
            query = "SELECT MAX(PRJID) FROM TASKPROJECT";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public void Projectins(int id, string name, string lan, string stdt, string endt)
        {
            int result = 0;
            query = "INSERT INTO TASKPROJECT VALUES(" + id + ",'" + name + "','" + lan + "','" + stdt + "','" + endt + "')";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //MessageBox.Show(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("project added");
            else
                Console.WriteLine("project not added");
        }
        public DataTable projectsel()
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM TASKPROJECT";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable Getpro()
        {
            DataTable dt = new DataTable();
            query = "SELECT PRJID,PRJNAME FROM TASKPROJECT";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public void projectupdate(int pid, string name, string lan, string enddt)
        {
            int result = 0;
            query = "UPDATE TASKPROJECT SET PRJNAME ='" + name + "',PRJLAN ='" + lan + "',ENDATE ='" + enddt + "' WHERE PRJID =" + pid + "";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("VALUES UPDATED");
            else
                Console.WriteLine("VALUES NOT UPDATED");
        }
        public DataTable projectmod(int pid)
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM TASKPROJECT WHERE PRJID =" + pid + "";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        #endregion
        #region TASK table
        public DataTable Gettask(int tid)
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM TMSTASK WHERE TASKID="+ tid+"";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable Gettask()
        {
            DataTable dt = new DataTable();
            query = "SELECT TASKID,TASKNAME FROM TMSTASK";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable Gettaskdet()
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM TMSTASK";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        } //taskupdate
        public DataTable taskid()
        {
            DataTable dt = new DataTable();
            query = "SELECT MAX(TASKID) FROM TMSTASK";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public void Taskins(int id, string name, string dur)
        {
            int result = 0;
            query = "INSERT INTO TMSTASK VALUES(" + id + ",'" + name + "','" + dur + "')";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //MessageBox.Show(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("Task added");
            else
                Console.WriteLine("Task not added");
        }
        public void taskupdate(int id, string name, string dur)
        {
            int result = 0;
            query = "UPDATE TMSTASK SET TASKNAME ='" + name + "',DURATION ='" + dur + "' WHERE TASKID =" + id + "";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("VALUES UPDATED");
            else
                Console.WriteLine("VALUES NOT UPDATED");
        }
        #endregion
        #region TKUSERACT table
        public void dailyactins(int id, string name, string wdate,string pro,string lan,string scre,string action)
        {
            int result = 0;
            query = "INSERT INTO TKUSERACT VALUES(" + id + ",TKUSERACT_SNO.nextval,'" + name + "','" + wdate + "','" + pro + "','" + lan + "','" + scre + "','" + action + "')";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //MessageBox.Show(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("Your action added");
            else
                Console.WriteLine("Your action not added");
        }
        public DataTable dailyactsel(string user)
        {
            DataTable dt = new DataTable();
            DateTime date = DateTime.Now.Date;
            string dat = Convert.ToString(date.ToString("dd/MM/yyyy"));
            query = "SELECT * FROM TKUSERACT WHERE WRDATE='" + dat + "' AND USERNAME=" + user + "";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable dailyact(string pro)
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM TKUSERACT WHERE PRNAME='" + pro + "' ORDER BY SNO";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        #endregion
    }
}
