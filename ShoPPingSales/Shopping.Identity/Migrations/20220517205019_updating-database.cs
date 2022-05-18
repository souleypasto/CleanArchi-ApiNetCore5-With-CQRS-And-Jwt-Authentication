using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Identity.Migrations
{
    public partial class updatingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "08236c41-68e1-45be-bea7-66015512f242");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "edd4ec46-ce17-481b-9d46-e5e6025ff38a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6a13614-465b-42b6-87be-30ca7ad1f574", "AQAAAAEAACcQAAAAECb1IhbTzZ3OaswT7X974pjOf0VWw+DurP/ru8BCiHa/+Pdyc1ZDyHJPkkqgICwxBw==", "658544c5-1605-4f52-8a26-a1e943ce05d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1aa5b78-4e0b-458e-be2c-d1d65e968986", "AQAAAAEAACcQAAAAEHK/izfhRZouBnP+h8pWwL6swaMtUXQPA2T37zvoc/XpHug2VEOqGo+FHMg0QVfrIQ==", "3b4e4889-b002-410b-b33a-1daf2224128d" });
        }
    }
}
