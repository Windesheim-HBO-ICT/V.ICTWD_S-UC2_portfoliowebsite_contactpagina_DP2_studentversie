function setupContactForm() {
    const form = document.getElementById('contactForm');
    if (!form) return;

    const hp = document.getElementById('Website');
    const message = document.getElementById('Message');
    const counter = document.getElementById('characterCount');
    const status = document.getElementById('formStatus');

    message.addEventListener('input', () => {
        counter.textContent = `${message.value.length}/500`;
    });

    form.addEventListener('submit', (event) => {

        if (hp.value) {
            event.preventDefault();
            status.textContent = 'Het formulier kon niet worden verzonden.';
        }
    });
}

window.addEventListener('DOMContentLoaded', setupContactForm);
