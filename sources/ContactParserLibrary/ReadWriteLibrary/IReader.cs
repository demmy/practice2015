using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactParserLibrary.ContactsLibrary;

namespace ContactParserLibrary.ReadWriteLibrary
{
    public interface IReader
    {
        void InitContactsStorage(out ContactsStorage storage);
    }
}
