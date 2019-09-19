using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sheet3.Models
{
    public class DBManager
    {
        ContactBAL.BLL newBLL = new ContactBAL.BLL();

        public void Add(Contact c)
        {
            newBLL.Add(c);
        }
        public List<Contact> getAll()
        {

            return newBLL.getAll();
        }
        public void Delete(int id)
        {
            newBLL.Delete(id);

        }
        public void Update(Contact c)
        {
            newBLL.Update(c);
        }
        public Contact Details(int id)
        {
            return newBLL.Details(id);
        }
    }
}