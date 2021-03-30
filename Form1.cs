﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using System.IO;


namespace PdfMerger2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private string GetFileName()
        {
            OpenFileDialog request = new OpenFileDialog();
            request.Filter = "Pdf Files|*.pdf";

            if (request.ShowDialog() == DialogResult.OK)
            {
                return request.FileName;
            }
            return "Empty";
        }
        private string GetResultName()
        {
            Random rand = new Random();
            SaveFileDialog result = new SaveFileDialog();
            result.Filter = "Pdf Files|*.pdf";
            if (result.ShowDialog() == DialogResult.OK)
            {
                return result.FileName;
            }
            return "Empty";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] d = new string[selected_pdfs.Items.Count];
            for ( int i = 0; i < selected_pdfs.Items.Count; i++)
            {
                d[i] = selected_pdfs.Items[i].ToString();
            }

            string r;
            r = GetResultName();
            if (r != "Empty") 
            {
                PdfDocumentBase doc = PdfDocument.MergeFiles(d);
                doc.Save(r, FileFormat.PDF);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string d;
            d = GetFileName();
            if (d != "Empty")
            {
                selected_pdfs.Items.Add(d); 
            }

        }

        private void selected_pdfs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d = selected_pdfs.SelectedIndex;
            if (d >= 0) { selected_pdfs.Items.RemoveAt(d);  }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //To signal the end of the program
            Console.WriteLine("I've done!");
        }
        private void selected_pdfs_DragDrop(object sender, DragEventArgs e)
        {
            string[] Filel = (string[]) e.Data.GetData(DataFormats.FileDrop, true);
            selected_pdfs.Items.Add(Filel[0]);
        }

        private void selected_pdfs_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
