document.addEventListener("DOMContentLoaded", function () {
    const botaoEnviar = document.getElementById("enviar");
    const botaoApagar = document.getElementById("apagar");

    botaoEnviar.addEventListener("click", function (event) {
        event.preventDefault();

        const nome = document.getElementById("nome").value.trim();
        const email = document.getElementById("email").value.trim();
        const mensagem = document.getElementById("mensagem").value.trim();

        const emailValido = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (!nome && !email && !mensagem) {
            alert("Por favor, preencha o Nome, o Email e a Mensagem.");
            return;
        }

        if (!nome && !email) {
            alert("Por favor, preencha o Nome e o Email.");
            return;
        }

        if (!nome && !mensagem) {
            alert("Por favor, preencha o Nome e a Mensagem.");
            return;
        }

        if (!email && !mensagem) {
            alert("Por favor, preencha o Email e a Mensagem.");
            return;
        }

        if (!nome) {
            alert("Por favor, preencha o campo Nome.");
            return;
        }

        if (!email || !emailValido.test(email)) {
            alert("Por favor, insira um Email válido.");
            return;
        }

        if (!mensagem) {
            alert("Por favor, escreva uma Mensagem.");
            return;
        }


        alert(`Obrigado, ${nome}! Sua mensagem foi enviada com sucesso.`);

    });

    botaoApagar.addEventListener("click", function () {

        document.getElementById("nome").value = "";
        document.getElementById("email").value = "";
        document.getElementById("assunto").value = "Outro";
        document.getElementById("mensagem").value = "";
    });
});
