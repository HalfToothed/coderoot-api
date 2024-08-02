using coderoot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderoot.DataLayer.Interfaces
{
    public interface IProblemRepository
    {
        void Add(Problem problem);
        List<Problem> GetAllProblems();
        List<Topic> GetAllTopics();
    }
}
