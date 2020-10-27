using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{
                    Id=0, 
                    HowTo="How to generate migration",
                    Platform=".NET Core EF",
                    CommandLine="dotnet ef migrations add <name of migration>"
                },
                new Command{
                    Id=1,
                    HowTo="Run migrations",
                    Platform=".NET Core EF",
                    CommandLine="dotnet ef database update"
                },
                new Command{
                    Id=2,
                    HowTo="List active migrations",
                    Platform=".NET Core EF",
                    CommandLine="dotnet ef migrations list"
                }
            };
            return commands;
        }

        public Command GetCommandsById(int id)
        {
            return new Command{
                Id=0,
                HowTo="How to generate migrations",
                Platform=".NET Core EF",
                CommandLine="dotnet ef migrations add <name of migration>"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}