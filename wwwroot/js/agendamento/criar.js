$(function () {
    "use strict"; // ativa modo estrito dentro deste escopo


    // Seleciona o formulário
    $("#formAgendamento").on("submit", function (e) {
        let isValid = true;

        // Limpa mensagens anteriores
        $(".text-danger").text("");

        // Validação Data
        const data = $("#Data").val();
        if (!data) {
            $("#Data").addClass("is-invalid");
            $("#Data").siblings(".text-danger").text("A data é obrigatória*");
            isValid = false;
        }

        // Validação Hora
        const hora = $("#Hora").val();
        if (!hora) {
            $("#Hora").addClass("is-invalid");
            $("#Hora").siblings(".text-danger").text("A hora é obrigatória*");
            isValid = false;
        }

        // Validação Pessoa
        const pessoa = $("#PessoaId").val();
        if (!pessoa) {
            $("#PessoaId").addClass("is-invalid");
            $("#PessoaId").siblings(".text-danger").text("Selecione um cliente*");
            isValid = false;
        }

        // Validação Profissional
        const profissional = $("#ProfissionalId").val();
        if (!profissional) {
            $("#ProfissionalId").addClass("is-invalid");
            $("#ProfissionalId").siblings(".text-danger").text("Selecione um profissional*");
            isValid = false;
        }

        // Validação Serviço
        const servico = $("#ServicoId").val();
        if (!servico) {
            $("#ServicoId").addClass("is-invalid");
            $("#ServicoId").siblings(".text-danger").text("Selecione um serviço*");
            isValid = false;
        }

        // Se algum campo inválido, bloqueia o submit
        if (!isValid) {
            e.preventDefault();
        }
    });

    //Limpa formulário
    $("#btnLimpar").on("click", function (e) {
        e.preventDefault(); // evita comportamento padrão do botão, se for type="submit"
        $("#Data").val(null);
        $("#Hora").val("");
        $("#formAgendamento")[0].reset(); // reseta todos os inputs        
        $(".is-invalid").removeClass("is-invalid"); // remove bordas vermelhas
    });


});
