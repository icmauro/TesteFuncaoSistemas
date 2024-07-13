//submit botao beneficiarios

$(document).ready(function () {

    $('#formCadastroBeneficiario').submit(function (e) {
        e.preventDefault();

        $.ajax({
            url: urlPostBeneficiarioInclusao,
            method: "POST",
            data: {
                "IdCliente": $(this).find("#IdCliente").val(),
                "Nome": $(this).find("#NomeBeneficiario").val(),
                "Cpf": $(this).find("#CpfBeneficiario").val()
            },
            error:
                function (r) {
                    if (r.status == 400)
                        ModalDialog("Ocorreu um erro", r.responseJSON);
                    else if (r.status == 500)
                        ModalDialog("Ocorreu um erro", "Ocorreu um erro interno no servidor.");
                },
            success:
                function (r) {
                    ModalDialog("Sucesso!", r)
                    $("#formCadastroBeneficiario")[0].reset();
                }
        });
    });

    $('#CpfBeneficiario').mask('000.000.000-00');

    //////////////////////////////////////////////////////////////////////////////////

    //var tt = urlClienteListBeneficiario + '/IdCliente=' + $("#IdClienteForm").val();

    if (document.getElementById("gridBeneficiarios"))
        $('#gridBeneficiarios').jtable({
            title: 'Beneficiarios',
            paging: true, //Enable paging
            pageSize: 5, //Set page size (default: 10)
            sorting: true, //Enable sorting
            defaultSorting: 'Nome ASC', //Set default sorting
            actions: {
                listAction: urlClienteListBeneficiario,
            },
            fields: {
                Nome: {
                    title: 'Nome',
                    width: '50%'
                },
                Cpf: {
                    title: 'Cpf',
                    width: '35%'
                },
                Alterar: {
                    title: '',
                    display: function (data) {
                        return '<button onclick="window.location.href=\'' + urlAlteracao + '/' + data.record.Id + '\'" class="btn btn-primary btn-sm">Alterar</button>';
                    }
                }
            }
        });

    if (document.getElementById("gridBeneficiarios"))
        $('#gridBeneficiarios').jtable('load', { IdCliente: $("#IdClienteForm").val() });

});
