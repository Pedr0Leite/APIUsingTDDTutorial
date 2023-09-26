using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
            {

                new User{
                    Name = "Test User 1",
                    Email = "test.user1@example.com",
                    Address = new Address() {
                            Street = "123 Fake Street",
                            City = "FakeCity",
                            ZipCode = "3124"
                        }
                },
                new User{
                    Name = "Test User 2",
                    Email = "test.user2@example.com",
                    Address = new Address() {
                            Street = "123 Fake Street",
                            City = "FakeCity",
                            ZipCode = "3124"
                        }
                },
                new User{
                    Name = "Test User 3",
                    Email = "test.user3@example.com",
                    Address = new Address() {
                            Street = "123 Fake Street",
                            City = "FakeCity",
                            ZipCode = "3124"
                        }
                },
            };
    }
}
