﻿using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeParkour.Data
{
    public class TestableNavigation
    {
        public static Func<INavigationService, string, INavigationParameters, bool?, bool, Task<INavigationResult>> TestableNavigateAsync =
            (navSvc, pageName, navParams, isModal, isAnimated) => navSvc.NavigateAsync(pageName, navParams, isModal, isAnimated);

        public static Func<INavigationService, Task<INavigationResult>> TestableGoBackAsync =
                    (navSvc) => navSvc.GoBackAsync();

        public static Func<INavigationService, INavigationParameters, bool?, bool, Task<INavigationResult>> TestableGoBackAsyncWithParams =
                    (navSvc, navParams, isModal, isAnimated) => navSvc.GoBackAsync(navParams, isModal, isAnimated);
    }
}
