using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using webapp.Data;
using webapp.Models;

namespace webapp.Tests;

public class DataAccessLayerTest
{
        [Fact]
        public async Task AddStudentAsync_StudentIsAdded()
        {
            using (var db = new RazorClubContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var recId = 10;

                var expectedStudent = new Student() 
                { 
                    ID = recId, 
                    LastName = "Tester",
                    FirstMidName = "Test",
                };

                // Act
                await db.AddStudentAsync(expectedStudent);

                // Assert
                var actualStudent = await db.FindAsync<Student>(recId);
                Assert.Equal(expectedStudent, actualStudent);
            }
        }
}