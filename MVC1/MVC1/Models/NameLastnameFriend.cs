using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public enum FrienType
    {
    Conocido,
    Compañero,
    Estudio,
    Colegadetrabajo,
    Amigo,
    Amigodelainfancia,
    Pariente
        
    }
    public enum StatusType
    {
     Activo,
     Desactivo,
    }

    public class NameLastnameFriend
    {
        [Key]
        public int FriendId { get; set; }
        [Key]
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Birthdate { get; set; }
        [Required]
        public int FriendType { get; set; }
        public int StatusType { get; set; }
    }
}