
$(function () {

    var smallSize = 650;
    $("[data-toggle='tooltip']").tooltip();//initializing tooltip stuff
    ShowHideBasedOnSize();

    $(".main").onepage_scroll({
        sectionContainer: "section",
        afterMove: function (index) {
                
            $('#homeNavListItem').removeClass('active');
            $('#aboutNavListItem').removeClass('active');
            $('#workNavListItem').removeClass('active');
            $('#linksNavListItem').removeClass('active');
            $('#contactNavListItem').removeClass('active');

            switch(index)
            {
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
        },
        loop: true,
        responsiveFallback: smallSize
    });

    var pdf = new PDFObject({
        url: "http://www.pdsullivan.com/PatrickSullivan Resume.pdf",
        id: "pdfRendered",
        pdfOpenParams: {
            view: "FitH"
        }
    }).embed("pdfRenderer");

    //size functions
    $(window).resize(function () {
        ShowHideBasedOnSize();
    });

    $("#homeNavItem").click(function () {
        $('#homeNavListItem').addClass('active');
        $('.main').moveTo(1);
    });
    $("#aboutNavItem").click(function () {
        $('#aboutNavListItem').addClass('active');
        $(".main").moveTo(2);
    });
    $("#workNavItem").click(function () {
        $('#workNavListItem').addClass('active');
        $(".main").moveTo(3);
    });
    $("#linksNavItem").click(function () {
        $('#linksNavListItem').addClass('active');
        $(".main").moveTo(5);
    });
    $("#contactNavItem").click(function () {
        $('#contactNavListItem').addClass('active');
        $(".main").moveTo(4);
    });
    $("#brandNavButton").click(function () {
        $(".main").moveTo(1);
    });

    $("#btnContactMe").click(function () {
        $('#contactNavListItem').addClass('active');
        $(".main").moveTo(4);
    })

    function ShowHideBasedOnSize() {
        var width = $(window).width();
        if (width < smallSize) {
            $('#pdfRenderer').hide();
            $('#toggleNavButton').hide();
            $('#mobilePDFMessage').show();
        }
        else {
            $('#pdfRenderer').show();
            //$('#toggleNavButton').show();
            $('#mobilePDFMessage').hide();
        }
    };
});


