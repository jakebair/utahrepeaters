export const adminLteConf = {
    skin: 'blue',
    isSidebarLeftCollapsed: true,
    sidebarLeftMenu: [
        {label: 'Repeaters', iconClasses: 'fa fa-flag', children: [
            {label: '2m', route: '/map/2m', iconClasses: 'fa fa-map-pin'},
            {label: '70cm', route: '/map/70cm', iconClasses: 'fa fa-map-pin'},
            {label: 'Intertie', route: '/map/intertie', iconClasses: 'fa fa-map-pin'},
            {label: 'SDARC Sinbad', route: '/map/sdarc', iconClasses: 'fa fa-map-pin'},
            {label: '1.25m', route: '/map/1.25m', iconClasses: 'fa fa-map-pin'},
            {label: '6m', route: '/map/6m', iconClasses: 'fa fa-map-pin'},
            {label: '23cm', route: '/map/23cm', iconClasses: 'fa fa-map-pin'},
            {label: '33cm', route: '/map/33cm', iconClasses: 'fa fa-map-pin'},
        ]
        }
    ]
};
