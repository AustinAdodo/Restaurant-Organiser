// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



//$(window).load(function () {
//});

$(document).ready(function () {
    /*.........................................................MODAL UTILIZATION.............................................*/
    $("#viewdetails").on('click', function () {
        $("#notificationmodal").modal('hide'); $("#presentationmodal").modal('show');
        /*$("#notificationModalLabelbody").load("/St/src/index");*/
    });
    /*.........................................................................IMAGE DISPLAY VALIDATION..............................................*/
    $(".custom-file-input").on("change", function () {/*picturebox for display and validation*/
        var Selectedfile = $(this)[0].files[0];
        console.log($(this));
        var fileName = $(this).val().split("\\").pop();
        var selectinglabel = $(this).next(".custom-file-label");
        $(this).next(".custom-file-label").html(fileName);
        if (selectinglabel.html() !== null) {
            var reader = new FileReader();
            reader.onload = function (e) {
                $("#displayimageedit").attr("src", e.target.result).width(250).height(250);
            };
            reader.readAsDataURL(Selectedfile);
        }
    });
    /*...........................................................ROW DETAILS BUTTON....................................................................*/
    $("a.btndetail").on('click', function () {
        var status = $('#roledetails').css("display");
        alert(status);
        if (status == "none") {
            $('#roledetails').css({ "display": "block" });
        }
        if (status == "block") {
            $('#roledetails').css({ "display": "none" });
        }
    });
    /*...........................................................ADMIN SIDEBAR ONLY....................................................................*/
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar1').slideToggle();
    });
    /*...............................................CALENDER DEF DISPLAY....................................................................*/
    $("#salecal").datepicker({ dateFormat: "dd/mm/yy", changeMonth: true, changeYear: true }).datepicker("setDate", "-24/-1/0");
    /*...............................................Sidebar.....................................................................*/
    $("#sidebar").on({
        mouseover: function () {
            $(this).children("div").children("img").css({ "display": "block", "position": "relative", "cursor": "grab" });
            $("#brand").parent("div").siblings("div").children("img").css({ "display": "none" });
        },
        mouseout: function () {
            $(this).children("div").children("img").css({ "display": "none", "cursor": "default" })
            $("#brand").parent("div").siblings("div").children("img").css({ "display": "block" });
        }
    });
    /*...........................................................Served Confirmation.....................................................................*/
    $("button.serving").on("click", function () {
        var $breaks = $("<br /><br /><br /><br /><br /><br />");
        var $parenttd = $(this).parents("span").parents("div").parents("td");
        var Qty = $(this).parents("span").siblings("span.qty").text().toString().replace('Quantity', '').replace(':', '');
        var QtyServed = "<span style='color: white'>Quantity : </span><span style='color: white'>" + Qty + " |</span>";
        var tableNameNo = $(this).parents("span").siblings("span.tbl").text().toString().replace('Table Name', '').replace('Table', '').replace(':', '').replace('-', '').replace('|', '').trim();
        var servetable = "<span class='tbl' style='color: white'>    Table Name : Table -" + tableNameNo + " |</span>";
        var $neartd = $(this).parents("span").parents("div").parents("td").siblings("td")
        var $nearesttrchild = $(this).parents("span").parents("div").parents("td").parents("tr").closest("tr").prev().children(".right")
        var mealname = $(this).parents("span").siblings("span.foo").text().toString().replace('Name', '').replace(':', '').replace('|', '');
        var message = "the selected order<strong style='color:green'>" + mealname + "</strong> has been marked as 'served'";
        var $span = $("<span id='panelmsg'style='color: white'></span><br />").append(message);
        var $span2 = $("<span><button class='served btn btn-primary'>Undo this operation</button></span>");
        var served = "<span class='foo' style='color:dodgerblue'>Name :" + mealname + " |</span><br />" + QtyServed + servetable +
            "<span style='color: navy'>Status :</span><span class='fas fa-arrow-right' style='color: green'> served |</span>"
        /*build */
        $parenttd
            .css("border-bottom-color", "green").fadeOut(250, function () { $(this).css("border-bottom-color", "white").fadeIn(500) })
        $neartd.css("border-right-color", "green").fadeOut(500, function () { $neartd.css("border-right-color", "white").fadeIn(750) })
        $nearesttrchild.css("border-bottom-color", "green").fadeOut(750, function () { $nearesttrchild.css("border-bottom-color", "white").fadeIn(1000) })
        $parenttd
            .css("border-top-color", "green").fadeOut(750, function () { $(this).css("border-top-color", "white").fadeIn(1000) })/*if that column has a border-top*/
        $parenttd
            .css("border-right-color", "green").fadeOut(1000, function () { $(this).css("border-right-color", "white").fadeIn(1250) });
        /*update that column as served */
        $parenttd.children("div.container").html(served);
        /*notification Panel */
        $("#notification-panel").append($breaks);
        $("#notification-panel").append($span).append($span2);
        $("#notification-panel").children("span").fadeOut(9000);
    });
    $("#notification-panel").on("mouseover", function () {
        var currentopacity = $("#notification-panel").children("span").css("opacity");
        var currentdisplay = $("#notification-panel").children("span").css("display");
        if (parseFloat(currentopacity) > 0.4 && currentdisplay != "none") {
            $("#notification-panel").children("span").stop(true).fadeIn(500);
        }
    });
    $("#notification-panel").on("mouseout", function () {
        $(this).children("span").fadeOut(9000);
    });
    /*................................................................FOOD DISPLAY LI.....................................................................*/
    $("table#foodtable").on("mouseover", "li.dragline", function () {
        $(this).children("div.drag1").children("img").css({ "border": "3px solid green", "cursor": "pointer" });
    });
    $("table#foodtable").on("mouseout", "li.dragline", function () {
        $(this).children("div.drag1").children("img").css({ "border": "2px solid purple", "cursor": "default" });
    });
    $("table#foodtable").on("click", "li.dragline", function () {
        $(this).draggable({ containment: "parent", revert: true, cursor: "move" });
    });
    /*......................................................LayoutLinks Hover Behaviour.....................................................................*/
    $("li.nav-item").mouseover(function () {
        $(this).children("div").children("div").children("img").css({ "display": "block", "position": "relative" });
        $(this).children("div.row").css({ "border-bottom": "2px solid purple" });
        $("#brand").parent("div").siblings("div").children("img").css({ "display": "none" });
    }).mouseout(function () {
        $(this).children("div").children("div").children("img").css({ "display": "none" })
        $(this).children("div.row").css({ "border-bottom": "none" });
        $("#brand").parent("div").siblings("div").children("img").css({ "display": "block" });
    });
    /*..........drop down of nav-link submenu...........*/
    $("#ulmanage").on("mouseover", "li.dropdown-item", function () {
        $(this).children("ul.submenu.dropdown-menu").css({ "display": "block" });
        $(this).children("a.dropdown-item").css({ "background-color": "blue", "color": "black" })
    });
    $("#ulmanage").on("mouseout", "li.dropdown-item", function () {/*navbar submenu display block*/
        $(this).children("ul.submenu.dropdown-menu").css("display", "none");
        $(this).children("a.dropdown-item").css({ "background-color": "initial", "color": "black" });
    });
    $("ul.submenu").click(function () {/*navbar submenu display block*/
        $(this).children("ul").css("display", "none")
    });
    /*.............................PGROUPING BEHAVIOUR.....................................................................*/
    $("ul.country").on("click", "li.grouping", function (c) {
        c.preventDefault();
        var state = $(this).attr("data-loaded");
        if (state == "false") {
            $(this).attr("data-loaded", "true");
            $(this).children("ul.select-menu").css({ "display": "inherit", "cursor": "pointer" });
            $(this).css({ "color": "blue" });
            $(this).siblings("li.grouping").css({ "color": "white" });
            $(this).children("ul.select-menu").children("li.dropdown-item").children("a").css({ "color": "goldenrod" });
            $(this).siblings("li.grouping").children("ul.select-menu").css("display", "none");
            $(this).children("ul.select-menu").slideDown();
        }
        if (state == "true") {
            $(this).attr("data-loaded", "false");
            $("ul.select-menu").css("display", "none");
            $(this).children("ul.select-menu").slideUp();
        }
    });
    /*..................................................Ajax Get Calls.....................................................................*/
    $("li.dropdown-item").off().on("click", function () {
        var datastate = $(this).children("a").attr("data-loaded");
        var datastate2 = $(this).children("a").attr("gid");
        var Data1 = { gid: datastate2 };
        if (datastate == "closed") {
            $(this).attr("data-loaded", "open");
            $.ajax(
                {
                    type: "GET",
                    url: "/Home/PopulateMenuItem",
                    datatype: "json",
                    data: Data1,
                    success: function (datastream) {
                        var $ul = $("<ul></ul>");
                        var populate = '';
                        var Alias = [];
                        $(datastream).each(function (index, element) {
                            Alias[index] = element.countryAlias;
                            var $li = $("<li id='dragnn" + index + "' class= 'dragline' style='display:inline-block'></li>");
                            populate = $ul.append(
                                $li.append(
                                    "<div class='drag1'><img style='height: 120px; width: 220px; border: 2px solid purple' src ='" + element.pictureUrl + "'/>" +
                                    "<div><span style='color:white'> " + element.name + "</span></div>" +
                                    "</div>"
                                )
                            ).append('&ensp;&ensp;');
                        });
                        displayFor = "</span>Displaying For " + Alias[0] + " Cuisines";
                        $("#maindisplay").html('');
                        $("#maindisplay").html(populate);
                        $("#displayfor").html(displayFor);
                        /* \xA0 <br/>*/
                    },
                    error: function (e) {
                        var message = '<h3 style="color:yellow">' + "The resouce attached to the selected menu could not be loaded" + '</h3 >';
                        $("#maindisplay").html('');
                        $("#maindisplay").html(message);
                    },
                });
        }
        else {
            $(this).children("a").attr("data-loaded", "closed");
        }
    });
    /*..................................................Ajax Post Calls.....................................................................*/
    /*deactivate.....................................Employee*/
    var $checkedcheckbox = "";
    $(":input[type=checkbox]:checked").on("change", function () {
        $checkedcheckbox = $(this);
        var empId = $(this).siblings("span").attr("empid");
        var status = $(this).parent("label").parent("span").siblings("span.status").html();
        if (status == "Active") {
            $(this).parent("label").parent("span").siblings("span.status").html("Inactive");
            $(this).parent("label").parent("span").siblings("span.status").css("color", "red");
        }
        if (status == "Inactive") {
            $(this).parent("label").parent("span").siblings("span.status").html("Active");
            $(this).parent("label").parent("span").siblings("span.status").css("color", "green");
        }
        $("#deactivate").attr("targetid", empId);
        $("#deactivate").attr("status", status);
    });
    ///if any of the below buttons were clicked
    $("#dismiss").on("click", function () {
        var status = $checkedcheckbox.parent("label").parent("span").siblings("span.status").html();
        if (status == "Active") {
            $checkedcheckbox.parent("label").parent("span").siblings("span.status").css("color", "red");
            $checkedcheckbox.parent("label").parent("span").siblings("span.status").html("Inactive");
            $checkedcheckbox.removeAttr("checked");
            $checkedcheckbox.attr("focus", "focus");
        }
        if (status == "Inactive") {
            $checkedcheckbox.parent("label").parent("span").siblings("span.status").css("color", "green");
            $checkedcheckbox.parent("label").parent("span").siblings("span.status").html("Active");
            $checkedcheckbox.removeAttr("focus");
            $checkedcheckbox.attr("checked", "checked");
        }
    });
    $("#no").on("click", function () {
        var status = $checkedcheckbox.parent("label").parent("span").siblings("span.status").html();
        if (status == "Active") {
            $checkedcheckbox.parent("label").parent("span").siblings("span.status").css("color", "red");
            $checkedcheckbox.parent("label").parent("span").siblings("span.status").html("Inactive");
            $checkedcheckbox.attr("checked", "focus");
        }
        if (status == "Inactive") {
            $checkedcheckbox.parent("label").parent("span").siblings("span.status").css("color", "green");
            $checkedcheckbox.parent("label").parent("span").siblings("span.status").html("Active");
            $checkedcheckbox.attr("focus", "checked");
        }
    });

    $("#deactivate").on("click", function () {
        ///pass employee id to the button
        var id = $(this).attr("targetid");
        $("#exampleModal").modal("hide");
        var Data1 = { EmployeeId: id };
        $.ajax({
            type: "POST",
            url: "/Administration/ToggleEmployeeStatus",
            datatype: "json",
            data: Data1,
            success: function (datastream) {
                var $span = $("<span></span>");
                var message1 = "Action successfully executed on Employee of Id :" + datastream.EmployeeId; ////
                $("#messageUpdates1").html($span.append(message1));
                $("#messageUpdates1").attr("hidden", "false");
                $("#messageUpdates1").fadeIn(500);
                $("#messageUpdates1").fadeOut(9000);
            },
            error: function (e) {
                var message = '<h5 style="color:yellow">' + "The resource attached could not be loaded" + '</h5 >';
                $("#messageUpdates").html('');
                $("#messageUpdates").html(message);
                $("#messageUpdates").attr("hidden", "false");
                $("#messageUpdates").fadeIn(500);
                $("#messageUpdates").fadeOut(9000);
            },
        });
        /* url: "",*/
        /*var message2 = "The Employee " + datastream.EmployeeFullName + " is now InActive"*/
    });
    /*update an approval..................*/
    $("#decline").on("click", function () {
        var NotificationCount = $("#notinumber").html();
        var decision = $(this).attr("dec");
        var id = $(this).attr("notiId");
        var Data1 = { NotificationId: id, PassedData: decision };
        if (decision == "Declined" || decision == "Approved") {
            $.ajax({
                type: "POST",
                url: "/Home/UpdateNotificationsandRecords",
                datatype: "json",
                data: Data1,
                success: function (datastream) {
                    var $span = $("<span style='color:#7386D5;font-size:12px;'></span>");
                    var message1 = "Your Action has been communicated to the respective user of Id : " + datastream.consumerId;
                    ////update notificaions
                    $("notificationmodal").load(" notificationmodal");
                    $("#notinumber").html(parseInt(NotificationCount - 1));////Negate Notification.
                    $("#messageUpdates").html($span.append(message1));
                    $("#messageUpdates").fadeIn(500);
                    $("#messageUpdates").fadeOut(9000);
                },
                error: function (e) {
                    var message = '<h5 style="color:yellow">' + "The resource attached could not be loaded" + '</h5 >';
                    $("#messageUpdates").html('');
                    $("#messageUpdates").html(message);
                    $("#messageUpdates").attr("hidden", "false");
                    $("#messageUpdates").fadeIn(500);
                    $("#messageUpdates").fadeOut(9000);
                },
            });
        }

    });
});
    /*check if fadeIn is bound*/
    //var rawDom = $("#notification-panel").children("span").get(0);
    //var fadeinevent = $._data(rawDom, "events");
    //if (fadeinevent != undefined && fadeinevent.fadeOut != undefined) {
    //}