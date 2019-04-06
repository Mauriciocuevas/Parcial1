using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public enum friendType
    {
      Conocido,
      Compañero,
      Estudio,
      Colegadetrabajo,
      Amigo,
      Amigodelainfancia,
      Pariente,
    }
    public enum StatusType
    {
     Activo,
     Desactivo,
    }
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Birthdate { get; set; }
        [Required]
        public int FriendType { get; set; }
        public int StatusType { get; set; }
    }
}