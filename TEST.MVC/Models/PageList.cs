using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEST.MVC.Web.Models
{
    public class PageList
    {
        public bool prevSpot { get; set; }
        public bool nextSpot { get; set; }
        public int firstNum { get; set; }
        public int lastNum { get; set; }
        public int showPageNum { get; set; }
        public int total { get; set; }
        public int curPage { get; set; }
        public int pageSize { get; set; }
        public int totalPages
        {
            get
            {
                return (int)Math.Ceiling((double)total / pageSize);
            }
        }
        public List<int> pageList { get; set; }


        public PageList(int curPage, int total, int pageSize = 10, int showPageNum = 9)
        {
            this.total = total;
            this.pageSize = pageSize;
            this.curPage = curPage;
            this.showPageNum = showPageNum;
            this.firstNum = 1;
            this.lastNum = this.totalPages;
            this.pageList = this.GetPageList();
        }

        public List<int> GetPageList()
        {
            var plist = new List<int>();
            if (totalPages <= showPageNum)
            {
                for (int i = 2; i < totalPages; i++)
                {
                    plist.Add(i);
                }
            }
            else
            {
                var half = (int)((showPageNum + 1) / 2) - 1;
                if (curPage - half > 1 && curPage + half < totalPages)
                {
                    this.prevSpot = this.nextSpot = true;
                    for (int i = curPage - half + 1; i < curPage + half; i++)
                    {
                        plist.Add(i);
                    }
                }
                else if (curPage - half > 1)
                {
                    this.prevSpot = true;
                    for (int i = totalPages - 1; i > totalPages - showPageNum + 2; i--)
                    {
                        plist.Add(i);
                    }
                }
                else if (curPage - half <= 1)
                {
                    this.nextSpot = true;
                    for (int i = 2; i < showPageNum; i++)
                    {
                        plist.Add(i);
                    }
                }
            }

            return plist.OrderBy(x => x).ToList();
        }
    }
}