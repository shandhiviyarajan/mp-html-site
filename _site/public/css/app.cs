body {
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  padding-top: 140px;
  font-family: 'Poppins', sans-serif; }

.bg_grey {
  background: #EBEBEB; }

header {
  position: fixed;
  width: 100%;
  top: 0px;
  left: 0px;
  z-index: 4000;
  background: #fff;
  box-shadow: 0 2px 4px 0 rgba(0, 0, 0, 0.5); }
  header div.mobile_menu {
    display: none; }
  header div.top-header {
    position: relative;
    background: #2474A4;
    text-align: right; }
    header div.top-header a {
      display: inline-block;
      padding: 10px 20px;
      color: #fff; }
      header div.top-header a:hover {
        color: #d6d6d6; }
  header ul {
    margin: 0px;
    float: right;
    list-style: none; }
    header ul li {
      display: inline-block;
      margin-left: -4px; }
      header ul li a {
        height: 100px;
        display: block;
        padding: 0px 20px;
        font-size: 14px;
        color: #272727;
        letter-spacing: 0;
        text-decoration: none;
        line-height: 100px; }
        header ul li a:hover {
          color: #194964;
          text-decoration: none; }
    header ul li:last-child {
      display: none; }

.home-block-one {
  position: relative;
  height: 600px;
  overflow: hidden; }
  .home-block-one img {
    width: 100%; }
  .home-block-one div.slider-item {
    height: 600px;
    display: flex;
    justify-content: center;
    align-items: center; }
  .home-block-one div.slider-text {
    width: 700px;
    font-weight: 700;
    position: relative;
    text-align: Center;
    height: 200px;
    width: 100%;
    font-size: 48px;
    color: #FFFFFF;
    line-height: 56px;
    text-align: center;
    text-shadow: 0 2px 4px rgba(0, 0, 0, 0.5); }

.home-block-event {
  padding: 60px; }
  .home-block-event .next-date-wrapper {
    display: flex; }
    .home-block-event .next-date-wrapper .next-date {
      width: 96px;
      border: 1px solid #979797;
      border-radius: 4px;
      font-size: 36px;
      color: #6E6E6E;
      text-align: center;
      line-height: 28px;
      font-weight: 700;
      padding: 20px;
      margin: 0px 20px 0px 0px; }
      .home-block-event .next-date-wrapper .next-date span {
        display: block;
        font-size: 18px; }
    .home-block-event .next-date-wrapper .next-date-text {
      margin: 20px 20px 0px 0px;
      font-size: 36px;
      color: #000000;
      font-weight: 700;
      line-height: 24px; }
      .home-block-event .next-date-wrapper .next-date-text span {
        display: block;
        font-size: 16px;
        color: #6E6E6E; }
  .home-block-event .next-event-date-wrapper {
    display: flex;
    justify-content: space-around; }
    .home-block-event .next-event-date-wrapper .next-arrow {
      margin: 0px 20px 0px 0px; }
    .home-block-event .next-event-date-wrapper .next-arrow-2 {
      margin: 0px 0px 0px 20px; }
    .home-block-event .next-event-date-wrapper .next-event-date {
      font-size: 36px;
      color: #D73030;
      font-weight: bold;
      line-height: 32px;
      margin-top: 10px; }
      .home-block-event .next-event-date-wrapper .next-event-date span {
        display: block;
        font-size: 16px;
        line-height: 20px; }
  .home-block-event .next-event-info .next-event-title {
    color: #2474A4;
    font-size: 24px;
    font-weight: bold;
    text-align: left;
    line-height: 24px;
    margin: 0px 0px 10px 0px; }
  .home-block-event .next-event-info .next-event-time {
    font-weight: 400;
    font-size: 16px;
    color: #2474A4;
    line-height: 16px;
    margin: 0px 0px 10px 0px; }

.block-free-website {
  padding: 80px 0px; }

.featured-video-block {
  /* Rectangle 20: */
  background-image: linear-gradient(-127deg, #0C80A1 0%, #063E55 100%);
  height: 700px;
  padding: 60px 0px; }
  .featured-video-block div.block-title {
    font-size: 36px;
    font-weight: bold;
    margin-bottom: 50px;
    color: #0DA5C5; }
    .featured-video-block div.block-title span {
      color: #fff; }
  .featured-video-block video {
    width: 100%; }
  .featured-video-block .video-block {
    position: relative; }
    .featured-video-block .video-block video {
      height: 490px;
      background: #000; }
    .featured-video-block .video-block img {
      position: absolute;
      left: 50%;
      margin-left: -54px;
      top: 50%;
      margin-top: -62px; }
  .featured-video-block .video-description {
    background: #0674A5;
    padding: 20px; }
    .featured-video-block .video-description h3, .featured-video-block .video-description p {
      color: #fff; }
    .featured-video-block .video-description h3 {
      font-size: 24px;
      font-weight: bold; }
    .featured-video-block .video-description p {
      font-size: 16px;
      font-weight: 400;
      line-height: 24px; }

div.block-connect,
div.block-digital-training,
div.block-connect-with-us {
  position: relative;
  height: 600px; }
  div.block-connect div.container,
  div.block-digital-training div.container,
  div.block-connect-with-us div.container {
    position: relative;
    z-index: 3000;
    padding-top: 90px; }
    div.block-connect div.container svg,
    div.block-digital-training div.container svg,
    div.block-connect-with-us div.container svg {
      display: block;
      margin: 0 auto; }
  div.block-connect div.overlay,
  div.block-digital-training div.overlay,
  div.block-connect-with-us div.overlay {
    z-index: 2000;
    width: 100%;
    height: 100%;
    position: absolute;
    top: 0px;
    left: 0px;
    background: rgba(0, 0, 0, 0.5); }
  div.block-connect.connect_bg,
  div.block-digital-training.connect_bg,
  div.block-connect-with-us.connect_bg {
    background: url("../images/connect_bg.jpg") center center no-repeat;
    background-size: cover; }

div.block-digital-training {
  height: 430px; }
  div.block-digital-training.digital_bg {
    background: url("../images/digital_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.block-digital-training a.btn-start {
    background-image: linear-gradient(-151deg, #0EACD1 0%, #0674A5 94%);
    color: #fff;
    width: 100%;
    height: 64px;
    border: none;
    max-width: 320px;
    margin: 20px auto;
    display: block;
    line-height: 48px; }
  div.block-digital-training h2 {
    font-size: 48px;
    font-weight: bold;
    margin: 10px 0px; }
  div.block-digital-training h3 {
    font-size: 24px;
    font-weight: bold; }
  div.block-digital-training p {
    font-size: 14px; }
  div.block-digital-training h2, div.block-digital-training h3, div.block-digital-training p {
    text-align: center;
    color: #fff; }
  div.block-digital-training div.overlay {
    background: rgba(0, 0, 0, 0.8); }

div.block-connect-with-us {
  height: 360px; }
  div.block-connect-with-us div.container {
    padding: 30px 0px; }
  div.block-connect-with-us.connect_withus_bg {
    background: url("../images/connect_withus.jpg") center center no-repeat;
    background-size: cover; }
  div.block-connect-with-us div.overlay {
    background: rgba(255, 255, 255, 0.9); }

.block-free-website {
  position: relative; }
  .block-free-website h2 {
    font-size: 36px;
    color: #000000;
    font-weight: bold;
    letter-spacing: 0;
    text-align: right;
    text-shadow: 0 2px 4px rgba(0, 0, 0, 0.15); }
    .block-free-website h2 small {
      font-size: 18px;
      color: #9A9A9A;
      letter-spacing: 0;
      display: block;
      margin: 0px 0px 20px 0px; }
  .block-free-website p {
    text-align: right;
    font-size: 16px;
    color: #000; }
  .block-free-website a {
    margin: 0px auto;
    height: 226px;
    width: 200px;
    text-align: Center;
    color: #fff;
    display: flex;
    align-items: center;
    justify-content: center;
    border-radius: 4px;
    flex-direction: column;
    border: none;
    text-decoration: none;
    background-image: linear-gradient(151deg, #0EACD1 0%, #0674A5 94%);
    font-size: 24px;
    font-weight: bold;
    padding: 0px 10px 20px 10px;
    -webkit-transition: 0.2s ease;
    -moz-transition: 0.2s ease;
    -ms-transition: 0.2s ease;
    -o-transition: 0.2s ease;
    transition: 0.2s ease; }
    .block-free-website a svg {
      margin: 10px 0px; }
    .block-free-website a:hover {
      -webkit-transform: scale(1.1);
      -moz-transform: scale(1.1);
      -ms-transform: scale(1.1);
      -o-transform: scale(1.1);
      transform: scale(1.1); }
    .block-free-website a span {
      display: block;
      font-size: 12px;
      color: #fff;
      margin: 10px 0px;
      font-weight: normal; }
  .block-free-website a.btn-start {
    background-image: linear-gradient(-151deg, #0EACD1 0%, #0674A5 94%);
    color: #fff;
    width: 100%;
    height: 64px;
    border: none;
    font-size: 18px;
    line-height: 40px;
    padding-top: 10px; }

div.block-connect h2 {
  text-align: center;
  font-weight: bold;
  font-size: 36px;
  color: #FFFFFF;
  letter-spacing: 0;
  text-shadow: 0 2px 4px rgba(0, 0, 0, 0.15);
  margin: 10px 0px; }
div.block-connect h5 {
  font-size: 18px;
  color: #FFFFFF;
  letter-spacing: 0;
  text-align: center;
  font-weight: normal;
  line-height: 1.6em; }
div.block-connect .connect-buttons {
  display: flex;
  justify-content: center;
  margin: 60px 0px; }
  div.block-connect .connect-buttons > div {
    margin: 0px 20px;
    width: 160px;
    height: 160px;
    border-radius: 4px;
    background: #fff;
    text-align: center;
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
    padding: 15px;
    -webkit-transition: 0.2s ease;
    -moz-transition: 0.2s ease;
    -ms-transition: 0.2s ease;
    -o-transition: 0.2s ease;
    transition: 0.2s ease; }
    div.block-connect .connect-buttons > div:hover {
      -webkit-transform: scale(1.05);
      -moz-transform: scale(1.05);
      -ms-transform: scale(1.05);
      -o-transform: scale(1.05);
      transform: scale(1.05); }
    div.block-connect .connect-buttons > div a {
      display: block;
      font-size: 18px;
      color: #246E9E;
      letter-spacing: 0;
      text-align: center;
      line-height: 22px;
      font-weight: 600;
      text-decoration: none; }
      div.block-connect .connect-buttons > div a svg {
        margin: 10px auto; }
  div.block-connect .connect-buttons .btn_2 {
    background: #EB8F24; }
    div.block-connect .connect-buttons .btn_2 a {
      color: #fff; }
  div.block-connect .connect-buttons .btn_3 {
    background: #45B9D3; }
    div.block-connect .connect-buttons .btn_3 a {
      color: #fff; }
  div.block-connect .connect-buttons .btn_4 {
    background: #E94343; }
    div.block-connect .connect-buttons .btn_4 a {
      color: #fff; }
  div.block-connect .connect-buttons .btn_5 {
    background: #161515; }
    div.block-connect .connect-buttons .btn_5 a {
      color: #fff; }

footer {
  background: #194964;
  height: 360px;
  padding: 60px 0px; }
  footer ul {
    margin: 0px;
    padding: 0px; }
    footer ul li {
      list-style: none;
      font-weight: 600;
      font-size: 15px;
      font-family: "Montserrat", sans-serif;
      color: #fff; }
      footer ul li a {
        font-family: "Montserrat", sans-serif;
        text-decoration: none;
        font-weight: normal;
        color: #fff;
        padding: 7px 0px;
        display: block; }
        footer ul li a:hover {
          text-decoration: none;
          color: #f9f9f9; }
  footer div.copyright {
    background: #fff;
    padding: 20px 0px; }
    footer div.copyright p {
      text-align: center;
      font-size: 12px; }
  footer div.social-media-icons {
    text-align: center;
    padding: 20px 0px;
    border-top: thin solid #164158; }
    footer div.social-media-icons a {
      text-align: Center;
      width: 44px;
      height: 44px;
      display: inline-block;
      color: #fff;
      font-size: 18px; }
      footer div.social-media-icons a:hover {
        color: #f9f9f9; }

div.about-mp iframe,
div.page-jesus iframe {
  width: 100%;
  display: block;
  margin: 20px 0px; }
div.about-mp div.ministry-links ul,
div.page-jesus div.ministry-links ul {
  text-align: Center;
  margin: 0px;
  padding: 0px; }
  div.about-mp div.ministry-links ul li,
  div.page-jesus div.ministry-links ul li {
    list-style: none;
    display: inline-block; }
    div.about-mp div.ministry-links ul li a,
    div.page-jesus div.ministry-links ul li a {
      font-family: "Montserrat", sans-serif;
      display: block;
      padding: 7px 20px;
      font-size: 14px; }
div.about-mp h2,
div.page-jesus h2 {
  text-align: center;
  color: #000;
  font-size: 48px;
  font-weight: bold;
  margin: 20px 0px; }
div.about-mp h2.text-blue,
div.page-jesus h2.text-blue {
  color: #246E9E; }
div.about-mp h3,
div.page-jesus h3 {
  font-size: 36px;
  font-weight: bold; }
div.about-mp h4,
div.page-jesus h4 {
  font-weight: bold;
  text-align: Center;
  color: #000;
  font-size: 24px; }
div.about-mp p,
div.page-jesus p {
  font-size: 16px;
  line-height: 2em;
  font-family: "Montserrat", sans-serif; }

div.partner-with-us {
  padding: 40px 0px; }
  div.partner-with-us h2 {
    font-weight: bold;
    font-size: 48px;
    color: #000;
    text-align: Center; }
  div.partner-with-us a.btn svg {
    display: inline-block; }

div.page-header {
  height: 290px;
  position: relative;
  margin-bottom: 40px; }
  div.page-header.page-big {
    height: 450px; }
    div.page-header.page-big .page-title {
      height: 450px; }
  div.page-header.page-xl {
    height: 720px; }
    div.page-header.page-xl .page-title {
      height: 720px; }
    div.page-header.page-xl div.overlay {
      position: absolute;
      width: 100%;
      height: 100%;
      background: rgba(0, 0, 0, 0.15);
      z-index: 2000;
      top: 0px;
      left: 0px; }
  div.page-header div.page-title {
    height: 290px;
    display: flex;
    justify-content: center;
    align-items: center;
    position: relative;
    z-index: 3000; }
    div.page-header div.page-title h2 {
      font-size: 48px;
      font-weight: bold;
      color: #fff;
      text-align: Center; }
      div.page-header div.page-title h2 span {
        display: block;
        font-size: 18px;
        font-weight: 400;
        text-align: Center; }
  div.page-header div.overlay {
    position: absolute;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.5);
    z-index: 2000;
    top: 0px;
    left: 0px; }
  div.page-header.donate_bg {
    background: url("../images/donate_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.partner_bg {
    background: url("../images/home_img.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.testimonial_bg {
    background: url("../images/testimonial_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.free_web_bg {
    background: url("../images/free_web_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.jesus_bg {
    background: url("../images/jesus_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.videos_bg {
    background: url("../images/videos_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.events_bg {
    background: url("../images/events_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.confess_bg {
    background: url("../images/confess_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.blog_bg {
    background: url("../images/blog_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.about_bg {
    background: url("../images/about_bg.jpg") center center no-repeat;
    background-size: cover; }
  div.page-header.digital_trining_bg {
    background: url("../images/dt.jpg") center center no-repeat;
    background-size: cover; }

img.page-full-image {
  width: 100%;
  margin: 60px auto; }

div.page-content {
  padding: 0px 0px; }
  div.page-content div.page-divider {
    border-top: thin solid #d8d8d8;
    margin: 40px 0px;
    position: relative; }
  div.page-content p {
    font-family: "Montserrat", sans-serif;
    font-size: 18px;
    text-align: center; }
  div.page-content .t-videos {
    padding: 0px 0px 60px 0px; }
    div.page-content .t-videos iframe {
      width: 100%;
      height: 220px; }
    div.page-content .t-videos p {
      font-weight: bold;
      font-size: 16px;
      text-align: left; }
  div.page-content .t-articles div.col-md-6 a {
    display: block;
    background: #f1f1f1;
    padding: 20px;
    text-decoration: none;
    margin: 0px 0px 20px 0px; }
    div.page-content .t-articles div.col-md-6 a:hover {
      background: #fff; }
    div.page-content .t-articles div.col-md-6 a div.col-sm-6 p {
      color: #000;
      font-size: 14px;
      font-weight: bold; }
      div.page-content .t-articles div.col-md-6 a div.col-sm-6 p span {
        color: #2397BC; }
    div.page-content .t-articles div.col-md-6 a h3 {
      font-size: 20px;
      color: #000;
      font-weight: bold;
      text-decoration: none;
      margin: 20px 0px 0px 0px; }

.testimony-tabs {
  text-align: Center;
  margin-bottom: 40px; }
  .testimony-tabs li {
    display: inline-block;
    margin-left: -4px; }
    .testimony-tabs li a {
      color: #494949;
      text-decoration: none;
      display: block;
      padding: 20px 60px;
      font-size: 20px;
      font-weight: 600;
      text-align: Center;
      /* Rectangle: */
      /* Rectangle: */
      background: #E4E4E4;
      box-shadow: 0 2px 4px 0 rgba(0, 0, 0, 0.2);
      border-radius: 8px 0 0 8px; }
      .testimony-tabs li a.active, .testimony-tabs li a:hover {
        color: #fff;
        background-image: linear-gradient(151deg, #0EACD1 0%, #0674A5 94%); }
      .testimony-tabs li a:active {
        transform: scale(0.98); }
  .testimony-tabs li:last-child a {
    border-radius: 0px 8px 8px 0px; }

.block-social-share {
  padding: 60px 0px; }

.block-countries {
  padding: 60px 0px; }

.featured-blog {
  position: relative; }
  .featured-blog div.col-md-3 {
    position: relative;
    padding: 0px; }
    .featured-blog div.col-md-3 a {
      display: block;
      text-decoration: none;
      padding: 5px; }
      .featured-blog div.col-md-3 a div.blog-info {
        position: absolute;
        z-index: 2000;
        width: 60%;
        height: 30%;
        /* top: 25%; */
        left: 20%;
        bottom: 0px;
        text-align: center; }
      .featured-blog div.col-md-3 a h3 {
        font-size: 18px;
        color: #FFFFFF;
        text-align: center; }
      .featured-blog div.col-md-3 a div.blog-category {
        font-size: 12px;
        font-weight: 300;
        text-align: Center;
        color: #fff; }
      .featured-blog div.col-md-3 a div.created-date {
        color: #818181;
        font-size: 12px; }
    .featured-blog div.col-md-3 figure {
      display: block;
      margin: 0px; }
      .featured-blog div.col-md-3 figure img {
        width: 100%; }

.page-form {
  padding: 60px 0px; }
  .page-form svg {
    display: block;
    margin: 0 auto; }

.form_bg {
  background: url("../images/form_bg.jpg") center center no-repeat;
  background-size: cover; }

.digital_training_info {
  background: #00BAFF;
  height: 280px;
  margin: 100px 0px; }
  .digital_training_info p {
    color: #fff;
    font-size: 18px;
    font-weight: bold;
    padding-top: 60px; }
  .digital_training_info div.col-md-4 {
    position: relative; }
  .digital_training_info img {
    position: absolute;
    top: -90px;
    z-index: 3000; }
  .digital_training_info a.btn {
    display: block;
    text-decoration: none;
    background: #fff;
    color: #2474A4;
    font-size: 18px;
    font-weight: bold;
    text-align: Center;
    margin-top: 100px;
    height: 64px;
    border-radius: 4px;
    padding-top: 15px;
    /* Rectangle 18: */
    box-shadow: 0 4px 4px 0 rgba(0, 0, 0, 0.28); }
    .digital_training_info a.btn:active {
      transform: scale(0.98); }

a.btn-start {
  background-image: linear-gradient(-151deg, #0EACD1 0%, #0674A5 94%);
  color: #fff;
  width: 100%;
  height: 64px;
  border: none;
  max-width: 320px;
  margin: 20px auto;
  display: block;
  line-height: 48px;
  font-weight: bold; }

div.page-events {
  position: relative; }
  div.page-events a.event-item {
    display: block;
    text-decoration: none;
    margin: 0px 0px 40px 0px;
    position: relative; }
    div.page-events a.event-item:hover div.event-title {
      color: #2474A4; }
    div.page-events a.event-item button.btn-event-reg {
      /* Rectangle: */
      background-image: linear-gradient(117deg, rgba(157, 185, 213, 0.98) 0%, #287BDE 100%);
      box-shadow: 0 2px 4px 0 rgba(0, 0, 0, 0.5);
      border-radius: 4px;
      color: #fff;
      border: none;
      font-size: 14px;
      font-weight: bold;
      padding: 10px 20px;
      margin: 15px 0px; }
      div.page-events a.event-item button.btn-event-reg:hover {
        background: #2474A4; }
    div.page-events a.event-item div.event-title {
      font-size: 20px;
      font-weight: bold;
      color: #000;
      text-decoration: none; }
    div.page-events a.event-item div.flag {
      position: absolute;
      right: 0px;
      top: 0px; }
    div.page-events a.event-item div.event-date {
      width: 65px;
      text-align: right;
      float: right;
      text-decoration: none; }
      div.page-events a.event-item div.event-date span {
        display: block; }
      div.page-events a.event-item div.event-date span.date {
        font-size: 36px;
        font-weight: bold;
        color: #D73030; }
      div.page-events a.event-item div.event-date span.month,
      div.page-events a.event-item div.event-date span.year {
        text-transform: uppercase;
        font-size: 22px;
        color: #D73030; }
    div.page-events a.event-item div.event-time {
      color: #2474A4;
      font-size: 14px;
      text-decoration: none; }

div.partner-page div.donation-btns {
  text-align: center;
  margin: 0px 0px 40px 0px; }
div.partner-page a.btn.btn-become-partner {
  /* Rectangle 8 Copy: */
  /* Rectangle 8 Copy 2: */
  background: #FFFFFF;
  border: 1px solid #F4F4F4;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.25);
  border-radius: 162.5px;
  color: #000;
  font-size: 20px;
  text-align: left;
  display: inline-block;
  font-weight: bold;
  padding: 30px 40px;
  width: 400px;
  margin: 0px 10px 0px 10px;
  border: none; }
  div.partner-page a.btn.btn-become-partner img {
    float: left;
    margin: 0px 15px 0px 0px; }
  div.partner-page a.btn.btn-become-partner:hover {
    background-image: linear-gradient(151deg, #0EACD1 0%, #0674A5 94%);
    color: #fff; }
  div.partner-page a.btn.btn-become-partner.active {
    background-image: linear-gradient(151deg, #0EACD1 0%, #0674A5 94%); }
div.partner-page div.payment-methods {
  padding: 40px;
  margin: 0px 0px 40px 0px;
  /* Rectangle 8: */
  background: #FFFFFF;
  box-shadow: 0 2px 20px 0 rgba(0, 0, 0, 0.1);
  border-radius: 17px;
  text-align: Center; }
  div.partner-page div.payment-methods h4 {
    font-size: 20px;
    text-align: Center;
    color: #000;
    margin: 0px 0px 20px 0px; }
  div.partner-page div.payment-methods a {
    display: inline-block;
    width: 130px;
    margin: 10px 10px; }
    div.partner-page div.payment-methods a img {
      width: 100%; }

div.page-videos {
  position: relative; }
  div.page-videos .v-cat-active {
    /* Sermons: */
    font-size: 24px;
    color: #3D4041;
    letter-spacing: 0; }
  div.page-videos div.related-videos h5 {
    color: #686868;
    font-size: 14px;
    text-align: left;
    margin: 20px 0px;
    font-family: "Montserrat", sans-serif; }
  div.page-videos div.col-md-4 {
    margin: 0px 0px 20px 0px; }
    div.page-videos div.col-md-4 iframe {
      width: 100%;
      height: 200px; }
    div.page-videos div.col-md-4 p {
      text-align: left;
      font-size: 14px;
      font-weight: bold;
      color: #000;
      font-family: "Montserrat", sans-serif; }
  div.page-videos div.main-video {
    margin: 0px 0px 20px 0px; }
    div.page-videos div.main-video iframe {
      width: 100%;
      height: 420px; }
  div.page-videos .v-cats li a {
    padding: 7px 10px;
    display: block;
    font-size: 18px;
    color: #2474A4;
    font-weight: 400;
    transition: 0.2s ease;
    text-decoration: none;
    margin: 0px 0px 10px 0px; }
    div.page-videos .v-cats li a.active {
      background: #0674A5;
      box-shadow: 0 1px 2px 0 rgba(0, 0, 0, 0.5);
      color: #fff;
      font-weight: bold;
      padding: 7px 20px; }
    div.page-videos .v-cats li a:hover {
      /* Rectangle 10 Copy 4: */
      background: #0674A5;
      box-shadow: 0 1px 2px 0 rgba(0, 0, 0, 0.5);
      border-radius: 4px;
      color: #fff;
      font-weight: bold;
      padding: 7px 20px; }
  div.page-videos h3 {
    text-align: left;
    margin: 0px 0px 20px 0px;
    font-size: 24px;
    font-weight: bold;
    color: #000;
    letter-spacing: 0; }
    div.page-videos h3 span {
      color: #818181;
      font-weight: normal; }

div.page-ministry div.d-training h4 {
  /* Empower Ministries: */
  font-size: 18px;
  color: #9A9A9A;
  letter-spacing: 0;
  text-align: right;
  margin: 7px 0px; }
div.page-ministry div.d-training h2 {
  /* FREE WEBSITE FOR EVE: */
  font-family: Avenir-Black;
  font-size: 36px;
  color: #000000;
  letter-spacing: 0;
  text-align: right;
  text-shadow: 0 2px 4px rgba(0, 0, 0, 0.15); }
div.page-ministry div.d-training a.btn {
  margin: 0px -1px;
  float: right; }
div.page-ministry div.d-training p {
  /* Easy and simple thre: */
  font-family: Avenir-Medium;
  font-size: 18px;
  color: #000000;
  margin: 7px 0px;
  letter-spacing: 0;
  text-align: right; }
div.page-ministry div.create-website div.col-md-4 a {
  /* Rectangle Copy 9: */
  background-image: linear-gradient(-151deg, #0EACD1 0%, #0674A5 94%);
  border-radius: 4px;
  transition: 0.2s ease;
  width: 220px;
  height: 240px;
  margin: 0 auto;
  text-align: center;
  padding: 20px;
  display: flex;
  flex-direction: column;
  align-items: Center;
  justify-content: center;
  text-decoration: none;
  font-size: 18px;
  font-weight: bold;
  color: #fff; }
  div.page-ministry div.create-website div.col-md-4 a svg {
    display: block;
    margin: 10px auto; }
  div.page-ministry div.create-website div.col-md-4 a p {
    margin: 7px 0px;
    font-size: 12px;
    text-align: Center; }
  div.page-ministry div.create-website div.col-md-4 a:hover {
    transform: scale(1.05); }

div.page-confess p span {
  display: block;
  color: #2474A4; }

div.page-header-content {
  padding: 100px 0px 0px 0px;
  position: relative;
  z-index: 3000; }
  div.page-header-content div.form-content {
    padding-top: 100px; }
  div.page-header-content h2 {
    color: #fff;
    font-weight: bold;
    text-align: center;
    font-size: 36px; }
  div.page-header-content p {
    font-size: 18px;
    color: #fff;
    text-align: center; }
  div.page-header-content svg {
    margin: 20px auto;
    display: block; }
  div.page-header-content input[type="number"] {
    width: 100%;
    height: 56px;
    background: #fff;
    border: none;
    font-weight: bold;
    font-size: 24px;
    text-align: center;
    margin: 0px 0px 40px 0px;
    border-radius: 4px; }
  div.page-header-content button.btn-donate {
    border: none;
    width: 100%;
    height: 56px;
    /* Rectangle 9 Copy 11: */
    background-image: linear-gradient(-125deg, #4AA7CD 0%, #246E9E 100%);
    box-shadow: 0 2px 4px 0 rgba(0, 0, 0, 0.2);
    border-radius: 4px;
    color: #fff;
    font-weight: bold;
    font-size: 24px; }
  div.page-header-content button.btn-amount {
    border-radius: 4px;
    width: 100%;
    /* 20: */
    font-size: 24px;
    color: #000000;
    letter-spacing: 0;
    text-align: center;
    font-weight: bold;
    margin: 0px 0px 40px 0px; }
    div.page-header-content button.btn-amount:hover {
      background: #47C86E;
      color: #fff; }

.follow-us {
  text-align: center;
  background: #f1f1f1;
  padding: 60px 0px;
  position: relative; }
  .follow-us h3 {
    margin: 20px 0px;
    font-weight: bold;
    font-size: 36px; }
  .follow-us .social-connect {
    text-align: center; }
    .follow-us .social-connect a {
      display: inline-block;
      width: 72px;
      height: 72px;
      margin: 0px 20px; }

.country-contact {
  background: #fff;
  padding: 60px 0px; }
  .country-contact a {
    display: inline-block;
    color: #000;
    text-decoration: none;
    text-align: center;
    font-size: 16px;
    font-weight: 400;
    width: 240px; }
    .country-contact a strong {
      display: block;
      font-size: 20px;
      font-weight: bold; }

.page-build-church h2 {
  font-size: 36px;
  font-weight: bold;
  color: #000;
  text-align: Center;
  margin: 15px 0px; }
.page-build-church div.col-md-4 img {
  margin: 5px;
  width: 100%; }

div.page-blog div.blog-image figure img {
  width: 100%; }
div.page-blog div.blog-title {
  background: #fff;
  padding: 40px;
  position: relative;
  margin: -100px 20px 0px 20px; }
  div.page-blog div.blog-title h3 {
    font-weight: bold;
    font-size: 32px;
    color: #000000;
    letter-spacing: 0; }
div.page-blog div.blog-body p {
  text-align: left;
  font-family: "Montserrat", sans-serif; }

div.blog-date {
  /* April 30th 2019 Copy 9: */
  font-family: "Montserrat", sans-serif;
  font-size: 12px;
  color: #818181;
  letter-spacing: 0;
  text-align: center; }

@media screen and (max-width: 767px) {
  body {
    padding-top: 60px; }

  header {
    height: 60px;
    overflow: hidden; }
    header div.mobile_menu {
      z-index: 2000;
      cursor: pointer;
      display: block;
      position: absolute;
      right: 0px;
      top: 5px;
      width: 44px;
      height: 44px;
      font-size: 32px;
      color: #2474A4; }
    header div.logo img {
      width: 60px;
      margin: 0 auto;
      display: block; }
    header div.top-header {
      display: none; }
    header ul {
      float: none;
      padding: 0px; }
      header ul li:last-child {
        display: block; }
    header ul li {
      display: block; }
      header ul li a {
        height: auto;
        display: block;
        font-size: 18px;
        font-weight: bold;
        text-decoration: none;
        padding: 5px 20px;
        line-height: 30px; }
        header ul li a:hover {
          background: #2474A4;
          color: #fff; }

  header.expand {
    height: 500px;
    overflow-y: scroll; }

  .home-block-event {
    padding: 20px; }

  .home-block-event .next-date-wrapper .next-date-text {
    margin: 0px 0px 0px 0px;
    line-height: 36px; }

  .home-block-event .next-event-info .next-event-title {
    color: #2474A4;
    font-size: 24px;
    font-weight: bold;
    text-align: left;
    margin: 20px 0px 10px 0px; }

  .featured-video-block {
    height: auto; }

  .block-free-website a {
    width: auto; }

  div.block-connect, div.block-digital-training, div.block-connect-with-us {
    height: auto; }

  div.block-connect .connect-buttons {
    display: flex;
    flex-wrap: wrap; }

  div.page-events a.event-item div.event-date {
    padding-left: 20px;
    float: left;
    display: flex; }
  div.page-events a.event-item img {
    width: 100%; } }

/*# sourceMappingURL=app.cs.map */
