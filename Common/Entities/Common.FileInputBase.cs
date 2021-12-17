using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_CORE.Common.Entities
{
    public class FileInputBaseCommon
    {
        public IFormFile Image { get; set; }
        public IFormFile Video { get; set; }
        public IFormFile Attatch { get; set; }
    }
}
