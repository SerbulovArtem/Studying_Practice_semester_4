using Dormitory.Domain.Convertors.Txt;
using Dormitory.Domain.Repositories.Abstract;
using System.Collections.Generic;
using System.IO;

namespace Dormitory.Domain.Repositories.Concreate.Txt
{
    internal class TxtBaseRepository<T> : IRepository<T>
    {
        private List<T> _items;
        private string _sourceFileName;
        private ITxtConvertor<T> _convertor;

        public TxtBaseRepository(string sourceFileName, ITxtConvertor<T> convertor)
        {
            _items = new List<T>();
            _sourceFileName = sourceFileName;
            _convertor = convertor;
        }

        public void Add(T entity) 
        {
            _items.Add(entity);
            WriteItemsToFile();
        }

        public void DeleteAt(int index)
        {
            _items.RemoveAt(index);
            WriteItemsToFile();
        }

        public void EditAt(int index, T entity) 
        { 
            _items.RemoveAt(index);
            _items.Insert(index, entity);
            WriteItemsToFile();
        }

        public List<T> GetAll()
        {
            ReadItemsFromFile();
            return _items;
        }

        private void ReadItemsFromFile()
        {
            _items.Clear();

            using (var sr = new StreamReader(_sourceFileName, true))
            {
                var lines = sr.ReadToEnd().Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines) 
                {
                    _items.Add(_convertor.Convert(line));
                }
            }
        }

        private void WriteItemsToFile()
        {
            using (var sw = new StreamWriter(_sourceFileName, false))
            {
                foreach(var item in _items)
                {
                    sw.WriteLine(_convertor.Convert(item));
                }
            }
        }
    }
}
