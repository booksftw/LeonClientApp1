import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Client } from '../models/client';

@Component({
  selector: 'app-review-client',
  templateUrl: './review-client.component.html',
  styleUrls: ['./review-client.component.css']
})
export class ReviewClientComponent implements OnInit {
  clients: Client[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
    this.http.get(this.baseUrl + 'api/Client/GetAllClients')
      .subscribe((result: Client[]) => {
        console.log("result", result)
        this.clients = result;
      }, error => {

        console.error(error)
      });
  }

  deleteClient(id): void {

    this.clients = this.clients.filter(c => c.id !== id);

    // call the end point
    this.http.delete(`${this.baseUrl}api/Client/${id}`)
      .subscribe
      (
        r => console.log("esult: ", r),
        e => console.error(e)
      );

  }

}
