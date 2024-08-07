import { AsyncPipe } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HttpClientModule, AsyncPipe, FormsModule, ReactiveFormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  http = inject(HttpClient)

  levelForms = new FormGroup({
    level: new FormControl<number>(0),
    levelToAchieve: new FormControl<number>(0),
    xpPossessed: new FormControl<number>(0),
    xpGivenByActivity: new FormControl<number>(0)
  })

  result: any = null;
  
  onFormSubmit(){
    console.log(this.levelForms.value)
    const calculateXpNeededRequest = {
      level: this.levelForms.value.level,
      levelToAchieve: this.levelForms.value.levelToAchieve,
      xpPossessed: this.levelForms.value.xpPossessed,
      xpGivenByActivity: this.levelForms.value.xpGivenByActivity
    }

    this.http.post("http://localhost:5160/level", calculateXpNeededRequest)
    .subscribe(
      {
        next: (value) => {
          console.log(value)
          this.result = value
          this.levelForms.reset();
        }
      }
    )
  }
}