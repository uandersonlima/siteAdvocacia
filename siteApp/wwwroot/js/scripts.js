document.addEventListener("DOMContentLoaded", () => {
  let nav = document.querySelector('nav#menu'),
    search = document.querySelector('li.pesquisa a'),
    menuPosition = nav.offsetTop;
  let aGroup = nav.querySelectorAll('li.menu a');

  search.addEventListener("click", function () {
    let searchBox = this.parentNode.querySelector('ul');
    if (searchBox.classList.contains('show')) {
      searchBox.classList.remove('show');
    }
    else {
      searchBox.classList.add('show');
    }
  })

  aGroup.forEach(element => element.addEventListener("click", function () {
    let li = this.parentNode;
    if (li.classList.contains('show')) {
      li.classList.remove('show');
    }
    else {
      li.classList.add('show');
    }
  }))

  window.addEventListener("scroll", () => {
    if (this.scrollY > menuPosition) {
      nav.classList.remove('menu-flutuante');
    }
    else {
      nav.classList.add('menu-flutuante');
    }
  });

  document.querySelector('a.expand').click = $('.navbar-collapse').collapse('hide');
}, false);
