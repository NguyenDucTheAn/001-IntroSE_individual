using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ChessPiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();



        //right
        for (int i = currentX + 1; i < tileCountX; i++)
            if (board[i, currentY] != null)
            {
                // if different team
                if (board[i, currentY].team != team)
                    r.Add(new Vector2Int(i, currentY));
                break;
            }
            else
                r.Add(new Vector2Int(i, currentY));

        //left
        for (int i = currentX - 1; i >= 0; i--)
            if (board[i, currentY] != null)
            {
                // if different team
                if (board[i, currentY].team != team)
                    r.Add(new Vector2Int(i, currentY));
                break;
            }
            else
                r.Add(new Vector2Int(i, currentY));

        //up
        for (int i = currentY + 1; i < tileCountY; i++)
            if (board[currentX, i] != null)
            {
                // if different team
                if (board[currentX, i].team != team)
                    r.Add(new Vector2Int(currentX, i));
                break;
            }
            else
                r.Add(new Vector2Int(currentX, i));

        //down
        for (int i = currentY - 1; i >= 0; i--)
            if (board[currentX, i] != null)
            {
                // if different team
                if (board[currentX, i].team != team)
                    r.Add(new Vector2Int(currentX, i));
                break;
            }
            else
                r.Add(new Vector2Int(currentX, i));



        // top right
        for (int x = currentX + 1, y = currentY + 1; x < tileCountX && y < tileCountY; x++, y++)
            if (board[x, y] != null)
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));
                break;
            }
            else
                r.Add(new Vector2Int(x, y));

        // top left
        for (int x = currentX - 1, y = currentY + 1; x >= 0 && y < tileCountY; x--, y++)
            if (board[x, y] != null)
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));
                break;
            }
            else
                r.Add(new Vector2Int(x, y));

        // bottom right
        for (int x = currentX + 1, y = currentY - 1; x < tileCountX && y >= 0; x++, y--)
            if (board[x, y] != null)
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));
                break;
            }
            else
                r.Add(new Vector2Int(x, y));

        // bottom left
        for (int x = currentX - 1, y = currentY - 1; x >= 0 && y >= 0; x--, y--)
            if (board[x, y] != null)
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));
                break;
            }
            else
                r.Add(new Vector2Int(x, y));



        return r;
    }
}