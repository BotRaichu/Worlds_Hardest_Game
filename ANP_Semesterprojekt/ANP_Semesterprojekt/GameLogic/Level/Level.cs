namespace ANP_Semesterprojekt.GameLogic.Level;

public class Level
{
    //Timer _tmrMoveEnemy = new Timer();
    public const int WALLSTANDARDWIDTH = 5;
    public const int DIFFTOWALL = 100;
    public int CoinNum;


    public List<Coin> coins = new List<Coin>();
    public List<Enemy> enemys = new List<Enemy>();
    public List<SpawnArea> spawnAreas = new List<SpawnArea>();

    public List<Wall> walls = new List<Wall>();


    public List<Wall> CreateWall(int width, int height, int top, int left)
    {
        Wall wall = new Wall(width, height, top, left)
        {
            Width = width,
            Height = height,
            Top = top,
            Left = left
        };


        walls.Add(wall);
        return walls;
    }
    public List<Enemy> CreateEnemy(int width, int height, int top, int left, bool isHorizontal)
    {
        Enemy enemy = new Enemy(width, height, top, left, isHorizontal)
        {
            Width = width,
            Height = height,
            Top = top,
            Left = left,
        };
        enemys.Add(enemy);
        
        return enemys;
    }

    public List<Coin> CreateCoin(int width, int height, int top, int left)
    {
        Coin coin = new Coin(width, height, top, left)
        {
            Width =width,
            Height = height,
            Top = top,
            Left = left
        };
        coins.Add(coin);
        return coins;
    }
    public List<SpawnArea> CreateSpawnEndArea(int width, int height, int top, int left)
    {
        SpawnArea spawnArea= new SpawnArea(width, height, top, left)
        {
            Width=width,
            Height=height,
            Top = top,
            Left = left
        };
        spawnAreas.Add(spawnArea);
        return spawnAreas;
    }


    /*public void InitLevel1(Size formSize )
    {
        #region LEVEL1

        #region ENEMYS
        enemys =  CreateEnemy(20, 20, formSize.Height / 2 - 50, 250, false);
        enemys =  CreateEnemy(20, 20, formSize.Height / 2 - 50, 350, false);
        enemys =  CreateEnemy(20, 20, formSize.Height / 2 + 50, 450, false);
        
        #endregion
        #region WALLS
        //walls = (formSize);

        // Horizontal

        walls =  CreateWall(formSize.Width - DIFFTOWALL - 100, WALLSTANDARDWIDTH, formSize.Height / 2 - 50, DIFFTOWALL);
        walls =  CreateWall(formSize.Width - DIFFTOWALL - 100, WALLSTANDARDWIDTH, formSize.Height / 2 + 100, DIFFTOWALL);

        // Vertical
        walls =  CreateWall(WALLSTANDARDWIDTH, 155, formSize.Height / 2 - 50, formSize.Width - DIFFTOWALL);
        walls =  CreateWall(WALLSTANDARDWIDTH, 152, formSize.Height / 2 - 50, DIFFTOWALL);
        #endregion


        #region COINS
        coins =  CreateCoin(20, 20, formSize.Height / 2 - 50, DIFFTOWALL + 100);
        coins =  CreateCoin(20, 20, formSize.Height / 2 - 50, DIFFTOWALL + 100);

        #endregion

        #region SPAWNENDPOINTS

        spawnAreas =  CreateSpawnEndArea(75, 155, formSize.Height / 2 - 50, DIFFTOWALL);
        spawnAreas =  CreateSpawnEndArea(75, 155, formSize.Height / 2 - 50, formSize.Width - DIFFTOWALL - 75);
        #endregion
        #endregion
    }*/
}
