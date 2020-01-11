import { Component, Inject, OnChanges } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-add-client',
  templateUrl: './add-client.component.html',
  styleUrls: ['./add-client.component.css']
})

export class AddClientComponent {

  showSubmissionSuccessIndicator = false;
  showSubmissionFailureIndicator = false;

  profileForm = this.fb.group({
    firstName: ['', Validators.required],
    lastName: [''],
    birthday: ['', Validators.required],
    email: ['', Validators.email],
    totalSpending: [''],
    notes: ['']
  });


  constructor(private fb: FormBuilder, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  onSubmit() {
    console.warn(this.profileForm.value);

    this.http.post(this.baseUrl + 'api/Client/AddClient', this.profileForm.value)
      .subscribe(result => {
        this.showFormIndicatorAnimation(true)
      }, error => {
        this.showFormIndicatorAnimation(false)
        console.error(error)
      });

  }

  showFormIndicatorAnimation(submissionIsSuccessful) {
    if (submissionIsSuccessful) {
      this.showSubmissionSuccessIndicator = true;
      setTimeout(_ => this.showSubmissionSuccessIndicator = false, 4000)
    } else {
      this.showSubmissionFailureIndicator = true;
      setTimeout(_ => this.showSubmissionFailureIndicator = false, 4000)
    }
  }
}
