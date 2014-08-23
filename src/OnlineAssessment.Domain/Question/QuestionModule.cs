﻿// Author:
//      Lu Rongkai <lurongkai@gmail.com>
// 
// Copyright (c) 2014 lurongkai
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA

namespace OnlineAssessment.Domain
{
    public enum QuestionModule
    {
        Theory, // 理论
        Skill, // 技能
        SkillExtension // 拓展技能
        //UnitTesting, // 单元测试
        //ComprehensiveTesting, // 综合题测试
        //SimulationTesting, // 模拟考试
        //ModularizedTheoryExam, // 模块化考试-理论模块
        //ModularizedSkillExam, // 模块化考试-技能模块
        //ModularizedSkillExtensionExam // 模块化考试-拓展技能模块
    }
}