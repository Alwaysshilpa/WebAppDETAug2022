using Microsoft.AspNetCore.Mvc;
using MVCDemo.FriendServices;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
  
    
        public class FriendController : Controller
        {
            public List<Friend> Friend { get; set; }
            public IActionResult Index()
            {
                List<Friend> Friends = FriendServices.FriendServices.GetAll();

                return View(Friends);
            }
        public IActionResult List()
        {
            List<Friend> friends = FriendServices.FriendServices.GetAll();
            return View(friends);
        }
        public IActionResult Details(int id)
        {
            Friend f = FriendServices.FriendServices.Get(id);
            return View(f);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Friend p)
        {
            FriendServices.FriendServices.Add(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Friend p = FriendServices.FriendServices.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(Friend p)
        {
            FriendServices.FriendServices.Delete(p.FriendID);
            return RedirectToAction("List");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Friend f)
        {
            FriendServices.FriendServices.Update(f);
            return RedirectToAction("List");
        }

    }
    

}
