﻿using Entities;
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
        public void Add(Contact c)
        {
            c.contactid = DLL.lastId++;
            if(c.phone == null )
            {
                c.phone = "Not Available";
            }
            DLL.contactList.Add(c);

        }
        

        public void Delete(Contact c)
        {
            DLL.contactList.Where(x => x.Active == false);
        }
        public Contact Details(int id)
        {
            return DLL.contactList.Where(x => x.contactid == id).Single();

        }
        public List<Contact> getAll()
        {
            DLL.contactList.Where(x => x.Active == true);
            return DLL.contactList;

        }

        public void Update(Contact c)
        {
            if (c.phone == null)
            {
                c.phone = "Not Available";
            }
            else
            {
                var tempRecord = DLL.contactList.Where(x => x.contactid == c.contactid).Single();
                tempRecord.first = c.first;
                tempRecord.last = c.last;
                tempRecord.phone = c.phone;
                tempRecord.Bphone = c.Bphone;
                tempRecord.address = c.address;
                tempRecord.notes = c.notes;
                tempRecord.Active = c.Active;
            }
        }
    }
}
