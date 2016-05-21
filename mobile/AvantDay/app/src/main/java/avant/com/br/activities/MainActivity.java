package avant.com.br.activities;

import java.util.ArrayList;
import java.util.List;

import android.app.Activity;
import android.content.BroadcastReceiver;
import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.AdapterView.OnItemClickListener;

import avant.com.br.adapters.ProdutoAdapter;
import avant.com.br.models.Foto;
import avant.com.br.models.Produto;
import avant.com.br.activities.R;

public class MainActivity extends BaseActivity implements OnItemClickListener {

	private BroadcastReceiver receiver;
	private ListView mPromocaoListView;
	private List<Produto> mProdutos;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_lista_promocoes);

		initialize();
	}

	@Override
	protected void onResume() {
		super.onResume();

		setListeners();

		loadData();
	};

	@Override
	protected void onPause() {
		super.onPause();


	}

	private void initialize() {

		mPromocaoListView = (ListView) findViewById(R.id.lista_de_promocoes);
		mPromocaoListView.setOnItemClickListener(this);


	}

	private void setListeners() {


	}

	private List<Produto> getFakes(){

		List<Produto> lista = new ArrayList<Produto>();

		Produto p = new Produto();
		p.setNome("Produto 1");
		Foto f = new Foto();
		f.setUri("https://10.2.1:3000");
		p.setFoto(f);
		lista.add(p);

		Produto p2 = new Produto();
		Foto f2 = new Foto();
		f2.setUri("https://10.2.1:3000");
		p2.setFoto(f2);
		p2.setNome("Produto 2");
		lista.add(p2);

		Produto p3 = new Produto();
		Foto f3 = new Foto();
		f3.setUri("https://10.2.1:3000");
		p3.setFoto(f3);
		p3.setNome("Produto 3");
		lista.add(p3);

		Produto p4 = new Produto();
		Foto f4 = new Foto();
		f4.setUri("https://10.2.1:3000");
		p4.setFoto(f4);
		p4.setNome("Produto 4");
		lista.add(p4);

		Produto p5 = new Produto();
		Foto f5 = new Foto();
		f5.setUri("https://10.2.1:3000");
		p5.setFoto(f5);
		p5.setNome("Produto 5");
		lista.add(p5);

		return lista;
	}

	private void loadData(){

		mProdutos = getFakes();


		runOnUiThread(new Runnable() {
			@Override
			public void run() {
				mPromocaoListView.setAdapter(new ProdutoAdapter(MainActivity.this, mProdutos));
			}
		});
	}

	private void startActivityDetalheProduto(Produto produto) {

		Intent intent = new Intent(this, DetalheProdutoActivity.class);
		intent.putExtra("fotoUri", produto.getFoto().getUri());
		startActivity(intent);
	}

	@Override
	public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

		Produto produto = (Produto) parent.getItemAtPosition(position);

		startActivityDetalheProduto(produto);
	}
}
