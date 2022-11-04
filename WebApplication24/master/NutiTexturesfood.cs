using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication24.Model
{
    public partial class NutiTexturesfood
    {
        public NutiTexturesfood()
        {
            NutiAssesments = new HashSet<NutiAssesment>();
        }

        public int TexturesfoodId { get; set; }
        public string Texturesfood { get; set; }

        public virtual ICollection<NutiAssesment> NutiAssesments { get; set; }
    }
}
