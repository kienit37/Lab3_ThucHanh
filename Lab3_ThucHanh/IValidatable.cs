using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    public interface IValidatable
    {
        bool IsValid(out string message);
    }
    public interface IPrintable
    {
        string ToDisplayText();
    }
    
}
