using EntityFrameworkCore.Data;


using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;

using var context = new FootballLeagueDbContext();

//selecting a single record

var teamOne = await context.Teams.FirstAsync();

var teamTwo = await context.Teams.FirtAsync(taem => team.TeamId == 1);

var teamThree = await context.Teams.FirstAsync(teamOne => teamOne.TeamId == 2);

void GetAllTeams()
{
    var teams = context.Teams.ToList();

    foreach (var t in teams)
    {
        Console.WriteLine(team.Name);
    }
}