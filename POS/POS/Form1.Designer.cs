namespace POS
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
            this.price1 = new System.Windows.Forms.TextBox();
            this.item1 = new System.Windows.Forms.TextBox();
            this.item2 = new System.Windows.Forms.TextBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.amt = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.TextBox();
            this.cash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.add1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.purchasedView = new System.Windows.Forms.ListView();
            this.itemView = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.ctr = new System.Windows.Forms.Label();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flyoutPanel2 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl2 = new DevExpress.Utils.FlyoutPanelControl();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel2)).BeginInit();
            this.flyoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).BeginInit();
            this.flyoutPanelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // price1
            // 
            this.price1.Location = new System.Drawing.Point(86, 33);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(100, 20);
            this.price1.TabIndex = 1;
            this.price1.Text = "0";
            this.price1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price1_KeyPress);
            // 
            // item1
            // 
            this.item1.Location = new System.Drawing.Point(86, 7);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(100, 20);
            this.item1.TabIndex = 0;
            // 
            // item2
            // 
            this.item2.Location = new System.Drawing.Point(359, 71);
            this.item2.Name = "item2";
            this.item2.ReadOnly = true;
            this.item2.Size = new System.Drawing.Size(100, 20);
            this.item2.TabIndex = 0;
            // 
            // price2
            // 
            this.price2.Location = new System.Drawing.Point(359, 97);
            this.price2.Name = "price2";
            this.price2.ReadOnly = true;
            this.price2.Size = new System.Drawing.Size(100, 20);
            this.price2.TabIndex = 0;
            this.price2.Text = "0";
            this.price2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item2_KeyPress);
            // 
            // amt
            // 
            this.amt.Location = new System.Drawing.Point(359, 149);
            this.amt.Name = "amt";
            this.amt.ReadOnly = true;
            this.amt.Size = new System.Drawing.Size(100, 20);
            this.amt.TabIndex = 0;
            this.amt.Text = "0";
            this.amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item2_KeyPress);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(359, 123);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(100, 20);
            this.qty.TabIndex = 2;
            this.qty.Text = "0";
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item2_KeyPress);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(359, 291);
            this.change.Name = "change";
            this.change.ReadOnly = true;
            this.change.Size = new System.Drawing.Size(100, 20);
            this.change.TabIndex = 0;
            this.change.Text = "0";
            this.change.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item2_KeyPress);
            // 
            // st
            // 
            this.st.Location = new System.Drawing.Point(359, 239);
            this.st.Name = "st";
            this.st.ReadOnly = true;
            this.st.Size = new System.Drawing.Size(100, 20);
            this.st.TabIndex = 0;
            this.st.Text = "0";
            this.st.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item2_KeyPress);
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(359, 265);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(100, 20);
            this.cash.TabIndex = 3;
            this.cash.Text = "0";
            this.cash.TextChanged += new System.EventHandler(this.cash_TextChanged);
            this.cash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Item Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Subtotal :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cash :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Change :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "SC (8%)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(359, 201);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Senior Citizen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(192, 8);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(55, 45);
            this.add1.TabIndex = 4;
            this.add1.Text = "ADD";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "CASH OUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 63);
            this.button3.TabIndex = 4;
            this.button3.Text = "VOID";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(359, 330);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(55, 63);
            this.add2.TabIndex = 4;
            this.add2.Text = "ADD";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // purchasedView
            // 
            this.purchasedView.FullRowSelect = true;
            this.purchasedView.Location = new System.Drawing.Point(500, 52);
            this.purchasedView.Name = "purchasedView";
            this.purchasedView.Size = new System.Drawing.Size(319, 341);
            this.purchasedView.TabIndex = 1;
            this.purchasedView.UseCompatibleStateImageBehavior = false;
            // 
            // itemView
            // 
            this.itemView.FullRowSelect = true;
            this.itemView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemView.Location = new System.Drawing.Point(15, 59);
            this.itemView.MultiSelect = false;
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(251, 334);
            this.itemView.TabIndex = 1;
            this.itemView.UseCompatibleStateImageBehavior = false;
            this.itemView.Click += new System.EventHandler(this.itemView_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "No. Of Items :";
            // 
            // ctr
            // 
            this.ctr.AutoSize = true;
            this.ctr.Location = new System.Drawing.Point(602, 406);
            this.ctr.Name = "ctr";
            this.ctr.Size = new System.Drawing.Size(13, 13);
            this.ctr.TabIndex = 2;
            this.ctr.Text = "0";
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(500, 33);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(340, 347);
            this.flyoutPanel1.TabIndex = 5;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.flyoutPanelControl1.Controls.Add(this.label14);
            this.flyoutPanelControl1.Controls.Add(this.label20);
            this.flyoutPanelControl1.Controls.Add(this.label19);
            this.flyoutPanelControl1.Controls.Add(this.label17);
            this.flyoutPanelControl1.Controls.Add(this.label16);
            this.flyoutPanelControl1.Controls.Add(this.label18);
            this.flyoutPanelControl1.Controls.Add(this.label24);
            this.flyoutPanelControl1.Controls.Add(this.label23);
            this.flyoutPanelControl1.Controls.Add(this.label22);
            this.flyoutPanelControl1.Controls.Add(this.label15);
            this.flyoutPanelControl1.Controls.Add(this.label26);
            this.flyoutPanelControl1.Controls.Add(this.label25);
            this.flyoutPanelControl1.Controls.Add(this.label13);
            this.flyoutPanelControl1.Controls.Add(this.label12);
            this.flyoutPanelControl1.Controls.Add(this.label1);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(340, 347);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(107, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Quantity";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(630, 577);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Item";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(434, 435);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Item";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(436, 393);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Item";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(243, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Cash :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(230, 272);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Change :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(286, 272);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(286, 251);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(286, 232);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(242, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(192, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Item";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(127, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Item";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Item";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Item";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Item Name :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "VIEW REPORTS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flyoutPanel2
            // 
            this.flyoutPanel2.Controls.Add(this.flyoutPanelControl2);
            this.flyoutPanel2.Location = new System.Drawing.Point(1, 4);
            this.flyoutPanel2.Name = "flyoutPanel2";
            this.flyoutPanel2.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanel2.Options.CloseOnOuterClick = true;
            this.flyoutPanel2.OwnerControl = this;
            this.flyoutPanel2.Size = new System.Drawing.Size(684, 412);
            this.flyoutPanel2.TabIndex = 7;
            // 
            // flyoutPanelControl2
            // 
            this.flyoutPanelControl2.Controls.Add(this.listView1);
            this.flyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl2.FlyoutPanel = this.flyoutPanel2;
            this.flyoutPanelControl2.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl2.Name = "flyoutPanelControl2";
            this.flyoutPanelControl2.Size = new System.Drawing.Size(684, 412);
            this.flyoutPanelControl2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 363);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemView);
            this.Controls.Add(this.purchasedView);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.st);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.change);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.flyoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.flyoutPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel2)).EndInit();
            this.flyoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).EndInit();
            this.flyoutPanelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.TextBox item1;
        private System.Windows.Forms.TextBox item2;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox change;
        private System.Windows.Forms.TextBox st;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.ListView purchasedView;
        private System.Windows.Forms.ListView itemView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ctr;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private DevExpress.Utils.FlyoutPanel flyoutPanel2;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}

