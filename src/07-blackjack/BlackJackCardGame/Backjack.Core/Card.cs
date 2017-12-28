namespace Backjack.Core
{
    public class Card
    {
        //mis tähtis, mis mast, palju punkte annab?
        // clubs (♣), diamonds (♦), hearts (♥) and spades (♠)

        public string Description => _rank + _suite.GetShortName();

        //Kui booleani ei väärtustata, siis ta on vaikimisi false. 
        public bool Hidden { get; set; }

        private readonly string _rank;

        private readonly Suite _suite;

        private readonly int _points;

        public Card(string rank, Suite suite, int points, bool hidden = false)
        {
            this._rank = rank;
            this._suite = suite;
            this._points = points;
            this.Hidden = hidden;

            //Description = _rank + _suite; --> selle tõistsime ülesse ja tegime kohe: Description => _rank + _suite (mis tähendab, et get, returnib siis _rank + _suite)

        }
    }
}