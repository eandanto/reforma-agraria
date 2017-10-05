$(".nav-link").on("click", function() {
    $(".nav-link").removeClass("active");
    $(this).addClass("active");
  });

$(".nav-item").on("click", function() {
    $(".nav-item").removeClass("active");
    $(this).addClass("active");
  });

var ctx = document.getElementById("myChart");
var myDoughnutChart = new Chart(ctx, {
    type: 'doughnut',
    data: {
        labels: ["Red", "Empty"],
        datasets: [{
            label: '# of Votes',
            data: [12, 19],
            backgroundColor: [
                'rgba(255, 99, 132, 0.5)',
                'rgba(209, 219, 232, 0.2)'
            ],
            borderColor: [
                'rgba(255,99,132,0.3)',
                'rgba(209, 219, 232, 0.2)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            
                ticks: {
                    beginAtZero: true
                }
    
        }
    }
});



var ctx = document.getElementById("myChart1");
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ["January", "February", "March"],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 25, 10, 5],
            backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86, 0.2)'
      
            ],
            borderColor: [
                'rgba(255,99,132,1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)'
     
            ],
            borderWidth: 1
        }]
    },
    options: {
    
    }
});






$(document).ready(function() 
    { 
        $("#myTable").tablesorter( {sortList: [[0,0], [1,0]]} ); 
    } 
); 
    