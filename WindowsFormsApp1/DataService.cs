using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SomeData
    {
        
    }

    public interface IDataService
    {
        Task<SomeData> GetSomeData();
    }

    public class MockDataService: IDataService
    {
        private SomeData _mockData;
        public void SetDataToReturn(SomeData data)
        {
            _mockData = data;
        }
        public async Task<SomeData> GetSomeData()
        {
            return await Task.FromResult(_mockData);
        }
    }

    public class DataService : IDataService
    {
        public async Task<SomeData> GetSomeData()
        {
            return await Task.FromResult(new SomeData());
        }
    }
}