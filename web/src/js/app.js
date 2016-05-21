// Definindo o modulo de nosso App
angular.module('avantApp', [ 'ngRoute' ])

// Criando as Rotas
.config(['$routeProvider',
	function($routeProvider) {
		$routeProvider

		.when('/', {
			templateUrl: 'home.php',
			controller: 'HomeCtrl'
		})

		.when('/produto/:id', {
			templateUrl: 'produto.php',
			controller: 'ProdutoCtrl'
		})

		// Redirecionamento Default
		.otherwise({
			redirectTo: '/'
		});
	}
]);
