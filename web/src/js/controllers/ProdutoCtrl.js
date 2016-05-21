// Incluindo o modulo
angular.module('avantApp')

// Controller Repeat
.controller('ProdutoCtrl', ['$scope', function ($scope) {

  $scope.produtos = [
    { id: 1, cat: 'perfumes', titulo: '212 Vip Rosé New York Pills Eau de Parfum - 20 ml', marca: 'Carolina Herrera', img: 'http://imagens.sephora.com.br/%7BC9FA09BA-B17B-4DAE-BC34-7BA73A5A57B8%7D_212-VIP-ROSE_130px.jpg', preco: 'R$ 199,00' },
    { id: 2, cat: 'perfumes', titulo: 'La Vie Est Belle Florale Feminino Eau - 50 ml', marca: 'Lancôme', img: 'http://imagens.sephora.com.br/%7B1C4F6F79-7AD3-415B-B009-C50D29D44B32%7D_3614270265877_EDTFlorale-01-Flacon-Retouche-B-20150319_130x130.jpg', preco: 'R$ 399,00' },
    { id: 3, cat: 'perfumes', titulo: 'Radiant Seduction in Black Masculino Eau - 100 ml', marca: 'Antonio Banderas', img: 'http://imagens.sephora.com.br/%7BCDE48C0F-6AC6-4D76-9E87-80F499AF4BDF%7D_65105171_130px.jpg', preco: 'R$ 109,00' },
    { id: 4, cat: 'perfumes', titulo: 'Fahrenheit Cologne Masculino Eau de Cologne', marca: 'Dior', img: 'http://imagens.sephora.com.br/%7B9DDBD93C-37FD-402C-B48F-C610D9AC98C5%7D_FHT-COLOGNE_130px.jpg', preco: 'R$ 379,00' },
    { id: 5, cat: 'maquiagens', titulo: 'Base Velvet Matte Skin Tint SPF 30', marca: 'NARS', img: 'http://imagens.sephora.com.br/%7B67C36FD9-126E-489B-93F4-8B990ECFF510%7D_velvetmatte_130x130.jpg', preco: 'R$ 239,00' },
    { id: 6, cat: 'maquiagens', titulo: 'Lápis Labial Velvetease Lip Pencil', marca: 'M·A·C', img: 'http://imagens.sephora.com.br/%7B4BBBE8A2-3D42-46DD-8E74-F90CB4746949%7D_773602317677_130x130.jpg', preco: 'R$ 89,00' },
    { id: 7, cat: 'maquiagens', titulo: 'Coleção Flamingo Batom M·A·C Lipstick', marca: 'M·A·C', img: 'http://imagens.sephora.com.br/%7BA8841E1E-8EB5-450D-A26C-80DCB88E3142%7D_773602394722_1_130x130.jpg', preco: 'R$ 73,00' },
    { id: 8, cat: 'maquiagens', titulo: 'Kit For 25 Years Our Lips Have Been - 1 unid.', marca: 'Smashbox', img: 'http://imagens.sephora.com.br/%7B60F09300-B81A-43D9-A53D-8FEF1B954247%7D_kitbelegendary_130px.jpg', preco: 'R$ 459,00' },
    { id: 9, cat: 'roupas', titulo: 'Camiseta Ellus 2nd Floor Snake', marca: '', img: 'http://iacom1-a.akamaihd.net/produtos/01/00/sku/117497/2/117497250G1.jpg', preco: 'R$ 79,90' },
    { id: 10, cat: 'roupas', titulo: 'Blusa Ellus Manga Longa', marca: '', img: 'http://iacom1-a.akamaihd.net/produtos/01/00/sku/117640/9/117640984G1.jpg', preco: 'R$ 99,90' },
    { id: 11, cat: 'roupas', titulo: 'Blusa M. Officer Com Spikes', marca: '', img: 'http://iacom1-a.akamaihd.net/produtos/01/00/sku/117822/1/117822155G1.jpg', preco: 'R$ 99,90' },
    { id: 12, cat: 'roupas', titulo: 'Blusa Ateen Dupla Romain Linda', marca: '', img: 'http://iacom1-a.akamaihd.net/produtos/01/00/sku/117973/2/117973295G1.jpg', preco: 'R$ 256,90' },
    { id: 13, cat: 'cabelos', titulo: 'Prancha Nano Titanium Babyliss Pro Tradicional 11/4', marca: '', img: 'http://iacom1-a.akamaihd.net/produtos/01/00/sku/9701/7/9701768G1.jpg', preco: 'R$ 349,00' },
    { id: 14, cat: 'cabelos', titulo: 'Secador de Cabelo Taiff Tourmaline Ion Cerâmica Preto - 2000W', marca: '', img: 'http://iacom1-a.akamaihd.net/produtos/01/00/item/7503/4/7503466G1.jpg', preco: 'R$ 179,00' },
    { id: 15, cat: 'cabelos', titulo: 'Escova Rotativa Britânia Cerâmica', marca: '', img: 'http://iacom1-a.akamaihd.net/produtos/01/00/item/126706/6/126706631G1.jpg', preco: 'R$ 69,90' },
    { id: 16, cat: 'cabelos', titulo: 'Escova Alisadora Elétrica Chapinha Lcd 230c', marca: '', img: 'http://iacom1-a.akamaihd.net/produtos/01/00/sku/12807/3/12807333G1.jpg', preco: 'R$ 137,00' },
  ];


  (function($){
    $(function(){
      setTimeout(function(){
        $('.produtos').slick({
          infinite: true,
          lazyLoad: 'ondemand',
          slidesToShow: 4,
          slidesToScroll: 1,
          speed: 300,
          autoplay: true
        });
      }, 200);
    });
  })(jQuery);

}]);
