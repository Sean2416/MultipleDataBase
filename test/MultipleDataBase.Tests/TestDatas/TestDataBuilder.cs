using MultipleDataBase.EntityFrameworkCore;

namespace MultipleDataBase.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MultipleDataBaseDbContext _context;

        public TestDataBuilder(MultipleDataBaseDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}