using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DiceWars.DAL.Clash;

namespace DiceWars.DAL
{
    public class ClashManager : DbManager
    {
        public void Create(Clash c)
        {
            // create a new connection to the database
            using var connection = Connection;
            try
            {
                // use sql to insert aka create
                var sql = $"INSERT INTO Cl_Clash (cl_player1_19257, cl_player2_19257, cl_date_19257, cl_outcome_19257) " +
                    $"VALUES (@player1, @player2, @cl_date, @outcome)";
                using var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("player1", c.cl_player1_19257.pl_id_19257);
                command.Parameters.AddWithValue("player2", c.cl_player2_19257.pl_id_19257);
                command.Parameters.AddWithValue("cl_date", c.cl_date_19257.Ticks);
                command.Parameters.AddWithValue("outcome", c.cl_outcome_19257);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        public List<Clash> GetAll()
        {
            // getting all the games
            // the below first line is so we can conect cl_player1 and cl_player2 to pl_id
            var allPlayers = new PlayerManager().GetAll().ToDictionary(t => t.pl_id_19257, t => t);

            var connection = Connection;
            var result = new List<Clash>();
            try
            {
                var sql = $@"SELECT [cl_id_19257]
							  ,[cl_player1_19257]
							  ,[cl_player2_19257]
							  ,[cl_date_19257]
							  ,[cl_outcome_19257]
						  FROM [Cl_Clash]";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var clash = new Clash
                    {
                        cl_id_19257 = Convert.ToInt32(reader.GetValue(0)),
                        cl_player1_19257 = new PlayerManager().GetById(Convert.ToInt32(reader.GetValue(1))),
                        cl_player2_19257 = new PlayerManager().GetById(Convert.ToInt32(reader.GetValue(2))),
                        cl_date_19257 = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        cl_outcome_19257 = (outcome)Convert.ToInt32(reader.GetValue(4))
                    };
                    result.Add(clash);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }

            return result;
        }

        public Clash GetById(int id)
        {
            // the get by id function
            using var connection = Connection;
            try
            {
                var sql = $"SELECT cl_id_19257, cl_player1_19257, cl_player2_19257, cl_date_19257, cl_outcome_19257 FROM Cl_Clash WHERE cl_id_19257 = {id}";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Clash
                    {
                        cl_id_19257 = Convert.ToInt32(reader.GetValue(0)),
                        cl_player1_19257 = Convert.ToInt32(reader.GetValue(1)),
                        cl_player2_19257 = Convert.ToInt32(reader.GetValue(2)),
                        cl_date_19257 = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        cl_outcome_19257 = (outcome)Convert.ToInt32(reader.GetValue(4))
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return null;
        }

    }
}
