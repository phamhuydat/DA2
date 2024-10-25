using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Areas.Components.ListRole
{
	public class ListRoleViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public ListRoleViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(int? seletetedId, IEnumerable<int> excludeIds)
		{
			var data = await repository
					.GetAll<Role>(where: r => excludeIds == null || excludeIds.Any() && !excludeIds.Contains(r.Id))
					.ToListAsync();

			ViewBag.SelectedId = seletetedId;
			return View(data);
		}
	}
}
