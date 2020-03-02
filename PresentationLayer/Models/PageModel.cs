using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PresentationLayer.Models
{
    public abstract class PageViewModel
    {
        public int Id { get; set; }
    }
    public abstract class PageEditModel
    {
        public int Id { get; set; }
    }
}
