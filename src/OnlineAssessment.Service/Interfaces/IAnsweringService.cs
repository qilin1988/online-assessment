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
// 
// Source code hosted on: https://github.com/lurongkai/online-assessment

using System;
using System.Collections.Generic;
using OnlineAssessment.Domain;

namespace OnlineAssessment.Service
{
    public interface IAnsweringService
    {
        Guid UploadAnswerSheet(Guid examinationId, string studentId, AnswerSheet answerSheet);

        IEnumerable<AnswerSheetItem> GetAllUnevaluatedAnswers(Guid examinationId);
        void EvaluatingAnswer(Guid answerSheetId, Guid answerId, int score);

        AnswerSheet GetAnswerSheet(Guid answerSheetId);
    }
}