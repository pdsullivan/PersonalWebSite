
$(function () {

    ShowHideBasedOnSize();

    $(".main").onepage_scroll({
        sectionContainer: "section",
        afterMove: function (index) {
                
            $('#homeNavListItem').removeClass('active');
            $('#aboutNavListItem').removeClass('active');
            $('#linksNavListItem').removeClass('active');

            switch(index)
            {
                case 1:
                    $('#homeNavListItem').addClass('active');
                    break;
                case 2:
                    $('#aboutNavListItem').addClass('active');
                    break;
                case 3:
                    $('#linksNavListItem').addClass('active');
                    break;
            }
        },
        loop: true,
        responsiveFallback: 980
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
        $(".main").moveTo(1);
        ShowHideBasedOnSize();
    });


    $("#homeNavItem").click(function () {
        $(".main").moveTo(1);
    });
    $("#aboutNavItem").click(function () {
        $(".main").moveTo(2);
    });
    $("#linksNavItem").click(function () {
        $(".main").moveTo(3);
    });

});

function ShowHideBasedOnSize() {
    var width = $(window).width();
    if (width < 980) {
        $('#navbarContainer').hide();
        $('#pdfRenderer').hide();
        $('#mobilePDFMessage').show();
    }
    else {
        $('#navbarContainer').show();
        $('#pdfRenderer').show();
        $('#mobilePDFMessage').hide();
    }
};

