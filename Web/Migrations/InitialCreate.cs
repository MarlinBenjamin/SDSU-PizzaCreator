using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.wwwroot.Migrations
{
    public partial class InitialCreate : Migrations
    {
        protected override void Up (MBuilder mbuilder)
        {
            Mbuider.CreateTable(
                name: "Contact", columns: table => new
                {
                    ContactId = table.column<int>(Nullable: false),
                    Name = table.column<String>(Nullable: false),
                    Address = table.column<String>(Nullable: false),
                    City = table.colmn<String>(Nullable: false),
                    State = table.column<String>(Nullalbe: false),
                    Zip = table.column<String>(Nullalbe: false),
                    Email = table.column<String>(Nullable: false),
                    OwnerID = table.column<int>(Nullable: false)
                },
                Constriants :  table =>
                {
                    table.Primarykey("Contact_ID", x => x.ContactId);

                });
        }
        protected override Down (MBuider mbuilder)
        {
            mbuider.Droptable(name: "Topping");
        }
    }
}
