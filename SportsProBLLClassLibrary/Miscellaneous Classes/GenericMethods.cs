using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProBLLClassLibrary
{
    public static class GenericMethods
    {
        /// <summary>
        /// Generic method to loop through a List of objects and 
        /// add each object to the binding source specified.
        /// </summary>
        /// <typeparam name="Object">Any object the user uses inside the specified List.</typeparam>
        /// <param name="lst">A List containing any type of object.</param>
        /// <param name="bs">A BindingSource object.</param>
        public static void AddObjectsToBindingSource<Object>(List<Object> lst, BindingSource bs)
        {
            foreach (Object obj in lst)
            {
                bs.Add(obj);
            }
        }

        /// <summary>
        /// Formats a form to properly attach to parent and fill entire parent width.
        /// </summary>
        /// <param name="someForm">A Form object.</param>
        public static void FormatMdiChild(Form childForm, Form parentForm)
        {
            childForm.MdiParent = parentForm;
            childForm.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            childForm.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Displays the "No results found" label if the DataGridView has no data.
        /// </summary>
        public static void DisplayLabelWhenNoResultsFound(Label lbl, DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                lbl.Show();
            }
        }
    }
}
