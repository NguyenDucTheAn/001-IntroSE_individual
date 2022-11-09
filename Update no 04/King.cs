using System.Collections.Generic;
using UnityEngine;

public class King : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ChessPiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        // 3 tiles above and below the King
        int x = currentX - 1, y_up = currentY + 1, y_down = currentY - 1;
        for (x; x <= currentX + 1; x++)
        {
            if (x >= 0 && x < tileCountX)
            {
                if (y_up < tileCountY && (board[x, y_up] == null || board[x, y_up].team != team))
                    r.Add(new Vector2Int(x, y_up));
                if (y_down >= 0 && (board[x, y_down] == null || board[x, y_down].team != team))
                    r.Add(new Vector2Int(x, y_down));
            }
        }

        // right
        if (currentX + 1 < tileCountX && (board[currentX + 1, currentY] == null || board[currentX + 1, currentY].team != team))
            r.Add(new Vector2Int(currentX + 1, currentY));

        // left
        if (currentX - 1 >= 0 && (board[currentX - 1, currentY] == null || board[currentX - 1, currentY].team != team))
            r.Add(new Vector2Int(currentX - 1, currentY));

        return r;
    }
}