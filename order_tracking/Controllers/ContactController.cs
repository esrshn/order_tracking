using Microsoft.AspNetCore.Mvc;

namespace order_tracking.Controllers
{
    public class ContactController : Controller
    {
        // Dependency Injection ile DbContext aldık
        private readonly ApplicationDbContext _dbContext;

        // Constructor: Bağımlılık enjeksiyonu
        public ContactController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Index Action - Kişileri listele
        public IActionResult Index()
        {
            var contacts = _dbContext.Contacts.ToList();  // Contact modeline göre liste alıyoruz
            return View(contacts); // View'e gönderiyoruz
        }

        // Create Action - Yeni Contact eklemek için
        public IActionResult Create()
        {
            return View();
        }

        // Create POST Action - Kişi eklemek için
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Contacts.Add(contact);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");  // Başarıyla ekledikten sonra Index'e yönlendir
            }
            return View(contact);
        }
    }
}
