using System;
using RestSharp;
using System.Windows.Forms;

namespace VerifyRest_NET
{

    /// <summary>
    /// Esempio di utilizzo del servizio WS VERIFY per la verifica e la normalizzazione degli indirizzi italiani 
    /// realizzato da StreetMaster Italia
    /// 
    /// L'end point del servizio è 
    ///     http://ec2-46-137-97-173.eu-west-1.compute.amazonaws.com/smrest/webresources/verify
    ///     
    /// Per l'utilizzo registrarsi sul sito http://streetmaster.it e richiedere la chiave per il servizio VERIFY 
    /// Il protocollo di comunicazione e' in formato JSON
    /// Per le comunicazioni REST è utilizzata la libreria opensource RestSharp (http://restsharp.org/)
    /// 
    ///  2016 - Software by StreetMaster (c)
    /// </summary>
    public partial class frmVerifyRest : Form
    {
        int currCand = 0;
        VerifyResponse outVerify;
        public frmVerifyRest()
        {
            InitializeComponent();
        }

        private void btnCallVerify_Click(object sender, EventArgs e)
        {
            
            if (txtKey.Text==String.Empty)
            {
                MessageBox.Show("E' necessario specificare una chiave valida per il servizio VERIFY");
                txtKey.Focus();
                return;
            }

            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // inizializzazione client del servizio VERIFY
            var clientVerify = new RestSharp.RestClient();
            clientVerify.BaseUrl = new Uri("http://ec2-46-137-97-173.eu-west-1.compute.amazonaws.com");

            var request = new RestRequest("smrest/webresources/verify", Method.GET);
            request.RequestFormat = DataFormat.Json;

            // valorizzazione input
            // per l'esempio viene valorizzato un insieme minimo dei parametri
            request.AddParameter("Key", txtKey.Text);
            request.AddParameter("Localita", txtInComune.Text);
            request.AddParameter("Cap", txtInCap.Text);
            request.AddParameter("Provincia", txtInProvincia.Text);
            request.AddParameter("Indirizzo", txtInIndirizzo.Text);
            request.AddParameter("Localita2", String.Empty);
            request.AddParameter("Dug", String.Empty);
            request.AddParameter("Civico", String.Empty);
                
            var response = clientVerify.Execute<VerifyResponse>(request);
            outVerify = response.Data;


            //  output generale
            txtOutEsito.Text = outVerify.Norm.ToString();
            txtOutCodErr.Text = outVerify.CodErr.ToString();
            txtOutNumCand.Text = outVerify.NumCand.ToString();

            currCand = 0;
            // dettaglio del primo candidato se esiste
            // nella form di output e' riportato solo un sottoinsieme di tutti i valori restituiti
            if (outVerify.Output.Count > 0)
            {
                txtOutCap.Text = outVerify.Output[currCand].Cap;
                txtOutComune.Text = outVerify.Output[currCand].Comune;
                txtOutFrazione.Text = outVerify.Output[currCand].Frazione;
                txtOutIndirizzo.Text = outVerify.Output[currCand].Indirizzo;
                txtOutProvincia.Text = outVerify.Output[currCand].Prov;
                txtOutScoreComune.Text = outVerify.Output[currCand].ScoreComune.ToString();
                txtOutScoreStrada.Text = outVerify.Output[currCand].ScoreStrada.ToString();
            }
            Cursor = Cursors.Default;
        }

        private void btnMovePrev_Click(object sender, EventArgs e)
        {
            // dettaglio del successivo candidato se esiste
            if (currCand > 0)
            {
                currCand -= 1;
                txtOutCap.Text = outVerify.Output[currCand].Cap;
                txtOutComune.Text = outVerify.Output[currCand].Comune;
                txtOutFrazione.Text = outVerify.Output[currCand].Frazione;
                txtOutIndirizzo.Text = outVerify.Output[currCand].Indirizzo;
                txtOutProvincia.Text = outVerify.Output[currCand].Prov;
                txtOutScoreComune.Text = outVerify.Output[currCand].ScoreComune.ToString();
                txtOutScoreStrada.Text = outVerify.Output[currCand].ScoreStrada.ToString();

            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            // dettagli del precedente candidato se esiste
            if (currCand+1< outVerify.Output.Count)
            {
                currCand += 1;
                txtOutCap.Text = outVerify.Output[currCand].Cap;
                txtOutComune.Text = outVerify.Output[currCand].Comune;
                txtOutFrazione.Text = outVerify.Output[currCand].Frazione;
                txtOutIndirizzo.Text = outVerify.Output[currCand].Indirizzo;
                txtOutProvincia.Text = outVerify.Output[currCand].Prov;
                txtOutScoreComune.Text = outVerify.Output[currCand].ScoreComune.ToString();
                txtOutScoreStrada.Text = outVerify.Output[currCand].ScoreStrada.ToString();

            }
        }
    }
}
