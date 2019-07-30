import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MarkComponent } from './components/mark/mark.component';


const routes: Routes = [
  {
    path: '',
    component: MarkComponent,
    data: { title: 'Marks' }
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
