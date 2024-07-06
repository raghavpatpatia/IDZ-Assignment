public class Pawn : PieceUnit
{
    public Pawn(ChessPieceController pieceController) : base(pieceController) { }

    public override void CalculateLegalMoves()
    {
        int direction = pieceController.ChessPieceView.ChessPieceTeam == ChessPieceTeam.WHITE ? 1 : -1;
        int startRow = pieceController.ChessPieceView.ChessPieceTeam == ChessPieceTeam.WHITE ? 1 : 6;

        int currentRow = pieceController.ChessPieceView.PieceRow;
        int currentCol = pieceController.ChessPieceView.PieceColumn;

        if (GetPieceAt(currentRow + direction, currentCol) == null)
        {
            HighlightTile(currentRow + direction, currentCol);
            if (currentRow == startRow && GetPieceAt(currentRow + 2 * direction, currentCol) == null)
            {
                HighlightTile(currentRow + 2 * direction, currentCol);
            }
        }

        HighlightCaptureTile(currentRow + direction, currentCol + 1);
        HighlightCaptureTile(currentRow + direction, currentCol - 1);
    }

    private void HighlightCaptureTile(int row, int col)
    {
        var piece = GetPieceAt(row, col);
        if (piece != null && piece.ChessPieceTeam != pieceController.ChessPieceView.ChessPieceTeam)
        {
            HighlightTile(row, col);
        }
    }
}
