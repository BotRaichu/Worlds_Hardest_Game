

namespace ANP_Semesterprojekt.GameLogic;

public class Player : GameObject
{
    public int _xMovingpixel = 10;
    public int _yMovingpixel = 10;

    public Point STARTPOINT; 
    public Player()
    {
        Width = 25; Height = 25;
        BackColor = Color.Red;
        //Location = new Point(ClientSize.Width * 2);
        Location = new Point(STARTPOINT.X, STARTPOINT.Y);

    }


    public void MovePlayer(KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.W:
            case Keys.Up:
                Top -= (_yMovingpixel);
                break;
            case Keys.A:
            case Keys.Left:
                Left -= (_yMovingpixel);
                break;
            case Keys.S:
            case Keys.Down:
                Top += (_yMovingpixel);
                break;

            case Keys.D:
            case Keys.Right:
                Left += (_yMovingpixel);
                break;

            default: break;

        }

    }
    public void MovePlayer(KeyEventArgs e, Size formSize)
    {
        switch (e.KeyCode)
        {
            case Keys.W:
            case Keys.Up:
                Top = Top - _yMovingpixel < 0 ? 0 : Top - _yMovingpixel;
                break;
            case Keys.A:
            case Keys.Left:
                Left = Left - _xMovingpixel < 0 ?
                        0 : Left - _xMovingpixel;
                break;

            case Keys.S:
            case Keys.Down:
                Top = Bottom + _yMovingpixel > formSize.Height ?
                    formSize.Height - Height : Top + _yMovingpixel;
                break;

            case Keys.D:
            case Keys.Right:
                Left = Right + _xMovingpixel > formSize.Width ?
                        formSize.Width - Width : Left + _xMovingpixel;
                break;

            default: break;

        }


    }

    public bool CheckCollisionPlayerWithEnemy(Enemy enemy)
    {
        return Bounds.IntersectsWith(enemy.Bounds);
    }
    public void CheckCollisionPlayerWithWall(Wall wall, KeyEventArgs e, Size formSize)
    {

        switch (e.KeyCode)
        {
            case Keys.W:
            case Keys.Up:
                Top = Top - _yMovingpixel < 0 ? wall.Bottom : wall.Bottom;
                break;
            case Keys.A:
            case Keys.Left:
                Left = Left - _xMovingpixel < 0 ?
                        wall.Right : wall.Right;
            break;
            case Keys.S:
            case Keys.Down:
                if (Bottom + _yMovingpixel > wall.Top)
                {
                    Top = wall.Top -Height;
                }
                //Top = Bottom + _yMovingpixel > wall.Top ?
                    //wall.Top : wall.Top;
                break;
            case Keys.D:
            case Keys.Right:
                Left = Right + _xMovingpixel > wall.Left?
                        wall.Left - Width : Left + _xMovingpixel;
            break;
            default: break;
        }

    }

    public bool PlayerCollectCoin(Coin coin)
    {
        if (Bounds.IntersectsWith(coin.Bounds))
        {
            return true;
        }
        return false;        
    }



}
