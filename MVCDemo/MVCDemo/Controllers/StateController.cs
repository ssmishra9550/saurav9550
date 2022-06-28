using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class StateController : Controller
    {
        // GET: State
        public ActionResult Index()
        {
            StateContext stateContext = new StateContext();
            List<State> states = stateContext.states.ToList();
            return View(states);
        }
        public ActionResult Details( int Id)
        {
            StateContext stateContext = new StateContext();
            State state = stateContext.states.Single(statee => statee.State_id == Id);        
            return View(state);
        }
    }
}