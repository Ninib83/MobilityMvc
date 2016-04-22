var slideimages = new Array()
slideimages[0] = new Image()
slideimages[0].src = "img/cover1.jpg"
slideimages[1] = new Image()
slideimages[1].src = "img/cover2.jpg"
slideimages[2] = new Image()
slideimages[2].src = "img/cover3.jpg"
slideimages[3] = new Image()
slideimages[3].src = "img/cover5.jpg"
slideimages[4] = new Image()
slideimages[4].src = "img/cover6.jpg"
slideimages[5] = new Image()
slideimages[5].src = "img/cover7.jpg"
slideimages[6] = new Image()
slideimages[6].src = "img/Sony-Xperia-Go-ang-Acro-S.jpg"

var linkslideimages = new Array()
linkslideimages[0] = new Image()
linkslideimages[0].href = "http://www.assassinscreed.ubi.com/en-gb/home/"
linkslideimages[1] = new Image()
linkslideimages[1].href = "https://godofwar.playstation.com/?age-verified=025153fcba"
linkslideimages[2] = new Image()
linkslideimages[2].href = "https://www.youtube.com/watch?v=ppp22gkClzQ"
linkslideimages[3] = new Image()
linkslideimages[3].href = "https://www.destinythegame.com/game"
linkslideimages[4] = new Image()
linkslideimages[4].href = "https://www.youtube.com/watch?v=aMTiSmhr3Hg"
linkslideimages[5] = new Image()
linkslideimages[5].href = "http://www.dragonsdogma.com/agegate.php"
linkslideimages[6] = new Image()
linkslideimages[6].href = "http://the-fast-and-the-furious.gamesxl.com/"

var step = 0

function slideit() {

    if (!document.images)
        return
    document.getElementById("slide").src = slideimages[step].src
    document.getElementById("link-slide").href = linkslideimages[step].href
    if (step < 6)
        step++
    else
        step = 0

    setTimeout("slideit()", 5000)
};

slideit();