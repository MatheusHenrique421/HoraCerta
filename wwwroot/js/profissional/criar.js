$(function () {
    "use strict";


    $("#telefone").inputmask("(99) 9 9999-9999");
    $("#whatsApp").inputmask("+55 (99) 9 9999-9999");


    const especialidadesSelecionadas = [];

    $('#especialidadesSelect').on('change', function () {
        const select = $(this);
        const id = select.val();
        const texto = select.find('option:selected').text();

        if (!id) return;

        // Se ainda não estiver selecionada
        if (!especialidadesSelecionadas.includes(id)) {
            especialidadesSelecionadas.push(id);

            // Remove o texto "Nenhuma especialidade selecionada"
            $('#especialidadesSelecionadas p').remove();

            // Adiciona o item visual
            $('#especialidadesSelecionadas').append(`
                    <span class="badge bg-primary text-white fs-6 me-2 mb-2 d-inline-flex align-items-center">
                        ${texto}
                        <button type="button" class="btn btn-sm btn-link text-white ms-1 p-0 remove-especialidade" data-id="${id}" title="Remover">
                            <i class="fas fa-times"></i>
                        </button>
                    </span>
                `);

            // Atualiza o hidden input
            $('#especialidadesHidden').val(especialidadesSelecionadas.join(','));

            // Remove do select
            select.find(`option[value="${id}"]`).remove();
            select.val('');
            $('#txtSemEspecialidade').hide();
        }
    });

    // Remover especialidade
    $(document).on('click', '.remove-especialidade', function () {
        const id = $(this).data('id');
        const badge = $(this).closest('span');
        const texto = badge.text().trim();

        // Remove visualmente
        badge.remove();

        // Atualiza array e hidden
        const index = especialidadesSelecionadas.indexOf(id);
        if (index > -1) especialidadesSelecionadas.splice(index, 1);
        $('#especialidadesHidden').val(especialidadesSelecionadas.join(','));

        // Recoloca no select
        $('#especialidadesSelect').append(`<option value="${id}">${texto}</option>`);

        // Se nenhuma estiver selecionada, mostra aviso
        if (especialidadesSelecionadas.length === 0) {
            $('#especialidadesSelecionadas').html('<p class="text-muted mb-0 small">Nenhuma especialidade selecionada.</p>');
        }
    });


    //Limpa formulário
    $("#btnLimpar").on("click", function (e) {
        e.preventDefault(); // evita comportamento padrão do botão, se for type="submit"

        $("#formProfissional")[0].reset(); // reseta todos os inputs    

        $("#formProfissional").find(".text-danger").text("");

        $(".is-invalid").removeClass("is-invalid"); // remove bordas vermelhas
    });

    //Submit com validação
    $("#formProfissional").on("submit", function (e) {
        let isValid = true;

        // Validação Serviço
        const nome = $("#Nome").val();
        if (!nome) {
            $("#Nome").addClass("is-invalid");
            $("#Nome").siblings(".text-danger").text("O Nome é obrigatório.");
            isValid = false;
        }

        const sobrenome = $("#Sobrenome").val();
        if (!sobrenome) {
            $("#Sobrenome").addClass("is-invalid");
            $("#Sobrenome").siblings(".text-danger").text("O Sobrenome é obrigatório.");
            isValid = false;
        }

        const whatsApp = $("#whatsApp").val();
        if (!whatsApp) {
            $("#whatsApp").addClass("is-invalid");
            $("#whatsApp").siblings(".text-danger").text("O WhatsApp é obrigatório.");
            isValid = false;
        }

        const email = $("#Email").val();
        if (!email) {
            $("#Email").addClass("is-invalid");
            $("#Email").siblings(".text-danger").text("O E-mail é obrigatório.");
            isValid = false;
        }

        const instagram = $("#Instagram").val();
        if (!instagram) {
            $("#Instagram").addClass("is-invalid");
            $("#Instagram").siblings(".text-danger").text("O Instagram é obrigatório.");
            isValid = false;
        }

        const especialidadesIdSelecionadas = $("#especialidadesSelect").val();
        if (!especialidadesIdSelecionadas) {
            $("#especialidadesSelect").addClass("is-invalid");
            $("#especialidadesSelect").siblings(".text-danger").text("Selecione as especialidades do profissional.");
            isValid = false;
        }


        // Se algum campo inválido, bloqueia o submit
        if (!isValid) {
            e.preventDefault();
        }
    });

});