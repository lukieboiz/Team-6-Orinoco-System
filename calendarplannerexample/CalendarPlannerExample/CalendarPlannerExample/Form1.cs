using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeekPlanner;


namespace CalendarPlannerExample
{
    public partial class Form1 : Form
    {
        private int day;

        public Form1()
        {
            InitializeComponent();
            weekPlanner.Columns.Add("Room", "Room", 150);
            this.comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weekPlanner.CurrentDate = DateTime.Now;
        }

        public IEnumerable<WeekPlannerItem> GetItemsByRow(int rowIndex)
        {
            var rows = weekPlanner.Rows;
            var row = rows.ElementAt(rowIndex);
            return row.Items.ToList();
        }

        private void btn_AddRow_Click(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex > - 1)
            {
                bool exists = false;
                var itemCollection = new WeekPlannerItemCollection();

                var ColumnRows = new DataColumns(weekPlanner.Calendar);
                ColumnRows["Room"].Data.Add(comboBox.Text.ToString());
                for (int i = 0; i < weekPlanner.RowCount; i ++)
                {
                    Console.Write(weekPlanner.Calendar.Columns["Room"].Data.ElementAtOrDefault(0));
                }

                if (exists)
                {
                    MessageBox.Show("Room already exists in a row");
                }
                else
                {
                    weekPlanner.Rows.Add(ColumnRows, itemCollection);
                }
            }
            else
            {
                MessageBox.Show("Please select a room");
            }
        }

        private void btn_AddRow2_Click(object sender, EventArgs e)
        {
            var ColumnRows = new DataColumns(weekPlanner.Calendar);

            var itemCollection = new WeekPlannerItemCollection();

            var item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(0);
            item.EndDate = DateTime.Now.AddDays(0);
            item.Subject = "1 date";
            item.BackColor = Color.YellowGreen;
            itemCollection.Add(item);

            var row = new WeekPlannerRow();
            row.Columns = ColumnRows;
            ColumnRows["Room"].Data.Add("J202");

            row.Name = Guid.NewGuid().ToString().Substring(0, 5);
            row.Items = itemCollection;
            row.IsCollapsible = true;
            weekPlanner.Rows.Add(row);
        }

        private void btn_RemoveRow_Click(object sender, EventArgs e)
        {
            if (weekPlanner.Rows.Count > 0)
            {
                if (!weekPlanner.Rows[weekPlanner.SelectedRowIndex].IsCollapsible)
                {

                    weekPlanner.Rows.Remove(weekPlanner.SelectedRowIndex);
                }
            }
        }


        private bool isSelectedRow()
        {
            if (weekPlanner.SelectedRowIndex == -1)
            {
                MessageBox.Show("Please select cell");
                return false;
            }

            return true;
        }

        private void btn_SetRowColor_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var row = weekPlanner.Rows.ElementAt(weekPlanner.SelectedRowIndex);
                row.BackColor = Color.Lime;
            }
        }

        private void btn_DeleteRows_Click(object sender, EventArgs e)
        {
            weekPlanner.Rows.Clear();
        }

        private void btn_NewItem_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var rows = weekPlanner.Rows;
                var row = rows.ElementAt(weekPlanner.SelectedRowIndex);

                var item = new WeekPlannerItem();
                item.StartDate = DateTime.Now.AddDays(0);
                item.EndDate = DateTime.Now.AddDays(0);
                item.Subject = "Room";
                item.BackColor = Color.YellowGreen;

                row.Items.Add(item);
            }
        }

        private void btn_DeleteItems_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var rows = weekPlanner.Rows;
                var row = rows.ElementAt(weekPlanner.SelectedRowIndex);
                row.Items.Clear();
            }
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var rows = weekPlanner.Rows;
                var row = rows.ElementAt(weekPlanner.SelectedRowIndex);

                var item = row.Items.Where(d => d.Subject == "Room").FirstOrDefault();
                if (item == null)
                {
                    MessageBox.Show("Item is not found");
                    return;
                }
                row.Items.Remove(item);
            }
        }

        private void btn_SetItemDate_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var rows = weekPlanner.Rows;
                var row = rows.ElementAt(weekPlanner.SelectedRowIndex);

                var item = row.Items.Where(d => d.Subject == "Room").FirstOrDefault();
                if (item == null)
                {
                    MessageBox.Show("Item is not found");
                    return;
                }
                item.StartDate = DateTime.Now.AddDays(1);
                item.EndDate = DateTime.Now.AddDays(5);
            }
        }

        private void btn_EditMode_Click(object sender, EventArgs e)
        {
            if (weekPlanner.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
                return;
            }

            weekPlanner.ActivateEditMode(weekPlanner.SelectedItem);
        }

        private void btn_ClearColumn_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var row = weekPlanner.Rows.ElementAt(weekPlanner.SelectedRowIndex);
                row.Columns["Room"].Data.Clear();
            }
        }

        private void btn_AddColumnData_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var row = weekPlanner.Rows.ElementAt(weekPlanner.SelectedRowIndex);
                row.Columns["Room"].Data.Add(Guid.NewGuid().ToString().Substring(0, 8), Color.Red);
            }
        }

        private void weekPlanner_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            weekPlanner.ActivateEditMode(e.Item);
            e.Item.BackColor = Color.Yellow;
        }

        private void weekPlanner_RowDoubleClick(object sender, RowEventArgs e)
        {
            weekPlanner.Rows.ElementAt(weekPlanner.SelectedRowIndex).Items.Add(weekPlanner.SelectedCellDate, weekPlanner.SelectedCellDate, "Info here");
        }

        private void btn_MinusDay_Click(object sender, EventArgs e)
        {
            day--;
            weekPlanner.CurrentDate = DateTime.Now.AddDays(day);
        }

        private void btn_PlusDay_Click(object sender, EventArgs e)
        {
            day++;
            weekPlanner.CurrentDate = DateTime.Now.AddDays(day);
        }
        private void weekPlanner_RowLeftColumnClick(object sender, RowClickEventArgs e, int rowNumber)
        {
            if (e.MouseButton == MouseButtons.Right)
            {
                MessageBox.Show(e.Row.Level.ToString());
            }

            if (e.Row.IsCollapsible)
            {
                if (e.Row.IsExpanded)
                {
                    var count = IterateChilds(e.Row.Name, true, 0);
                    //if not found child nodes
                    if (count == 0)
                    {
                        for (int i = 1; i < 3; i++)
                        {
                            var row = new WeekPlannerRow();
                            var ColumnRows = new DataColumns(weekPlanner.Calendar);
                            row.Columns = ColumnRows;

                            ColumnRows["Room"].Data.Add(Guid.NewGuid().ToString().Substring(0, 8));
 
                            row.Name = Guid.NewGuid().ToString().Substring(0, 5);
                            row.Level = e.Row.Level + 1;
                            row.AncestorName = e.Row.Name;

                            if (i == 2 && e.Row.Level<2)
                            {
                                row.IsCollapsible = true;
                            }
                            else
                            {
                                row.LeftMarginBackColor = Color.FromArgb(240, 242, 245);
                                row.BackColor = Color.GhostWhite;
                            }
                            row = weekPlanner.Rows.Insert(rowNumber + i, row);
                        }
 
                    }
                }
                //if found child nodes
                else
                {
                    var r = weekPlanner.Rows.ElementAt(rowNumber);
                    IterateChilds(r.Name,false,0);
                }
            }

        }

        //iterates child nodes
        private int IterateChilds(string ancestor, bool isVisible, int childCount)
        {
            var nodes = weekPlanner.Rows.Where(r => r.AncestorName == ancestor);

            foreach (var node in nodes)
            {
                childCount++;
                node.IsVisible = isVisible;
                node.IsExpanded = true;
                IterateChilds(node.Name, isVisible, childCount);
            }
            return childCount;
        }

        private void weekPlanner_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
