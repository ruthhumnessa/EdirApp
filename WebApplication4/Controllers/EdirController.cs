using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModels;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{
    public class EdirController : Controller
    {
        // GET: Edir


        private ApplicationDbContext _context;
        public EdirController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //[Authorize]
        public ViewResult Index()
        {
            var edirs = _context.Edirs.Include(c => c.EdirType).ToList();

            if (User.IsInRole("CanManageEdirs"))
            {
                return View("index",edirs);
            }else
                return View( "ReadOnlyIndex", edirs);
        }

        public ActionResult Details(int id)
        {
            var edir = _context.Edirs.Include(c=>c.EdirType).
                SingleOrDefault(c => c.Id == id);

            if (edir == null)
            {
                return HttpNotFound();
            }
            return View(edir);
        }

        public ActionResult New()
        {
            var edirTypes = _context.EdirTypes.ToList();
            var viewModel = new NewEdirViewModel
            {
                EdirTypes = edirTypes
            };
            if (User.IsInRole("CanManageEdirs"))
            {
                return View(viewModel);
            }
            else
                return View("AccessDenied");
            
        }
       
        [HttpPost]
        
        public ActionResult Create(Edir edir)

        {
        //    if (!ModelState.IsValid)
        //    {
        //        var viewModel = new NewEdirViewModel
        //        {
        //            Edir = edir,
        //            EdirTypes = _context.EdirTypes.ToList()
        //        };
        //        return View("New", viewModel);
        //    }


            if (edir.Id == 0)
                {
                    _context.Edirs.Add(edir);
                }
                else
                {
                    var edirInDb = _context.Edirs.Single(c => c.Id == edir.Id);
                    edirInDb.Name = edir.Name;
                    edirInDb.EdirTypeId = edir.EdirTypeId;
                    edirInDb.Subcity = edir.Subcity;
                    edirInDb.Wereda = edir.Wereda;
                    edirInDb.Email = edir.Email;
                }
                _context.SaveChanges();
                return RedirectToAction("Index", "Edir");
            
        }

        public ActionResult Edit(int id)
        {
            var edir = _context.Edirs.SingleOrDefault(c => c.Id == id);
            if (edir == null)
            {
                return HttpNotFound();
            }
            else
            {
                var viewModel = new NewEdirViewModel
                {
                    Edir = edir,
                    EdirTypes = _context.EdirTypes.ToList()
                };
                return View("New",viewModel);
            }

        }



        public ActionResult Delete(int id)
        {
            var viewModel = new NewEdirViewModel
            {
                EdirTypes = _context.EdirTypes.ToList()

            };

            var edir = _context.Edirs.FirstOrDefault(c => c.Id == id);

            if (edir != null)
                _context.Edirs.Remove(edir);
                _context.SaveChanges();


            return RedirectToAction("Index", "Edir");

     
        }

        public ActionResult Permit(int id)
        {
            var viewModel = new NewEdirViewModel
            {
                EdirTypes = _context.EdirTypes.ToList()

            };

            var edir = _context.Edirs.FirstOrDefault(c => c.Id == id);

            if (edir != null)
                _context.Edirs.Remove(edir);
            _context.SaveChanges();


            return RedirectToAction("Index", "Customer");


        }

        public string CurrentFilter { get; set; }
        public IList<Edir> Edir { get; set; }
        public async Task<ActionResult> Search(string SearchString)
        {

            //var edirs = _context.Edirs.Include(c => c.EdirType).ToList();
            CurrentFilter = SearchString;

            IQueryable<Edir> edirr = from s in _context.Edirs.Include(c => c.EdirType) select s;
            if (!String.IsNullOrEmpty(SearchString))
            {
                edirr = edirr.Where(s => s.Name.Contains(SearchString));
            }

            Edir = await edirr.AsNoTracking().ToListAsync();

            return View("Index",Edir);

        }

        public async Task<ActionResult> SearchSelected(string SearchString)
        {

            //var edirs = _context.Edirs.Include(c => c.EdirType).ToList();
            CurrentFilter = SearchString;

            IQueryable<Edir> edirr = from s in _context.Edirs.Include(c => c.EdirType) select s;
            if (!String.IsNullOrEmpty(SearchString))
            {
                edirr = edirr.Where(s => s.Subcity.Contains(SearchString));
            }

            Edir = await edirr.AsNoTracking().ToListAsync();

            return View("ReadOnlyIndex", Edir);

        }

    } 
}