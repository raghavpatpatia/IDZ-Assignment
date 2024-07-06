public class Queen : PieceUnit
{
    public Queen(ChessPieceController pieceController) : base(pieceController) { }

    public override void CalculateLegalMoves()
    {
        HighlightMovesInDirection(1, 0);
        HighlightMovesInDirection(-1, 0);
        HighlightMovesInDirection(0, 1);
        HighlightMovesInDirection(0, -1);

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
