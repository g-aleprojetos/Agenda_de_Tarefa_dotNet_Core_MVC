using Agenda_Tarefa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Tarefa.ViewComponents
{
    public class ListaTarefasViewComponent : ViewComponent
    {
        private readonly Contexto _context;

        public ListaTarefasViewComponent(Contexto contexto)
        {
            _context = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync(string data)
        {
            return View(await _context.Tarefas
                .OrderBy(t => t.Horario).Where(t => t.Data == data).ToListAsync());
        }
    }
}
