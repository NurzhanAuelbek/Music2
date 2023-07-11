using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Music2.Data;
using Music2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class SharedController : Controller
{
	private readonly ApplicationDbContext _db;

	public SharedController(ApplicationDbContext db)
	{
		_db = db;
	}


	public IActionResult PlayerPartial()
	{
		IEnumerable<AudioTrack> objList = _db.AudioTracks;
		return View(objList);
	}
}