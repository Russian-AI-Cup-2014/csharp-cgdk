using System;
using Com.CodeGame.CodeHockey2014.DevKit.CSharpCgdk.Model;

namespace Com.CodeGame.CodeHockey2014.DevKit.CSharpCgdk {
    public sealed class MyStrategy : IStrategy {
        public void Move(Hockeyist self, World world, Game game, Move move) {
            move.SpeedUp = -1.0D;
            move.Turn = Math.PI;
            move.Action = ActionType.Strike;
        }
    }
}