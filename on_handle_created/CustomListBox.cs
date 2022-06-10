using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace on_handle_created
{
    class CustomListBox : ListBox
    {
        static int _createCount = 0; 
        protected override void OnHandleCreated(EventArgs e)
        { 
            base.OnHandleCreated(e);

            if (!DesignMode)
            {
                _createCount++;
                switch (_createCount)
                {
                    case 0: throw new NotImplementedException();
                    case 1:
                        // Creation
                        Debug.Assert(Items.Count == 0, "Expecting uninitialized Window.");
                        break;
                    default:
                        // Nevertheless, here we are!
                        Debug.Assert(Items.Count == 0, "Was NOT expecting control persistence across different handle lifecycles.");
                        break;
                }
                Items.Add("Single Item");
            }
        }
        public void Test() => RecreateHandle();
    }
}
