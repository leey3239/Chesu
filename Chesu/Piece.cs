using System;

public abstract class Piece
{
    private bool _colour; //1 is WHITE 0 is BLACK
    private bool _dead;
    public Piece(bool colour)
    {
        _colour = colour;
    }
    public bool GetColour()
    {
        return _colour;
    }
    public void SetColour(bool colour)
    {
        _colour = colour;
    }
    public bool GetDead()
    {
        return _dead;
    }
    public void SetDead(bool dead)
    {
        _dead = dead;
    }
}