using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace QuickReplyTools
{
    public class FormSizeSet
    {
        #region 窗体坐标
        private float X;
        private float Y;
        public float _x
        {
            set { X = value; }
        }
        public float _y
        {
            set { Y = value; }
        }
        #endregion

        #region 将坐标与大小存入tag
        /// <summary>
        /// 将坐标与大小存入tag
        /// </summary>
        /// <param name="cons"></param>
        public void setTag(Control cons)
        {
            //遍历窗体中的控件
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        #endregion

        #region 根据所有窗体调整大小
        /// <summary>
        /// 根据窗体大小调整控件大小
        /// </summary>
        /// <param name="newx"></param>
        /// <param name="newy"></param>
        /// <param name="cons"></param>
        public void setControls(float newx, float newy, Control cons)
        {
            try
            {
                //遍历窗体中的控件，重新设置控件的值
                foreach (Control con in cons.Controls)
                {
                    //获取控件tag属性值，并分割后存储字符串数组
                    string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                    float a = Convert.ToSingle(mytag[0]) * newx;//根据窗体缩放比例确定控件的宽度值
                    con.Width = (int)a;
                    a = Convert.ToSingle(mytag[1]) * newy;
                    con.Height = (int)a;//高度

                    a = Convert.ToSingle(mytag[2]) * newx;
                    con.Left = (int)a;//左边缘距离
                    a = Convert.ToSingle(mytag[3]) * newy;
                    con.Top = (int)a;//上边缘距离
                    Single currentSize = Convert.ToSingle(mytag[4]) * newy;
                    if (con.Name != "tpgQuickReply" && con.Name != "tpgVideoLink")
                    {
                        con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    }
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }

                }
            }
            catch { }
        }
        #endregion

        #region 修改大小
        /// <summary>
        /// 修改大小
        /// </summary>
        /// <param name="from"></param>
        public void form_Resize(Form from)
        {
            float newx = (from.Width) / X;
            float newy = (from.Height) / Y;
            setControls(newx, newy, from);
        }

        public static float pInfosize = 9;
        public static float holtersize = 9;
        public void PColumns_Resize(DataGridView dgv)
        {
            if (pInfosize == dgv.Font.Size)
                return;
            float change = dgv.Font.Size / pInfosize;
            float a = dgv.Columns[0].MinimumWidth * change;
            dgv.Columns[0].MinimumWidth = Convert.ToInt32(a);
            a = dgv.Columns[1].MinimumWidth * change;
            dgv.Columns[1].MinimumWidth = Convert.ToInt32(a);
            pInfosize = dgv.Font.Size;
        }

        public void HColumns_Resize(DataGridView dgv)
        {
            if (holtersize == dgv.Font.Size)
                return;
            float change = dgv.Font.Size / holtersize;
            float a = dgv.Columns[0].MinimumWidth * change;
            dgv.Columns[0].MinimumWidth = Convert.ToInt32(a);
            a = dgv.Columns[1].MinimumWidth * change;
            dgv.Columns[1].MinimumWidth = Convert.ToInt32(a);
            holtersize = dgv.Font.Size;
        }

        #endregion
    }
}