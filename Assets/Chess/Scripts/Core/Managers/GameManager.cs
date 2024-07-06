using UnityEngine;
using Chess.Scripts.Core;

public class GameManager : GenericMonoSingleton<GameManager>
{
    public ChessPieceView[] chessPieces;
    private ChessPieceController[] chessPieceControllers;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        chessPieceControllers = new ChessPieceController[chessPieces.Length];
        InitializeChessControllers();
    }

    private void InitializeChessControllers()
    {
        for (int i = 0; i < chessPieces.Length; i++)
        {
            chessPieceControllers[i] = new ChessPieceController(chessPieces[i]);
        }
    }
}