﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" + "VALUES('Caderno espiral','Caderno espiral 100 fôlhas', 7.45,50,'caderno1.jpg',1)");
            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" + "VALUES('Estojo escolar','Estojo escolar cinza', 5.65,70,'estojo1.jpg',1)");
            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" + "VALUES('Caderno hotwheels','Caderno espiral 200 fôlhas', 18.45,60,'caderno2.jpg',1)");
            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" + "VALUES('Mochila escolar','mochila escolar preta  p notebook', 205.65,6,'bolsa1.jpg',1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
