using Chess.Scripts.Core;
using UnityEngine;

public class ChessPieceView : MonoBehaviour
{
    [SerializeField] private ChessPieceType pieceType;
    [SerializeField] private ChessPieceTeam pieceTeam;
    public ChessPieceType ChessPieceType { get { return pieceType; } }
    public ChessPieceTeam ChessPieceTeam { get { return pieceTeam; } }
    public int PieceRow { get; private set; }
    public int PieceColumn { get; private set; }
    private ChessPieceController chessPieceController;
    private ChessPlayerPlacementHandler chessPlayerPlacementHandler;

    private void Start()
    {
        this.chessPlayerPlacementHandler = this.gameObject.GetComponent<ChessPlayerPlacementHandler>();
        PieceRow = chessPlayerPlacementHandler.row;
        PieceColumn = chessPlayerPlacementHandler.column;
    }

    public void Init(ChessPieceController chessPieceController)
    {
        this.chessPieceController = chessPieceController;
    }

    private void OnMouseDown()
    {
        chessPieceController.OnPieceSelected();
    }
}