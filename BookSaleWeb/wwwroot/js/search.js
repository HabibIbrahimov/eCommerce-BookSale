$(document).ready(function () {
    //search
    $(document).on("keyup", "#input-search", function () {
        let search = $("#input-search").val().trim();
        $("#search-list li").slice(1).remove();
        if (search.length > 0) {
            $.ajax({
                url: "/Customer/Home/Search?search=" + search,
                type: "get",
                success: function (res) {
                    $("#search-list").append(res);
                }
            })
        }
    })
});