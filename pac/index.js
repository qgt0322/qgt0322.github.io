var clock = document.getElementById('clock');
var monthContent = ["一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"];
var dayContent = ["一号", "二号", "三号", "四号", "五号", "六号", "七号", "八号", "九号", "十号", "十一号", "十二号", "十三号", "十四号", "十五号", "十六号", "十七号", "十八号", "十九号", "二十号", "二十一号", "二十二号", "二十三号", "二十四号", "二十五号", "二十六号", "二十七号", "二十八号", "二十九号", "三十号", "三十一号"];
var weekContent = ["小宝贝", "大宝贝", "宝宝", "猪猪", "大可爱", "小公主", "小笨猪"];
var hourContent = ["零点", "一点", "两点", "三点", "四点", "五点", "六点", "七点", "八点", "九点", "十点", "十一点", "十二点", "十三点", "十四点", "十五点", "十六点", "十七点", "十八点", "十九点", "二十点", "二十一点", "二十二点", "二十三点"];
var minuteContent = [
    "零分", "一分", "二分", "三分", "四分", "五分", "六分", "七分", "八分", "九分", "十分",
    "十一分", "十二分", "十三分", "十四分", "十五分", "十六分", "十七分", "十八分", "十九分", "二十分",
    "二十一分", "二十二分", "二十三分", "二十四分", "二十五分", "二十六分", "二十七分", "二十八分", "二十九分", "三十分",
    "三十一分", "三十二分", "三十三分", "三十四分", "三十五分", "三十六分", "三十七分", "三十八分", "三十九分", "四十分",
    "四十一分", "四十二分", "四十三分", "四十四分", "四十五分", "四十六分", "四十七分", "四十八分", "四十九分", "五十分",
    "五十一分", "五十二分", "五十三分", "五十四分", "五十五分", "五十六分", "五十七分", "五十八分", "五十九分"];
var secondsContent = [
    "意中人", "520", "我爱你", "love", "一生一世", "521", "纸短情长", "999", "心上人", "1314",
    "意中人", "520", "我爱你", "love", "一生一世", "521", "纸短情长", "999", "心上人", "1314",
    "意中人", "520", "我爱你", "love", "一生一世", "521", "纸短情长", "999", "心上人", "1314",
    "意中人", "520", "我爱你", "love", "一生一世", "521", "纸短情长", "999", "心上人", "1314",
    "意中人", "520", "我爱你", "love", "一生一世", "521", "纸短情长", "999", "心上人", "1314",
    "意中人", "520", "我爱你", "love", "一生一世", "521", "纸短情长", "999", "心上人", "1314"];
//存放生成dom元素
var monthDom = [];
var dayDom = [];
var weekDom = [];
var hourDom = [];
var minutesDom = [];
var secondsDom = [];


var allSet = [
    [monthContent, monthDom],
    [dayContent, dayDom],
    [weekContent, weekDom],
    [hourContent, hourDom],
    [minuteContent, minutesDom],
    [secondsContent, secondsDom]
];
var isCircle = false;
window.onload = function () {
    init();
    setInterval(() => {
        initStyle();
        runTime();
    }, 100);
    changePosition();

}

function btnClick() {
    changCircle();

    const music = new Audio('./pac/love.mp3');
    music.play();
    music.loop = true;
    // music.playbackRate = 2;
    // music.pause();

    var btn = document.getElementsByClassName('btn')[0];
    btn.style.display = 'none';
    setTimeout(() => {
        showText();
    }, 1500)
}
//初始状态
function init() {
    for (var i = 0; i < allSet.length; i++) {
        for (var j = 0; j < allSet[i][0].length; j++) {
            // allText[i][j];
            var temp = createLable(allSet[i][0][j])
            clock.appendChild(temp)
            allSet[i][1].push(temp)
        }
    }

}
//创建dom
function createLable(text) {
    var div = document.createElement('div');
    div.classList.add('label');
    div.innerText = text;
    return div;
}

function runTime() {
    var now = new Date();
    var month = now.getMonth();
    var day = now.getDate();
    var week = now.getDay();
    var hour = now.getHours();
    var minute = now.getMinutes();
    var seconds = now.getSeconds();
    var nowValue = [month, day - 1, week, hour, minute, seconds]
    for (var i = 0; i < nowValue.length; i++) {
        var index = nowValue[i];
        allSet[i][1][index].style.color = '#000';
        allSet[i][1][index].style.fontWeight = 'bolder'
    }
    if (isCircle) {//变圆
        var circleMidY = document.body.clientHeight / 2;
        var circleMidX = document.body.clientWidth / 2;
        for (var i = 0; i < allSet.length; i++) {
            for (var j = 0; j < allSet[i][0].length; j++) {
                var r = (i + 1) * 25 + 35 * i; //y=kx+b 半径
                var deg = 360 / allSet[i][0].length * (j - nowValue[i]);
                var x = circleMidX + r * Math.sin(deg * Math.PI / 180);//找到x，y坐标
                var y = circleMidY - r * Math.cos(deg * Math.PI / 180);
                var temp = allSet[i][1][j];
                temp.style.left = x + 'px';
                temp.style.top = y + 'px';
                temp.style.transform = 'rotate(' + (deg - 90) + 'deg)'

            }
        }
    }
}
//初始化样式
function initStyle() {
    var label = document.getElementsByClassName('label');
    for (var i = 0; i < label.length; i++) {
        label[i].style.color = 'yellow';
        label[i].style.fontWeight = '100';
    }
}
//将每个都设置成绝对定位
function changePosition() {
    for (let i = 0; i < allSet.length; i++) {
        for (let j = 0; j < allSet[i][1].length; j++) {
            let x = allSet[i][1][j].offsetLeft;
            let y = allSet[i][1][j].offsetTop;
            setTimeout(function () {
                allSet[i][1][j].style.position = 'absolute'
                allSet[i][1][j].style.left = x + 'px';
                allSet[i][1][j].style.top = y + 'px';
            }, 50)
        }
    }
}

function changCircle() {
    isCircle = true;
    clock.style.transform = "rotate(90deg)";
}


var logo = "陈陈: ,,,我们相识于网络 ,,,我们相聚于北京 ,,,北京是国之都 ,,,而你是我的爱 ,,,我有点嘴笨 ,,,你有点敏感 ,,,有时候我说不清楚 ,,,却没有故意的时候 ,,,时有直白的甜言密语 ,,,是我心里的真实写照 ,,,想和你一起 ,,,不用太久 ,,,一辈子刚好 ,,,我爱你 ！！！"
var ptext = document.getElementsByClassName('text')[0];

function showText() {
    var flag = 0;
    var show = true;
    var mouse = document.createElement('span');
    mouse.innerText = "__";
    mouse.style.position = 'absolute';
    mouse.style.left = '0';
    mouse.style.top = '0';
    ptext.appendChild(mouse)
    var timer = setInterval(() => {
        if (flag < logo.length) {
            if (logo.charAt(flag) != ",") {
                mouse.style.left = 20 + parseInt(mouse.style.left) + 'px';
            }
            if (logo.charAt(flag) == " ") {
                mouse.style.top = 29 + parseInt(mouse.style.top) + 'px';
                mouse.style.left = '0';
                ptext.appendChild(document.createElement('br'))
            } else if (logo.charAt(flag) == ",") {
                if (show) {
                    mouse.style.display = 'none'
                } else {
                    mouse.style.display = 'inline-block'
                }
                show = !show;
            } else {
                let span = document.createElement('span');
                span.innerText = logo.charAt(flag);
                ptext.appendChild(span)
            }
            flag++;
        } else {
            clear()
            mouse.style.display = 'none'
        }
    }, 150);
    function clear() {
        clearInterval(timer)
    }
}
