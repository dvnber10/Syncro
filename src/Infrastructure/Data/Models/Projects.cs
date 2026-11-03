using System;
using System.ComponentModel.DataAnnotations;
using Domain.Enums;


namespace Infrastructure.Data.Models;

public class Projects
{
    [Key]

    public Guid Id { get; set;}

    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public DateTime FechaInicio { get; set; } = System.DateTime.Now;
    [Required]
    public DateTime FechaFin { get; set; } = System.DateTime.Now;
    public Estado_Proyecto Estado { get; set; } = Estado_Proyecto.En_proceso;
}
