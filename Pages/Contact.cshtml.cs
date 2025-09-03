using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContactModel : PageModel
{
    [BindProperty]
    public ContactForm Contact { get; set; } = new();
    public bool Submitted { get; set; }

    public void OnGet() { }

    public void OnPost()
    {
        Submitted = true; // Pretend we sent the message somewhere
    }
}

public class ContactForm
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}
