public abstract class PieceUnit : IChessPiece
{
    protected ChessPieceController pieceController;
    public PieceUnit(ChessPieceController pieceController)
    {
        this.pieceController = pieceController;
    }
    public abstract void CalculateLegalMoves();

    protected void HighlightTile(int r, int c)
    {
        if (pieceController.IsInBounds(r, c))
        {
            var tile = ChessBoardPlacementHandler.Instance.GetTile(r, c);
            if (tile != null)
            {
                var piece = GetPieceAt(r, c);
                if (piece == null)
                {
                    ChessBoardPlacementHandler.Instance.Highlight(r, c);
                }
                else if (piece.ChessPieceTeam != pieceController.ChessPieceView.ChessPieceTeam)
                {
                    ChessBoardPlacementHandler.Instance.CaptureHighlight(r, c);
                }
            }
        }
    }

    protected ChessPieceView GetPieceAt(int r, int c)
    {
        foreach (var piece in GameManager.Instance.chessPieces)
        {
            if (piece.PieceRow == r && piece.PieceColumn == c)
            {
                return piece;
            }
        }
        return null;
    }

    protected void HighlightMovesInStraightLine(int rowIncrement, int colIncrement)
    {
        int currentRow = pieceController.ChessPieceView.PieceRow;
        int currentCol = pieceController.ChessPieceView.PieceColumn;

        while (true)
        {
            currentRow += rowIncrement;
            currentCol += colIncrement;

            if (!pieceController.IsInBounds(currentRow, currentCol))
                break;

            var piece = GetPieceAt(currentRow, currentCol);
            if (piece != null && piece.ChessPieceTeam == pieceController.ChessPieceView.ChessPieceTeam)
                break;

            HighlightTile(currentRow, currentCol);

            if (piece != null)
                break;
        }
    }
}
