
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoginForm.Controllers
{
[HtppGet]
	public ActionResult auth(){

	return view();
}
//==================================================
[HtppPost]
	public ActionResult auth(mymodel obj){
	
	login database = new login();
	
	var res= database.mytable.Where(a=>a.email== obj.email).FirstorDefault();
	
	//==============================================
	
		if(res==null){
				tempdata["invalid"]="This is invalid email";
}
		else{
				if(res.email==obj.email && res.password==obj.password)
			{
				FormsAuthentication.SetAuthCookie(res.email, false);  // not saving in cookie
				
				return RedirectToAction("dashboard","home"); 
				
			}
				tempdata["no"]="Plz try again";
				return view();
}

	
			  return view();
}

		public ActionResult logoff()
		{
				FormsAuthentication.SignOut();
				return RedirectToAction("Index");
		
		}
	
	public ActionResult show(){
		
		helpentity database = new helpentity();
		
			List<mymodel> mm = new List<mymodel>
		
		foreach(var item in mymodel){
			
			mm.Add( new mm
			{
			mm.id=id,
			mm.name=name,
			mm.email=email
			});
			}
		
		database.mytable.Add(mm);
		database.saveChange();
		
		return RedirectToAction(mm);
		

	}

