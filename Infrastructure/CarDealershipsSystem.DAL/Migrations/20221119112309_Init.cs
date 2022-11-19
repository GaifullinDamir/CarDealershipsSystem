using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealershipsSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.CreateTable(
                name: "BRANCH",
                columns: table => new
                {
                    IDBRANCH = table.Column<int>(name: "ID_BRANCH", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BRANCHNAME = table.Column<string>(name: "BRANCH_NAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    BRANCHADDRESS = table.Column<string>(name: "BRANCH_ADDRESS", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    HEADNAME = table.Column<string>(name: "HEAD_NAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    HEADSURNAME = table.Column<string>(name: "HEAD_SURNAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    HEADMIDDLENAME = table.Column<string>(name: "HEAD_MIDDLENAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    HEADPASSDATA = table.Column<long>(name: "HEAD_PASS_DATA", type: "bigint", nullable: false),
                    HEADPHONENUMBER = table.Column<string>(name: "HEAD_PHONE_NUMBER", type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BRANCH__261C45A4714DCBF7", x => x.IDBRANCH);
                });

            migrationBuilder.CreateTable(
                name: "BUYER",
                columns: table => new
                {
                    BUYERPASSDATA = table.Column<long>(name: "BUYER_PASS_DATA", type: "bigint", nullable: false),
                    BUYERSURNAME = table.Column<string>(name: "BUYER_SURNAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    BUYERNAME = table.Column<string>(name: "BUYER_NAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    BUYERMIDDLENAME = table.Column<string>(name: "BUYER_MIDDLENAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    BUYERPHONENUMBER = table.Column<string>(name: "BUYER_PHONE_NUMBER", type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BUYER__ABE081A1CB4B8249", x => x.BUYERPASSDATA);
                });

            migrationBuilder.CreateTable(
                name: "MANAGER",
                columns: table => new
                {
                    MNGRPASSDATA = table.Column<long>(name: "MNGR_PASS_DATA", type: "bigint", nullable: false),
                    IDBRANCH = table.Column<int>(name: "ID_BRANCH", type: "int", nullable: false),
                    MNGRSURNAME = table.Column<string>(name: "MNGR_SURNAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    MNGRNAME = table.Column<string>(name: "MNGR_NAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    MNGRMIDDLENAME = table.Column<string>(name: "MNGR_MIDDLENAME", type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    MNGRPHONENUMBER = table.Column<string>(name: "MNGR_PHONE_NUMBER", type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    MNGRSALARY = table.Column<decimal>(name: "MNGR_SALARY", type: "money", nullable: false),
                    MNGRPAYDATE = table.Column<DateTime>(name: "MNGR_PAY_DATE", type: "date", nullable: false),
                    MNGRPRIZE = table.Column<decimal>(name: "MNGR_PRIZE", type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MANAGER__91EE6294FA89A267", x => x.MNGRPASSDATA);
                    table.ForeignKey(
                        name: "FK__MANAGER__ID_BRAN__36B12243",
                        column: x => x.IDBRANCH,
                        principalTable: "BRANCH",
                        principalColumn: "ID_BRANCH");
                });

            migrationBuilder.CreateTable(
                name: "CAR_ORDER",
                columns: table => new
                {
                    IDORDER = table.Column<int>(name: "ID_ORDER", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MNGRPASSDATA = table.Column<long>(name: "MNGR_PASS_DATA", type: "bigint", nullable: false),
                    BUYERPASSDATA = table.Column<long>(name: "BUYER_PASS_DATA", type: "bigint", nullable: false),
                    CONTRACTDATE = table.Column<DateTime>(name: "CONTRACT_DATE", type: "date", nullable: false),
                    ORDERAMOUNT = table.Column<decimal>(name: "ORDER_AMOUNT", type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CAR_ORDE__D23A85655E8E6594", x => x.IDORDER);
                    table.ForeignKey(
                        name: "FK__CAR_ORDER__BUYER__412EB0B6",
                        column: x => x.BUYERPASSDATA,
                        principalTable: "BUYER",
                        principalColumn: "BUYER_PASS_DATA");
                    table.ForeignKey(
                        name: "FK__CAR_ORDER__MNGR___403A8C7D",
                        column: x => x.MNGRPASSDATA,
                        principalTable: "MANAGER",
                        principalColumn: "MNGR_PASS_DATA");
                });

            migrationBuilder.CreateTable(
                name: "CAR",
                columns: table => new
                {
                    IDCAR = table.Column<int>(name: "ID_CAR", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDBRANCH = table.Column<int>(name: "ID_BRANCH", type: "int", nullable: false),
                    IDORDER = table.Column<int>(name: "ID_ORDER", type: "int", nullable: false),
                    BRAND = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    MODEL = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    BODYTYPE = table.Column<string>(name: "BODY_TYPE", type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    QUANTITY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CAR__2BF8FA1E804D4674", x => x.IDCAR);
                    table.ForeignKey(
                        name: "FK__CAR__ID_BRANCH__45F365D3",
                        column: x => x.IDBRANCH,
                        principalTable: "BRANCH",
                        principalColumn: "ID_BRANCH");
                    table.ForeignKey(
                        name: "FK__CAR__ID_ORDER__47DBAE45",
                        column: x => x.IDORDER,
                        principalTable: "CAR_ORDER",
                        principalColumn: "ID_ORDER");
                });

            migrationBuilder.CreateTable(
                name: "CAR_EXEMPLAR",
                columns: table => new
                {
                    VINNUMBER = table.Column<string>(name: "VIN_NUMBER", type: "varchar(17)", unicode: false, maxLength: 17, nullable: false),
                    IDCAR = table.Column<int>(name: "ID_CAR", type: "int", nullable: false),
                    HORSEPOWER = table.Column<int>(name: "HORSE_POWER", type: "int", nullable: false),
                    PRICE = table.Column<decimal>(type: "money", nullable: false),
                    COLOR = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    YEAROFASSEMBLY = table.Column<DateTime>(name: "YEAR_OF_ASSEMBLY", type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CAR_EXEM__B372A1A30439A375", x => x.VINNUMBER);
                    table.ForeignKey(
                        name: "FK__CAR_EXEMP__ID_CA__5070F446",
                        column: x => x.IDCAR,
                        principalTable: "CAR",
                        principalColumn: "ID_CAR");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__BRANCH__1DEAC273B604FA0C",
                table: "BRANCH",
                column: "HEAD_PASS_DATA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__BRANCH__5F3A4AF4994A30AB",
                table: "BRANCH",
                column: "HEAD_PHONE_NUMBER",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__BUYER__7FDA2467C6A8FD4A",
                table: "BUYER",
                column: "BUYER_PHONE_NUMBER",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CAR_ID_BRANCH",
                table: "CAR",
                column: "ID_BRANCH");

            migrationBuilder.CreateIndex(
                name: "IX_CAR_ID_ORDER",
                table: "CAR",
                column: "ID_ORDER");

            migrationBuilder.CreateIndex(
                name: "IX_CAR_EXEMPLAR_ID_CAR",
                table: "CAR_EXEMPLAR",
                column: "ID_CAR");

            migrationBuilder.CreateIndex(
                name: "IX_CAR_ORDER_BUYER_PASS_DATA",
                table: "CAR_ORDER",
                column: "BUYER_PASS_DATA");

            migrationBuilder.CreateIndex(
                name: "IX_CAR_ORDER_MNGR_PASS_DATA",
                table: "CAR_ORDER",
                column: "MNGR_PASS_DATA");

            migrationBuilder.CreateIndex(
                name: "IX_MANAGER_ID_BRANCH",
                table: "MANAGER",
                column: "ID_BRANCH");

            migrationBuilder.CreateIndex(
                name: "UQ__MANAGER__AB6758BFC77CA6E2",
                table: "MANAGER",
                column: "MNGR_PHONE_NUMBER",
                unique: true); */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropTable(
                name: "CAR_EXEMPLAR");

            migrationBuilder.DropTable(
                name: "CAR");

            migrationBuilder.DropTable(
                name: "CAR_ORDER");

            migrationBuilder.DropTable(
                name: "BUYER");

            migrationBuilder.DropTable(
                name: "MANAGER");

            migrationBuilder.DropTable(
                name: "BRANCH"); */
        }
    }
}
