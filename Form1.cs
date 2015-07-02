//Paulo Santiago
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Culminating
{
    public partial class Form1 : Form
    {
        Image kyubeyAnimation, kyokoAnimation, sayakaAnimation;
        
        //Setting images to an array for the animations
        Bitmap[] kyubeySprite = {   Culminating.Properties.Resources.Kyubey1,
                                 Culminating.Properties.Resources.Kyubey2,
                                 Culminating.Properties.Resources.Kyubey3,
                                 Culminating.Properties.Resources.Kyubey4, 
                                 Culminating.Properties.Resources.Kyubey5, 
                                 Culminating.Properties.Resources.Kyubey6, 
                                 Culminating.Properties.Resources.Kyubey7 };

        Bitmap healthPic = Culminating.Properties.Resources.Health;

        Bitmap[] kyokoSprite = {  Culminating.Properties.Resources.Kyoko1,
                            Culminating.Properties.Resources.Kyoko2,
                            Culminating.Properties.Resources.Kyoko3,
                            Culminating.Properties.Resources.Kyoko4,
                            Culminating.Properties.Resources.Kyoko5,
                            Culminating.Properties.Resources.Kyoko6,
                            Culminating.Properties.Resources.Kyoko7,
                            Culminating.Properties.Resources.Kyoko8 };

        Bitmap[] sayakaSprite = { Culminating.Properties.Resources.Sayaka1,
                                Culminating.Properties.Resources.Sayaka2,
                                Culminating.Properties.Resources.Sayaka3,
                                Culminating.Properties.Resources.Sayaka4,
                                Culminating.Properties.Resources.Sayaka5,
                                Culminating.Properties.Resources.Sayaka6,
                                Culminating.Properties.Resources.Sayaka7,
                                Culminating.Properties.Resources.Sayaka8,
                                Culminating.Properties.Resources.Sayaka9,
                                Culminating.Properties.Resources.Sayaka10,
                                Culminating.Properties.Resources.SayakaA1,
                                Culminating.Properties.Resources.SayakaA2,
                                Culminating.Properties.Resources.SayakaA3,
                                Culminating.Properties.Resources.SayakaA4,
                                Culminating.Properties.Resources.SayakaA5,
                                Culminating.Properties.Resources.SayakaA6,
                                Culminating.Properties.Resources.SayakaA7,
                                Culminating.Properties.Resources.SayakaA8,
                                Culminating.Properties.Resources.SayakaA9,
                                Culminating.Properties.Resources.SayakaA10,
                                Culminating.Properties.Resources.SayakaB1,
                                Culminating.Properties.Resources.SayakaB2,
                                Culminating.Properties.Resources.SayakaB3,
                                Culminating.Properties.Resources.SayakaB4,
                                Culminating.Properties.Resources.SayakaB5,
                                Culminating.Properties.Resources.SayakaB6,
                                Culminating.Properties.Resources.SayakaB7,
                                Culminating.Properties.Resources.SayakaB8,
                                Culminating.Properties.Resources.SayakaB9,
                                Culminating.Properties.Resources.SayakaB10,
                                Culminating.Properties.Resources.SayakaB11,
                                Culminating.Properties.Resources.SayakaB12,
                                Culminating.Properties.Resources.SayakaR1,
                                Culminating.Properties.Resources.SayakaR2,
                                Culminating.Properties.Resources.SayakaR3,
                                Culminating.Properties.Resources.SayakaR4,
                                Culminating.Properties.Resources.SayakaR5,
                                Culminating.Properties.Resources.SayakaR6,
                                Culminating.Properties.Resources.SayakaR7,
                                Culminating.Properties.Resources.SayakaR8};


        //Booleans
        bool menu = true, game=false;
        bool runFWD = true, move = true, enbShoot=true, shoot = false, enbCharge=false, charge = false, maxStam=false;
        bool moveUp = false, moveDown = false, moveLeft = false, moveRight = false;
        //bool hSpawn = false;
        bool kyokoSpawn = false, kyokoAtt = false;
        bool sayakaSpawn=false, sayakaIdle=true, sayakaIdleAn=true, sayakaAttack1=false, sayakaAttack1An=false, sayakaAttack2=false, sayakaAttack2An=false;

        //Point Locations
        Point kyubeyLoc;
        Point kyokoLoc;
        Point sayakaLoc;
        Point sayakaRALoc;

        Point[] eLoc= new Point[50];
        Point[] debrisLoc = new Point[25];

        Point bulletLoc, chargeLoc;
        Point hLoc;


        //Int Values
        int sprite = 0, ndx = 0, kyoNdx = 0, sayNdx = 0;
        int kyubeyWidth = 68, kyubeyHeight = 41;
        int kyoW = 187, kyoH = 105;
        int sayW, sayH, sayIW = 95, sayIH = 95, xRate = 4, yRate = 4;

        int score;

        int eSize = 7, dSize = 25, bSizeX=21, bSizeY=7;//, cSizeX;//, cSizeY=5;

        int bgMoveInt=4;

        //Brush colours
        SolidBrush bulletColour = new SolidBrush(Color.FromArgb(255, 243, 62, 62)),
                   transparent = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
        SolidBrush debrisVar;
        SolidBrush debrisColour = new SolidBrush(Color.FromArgb(255, 255, 255));
        SolidBrush kyoDColour = new SolidBrush(Color.FromArgb(251, 51, 51)), sayColor = new SolidBrush(Color.FromArgb(111, 88, 255));

        Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Setting random spawnpoints of the background
            randomize();

            menuLoad();

            //Plays and loops audio
            //Could possibly be creating the crashes? Disabled
            //System.Media.SoundPlayer BGM = new System.Media.SoundPlayer(Culminating.Properties.Resources._15_I_remember);
            //BGM.PlayLooping();
        }

        private void menuLoad()
        {
            //Disabling text and pictureboxes when the menu loads
            game = false;
            menu = true;

            lblPlay.Enabled = true;
            lblPlay.Visible = true;
            lblTutorial.Enabled = true;
            lblTutorial.Visible = true;
            pbW.Visible = true;
            pbA.Visible = true;
            pbS.Visible = true;
            pbD.Visible = true;
            pbMouse.Visible = true;
            

            pgbHealth.Visible = false;
            pgbEnemyHealth.Visible = false;
            pbStamina.Visible = false;
            pbStaminaBack.Visible = false;
            pgbHealth.Value = 0;
            pgbEnemyHealth.Value = 0;
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            //Enables disables texts and pictureboxes
            menu = false;
            game = true;

            lblPlay.Enabled = false;
            lblPlay.Visible = false;
            lblTutorial.Enabled = false;
            lblTutorial.Visible = false;
            pbW.Visible = false;
            pbA.Visible = false;
            pbS.Visible = false;
            pbD.Visible = false;
            pbMouse.Visible = false;

            gameLoad();
        }

        private void gameLoad()
        {

            game = true;
            menu = false;
            //Setting the sprite to an initial image
            kyubeyAnimation = kyubeySprite[0];
            kyokoAnimation = kyokoSprite[0];
            sayakaAnimation = sayakaSprite[32];

            //Set Stamina Value to 0
            pbStamina.Width = 0;

            //Set score to 0
            score = 0;

            //Setting Bosses to not spawn
            kyokoSpawn = false;
            sayakaSpawn = false;


            //Setting random spawnpoints of the background
            randomize();

            //Setting the visibility of progress bars
            pgbHealth.Visible = true;
            pbStamina.Visible = true;
            pbStaminaBack.Visible = true;

            //Setting the value of healths
            pgbHealth.Value = 100;
            pgbEnemyHealth.Value = 100;

            //Setting the spawn location of the characters
            kyubeyLoc.X = (pbArena.Size.Width / 2) - kyubeyWidth / 2;
            kyubeyLoc.Y = (pbArena.Size.Height / 2) - kyubeyHeight / 2;

            kyokoLoc.X = pbArena.Size.Width - kyoW;
            kyokoLoc.Y = (pbArena.Size.Height / 2) - kyoH / 2;

            sayakaLoc.X = pbArena.Size.Width - sayIW;
            sayakaLoc.Y = (pbArena.Size.Height / 2) - sayIH / 2;

            debrisVar = debrisColour;
        }

        private void pbArena_Paint(object sender, PaintEventArgs e)
        {

            // If the menu or game is loaded, there will still be a background
            if (menu == true || game == true)
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(150, 250, 128, 114));

                for (ndx = 0; ndx < 49; ndx++)
                {
                    e.Graphics.FillEllipse(brush, eLoc[ndx].X, eLoc[ndx].Y, eSize, eSize);
                }
            }

            //If the game is loaded, different comands will draw different things
            if (game == true)
            {
                if (shoot == true)
                    e.Graphics.FillEllipse(bulletColour, bulletLoc.X, bulletLoc.Y, bSizeX, bSizeY);

                //Extra attack that was not implemented
                //if (charge == true)
                //    e.Graphics.DrawImage(Culminating.Properties.Resources.laserBeam, chargeLoc.X, chargeLoc.Y, cSizeX, 150);


                //Draws circle attacks
                for (ndx = 0; ndx < 25; ndx++)
                    e.Graphics.FillEllipse(debrisVar, debrisLoc[ndx].X, debrisLoc[ndx].Y, dSize, dSize);

                //Health item that was not implemented
                //if (hSpawn == true)
                //    e.Graphics.DrawImage(healthPic, hLoc.X, hLoc.Y, 20, 20);

                //Enemy health becomes visible, debris colour changes and draws the boss
                if (kyokoSpawn == true)
                {
                    pgbEnemyHealth.Visible = true;
                    debrisVar = kyoDColour;
                    e.Graphics.DrawImage(kyokoAnimation, kyokoLoc.X, kyokoLoc.Y, kyoW, kyoH);
                }

                //Spawns second boss
                if (sayakaSpawn == true)
                {
                    //Enemy health and colour becomes visible and changes
                    pgbEnemyHealth.Visible = true;
                    debrisVar = sayColor;
                    
                    //Changes size of the boss to the sprite sizes
                    if (sayakaIdleAn == true)
                    {
                        sayW = 95;
                        sayH = 95;
                    }

                    if (sayakaAttack1An == true)
                    {
                        sayW = 124;
                        sayH = 103;
                    }

                    if (sayakaAttack2An == true)
                    {
                        sayW = 103;
                        sayH = 123;
                    }

                    //Spawns the range attack if she performs it
                    if (sayakaAttack2 == true)
                        e.Graphics.DrawImage(Culminating.Properties.Resources.SayakaRA, sayakaRALoc.X, sayakaRALoc.Y, 165, 161);

                    e.Graphics.DrawImage(sayakaAnimation, sayakaLoc.X, sayakaLoc.Y, sayW, sayH);
                }

                //Draws main character
                e.Graphics.DrawImage(kyubeyAnimation, kyubeyLoc.X, kyubeyLoc.Y, kyubeyWidth, kyubeyHeight);
            }
                
               
        }

        private void randomize()
        {
            //Randomize BG Location
            for (ndx = 0; ndx < 49; ndx++)
           { 
                eLoc[ndx].X = rnd.Next(0, pbArena.Width);
                eLoc[ndx].Y = rnd.Next(0, pbArena.Height);
            }

            //Randomize Debris Location
            for (ndx = 0; ndx < 25; ndx++)
            {
                debrisLoc[ndx].X = pbArena.Width + rnd.Next(200,500);
                debrisLoc[ndx].Y = rnd.Next(0, pbArena.Height);
            }

            //Randomize health location
            hLoc.X = pbArena.Width + rnd.Next(200, 500);
            hLoc.Y = rnd.Next(0, pbArena.Height);

        }

        private void tmrMovement_Tick(object sender, EventArgs e)
        {
            
            //Moves the background
            for (ndx = 0; ndx < 49; ndx++)
            {
                eLoc[ndx].X -= bgMoveInt;

                if (eLoc[ndx].X <= 0)
                {
                    eLoc[ndx].Y = rnd.Next(0, pbArena.Height);
                    eLoc[ndx].X = pbArena.Width;
                }
            }

            //Moves debris
            for (ndx = 0; ndx < 25; ndx++)
            {
                debrisLoc[ndx].X -= 3;

                if (debrisLoc[ndx].X + eSize * 3 <= 0)
                {
                    debrisLoc[ndx].X = pbArena.Width + rnd.Next(200,500);
                    debrisLoc[ndx].Y = rnd.Next(0, pbArena.Height);
                }

                //Bullet collision with debris
                if (bulletLoc.Y +5 >= debrisLoc[ndx].Y && bulletLoc.Y + 5 <= debrisLoc[ndx].Y + dSize && bulletLoc.X >= debrisLoc[ndx].X && kyubeyLoc.X <= debrisLoc[ndx].X)
                {

                    if (maxStam == true)
                        enbShoot = false;
                    else
                        enbShoot = true;
                        
                    //Moves the bullet when it makes collision
                    bulletLoc.Y = 9999;

                    //Temporary Method of removing debris
                    debrisLoc[ndx].X = pbArena.Width + rnd.Next(200,500);
                    debrisLoc[ndx].Y = rnd.Next(0, pbArena.Height);
                }

                  //Kyubey Collision with debris
                if (kyubeyLoc.Y + kyubeyHeight >= debrisLoc[ndx].Y && kyubeyLoc.Y <= debrisLoc[ndx].Y + dSize && kyubeyLoc.X + kyubeyWidth >= debrisLoc[ndx].X && kyubeyLoc.X <= debrisLoc[ndx].X)
                {
                    try
                    {
                        pgbHealth.Value -= 2;
                    }
                    catch 
                    {
                        pgbHealth.Value = pgbHealth.Value;
                    }

                    debrisLoc[ndx].Y = 9999;
                }
            }

            //Moves Kyoko
            if (kyokoSpawn == true)
            {
                //If kyoko attacks, she dashes towards you
                if (kyokoAtt == true)
                {
                    kyokoLoc.X -= 37;

                    //Approximate hitbox of the spear, so only if you get hit by the spear, it will do damage
                    if (kyokoLoc.X <= kyubeyLoc.X + kyubeyWidth / 2 && kyokoLoc.Y +kyoH >= kyubeyLoc.Y && kyokoLoc.Y +kyoH/2 <=kyubeyLoc.Y + kyubeyHeight)
                    {
                        try
                        {
                            pgbHealth.Value -= 20;
                        }
                        catch
                        {
                            pgbHealth.Value = 0;
                        }
                    }
                }

                //Once she moves past you, she walks back
                if (kyokoLoc.X <= kyubeyLoc.X + kyubeyWidth / 2)
                    kyokoAtt = false;

                if (kyokoAtt == false)
                {
                    if (kyokoLoc.X <= pbArena.Size.Width - kyoW)
                        kyokoLoc.X += 3;

                    if (kyokoLoc.X >= pbArena.Size.Width - kyoW)
                    {
                        //SHe moves up/down to depending on your location to follow you
                        if (kyubeyLoc.Y <= kyokoLoc.Y + kyoH / 2)
                            kyokoLoc.Y -= 2;

                        if (kyubeyLoc.Y >= kyokoLoc.Y + kyoH / 2)
                            kyokoLoc.Y += 2;

                        //If her Y location is the same(or within a range of 2) she will perform an attack
                        //Height is divided by 2 to align sprite better
                        if (kyubeyLoc.Y <= kyokoLoc.Y + kyoH / 2 + 2 && kyubeyLoc.Y >= kyokoLoc.Y +kyoH/2 -2)
                            kyokoAtt = true;
                    }

                }
            }

            //Spawns Sayaka; 2nd boss
            if (sayakaSpawn==true)
            {
                //If she is not attacking, she will bounce off walls
                if (sayakaIdle == true)
                {

                    if (sayakaLoc.X <= pbArena.Width / 2)
                        sayakaLoc.X += 10;

                    sayakaLoc.Y += yRate;
                    sayakaLoc.X -= xRate;

                    if (sayakaLoc.Y >= pbArena.Height - kyubeyHeight)
                        yRate *= -1;

                    if (sayakaLoc.Y <= 0)
                        yRate *= -1;

                    if (sayakaLoc.X >= pbArena.Width - kyubeyWidth)
                        xRate *= -1;

                    if (sayakaLoc.X <= pbArena.Width / 2)
                        xRate *= -1;

                    //If you approach her(moving past the half way point of your side) she will perform an attack
                    if (kyubeyLoc.X >= pbArena.Width/2 - pbArena.Width/4)
                    {
                        sayNdx = 0;

                        sayakaIdle = false;
                        sayakaIdleAn = false;
                        sayakaAttack1 = true;
                    }

                    //Same as previous boss' code. If she has the same Y value within 2, she will perform a range attack
                    if (kyubeyLoc.Y <= sayakaLoc.Y + sayH / 3 + 2 && kyubeyLoc.Y >= sayakaLoc.Y + sayH / 3 - 2 && sayakaLoc.X >= pbArena.Width/2)
                    {
                        sayakaAttack2 = true;
                        sayNdx = 0;
                        spawnSayakaRA();
                    }
                }

                //1st Attack Code
                if (sayakaAttack1==true)
                {
                    //Disable previous attacks/animation
                    sayakaAttack2 = false;
                    sayakaAttack1An = true;

                    //During the 1st attack, she will move towards your location (X and Y) to attack
                    if (kyubeyLoc.Y <= sayakaLoc.Y + sayH / 3)
                        sayakaLoc.Y -= 10;
                        
                    if (kyubeyLoc.Y >= sayakaLoc.Y + sayH / 3)
                        sayakaLoc.Y += 10;

                    if (sayakaLoc.X >= kyubeyLoc.X + kyubeyWidth / 2)
                        sayakaLoc.X -= 8;
                    else if (sayakaLoc.X <= kyubeyLoc.X )
                        sayakaLoc.X += 8;

                    //If she reaches your location, she will attack
                    //Coded so only her sword will do damage
                    if (kyubeyLoc.Y <= sayakaLoc.Y + sayH/3+10 && kyubeyLoc.Y +kyubeyHeight >= sayakaLoc.Y +sayH/3 -10 && kyubeyLoc.X +kyubeyWidth/2 >= sayakaLoc.X)
                    {
                        sayakaAttack1 = false;
                        try
                        {
                            pgbHealth.Value -= 15;
                        }
                        catch
                        {
                            pgbHealth.Value = 0;
                        }
                    }
                }

                //Attack 2
                if (sayakaAttack2==true)
                {
                    //Disables other attacks/animations
                    sayakaAttack1 = false;
                    sayakaIdle = false;
                    sayakaIdleAn = false;
                    sayakaAttack2An = true;
                    
                    //Moves the range attack
                    sayakaRALoc.X -= 15;

                    //If it hits you, does damage and resets location
                    if (sayakaRALoc.X <= kyubeyLoc.X + kyubeyWidth/3 && sayakaRALoc.X + 165 >= kyubeyLoc.X && sayakaRALoc.Y <= kyubeyLoc.Y + kyubeyHeight && sayakaRALoc.Y + 161 >= kyubeyLoc.Y)
                    {
                        sayakaRALoc.X = 99999;
                        sayakaRALoc.Y = 99999;
                        try
                        {
                            pgbHealth.Value -= 15;
                        }
                        catch
                        {
                            pgbHealth.Value = 0;
                        }
                    }
                }
            }
            
            //Moves the shooting projectiles
            if (shoot == true)
            {
                //Moves bullet by 30
                bulletLoc.X += 30;

                //Cannot shoot again if the bullet is still on the screen
                if (bulletLoc.X - eSize * 3 <= pbArena.Width)
                    enbShoot = false;
                else if (bulletLoc.X - eSize * 3 >= pbArena.Width)
                {
                    //Once it reaches past the bounds of the screen
                    //Reset the bullet location
                    bulletLoc.Y = 99999;

                    //If the stamina bar is filled, you cannot shoot until it reaches 0
                    if (maxStam == true)
                        enbShoot = false;
                    else
                        enbShoot = true;

                    tmrStamina.Enabled = true;
                }

                //Hit detection for bosses
                if (kyokoSpawn == true)
                {
                    //Coded so the bullet his the boss more naturally
                    if (bulletLoc.X + bSizeX >= kyokoLoc.X + kyoW/2 && bulletLoc.Y + bSizeY >= kyokoLoc.Y && bulletLoc.Y <= kyokoLoc.Y + kyoH)
                    {
                        //Bullets do 2 damage to the 1st boss
                        try
                        {
                            pgbEnemyHealth.Value -= 2;
                        }
                        catch
                        {
                            pgbEnemyHealth.Value = pgbEnemyHealth.Value;
                        }

                        if (pgbEnemyHealth.Value == 0)
                            defeatBoss();

                        if (maxStam == true)
                            enbShoot = false;
                        else
                            enbShoot = true;

                        bulletLoc.Y = 9999;
                    }
                }

                if (sayakaSpawn == true)
                {
                    if (bulletLoc.X + bSizeX >= sayakaLoc.X + sayW / 2 && bulletLoc.Y + bSizeY >= sayakaLoc.Y && bulletLoc.Y <= sayakaLoc.Y + sayH)
                    {
                       
                        try
                        {
                            pgbEnemyHealth.Value -= 5;
                        }
                        catch
                        {
                            pgbEnemyHealth.Value = 0;
                        }

                        if (pgbEnemyHealth.Value == 0)
                            defeatBoss();

                        if (maxStam == true)
                            enbShoot = false;
                        else
                            enbShoot = true;

                        bulletLoc.Y = 9999;
                    }
                }
            }

            //Extra attack that was not implemented
            //if (charge == true)
            //{
            //    cSizeX += 10;

            //    tmrStamina.Enabled = false;
            //}
            //else if (charge == false)
            //    tmrStamina.Enabled = true;

            //Health item that was not implemented
            //It moves like a sin wave
            ////Moves health
            //if (hSpawn==true)
            //{
            //    int hMoveInt = 1;

            //    hLoc.X -= 5;
            //    //Moves health like a sin wave
            //    hIntY += 1;
            //    double hMoveY; 
            //    hMoveY = Math.Sin(System.Convert.ToDouble(hIntY))*10;
            //    hLoc.Y += System.Convert.ToInt32(hMoveY);// *10;
            //}

            //Move Character
            if (moveUp == true && kyubeyLoc.Y>=0)
                kyubeyLoc.Y -= 4;

            if (moveDown==true && kyubeyLoc.Y + kyubeyHeight<=pbArena.Height)
                kyubeyLoc.Y += 4;

            if (moveLeft == true && kyubeyLoc.X >= 0)
                kyubeyLoc.X -= 4;

            if (moveRight == true && kyubeyLoc.X <= (pbArena.Size.Width / 2) - kyubeyWidth / 2)
                kyubeyLoc.X += 4;
           
            if (pgbHealth.Value == 0)
                lose();

            pbArena.Refresh();
        }     

        private void tmrSprite_Tick(object sender, EventArgs e)
        {

            pgbHealth.Value = 100;
            //Moves the character
            if (move==true)
            {
            //Sets the drawn image's picture 
              kyubeyAnimation = kyubeySprite[sprite];

                if (runFWD == true)
                    sprite++;

                if (runFWD == false)
                    sprite--;

                //Once the sprite images have been animated, resets it
                if (sprite >= 7)
                    {
                        sprite = 0;
                        sprite++;
                    }
            }
            //Same code as main character
            if (kyokoSpawn == true)
            {
                kyokoAnimation = kyokoSprite[kyoNdx];

                kyoNdx++;

                if (kyoNdx >= 7)
                    kyoNdx = 0;
            }

            //2nd Boss' animation
            if (sayakaSpawn==true)
            {

                sayNdx++;

                //If 2nd boss is idling it does the first animation
                if (sayakaIdleAn==true)
                {
                    sayakaAttack1An = false;
                    sayakaAttack2An = false;

                    if (sayNdx >= 8)
                        sayNdx = 0;

                    sayakaAnimation = sayakaSprite[sayNdx + 32];
                }

                //If the 1st attack is performed,changes the animation
                if (sayakaAttack1An==true)
                {
                    sayakaIdleAn = false;
                    sayakaAttack2An = false;

                    if (sayNdx >= 9)
                    {
                        sayNdx = 0;
                        sayakaIdle = true;
                        sayakaIdleAn = true;
                        sayakaAttack1 = false;
                    }

                    sayakaAnimation = sayakaSprite[sayNdx+10];
                }

                //If the 2nd attack is performed, changes the animation
                if (sayakaAttack2An==true)
                {
                    sayakaIdleAn = false;
                    sayakaAttack1An = false;

                    if (sayNdx >= 12)
                    {
                        sayNdx = 0;
                        sayakaIdle = true;
                        sayakaIdleAn = true;
                        sayakaAttack2 = false;
                    }

                    sayakaAnimation = sayakaSprite[sayNdx + 20];
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //test code for the health spawn
            //if (e.KeyCode==Keys.Q)
            //{
            //    hSpawn = true;
            //    hLoc.X = pbArena.Width + 50;
            //    hLoc.Y = rnd.Next(0, pbArena.Height);
            //}

            //Pressing Space shoots, if the conditions are true
            if (e.KeyCode == Keys.Space)
            {
                if (enbShoot == true)
                {
                    shoot = true;
                    spawnBullets();
                    tmrStamina.Enabled = false;
                }
            }

            //WASD or Arrow Keys are used to move
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                moveUp = true;

            if (e.KeyCode == Keys.Down || e.KeyCode==Keys.S)
                moveDown = true;

            if (e.KeyCode == Keys.Left || e.KeyCode==Keys.A)
                moveLeft = true;

            if (e.KeyCode == Keys.Right || e.KeyCode==Keys.D)
                moveRight = true;            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Space)
            //    charge = false;

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                moveUp = false;

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                moveDown = false;

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                moveLeft = false;

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                moveRight = false;
        }

        //Mouse click is also used to shoot
        private void pbArena_MouseClick(object sender, MouseEventArgs e)
        {
            if (enbShoot == true)
            {
                shoot = true;
                spawnBullets();
                tmrStamina.Enabled = false;
            }
        }

        //Sets location of bullets to the character when spawned
        private void spawnBullets()
        {
            pbStamina.Width += 30;

            if (pbStamina.Width >= 150)
            {
                pbStamina.Width = 150;
                maxStam = true;
            }
            
            bulletLoc.X = kyubeyLoc.X + kyubeyWidth;
            bulletLoc.Y = kyubeyLoc.Y + kyubeyHeight / 2;
        }

        //Spawns an attack that was not implemented
        //private void spawnCharge()
        //{

        //    pbStamina.Width += 2;

        //    if (pbStamina.Width >= 150)
        //    {
        //        pbStamina.Width = 150;
        //        maxStam = true;
        //    }

        //    chargeLoc.X = kyubeyLoc.X + kyubeyWidth;
        //    chargeLoc.Y = kyubeyLoc.Y - kyubeyHeight - 10;
        //}


        //AFter each tick, the stamina bar decreases
        private void tmrStamina_Tick(object sender, EventArgs e)
        {
            pbStamina.Width -= 1;

            if (maxStam==true)
            {
                enbShoot = false;
                enbCharge = false;

                if (pbStamina.Width<=0)
                {
                    maxStam = false;
                }
            }
        }

        //Location of the range attack of the 2nd boss
        private void spawnSayakaRA()
        {
            sayakaRALoc.X = sayakaLoc.X - sayW;
            sayakaRALoc.Y = sayakaLoc.Y - sayH / 4;
        }

        //Increases the score
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            score += 1;
            //lblScore.Text = score.ToString();

            //Once the score reaches 20, spawns the 1st boss
            if (score==20 && sayakaSpawn==false)
                kyokoSpawn = true;

            //Once the score reaches 70 and the 1st boss is dead, spawn the 2nd boss
            if (score >= 70 && kyokoSpawn == false)
                sayakaSpawn = true;

            //Once the score reaches 100 and both bosses are dead, you win!
            if (score>=100 && sayakaSpawn==false && kyokoSpawn==false && game==true)
            {
                lblWin.Visible = true;
                lblWin.Enabled = true;
            }
             //Debug code
            //pgbHealth.Value = 100;
        }

        private void lose()
        {
            //lblWin.Visible = true;
            //lblWin.Enabled = true;
            //lblWin.Text = "Game Over";
            menuLoad();
        }

        private void bossSpawn()
        {
            //When bosses spawn, their health is set to 100
            pgbEnemyHealth.Value = 100;
            pgbEnemyHealth.Visible = true;
        }

        private void defeatBoss()
        {
            //Resets the spawn location
            if (kyokoSpawn==true)
            { 
                kyokoSpawn = false;
                kyokoLoc.X = pbArena.Size.Width - kyoW;
                kyokoLoc.Y = (pbArena.Size.Height / 2) - kyoH / 2;
            }

            if (sayakaSpawn == true)
            {
                sayakaSpawn = false;
                sayakaLoc.X = pbArena.Size.Width - sayW;
                sayakaLoc.Y = (pbArena.Size.Height / 2) - sayH / 2;
            }

            //If you deafeat a boss, you get 50 health
            try
            {
                pgbHealth.Value += 50;
            }
            catch
            {
                pgbHealth.Value = 100;
            }
                
            //Changes the debris colour
            debrisVar = debrisColour;

            pgbEnemyHealth.Value = 100;
            pgbEnemyHealth.Visible = false;
        }
    }    
}
