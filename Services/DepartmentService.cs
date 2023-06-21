using Microsoft.EntityFrameworkCore;
using SallesWebMvc.Data;
using SallesWebMvc.Models;
using System.Linq;

namespace SallesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SallesWebMvcContext _context;

        public DepartmentService(SallesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(s => s.Name).ToListAsync();
        }
        public Department GetByIdAsync(int id)
        {
            var ids = id;
            var department = _context.Department.Where(d => d.Id == ids).FirstOrDefault();
            return department;
        }
    }
}
