
.text {
    color: whitesmoke;
    font-size: 45px;
    text-align: center;
    font-family: 'Fantasy';
    text-shadow: 5px 5px 5px yellow;
}

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    background-color: #020024;
}

.bgg {
    position: fixed;
    display: grid;
    align-content: center;
    z-index: 1;
    height: 100vh;
    left: 50%;
    margin-left: -315px;
}

.bgg li.sphere {
    width: 650px;
    height: 650px;
    background: #020024;
    background: radial-gradient(rgba(2, 0, 36, 0.5) 47%, rgba(108, 108, 142, 0.7) 51%, rgba(171, 171, 255, 0.7) 52%, #020024 53%);
}

ul {
    list-style-type: none;
}

.tree {
    z-index: 2;
    position: fixed;
    left: 50%;
    margin-left: -160px;
    display: grid;
    height: 97vh;
    align-content: center;
    grid-template-areas: ". tree-top ."". tree-middle ."". tree-bottom ."". tree-stem .";
    grid-template-columns: 100px auto 100px;
    transform: rotateY(50deg) scaley(1.5);
}

.tree>li {
    position: relative;
    display: block;
}

.tree .top,
.tree .top-star {
    grid-area: tree-top;
}

.tree .top li,
.tree .top-star li {
    border-color: green;
}

.tree .top-star {
    grid-area: tree-top;
    width: 130px;
    height: 55px;
    position: absolute;
    background-color: #fff;
    border-radius: 50%;
    top: -48px;
    z-index: 10;
    left: 4px;
    animation: starLight 1.5s ease-out infinite alternate;
}

.tree .middle {
    grid-area: tree-middle;
}

.tree .bottom {
    grid-area: tree-bottom;
}

.tree .stem {
    grid-area: tree-stem;
}

.tree .tree-pts {
    margin: 0 auto;
    display: flex;
    justify-content: center;
}

.tree .tree-pts .pts {
    top: 0;
    position: absolute;
}

.tree li:nth-of-type(1) .pts {
    border-left: 10px solid #049c04;
    z-index: calc(8 - 1);
}

.tree li:nth-of-type(2) .pts {
    border-left: 10px solid #13a313;
    z-index: calc(8 - 2);
}

.tree li:nth-of-type(3) .pts {
    border-left: 10px solid #067806;
    z-index: calc(8 - 3);
}

.tree li:nth-of-type(4) .pts {
    border-left: 10px solid #0f6b0f;
    z-index: calc(8 - 4);
}

.tree li:nth-of-type(5) .pts {
    border-left: 10px solid #0f5f0f;
    z-index: calc(8 - 5);
}

.tree li:nth-of-type(6) .pts {
    border-left: 10px solid #0f4f0f;
    z-index: calc(8 - 6);
}

.tree li:nth-of-type(7) .stem {
    border-bottom-color: #0f4f0f;
    z-index: calc(8 - 7);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(1) {
    width: 1.7em;
    height: 2em;
    border-radius: 100% 0 0 0;
    transform: rotate(219.5deg) rotatey(28.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(2) {
    width: 1.7em;
    height: 2em;
    border-radius: 100% 0 0 0;
    transform: rotate(218.5deg) rotatey(36.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(3) {
    width: 1.7em;
    height: 2em;
    border-radius: 100% 0 0 0;
    transform: rotate(217.5deg) rotatey(44.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(4) {
    width: 1.7em;
    height: 2em;
    border-radius: 100% 0 0 0;
    transform: rotate(216.5deg) rotatey(52.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(5) {
    width: 1.7em;
    height: 2em;
    border-radius: 100% 0 0 0;
    transform: rotate(215.5deg) rotatey(60.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(6) {
    width: 1.7em;
    height: 2em;
    border-radius: 100% 0 0 0;
    transform: rotate(214.5deg) rotatey(68.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(7) {
    width: 1.7em;
    height: 2em;
    border-radius: 100% 0 0 0;
    transform: rotate(213.5deg) rotatey(76.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(8) {
    width: 1.7em;
    height: 2em;
    border-radius: 100% 0 0 0;
    transform: rotate(212.5deg) rotatey(84.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(9) {
    width: 1.7em;
    height: 2em;
    border-radius: 0 0 0 100%;
    transform: rotate(-40.5deg) rotatey(28.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(10) {
    width: 1.7em;
    height: 2em;
    border-radius: 0 0 0 100%;
    transform: rotate(-41.5deg) rotatey(37deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(11) {
    width: 1.7em;
    height: 2em;
    border-radius: 0 0 0 100%;
    transform: rotate(-42.5deg) rotatey(45.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(12) {
    width: 1.7em;
    height: 2em;
    border-radius: 0 0 0 100%;
    transform: rotate(-43.5deg) rotatey(54deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(13) {
    width: 1.7em;
    height: 2em;
    border-radius: 0 0 0 100%;
    transform: rotate(-44.5deg) rotatey(62.5deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(14) {
    width: 1.7em;
    height: 2em;
    border-radius: 0 0 0 100%;
    transform: rotate(-45.5deg) rotatey(71deg) translateX(4em);
}

.tree li:nth-child(1) .tree-pts .pts:nth-of-type(15) {
    width: 1.7em;
    height: 2em;
    border-radius: 0 0 0 100%;
    transform: rotate(-46.5deg) rotatey(79.5deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(1) {
    width: 3.4em;
    height: 4em;
    border-radius: 100% 0 0 0;
    transform: rotate(220deg) rotatey(29deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(2) {
    width: 3.4em;
    height: 4em;
    border-radius: 100% 0 0 0;
    transform: rotate(219deg) rotatey(37deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(3) {
    width: 3.4em;
    height: 4em;
    border-radius: 100% 0 0 0;
    transform: rotate(218deg) rotatey(45deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(4) {
    width: 3.4em;
    height: 4em;
    border-radius: 100% 0 0 0;
    transform: rotate(217deg) rotatey(53deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(5) {
    width: 3.4em;
    height: 4em;
    border-radius: 100% 0 0 0;
    transform: rotate(216deg) rotatey(61deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(6) {
    width: 3.4em;
    height: 4em;
    border-radius: 100% 0 0 0;
    transform: rotate(215deg) rotatey(69deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(7) {
    width: 3.4em;
    height: 4em;
    border-radius: 100% 0 0 0;
    transform: rotate(214deg) rotatey(77deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(8) {
    width: 3.4em;
    height: 4em;
    border-radius: 100% 0 0 0;
    transform: rotate(213deg) rotatey(85deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(9) {
    width: 3.4em;
    height: 4em;
    border-radius: 0 0 0 100%;
    transform: rotate(-40deg) rotatey(29deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(10) {
    width: 3.4em;
    height: 4em;
    border-radius: 0 0 0 100%;
    transform: rotate(-41deg) rotatey(38deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(11) {
    width: 3.4em;
    height: 4em;
    border-radius: 0 0 0 100%;
    transform: rotate(-42deg) rotatey(47deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(12) {
    width: 3.4em;
    height: 4em;
    border-radius: 0 0 0 100%;
    transform: rotate(-43deg) rotatey(56deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(13) {
    width: 3.4em;
    height: 4em;
    border-radius: 0 0 0 100%;
    transform: rotate(-44deg) rotatey(65deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(14) {
    width: 3.4em;
    height: 4em;
    border-radius: 0 0 0 100%;
    transform: rotate(-45deg) rotatey(74deg) translateX(4em);
}

.tree li:nth-child(2) .tree-pts .pts:nth-of-type(15) {
    width: 3.4em;
    height: 4em;
    border-radius: 0 0 0 100%;
    transform: rotate(-46deg) rotatey(83deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(1) {
    width: 5.1em;
    height: 6em;
    border-radius: 100% 0 0 0;
    transform: rotate(220.5deg) rotatey(29.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(2) {
    width: 5.1em;
    height: 6em;
    border-radius: 100% 0 0 0;
    transform: rotate(219.5deg) rotatey(37.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(3) {
    width: 5.1em;
    height: 6em;
    border-radius: 100% 0 0 0;
    transform: rotate(218.5deg) rotatey(45.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(4) {
    width: 5.1em;
    height: 6em;
    border-radius: 100% 0 0 0;
    transform: rotate(217.5deg) rotatey(53.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(5) {
    width: 5.1em;
    height: 6em;
    border-radius: 100% 0 0 0;
    transform: rotate(216.5deg) rotatey(61.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(6) {
    width: 5.1em;
    height: 6em;
    border-radius: 100% 0 0 0;
    transform: rotate(215.5deg) rotatey(69.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(7) {
    width: 5.1em;
    height: 6em;
    border-radius: 100% 0 0 0;
    transform: rotate(214.5deg) rotatey(77.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(8) {
    width: 5.1em;
    height: 6em;
    border-radius: 100% 0 0 0;
    transform: rotate(213.5deg) rotatey(85.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(9) {
    width: 5.1em;
    height: 6em;
    border-radius: 0 0 0 100%;
    transform: rotate(-39.5deg) rotatey(29.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(10) {
    width: 5.1em;
    height: 6em;
    border-radius: 0 0 0 100%;
    transform: rotate(-40.5deg) rotatey(39deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(11) {
    width: 5.1em;
    height: 6em;
    border-radius: 0 0 0 100%;
    transform: rotate(-41.5deg) rotatey(48.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(12) {
    width: 5.1em;
    height: 6em;
    border-radius: 0 0 0 100%;
    transform: rotate(-42.5deg) rotatey(58deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(13) {
    width: 5.1em;
    height: 6em;
    border-radius: 0 0 0 100%;
    transform: rotate(-43.5deg) rotatey(67.5deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(14) {
    width: 5.1em;
    height: 6em;
    border-radius: 0 0 0 100%;
    transform: rotate(-44.5deg) rotatey(77deg) translateX(4em);
}

.tree li:nth-child(3) .tree-pts .pts:nth-of-type(15) {
    width: 5.1em;
    height: 6em;
    border-radius: 0 0 0 100%;
    transform: rotate(-45.5deg) rotatey(86.5deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(1) {
    width: 6.8em;
    height: 8em;
    border-radius: 100% 0 0 0;
    transform: rotate(221deg) rotatey(30deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(2) {
    width: 6.8em;
    height: 8em;
    border-radius: 100% 0 0 0;
    transform: rotate(220deg) rotatey(38deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(3) {
    width: 6.8em;
    height: 8em;
    border-radius: 100% 0 0 0;
    transform: rotate(219deg) rotatey(46deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(4) {
    width: 6.8em;
    height: 8em;
    border-radius: 100% 0 0 0;
    transform: rotate(218deg) rotatey(54deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(5) {
    width: 6.8em;
    height: 8em;
    border-radius: 100% 0 0 0;
    transform: rotate(217deg) rotatey(62deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(6) {
    width: 6.8em;
    height: 8em;
    border-radius: 100% 0 0 0;
    transform: rotate(216deg) rotatey(70deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(7) {
    width: 6.8em;
    height: 8em;
    border-radius: 100% 0 0 0;
    transform: rotate(215deg) rotatey(78deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(8) {
    width: 6.8em;
    height: 8em;
    border-radius: 100% 0 0 0;
    transform: rotate(214deg) rotatey(86deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(9) {
    width: 6.8em;
    height: 8em;
    border-radius: 0 0 0 100%;
    transform: rotate(-39deg) rotatey(30deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(10) {
    width: 6.8em;
    height: 8em;
    border-radius: 0 0 0 100%;
    transform: rotate(-40deg) rotatey(40deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(11) {
    width: 6.8em;
    height: 8em;
    border-radius: 0 0 0 100%;
    transform: rotate(-41deg) rotatey(50deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(12) {
    width: 6.8em;
    height: 8em;
    border-radius: 0 0 0 100%;
    transform: rotate(-42deg) rotatey(60deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(13) {
    width: 6.8em;
    height: 8em;
    border-radius: 0 0 0 100%;
    transform: rotate(-43deg) rotatey(70deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(14) {
    width: 6.8em;
    height: 8em;
    border-radius: 0 0 0 100%;
    transform: rotate(-44deg) rotatey(80deg) translateX(4em);
}

.tree li:nth-child(4) .tree-pts .pts:nth-of-type(15) {
    width: 6.8em;
    height: 8em;
    border-radius: 0 0 0 100%;
    transform: rotate(-45deg) rotatey(90deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(1) {
    width: 8.5em;
    height: 10em;
    border-radius: 100% 0 0 0;
    transform: rotate(221.5deg) rotatey(30.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(2) {
    width: 8.5em;
    height: 10em;
    border-radius: 100% 0 0 0;
    transform: rotate(220.5deg) rotatey(38.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(3) {
    width: 8.5em;
    height: 10em;
    border-radius: 100% 0 0 0;
    transform: rotate(219.5deg) rotatey(46.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(4) {
    width: 8.5em;
    height: 10em;
    border-radius: 100% 0 0 0;
    transform: rotate(218.5deg) rotatey(54.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(5) {
    width: 8.5em;
    height: 10em;
    border-radius: 100% 0 0 0;
    transform: rotate(217.5deg) rotatey(62.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(6) {
    width: 8.5em;
    height: 10em;
    border-radius: 100% 0 0 0;
    transform: rotate(216.5deg) rotatey(70.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(7) {
    width: 8.5em;
    height: 10em;
    border-radius: 100% 0 0 0;
    transform: rotate(215.5deg) rotatey(78.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(8) {
    width: 8.5em;
    height: 10em;
    border-radius: 100% 0 0 0;
    transform: rotate(214.5deg) rotatey(86.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(9) {
    width: 8.5em;
    height: 10em;
    border-radius: 0 0 0 100%;
    transform: rotate(-38.5deg) rotatey(30.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(10) {
    width: 8.5em;
    height: 10em;
    border-radius: 0 0 0 100%;
    transform: rotate(-39.5deg) rotatey(41deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(11) {
    width: 8.5em;
    height: 10em;
    border-radius: 0 0 0 100%;
    transform: rotate(-40.5deg) rotatey(51.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(12) {
    width: 8.5em;
    height: 10em;
    border-radius: 0 0 0 100%;
    transform: rotate(-41.5deg) rotatey(62deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(13) {
    width: 8.5em;
    height: 10em;
    border-radius: 0 0 0 100%;
    transform: rotate(-42.5deg) rotatey(72.5deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(14) {
    width: 8.5em;
    height: 10em;
    border-radius: 0 0 0 100%;
    transform: rotate(-43.5deg) rotatey(83deg) translateX(4em);
}

.tree li:nth-child(5) .tree-pts .pts:nth-of-type(15) {
    width: 8.5em;
    height: 10em;
    border-radius: 0 0 0 100%;
    transform: rotate(-44.5deg) rotatey(93.5deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(1) {
    width: 10.2em;
    height: 12em;
    border-radius: 100% 0 0 0;
    transform: rotate(222deg) rotatey(31deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(2) {
    width: 10.2em;
    height: 12em;
    border-radius: 100% 0 0 0;
    transform: rotate(221deg) rotatey(39deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(3) {
    width: 10.2em;
    height: 12em;
    border-radius: 100% 0 0 0;
    transform: rotate(220deg) rotatey(47deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(4) {
    width: 10.2em;
    height: 12em;
    border-radius: 100% 0 0 0;
    transform: rotate(219deg) rotatey(55deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(5) {
    width: 10.2em;
    height: 12em;
    border-radius: 100% 0 0 0;
    transform: rotate(218deg) rotatey(63deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(6) {
    width: 10.2em;
    height: 12em;
    border-radius: 100% 0 0 0;
    transform: rotate(217deg) rotatey(71deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(7) {
    width: 10.2em;
    height: 12em;
    border-radius: 100% 0 0 0;
    transform: rotate(216deg) rotatey(79deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(8) {
    width: 10.2em;
    height: 12em;
    border-radius: 100% 0 0 0;
    transform: rotate(215deg) rotatey(87deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(9) {
    width: 10.2em;
    height: 12em;
    border-radius: 0 0 0 100%;
    transform: rotate(-38deg) rotatey(31deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(10) {
    width: 10.2em;
    height: 12em;
    border-radius: 0 0 0 100%;
    transform: rotate(-39deg) rotatey(42deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(11) {
    width: 10.2em;
    height: 12em;
    border-radius: 0 0 0 100%;
    transform: rotate(-40deg) rotatey(53deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(12) {
    width: 10.2em;
    height: 12em;
    border-radius: 0 0 0 100%;
    transform: rotate(-41deg) rotatey(64deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(13) {
    width: 10.2em;
    height: 12em;
    border-radius: 0 0 0 100%;
    transform: rotate(-42deg) rotatey(75deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(14) {
    width: 10.2em;
    height: 12em;
    border-radius: 0 0 0 100%;
    transform: rotate(-43deg) rotatey(86deg) translateX(4em);
}

.tree li:nth-child(6) .tree-pts .pts:nth-of-type(15) {
    width: 10.2em;
    height: 12em;
    border-radius: 0 0 0 100%;
    transform: rotate(-44deg) rotatey(97deg) translateX(4em);
}

.left {
    right: 50%;
    margin-right: -38px;
}

.right {
    left: 50%;
    margin-left: -38px;
}

.tree-stem .stem {
    width: 0;
    height: 0;
    border-left: 70px solid transparent;
    border-right: 70px solid transparent;
    border-bottom: 120px solid #0f4f0f;
    margin: 0 auto;
}

.gift {
    position: absolute;
    width: 50px;
    height: 30px;
    margin: 5px;
    background-color: #ffc0cb;
    border: 1px dotted #42161e;
    z-index: 20;
    box-shadow: 1px -1px 2px #f5b0bc, 2px -2px 2px #e89daa, 3px -3px 2px #da8a98, 4px -4px 2px #ce7a89, 5px -5px 2px #bb6676, 6px -6px 2px #af5969, 7px -7px 2px #a04a5a, 8px -8px 2px #943e4e, 9px -9px 2px #803442, 10px -10px 2px #6b2834, 11px -11px 2px #541e28, 12px -12px 2px #42161e;
}

.g1 {
    left: -10px;
    top: 110px;
}

.g2 {
    left: 33px;
    top: 120px;
    height: 15px;
}

.g3 {
    left: 85px;
    top: 125px;
    width: 70px;
    height: 22px;
}

.g4 {
    left: -45px;
    top: 130px;
}

.g5 {
    left: 45px;
    top: 130px;
}

.g6 {
    left: 0px;
    top: 130px;
}

.g7 {
    left: 65px;
    top: 130px;
}

.g8 {
    left: 120px;
    top: 150px;
    height: 13px;
    width: 123px;
}

.g9 {
    left: 50px;
    top: 150px;
}

.shadow {
    width: 400px;
    height: 50px;
    background-color: rgba(42, 41, 68, 0.5);
    position: absolute;
    border-radius: 50%;
    top: 126px;
    left: -128px;
}

.toys {
    display: grid;
    position: absolute;
    gap: 5px;
    grid-template-columns: repeat(9, 20px);
    grid-template-rows: repeat(12, 20px);
    left: calc(50% - 100px);
    top: calc(50% - 135px);
    z-index: 2;
}

.toys .star {
    top: -30px;
    left: 10px;
    position: relative;
    border-right: 100px solid transparent;
    border-bottom: 70px solid gold;
    border-left: 100px solid transparent;
    transform: rotate(35deg) scale(0.2);
}

.toys .star:before {
    border-bottom: 80px solid gold;
    border-left: 30px solid transparent;
    border-right: 30px solid transparent;
    position: absolute;
    top: -45px;
    left: -65px;
    content: '';
    transform: rotate(-35deg);
}

.toys .star:after {
    position: absolute;
    top: 3px;
    left: -105px;
    border-right: 100px solid transparent;
    border-bottom: 70px solid gold;
    border-left: 100px solid transparent;
    transform: rotate(-70deg);
    content: '';
}

.toys .ball {
    width: 20px;
    height: 20px;
    background-color: #f00;
    border-radius: 50%;
    z-index: 1;
    position: absolute;
}

.toys .b1,
.toys .b4,
.toys .b5,
.toys .b8,
.toys .b11,
.toys .b13,
.toys .b16,
.toys .b18 {
    background-color: red;
    box-shadow: -1px -1px 6px inset #600, 1px 1px 8px inset #ffc9c9;
}

.toys .b2,
.toys .b6,
.toys .b9,
.toys .b12,
.toys .b14,
.toys .b17,
.toys .b20 {
    background-color: gold;
    box-shadow: -1px -1px 6px inset #3a3101, 1px 1px 8px inset #ffffff;
}

.toys .b3,
.toys .b7,
.toys .b10,
.toys .b15,
.toys .b19 {
    background-color: #ececec;
    box-shadow: -1px -1px 6px inset #615f5f, 1px 1px 8px inset #ffffff;
}

.toys .b1 {
    grid-area: 3 / 5;
    top: -5px;
    left: 10px;
}

.toys .b2 {
    grid-area: 4 / 4;
    top: -5px;
    left: -5px;
}

.toys .b3 {
    grid-area: 4 / 6;
    top: -1px;
    left: 5px;
}

.toys .b4 {
    grid-area: 5 / 5;
    top: -8px;
    left: -3px;
}

.toys .b5 {
    grid-area: 6 / 2;
}

.toys .b6 {
    grid-area: 6 / 4;
    top: -10px;
    left: -10px;
}

.toys .b7 {
    grid-area: 6 / 6;
    top: -10px;
    left: -5px;
}

.toys .b8 {
    grid-area: 6 / 8;
    top: 2px;
    left: 5px;
}

.toys .b9 {
    grid-area: 7 / 1;
    top: 4px;
    left: 0px;
}

.toys .b10 {
    grid-area: 7 / 3;
    top: 3px;
    left: 3px;
}

.toys .b11 {
    grid-area: 7 / 5;
    top: -10px;
    left: -10px;
}

.toys .b12 {
    grid-area: 7 / 7;
    top: -4px;
    left: 3px;
}

.toys .b13 {
    grid-area: 8 / 2;
    top: 8px;
    left: 0px;
}

.toys .b14 {
    grid-area: 8 / 4;
    top: 5px;
    left: 5px;
}

.toys .b15 {
    grid-area: 8 / 6;
    top: -10px;
    left: -10px;
}

.toys .b16 {
    grid-area: 8 / 8;
    top: -3px;
    left: 17px;
}

.toys .b17 {
    grid-area: 9 / 1;
    top: 20px;
    left: 8px;
}

.toys .b18 {
    grid-area: 9 / 6;
    top: -5px;
    left: 20px;
}

.toys .b19 {
    grid-area: 9 / 10;
    top: 26px;
    left: -30px;
}

.toys .b20 {
    grid-area: 8 / 10;
    top: 24px;
    left: 0px;
}

.light {
    width: 3px;
    height: 3px;
    border-radius: 50%;
    position: absolute;
    background-color: #fff;
    animation: lights 1.5s ease-in infinite alternate;
}

.l1 {
    grid-area: 2 / 5;
    top: 5px;
    left: 5px;
}

.l2 {
    grid-area: 3 / 4;
    animation-delay: 0.4s;
}

.l3 {
    grid-area: 3/ 5;
    top: -5px;
    left: -5px;
    animation-delay: 0.6s;
}

.l4 {
    grid-area: 3 / 5;
    top: 15px;
    left: 0px;
    animation-delay: 0.8s;
}

.l5 {
    grid-area: 2 / 5;
    top: 5px;
    left: 5px;
    animation-delay: 1s;
}

.l7 {
    grid-area: 4 / 5;
    top: 5px;
    left: 15px;
}

.l8 {
    animation-delay: 0.4s;
    grid-area: 5 / 7;
    top: -10px;
    left: 10px;
}

.l9 {
    animation-delay: 0.6s;
    grid-area: 5 / 6;
}

.l10 {
    animation-delay: 0.8s;
    grid-area: 5 / 3;
    top: -5px;
    left: 15px;
}

.l11 {
    animation-delay: 1s;
    grid-area: 5 / 4;
    top: 5px;
    left: 10px;
}

.l12 {
    grid-area: 6 / 5;
    left: 5px;
}

.l13 {
    animation-delay: 0.4s;
    grid-area: 6 / 7;
    left: 5px;
    top: 3px;
}

.l14 {
    animation-delay: 0.6s;
    grid-area: 7 / 6;
    left: 5px;
}

.l15 {
    animation-delay: 0.8s;
    grid-area: 6 / 3;
    top: 8px;
}

.l16 {
    animation-delay: 1s;
    grid-area: 7 / 4;
}

.l17 {
    grid-area: 8 / 5;
}

.l18 {
    animation-delay: 0.4s;
    grid-area: 9 / 6;
}

.l19 {
    animation-delay: 0.6s;
    grid-area: 8 / 7;
    top: 5px;
    left: 7px;
}

.l20 {
    animation-delay: 0.8s;
    grid-area: 8 / 2;
    top: -15px;
    left: 5px;
}

.l21 {
    animation-delay: 1s;
    grid-area: 8/ 3;
    left: 5px;
    top: 5px;
}

.l22 {
    animation-delay: 0.4s;
    grid-area: 7 / 8;
    top: 15px;
    left: 20px;
}

.l23 {
    animation-delay: 0.6s;
    grid-area: 9 / 1;
    left: 15px;
    top: 15px;
}

.l24 {
    animation-delay: 0.8s;
    grid-area: 9 / 3;
}

.l25 {
    animation-delay: 1s;
    grid-area: 9 / 8;
    top: 5px;
    left: 15px;
}

.l6 {
    grid-area: 2 / 5;
    top: 10px;
    left: 20px;
}

@keyframes starLight {
    0% {
        background: radial-gradient(ellipse at center, gold 0%, rgba(255, 240, 158, 0.5) 42%, rgba(255, 242, 173, 0.2) 58%, rgba(255, 255, 255, 0.1) 100%);
    }

    15% {
        background: radial-gradient(ellipse at center, gold 0%, rgba(255, 240, 158, 0.5) 41%, rgba(255, 242, 173, 0.2) 59%, rgba(255, 255, 255, 0.1) 100%);
    }

    25% {
        background: radial-gradient(ellipse at center, gold 0%, rgba(255, 240, 158, 0.5) 40%, rgba(255, 242, 173, 0.2) 60%, rgba(255, 255, 255, 0.1) 100%);
    }

    35% {
        background: radial-gradient(ellipse at center, gold 0%, rgba(255, 240, 158, 0.5) 39%, rgba(255, 242, 173, 0.2) 61%, rgba(255, 255, 255, 0.1) 100%);
    }

    50% {
        background: radial-gradient(ellipse at center, gold 0%, rgba(255, 240, 158, 0.5) 38%, rgba(255, 242, 173, 0.2) 62%, rgba(255, 255, 255, 0.1) 100%);
    }

    65% {
        background: radial-gradient(ellipse at center, gold 0%, rgba(255, 240, 158, 0.5) 37%, rgba(255, 242, 173, 0.2) 63%, rgba(255, 255, 255, 0.1) 100%);
    }

    75% {
        background: radial-gradient(ellipse at center, gold 0%, rgba(255, 240, 158, 0.5) 36%, rgba(255, 242, 173, 0.2) 64%, rgba(255, 255, 255, 0.1) 100%);
    }

    85% {
        background: radial-gradient(ellipse at center, gold 0%, rgba(255, 240, 158, 0.5) 35%, rgba(255, 242, 173, 0.2) 65%, rgba(255, 255, 255, 0.1) 100%);
    }

    100% {
        background: radial-gradient(ellipse at center, gold 0%, rgba(255, 240, 158, 0.5) 34%, rgba(255, 242, 173, 0.2) 66%, rgba(255, 255, 255, 0.1) 100%);
    }
}

@keyframes lights {
    0% {
        box-shadow: 0 0 0px 0px #fff;
    }

    25% {
        box-shadow: 0 0 1px 1px #fff;
    }

    50% {
        box-shadow: 0 0 2px 2px #fff;
    }

    75% {
        box-shadow: 0 0 3px 3px #fff;
    }

    100% {
        box-shadow: 0 0 4px 4px #fff;
    }
}