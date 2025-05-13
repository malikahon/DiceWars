using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiceWars.DAL
{
    public partial class PlayerManager : DbManager
    {
        public void Create(Player p)
        {
            // create function for player
            using var connection = Connection;
            try
            {
                var sql = $"INSERT INTO Pl_Player (pl_name_19257, pl_is_pvp_enabled_19257, pl_last_game_date_19257, pl_score_19257)" +
                    $" VALUES (@name, @is_pvp_enabled, @last_game_date, @score)";
                using var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("name", p.pl_name_19257);
                command.Parameters.AddWithValue("is_pvp_enabled", Convert.ToInt32(p.pl_is_pvp_enabled_19257));
                command.Parameters.AddWithValue("last_game_date", p.pl_last_game_date_19257.Ticks);
                command.Parameters.AddWithValue("score", p.pl_score_19257);
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

        public void Update(Player p)
        {
            // updating player function
            using var connection = Connection;
            try
            {
                var sql = $"UPDATE Pl_Player SET pl_name_19257 = @name " +
                    $", pl_is_pvp_enabled_19257 = @is_pvp_enabled, pl_last_game_date_19257 = @last_game_date, pl_score_19257 = @score" +
                    $" WHERE pl_id_19257 =@id";
                using var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("name", p.pl_name_19257);
                command.Parameters.AddWithValue("is_pvp_enabled", Convert.ToInt32(p.pl_is_pvp_enabled_19257));
                command.Parameters.AddWithValue("last_game_date", p.pl_last_game_date_19257.Ticks);
                command.Parameters.AddWithValue("score", p.pl_score_19257);
                command.Parameters.AddWithValue("id", p.pl_id_19257);
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

        public void Delete(int id)
        {
            // delete function for player 
            using var connection = Connection;
            try
            {
                connection.Open();
                // below code for validation - checks if there areclashes with player before deleting
                var clash_sql = $@"SELECT COUNT(*) FROM [Cl_Clash] WHERE [cl_player1_19257] = {id} OR [cl_player2_19257] = {id}";
                var sqlclash = new SQLiteCommand(clash_sql, connection);
                int clash_count = Convert.ToInt32(sqlclash.ExecuteScalar());
                if (clash_count > 0)
                {
                    throw new Exception("You can't delete a player with clash history.");
                }
                var sql = $"DELETE FROM Pl_Player WHERE pl_id_19257=@id";
                using var command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("id", id);
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

        public List<Player> GetAll()
        {
            // gets all players (for dgv)
            using var connection = Connection;
            var result = new List<Player>();
            try
            {
                var sql = @$"SELECT pl_id_19257 " +
                    ",pl_name_19257" +
                    ",pl_is_pvp_enabled_19257" +
                    ",pl_last_game_date_19257" +
                    ",pl_score_19257 FROM Pl_Player;";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var p = new Player
                    {
                        pl_id_19257 = Convert.ToInt32(reader.GetValue(0)),
                        pl_name_19257 = reader.GetValue(1).ToString(),
                        pl_is_pvp_enabled_19257 = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(2))),
                        pl_last_game_date_19257 = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        pl_score_19257 = Convert.ToInt32(reader.GetValue(4))
                    };
                    result.Add(p);
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


        public Player GetById(int id)
        {
            // gets Player by Id
            using var connection = Connection;
            try
            {
                var sql = $"SELECT pl_id_19257, pl_name_19257, pl_is_pvp_enabled_19257, pl_last_game_date_19257, pl_score_19257 FROM Pl_Player WHERE pl_id_19257 = {id}";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Player
                    {
                        pl_id_19257 = Convert.ToInt32(reader.GetValue(0)),
                        pl_name_19257 = Convert.ToString(reader.GetValue(1)),
                        pl_is_pvp_enabled_19257 = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(2))),
                        pl_last_game_date_19257 = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        pl_score_19257 = Convert.ToInt32(reader.GetValue(4))
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

        public List<Player> GetEnabled()
        {
            using var connection = Connection;
            var result = new List<Player>();
            try
            {
                var sql = @$"SELECT pl_id_19257 " +
                    ",pl_name_19257" +
                    ",pl_is_pvp_enabled_19257" +
                    ",pl_last_game_date_19257" +
                    ",pl_score_19257 FROM Pl_Player WHERE pl_is_pvp_enabled_19257 == true";

                using var command = new SQLiteCommand(sql, connection);
                connection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var p = new Player
                    {
                        pl_id_19257 = Convert.ToInt32(reader.GetValue(0)),
                        pl_name_19257 = Convert.ToString(reader.GetValue(1)),
                        pl_is_pvp_enabled_19257 = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(2))),
                        pl_last_game_date_19257 = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        pl_score_19257 = Convert.ToInt32(reader.GetValue(4))
                    };
                    result.Add(p);
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

            return result;
        }
    }
}
