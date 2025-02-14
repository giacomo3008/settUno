using System;

namespace settUno.models
{
    public class Contribuente
    {
        private string _nome;
        private string _cognome;
        private string _dataNascita;
        private string _codiceFiscale;
        private string _sesso;
        private string _comuneResidenza;
        private double _redditoAnnuale;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public string DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        public string Sesso
        {
            get { return _sesso; }
            set { _sesso = value; }
        }

        public string ComuneResidenza
        {
            get { return _comuneResidenza; }
            set { _comuneResidenza = value; }
        }

        public double RedditoAnnuale
        {
            get { return _redditoAnnuale; }
            set { _redditoAnnuale = value; }
        }
        public double CalcoloImposta()
        {
            double imposta = 0;

            if (_redditoAnnuale <= 15000)
            {
                imposta = _redditoAnnuale * 0.23;
            }
            else if (_redditoAnnuale > 15000 && _redditoAnnuale <= 28000)
            {
                imposta = 3450 + ((_redditoAnnuale - 15000) * 0.27);
            }
            else if (_redditoAnnuale > 28000 && _redditoAnnuale <= 55000)
            {
                imposta = 6960 + ((_redditoAnnuale - 28000) * 0.38);
            }
            else if (_redditoAnnuale > 55000 && _redditoAnnuale <= 75000)
            {
                imposta = 17220 + ((_redditoAnnuale - 55000) * 0.41);
            }
            else if (_redditoAnnuale > 75000)
            {
                imposta = 25420 + ((_redditoAnnuale - 75000) * 0.43);
            }

            return imposta;
        }

        public string Riepilogo()
        {
            return $"Contribuente: {Nome} {Cognome},\n" +
                   $"nato il {DataNascita} ({Sesso}),\n" +
                   $"residente in {ComuneResidenza},\n" +
                   $"codice fiscale: {CodiceFiscale}\n" +
                   $"Reddito dichiarato: {RedditoAnnuale:0.00}\n" +
                   $"IMPOSTA DA VERSARE: € {CalcoloImposta():0.00}";
        }
    }
}
