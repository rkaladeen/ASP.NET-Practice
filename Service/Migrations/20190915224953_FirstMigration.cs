using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsCategorys",
                columns: table => new
                {
                    Category_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCategorys", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 10, nullable: false),
                    LastName = table.Column<string>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    News_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AuthorUser_Id = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 25, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 100, nullable: false),
                    Category_Id = table.Column<int>(nullable: false),
                    Text = table.Column<string>(maxLength: 1000, nullable: false),
                    Img_Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.News_Id);
                    table.ForeignKey(
                        name: "FK_News_Users_AuthorUser_Id",
                        column: x => x.AuthorUser_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_News_NewsCategorys_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "NewsCategorys",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Store_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zip = table.Column<int>(maxLength: 5, nullable: false),
                    GeneralManagerUser_Id = table.Column<int>(nullable: false),
                    SupervisorUser_Id = table.Column<int>(nullable: false),
                    OTPUser_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Store_Id);
                    table.ForeignKey(
                        name: "FK_Stores_Users_GeneralManagerUser_Id",
                        column: x => x.GeneralManagerUser_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stores_Users_OTPUser_Id",
                        column: x => x.OTPUser_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stores_Users_SupervisorUser_Id",
                        column: x => x.SupervisorUser_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Like_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    User_Id = table.Column<int>(nullable: false),
                    News_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Like_Id);
                    table.ForeignKey(
                        name: "FK_Likes_News_News_Id",
                        column: x => x.News_Id,
                        principalTable: "News",
                        principalColumn: "News_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Ticket_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Reported_ByUser_Id = table.Column<int>(nullable: false),
                    Assigned_ToUser_Id = table.Column<int>(nullable: true),
                    LocationStore_Id = table.Column<int>(nullable: false),
                    Priority = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    Resolution = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Ticket_Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_Assigned_ToUser_Id",
                        column: x => x.Assigned_ToUser_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Stores_LocationStore_Id",
                        column: x => x.LocationStore_Id,
                        principalTable: "Stores",
                        principalColumn: "Store_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_Reported_ByUser_Id",
                        column: x => x.Reported_ByUser_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_News_Id",
                table: "Likes",
                column: "News_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_User_Id",
                table: "Likes",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorUser_Id",
                table: "News",
                column: "AuthorUser_Id");

            migrationBuilder.CreateIndex(
                name: "IX_News_Category_Id",
                table: "News",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_GeneralManagerUser_Id",
                table: "Stores",
                column: "GeneralManagerUser_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_OTPUser_Id",
                table: "Stores",
                column: "OTPUser_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_SupervisorUser_Id",
                table: "Stores",
                column: "SupervisorUser_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Assigned_ToUser_Id",
                table: "Tickets",
                column: "Assigned_ToUser_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_LocationStore_Id",
                table: "Tickets",
                column: "LocationStore_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Reported_ByUser_Id",
                table: "Tickets",
                column: "Reported_ByUser_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "NewsCategorys");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
