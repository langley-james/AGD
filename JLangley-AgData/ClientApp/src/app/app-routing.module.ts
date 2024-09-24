import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RouterModule, Routes } from '@angular/router';
import { PersonComponent } from './person/person.component';

const routes: Routes = [
  { path: '', redirectTo: '/person', pathMatch: 'full' }, // Default route
  { path: 'person', component: PersonComponent }, // Route to PersonComponent
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
