using Timer = System.Windows.Forms.Timer;
namespace ANP_Semesterprojekt.GameLogic;

public class Wall : GameObject
{
    Timer _tmrMoveEnemy = new Timer();
    public Wall(int width, int height, int top, int left)
    {

        Width = width;
        Height = height;
        Top = top;
        Left = left;
        BackColor = Color.Black;


    }

}
