using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LEAP.App.Model
{
    [PetaPoco.TableName("Test.TestTable")]
    [PetaPoco.PrimaryKey("Id")]
    public partial class TestTable
    {
        public int Id { get; set; }
        public string Desc { get; set; }
    }
}