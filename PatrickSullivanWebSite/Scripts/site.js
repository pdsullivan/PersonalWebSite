
$(function () {

    var smallSize = 1200;
    $("[data-toggle='tooltip']").tooltip();//initializing tooltip stuff

    //one page scroll initialization
    $(".main").onepage_scroll({
        sectionContainer: "section",
        afterMove: function (index) {
            AfterOnePageScrollMove(index);
        },
        loop: true,
        responsiveFallback: smallSize
    });

    function AfterOnePageScrollMove(index) {
        RemoveAllActiveClassesFromNav();

        switch (index) {
            case 1:
                $('#homeNavListItem').addClass('active');
                break;
            case 2:
                $('#aboutNavListItem').addClass('active');
                break;
            case 3:
                $('#workNavListItem').addClass('active');
                break;
            case 5:
                $('#linksNavListItem').addClass('active');
                break;
            case 4:
                $('#contactNavListItem').addClass('active');
                break;
        }
    };

    function ScrollToSection(sectionNumber) {

        RemoveAllActiveClassesFromNav();

        if (LargeSize()) {
            $('.main').moveTo(sectionNumber);
        } else {
            var page = 'page' + sectionNumber;

            document.getElementById(page).scrollIntoView();

            //attempt at offset not done yet
            //Element.prototype.documentOffsetTop = function () {
            //    return this.offsetTop + (this.offsetParent ? this.offsetParent.documentOffsetTop() : 0);
            //};

            //var top = document.getElementById(page).documentOffsetTop() - 45;
            //console.log(top);
            //window.scrollTo( 0, top );
        }
    };

    function RemoveAllActiveClassesFromNav() {
        $('#homeNavListItem').removeClass('active');
        $('#aboutNavListItem').removeClass('active');
        $('#workNavListItem').removeClass('active');
        $('#linksNavListItem').removeClass('active');
        $('#contactNavListItem').removeClass('active');
    };

    function LargeSize() {
        var width = $(window).width();
        
        if (width > smallSize) {
            console.log('LARGE SIZE');
            return true;
        } else {
            console.log('SMALL SIZE');
            return false;
        }
    };


    //nav click functions
    $("#homeNavItem").click(function () {
        ScrollToSection(1);
        $('#homeNavListItem').addClass('active');
    });
    $("#aboutNavItem").click(function () {
        ScrollToSection(2);
        $('#aboutNavListItem').addClass('active');
    });
    $("#workNavItem").click(function () {
        ScrollToSection(3);
        $('#workNavListItem').addClass('active');
    });
    $("#linksNavItem").click(function () {
        ScrollToSection(5);
        $('#linksNavListItem').addClass('active');
    });
    $("#contactNavItem").click(function () {
        ScrollToSection(4);
        $('#contactNavListItem').addClass('active');
    });
    $("#brandNavButton").click(function () {
        ScrollToSection(1);
        $('#homeNavListItem').addClass('active');
    });
    $("#btnContactMe").click(function () {
        ScrollToSection(4);
        $('#contactNavListItem').addClass('active');
    });

});


