using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class Panel_inf
    {
        List<Panel> panel_list;
        List<List<string>> panel_path_list;
        string local_path = @"D:\eye of sauron\runtime\1218180";
        public Panel_inf(List<List<string>> panellist_)
        {
            // List<List<string>> = [panelid, origin image path, result path]
            panel_path_list = panellist_;
            Refreshpanellist();
        }

        public void Refreshpanellist()
        {
            // please use this function under another thread,it will cost long time for initial the panel.
            while (panel_list.Count < 20 & panel_path_list.Count != 0)
            {
                string panelid = panel_path_list[0][0];
                string origin_image_path = panel_path_list[0][1];
                string result_path = panel_path_list[0][2];
                Panel thispanel = new Panel(origin_image_path, local_path);
                panel_list.Add(thispanel);
            }
        }

        public void Destroy_fist_panel()
        {
            panel_list.RemoveAt(0);
        }

        public Panel get_first_panel()
        {
            return panel_list[0];
        }

        public int Get_remain_job()
        {
            return panel_list.Count;
        }

    }
}
