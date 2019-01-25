using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CS.Impl._03_Linq
{
    public class Linq
    {
        public IEnumerable<string> FindStringsWhichStartsAndEndsWithSpecificCharacter(string startCharacter, string endCharacter, IEnumerable<string> strings)
        {
            return strings.Where(str => str.EndsWith(endCharacter) && str.StartsWith(startCharacter));
        }

        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)
        {
            return numbers.Where(ints => ints > limit);
        }

        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)
        {
            int count = 0;
            return numbers.OrderByDescending(x => x).Take(limit);
        }

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
            IDictionary<string, int> dict = new Dictionary<string, int>();
            return files.GroupBy(l => l.Substring(l.Length -3, 3).ToLower())
                    .Select(g => new
                        {
                            Name = g.Key,
                            Count = g.Select(l => l).Distinct().Count()
                        })
                    .ToDictionary(res => res.Name,
                        res => res.Count);
        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
            throw new NotImplementedException();
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
    }

    public class Purchase
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ClientId { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
