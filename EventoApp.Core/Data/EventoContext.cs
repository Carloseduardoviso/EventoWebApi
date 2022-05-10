using EventoApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoApp.Core.Data;

public class EventoContext : DbContext
{
    public DbSet<Evento> Eventos { get; set; } = default!;
    public EventoContext(DbContextOptions<EventoContext> options)
        : base(options)
    {
    }
}
