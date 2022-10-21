using System;
using static System.Console;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    
    public class GameEngine
    {
        private Map map;

        private Random ran;

        private Hero hero;

        private Enemy enemy;

        private Mage mage;

        private SwampCreature swampCreature;

        private const string FILENAME = "Savefile.txt";
        //getter and accessors for map

        public string Display
        {
            get { return map.ToString(); }
        }
        //constructors of GameEngine
        public GameEngine()
        {
            map = new Map(10, 20, 15, 25, 4, 5);
        }

        public void Save()
        {
            try
            {
                FileStream saveFile = new FileStream(
                FILENAME, FileMode.Create, FileAccess.Write
                );

                BinaryFormatter bWriter = new BinaryFormatter();

                bWriter.Serialize(saveFile, map);

                saveFile.Close();
            }
            catch(Exception ex)
            {

            }
        }

        public void Load()
        {
            try
            {
                FileStream saveFile = new FileStream(
                FILENAME, FileMode.Open, FileAccess.Read
                );

                BinaryFormatter bReader = new BinaryFormatter();

                while(saveFile.Position < saveFile.Length)
                {
                    map = (Map)bReader.Deserialize(saveFile);
                    
                }
                saveFile.Close();
            }
            catch (Exception error)
            {
                if (!(File.Exists(FILENAME)))
                {
                    MessageBox.Show("There's no saved file.");

                }
            }
        }

        public bool MovePlayer(Movement direction)
        {//The characters movements across the map
            if (direction == Movement.No_movement)
            {
                return false;
            }

            Movement validMove = map.Hero.ReturnMove(direction);
            if (validMove == Movement.No_movement)
            {
                return false;
            }


            map.Hero.Move(validMove);
            map.UpdateMap();
            map.UpdateVision();

            if (hero is Gold)
            {
                map.PickupItem();
            }

            return true;
        }

        public string Herostats()
        {//Displays Hero's stats
            return "Hero :" + hero.Hp + "/" + hero.MaxHp + "HP" +
                " \n Gold Purse: " + hero.GoldPurse;
        }

        public string PlayerAttack(Movement direction)
        {
            if (direction == Movement.No_movement)
            {
                return "Attack Failed";
            }

            Tile tile = map.Hero.Vision[(int)direction];

            if (tile is Enemy)
            {
                map.Hero.Attack((Enemy)tile);
                return "Hero attacked: " + enemy.ToString();
            }

            return "Attack failed, no enemy in this direction";
        }

        public void EnemyAttacks()
        {

            for (int i = 0; i < map.Enemies; i++)
            {
                if (MoveEnemies() == true)
                {
                    if(enemy.CheckRange(hero) == true)
                    {
                        enemy.Attack(hero);
                    }
                } else if( PlayerAttack(Movement.No_movement) == "Attack Failed" ||
                           PlayerAttack(Movement.No_movement) == "Attack failed, no enemy in this direction")
                {
                    if(enemy.CheckRange(hero) == true)
                    {
                        enemy.Attack(hero);
                    }
                }

                if(mage.CheckRange(hero) || mage.CheckRange(swampCreature))
                {
                    enemy.Attack(hero);
                }
                
            }
        }

        public bool MoveEnemies()
        {
            int ran_num = ran.Next(4);
            Movement validMove = enemy.ReturnMove((Movement)ran_num);
            if (MovePlayer(Movement.No_movement) == false)
            {
                 for (int i = 0; i < map.Enemies; i++)
                {
                    if (validMove == Movement.No_movement)
                    {
                        enemy.Move(validMove);
                        map.UpdateMap();
                        map.UpdateVision();
                        return true;
                    }
                    else if (validMove == Movement.Up)
                    {
                        enemy.Move(validMove);
                        map.UpdateMap();
                        map.UpdateVision();
                        return true;
                    }
                    else if (validMove == Movement.Left)
                    {
                        enemy.Move(validMove);
                        map.UpdateMap();
                        map.UpdateVision();
                        return true;
                    }
                    else if (validMove == Movement.Right)
                    {
                        enemy.Move(validMove);
                        map.UpdateMap();
                        map.UpdateVision();
                        return true;
                    }
                    else
                    {
                        enemy.Move(validMove);
                        map.UpdateMap();
                        map.UpdateVision();
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
