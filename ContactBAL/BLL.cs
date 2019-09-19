using Entities;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDAL;
using System.Collections.Generic;

namespace ContactBAL
{
    public class BLL
    {
        public List<Contact> getAll()
        {
            return DLL.contactList.Where(x => x.Active == true).ToList();

        }

        public void Add(Contact c)
        {
            c.contactid = DLL.lastId++;
            c.Active = true;
            DLL.contactList.Add(c);
            if (c.phone == null)
            {
                c.phone = "Not Available";
            }

        }
        public void Delete(int id)
        {
            var tempRecord = DLL.contactList.Where(x => x.contactid == id).Single();
            tempRecord.Active = false;
            //Details(id).Active = false;
        }

        public Contact Details(int id)
        {
            return DLL.contactList.Where(x => x.contactid == id).Single();

        }

        public void Update(Contact c)
        {
            var tempRecord = DLL.contactList.Where(x => x.contactid == c.contactid).Single();

            
            tempRecord.first = c.first;
            tempRecord.last = c.last;
            tempRecord.phone = c.phone;
            tempRecord.Bphone = c.Bphone;
            tempRecord.address = c.address;
            tempRecord.notes = c.notes;
            tempRecord.Active = c.Active;
            //if (c.phone == null)
            //{
            //    c.phone = "Not Available";
            //}
        }
    }
}
