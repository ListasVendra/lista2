//INTERFACE 1 - Restauravel

public enum StatusRestauracao {
    SemRestauracao,
	Restaurando,
	NecessitandoDocumentacao
}

public interface Restaurável {
	StatusRestauracao getStatusRestauracao();
	void setStatusRestauracao(StatusRestauracao s);
	boolean validarRestauracao();
}

public class Restauração {
	private Restaurável restaurável;
    //Outros atributos e propriedades
}

public class Obra : Restaurável {
	private StatusRestauracao statusRestauracao;

    //Outros atributos e propriedades

	public StatusRestauracao getStatusRestauracao() {
		return statusRestauracao;
	}
	public void setStatusRestauracao(StatusRestauracao s) {
        statusRestauracao = s;
    }
	public boolean validarRestauracao() {
		//Aqui faria a validação da restauração
	}
}

//INTERFACE 2 - Pagavel

public class Souvinier : Pagável {
    //Outros atributos e propriedades
	public float calculoDesconto() {
		//Realiza o calculo do desconto pela classe Souvenir
	}
	public boolean validaPagamento() {
		//Valida o pagamento pela classe Souvenir
	}
	public float getValor() {
        //Retorna o preço do Souvenir
	}
}

public interface Pagável {
	float calculoDesconto();
	boolean validaPagamento();
	float getValor();
}

public class PagamentoVisita : Pagável {
    //Outros atributos e propriedades
	public float calculoDesconto() {
		//Realiza o calculo do desconto pela classe PagamentoVisita
	}
	public boolean validaPagamento() {
		//Valida o pagamento pela classe PagamentoVisita
	}
	public float getValor() {
        //Retorna o preço do PagamentoVisita
	}
}

