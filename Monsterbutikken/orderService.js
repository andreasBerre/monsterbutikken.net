app.factory('orderService',['$http', function($http) {
    return {
        getOrders: function(){
            return $http.get('/service/order');
        },

        getOrder: function(orderId){
            return $http.get('/service/order/' + encodeURIComponent(orderId));
        },

        placeOrder: function(){
            return $http.post('/service/order');
        }
    };
}]);
