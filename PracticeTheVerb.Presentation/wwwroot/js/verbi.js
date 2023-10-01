/* :: 1.0 Import All Verb JSs */
function include(file) {
  var script  = document.createElement('script');
  script.src  = file;
  script.type = 'text/javascript';
  script.defer = true;

  document.getElementsByTagName('head').item(0).appendChild(script);

}

/* Include JS Verbs ControlaTutti */
include('/js/controllaTutti.js');

/* Include JS Verbs INDICATIVO */
include('/js/indicativo/presente.js');
include('/js/indicativo/passatoProssimo.js');
include('/js/indicativo/imperfetto.js');
include('/js/indicativo/trapassatoProssimo.js');
include('/js/indicativo/passatoRemoto.js');
include('/js/indicativo/trapassatoRemoto.js');
include('/js/indicativo/futuroSemplice.js');
include('/js/indicativo/futuroAnteriore.js');

/* Include JS Verbs CONGIUNTIVO */
include('/js/congiuntivo/presente.js');
include('/js/congiuntivo/passato.js');
include('/js/congiuntivo/imperfetto.js');
include('/js/congiuntivo/trapassato.js');

/* Include JS Verbs CONDIZIONALE */
include('/js/condizionale/presente.js');
include('/js/condizionale/passato.js');

/* Include JS Verbs RIFLESSIVO */
include('/js/riflessivo/presente.js');
include('/js/riflessivo/passato.js');

/* Include JS Verbs IMPERATIVO */
include('/js/imperativo/presente.js');

/* Include JS Verbs INFINITIVO */
include('/js/infinitivo/presente.js');
include('/js/infinitivo/passato.js');

/* Include JS Verbs PARTICIPIO */
include('/js/participio/presente.js');
include('/js/participio/passato.js');

/* Include JS Verbs GERUNDIO */
include('/js/gerundio/presente.js');
include('/js/gerundio/passato.js');