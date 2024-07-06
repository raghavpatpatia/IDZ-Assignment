public class Bishop : PieceUnit
{
    public Bishop(ChessPieceController pieceController) : base(pieceController) { }

    public override void CalculateLegalMoves()
    {
        HighlightMovesInDirection(1, 1);
        HighlightMovesInDirection(1, -1);
        HighlightMovesInDirection(-1, 1);
        HighlightMovesInDirection(-1, -1);
    }

    private void HighlightMovesInDirection(int rowIncrement, int colIncrement)
    {
        HighlightMovesInStraightLine(rowIncrement, colIncrement);
    }
}
