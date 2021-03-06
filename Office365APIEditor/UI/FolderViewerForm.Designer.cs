﻿namespace Office365APIEditor
{
    partial class FolderViewerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderViewerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_ItemList = new System.Windows.Forms.DataGridView();
            this.dataGridView_ItemProps = new System.Windows.Forms.DataGridView();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_ItemList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_DisplayAttachments = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip_ItemList_DraftItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_DisplayAttachments_DraftItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Edit_DraftItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemProps)).BeginInit();
            this.contextMenuStrip_ItemList.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip_ItemList_DraftItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_ItemList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_ItemProps);
            this.splitContainer1.Size = new System.Drawing.Size(881, 469);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView_ItemList
            // 
            this.dataGridView_ItemList.AllowUserToAddRows = false;
            this.dataGridView_ItemList.AllowUserToDeleteRows = false;
            this.dataGridView_ItemList.AllowUserToOrderColumns = true;
            this.dataGridView_ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ItemList.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ItemList.MultiSelect = false;
            this.dataGridView_ItemList.Name = "dataGridView_ItemList";
            this.dataGridView_ItemList.ReadOnly = true;
            this.dataGridView_ItemList.Size = new System.Drawing.Size(881, 214);
            this.dataGridView_ItemList.TabIndex = 0;
            this.dataGridView_ItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ItemList_CellClick);
            this.dataGridView_ItemList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ItemList_CellDoubleClick);
            this.dataGridView_ItemList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ItemList_CellMouseClick);
            // 
            // dataGridView_ItemProps
            // 
            this.dataGridView_ItemProps.AllowUserToAddRows = false;
            this.dataGridView_ItemProps.AllowUserToDeleteRows = false;
            this.dataGridView_ItemProps.AllowUserToOrderColumns = true;
            this.dataGridView_ItemProps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ItemProps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Property,
            this.Value,
            this.Type});
            this.dataGridView_ItemProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ItemProps.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ItemProps.Name = "dataGridView_ItemProps";
            this.dataGridView_ItemProps.ReadOnly = true;
            this.dataGridView_ItemProps.Size = new System.Drawing.Size(881, 251);
            this.dataGridView_ItemProps.TabIndex = 0;
            this.dataGridView_ItemProps.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ItemProps_CellDoubleClick);
            // 
            // Property
            // 
            this.Property.HeaderText = "Property";
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // contextMenuStrip_ItemList
            // 
            this.contextMenuStrip_ItemList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_ItemList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_DisplayAttachments});
            this.contextMenuStrip_ItemList.Name = "contextMenuStrip_ItemList";
            this.contextMenuStrip_ItemList.Size = new System.Drawing.Size(193, 26);
            this.contextMenuStrip_ItemList.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_ItemList_Opening);
            // 
            // ToolStripMenuItem_DisplayAttachments
            // 
            this.ToolStripMenuItem_DisplayAttachments.Name = "ToolStripMenuItem_DisplayAttachments";
            this.ToolStripMenuItem_DisplayAttachments.Size = new System.Drawing.Size(192, 22);
            this.ToolStripMenuItem_DisplayAttachments.Text = "Display Attachments...";
            this.ToolStripMenuItem_DisplayAttachments.Click += new System.EventHandler(this.ToolStripMenuItem_DisplayAttachments_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Status
            // 
            this.toolStripStatusLabel_Status.Name = "toolStripStatusLabel_Status";
            this.toolStripStatusLabel_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // contextMenuStrip_ItemList_DraftItem
            // 
            this.contextMenuStrip_ItemList_DraftItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_ItemList_DraftItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_DisplayAttachments_DraftItem,
            this.toolStripMenuItem_Edit_DraftItem});
            this.contextMenuStrip_ItemList_DraftItem.Name = "contextMenuStrip_ItemList";
            this.contextMenuStrip_ItemList_DraftItem.Size = new System.Drawing.Size(193, 70);
            // 
            // toolStripMenuItem_DisplayAttachments_DraftItem
            // 
            this.toolStripMenuItem_DisplayAttachments_DraftItem.Name = "toolStripMenuItem_DisplayAttachments_DraftItem";
            this.toolStripMenuItem_DisplayAttachments_DraftItem.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem_DisplayAttachments_DraftItem.Text = "Display Attachments...";
            this.toolStripMenuItem_DisplayAttachments_DraftItem.Click += new System.EventHandler(this.ToolStripMenuItem_DisplayAttachments_DraftItem_Click);
            // 
            // toolStripMenuItem_Edit_DraftItem
            // 
            this.toolStripMenuItem_Edit_DraftItem.Name = "toolStripMenuItem_Edit_DraftItem";
            this.toolStripMenuItem_Edit_DraftItem.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem_Edit_DraftItem.Text = "Edit...";
            this.toolStripMenuItem_Edit_DraftItem.Click += new System.EventHandler(this.ToolStripMenuItem_Edit_DraftItem_Click);
            // 
            // FolderViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 491);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FolderViewerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FolderViewerForm_FormClosing);
            this.Load += new System.EventHandler(this.FolderViewerForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemProps)).EndInit();
            this.contextMenuStrip_ItemList.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip_ItemList_DraftItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_ItemList;
        private System.Windows.Forms.DataGridView dataGridView_ItemProps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ItemList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DisplayAttachments;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ItemList_DraftItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DisplayAttachments_DraftItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit_DraftItem;
    }
}