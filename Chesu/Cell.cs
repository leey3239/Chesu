using System;
public class Cell
{
    private Piece _piece;
    private Tuple<int, int> _cords;

    public Cell(Tuple<int, int> cords, Piece piece)
    {
        _cords = cords;
        _piece = piece;
    }

    public Cell(Tuple<int, int> cords)
    {
        _cords = cords;
        _piece = null;
    }

    public Piece GetPiece()
    {
        return _piece;
    }

    public void SetPiece(Piece piece)
    {
        _piece = piece;
    }

    public Tuple<int, int> GetCords()
    {
        return _cords;
    }
    public void SetCords(Tuple<int, int> cords)
    {
        this._cords = cords;
    }

}