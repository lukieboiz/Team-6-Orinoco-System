namespace CalendarPlannerExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WeekPlanner.DataColumns dataColumns3 = new WeekPlanner.DataColumns();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MinusDay = new System.Windows.Forms.Button();
            this.btn_PlusDay = new System.Windows.Forms.Button();
            this.btn_DeleteRows = new System.Windows.Forms.Button();
            this.btn_RemoveRow = new System.Windows.Forms.Button();
            this.btn_SetItemDate = new System.Windows.Forms.Button();
            this.btn_ClearColumn = new System.Windows.Forms.Button();
            this.btn_DeleteItem = new System.Windows.Forms.Button();
            this.btn_NewItem = new System.Windows.Forms.Button();
            this.btn_AddRow = new System.Windows.Forms.Button();
            this.weekPlanner = new WeekPlanner.CalendarPlanner();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_MinusDay);
            this.panel1.Controls.Add(this.btn_PlusDay);
            this.panel1.Controls.Add(this.btn_DeleteRows);
            this.panel1.Controls.Add(this.btn_RemoveRow);
            this.panel1.Controls.Add(this.btn_SetItemDate);
            this.panel1.Controls.Add(this.btn_ClearColumn);
            this.panel1.Controls.Add(this.btn_DeleteItem);
            this.panel1.Controls.Add(this.btn_NewItem);
            this.panel1.Controls.Add(this.btn_AddRow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "G218",
            "H039",
            "H213",
            "J202/204",
            "J210",
            "J255",
            "J325"});
            this.comboBox.Location = new System.Drawing.Point(589, 43);
            this.comboBox.Name = "comboBox";
            this.comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox.Size = new System.Drawing.Size(90, 21);
            this.comboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Room:";
            // 
            // btn_MinusDay
            // 
            this.btn_MinusDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinusDay.Location = new System.Drawing.Point(589, 4);
            this.btn_MinusDay.Name = "btn_MinusDay";
            this.btn_MinusDay.Size = new System.Drawing.Size(41, 23);
            this.btn_MinusDay.TabIndex = 29;
            this.btn_MinusDay.Text = "Day -";
            this.btn_MinusDay.UseVisualStyleBackColor = true;
            this.btn_MinusDay.Click += new System.EventHandler(this.btn_MinusDay_Click);
            // 
            // btn_PlusDay
            // 
            this.btn_PlusDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PlusDay.Location = new System.Drawing.Point(636, 4);
            this.btn_PlusDay.Name = "btn_PlusDay";
            this.btn_PlusDay.Size = new System.Drawing.Size(43, 23);
            this.btn_PlusDay.TabIndex = 28;
            this.btn_PlusDay.Text = "Day +";
            this.btn_PlusDay.UseVisualStyleBackColor = true;
            this.btn_PlusDay.Click += new System.EventHandler(this.btn_PlusDay_Click);
            // 
            // btn_DeleteRows
            // 
            this.btn_DeleteRows.Location = new System.Drawing.Point(168, 4);
            this.btn_DeleteRows.Name = "btn_DeleteRows";
            this.btn_DeleteRows.Size = new System.Drawing.Size(110, 23);
            this.btn_DeleteRows.TabIndex = 26;
            this.btn_DeleteRows.Text = "Delete rows";
            this.btn_DeleteRows.UseVisualStyleBackColor = true;
            this.btn_DeleteRows.Click += new System.EventHandler(this.btn_DeleteRows_Click);
            // 
            // btn_RemoveRow
            // 
            this.btn_RemoveRow.Location = new System.Drawing.Point(87, 4);
            this.btn_RemoveRow.Name = "btn_RemoveRow";
            this.btn_RemoveRow.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveRow.TabIndex = 24;
            this.btn_RemoveRow.Text = "Delete Row";
            this.btn_RemoveRow.UseVisualStyleBackColor = true;
            this.btn_RemoveRow.Click += new System.EventHandler(this.btn_RemoveRow_Click);
            // 
            // btn_SetItemDate
            // 
            this.btn_SetItemDate.Location = new System.Drawing.Point(168, 32);
            this.btn_SetItemDate.Name = "btn_SetItemDate";
            this.btn_SetItemDate.Size = new System.Drawing.Size(97, 23);
            this.btn_SetItemDate.TabIndex = 23;
            this.btn_SetItemDate.Text = "Set Item Date";
            this.btn_SetItemDate.UseVisualStyleBackColor = true;
            this.btn_SetItemDate.Click += new System.EventHandler(this.btn_SetItemDate_Click);
            // 
            // btn_ClearColumn
            // 
            this.btn_ClearColumn.Location = new System.Drawing.Point(6, 61);
            this.btn_ClearColumn.Name = "btn_ClearColumn";
            this.btn_ClearColumn.Size = new System.Drawing.Size(94, 23);
            this.btn_ClearColumn.TabIndex = 21;
            this.btn_ClearColumn.Text = "Clear Column";
            this.btn_ClearColumn.UseVisualStyleBackColor = true;
            this.btn_ClearColumn.Click += new System.EventHandler(this.btn_ClearColumn_Click);
            // 
            // btn_DeleteItem
            // 
            this.btn_DeleteItem.Location = new System.Drawing.Point(87, 32);
            this.btn_DeleteItem.Name = "btn_DeleteItem";
            this.btn_DeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteItem.TabIndex = 20;
            this.btn_DeleteItem.Text = "Delete Item";
            this.btn_DeleteItem.UseVisualStyleBackColor = true;
            this.btn_DeleteItem.Click += new System.EventHandler(this.btn_DeleteItem_Click);
            // 
            // btn_NewItem
            // 
            this.btn_NewItem.Location = new System.Drawing.Point(6, 32);
            this.btn_NewItem.Name = "btn_NewItem";
            this.btn_NewItem.Size = new System.Drawing.Size(75, 23);
            this.btn_NewItem.TabIndex = 18;
            this.btn_NewItem.Text = "New Item";
            this.btn_NewItem.UseVisualStyleBackColor = true;
            this.btn_NewItem.Click += new System.EventHandler(this.btn_NewItem_Click);
            // 
            // btn_AddRow
            // 
            this.btn_AddRow.Location = new System.Drawing.Point(6, 3);
            this.btn_AddRow.Name = "btn_AddRow";
            this.btn_AddRow.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRow.TabIndex = 16;
            this.btn_AddRow.Text = "Add row";
            this.btn_AddRow.UseVisualStyleBackColor = true;
            this.btn_AddRow.Click += new System.EventHandler(this.btn_AddRow_Click);
            // 
            // weekPlanner
            // 
            this.weekPlanner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.weekPlanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekPlanner.Columns = dataColumns3;
            this.weekPlanner.CurrentDate = new System.DateTime(2011, 9, 9, 14, 3, 35, 690);
            this.weekPlanner.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.weekPlanner.DayCount = 7;
            this.weekPlanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekPlanner.GridBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.weekPlanner.GridCellHeight = 50;
            this.weekPlanner.GridTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.weekPlanner.HeaderColumnsFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner.HeaderDatesFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner.HeaderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.weekPlanner.HeaderFillLeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.weekPlanner.HeaderStyleMode = WeekPlanner.HeaderStyle.Aqua;
            this.weekPlanner.IsAllowedDraggingBetweenRows = true;
            this.weekPlanner.IsAllowedTreeViewDrawing = true;
            this.weekPlanner.ItemHeight = 20;
            this.weekPlanner.ItemTextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner.LeftMargin = 350;
            this.weekPlanner.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.weekPlanner.Location = new System.Drawing.Point(5, 105);
            this.weekPlanner.Name = "weekPlanner";
            this.weekPlanner.Size = new System.Drawing.Size(684, 331);
            this.weekPlanner.TabIndex = 1;
            this.weekPlanner.ItemDoubleClick += new WeekPlanner.CalendarPlanner.CalendarItemEventHandler(this.weekPlanner_ItemDoubleClick);
            this.weekPlanner.RowDoubleClick += new WeekPlanner.CalendarPlanner.CalendarRowEventHandler(this.weekPlanner_RowDoubleClick);
            this.weekPlanner.RowLeftColumnClick += new WeekPlanner.CalendarPlanner.CalendarRowLeftColumnEventHandler(this.weekPlanner_RowLeftColumnClick);
            this.weekPlanner.Load += new System.EventHandler(this.weekPlanner_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 441);
            this.Controls.Add(this.weekPlanner);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WeekPlanner.CalendarPlanner weekPlanner;
        private System.Windows.Forms.Button btn_MinusDay;
        private System.Windows.Forms.Button btn_PlusDay;
        private System.Windows.Forms.Button btn_DeleteRows;
        private System.Windows.Forms.Button btn_RemoveRow;
        private System.Windows.Forms.Button btn_SetItemDate;
        private System.Windows.Forms.Button btn_ClearColumn;
        private System.Windows.Forms.Button btn_DeleteItem;
        private System.Windows.Forms.Button btn_NewItem;
        private System.Windows.Forms.Button btn_AddRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

