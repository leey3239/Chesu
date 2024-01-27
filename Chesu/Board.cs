using System;
using static Piece;

public class Board
{
    Cell[][] Cells;

    public Board()
    {
  
    }

    public Cell getCell(int x, int y)
    {
        return Cells[x][y];
    }

    public void resetBoard()
    {
        
        Cells[0][0] = new Cell(new Tuple<int, int>(0, 0), new Rook(true));
        Cells[1][0] = new Cell(new Tuple<int, int>(1, 0), new Knight(true));
        Cells[2][0] = new Cell(new Tuple<int, int>(2, 0), new Bishop(true));
        Cells[3][0] = new Cell(new Tuple<int, int>(3, 0), new Queen(true));
        Cells[4][0] = new Cell(new Tuple<int, int>(4, 0), new King(true));
        Cells[5][0] = new Cell(new Tuple<int, int>(5, 0), new Bishop(true));
        Cells[6][0] = new Cell(new Tuple<int, int>(6, 0), new Knight(true));
        Cells[7][0] = new Cell(new Tuple<int, int>(7, 0), new Rook(true));

        Cells[0][1] = new Cell(new Tuple<int, int>(0, 1), new Pawn(true));
        Cells[1][1] = new Cell(new Tuple<int, int>(1, 1), new Pawn(true));
        Cells[2][1] = new Cell(new Tuple<int, int>(2, 1), new Pawn(true));
        Cells[3][1] = new Cell(new Tuple<int, int>(3, 1), new Pawn(true));
        Cells[4][1] = new Cell(new Tuple<int, int>(4, 1), new Pawn(true));
        Cells[5][1] = new Cell(new Tuple<int, int>(5, 1), new Pawn(true));
        Cells[6][1] = new Cell(new Tuple<int, int>(6, 1), new Pawn(true));
        Cells[7][1] = new Cell(new Tuple<int, int>(7, 1), new Pawn(true));

        Cells[0][7] = new Cell(new Tuple<int, int>(0, 7), new Rook(false));
        Cells[1][7] = new Cell(new Tuple<int, int>(1, 7), new Knight(false));
        Cells[2][7] = new Cell(new Tuple<int, int>(2, 7), new Bishop(false));
        Cells[3][7] = new Cell(new Tuple<int, int>(3, 7), new Queen(false));
        Cells[4][7] = new Cell(new Tuple<int, int>(4, 7), new King(false));
        Cells[5][7] = new Cell(new Tuple<int, int>(5, 7), new Bishop(false));
        Cells[6][7] = new Cell(new Tuple<int, int>(6, 7), new Knight(false));
        Cells[7][7] = new Cell(new Tuple<int, int>(7, 7), new Rook(false));
        
        Cells[0][6] = new Cell(new Tuple<int, int>(0, 6), new Pawn(false));
        Cells[1][6] = new Cell(new Tuple<int, int>(1, 6), new Pawn(false));
        Cells[2][6] = new Cell(new Tuple<int, int>(2, 6), new Pawn(false));
        Cells[3][6] = new Cell(new Tuple<int, int>(3, 6), new Pawn(false));
        Cells[4][6] = new Cell(new Tuple<int, int>(4, 6), new Pawn(false));
        Cells[5][6] = new Cell(new Tuple<int, int>(5, 6), new Pawn(false));
        Cells[6][6] = new Cell(new Tuple<int, int>(6, 6), new Pawn(false));
        Cells[7][6] = new Cell(new Tuple<int, int>(7, 6), new Pawn(false));
        

        
    }
}