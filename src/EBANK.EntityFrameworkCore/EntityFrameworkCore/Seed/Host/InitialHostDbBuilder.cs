namespace EBANK.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly EBANKDbContext _context;

        public InitialHostDbBuilder(EBANKDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
