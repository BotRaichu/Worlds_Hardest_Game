using Timer = System.Windows.Forms.Timer;
using ANP_Semesterprojekt.GameLogic;
using ANP_Semesterprojekt.GameLogic.Level;
namespace ANP_Semesterprojekt;

public partial class Form1 : Form
{
    const int MAXLEVEL = 4;
    const int DIFFTOWALL = 100;
    public const int WALLSTANDARDWIDTH = 5;
    private int _level;
    int currLevel = 1;

    Timer _tmrMoveEnemy = new Timer() { Interval = 200, Enabled = true };
    Timer _tmrMovePlayer = new Timer() { Interval = 500, Enabled = true };


    private int Level
    {
        get { return _level; }

        set
        {
            _level = value;
            Text = "Level: " + value + "/" + MAXLEVEL;



        }
    }

    List<Coin> coins = new List<Coin>();
    Player player = new Player();
    List<Enemy> enemys = new List<Enemy>();
    List<SpawnArea> spawnAreas = new List<SpawnArea>();
    List<Wall> walls = new List<Wall>();

    Level level = new Level();



    public Form1()
    {
        InitializeComponent();
        Level = 1;
        player.Location = player.STARTPOINT = new Point(130, 240);
        // Hier Levels hinzufügen, jenachdem wie viele Enemys oder Coins, es sein sollen einfach die Zeile duplizieren, und mit der Position musst du rumprobieren
        MaximizeBox = false;
        FormBorderStyle = FormBorderStyle.FixedSingle; 
        InitGame();
       // InitLevel();
        ControlsAdd();

        // Idee: Wenn Spieler ein Level erledigt wird die ganze Liste gelöscht und wieder neu überschrieben mit den Daten aus Level2 usw
        // Idee: Eine Oberklasse mit Level und alle Level X erben von dieser Klasse. Ergebnis: Soll Duplikate verhindern

        _tmrMoveEnemy.Tick += TmrMoveEnemy_Tick;
        KeyDown += Form1_KeyDown;
    }

    // Wenn du ein Level gebaut hast, kopier den Code von der Zeile 50 in diese Methode in die jeweilige Region 
    public void InitLevel()
    {
        
        if (currLevel == 1)
        {          
           #region LEVEL1BUILD
            // Zuweisungen verbessern


            #region LEVEL



            #region ENEMYS

            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 - 50, 250, false);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 - 50, 350, false);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 + 50, 450, false);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 + 55, 450, true);

            #endregion
            #region WALLS

            // Horizontal

            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 100, WALLSTANDARDWIDTH, ClientSize.Height / 2 - 50, DIFFTOWALL);
            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 100, WALLSTANDARDWIDTH, ClientSize.Height / 2 + 100, DIFFTOWALL);

            // Vertical
            walls = level.CreateWall(WALLSTANDARDWIDTH, 155, ClientSize.Height / 2 - 50, ClientSize.Width - DIFFTOWALL);
            walls = level.CreateWall(WALLSTANDARDWIDTH, 2152, ClientSize.Height / 2 - 50, DIFFTOWALL);
            #endregion


            #region COINS
            coins = level.CreateCoin(20, 20, ClientSize.Height / 2 - 50, DIFFTOWALL + 100);

            #endregion

            #region SPAWNENDPOINTS

            spawnAreas = level.CreateSpawnEndArea(75, 155, ClientSize.Height / 2 - 50, DIFFTOWALL);
            spawnAreas = level.CreateSpawnEndArea(75, 155, ClientSize.Height / 2 - 50, ClientSize.Width - DIFFTOWALL - 75);
            #endregion
            #endregion

            #endregion
        }
        ++currLevel;
        if (currLevel== 2)
        {
            
            #region LEVEL2BUILD
            #region ENEMYS
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 - 50, 250, false);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 - 50, 350, false);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 + 50, 450, false);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 + 55, 450, true);

            #endregion
            #region WALLS

            // Horizontal

            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 100, WALLSTANDARDWIDTH, ClientSize.Height / 2 - 50, DIFFTOWALL);
            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 100, WALLSTANDARDWIDTH, ClientSize.Height / 2 + 100, DIFFTOWALL);

            // Vertical
            walls = level.CreateWall(WALLSTANDARDWIDTH, 155, ClientSize.Height / 2 - 50, ClientSize.Width - DIFFTOWALL);
            walls = level.CreateWall(WALLSTANDARDWIDTH, 152, ClientSize.Height / 2 - 50, DIFFTOWALL);
            #endregion


            #region COINS
            coins = level.CreateCoin(20, 20, ClientSize.Height / 2 - 50, DIFFTOWALL + 100);
            coins = level.CreateCoin(20, 20, ClientSize.Height / 2 - 50, DIFFTOWALL + 100);

            #endregion

            #region SPAWNENDPOINTS

            spawnAreas = level.CreateSpawnEndArea(75, 155, ClientSize.Height / 2 - 50, DIFFTOWALL);
            spawnAreas = level.CreateSpawnEndArea(75, 155, ClientSize.Height / 2 - 50, ClientSize.Width - DIFFTOWALL - 75);
            #endregion
            #endregion
        }
        if (currLevel == 3)
        {        
            #region LEVEL3BUILD
            #region ENEMYS
            //enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 - 50, 250, false);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 + 50, 100, true);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 + 20, 150, true);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 - 30, 450, true);

            #endregion
            #region WALLS

            // Horizontal

            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 600, WALLSTANDARDWIDTH, ClientSize.Height / 2 - 150, DIFFTOWALL);
            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 200, WALLSTANDARDWIDTH, ClientSize.Height / 2 - 50, DIFFTOWALL + 100);
            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 200, WALLSTANDARDWIDTH, ClientSize.Height / 2 + 100, DIFFTOWALL + 100);
            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 600, WALLSTANDARDWIDTH, ClientSize.Height / 2 + 150, DIFFTOWALL);
            //walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 100, WALLSTANDARDWIDTH, ClientSize.Height / 2 + 100, DIFFTOWALL);

            // Vertical
            walls = level.CreateWall(WALLSTANDARDWIDTH, 155, ClientSize.Height / 2 - 50, ClientSize.Width - DIFFTOWALL);
            walls = level.CreateWall(WALLSTANDARDWIDTH, 300, ClientSize.Height / 2 - 150, DIFFTOWALL);
            walls = level.CreateWall(WALLSTANDARDWIDTH, 100, ClientSize.Height / 2 - 150, DIFFTOWALL + 100);
            walls = level.CreateWall(WALLSTANDARDWIDTH, 55, ClientSize.Height / 2 + 100, DIFFTOWALL + 100);
            #endregion


            #region COINS
            coins = level.CreateCoin(20, 20, ClientSize.Height / 2 - 30, DIFFTOWALL + 550);
            coins = level.CreateCoin(20, 20, ClientSize.Height / 2 + 50, DIFFTOWALL + 550);
            coins = level.CreateCoin(20, 20, ClientSize.Height / 2 + 20, DIFFTOWALL + 250);

            #endregion

            #region SPAWNENDPOINTS

            spawnAreas = level.CreateSpawnEndArea(100, 105, ClientSize.Height / 2 - 150, DIFFTOWALL);
            spawnAreas = level.CreateSpawnEndArea(100, 55, ClientSize.Height / 2 + 100, DIFFTOWALL);
            player.Location = player.STARTPOINT = new Point(140, 100);
            #endregion
            #endregion
        }
        if (currLevel  == 4)
        {   
            #region LEVEL4BUILD
            #region ENEMYS
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 - 150, 150, true);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 - 50, 350, true);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 + 50, 670, false);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 + 10, 610, false);
            enemys = level.CreateEnemy(20, 20, ClientSize.Height / 2 + 55, 550, true);

            #endregion
            #region WALLS

            // Horizontal

            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 100, WALLSTANDARDWIDTH, ClientSize.Height / 2 - 180, DIFFTOWALL);
            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 100, WALLSTANDARDWIDTH, ClientSize.Height / 2 + 165, DIFFTOWALL);
            walls = level.CreateWall(ClientSize.Width - DIFFTOWALL - 225, WALLSTANDARDWIDTH, ClientSize.Height / 2 + 10, DIFFTOWALL);
            // Vertical
            walls = level.CreateWall(WALLSTANDARDWIDTH, 350, ClientSize.Height / 2 - 180, ClientSize.Width - DIFFTOWALL);
            walls = level.CreateWall(WALLSTANDARDWIDTH, 350, ClientSize.Height / 2 - 180, DIFFTOWALL);
            #endregion


            #region COINS
            coins = level.CreateCoin(20, 20, ClientSize.Height / 2 + 100, DIFFTOWALL + 540);
            coins = level.CreateCoin(20, 20, ClientSize.Height / 2 - 50, DIFFTOWALL + 500);

            #endregion

            #region SPAWNENDPOINTS

            spawnAreas = level.CreateSpawnEndArea(75, 190, ClientSize.Height / 2 - 180, DIFFTOWALL);
            spawnAreas = level.CreateSpawnEndArea(75, 190, ClientSize.Height / 2 - 20, ClientSize.Width - DIFFTOWALL - 600);
            player.Location = player.STARTPOINT = new Point(125, 120);
            #endregion
            #endregion
        }


    }
    private void TmrMoveEnemy_Tick(object? sender, EventArgs e)
    {
        foreach (Enemy enemy in enemys)
        {
            enemy.MoveEnemy(walls, ClientSize);
        }


    }

    public void ControlsRemove()
    {
        #region CONTROLSREMOVE
        Controls.Remove(player);

        foreach (Wall wall in walls)
        {
            Controls.Remove(wall);
        }
        foreach (Enemy enemy in enemys)
        {
            Controls.Remove(enemy);
        }
        foreach (Coin coin in coins)
        {
            Controls.Remove(coin);
        }
        foreach (SpawnArea area in spawnAreas)
        {
            Controls.Remove(area);
        }
        #endregion

    }
    public void ControlsAdd()
    {
        #region CONTROLSADD

        Controls.Add(player);
        foreach (Wall wall in walls)
        {
            Controls.Add(wall);
        }
        foreach (Enemy enemy in enemys)
        {
            Controls.Add(enemy);
        }
        foreach (Coin coin in coins)
        {
            Controls.Add(coin);
        }
        foreach (SpawnArea area in spawnAreas)
        {
            Controls.Add(area);
        }
        #endregion
    }

    public void ClearList()
    {
        enemys.Clear();
        walls.Clear();
        coins.Clear();
        spawnAreas.Clear();
    }

    public void InitGame()
    {
        _tmrMoveEnemy.Enabled = _tmrMovePlayer.Enabled = true;
        InitLevel();
        ControlsAdd();
    }

    private void Form1_KeyDown(object? sender, KeyEventArgs e)
    {
        player.MovePlayer(e);
        
        // TEST TEXT
        //Text = "Level: " + _level + "/" + MAXLEVEL + " " + player.Left+  player.Location+ spawnAreas[1].Left + spawnAreas[1].Location + "   "/* + coins[0].Location*/;


        Text = "Level: " + _level + "/" + MAXLEVEL +  " " + coins.Count;
        foreach (Wall wall in walls)
        {
            if (player.Bounds.IntersectsWith(wall.Bounds))
            {
                player.CheckCollisionPlayerWithWall(wall, e, ClientSize);
            }
        }

        foreach (Enemy enemy in enemys)
            if (player.CheckCollisionPlayerWithEnemy(enemy))
            {
                player.Location = new Point(player.STARTPOINT.X, player.STARTPOINT.Y);
                Text = "Level: " + currLevel+ "/" + MAXLEVEL ;
                foreach (Coin coin in coins)
                {
                    Controls.Add(coin);
                }
            }
                

        try
        {
            //Überprüfung ob Spieler alle Coins gesammelt hat und am Endpoint ist

            foreach (Coin coin in coins)
                if (player.PlayerCollectCoin(coin))
                    Controls.Remove(coin);

            foreach (Control cntrl in Controls)
            {
                // TODO: Player Location equals area Location
                // TODO: AREA TO BE DONE WHERE PLAYER STARTS AND HAS TO END
                if (!Controls.OfType<Coin>().Any() && spawnAreas[1].TouchPlayer(player))
                {
                    


                    if (Level != MAXLEVEL)
                    {
                        ++Level;
                        ControlsRemove();
                        ClearList();
                        _tmrMoveEnemy.Enabled = _tmrMovePlayer.Enabled = false;
                        InitGame();

                    }

                    if (Level > MAXLEVEL)
                        Close();

                }


            }
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
        }

    }



}