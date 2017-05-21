using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcJqGrid
{
    public class groupingView
    {
        private List<string> _groupfield = new List<string>();
        private List<string> _grouptext = new List<string>();
        private List<string> _grouporder = new List<string>();
        private List<bool> _groupsummary = new List<bool>();
        private List<bool> _groupcolumnshow = new List<bool>();
        private bool _groupcollapse = false;
        private bool _showsummaryonhide = false;
        private bool _groupdatasorted = false;


        public groupingView SetGroupField(List<string> groupfield)
        {
            _groupfield = groupfield;
            return this;
        }

        public groupingView SetGroupOrder(List<string> grouporder)
        {
            _grouporder = grouporder;
            return this;
        }

        public groupingView SetGroupText(List<string> grouptext)
        {
            _grouptext = grouptext;
            return this;
        }

        public groupingView SetGroupSummary(List<bool> groupsummary)
        {
            _groupsummary = groupsummary;
            return this;
        }

        public groupingView SetGroupColumnShow(List<bool> groupcolumnshow)
        {
            _groupcolumnshow = groupcolumnshow;
            return this;
        }


        public groupingView SetGroupCollapse(bool groupcollapse)
        {
            _groupcollapse = groupcollapse;
            return this;
        }

        public groupingView SetShowSummaryOnHide(bool showsummaryonhide)
        {
            _showsummaryonhide = showsummaryonhide;
            return this;
        }

        public groupingView SetGroupDataSorted(bool groupdatasorted)
        {
            _groupdatasorted = groupdatasorted;
            return this;
        }

        public override string ToString()
        {
            var script = new StringBuilder();

            // Start column
            script.AppendLine().Append("{").AppendLine();

            if (_groupfield.Count > 0)
            {
                script.AppendFormat("groupField: ['{0}']", string.Join("','", (from c in _groupfield select c).ToArray()));
            }

            if (_grouptext.Count > 0)
            {
                script.Append(",").AppendLine();
                script.AppendFormat("groupText: ['{0}']", string.Join("','", (from c in _grouptext select c).ToArray()));
            }

            if (_grouporder.Count > 0)
            {
                script.Append(",").AppendLine();
                script.AppendFormat("groupOrder: ['{0}']", string.Join("','", (from c in _grouporder select c).ToArray()));
            }

            if (_groupsummary.Count > 0)
            {
                script.Append(",").AppendLine();
                script.AppendFormat("groupSummary: [{0}]", string.Join(",", (from c in _groupsummary select c).ToArray()).ToLower());
            }

            if (_groupcolumnshow.Count > 0)
            {
                script.Append(",").AppendLine();
                script.AppendFormat("groupColumnShow: [{0}]", string.Join(",", (from c in _groupcolumnshow select c).ToArray()).ToLower());
            }

            // End column
            script.AppendLine();
            script.Append("}");

            return script.ToString();
        }

    }
}
