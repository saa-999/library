using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace library.Migrations
{
    /// <inheritdoc />
    public partial class AddBookUx_Ratings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Books",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "ImagePath", "Rating", "Title" },
                values: new object[] { "M. Castillo", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_1/600/900", 4.2999999999999998, "Pages of Time #1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ImagePath", "Rating", "Signed", "Title" },
                values: new object[] { "R. Bennett", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_2/600/900", 3.3999999999999999, true, "Ink & Ideas #2" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "ImagePath", "Rating", "Signed", "Title" },
                values: new object[,]
                {
                    { 3, "L. Nakamura", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_3/600/900", 3.8999999999999999, false, "Beyond The Stacks #3" },
                    { 4, "H. Ibrahim", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_4/600/900", 3.3999999999999999, false, "Patterns of Code #4" },
                    { 5, "C. Martin", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_5/600/900", 4.0, true, "Sands of Memory #5" },
                    { 6, "S. Patel", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_6/600/900", 3.2999999999999998, false, "Hidden Chapters #6" },
                    { 7, "N. Alvarez", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_7/600/900", 4.4000000000000004, true, "The Archivist #7" },
                    { 8, "Y. Chen", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_8/600/900", 3.8999999999999999, true, "Refactor Your Mind #8" },
                    { 9, "D. Howard", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_9/600/900", 3.2000000000000002, false, "Designing Harmony #9" },
                    { 10, "A. Reynolds", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_10/600/900", 4.0, false, "The Silent Library #10" },
                    { 11, "M. Castillo", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_11/600/900", 4.7999999999999998, true, "Pages of Time #11" },
                    { 12, "R. Bennett", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_12/600/900", 3.5, false, "Ink & Ideas #12" },
                    { 13, "L. Nakamura", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_13/600/900", 3.2999999999999998, true, "Beyond The Stacks #13" },
                    { 14, "H. Ibrahim", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_14/600/900", 4.9000000000000004, false, "Patterns of Code #14" },
                    { 15, "C. Martin", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_15/600/900", 4.7999999999999998, true, "Sands of Memory #15" },
                    { 16, "S. Patel", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_16/600/900", 4.5, true, "Hidden Chapters #16" },
                    { 17, "N. Alvarez", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_17/600/900", 4.2000000000000002, true, "The Archivist #17" },
                    { 18, "Y. Chen", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_18/600/900", 4.5, true, "Refactor Your Mind #18" },
                    { 19, "D. Howard", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_19/600/900", 3.8999999999999999, false, "Designing Harmony #19" },
                    { 20, "A. Reynolds", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_20/600/900", 3.2999999999999998, true, "The Silent Library #20" },
                    { 21, "M. Castillo", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_21/600/900", 3.2000000000000002, false, "Pages of Time #21" },
                    { 22, "R. Bennett", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_22/600/900", 4.4000000000000004, false, "Ink & Ideas #22" },
                    { 23, "L. Nakamura", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_23/600/900", 4.0999999999999996, false, "Beyond The Stacks #23" },
                    { 24, "H. Ibrahim", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_24/600/900", 3.6000000000000001, false, "Patterns of Code #24" },
                    { 25, "C. Martin", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_25/600/900", 5.0, true, "Sands of Memory #25" },
                    { 26, "S. Patel", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_26/600/900", 4.2999999999999998, false, "Hidden Chapters #26" },
                    { 27, "N. Alvarez", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_27/600/900", 3.6000000000000001, false, "The Archivist #27" },
                    { 28, "Y. Chen", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_28/600/900", 4.2999999999999998, true, "Refactor Your Mind #28" },
                    { 29, "D. Howard", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_29/600/900", 4.5, true, "Designing Harmony #29" },
                    { 30, "A. Reynolds", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_30/600/900", 4.2000000000000002, false, "The Silent Library #30" },
                    { 31, "M. Castillo", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_31/600/900", 3.5, true, "Pages of Time #31" },
                    { 32, "R. Bennett", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_32/600/900", 3.8999999999999999, true, "Ink & Ideas #32" },
                    { 33, "L. Nakamura", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_33/600/900", 3.3999999999999999, false, "Beyond The Stacks #33" },
                    { 34, "H. Ibrahim", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_34/600/900", 4.5999999999999996, true, "Patterns of Code #34" },
                    { 35, "C. Martin", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_35/600/900", 3.5, true, "Sands of Memory #35" },
                    { 36, "S. Patel", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_36/600/900", 3.5, true, "Hidden Chapters #36" },
                    { 37, "N. Alvarez", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_37/600/900", 3.7000000000000002, true, "The Archivist #37" },
                    { 38, "Y. Chen", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_38/600/900", 3.6000000000000001, true, "Refactor Your Mind #38" },
                    { 39, "D. Howard", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_39/600/900", 4.9000000000000004, true, "Designing Harmony #39" },
                    { 40, "A. Reynolds", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_40/600/900", 4.7999999999999998, false, "The Silent Library #40" },
                    { 41, "M. Castillo", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_41/600/900", 4.4000000000000004, true, "Pages of Time #41" },
                    { 42, "R. Bennett", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_42/600/900", 3.7999999999999998, false, "Ink & Ideas #42" },
                    { 43, "L. Nakamura", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_43/600/900", 3.5, false, "Beyond The Stacks #43" },
                    { 44, "H. Ibrahim", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_44/600/900", 4.0999999999999996, true, "Patterns of Code #44" },
                    { 45, "C. Martin", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_45/600/900", 3.2000000000000002, true, "Sands of Memory #45" },
                    { 46, "S. Patel", "Short chapters, practical insights, and zero fluff—made for busy readers.", "https://picsum.photos/seed/library_book_46/600/900", 4.5, true, "Hidden Chapters #46" },
                    { 47, "N. Alvarez", "A field note from the front desk: what to keep, what to search, and when.", "https://picsum.photos/seed/library_book_47/600/900", 4.5999999999999996, true, "The Archivist #47" },
                    { 48, "Y. Chen", "Tiny patterns that scale from a single page to a whole system.", "https://picsum.photos/seed/library_book_48/600/900", 4.0, false, "Refactor Your Mind #48" },
                    { 49, "D. Howard", "Calm explanations with examples you can try the same day.", "https://picsum.photos/seed/library_book_49/600/900", 4.7000000000000002, false, "Designing Harmony #49" },
                    { 50, "A. Reynolds", "A concise, human-friendly guide that turns complex ideas into daily tools.", "https://picsum.photos/seed/library_book_50/600/900", 3.3999999999999999, false, "The Silent Library #50" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "ImagePath", "Title" },
                values: new object[] { "Robert C. Martin", null, null, "Clean Code" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ImagePath", "Signed", "Title" },
                values: new object[] { "Andrew Hunt", null, null, false, "The Pragmatic Programmer" });
        }
    }
}
