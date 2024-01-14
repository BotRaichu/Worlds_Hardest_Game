
namespace ANP_Semesterprojekt.GameLogic;

public class Coin : GameObject
{


    public Coin(int width, int height, int top, int left)
    {
        Width = 20; Height = 20; 
        Top = top; Left = left;
        BackColor = Color.Yellow;
    }

}
