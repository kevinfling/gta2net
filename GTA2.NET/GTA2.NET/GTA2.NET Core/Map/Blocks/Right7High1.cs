﻿// GTA2.NET
// 
// File: Right7High1.cs
// Created: 22.04.2013
// Created by: João Pires
// 
// Copyright (C) 2010-2013 Hiale
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software
// and associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software
// is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies
// or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR
// IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
// Grand Theft Auto (GTA) is a registred trademark of Rockstar Games.
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Hiale.GTA2NET.Core.Collision;

namespace Hiale.GTA2NET.Core.Map.Blocks
{
    class Right7High1 : BlockInfo
    {
        public Right7High1() : base()
        {
            SlopeType = SlopeType.Right7High1;
        }

        public Right7High1(blockInfo blockInfo, Vector3 pos) : base(blockInfo, pos) 
        {
            SlopeType = SlopeType.Right7High1;
        }
        
        public override BlockInfo DeepCopy()
        {
            return new Right7High1(this.blockInfo, this.Position);
        }

        public override BlockInfo DeepCopy(blockInfo blockInfo, Vector3 pos)
        {
            return new Right7High1(blockInfo, pos);
        }

        public override void SetUpCube()
        {
            SetUpSlope_High(8, 0);
        }

        public override void GetCollision(List<IObstacle> obstacles)
        {
            throw new System.NotImplementedException();
        }
    }
}