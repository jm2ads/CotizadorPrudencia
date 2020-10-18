markerArray = new Array();
var markers;
function initialize(urlBase, mapUser) {
  
   
    
    let myMap = L.map('myMap').setView([-37.11026,-56.86950], 15)
  
    const urlOpenLayers = 'https://a.tile.openstreetmap.org/{z}/{x}/{y}.png'
    L.tileLayer(urlOpenLayers, {
        maxZoom: 15,
    }).addTo(myMap)

    var markersFijo = new L.FeatureGroup();
     this.markers = new L.FeatureGroup();

     //ICONO SUPER 
    const iconMarkerSuper = L.icon({ iconUrl: '/js/sj.png', iconSize: [40, 40], iconAnchor: [60, 60] })
    const iconMarker = L.icon({ iconUrl: '/js/marker.png', iconSize: [40, 40], iconAnchor: [30, 60] })

    markerSuper = L.marker([-37.11026, -56.86950], {icon: iconMarkerSuper}).addTo(myMap)
     //ICONO SUPER 



    markerSuper.addTo(markersFijo);

    markersFijo.addTo(myMap);


  
   
    const updateMap = () => {
        myMap.removeLayer(this.markers);
        this.markers = new L.FeatureGroup();
        console.log("markerArray.length:" + this.markers);
        //const urlISSGeoLocation = 'http://api.open-notify.org/iss-now.json'
        //const urlISSGeoLocation = 'https://localhost:44356/Locations/Locations.json'
        const urlISSGeoLocation = urlBase + 'Locations/Locations.json'
        fetch(urlISSGeoLocation)
            .then(res => res.json())
            .then(data => {
                
                console.log("data.length:" + data.length);

                for (var i = 0; i < data.length; i++) {
                    var _latitude = data[i].iss_position.latitude;
                    var _longitude = data[i].iss_position.longitude;

                    //var markerNew = L.marker([_latitude, _longitude], { icon: iconMarker });
                    //markerNew.bindPopup('<p>Soy :' + mapUser + '</p><p>Ya llego</p>');
                    //markerArray[i].addTo(myMap);
                    if (data[i].message == 'ADFS') {
                        var LamMarker = new L.marker([_latitude, _longitude], { icon: iconMarker });
                        LamMarker.bindPopup('<p>Soy :' + data[i].message + '</p><p>latitude :' + _latitude + '</p><p>longitude :' + _longitude + '</p>');
                    } else {
                        var LamMarker = new L.marker([_latitude, _longitude]);
                        LamMarker.bindPopup('<p>Soy :' + data[i].message + '</p><p>latitude :' + _latitude + '</p><p>longitude :' + _longitude + '</p>');
                    }
                    LamMarker.addTo(this.markers);
                }
                
                myMap.addLayer(this.markers);
               
            })

        setTimeout(updateMap, 5000)
    }

    updateMap()

}
function markerDel(markers) {
    console.log("markerArray.length:" + this.markers);
  

    //myMap.removeLayer(this.markerArray);
    //for (i = 0; i < markers.length; i++) {
    //   // this.myMap.removeLayer(markers[i]);
    //}
}
