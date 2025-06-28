#nullable enable

using Microsoft.EntityFrameworkCore;
using RabbitWarrenApi.Models;

namespace RabbitWarrenApi.Data;

public class RabbitWarrenContext : DbContext
{
    public RabbitWarrenContext(DbContextOptions<RabbitWarrenContext> options) : base(options)
    {
    }

    public DbSet<AdoptionRequest> AdoptionRequests => Set<AdoptionRequest>();
    public DbSet<Rabbit> Rabbits => Set<Rabbit>();
} 