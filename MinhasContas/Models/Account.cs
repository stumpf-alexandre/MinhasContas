namespace minhas_contas.Models
{
    public class Account
    {
        public Account(){}

        public Account(int id, string dataLeitura, long numLeitura, long KwGasto, double valorPagar, string dataPagto, long mediaConsumo){
            this.id=id;
            this.dataLeitura=dataLeitura;
            this.numLeitura=numLeitura;
            this.KwGasto=KwGasto;
            this.valorPagar=valorPagar;
            this.dataPagto=dataPagto;
            this.mediaConsumo=mediaConsumo;
        }
        public int id{get; set;}

        public string dataLeitura{get; set;}

        public long numLeitura{get; set;}

        public long KwGasto{get; set;}
            
        public double valorPagar{get; set;}

        public string dataPagto{get; set;}

        public long mediaConsumo{get; set;}
    }
}