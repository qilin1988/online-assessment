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

using System;
using System.Web.Mvc;
using OnlineAssessment.Service;

namespace OnlineAssessment.Web.Core.Controllers
{
    public class EvaluatingController : Controller
    {
        private readonly IAnsweringService _answeringService;

        public EvaluatingController(IAnsweringService answeringService) {
            _answeringService = answeringService;
        }

        public ActionResult List(string subjectKey, Guid examinationId) {
            var unevaluatedAnswers = _answeringService.GetAllUnevaluatedAnswers(examinationId);
            return View(unevaluatedAnswers);
        }

        public ActionResult Evalute(string subjectKey, Guid examinationId, Guid answerSheetId, Guid answerId, int score) {
            _answeringService.EvaluatingAnswer(answerSheetId, answerId, score);

            return RedirectToAction("List", new {subjectKey = subjectKey, examinationId = examinationId});
        }
    }
}