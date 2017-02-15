﻿using System;

using Microsoft.Office.Interop.PowerPoint;

using ARSnovaPPIntegration.Business.Model;

namespace ARSnovaPPIntegration.Business.Contract
{
    public interface ISessionManager
    {
        ValidationResult SetClickSession(SlideSessionModel slideSessionModel);

        void CreateSession(SlideSessionModel slideSessionModel);

        void StartSession(SlideSessionModel slideSessionModel, int questionIndex, Slide questionSlide, Slide resultsSlide);

        void RemoveClickQuizDataFromServer(SlideSessionModel slideSessionModel);

        void KeepAlive(SlideSessionModel slideSessionModel);

        ValidationResult ActivateClickSession(SlideSessionModel slideSessionModel);

        event EventHandler ShowNextSlideEventHandler;
    }
}
