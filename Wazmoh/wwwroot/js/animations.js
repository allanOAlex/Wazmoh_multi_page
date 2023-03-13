// Get all the href links and add click event listeners
var links = document.querySelectorAll('a[href^="#"]');
links.forEach(function (link) {
    link.addEventListener('click', function (e) {
        e.preventDefault(); // Prevent the default behavior of the link
        var target = document.querySelector(link.getAttribute('href'));
        if (target) {
            // Remove the active class from all sections
            var sections = document.querySelectorAll('.animated-section');
            sections.forEach(function (section) {
                section.classList.remove('active');
            });

            // Add the active class to the target section
            target.classList.add('active');

            // Add the animation class to the target section
            var animation = link.dataset.animation;
            if (animation) {
                target.classList.add(animation);
            }

            window.scrollTo(0, 0);
        }
    });

    
});



