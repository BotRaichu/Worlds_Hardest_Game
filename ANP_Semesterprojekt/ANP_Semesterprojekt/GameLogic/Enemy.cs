using ANP_Semesterprojekt.GameLogic;
using System;

namespace ANP_Semesterprojekt;

public class Enemy : GameObject
{
    int _xMovingDirection = 20;
    int _yMovingDirection = 20;
    bool _isHorizontal;
    public Enemy(int width, int height, int top, int left, bool isHorizontal)
    {

        Width = width;
        Height = height;
        Top = top;
        Left = left;
        _isHorizontal = isHorizontal;
        BackColor = Color.Blue;
        
    }

    public void MoveEnemy(List<Wall> walls,  Size formsize)
    {

        // Left += _xMovingDirection;
        if (_isHorizontal)
        {
            Left += _xMovingDirection;

            foreach (Wall wall in walls)
            {

                if (CheckCollisionWithWall(wall) || Left + _xMovingDirection < 0 || Right + _xMovingDirection > formsize.Width)
                {
                    _xMovingDirection *= -1;
                }
            }
        }
        else
        {
            Top += _yMovingDirection;
            foreach (Wall wall in walls)
            {

                if (CheckCollisionWithWall(wall) || Top + _yMovingDirection < 0 || Bottom + _yMovingDirection > formsize.Height)
                {
                    _yMovingDirection *= -1;
                }

            }

        }

    }

    

    public bool CheckCollisionWithWall(Wall wall)
    {

        return Bounds.IntersectsWith(wall.Bounds) || Bottom  == wall.Top || Top  == wall.Bottom
            || Left  == wall.Right
            || Right == wall.Left;



    }

}
