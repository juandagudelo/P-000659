import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MarkComponent } from './components/mark/mark.component';
import { MarkService } from './services/marks.service';
import { HttpClientModule } from '@angular/common/http';
import { SubjectService } from './services/subjects.service';

@NgModule({
  declarations: [
    AppComponent,
    MarkComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule 
  ],
  providers: [MarkService, SubjectService],
  bootstrap: [AppComponent]
})
export class AppModule { }
