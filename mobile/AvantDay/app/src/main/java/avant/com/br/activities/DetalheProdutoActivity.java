package avant.com.br.activities;

import android.app.Activity;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.TextView;
import org.w3c.dom.Text;
import avant.com.br.activities.R;

public class DetalheProdutoActivity extends BaseActivity {

    private TextView mDescricao;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detalhe_produto);

        String uri = getIntent().getStringExtra("fotoUri");
    }

    private void initialize(){

        mDescricao = (TextView) findViewById(R.id.descricao);

    }
}
