using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Web.SystemModule;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;
using DevExpress.ExpressApp.Web.Templates.ActionContainers.Menu;

namespace Solution28.Module.Web.Controllers {
    public class MyProcessActionContainerHolderController : ProcessActionContainerHolderController {
        protected override MenuActionItemBase OnCreateCustomMenuActionItem(ActionBase action) {
            if(action.Id == "FilterRange") {
                return new ParametrizedRangeActionMenuActionItem((ParametrizedAction)action);
            }
            return null;
        }
    }
}
