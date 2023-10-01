$(document).on('click', "#answerriflessivoPresente", function () {
    runriflessivoPresente();
});
function runriflessivoPresente() {

    var exriflessivoPresenteIo = document.getElementById('exriflessivoPresenteIo').value;
    var exriflessivoPresenteTu = document.getElementById('exriflessivoPresenteTu').value;
    var exriflessivoPresenteLui = document.getElementById('exriflessivoPresenteLui').value;
    var exriflessivoPresenteNoi = document.getElementById('exriflessivoPresenteNoi').value;
    var exriflessivoPresenteVoi = document.getElementById('exriflessivoPresenteVoi').value;
    var exriflessivoPresenteLoro = document.getElementById('exriflessivoPresenteLoro').value;

    //io
    var answerriflessivoPresenteIo = document.getElementById('answerriflessivoPresenteIo').value;
    if (exriflessivoPresenteIo == answerriflessivoPresenteIo){
        $('.CSSverbsAnswerriflessivoPresenteIo').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPresenteIo').attr('style', 'display: initial; color: red;');
    };

    //tu
    var answerriflessivoPresenteTu = document.getElementById('answerriflessivoPresenteTu').value;
    if (exriflessivoPresenteTu == answerriflessivoPresenteTu){
        $('.CSSverbsAnswerriflessivoPresenteTu').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPresenteTu').attr('style', 'display: initial; color: red;');
    };

    //lui
    var answerriflessivoPresenteLui = document.getElementById('answerriflessivoPresenteLui').value;
    if (exriflessivoPresenteLui == answerriflessivoPresenteLui){
        $('.CSSverbsAnswerriflessivoPresenteLui').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPresenteLui').attr('style', 'display: initial; color: red;');
    };

    //noi
    var answerriflessivoPresenteNoi = document.getElementById('answerriflessivoPresenteNoi').value;
    if (exriflessivoPresenteNoi == answerriflessivoPresenteNoi){
        $('.CSSverbsAnswerriflessivoPresenteNoi').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPresenteNoi').attr('style', 'display: initial; color: red;');
    };

    //voi
    var answerriflessivoPresenteVoi = document.getElementById('answerriflessivoPresenteVoi').value;
    if (exriflessivoPresenteVoi == answerriflessivoPresenteVoi){
        $('.CSSverbsAnswerriflessivoPresenteVoi').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPresenteVoi').attr('style', 'display: initial; color: red;');
    };

    //loro
    var answerriflessivoPresenteLoro = document.getElementById('answerriflessivoPresenteLoro').value;
    if (exriflessivoPresenteLoro == answerriflessivoPresenteLoro){
        $('.CSSverbsAnswerriflessivoPresenteLoro').attr('style', 'display: initial; color: green;');
    }else{
        $('.CSSverbsAnswerriflessivoPresenteLoro').attr('style', 'display: initial; color: red;');
    };
  };

// Cleaning the form
$(document).on('click', "#ricominciariflessivoPresente", function () {
    cleanriflessivoPresente();
});
function cleanriflessivoPresente() {
    $('.CSSverbsAnswerriflessivoPresenteIo').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPresenteTu').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPresenteLui').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPresenteNoi').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPresenteVoi').attr('style', 'display: none;');
    $('.CSSverbsAnswerriflessivoPresenteLoro').attr('style', 'display: none;');

    document.getElementById('formriflessivoPresente').reset();
};
