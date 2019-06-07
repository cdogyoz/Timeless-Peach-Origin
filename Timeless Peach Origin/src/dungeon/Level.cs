using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using Timeless_Peach_Origin.src.consoles;
using Timeless_Peach_Origin.src.constructs;
using Timeless_Peach_Origin.src.dungeon.chefs;
using SadConsole.Entities;
using SadConsole.Components;
using Microsoft.Xna.Framework;
using GoRogue;
using GoRogue.MapGeneration;
using GoRogue.MapViews;
using Troschuetz.Random;
using Troschuetz.Random.Generators;

namespace Timeless_Peach_Origin.src.dungeon {
    class Level : CellSurface {

        public GoRogue.MultiSpatialMap<Construct> entities;
        private LevelTypes levelType;
        private Cell[] level;

        public Level(LevelTypes levelType) : base(150, 75) {
            this.levelType = levelType;
            entities = new GoRogue.MultiSpatialMap<Construct>();
            CreateLevel();
        }

        private void CreateLevel() {
            if(levelType == LevelTypes.CAVERNS) {
                CavernChef cavern = new CavernChef(base.Width, base.Height, this);
                level = cavern.CreateLevel();
            }
        }

        public Cell[] GetLevel() {
            return level;
        }

        public T GetEntityAt<T>(Point position) where T : Construct {
            return entities.GetItems(position).OfType<T>().FirstOrDefault();
        }

        //Adds a construct to the multi-spatial map
        public void Add(Construct construct) {
            entities.Add(construct, construct.Position);
            construct.Moved += OnEntityMoved;
        }

        //Removes a construct from the multi-spatial map
        public void Remove(Construct construct) {
            entities.Remove(construct);
            construct.Moved -= OnEntityMoved;
        }

        private void OnEntityMoved(object sender, Entity.EntityMovedEventArgs args) {
            entities.Move(args.Entity as Construct, args.Entity.Position);
        }


    }
}
