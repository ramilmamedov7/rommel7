using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NewsAgency.Models;

namespace NewsAgency
{
    public partial class Form1 : Form
    {
        private DatabaseEntities db = new DatabaseEntities();

        public Form1()
        {
            InitializeComponent();
            FillCategories();
            FillData();
        }

        private void FillData()
        {
            dgvNews.Rows.Clear();
            var list = db.News.Select(n => new
            {
                n.Title,
                n.CreatedAt,
                n.Content,
                n.ID
            }).ToList();

            foreach (var item in list)
            {
                dgvNews.Rows.Add(item.Title, item.CreatedAt, item.Content, GetList(item.ID));
            }
        }

        private string GetList(int newsId)
        {
            List<NewsToCategories> List = db.NewsToCategories.Where(nc => nc.NewsID == newsId).ToList();
            string result = "";
            List.ForEach(i => result += i.Categories.Name + " ");
            return result;
        }

        private void FillCategories()
        {
            List<Categories> List = db.Categories.ToList();
            List.ForEach(i => clbCategries.Items.Add(i.Name));
        }
        private void BtnAddClick(object sender, EventArgs e)
        {
            string title = rtbTitle.Text;
            DateTime date = dtpDate.Value;
            string content = rcbContent.Text;

            if (title == string.Empty || date == null || content == string.Empty)
            {
                MessageBox.Show("Bosluq buraxma");
                return;
            }

            News nws = new News();
            nws.Title = title;
            nws.CreatedAt = date;
            nws.Content = content;

            db.News.Add(nws);
            db.SaveChanges();
            NewsToCategories rel = new NewsToCategories();
            for (int i = 0; i < clbCategries.Items.Count; i++)
            {
                if (clbCategries.GetItemChecked(i))
                {
                    int CatId = this.getCategoryIdByName(clbCategries.Items[i].ToString());
                    rel.CategoryID = CatId;
                    rel.NewsID = nws.ID;
                    db.NewsToCategories.Add(rel);
                    db.SaveChanges();
                }
            }
            FillData();
        }

        private int getCategoryIdByName(string name)
        {
            return db.Categories.FirstOrDefault(c => c.Name == name).ID;
        }
    }
}
