 public static bool validateUserByBind(string username, string password)
        {
            bool result = true;
            var credentials = new NetworkCredential(username, password);
            //var serverId = new LdapDirectoryIdentifier(connection.SessionOptions.HostName);

            var serverId = new LdapDirectoryIdentifier("xx.x.xxx.xxx");




            var conn = new LdapConnection(serverId, credentials);
            try
            {
                conn.Bind();
            }
            catch (Exception ex)
            {
                result = false;
            }

            conn.Dispose();

            return result;
        }