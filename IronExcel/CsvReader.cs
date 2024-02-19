using System.Globalization;

namespace IronExcel
{
    internal class CsvReader : IDisposable
    {
        private StreamReader reader;
        private CultureInfo invariantCulture;

        public CsvReader(StreamReader reader, CultureInfo invariantCulture)
        {
            this.reader = reader;
            this.invariantCulture = invariantCulture;
        }

        internal object GetRecords<T>()
        {
            throw new NotImplementedException();
        }
    }
}