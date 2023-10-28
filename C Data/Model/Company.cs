﻿namespace Data.Model;

public class Company : Base 
{
    public string? Name { get; set; }
    public string? Mail { get; set; }
    public string? Description { get; set; }
    public string? Ruc { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? ProfilePicture { get; set; }
    public int RepresentanteId { get; set; }
    public Representante Representante { get; set; }
    public List<Answer> Responses { get; set; }
}