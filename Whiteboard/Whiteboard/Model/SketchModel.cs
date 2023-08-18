using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard.Model
{
    public class SketchModel
    {
        public SketchModel(Image image, DateTime dateTime, string name)
        {
            Project = image;
            DateCreated = dateTime;
            ProjectName = name;
        }

        public Image Project { get; set; } 
        public DateTime DateCreated { get; set; }
        public string ProjectName { get; set; }
    }
}
