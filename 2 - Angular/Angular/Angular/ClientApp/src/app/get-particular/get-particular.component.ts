import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-get-particular',
  templateUrl: './get-particular.component.html'
})

export class GetParticularComponent {
  public forecast: WeatherForecast;
  public forecasts: WeatherForecast[] = [];
  public id: number;
  public http: HttpClient;
  public url: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));

    http.get<WeatherForecast>(baseUrl + 'getparticular?id=' + this.id).subscribe(result => {
      this.forecast = result;
    }, error => console.error(error));

    this.http = http;
    this.url = baseUrl;
  }

  getItem(): void {
    if (this.id > this.forecasts.length) {
      this.forecast = undefined;
    }
    else {
      this.http.get<WeatherForecast>(this.url + 'getparticular?id=' + this.id).subscribe(result => {
        this.forecast = result;
      }, error => console.error(error));
    }
  }
}



interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
