using System.Collections.Generic;

public class Adapatador : IHRSystem
{
	private HRSystem _system;
	public Adapatador(HRSystem system)
	{
		_system = system;
	}
	public List<string> GetEmployees()
	{
		string [][] result = _system.GetEmployees();

		List<string> employeeList = new List<string>();
		foreach (string[] employee in result)
		{
			employeeList.Add(employee[0]);
			employeeList.Add(",");
			employeeList.Add(employee[1]);
			employeeList.Add(",");
			employeeList.Add(employee[2]);
			employeeList.Add("\n");
		}
		return employeeList;
	}
}

