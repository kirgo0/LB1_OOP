namespace Lb1
{
    public class MatchResult
    {
        public int matchIndex { get; }
        public string opName { get; }
        public int matchRating { get; }
        public Status _pStatus { get; }

        public MatchResult(int matchIndex, string opName, int matchRating,Status _pStatus)
        {
            this.matchIndex = matchIndex;
            this.opName = opName;
            this.matchRating = matchRating;
            this._pStatus = _pStatus;
        }
    }
}