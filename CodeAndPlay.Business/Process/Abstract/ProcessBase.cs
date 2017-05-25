using CodeAndPlay.Business.Commons;
using CodeAndPlay.Data.Contracts;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeAndPlay.Business.Process.Abstract
{
    public abstract class ProcessBase
    {
        protected IUnitOfWork UnitOfWork { get; private set; }

        public ProcessBase(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        protected bool IsValid(string controlNumber, int workshopId)
        {
            if (workshopId < 1 || workshopId > 3) return false;
            return IsValid(Constants.CTRL_NUM_PATTERN, controlNumber);
        }

        protected bool IsValid(string name, int eventId, string leader, params string[] members)
        {
            if (eventId < 1 || eventId > 3) return false;
            if (string.IsNullOrEmpty(leader)) return false;

            return IsValid(Constants.TEAM_NAME_PATTERN, name) && IsValid(Constants.CTRL_NUM_PATTERN, members) && members.Contains(leader);
        }

        protected bool IsValid(string pattern, params string[] strings)
        {
            if (strings == null && !strings.Any()) return false;
            if (string.IsNullOrEmpty(pattern)) return false;

            return strings.All(s => !string.IsNullOrEmpty(s) && Regex.IsMatch(s, pattern));
        }
    }
}
