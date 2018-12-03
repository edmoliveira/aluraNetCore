class buscaDeProdutos {
    constructor() {

    }

    mostrarMensagem(mensagem) {
        $('.produto-message-popup').text(mensagem);
        $('.produto-message-popup').slideDown('slow');

        setTimeout(function () {
            $('.produto-message-popup').slideUp('slow');
        }, 2000);
    }
}

var oBuscaDeProdutos = new buscaDeProdutos();