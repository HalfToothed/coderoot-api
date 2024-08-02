using coderoot.DataLayer.Interfaces;
using coderoot.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderoot.DataLayer.Repositories
{
    public class ProblemRepository : IProblemRepository
    {
        private readonly DataContext _context;
        public ProblemRepository(DataContext context)
        {
            _context = context;
        }

        public async void Add(Problem problem)
        {
            await _context.Problem.AddAsync(problem);
            _context.SaveChanges();
        }
        
        public List<Problem> GetAllProblems()
        {
            return _context.Problem.ToList();
        }

        public List<Topic> GetAllTopics()
        {
            return _context.Topic.ToList();
        }
    }
}
