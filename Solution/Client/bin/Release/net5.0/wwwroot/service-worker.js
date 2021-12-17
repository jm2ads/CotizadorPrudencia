// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
self.addEventListener('fetch', () => { });


self.addEventListener('push', event => {
    const payload = event.data.json();

    event.waitUntil(
        self.registration.showNotification('Nueva Solicitud de Poliza', {
            body: payload.titulo,
            image: payload.imagen,
            data: { url: payload.url }
        })
    );
});

self.addEventListener('notificationclick', event => {
    event.notification.close();
    event.waitUntil(clients.openWindow(event.notification.data.url));
});


/* Manifest version: NsyTu7a3 */
