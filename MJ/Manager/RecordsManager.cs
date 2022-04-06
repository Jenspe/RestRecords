﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestRecords.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace RestRecords.Manager
{
    public class RecordsManager
    {
        private static int _nextId = 1;

        private static readonly List<Record> Data = new List<Record>()
        {
            new Record() {Title = "titletest1", Id = _nextId++, ArtistName = "John"},
            new Record() {Title = "titletest2", Id = _nextId++, ArtistName = "Henry"},
            new Record() {Title = "titletest3", Id = _nextId++, ArtistName = "Ben"}
        };

        public Record GetById(int id)
        {
            return Data.Find(record => record.Id == id);
        }

        public List<Record> GetAll()
        {
            return Data;
        }

        public Record Add(Record newRecord)
        {
            newRecord.Id = _nextId;
            Data.Add(newRecord);
            return newRecord;
        }

        public Record Delete(int id)
        {
            Record record = Data.Find(Record => Record.Id == id);
            if (record == null) return null;
            Data.Remove(record);
            return record;
        }

        






    }
}