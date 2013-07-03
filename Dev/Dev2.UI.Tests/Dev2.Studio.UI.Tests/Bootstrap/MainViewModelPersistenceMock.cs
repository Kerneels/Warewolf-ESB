﻿
using Dev2.Studio.Core.Interfaces;
using Dev2.Studio.ViewModels;
using Dev2.Studio.ViewModels.WorkSurface;

namespace Dev2.Core.Tests
{
    public class MainViewModelPersistenceMock : MainViewModel
    {
        public MainViewModelPersistenceMock(IEnvironmentRepository environmentRepository, bool createDesigners = true)
            : base(environmentRepository, createDesigners)
        {
        }

        public void TestClose()
        {
            base.OnDeactivate(true);
        }

        public void CallDeactivate(WorkSurfaceContextViewModel item)
        {            
            base.DeactivateItem(item,true);
        }
    }
}
