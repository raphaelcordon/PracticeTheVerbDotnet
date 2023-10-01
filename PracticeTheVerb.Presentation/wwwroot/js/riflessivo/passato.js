$(document).on('click', "#answerriflessivoPassato", function () {
    runriflessivoPassato();
});
function runriflessivoPassato() {

    var exriflessivoPassatoIo = document.getElementById('exriflessivoPassatoIo').value;
    var exriflessivoPassatoTu = document.getElementById('exriflessivoPassatoTu').value;
    var exriflessivoPassatoLui = document.getElementById('exriflessivoPassatoLui').value;
    var exriflessivoPassatoNoi = document.getElementById('exriflessivoPassatoNoi').value;
    var exriflessivoPassatoVoi = document.getElementById('exriflessivoPassatoVoi').value;
    var exriflessivoPassatoLoro = document.getElementById('exriflessivoPassatoLoro').value;

    //io
    var answerriflessivoPassatoIo = document.getElementById('answerriflessivoPassatoIo').value;
    if (exriflessivoPassatoIo == answerriflessivoPassatoIo){
        $('.CSSverbsAnswerriflessivoPassatoIo').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPassatoIo').attr('style', 'display: initial; color: red;');
    };

    //tu
    var answerriflessivoPassatoTu = document.getElementById('answerriflessivoPassatoTu').value;
    if (exriflessivoPassatoTu == answerriflessivoPassatoTu){
        $('.CSSverbsAnswerriflessivoPassatoTu').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPassatoTu').attr('style', 'display: initial; color: red;');
    };

    //lui
    var answerriflessivoPassatoLui = document.getElementById('answerriflessivoPassatoLui').value;
    if (exriflessivoPassatoLui == answerriflessivoPassatoLui){
        $('.CSSverbsAnswerriflessivoPassatoLui').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPassatoLui').attr('style', 'display: initial; color: red;');
    };

    //noi
    var answerriflessivoPassatoNoi = document.getElementById('answerriflessivoPassatoNoi').value;
    if (exriflessivoPassatoNoi == answerriflessivoPassatoNoi){
        $('.CSSverbsAnswerriflessivoPassatoNoi').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPassatoNoi').attr('style', 'display: initial; color: red;');
    };

    //voi
    var answerriflessivoPassatoVoi = document.getElementById('answerriflessivoPassatoVoi').value;
    if (exriflessivoPassatoVoi == answerriflessivoPassatoVoi){
        $('.CSSverbsAnswerriflessivoPassatoVoi').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPassatoVoi').attr('style', 'display: initial; color: red;');
    };

    //loro
    var answerriflessivoPassatoLoro = document.getElementById('answerriflessivoPassatoLoro').value;
    if (exriflessivoPassatoLoro == answerriflessivoPassatoLoro){
        $('.CSSverbsAnswerriflessivoPassatoLoro').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPassatoLoro').attr('style', 'display: initial; color: red;');
    };
};

// Cleaning the form
$(document).on('click', "#ricominciariflessivoPassato", function () {
    cleanriflessivoPassato();
});
function cleanriflessivoPassato() {
    $('.CSSverbsAnswerriflessivoPassatoIo').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPassatoTu').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPassatoLui').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPassatoNoi').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPassatoVoi').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPassatoLoro').attr('style', 'display: none;');

    document.getElementById('formriflessivoPassato').reset();
};