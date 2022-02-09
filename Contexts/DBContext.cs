using PetaPoco;
using PetaPoco.Core;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace API_Template.Contexts {
    public class DBContext : Database {

        public DBContext(DbConnection connection, IMapper defaultMapper = null)
            : base(connection, defaultMapper) {
        }

        public DBContext(string connectionString, string providerName, IMapper defaultMapper = null)
            : base(connectionString, providerName, defaultMapper) {
        }

        public DBContext(string connectionString, DbProviderFactory factory, IMapper defaultMapper = null)
            : base(connectionString, factory, defaultMapper) {
        }

        public DBContext(string connectionString, IProvider provider, IMapper defaultMapper = null)
            : base(connectionString, provider, defaultMapper) {
        }

        public DBContext(IDatabaseBuildConfiguration configuration)
            : base(configuration) {
        }
    }
}
