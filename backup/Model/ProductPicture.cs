using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    class ProductPicture
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public byte[] ImageData { get; set; }

        public void CreateImage(string fileName)
        {
            var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            var br = new BinaryReader(fs);
            using (br)
            {
                using(fs)
                {
                    ImageData = br.ReadBytes((int)fs.Length);
                }
            }
  
        }


    }
}
