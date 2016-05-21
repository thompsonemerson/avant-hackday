package avant.com.br.activities;

import android.app.ActionBar;
import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.Window;

public class BaseActivity extends FragmentActivity {


	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_ACTION_BAR);
	}

	@Override
	protected void onResume() {
		super.onResume();

		ActionBar actionBar =  getActionBar();
		actionBar.setSubtitle("Avant Day");

	}

}
