using System.Data.SQLite;

namespace ExcuteSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source=:memory:";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();

                    //Create 2 tables
                    SQLiteCommand cmd = new SQLiteCommand("create table hehe1 (hehe int)", conn);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "create table hehe2 (hehe int)";
                    cmd.ExecuteNonQuery();

                    //Create 2 tables    
                    var start = System.DateTime.Now;
                    for (int i = 0; i < 200000; ++i)
                    {
                        cmd.CommandText = string.Format("insert into hehe1 values({0})",i);
                        cmd.ExecuteNonQuery();
                    }
                    System.Console.WriteLine("Insertion with raw sql cost: " + (System.DateTime.Now - start).TotalSeconds + "s");

                    start = System.DateTime.Now;
                    using (SQLiteTransaction mytransaction = conn.BeginTransaction())
                    {
                        using (SQLiteCommand mycommand = new SQLiteCommand(conn))
                        {
                            SQLiteParameter myparam = new SQLiteParameter();
                            int n;

                            mycommand.CommandText = "INSERT INTO hehe2 (hehe) VALUES(?)";
                            mycommand.Parameters.Add(myparam);

                            for (n = 0; n < 200000; n++)
                            {
                                myparam.Value = n;
                                mycommand.ExecuteNonQuery();
                            }
                        }
                        mytransaction.Commit();
                    }
                    System.Console.WriteLine("Insertion with transaction & prepare cost: " + (System.DateTime.Now - start).TotalSeconds + "s");
                }
            }
            catch (SQLiteException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
