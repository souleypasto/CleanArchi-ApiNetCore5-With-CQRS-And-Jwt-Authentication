using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Identity.Migrations
{
    public partial class changingusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "00bd39cb-bf7e-478e-9803-9ce9547532a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "3a15e3ce-2e3b-40c8-a1fa-7182b4954314");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cac43a6e-f7bb-4450-baaf-1add431ccbbf", "9bc6ece8-8762-40f5-8710-2bfc3f1151c6", "Gestionaire", "GESTIONAIRE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d57868f5-9f9a-49d7-89ec-05ceeba95e98", "AQAAAAEAACcQAAAAED3+OPo5jZFeTOrQiLdJ7URX6f9MPaA10Szhahy7fuptFr0TVrME43BHgiHn1RwQIg==", "bf449535-a55e-4ce6-b791-c03c0a06e3c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e5213cb-b1f7-47fa-a151-e985318f2b14", "AQAAAAEAACcQAAAAEBexKsLhbpsUsjsUCVCUyj+WYap+c1D64saFQD5IYoLZDJr0//SyAOtaFg2u87fO3w==", "8a0206ca-5c45-4d09-a5f5-81d5e4b28e86" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4450-baaf-1add431ccbbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "873a059c-d61f-41a2-bb29-5571bd35344b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "79b98ccd-44fc-4f19-8df9-b88e24a52c63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acd6e2dd-ef89-465d-994f-a0ece273aa3d", "AQAAAAEAACcQAAAAEPM5Q5UR4szkP0DtvZzd4IHFWIHuOzMTuje3nj2pf6afAii292BQTMZO+Z1/DFYMKw==", "87882945-8858-4539-8565-1e8447b1b3a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5bfd976-304f-49ca-ad6a-38894e2ea12e", "AQAAAAEAACcQAAAAEM4D7YJMdUBsrMJLUWRxd/BZa6FvdYsiUkuQSpd/7EwSHsu1pnCcgTyW9zqwj2CVPg==", "4e195adf-920d-4b15-8881-a2e00fc7efba" });
        }
    }
}
