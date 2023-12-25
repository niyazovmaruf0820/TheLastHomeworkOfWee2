using Domain.Models;
namespace Infrastructure.Services;

public class GroupService
{
    public GroupService() {}
    List<Group> _groups = new List<Group>();

    public List<Group> GetGroups()
    {
        return _groups;
    }

    public void CreateGroup(Group group)
    {
        _groups.Add(group);   
    }

    public string UpdateGroup(Group newGroup)
    {
        foreach (var group in _groups)
        {
            if (group.FirstName == newGroup.FirstName)
            {
                group.LastName = newGroup.LastName;
                group.BirthDay = newGroup.BirthDay;
                group.Salary = newGroup.Salary;
                return "Group successfully updated";
            }
        }
        return "Group not found";
    }

    public string DeleteGroup(string firstName)
    {
        foreach (var group in _groups)
        {
            if (group.FirstName == firstName)
            {
                _groups.Remove(group);
                return "Group deleted successfully";
            }
        }
        return "Group not found";
    }
}
