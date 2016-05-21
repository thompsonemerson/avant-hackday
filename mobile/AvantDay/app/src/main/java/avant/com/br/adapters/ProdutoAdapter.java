package avant.com.br.adapters;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;
import java.util.List;

import avant.com.br.models.Produto;
import avant.com.br.activities.R;

public class ProdutoAdapter extends BaseAdapter {

	private LayoutInflater mInflater;
	private List<Produto> mProdutos;

	public ProdutoAdapter(Context context, List<Produto> produtos) {
		mInflater = LayoutInflater.from(context);
		mProdutos = produtos;
	}

	@Override
	public int getCount() {
		return mProdutos.size();
	}

	@Override
	public Produto getItem(int position) {
		return mProdutos.get(position);
	}

	@Override
	public long getItemId(int position) {
		return position;
	}

	private void getViewCustomObra(View view, Produto obra){
		
		TextView descricao = (TextView) view.findViewById(R.id.descricao);
		descricao.setText(obra.getNome());
	}	
	
	@Override
	public View getView(int position, View view, ViewGroup parent) {
		Produto produto = mProdutos.get(position);
		if (produto == null) {
			return null;
		}
		
		view = mInflater.inflate(R.layout.item_lista_promocoes, null);
		
		getViewCustomObra(view, produto);
		
		return view;
	}
}
