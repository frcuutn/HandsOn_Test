import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'employees-data',
  templateUrl: './employees-data.component.html'
})
export class EmployeesDataComponent {
  public employees: Employee[];
  public isLoading: boolean = false;
  public employeeId: number;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  public get() {
    this.isLoading = true;
    this.http.get<Employee[]>(this.baseUrl + `api/Employees/EmployeesAsync/${this.employeeId || undefined}`).subscribe(result => {
      this.employees = result;
    }, error => console.error(error), () => { this.isLoading = false; });
  }

}

interface Employee {
  name: string;
  roleName: string;
  annualSalary: number;
}
