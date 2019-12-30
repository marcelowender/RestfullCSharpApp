using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroUsuarios.Models
{

    /*
     Banco de Dados

        admin
        usuario.123456
         */
    [Table("USUARIO")]
    public class Usuario
    {

        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }


    }
}