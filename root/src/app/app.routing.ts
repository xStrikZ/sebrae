import { Routes } from '@angular/router';

import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { SebraeLayoutComponent } from './layouts/sebrae-layout/sebrae-layout.component';

export const AppRoutes: Routes = [
  {
    path: '',
    redirectTo: 'dashboard',
    pathMatch: 'full',
  }, 
  {
    path: '',
    component: AdminLayoutComponent,
    children: [
        {
      path: '',
      loadChildren: './layouts/admin-layout/admin-layout.module#AdminLayoutModule'
  }]},
  {
    path: 'dashboard',
    component: SebraeLayoutComponent,
    children: [
        {
      path: '',
      loadChildren: './layouts/sebrae-layout/sebrae-layout.module#SebraeLayoutModule'
  }]},
  {
    path: '**',
    redirectTo: 'dashboard'
  }
]
