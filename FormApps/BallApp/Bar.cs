using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class Bar : Obj {

        public Bar(double xp, double yp)
            : base(xp, yp, @"Picture\tennis?ball.png") {

            MoveX = 10; //移動量設定
            MoveY = 0;
        }

        public override bool Move() {
            return true;
        }
        public override bool Move(Keys direction) {
            if (direction == Keys.Right)
                if (PosX < 635) {
                    PosX += MoveX;
                } else if (direction == Keys.Left) {
                    if (PosX > 0) {
                        PosX -= MoveX;
                    }
                }
            return true;
        }
    }
}
