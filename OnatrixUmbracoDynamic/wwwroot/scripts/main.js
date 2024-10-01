function handleContactFormSubmit(e) {
    e.preventDefault()

    fetch('https://api.domain.com/contactform')
    .then(() => {

    })
    .then(() => {

    })
    .catch(error => {

    })
}

  document.addEventListener('DOMContentLoaded', function() {
        // Get the first option's text (the first <a> tag in dropdown-content)
        var firstOptionText = document.querySelector('.dropdown-option').getAttribute('data-option');
        
        // Set the button's text to the first option's text
        document.getElementById('dropdownButton').textContent = firstOptionText;

        // Add event listeners to all dropdown options
        document.querySelectorAll('.dropdown-option').forEach(option => {
            option.addEventListener('click', function(event) {
                event.preventDefault(); // Prevent default link behavior
                
                // Get the selected option's text from the data-option attribute
                var selectedOption = this.getAttribute('data-option');
                
                // Update the button text to the selected option's text
                document.getElementById('dropdownButton').textContent = selectedOption;
            });
        });
    });