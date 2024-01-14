

namespace ANP_Semesterprojekt.GameLogic;

public class SpawnArea : GameObject
{

    public SpawnArea(int width, int height, int top, int left)
    {
        Width = width; Height = height;
        Top = top; Left = left;
        BackColor = Color.LimeGreen;
    }

    public bool TouchPlayer(Player player)
    {
        if (Bounds.IntersectsWith(player.Bounds))
        {
            return true;
        }
        return false;

    }
}
