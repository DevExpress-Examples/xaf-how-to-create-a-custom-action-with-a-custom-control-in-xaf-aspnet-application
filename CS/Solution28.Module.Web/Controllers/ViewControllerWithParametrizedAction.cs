using System;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Web.SystemModule;

namespace Solution28.Module.Web {
    public class ViewController1 : ViewController {
        public ViewController1() {
            ParametrizedAction filterAction = new ParametrizedAction(this, "FilterRange", "Edit", typeof(DateTime));
            filterAction.Execute += new ParametrizedActionExecuteEventHandler(filterAction_Execute);
        }
        private void filterAction_Execute(object sender, ParametrizedActionExecuteEventArgs e) {
            Range<DateTime> range = (Range<DateTime>)e.ParameterCurrentValue;
            ((ListView)View).CollectionSource.Criteria["By Date"] = CriteriaOperator.Parse("[Date] <= ? AND [Date] >= ?", range.To, range.From);
        }
    }    
}
