using HandsOnAPIDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIDemo2.Repositories
{
    public class ProjectRepository
    {
        //GetAll Projects
        public List<Project> GetAll()
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                return db.Project.ToList();
            }
        }
        //Get Project By Id
        public Project GetById(int id)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                return db.Project.Find(id);
            }
        }
        //Add Project
        public void Add(Project item)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Project.Add(item);
                db.SaveChanges();
            }

        }
        //Delete Project
        public void Delete(int id)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                Project p = db.Project.Find(id);
                db.Project.Remove(p);
                db.SaveChanges();
            }
        }
        public  void Update(Project item)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Project.Update(item);
                db.SaveChanges();
            }
        }

    }
}
