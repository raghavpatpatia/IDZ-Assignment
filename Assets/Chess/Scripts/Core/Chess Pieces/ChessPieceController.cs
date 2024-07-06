
public class ChessPieceController 
{ 
    public ChessPieceView ChessPieceView { get; private set; }
    public ChessPieceController(ChessPieceView chessPieceView)
    {
        this.ChessPieceView = chessPieceView;
        this.ChessPieceView.Init(this);
    }

    public bool IsInBounds(int row, int column)
    {
        return row >= 0 && row < 8 && column >= 0 && column < 8;
    }

    public void OnPieceSelected()
    {
        PieceUnit piece = GetPiece();
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        piece.CalculateLegalMoves();
    }

    private PieceUnit GetPiece()
    {
        switch (ChessPieceView.ChessPieceType)
        {
            case ChessPieceType.NONE:
                return null;
            case ChessPieceType.PAWN:
                return new Pawn(this);
            case ChessPieceType.ROOK:
                return new Rook(this);
            case ChessPieceType.KNIGHT:
                return new Knight(this);
            case ChessPieceType.BISHOP:
                return new Bishop(this);
            case ChessPieceType.QUEEN:
                return new Queen(this);
            case ChessPieceType.KING:
                return new King(this);
            default:
                return null;
        }
    }
}