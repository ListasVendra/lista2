class Exposicao {
    TreeSet<Obra> obras;
    //Outros Atributos e Propriedades

    public Exposicao() {
        obras = new TreeSet<Obra>();
    }

    public Obra PrimeiraObra() {
        return obras.First();
    }

    public Obra UltimaObra() {
        return obras.Last();
    }
}

class Obra {
    //Atributos e Propriedades
}