using Microsoft.EntityFrameworkCore.Migrations;

namespace hopTropOnlineShop.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cloth",
                columns: table => new 
                {
                    IDCloth = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(nullable: true),
                    TypeOfCloth = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Currency = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cloth", x => x.IDCloth);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    IDCustomer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.IDCustomer);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    IdDelivery = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDOrder = table.Column<int>(nullable: false),
                    DeliveryDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.IdDelivery);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    IDOrder = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    Sum = table.Column<double>(nullable: false),
                    IdBasket = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.IDOrder);
                });

            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    IDBasket = table.Column<int>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    IDCustomer = table.Column<int>(nullable: false),
                    CustomerIDCustomer = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.IDBasket);
                    table.ForeignKey(
                        name: "FK_Basket_Customer_CustomerIDCustomer",
                        column: x => x.CustomerIDCustomer,
                        principalTable: "Customer",
                        principalColumn: "IDCustomer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WishListCloth",
                columns: table => new
                {
                    IDCloth = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDBasket = table.Column<int>(nullable: false),
                    BasketIDBasket = table.Column<int>(nullable: true),
                    ClothIDCloth = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishListCloth", x => x.IDCloth);
                    table.ForeignKey(
                        name: "FK_WishListCloth_Basket_BasketIDBasket",
                        column: x => x.BasketIDBasket,
                        principalTable: "Basket",
                        principalColumn: "IDBasket",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WishListCloth_Cloth_ClothIDCloth",
                        column: x => x.ClothIDCloth,
                        principalTable: "Cloth",
                        principalColumn: "IDCloth",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basket_CustomerIDCustomer",
                table: "Basket",
                column: "CustomerIDCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_WishListCloth_BasketIDBasket",
                table: "WishListCloth",
                column: "BasketIDBasket");

            migrationBuilder.CreateIndex(
                name: "IX_WishListCloth_ClothIDCloth",
                table: "WishListCloth",
                column: "ClothIDCloth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "WishListCloth");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "Cloth");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
