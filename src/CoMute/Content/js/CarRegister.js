; (function (root, $) {
    $('#carRegister').on('submit', function (ev) {
        ev.preventDefault();

        var departure time = $('#departure time').val();
        if (!departure time) {
        return;
    }

    var expected Arrival time = $('#expected Arrival time ').val();
    if (!expected Arrival time) {
        return;
    }

    var origin = $('#origin').val();
    if (!origin) {
        return;
    }

    var Days available = $('#Days available').val();
    if (!Days available) {
        return;
    }

    var destination = $('#destination').val();
    if (!destination) {
        return;
    }

    var available seats = $('#available seats').val();
    if (!available seats) {
        return;
    }

    var leader = $('#leader').val();
    if (!leader) {
        return;
    }

    var notes = $('#notes').val();
    if (!notes) {
        return;
    }



    $.post('/api/user', {
        departure time: departure time,
        expected Arrival time: expected Arrival time,
        origin: origin,
        Days available: Days available,
        destination: destination.
        available seats: available seats,
        Days available: Days available,
        leader: leader,
        notes: notes,


    }, function (data) {
        // TODO: Navigate away...
    }).fail(function (data) {
        var $alert = $("#error");
        var $p = $alert.find("p");
        $p.text('Car Registration failed');
        $alert.removeClass('hidden');

        setTimeout(function () {
            $p.text('');
            $alert.addClass('hidden');
        }, 3000);
    });
});
}) (window, jQuery);