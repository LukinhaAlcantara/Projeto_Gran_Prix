// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//CLIENTES
$(document).ready(function () {
    $('#Cliente').DataTable(
        {
            language: {
                "decimal": "",
                "emptyTable": "Nenhum dado disponível na tabela",
                "info": "Mostrando _START_ a _END_ de _TOTAL_ entradas",
                "infoEmpty": "Mostrando 0 a 0 de 0 entradas",
                "infoFiltered": "(filtrado de um total de _MAX_ entradas)",
                "infoPostFix": "",
                "thousands": ",",
                "lengthMenu": "Mostrar _MENU_ entradas",
                "loadingRecords": "Carregando...",
                "processing": "Processando...",
                "search": "Buscar:", "zeroRecords": "Nenhum registro correspondente encontrado",
                "paginate": {
                    "first": "Primeira",
                    "last": "Última",
                    "next": "Próxima",
                    "previous": "Anterior"
                },
                "aria": {
                    "sortAscending": ": ativar para classificar a coluna em ordem crescente",
                    "sortDescending": ": ativar para classificar a coluna em ordem decrescente"
                }
            }
        });
    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        });
    }, 5000)

});

//FUNCIONARIOS
$(document).ready(function () {
    $('#Funcionario').DataTable(
        {
            language: {
                "decimal": "",
                "emptyTable": "Nenhum dado disponível na tabela",
                "info": "Mostrando _START_ a _END_ de _TOTAL_ entradas",
                "infoEmpty": "Mostrando 0 a 0 de 0 entradas",
                "infoFiltered": "(filtrado de um total de _MAX_ entradas)",
                "infoPostFix": "",
                "thousands": ",",
                "lengthMenu": "Mostrar _MENU_ entradas",
                "loadingRecords": "Carregando...",
                "processing": "Processando...",
                "search": "Buscar:", "zeroRecords": "Nenhum registro correspondente encontrado",
                "paginate": {
                    "first": "Primeira",
                    "last": "Última",
                    "next": "Próxima",
                    "previous": "Anterior"
                },
                "aria": {
                    "sortAscending": ": ativar para classificar a coluna em ordem crescente",
                    "sortDescending": ": ativar para classificar a coluna em ordem decrescente"
                }
            }
        });
    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        });
    }, 5000)
});

//FORNECEDORES
$(document).ready(function () {
    $('#Fornecedores').DataTable(
        {
            language: {
                "decimal": "",
                "emptyTable": "Nenhum dado disponível na tabela",
                "info": "Mostrando _START_ a _END_ de _TOTAL_ entradas",
                "infoEmpty": "Mostrando 0 a 0 de 0 entradas",
                "infoFiltered": "(filtrado de um total de _MAX_ entradas)",
                "infoPostFix": "",
                "thousands": ",",
                "lengthMenu": "Mostrar _MENU_ entradas",
                "loadingRecords": "Carregando...",
                "processing": "Processando...",
                "search": "Buscar:", "zeroRecords": "Nenhum registro correspondente encontrado",
                "paginate": {
                    "first": "Primeira",
                    "last": "Última",
                    "next": "Próxima",
                    "previous": "Anterior"
                },
                "aria": {
                    "sortAscending": ": ativar para classificar a coluna em ordem crescente",
                    "sortDescending": ": ativar para classificar a coluna em ordem decrescente"
                }
            }
        });
    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        });
    }, 5000)
});

//ESTOQUE
$(document).ready(function () {
    $('#Estoque').DataTable(
        {
            language: {
                "decimal": "",
                "emptyTable": "Nenhum dado disponível na tabela",
                "info": "Mostrando _START_ a _END_ de _TOTAL_ entradas",
                "infoEmpty": "Mostrando 0 a 0 de 0 entradas",
                "infoFiltered": "(filtrado de um total de _MAX_ entradas)",
                "infoPostFix": "",
                "thousands": ",",
                "lengthMenu": "Mostrar _MENU_ entradas",
                "loadingRecords": "Carregando...",
                "processing": "Processando...",
                "search": "Buscar:", "zeroRecords": "Nenhum registro correspondente encontrado",
                "paginate": {
                    "first": "Primeira",
                    "last": "Última",
                    "next": "Próxima",
                    "previous": "Anterior"
                },
                "aria": {
                    "sortAscending": ": ativar para classificar a coluna em ordem crescente",
                    "sortDescending": ": ativar para classificar a coluna em ordem decrescente"
                }
            }
        });
    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        });
    }, 5000)
});

//CAIXA
$(document).ready(function () {
    $('#Caixa').DataTable(
        {
            language: {
                "decimal": "",
                "emptyTable": "Nenhum dado disponível na tabela",
                "info": "Mostrando _START_ a _END_ de _TOTAL_ entradas",
                "infoEmpty": "Mostrando 0 a 0 de 0 entradas",
                "infoFiltered": "(filtrado de um total de _MAX_ entradas)",
                "infoPostFix": "",
                "thousands": ",",
                "lengthMenu": "Mostrar _MENU_ entradas",
                "loadingRecords": "Carregando...",
                "processing": "Processando...",
                "search": "Buscar:", "zeroRecords": "Nenhum registro correspondente encontrado",
                "paginate": {
                    "first": "Primeira",
                    "last": "Última",
                    "next": "Próxima",
                    "previous": "Anterior"
                },
                "aria": {
                    "sortAscending": ": ativar para classificar a coluna em ordem crescente",
                    "sortDescending": ": ativar para classificar a coluna em ordem decrescente"
                }
            }
        });
    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        });
    }, 5000)

});