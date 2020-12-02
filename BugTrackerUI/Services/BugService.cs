﻿using System.Collections.Generic;

namespace BugTrackerUI.Services
{
    public class BugService : IBugService
    {
        private List<Bug> Bugs = new List<Bug>();

        public void AddBug(Bug newBug)
        {
            newBug.Id = Bugs.Count + 1;
            Bugs.Add(newBug);
        }

        public List<Bug> GetBugs()
        {
            return Bugs;
        }
    }
}
