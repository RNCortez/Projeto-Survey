using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyWeb.Models
{
    public class Questionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string MsgFeedback { get; set; }
        public string Guid { get; set; }
        public int Usuariold { get; set; }

        public Questionario(int Id,string Nome,DateTime Inicio,DateTime Fim, string MsgFeedback,string Guid, int Usuaiold)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Inicio = Inicio;
            this.Fim = Fim;
            this.MsgFeedback = MsgFeedback;
            this.Guid = Guid;
            this.Usuariold = Usuariold;
        }




    }
}