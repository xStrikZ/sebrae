import { Component, OnInit } from '@angular/core';


export interface RouteInfo {
    path: string;
    title: string;
    icon: string;
    class: string;
}

export const ROUTES: RouteInfo[] = [
    { path: '/dashboard',     title: 'Home',              icon:'nc-bank',       class: '' },
    { path: '/rewards',       title: 'Pontos',            icon:'nc-diamond',    class: '' },
    { path: '/situation',     title: 'Situação',          icon:'nc-chat-33',    class: '' },
    { path: '/maps',          title: 'Localização',       icon:'nc-map-big',    class: '' },
    { path: '/user',          title: 'Home',              icon:'nc-bank',       class: '' },
    { path: '/table',         title: 'Empresas',          icon:'nc-shop',       class: '' },
    // { path: '/typography',    title: 'Typography',        icon:'nc-caps-small', class: '' },
    // { path: '/upgrade',       title: 'Upgrade to PRO',    icon:'nc-spaceship',  class: 'active-pro' },
];

@Component({
    moduleId: module.id,
    selector: 'sidebar-cmp',
    templateUrl: 'sidebar.component.html',
})

export class SidebarComponent implements OnInit {
    public menuItems: any[];
    ngOnInit() {
        this.menuItems = ROUTES.filter(menuItem => menuItem);
    }
}
