package avant.com.br.models;
/**
 * Created by dyego on 21/05/2016.
 */
public class Produto {

    private String nome;
    private String preco;
    private String descricao;

    public Foto getFoto() {
        return foto;
    }

    public void setFoto(Foto foto) {
        this.foto = foto;
    }

    private Foto foto;

    public String getNome() {
        return nome;
    }

    public String getPreco() {
        return preco;
    }

    public void setPreco(String preco) {
        this.preco = preco;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public void setNome(String nome) {
        this.nome = nome;

    }
}
