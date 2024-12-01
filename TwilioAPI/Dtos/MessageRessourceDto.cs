using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwilioAPI.Dtos
{
    public class MessageRessourceDto
    {
        [MaxLength(200)]
        [Required]
        public string Message { get; set; } = null!;

        [Required]
        public string To { get; set; } = null!;
    }
}