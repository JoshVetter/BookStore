using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.CodeDom.Compiler;

namespace BookStore
{
    public partial class TableViewController : UITableViewController
    {
        List<Book> bookStore;
        public TableViewController (IntPtr handle) : base (handle)
        {
        }
    }
}