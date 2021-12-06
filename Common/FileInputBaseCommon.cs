using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_CORE.Common
{
    public class FileInputBaseCommon
    {
        public IFormFile image { get; set; }
        public IFormFile video { get; set; }
        public IFormFile attatch { get; set; }
    }
}
