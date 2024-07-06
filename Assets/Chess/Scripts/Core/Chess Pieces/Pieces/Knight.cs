public class Knight : PieceUnit
{
    public Knight(ChessPieceController pieceController) : base(pieceController) { }

    public override void CalculateLegalMoves()
    {
        HighlightTile(pieceController.ChessPieceView.PieceRow + 2, pieceController.ChessPieceView.PieceColumn + 1);
        HighlightTile(pieceController.ChessPieceView.PieceRow + 2, pieceController.ChessPieceView.PieceColumn - 1);
        HighlightTile(pieceController.ChessPieceView.PieceRow - 2, pieceController.ChessPieceView.PieceColumn + 1);
        HighlightTile(pieceController.ChessPieceView.PieceRow - 2, pieceController.ChessPieceView.PieceColumn - 1);
        HighlightTile(pieceController.ChessPieceView.PieceRow + 1, pieceController.ChessPieceView.PieceColumn + 2);
        HighlightTile(pieceController.ChessPieceView.PieceRow + 1, pieceController.ChessPieceView.PieceColumn - 2);
        HighlightTile(pieceController.ChessPieceView.PieceRow - 1, pieceController.ChessPieceView.PieceColumn + 2);
        HighlightTile(pieceController.ChessPieceView.PieceRow - 1, pieceController.ChessPieceView.PieceColumn - 2);
    }
}
