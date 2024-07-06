public class King : PieceUnit
{
    public King(ChessPieceController pieceController) : base(pieceController) { }

    public override void CalculateLegalMoves()
    {
        HighlightTile(pieceController.ChessPieceView.PieceRow + 1, pieceController.ChessPieceView.PieceColumn);
        HighlightTile(pieceController.ChessPieceView.PieceRow - 1, pieceController.ChessPieceView.PieceColumn);
        HighlightTile(pieceController.ChessPieceView.PieceRow, pieceController.ChessPieceView.PieceColumn + 1);
        HighlightTile(pieceController.ChessPieceView.PieceRow, pieceController.ChessPieceView.PieceColumn - 1);
        HighlightTile(pieceController.ChessPieceView.PieceRow + 1, pieceController.ChessPieceView.PieceColumn + 1);
        HighlightTile(pieceController.ChessPieceView.PieceRow + 1, pieceController.ChessPieceView.PieceColumn - 1);
        HighlightTile(pieceController.ChessPieceView.PieceRow - 1, pieceController.ChessPieceView.PieceColumn + 1);
        HighlightTile(pieceController.ChessPieceView.PieceRow - 1, pieceController.ChessPieceView.PieceColumn - 1);
    }
}
