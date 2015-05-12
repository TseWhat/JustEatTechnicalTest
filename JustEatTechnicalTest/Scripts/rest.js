$(function () {
    $("#submit").on("click", function () {

        $("#restaurants tbody").empty();
        var outCode = $("#outcode").val();
        $("#submit").text("Searching...");
        $("#submit").prop("disabled", "disabled");

        $.ajax({
            url: homeUrl + "/GetRestaurants",
            data: { outcode: outCode },
            success: function (data) {
                var d = JSON.parse(data);
                var restaurantCount = 0;

                for (var i = 0; i < d.Restaurants.length; i++) {
                    var restaurant = d.Restaurants[i];
                    var restaurantContainer = document.createElement("tr");

                    var logo = "<td><img src='" + restaurant.Logo[0].StandardResolutionURL + "' /></td>";
                    $(restaurantContainer).append(logo);


                    var name = "<td>" + restaurant.Name + "</td>";
                    $(restaurantContainer).append(name);

                    var cuisines = document.createElement("td");

                    for (var j = 0; j < restaurant.CuisineTypes.length; j++) {
                        if (j != restaurant.CuisineTypes.length - 1)
                            $(cuisines).append(restaurant.CuisineTypes[j].Name + ", ");
                        else 
                            $(cuisines).append(restaurant.CuisineTypes[j].Name);
                    }
                    $(restaurantContainer).append(cuisines);

                    var rating = "<td>" + restaurant.RatingStars + "</td>";
                    $(restaurantContainer).append(rating);

                    $("#restaurants tbody").append(restaurantContainer);
                    restaurantCount++;
                }
                
                if (restaurantCount > 0) {
                    $("#restaurants").removeClass("hidden");
                    $("#no-data").addClass("hidden");
                }
                else {
                    $("#no-data").removeClass("hidden");
                    $("#restaurants").addClass("hidden");
                }

            },
            error: function (s, a, a) {

            },
            complete: function () {
                $("#submit").text("Find a takeaway");
                $("#submit").prop("disabled", false);
            }

        })
    });
});
