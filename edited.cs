@import url('https://fonts.googleapis.com/css?family=Satisfy');
@import url('https://monstrousdev.github.io/themes/addons/user-tags.css');
@import url('https://tropix126.github.io/BetterDiscordStuff/blockBetterDocs.css');
::selection {background:var(--main-color-faded) !important;}
/*
  /$$$$$$
 /$$__  $$
| $$  \ $$ /$$   /$$  /$$$$$$   /$$$$$$   /$$$$$$  /$$$$$$
| $$$$$$$$| $$  | $$ /$$__  $$ /$$__  $$ /$$__  $$|____  $$
| $$__  $$| $$  | $$| $$  \__/| $$  \ $$| $$  \__/ /$$$$$$$
| $$  | $$| $$  | $$| $$      | $$  | $$| $$      /$$__  $$
| $$  | $$|  $$$$$$/| $$      |  $$$$$$/| $$     |  $$$$$$$
|__/  |__/ \______/ |__/       \______/ |__/      \_______/
	       		By Tropical

TABLE OF CONTENTS

1. Background and Sizing
  1.a. Main Background
  1.b. Spacing
  1.c. General Transparency
  1.d. Light Mode Blocker

2. Titlebar
  2.a. Main Titlebar

3. Chat
  3.a. Messages and Codeblocks
  3.b. Dividers
  3.c. Transparency
  3.d. Chat Input Area
  3.e. Chat Header
  3.f. Spinners
  3.g. Welcome Message
  3.h. Scrollbar
  3.i. Bot Tags
  3.j. Linked Channels and Messages
  3.k. Reactions
  3.l. Search Bars
  3.m. Invites
  3.n. Embeds
  3.o. Calls
  3.p. Typing Indicators
  3.q. Tags

4. Channels Area
  4.a. Channels
  4.b. Account Details Container
  4.c. Top Header
  4.d. Transparency
  4.e. Private Channels Icons
  4.f. Channel Notice
  4.g. Categories

5. Guilds
  5.a. Wrapper
  5.b. Add/Create Guilds Button
  5.c. Unread and Selected Indicators
  5.d. Home Icon
  5.e. Tooltips
  5.a. Canary Wrapper
  5.b. Canary Add Guilds
  5.c. Canary Unread Ind.
  5.d. Canary HomeIcon

6. Members List
  6.a. Transparency
  6.b. Selected and Hovered Content
  6.c. User Status

7. Popups and Dropdowns
  7.a. Server Dropdown
  7.b. Status Picker
  7.c. Context Menus
  7.d. User Popouts
  7.e. Pinned Messages/Mentions
  7.f. Search Popout
  7.g. Add to Group DM
  7.h. Select Popouts
  7.i. Emoji Picker
  7.j. Gif Picker
  7.k. RTC Connection Popout
  7.l. Toasts
  7.m. @Everyone Popout

8. Modals
  8.a. Transparency
  8.b. Upload Modal
  8.c. Keyboard Shortcuts Modal
  8.d. Quick Switcher
  8.e. Screenshare Modal
  8.f. Add/Create Guilds Modal
  8.g. Reactions Modal
  8.h. Profile Modal
  8.i. Download Apps Screen

9. Settings
  9.a. Transparency and Sidebar
  9.b. Buttons and Checkboxes and Switches
  9.c. My Account
  9.d. Authorized Apps
  9.e. Connections
  9.f. Billing
  9.g. Nitro
  9.h. HypeSquad
  9.i. Voice and Video
  9.j. Overlay/Streamer Mode
  9.k. Notifications
  9.l. Keybinds
  9.m. Game Activity
  9.n. Game Library
  9.o. Language
  9.p. Change Log
  9.q. Dev Options
  9.r. BD Settings
  9.s. Server Settings
  9.t. Ace CSS Editor
  9.u. Changelog

10. Tag Animations (Animations by EllexideCodes, added here for support on tags.)
   10. Keyframes

11. Store, Activity, Library, Friends and Server Discovery
  11.a. Store
  11.b. Activity
  11.c. Library
  11.d. Friends

12. Out of app areas
  12.a. Login Screen
  12.b. Crash Screen
  12.c. Loading Screen

13. Plugins
  13.a. Theme and Pluginrepo
  13.b. BetterFormattingRedux
  13.c. GoogleTranslateOption
  13.d. Share Button
  13.e. Read All Notifications
  13.f. Compatibility Tags
  13.g. DetailedServerTooltips
  13.h. Reply System
  13.i. Permissions Viewer
  13.j. StatusEverywhere
  13.k. Date Viewer

14. Roundness

15. Overwrite Grey SVG's
*/

/*1. Background and Sizing*/
/*1.a. Main Background*/
body::before {
  position: absolute;
  content: '';
  height: 100%;
  width: 100%;
  background-image: var(--backdrop);
  background-size: cover;
  background-repeat: no-repeat;
  background-position: center;
  pointer-events: none;
  box-shadow:inset 0 0 0 1000px var(--backdrop-darkness);
}
.layer-3QrUeG,
.layers-3iHuyZ,
.container-2lgZY8 {
	background: transparent !important;
}
/*Makes aurora compatible with monsters addons*/
.theme-dark,
.appMount-3VJmYg {
	--primary-color: rgba(0,0,0,0.75);
	--secondary-color: rgba(0,0,0,0.6);
	--tertiary-color: rgba(0,0,0,0.4);
	--quaternary-color: rgba(0,0,0,0.7);
}

/*1.b. Spacing*/
.app,
.app-2rEoOp {
	margin: 25px;
	border-radius: 6px;
	overflow: hidden;
}
.container-3gCOGc,
#friends,
.activityFeed-28jde9,
.gameLibrary-TTDw4Y,
.applicationStore-1pNvnv {
	border-radius: 6px !important;
}
.base-3dtUhz {
    border-radius:0 0 0 5px !important;
}

/*1.c. General Transparency*/
#app-mount,
.divider-3gKybi,
.typing-2GQL18,
.typing-2GQL18,
.guild-1EfMGQ .guildInner-3DSoA4 {
	background: transparent !important;
}

/*1.d. Light Mode Blocker (Based on MasicoreLord's Light Theme blocker, taken with permission). */
.theme-light .layer-3QrUeG:first-of-type::before {
  content: "Sorry, but light mode isnt supported in Aurora yet. :( ~Tropical";
  text-align:center;
  width: 500px;
  position:absolute;
  top:50%;
  left:50%;
  transform:translate(-50%, -50%);
  background:rgba(0,0,0,0.75);
  border:1px solid rgba(0,0,0,0.5);
  box-shadow:0 0 12px black;
  color:#fff;
  padding: 20px;
  padding-bottom:80px;
  border-radius: 5px;
}
.app-2rEoOp.vertical-V37hAW.theme-light .container-2Thooq > .noWrap-3jynv6 > .button-2b6hmh {
  position: absolute;
  left: 50%;
  border-radius:3px;
  top: 45%;
  transform: translate(-50%, 120%);
  width: 180px;
  height: 40px;
  visibility: visible !important;
  background: var(--main-color) !important;
  box-shadow:0 0 12px black;
  opacity:1;
}
.app-2rEoOp.vertical-V37hAW.theme-light .container-2Thooq > .noWrap-3jynv6 > .button-2b6hmh:before {
  position: absolute;
  content: "Turn On Dark Mode";
  padding:20px;
  width:200px;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  font-size: 15px;
  font-weight: 500;
  text-align: center;
}
.theme-light .side-8zPYf6 .item-PXvHYJ:nth-of-type(19) {
    border:2px solid var(--hover-color);
    color:var(--hover-color);
    background:var(--main-color-faded);
    padding:16px;
    text-align:center;
}
.theme-light .layer-3QrUeG {
  background:var(--backdropblurred) !important;
  background-size:cover !important;
}
.theme-light .layer-3QrUeG:first-of-type * {
  visibility:hidden;
}
/*============== END OF SECTION ============== */

/*2. Titlebar*/
/*2.a. Main Titlebar*/
.wordmark-2iDDfm path {
	display:none;
}
.da-typeMacOS {
    margin-left:1.25% !important;
    margin-top:-0.3%;
}
#app-mount .wrapper-1Rf91z {
    margin-top:0px !important;
    padding-top:0px !important;
}
.wordmark-2iDDfm:after {
	content:'Aurora v2.6';
	position: absolute !important;
	left: 5px;
	width: 100vw;
	font-family:'Satisfy';
	color: rgba(255,255,255,0.8);
	font-size: 19px;
	font-weight:bold;
}
.da-winButtonClose:active {
    box-shadow:inset 0 0 1000px rgba(0,0,0,0.35);
}
.da-winButtonMinMax:active {
    background:rgba(255,255,255,0.15);
}
.winButton-iRh8-Z:nth-child(3) svg {
	display:none;
}
.da-winButton {
    width:45px;
    height:30px;
    transition:250ms ease all;
}
.titleBar-AC4pGV .winButton-iRh8-Z:nth-child(3) {
	background-image: url(data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSIjRkZGRkZGIj48cGF0aCBkPSJNMCAwaDI0djI0SDB6IiBmaWxsPSJub25lIi8+PHBhdGggZD0iTTcgMTRINXY1aDV2LTJIN3YtM3ptLTItNGgyVjdoM1Y1SDV2NXptMTIgN2gtM3YyaDV2LTVoLTJ2M3pNMTQgNXYyaDN2M2gyVjVoLTV6Ii8+PC9zdmc+) !important;
	background-repeat: no-repeat;
	background-position: center;
	background-size: 19px;
}
.da-winButtonClose:hover:after {
    content:'Close';
    position:absolute;
    top:40px;
    color:#dcddde;
    background:inherit;
    border-radius:5px;
    animation: fadetop 150ms;
    padding:8px 12px;
    font-size:14px;
    font-weight:500;
    box-shadow:0px 0px 20px rgba(0, 0, 0, 0.5);
    right:2px;
}
.da-winButton:nth-of-type(3):hover:after {
    content:'Maximize';
    position:absolute;
    top:40px;
    color:#dcddde;
    background:var(--main-color);
    padding:8px 12px;
    border-radius:5px;
    filter:none !important;
    animation: fadetop 150ms;
    font-size:14px;
    font-weight:500;
    box-shadow:0px 0px 20px rgba(0, 0, 0, 0.5);
}
.da-winButton:nth-of-type(4):hover:after {
    content:'Minimize';
    background:var(--main-color);
    position:absolute;
    top:40px;
    color:#dcddde;
    padding:8px 12px;
    border-radius:5px;
    opacity:1;
    animation: fadetop 150ms;
    font-size:14px;
    font-weight:500;
    box-shadow:0px 0px 20px rgba(0, 0, 0, 0.5);
}

/*============== END OF SECTION ============== */

/*3. Chat*/
/*3.a. Messages and Codeblocks*/
.da-containerCozy .inner-zqa7da {
	background:rgba(0,0,0,0.25) !important;
}
[class*="avatar-"], .image-33JSyf {
	box-shadow: 0.5px 0.5px 2px black !important;
}
.messageCozy-2JPAPA .image-33JSyf {
	border-radius:var(--chat-avatar-roundness) !important;
}
.operations-36ENbA>a {
	color:var(--hover-color) !important;
}
.containerCozy-jafyvG {
	background: rgba(0,0,0,0.4);
	margin: 15px 15px 0 25px;
	border-radius: 5px;
}
.spoilerText-3p6IlD.hidden-HHr2R9,
.spoilerText-3p6IlD {
  background: transparent !important;
}
.spoilerText-3p6IlD.hidden-HHr2R9 .inlineContent-3ZjPuv {
  opacity: 1;
  filter: blur(5px);
}
.spoilerWarning-2aAZq1 {
  background-color: rgba(0,0,0,0.5) !important;
  color: white !important;
}
.spoilerContainer-331r0R:hover .spoilerWarning-2aAZq1 {
  background: var(--main-color) !important;
}
.isLocalBot-38G0P0 {
	background:transparent !important;
	box-shadow:none !important;
}
.message-2qRu38 {
	background:transparent !important;
	border:none !important;
	box-shadow:none !important;
}
.markup-2BOw-j pre {
    background:transparent !important;
    border-radius:5px !important;
}
.markup-2BOw-j code {
    background:rgba(0,0,0,0.5) !important;
    border-radius:5px !important;
}
.messageGroupBlocked-3wrQQX.revealed-1_RKsf {
    border:none !important;
}
.messageGroupBlocked-3wrQQX {
    background:rgba(0,0,0,0.5) !important;
    border:none !important;
}
.messageGroupBlockedBtn-1PBBh- {
    background:transparent !important;
}
.option-1l2vXE .lookFilled-1Gx00P.colorGreen-29iAKY {
    background:var(--main-color) !important;
}

/*3.b. Dividers*/
.unreadBar-3YD_k9 {
	background:var(--main-color);
}
.newMessagesBar-mujexs button {
	color:#fff !important;
}
.divider-3gKybi {
	padding-top: 10px;
}
.dividerContent-2L12VI:before,
.dividerContent-2L12VI:after,
.dividerEnabled-2TTlcf {
	display:none;
}
.da-newMessagesBar {
    background:var(--hover-color) !important;
    box-shadow:0 0 12px rgba(0,0,0,.5) !important;
    border-radius:5px !important;
    transition:150ms all ease;
    width:fit-content;
    height:30px;
    animation: slide-up 200ms ease !important;
    margin-top:3px !important;
}
.da-newMessagesBar:hover {
  box-shadow:0 0 12px rgba(0,0,0,.5), inset 0 0 10000px rgba(0,0,0,0.25) !important;
}
.da-newMessagesBar:before {
  content:'';
  width:25px;
  height:30px;
  transform:scale(0.8);
  left:2px;
  -webkit-mask:url('data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAFySURBVEhL7de/K0ZRHMfxmx8D5WcZWEQZDBZGg5RNMclCKYv/gCz+BQOLxeDHYGAxKJkslP/AIGIikSjkx/tze04dp+s+91wndev51Gs457nnfp/b9z73nifKkVZs4B7nmMW/ZB9fjjEETRVaLJ1QoTu0Ya403oN9XANypRHreIJ9ZcYDerFozbkuMAWvbEKL36BeGo9wC8g77OP0xTT/iSFkSg1eSto1YaUPblE5hpsF6LOVeJQhTdCCy3j0M/U4gX11t5iHm1HoPFvxKEPSCvukUrhsfivcjO4UXaiGSZDCmjM/kTRrMAlSuBa7OCvDfm4Xv8cdGHD0ow5JCVJYN9YzNO/aQVKCFNbdqnew29NTzCApxe9xD0ZSDMN+Dwfr8Ss0n8YuEqzHqzhMcYBxmBS/x77xLqwbRAtu4lH+aOep82gblTnX0H5Jm7mJHCZxBBVeQuZM4wNa+BdX0B8ArwxiGXok+tqGNnveRSsJnCj6Bnlr2owdvxxcAAAAAElFTkSuQmCC');
  background:#fff;
}
.chat-3bRxxu .jumpToPresentBar-9P20AM button:first-child {
	display:none;
}
.jumpToPresentBar-9P20AM{
	left:auto!important;
}
.chat-3bRxxu .jumpToPresentBar-9P20AM button:last-child {
	color:#fff;
}
.chat-3bRxxu .jumpToPresentBar-9P20AM{
	background:var(--main-color);
}
.chat-3bRxxu .jumpToPresentBar-9P20AM .spinner {
	padding-right:7px;
	padding:8px;
	padding-left:50px;
}
.hasMore-3e72_v button {
	background:rgba(0,0,0,0.5) !important;
	border:none !important;
	color:var(--hover-color) !important;
}
.dividerContent-2L12VI {
	font-size:20px;
	text-transform:none;
	font-weight:500;
}

/*3.c. Transparency*/
.chat-3bRxxu .content-yTz4x3 {
	background-size: cover !important;
	background-repeat:no-repeat;
	background: inherit;
}
.chat-3bRxxu,
.noChannel-Z1DQK7 {
	border-radius: 6px;
	background: var(--backdropblurred) !important;
	background-size:cover !important;
	background-position: center !important;
	background-attachment: fixed !important;
}

/*3.d. Chat Input Area*/
.chat-3bRxxu form {
	margin: 4px 25px -5px 25px;
}
.newMessagesBar-mujexs {
	background:var(--main-color);
}
.attachButtonDivider-3Glu60 {
	display:none;
}
.inner-zqa7da {
	background: transparent !important;
	border-radius: 3px;
}
.attachButton-1UjEWA:hover:before {
    content:'Attach FIles';
    position:absolute;
    color:#dcddde;
    width:contain;
    bottom:45px;
    background:var(--main-color);
    padding:8px 12px;
    border-radius:5px;
    filter:none !important;
    animation: fadebottom 150ms;
    font-size:14px;
    font-weight:500;
    box-shadow:0px 0px 20px rgba(0, 0, 0, 0.5);
}
.wrapper-39oAo3 {
  background:transparent !important;
}
.messagesWrapper-3lZDfY,
.chat-3bRxxu form {
	background:transparent !important;
}
.button-2vd_v_ {
	margin-left:7px;
}

/*3.e. Chat Header*/
.title-3qD0b- .icon-1R19_H[name="Pin"] {
    background-image:url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4NCjwhLS0gR2VuZXJhdG9yOiBBZG9iZSBJbGx1c3RyYXRvciAxOC4wLjAsIFNWRyBFeHBvcnQgUGx1Zy1JbiAuIFNWRyBWZXJzaW9uOiA2LjAwIEJ1aWxkIDApICAtLT4NCjwhRE9DVFlQRSBzdmcgUFVCTElDICItLy9XM0MvL0RURCBTVkcgMS4xLy9FTiIgImh0dHA6Ly93d3cudzMub3JnL0dyYXBoaWNzL1NWRy8xLjEvRFREL3N2ZzExLmR0ZCI+DQo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkNhbHF1ZV8xIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB4PSIwcHgiIHk9IjBweCINCgkgdmlld0JveD0iMCAwIDI0IDI0IiBlbmFibGUtYmFja2dyb3VuZD0ibmV3IDAgMCAyNCAyNCIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+DQo8cGF0aCBmaWxsPSJub25lIiBkPSJNMCwwaDI0djI0SDBWMHoiLz4NCjxwb2x5Z29uIGZpbGw9IiNGRkZGRkYiIHBvaW50cz0iMTcuOSwxMy43IDE1LjgsMTIuNiAxNS4xLDUuMyAxNi40LDUgMTYuNCwzIDcuNiwzIDcuNiw1IDguOSw1LjMgOC4yLDEyLjYgNi4xLDEzLjcgNi4xLDE1LjcgDQoJMTEsMTUuNyAxMSwyMSAxMywyMSAxMywxNS43IDE3LjksMTUuNyAiLz4NCjwvc3ZnPg0K) !important;
}
.title-3qD0b- .icon-1R19_H[name="Pin"] path {
  visibility:hidden;
}
.title-3qD0b- .icon-1R19_H[name="NotificationBell"] {
    background-image:url("data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjRkZGRkZGIiBoZWlnaHQ9IjI0IiB2aWV3Qm94PSIwIDAgMjQgMjQiIHdpZHRoPSIyNCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4gICAgPHBhdGggZD0iTTEyIDIyYzEuMSAwIDItLjkgMi0yaC00YzAgMS4xLjg5IDIgMiAyem02LTZ2LTVjMC0zLjA3LTEuNjQtNS42NC00LjUtNi4zMlY0YzAtLjgzLS42Ny0xLjUtMS41LTEuNXMtMS41LjY3LTEuNSAxLjV2LjY4QzcuNjMgNS4zNiA2IDcuOTIgNiAxMXY1bC0yIDJ2MWgxNnYtMWwtMi0yeiIvPjwvc3ZnPg==") !important;
}
.title-3qD0b- .icon-1R19_H[name="Phone"]:hover {
    animation:shake 150ms linear infinite;
}
@keyframes shake {
    from {
        transform: rotate(-7deg);
    }
    to {
        transform: rotate(7deg);
    }
}

.title-3qD0b- .icon-1R19_H {
    transform:scale(0.9);
}
.aka-1mqp34 {
	background:var(--main-color);
}
.title-3qD0b-,
.da-headerBar {
	background:transparent !important;
	box-shadow:none !important;
}

/*3.f. Spinners*/
.spinner-wandering-cubes .spinner-item,
.spinner-pulsing-ellipsis .spinner-item,
.wanderingCubesItem-WPXqao {
	background:var(--main-color) !important;
	border-radius:50px;
}

/*3.g. Welcome Message*/
.da-h1 {
	color:var(--hover-color) !important;
}
.exclamation-1mi7Vi {
	-webkit-mask-image: url(https://discordapp.com/assets/7616be62f9b90270b5a2e1fe9d2ece4f.svg);
}
.share-1EA-d2 {
	-webkit-mask-image: url(https://discordapp.com/assets/07778297eb1e1e3d9bd3cd302920d5fb.svg);
}
.mobile-3_KEmF {
	-webkit-mask-image: url(https://discordapp.com/assets/83d501f2b7dd2987302ce29b321f4494.svg);
}
.twitter-1TN3uJ {
  -webkit-mask-image: url(https://discordapp.com/assets/326d79eb53886c88437e99a3754b1cd0.svg);
  -webkit-mask-size: 77%;
}
.icon-2shpbb {
  -webkit-mask-size:95%;
  -webkit-mask-position:center;
  -webkit-mask-repeat:no-repeat;
  background:var(--main-color) !important;
}

/*3.h. Scrollbar*/
.da-messagesWrapper .scrollerWrap-2lJEkd .scroller-2FKFPG::-webkit-scrollbar {
	width:10px !important;
}
.da-messagesWrapper .scrollerWrap-2lJEkd .scroller-2FKFPG::-webkit-scrollbar-track-piece {
	background: rgba(0, 0, 0, 0.4) !important;
    border: none !important;
    display:block !important;
}
.da-messagesWrapper .scroller-2FKFPG::-webkit-scrollbar-thumb {
  border:none !important;
  background:var(--main-color) !important;
}
.da-scrollerWrap .da-scroller::-webkit-scrollbar-track-piece {
    display:none !important;
}
.da-scroller:not(.messages-3amgkR)::-webkit-scrollbar-thumb {
    background:var(--hover-color) !important;
}
.da-scroller:not(.messages-3amgkR)::-webkit-scrollbar {
    width:5px !important;
}
.da-messagesWrapper .scroller::-webkit-scrollbar {
	width:10px !important;
}
.da-messagesWrapper .scroller::-webkit-scrollbar-track-piece {
	background: rgba(0, 0, 0, 0.4) !important;
    border: none !important;
    display:block !important;
}
.da-messagesWrapper .scroller::-webkit-scrollbar-thumb {
  border:none !important;
  background:var(--main-color) !important;
}
.da-scrollerWrap .da-scroller::-webkit-scrollbar-track-piece,
.da-guildsWrapper .scroller::-webkit-scrollbar {
    display:none !important;
}
.da-scroller:not(.messages-3amgkR)::-webkit-scrollbar-thumb {
    background:var(--hover-color) !important;
}
.da-scroller:not(.messages-3amgkR)::-webkit-scrollbar {
    width:5px !important;
}

/*3.i. Bot Tags*/
.botTag-2WPJ74 {
	background:var(--main-color);
	color:#fff !important;
}

/*3.j. Linked Channels and Mentions*/
.wrapper-3WhCwL {
  background:var(--main-color);
  color:#fff !important;
  border-radius:3px;
}
.da-isMentionedCozy:after {
    border-color:var(--hover-color);
}
.da-isMentionedCozy {
    background:var(--main-color-faded) !important;
}

/*3.k. Reactions*/
.reactions-1xb2Ex .reactionBtn-2na4rd {
	opacity: 0.8!important;
}
.reaction-1ELvT8.reactionMe-23mbRf .reactionCount-2ddRoS {
	opacity: 1;
}
.reaction-1ELvT8 {
	position: relative;
}
.reactionInner-rRPZdY {
	padding: 0px;
}
.reaction-1ELvT8 {
	background: rgba(0, 0, 0, 0.5) !important;
}
.reaction-1ELvT8 .emoji {
	margin: 0!important;
	background: none;
	opacity: 1 !important;
}
.reaction-1ELvT8.reactionMe-23mbRf {
	background: var(--main-color) !important;
	border-radius: 10px;
	opacity: 1 !important;
}
.reaction-1ELvT8 {
	border-radius: 10px;
	opacity: 0.7 !important;
}
.reaction-1ELvT8 .emoji {
	width: 32px;
	height: 32px;
	border-radius: 10px;
	transform: scale(0.7);
}
.reaction-1ELvT8.reactionMe-23mbRf .reactionCount-2ddRoS {
	font-weight: bold !important;
	color: var(--hover-color) !important;
}
.reaction-1ELvT8 .reactionCount-2ddRoS {
	position: absolute !important;
	margin-top: 22px !important;
	font-size: 11px;
	letter-spacing: 0;
	margin: 0;
	min-width: 32px!important;
}

/*3.l. Search Bars*/
.da-searchBar .da-searchBarInner {
	border:none;
}
.searchBar-6Kv8R2 {
	box-shadow:none !important;
}
.searchBar-2_Yu-C,
.searchBar-3dMhjb,
.searchBar-6Kv8R2 .da-searchBarInner,
.searchBar-1MOL6S,
.search .search-bar,
.search-bar .search-bar-inner,
.searchBar-6Kv8R2 .search-bar  {
	background:transparent !important;
	border:none !important;
}
.searchBar-2pE3BB .search-bar,
.searchBar-2pE3BB .da-searchBar {
	background:rgba(0,0,0,0.5) !important;
}
div[style*="width: 100%; height: 20px"] {
    height:15px !important;
}
.privateChannels-1nO12o .searchBar-6Kv8R2 {
    position: absolute;
    bottom: 40px;
    right: 35px;
    padding: 0;
    border-radius:500px !important;
    transform: translate(50%, 50%) scale(0.2);
    width: 255px;
    height: 255px;
    box-shadow:0px 0px 100px rgba(0,0,0,0.75) !important;
    background-image: url("data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjRkZGRkZGIiBoZWlnaHQ9IjI0IiB2aWV3Qm94PSIwIDAgMjQgMjQiIHdpZHRoPSIyNCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4gICAgPHBhdGggZD0iTTE1LjUgMTRoLS43OWwtLjI4LS4yN0MxNS40MSAxMi41OSAxNiAxMS4xMSAxNiA5LjUgMTYgNS45MSAxMy4wOSAzIDkuNSAzUzMgNS45MSAzIDkuNSA1LjkxIDE2IDkuNSAxNmMxLjYxIDAgMy4wOS0uNTkgNC4yMy0xLjU3bC4yNy4yOHYuNzlsNSA0Ljk5TDIwLjQ5IDE5bC00Ljk5LTV6bS02IDBDNy4wMSAxNCA1IDExLjk5IDUgOS41UzcuMDEgNSA5LjUgNSAxNCA3LjAxIDE0IDkuNSAxMS45OSAxNCA5LjUgMTR6Ii8+ICAgIDxwYXRoIGQ9Ik0wIDBoMjR2MjRIMHoiIGZpbGw9Im5vbmUiLz48L3N2Zz4="), var(--main-color);
    background-position: bottom 50% right 78px, bottom 0% right 0%;
    background-repeat: no-repeat;
    background-size: 40%, cover;
    transition:325ms width, 325ms background-size, 325ms right;
}
.privateChannels-1nO12o .searchBar-6Kv8R2:hover {
    width:965px;
    background-size: 12%, cover;
    right:110px;
}
.channel-2QD9_O.selected-1HYmZZ .linkButtonIcon-Mlm5d6 {
    color:#fff;
}
.privateChannels-1nO12o .searchBar-6Kv8R2:hover:after {
    content:"Search Messages";
    color:#fff;
    position:absolute;
    right:220px;
    height:255px;
    overflow:hidden;
    line-height:230px;
    font-size:88px;
}
.privateChannels-1nO12o .searchBar-6Kv8R2 input {
  pointer-events: initial;
  height: 100%;
  width: 100%;
  cursor: pointer;
}
.privateChannels-1nO12o .searchBar-6Kv8R2 input::-webkit-input-placeholder {
    color:transparent;
}
.privateChannels-1nO12o .searchBar-6Kv8R2 .searchBarInner-1_Tg2R {
  position: absolute;
  width: 100%;
  height: 100%;
  z-index: 100;
}
.search-2oPWTC .searchBar-3dMhjb {
    width:30px;
    transition-duration:300ms;
}
.search-2oPWTC .searchBar-3dMhjb:hover {
	width:200px;
}
.search-2oPWTC.da-focused .searchBar-3dMhjb {
	width: 244px !important;
}
.search-2oPWTC .da-searchBarIcon {
    cursor: pointer;
}
.searchBarIcon-1J6sKG .icon-3cZ1F_.visible-3V0mGj {
    opacity:.6 !important;
}
.emojiPicker-3m1S-j {
    height:60vh !important;
}
.emojiPicker-3m1S-j .scroller-3vODG7 {
    height:60vh !important;
}
.searchBar-6Kv8R2 .searchBarComponent-32dTOx {
    background:transparent !important;
    height:100% !important;
    width:100% !important;
}
.children-19S4PO:after {
    display:none;
}
.container-1r6BKw {
    background:transparent !important;
    box-shadow:none !important;
}
#app-mount .themed-OHr7kt.selected-3s45Ha.item-PXvHYJ {
    background:var(--main-color) !important;
}
.divider-3FBTu8 {
    display:none;
}
.akaBadge-1M-1Gw {
    background:var(--main-color) !important;
}
/*search bar*/
.iconContainer-O4O2CN {
    width:18px;
    height:18px;
}
.container-cMG81i {
    background:transparent !important;
}

/*3.m. Invites*/
.wrapper-35wsBm,
.invite-18yqGF {
    background:rgba(0,0,0,0.5) !important;
    border:none !important;
    box-shadow:0px 0px 5px black;
    transition: 150ms linear all;
}
.wrapper-35wsBm:hover,
.invite-18yqGF:hover {
    transform: scale(1.03) !important;
}
.invite-18yqGF .lookFilled-1Gx00P.colorGreen-29iAKY {
  background:var(--main-color) !important;
}


/*3.n. Embeds*/
.embed-IeVjo6:hover {
    -webkit-transform: scale(1.03) !important;
    transform: scale(1.03) !important;
}
.wrapper-2TxpI8 {
  background-color:rgba(0,0,0,0.25) !important;
}
.embedPill-1Zntps {
    height: calc(100% - 20px) !important;
    position: absolute !important;
    top: 10px !important;
    left: 6px !important;
    border-radius: 50px !important;
    width: 4px !important;
}
.embed-IeVjo6 {
    background-color: rgba(0, 0, 0, 0.66) !important;
    border-color: rgba(0, 0, 0, 0.66) !important;
}
.embed-IeVjo6 {
    border: 1px solid hsla(0,0%,80%,.3);
    padding: 8px 10px !important;
    -webkit-transition: 200ms cubic-bezier(.2, .11, 0, 1);
    transition: 200ms cubic-bezier(.2, .11, 0, 1) !important;
    box-shadow: 2px 2px 10px #0c0c0c !important;
    border-radius:5px;
}
.embedInner-1-fpTo {
    background:transparent !important;
    border:none !important;
}
.imageWrapper-2p5ogY.imageZoom-1n-ADA {
	box-shadow:0 3px 7px rgba(0,0,0,0.4);
	transition:250ms box-shadow cubic-bezier(0,0,0,.1);
}
.imageWrapper-2p5ogY.imageZoom-1n-ADA:hover {
		box-shadow:0 5px 15px rgba(0, 0, 0, 0.5);
}

/*3.o. Calls*/
.videoBackground-3AY_fu, .videoBackgroundTransition-3wpOSl {
    background: transparent !important;
}
.quickSelectPopoutOption-opKBx9:hover {
	background:rgba(255,255,255,0.05) !important;
}
.incomingCallInner-2VmFiR {
    background:rgba(0,0,0,0.5) !important;
}
.quickSelectPopout-X1hvgV {
	background:rgba(0,0,0,0.75) !important;
}
.container-1UB9sr {
	background:rgba(0,0,0,0.8) !important;
	box-shadow:0px 0px 5px black;
	border:none;
}
.check-2by_h9 {
	background:none;
	-webkit-mask-image:url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxNiIgaGVpZ2h0PSIxMiI+ICA8cGF0aCBmaWxsPSJub25lIiBzdHJva2U9IiM3Mjg5REEiIHN0cm9rZS13aWR0aD0iMyIgZD0iTTEuOTk2MDkzNzUgNS43ODM1MzM4bDMuNzAyODczODIgMy43MDI4NzM4TDE0LjE4NTM3NTIgMSIvPjwvc3ZnPg==");
	background:var(--main-color);
}
.audio-3vVhBi:after,
.video-15yGu3:after {
	background-color:rgba(0,0,0,0.5) !important;
}
.video-1FfuMD {
	background:transparent;
}
.wrapper-29NfPK {
	background:rgba(0,0,0,0.5) !important;
}
.wrapper-29NfPK.minimum-2d6zH6 .actions-2vadYq .center-1Vp33r {
	background:rgba(0,0,0,0.5) !important;
	border:none !important;
}
.callAvatarBorder-1D_KaE.video-3GgX2M.selected-2esnyn:not(.speaking-oCqYMI):not(.soundsharing-102bS9) {
	box-shadow:inset 0 0 0 2px var(--hover-color) !important;
}
.path2-1q7bG_,
.path-92Hmty {
	stroke:var(--hover-color) !important;
}
.wrapper-2NJDcI {
	background-color:var(--main-color-faded) !important;
	color:#fff;
}

/*3.p. Typing Indicators*/
.ellipsis-19qdx6 .spinnerItem-2HfQC8 {
    background:var(--main-color) !important;
}

/*3.q. Tags (v2 FEATURE, REDACTED)
.message-1PNnaP[data-user-id*="254362351170617345"] .da-timestampCozy:before {
    content: "Aurora Dev";
    background:var(--main-color);
    color: #fff;
    border-radius: 4px;
    margin-right:5px;
    margin-left:2px;
    font-size: 12px;
    font-weight: 600;
    padding: 1px 4px;
    text-shadow: 0px 1px 5px #000;
}
#app-mount .da-image[style*="219363409097916416"],
.da-containerCozy[data-author-id*="219363409097916416"]{
    border-radius:0% !important;
}
.da-containerCozy[data-author-id*="219363409097916416"] .reactionBtn-2na4rd {
    border-radius:0px;
    border:2px solid rgba(255,255,255,0.9);
    background-size:170%;
    transform:scale(.7);
    margin-top:-1px;
    background-position:50%
}
.message-1PNnaP[data-user-id*="254362351170617345"] .da-username {
  color:var(--hover-color);
}
.message-1PNnaP[data-user-id*="213220786805145600"] .da-timestampCozy:before,
.message-1PNnaP[data-user-id*="261354004569653248"] .da-timestampCozy:before,
.message-1PNnaP[data-user-id*="252460828157018112"] .da-timestampCozy:before,
.message-1PNnaP[data-user-id*="348593749372174337"] .da-timestampCozy:before {
    content: "Aurora Bug Hunter";
    background:var(--main-color-faded);
    color: rgba(255,255,255,0.8);
    border-radius: 4px;
    margin:8px;
    font-size: 12px;
    padding: 1px 4px;
}
*/
/*============== END OF SECTION ============== */

/*4. Channels Area*/
/*4.a. Channels*/
.channels-Ie2l6A:hover {
	width:320px;
}
.channels-Ie2l6A {
    transition:.3s width ease;
}
.channel-2QD9_O {
    padding-right:5px;
}
.contentSelectedText-3wUhMi,
body #app-mount .channel-2QD9_O.selected-1HYmZZ a {
	background: var(--main-color)
}
.da-contentHoveredText,
.channel-2QD9_O:hover a,
.contentConnectedVoice-qL-YrL:active,
.contentHoveredText-2D9B-x,
.contentHoveredVoice-3p_NEO:active,
.contentSelectedVoice-1WDIBM:active {
	background: var(--main-color-faded);
	transition: 100ms all linear;
}
#app-mount .wrapper-1ucjTd.modeSelected-1zApJ_ .content-3at_AU {
    background:var(--main-color) !important;
}
.wrapper-1ucjTd .content-3at_AU {
	transition: 100ms background linear;
}
.wrapper-1ucjTd:hover .content-3at_AU {
    background:var(--main-color-faded) !important;
}
.wrapper-1ucjTd.modeSelected-1zApJ_ .content-3at_AU .icon-1_QxNX {
    color:#fff;
}
.total-3tKGEB:after {
    display:none;
}
.total-3tKGEB {
    background:rgba(0,0,0,0.25);
    width:50%;
}
.users-i_3-kL {
    background:rgba(0,0,0,0.5);
    width:50%;
}
.wrapper-pZmgj4 {
    border-radius:5px;
}

/*4.b. Account Deatils Container*/
.container-2Thooq {background:transparent !important;}
.accountDetails-3k9g4n .username {
	font-family:'satisfy';
	font-weight:800 !important;
	color:var(--hover-color);
}
@keyframes spin {
    100% {
        transform:rotate(360deg);
    }
}
.button-2b6hmh:hover .buttonInner-LmnaN_ {
    animation:4s spin linear infinite;
}
.accountDetails-3k9g4n {text-align: center;}
.accountDetails-3k9g4n .username {max-width:unset !important;}
.da-accountDetails .username {
  font-size: 13px;
  height: 18px;
  line-height: 18px;
  font-weight:500;
}
.container-2Thooq .avatar-3JE4B3 {
  transition:250ms all linear;
}
.da-channels:hover .container-2Thooq .avatar-3JE4B3 {
  transform:scale(1.1);
}
.container-2Thooq .button-2b6hmh {
    transition:250ms ease all;
    border-radius:var(--media-roundness);
}
.container-2Thooq .button-2b6hmh:hover {
    background-color:rgba(255,255,255,0.1);
}
.container-2Thooq .button-2b6hmh:active {
    background-color:var(--main-color-faded);
}
.container-2Thooq .avatar-3JE4B3:hover .da-online:after {
    content:'Online';
    position:absolute;
    color:#dcddde;
    background:var(--main-color);
    border-radius:5px;
    animation: fadebottom 150ms;
    padding:8px 12px;
    font-size:14px;
    bottom:38px;
    left:-9px;
    font-weight:500;
    box-shadow:0px 0px 20px rgba(0, 0, 0, 0.5);
}
.container-2Thooq .avatar-3JE4B3:hover .da-idle:after {
    content:'Idle';
    position:absolute;
    color:#dcddde;
    background:var(--main-color);
    border-radius:5px;
    animation: fadebottom 150ms;
    padding:8px 12px;
    font-size:14px;
    bottom:38px;
    left:-9px;
    font-weight:500;
    box-shadow:0px 0px 20px rgba(0, 0, 0, 0.5);
}
.container-2Thooq .avatar-3JE4B3:hover .da-dnd:after {
    content:'DnD';
    position:absolute;
    color:#dcddde;
    background:var(--main-color);
    border-radius:5px;
    animation: fadebottom 150ms;
    padding:8px 12px;
    font-size:14px;
    bottom:38px;
    left:-9px;
    font-weight:500;
    box-shadow:0px 0px 20px rgba(0, 0, 0, 0.5);
}
.container-2Thooq .avatar-3JE4B3:hover .da-invisible:after {
    content:'Invisible';
    position:absolute;
    color:#dcddde;
    background:var(--main-color);
    border-radius:5px;
    animation: fadetop 150ms;
    padding:8px 12px;
    font-size:14px;
    bottom:38px;
    left:-9px;
    font-weight:500;
    box-shadow:0px 0px 20px rgba(0, 0, 0, 0.5);
}
.container-2Thooq .avatar-3JE4B3:hover {
    opacity:1;
}
.container-2Thooq .avatar-3JE4B3 {
  transition:250ms all linear;
}
.da-channels:hover .container-2Thooq .avatar-3JE4B3 {
  transform:scale(1.1);
}
.container-2Thooq .button-2b6hmh {
    transition:250ms ease all;
    border-radius:var(--media-roundness);
}
.container-2Thooq .button-2b6hmh:hover {
    background-color:rgba(255,255,255,0.1);
}
.container-2Thooq .button-2b6hmh:active {
    background-color:var(--main-color-faded);
}

/*4.c. Top Header*/
.header-2o-2hj {
	box-shadow:none !important; 
	border-radius:5px !important;
}
.bannerImage-1jOskm {
  -webkit-mask: linear-gradient(black, transparent 100%);
  transition:.3s width ease;
}
.da-channels:hover .bannerImage-1jOskm {
  width:320px !important;
}

/*4.d. Transparency*/
.container-PNkimc {
	background:transparent !important;
}
.vertical-V37hAW .channels-Ie2l6A {
	overflow: hidden !important;
	border-radius: 0 6px 6px 0 !important;
	margin-right: 25px;
	background: var(--backdropblurred);
	background-size:cover !important;
	background-position: center;
	background-attachment: fixed;
}

/*4.e. Private Channels Icon*/
[style*="/assets/f046e2247d730629309457e902d5c5b3.svg"]:after {
    content: "";
    position: absolute;
    width: 100%;
    height: 100%;
    background: var(--main-color) !important;
    -webkit-mask: url('data:image/svg+xml; utf8, <svg xmlns:xlink="http://www.w3.org/1999/xlink" xmlns="http://www.w3.org/2000/svg" viewBox="-295.5 374 45 45" version="1.1"><path d="M-273,409.5L-273,409.5c-4.1,0-6.8-0.6-7.9-1.7c-0.5-0.6-0.6-1.1-0.6-1.3c0-0.7,0.1-2.9,0.6-3.8c0.1-0.3,0.5-1,4.5-2.4c-1.6-1.4-2.6-4-2.6-7.1c0-4.2,2.3-7,5.9-7.1l0.1,0c3.6,0.1,5.9,2.8,5.9,7.1c0,3.1-1,5.7-2.6,7.1c4,1.4,4.4,2.1,4.5,2.4c0.4,0.9,0.5,3.1,0.6,3.8c0,0.2,0,0.7-0.6,1.3C-266.3,408.9-268.9,409.5-273,409.5z M-273,407.5L-273,407.5c5.1,0,6.2-0.9,6.4-1.1c-0.1-1.1-0.2-2.3-0.3-2.7c-0.6-0.4-2.9-1.3-4.8-1.9l-0.7-0.2l-0.1-2l0.7-0.3c1.7-0.6,2.8-3.1,2.8-6.1c0-3.1-1.5-5-3.9-5.1c-2.5,0-4,2-4,5.1c0,3,1.1,5.5,2.8,6.1l0.7,0.3l-0.1,2l-0.7,0.2c-1.9,0.6-4.2,1.5-4.8,1.9c-0.1,0.4-0.3,1.6-0.3,2.7C-279.2,406.6-278,407.5-273,407.5z"/><g opacity="0.7"><path class="st0" d="M-257,402.8c0-0.7-0.1-2.9-0.6-3.8c-0.1-0.3-0.5-1-4.5-2.4c1.6-1.4,2.6-4,2.6-7.1c0-4.2-2.3-7-5.9-7.1l-0.1,0c-1.9,0-3.5,0.8-4.5,2.2c0.6,0.3,1.2,0.6,1.8,1c0.7-0.8,1.6-1.3,2.8-1.3c2.4,0,3.9,2,3.9,5.1c0,3-1.1,5.5-2.8,6.1l-0.7,0.3l0.1,2l0.7,0.2c1.9,0.6,4.3,1.5,4.8,1.9c0.1,0.4,0.3,1.6,0.3,2.7c-0.2,0.2-1,0.8-3.8,1c0.1,0.6,0.2,1.2,0.2,2c2.5-0.2,4.2-0.8,5-1.6C-257,403.5-257,403-257,402.8z"/><path d="M-287,402.7c0.1-1.1,0.2-2.3,0.3-2.7c0.6-0.4,2.9-1.3,4.8-1.9l0.7-0.2l0.1-2l-0.7-0.3c-1.6-0.6-2.8-3.1-2.8-6.1c0-3.1,1.5-5,4-5.1c1.2,0,2.1,0.5,2.8,1.3c0.5-0.4,1.1-0.8,1.8-1c-1-1.4-2.6-2.2-4.5-2.2l-0.1,0c-3.6,0-5.9,2.8-5.9,7.1c0,3.1,1,5.7,2.6,7.1c-4,1.4-4.4,2.1-4.5,2.4c-0.4,0.9-0.5,3.1-0.6,3.8c0,0.2,0,0.7,0.6,1.3c0.8,0.9,2.5,1.4,5.1,1.6c0-0.7,0.1-1.4,0.2-2C-286,403.5-286.8,402.9-287,402.7z"/></g></svg>') center/cover no-repeat;
}
[style*="/assets/f046e2247d730629309457e902d5c5b3.svg"] {
    background: rgba(0,0,0,0.5) !important;
}
.da-privateChannels .da-channel .da-image,
.da-privateChannels .da-channel .da-avatar {
    box-shadow:none !important;
}
.da-image[style*="/assets/6debd47ed13483642cf09e832ed0bc1b.png"] {
    background:var(--main-color) !important;
    -webkit-mask:url(data:image/png;base64,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) center/cover no-repeat !important;
}

/*4.f. Channel Notice*/
.channelNotices-41mJbj .channelNotice-1-XFjC.invite-OjTXrW {
    background: transparent url(data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxMTQiIGhlaWdodD0iNTQiIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIj4gIDxkZWZzPiAgICA8cGF0aCBpZD0iYSIgZD0iTTAgMi44Nzk5NDczQzQuNTQ3MzIyOTUgNi40MjgwNDk5NCAxMC45MzEwMTExIDguNjM1MiAxOC4wMDAyIDguNjM1MmM3LjA2ODg5MTMgMCAxMy40NTI1OTQ5LTIuMjA2ODA1OTcgMTcuOTk5OC01Ljc1NDY2NjUyVi42MzUySDB2Mi4yNDQ3NDczeiIvPiAgICA8cGF0aCBpZD0iYyIgZD0iTTAgMy4yNjQ3NjA0NkM0LjU0NzMyMjk1IDguNDI1MTIwOTYgMTAuOTMxMDExMSAxMS42MzUyIDE4LjAwMDIgMTEuNjM1MmM3LjA2ODg5MTMgMCAxMy40NTI1OTQ5LTMuMjA5NTc4NiAxNy45OTk4LTguMzY5NTg3VjBIMHYzLjI2NDc2MDQ2eiIvPiAgPC9kZWZzPiAgPGcgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj4gICAgPHBhdGggZmlsbD0iIzQyNDU0OSIgZD0iTTg2Ljk4NjggMjYuOTk5OWMwIDEzLjgwNy0xMS4xOTMgMjUtMjUgMjUtMTAuMzUyIDAtMTkuMjM0LTYuMjkyLTIzLjAzMi0xNS4yNi0xLjI2Ny0yLjk5My0xLjk2OC02LjI4NS0xLjk2OC05Ljc0IDAtMS4xNzMuMDgxLTIuMzI2LjIzNy0zLjQ1NiAxLjY4My0xMi4xNzIgMTIuMTI5LTIxLjU0NCAyNC43NjMtMjEuNTQ0IDEzLjgwNyAwIDI1IDExLjE5MyAyNSAyNSIvPiAgICA8cGF0aCBmaWxsPSIjQUJBQ0FFIiBkPSJNNjEuOTg2OCAzOC4yNTIyYy03LjE1IDAtMTMtNS44NS0xMy0xM3YtNGMwLTcuMTUgNS44NS0xMyAxMy0xM3MxMyA1Ljg1IDEzIDEzdjRjMCA3LjE1LTUuODUgMTMtMTMgMTMiLz4gICAgPHBhdGggc3Ryb2tlPSIjMUUxRjIxIiBzdHJva2Utd2lkdGg9IjIiIGQ9Ik02MS45ODY4IDM4LjI1MjJjLTcuMTUgMC0xMy01Ljg1LTEzLTEzdi00YzAtNy4xNSA1Ljg1LTEzIDEzLTEzczEzIDUuODUgMTMgMTN2NGMwIDcuMTUtNS44NSAxMy0xMyAxM3oiIHN0cm9rZS1saW5lY2FwPSJyb3VuZCIgc3Ryb2tlLWxpbmVqb2luPSJyb3VuZCIvPiAgICA8ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg0NCA0Mi4zNjUpIj4gICAgICA8bWFzayBpZD0iYiIgZmlsbD0iI2ZmZiI+ICAgICAgICA8dXNlIHhsaW5rOmhyZWY9IiNhIi8+ICAgICAgPC9tYXNrPiAgICAgIDxwYXRoIGZpbGw9IiNBQkFDQUUiIGQ9Ik0wIDEzLjYzNTJWOS45MjA5MTQzQzAgNC43OTI0MTQzIDQuNDc3LjYzNTIgMTAgLjYzNTJoMTZjNS41MjMgMCAxMCA0LjE1NzIxNDMgMTAgOS4yODU3MTQzVjEzLjYzNTJIMHoiIG1hc2s9InVybCgjYikiLz4gICAgPC9nPiAgICA8ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg0MyA0MC4zNjUpIj4gICAgICA8bWFzayBpZD0iZCIgZmlsbD0iI2ZmZiI+ICAgICAgICA8dXNlIHhsaW5rOmhyZWY9IiNjIi8+ICAgICAgPC9tYXNrPiAgICAgIDxwYXRoIHN0cm9rZT0iIzFFMUYyMSIgc3Ryb2tlLXdpZHRoPSIyIiBkPSJNLjk4NjggMTV2LTMuODE4NTE0M2MwLTUuMjcyNDEzNiA0LjQ3Ny05LjU0NjI4NTcgMTAtOS41NDYyODU3aDE2YzUuNTIzIDAgMTAgNC4yNzM4NzIxIDEwIDkuNTQ2Mjg1N1YxNWgtMzZ6IiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIG1hc2s9InVybCgjZCkiLz4gICAgPC9nPiAgICA8cGF0aCBzdHJva2U9IiMxRTFGMjEiIHN0cm9rZS13aWR0aD0iMiIgZD0iTTM3LjUyODEgMzIuMTk4OWMtLjM1NS0xLjY3Ny0uNTQxLTMuNDE2LS41NDEtNS4xOTkgMC0xLjE3My4wOC0yLjMyNi4yMzctMy40NTYgMS42ODMtMTIuMTcyIDEyLjEyOC0yMS41NDQgMjQuNzYzLTIxLjU0NCAxMy44MDcgMCAyNSAxMS4xOTMgMjUgMjVzLTExLjE5MyAyNS0yNSAyNWMtOC43NDUgMC0xNi40NDEtNC40OS0yMC45MDktMTEuMjltLTIuMTIzLTMuOTcwMWMtLjEzLS4zMDYtLjI1NC0uNjE2LS4zNzEtLjkyOCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIi8+ICAgIDxwYXRoIHN0cm9rZT0iI0M1RDNGRiIgZD0iTTI0LjU2MDIgMzcuNjIzOWwtLjgzMy44MzNtLTMuMzMzNiAzLjMzMzdsLS44MzMuODMzbTQuOTk5Ni4wMDAzbC0uODMzLS44MzNtLTMuMzMzNi0zLjMzMzZsLS44MzMtLjgzMyIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIi8+ICAgIDxwYXRoIHN0cm9rZT0iIzcxODdERCIgZD0iTTEwNS41Nzc0IDIzLjYyOWMwIDEuMzgxLTEuMTE5IDIuNS0yLjUgMi41cy0yLjUtMS4xMTktMi41LTIuNSAxLjExOS0yLjUgMi41LTIuNSAyLjUgMS4xMTkgMi41IDIuNXoiIHN0cm9rZS1saW5lY2FwPSJyb3VuZCIgc3Ryb2tlLWxpbmVqb2luPSJyb3VuZCIvPiAgICA8cGF0aCBzdHJva2U9IiNGNEQ4NjIiIGQ9Ik0xNS45NDU0IDIzLjIwNmMwIDEuMTA1LS44OTUgMi0yIDJzLTItLjg5NS0yLTIgLjg5NS0yIDItMiAyIC44OTUgMiAyeiIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIi8+ICAgIDxwYXRoIHN0cm9rZT0iIzQzQjU4MSIgZD0iTTQgMzAuNTcyNnY1bTIuNS0yLjVoLTUiIHN0cm9rZS1saW5lY2FwPSJyb3VuZCIgc3Ryb2tlLWxpbmVqb2luPSJyb3VuZCIvPiAgICA8cGF0aCBzdHJva2U9IiNGNEQ4NjIiIGQ9Ik0xMTAuMDc3NCAxMC41ODd2NG0yLTJoLTQiIHN0cm9rZS1saW5lY2FwPSJyb3VuZCIgc3Ryb2tlLWxpbmVqb2luPSJyb3VuZCIvPiAgICA8cGF0aCBmaWxsPSIjNDNCNTgxIiBkPSJNODYuOTg2OCAxMS45OTk5YzAgNS41MjMtNC40NzcgMTAtMTAgMTBzLTEwLTQuNDc3LTEwLTEwIDQuNDc3LTEwIDEwLTEwIDEwIDQuNDc3IDEwIDEwIi8+ICAgIDxwYXRoIHN0cm9rZT0iIzFFMUYyMSIgc3Ryb2tlLXdpZHRoPSIyIiBkPSJNNjYuOTg2OCAxMS45OTk5YzAtMS4zODEuMjgtMi42OTYuNzg2LTMuODkyIDEuNTE4LTMuNTkgNS4wNzItNi4xMDggOS4yMTQtNi4xMDggNS41MjMgMCAxMCA0LjQ3NyAxMCAxMHMtNC40NzcgMTAtMTAgMTBjLTQuMDcgMC03LjU3Mi0yLjQzMS05LjEzMy01LjkyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiLz4gICAgPHBhdGggZmlsbD0iI0ZGRiIgZD0iTTc4LjQ4NjggMTAuNDk5OXYtM2MwLS4yNzYtLjIyNC0uNS0uNS0uNWgtMmMtLjI3NiAwLS41LjIyNC0uNS41djNoLTNjLS4yNzYgMC0uNS4yMjQtLjUuNXYyYzAgLjI3Ni4yMjQuNS41LjVoM3YzYzAgLjI3Ni4yMjQuNS41LjVoMmMuMjc2IDAgLjUtLjIyNC41LS41di0zaDNjLjI3NiAwIC41LS4yMjQuNS0uNXYtMmMwLS4yNzYtLjIyNC0uNS0uNS0uNWgtM3oiLz4gICAgPHBhdGggZD0iTTAgMGgxMTR2NTRIMHoiLz4gIDwvZz48L3N2Zz4=) no-repeat center 20px;
}
.channelNotices-41mJbj .channelNotice-1-XFjC {
    box-shadow: none;
}
.channelNotices-41mJbj .channelNotice-1-XFjC .message-3SOT5P .btn-11C5_u {
   background-color: var(--hover-color) !important;
}

/*4.g. Categories*/
@keyframes category {
	0% {
	opacity: 0;
	transform: translateY(-32%);
}
	100% {
		opacity: 1;
		transform:none;
	}
}
.wrapperConnectedText-3NUF2g,
.wrapperConnectedVoice-2mvQJY,
.wrapperDefaultText-2IWcE8,
.wrapperDefaultVoice-1yvceo,
.wrapperHoveredText-2geN_M,
.wrapperHoveredVoice-3ItgyI,
.wrapperLockedText-wfOnM5,
.wrapperLockedVoice-3QrBs-,
.wrapperMutedText-1YBpvv,
.wrapperMutedVoice-10gPcW,
.wrapperSelectedText-3dSUjC,
.wrapperSelectedVoice-xzxa2u,
.wrapperUnreadText-2zuiuD,
.wrapperUnreadVoice-23GIYe {
	animation:250ms category ease;
}
.iconCollapsed-3hFp_8,
.iconDefault-3Gr8d2,
.iconHovered-2L3-fB,
.iconHoveredCollapsed-3caIIZ,
.iconMuted-1HVBGH,
.iconUnread-2eGkvX {
	transition:200ms all linear;
}

/*============== END OF SECTION ============== */

/*5. Guilds*/
/*5.a. Wrapper*/
.da-guild,
.guild-1EfMGQ.folder,
.friendsOnline-_wi_fM,
.da-guildsError {
	margin-left:10px;
}
.friendsOnline-2JkivW {
    margin-left:0px;
}
.container-1aNBdK {
    margin-left:10px;
}
#app-mount .guildsWrapper-5TJh6A.foldercontent {
	border-radius:0px;
}
.guildSeparator-1X4GQ1:after {
	display:none !important;
}
.da-guildsWrapper,
.guildsWrapper-5TJh6A.foldercontent {
	background: var(--backdropblurred);
	width:90px;
	background-size:cover !important;
	background-position: center;
	background-attachment: fixed;
}
.guildsWrapper-5TJh6A.foldercontent .da-guildIcon {
    border-radius:var(--media-roundness) !important;
}
.da-guildsWrapper .scrollerWrap-2lJEkd .scroller-2FKFPG::-webkit-scrollbar,
.guildsWrapper-5TJh6A.foldercontent .scrollerWrap-2lJEkd .scroller-2FKFPG::-webkit-scrollbar,
.guildsWrapper-5TJh6A.foldercontent .scroller-wrap .scroller::-webkit-scrollbar {
	display:none;
}

.acronym-2mOFsV {
    transition:250ms ease background;
    background:rgba(0,0,0,0.5) !important;
}
.acronym-2mOFsV:hover {
    background:var(--main-color) !important;
}
.listItem-2P_4kh {
    margin-left:10px;
}
.pill-31IEus {
    width:30px;
    margin-left:-10px;
}
.item-2hkk8m {
    margin-left:6px;
    border-radius:50px;
    width:8px !important;
    background:var(--main-color);
}
.guildSeparator-3s64Iy {
    display:none;
}
.homeIcon-tEMBK1 path {
    display:none;
}
.button-OhfaWu {
    background:transparent !important;
}
.listItem-2P_4kh:first-child .wrapper-sa6paO {
    display:none;
}
.circleIconButton-jET_ig {
    margin:0 !important;
}
/*5.b. Add/Create Guilds Button*/
.guildsAdd-21_IdK {
	background:rgba(0,0,0,0.5) !important;
	border:none;
}

/*5.c. Unread and Selected Indicators*/
.unread-qLkInr:before {
  background:var(--hover-color) !important;
}
.guildsWrapper-5TJh6A .guilds-1q_RqH .guild-1EfMGQ.unread-qLkInr:before {
  box-shadow: 0 0 15px var(--hover-color);
  transition: all .2s ease;
}
.guildsWrapper-5TJh6A .guilds-1q_RqH .guild-1EfMGQ.selected-ML3OIq:before {
  box-shadow:0 0 12px black;
}
.guildsWrapper-5TJh6A .guilds-1q_RqH .guild-1EfMGQ.unread-qLkInr:hover:before,
.guildsWrapper-5TJh6A .guilds-1q_RqH .guild-1EfMGQ.selected-ML3OIq:before {
  border-radius: 20px;
  height: 40px;
  margin-top: -20px;
}

.guild-1EfMGQ.selected-ML3OIq:before,
.guild-1EfMGQ.unread-qLkInr:before {
    border-radius:5px !important;
    width:8px !important;
}
.guild-1EfMGQ:first-child.selected-ML3OIq:before {
    display:none !important;
}
.selected-ML3OIq:before {
	background:var(--main-color) !important;
}

/*5.d. Home Icon*/
.wrapper-232cHJ {
	background:var(--main-color) !important;
}
.homeIcon-1FoKUJ defs,
.homeIcon-1FoKUJ g {
	display: none;
}
.guildsWrapper-5TJh6A .guilds-1q_RqH>.guild-1EfMGQ:first-child .guildInner-3DSoA4 {
  border-radius: 0px !important;
}
.homeIcon-1FoKUJ {
	background: var(--main-color);
	-webkit-mask: url('data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmZmZmIiBoZWlnaHQ9IjQ4IiB2aWV3Qm94PSIwIDAgMjQgMjQiIHdpZHRoPSI0OCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj48cGF0aCBkPSJNMCAwaDI0djI0SDB6IiBmaWxsPSJub25lIi8+PHBhdGggZD0iTTIxIDZoLTJ2OUg2djJjMCAuNTUuNDUgMSAxIDFoMTFsNCA0VjdjMC0uNTUtLjQ1LTEtMS0xem0tNCA2VjNjMC0uNTUtLjQ1LTEtMS0xSDNjLS41NSAwLTEgLjQ1LTEgMXYxNGw0LTRoMTBjLjU1IDAgMS0uNDUgMS0xeiIvPjwvc3ZnPg==');
	-webkit-mask-size: 30px;
	-webkit-mask-repeat: no-repeat;
	-webkit-mask-position: center;
	transition:250ms all ease;
}

/*5.e. Tooltips*/
.da-tooltip {
    background: var(--main-color) !important;
    box-shadow:0px 0px 20px rgba(0,0,0,0.5) !important;
}
@keyframes fadetop {
	0% {
		opacity: 0;
		transform: translateY(-50%);
	}
	100% {
		opacity: 0.9;
		transform:none;
	}
}
@keyframes faderight {
	0% {
		opacity: 0;
		transform: translateX(50%);
	}
	100% {
		opacity: 0.9;
		transform: none;
	}
}
@keyframes fadebottom {
	0% {
		opacity: 0;
		transform: translateY(50%);
	}100% {
		opacity: 0.9; 
		transform: none;
	}
}
@keyframes fadeleft {
	0% {
		opacity: 0;
		transform: translateX(-50%);
	}
	100% {
		opacity: 0.9;
		transform: none;
	}
}
.da-tooltip.da-tooltipTop, .bd-tooltip[x-placement^='top'] {animation: fadetop 150ms;}
.da-tooltips .da-tooltip.da-right, .bd-tooltip[x-placement^='right'] {animation: faderight 150ms;}
.da-tooltips .da-tooltip.da-bottom, .bd-tooltip[x-placement^='bottom'] {animation: fadebottom 150ms;}
.da-tooltips .da-tooltip.da-left, .bd-tooltip[x-placement^='left'] {animation: fadeleft 150ms;}
.da-tooltip.da-top {animation: fadetop 150ms;}
.da-tooltips .da-tooltip,
.bd-tooltip {
    background: var(--main-color) !important;
    box-shadow:0px 0px 20px rgba(0,0,0,0.5) !important;
}
.tooltipPointer-3ZfirK,
.bd-tooltipArrow {
	display: none;
}

/*5.a. Canary Wrapper*/
.container-2td-dC,
.container-1ETFDs,
.guild-1EfMGQ.folder {
	margin-left:10px;
}
/*.da-friendsOnline {
  margin-left:0px;
}*/
/*Canary Roundness*/
.wrapper-1Rf91z .wrapper-2lTRaf:hover,
.container-2td-dC.da-selected .wrapper-2lTRaf,
#app-mount .wrapper-1Rf91z.foldercontent .guildIcon-VlWW86:hover,
#app-mount .wrapper-1Rf91z.foldercontent .wrapper-2lTRaf:hover,
#app-mount .wrapper-1Rf91z .inner-1W0Bkn {
	border-radius:var(--guild-hovered-roundness) !important;
}
.wrapper-2lTRaf {
	border-radius:var(--media-roundness) !important;
	transition:350ms all ease;
}
.da-guildsError {
    border-color:var(--hover-color) !important;
    background:var(--main-color-faded) !important;
    color:var(--hover-color) !important;
}
.wrapper-2lTRaf {
  background:transparent !important;
}
#app-mount .wrapper-1Rf91z.foldercontent {
	border-radius:0px;
}
.guildSeparator-3s64Iy:after {
	display:none !important;
}
.wrapper-1Rf91z,
.wrapper-1Rf91z.foldercontent {
	background:var(--backdropblurred);
	background-size:cover !important;
	background-position: center;
	background-attachment: fixed;
}
.wrapper-1Rf91z.foldercontent .guildIcon-VlWW86 {
    border-radius:var(--media-roundness) !important;
}
.wrapper-1Rf91z .scrollerWrap-2lJEkd .scroller-2FKFPG::-webkit-scrollbar,
.wrapper-1Rf91z.foldercontent .scrollerWrap-2lJEkd .scroller-2FKFPG::-webkit-scrollbar,
.wrapper-1Rf91z.foldercontent .scroller-wrap .scroller::-webkit-scrollbar {
	display:none;
}
.container-2td-dC .wrapper-2lTRaf:hover,
.container-2td-dC.da-selected .wrapper-2lTRaf {
    background-color:rgba(0,0,0,0.5) !important;
    box-shadow:0 0 15px rgba(0,0,0,0.5) !important;
}

/*5.b. Canary Add Guilds Button*/
.circleIconButton-jET_ig {
	background:rgba(0,0,0,0.5) !important;
	border:none;
}

/*5.c. Canary Unread Indicators*/
.unread-2OHH1w:before {
  background:var(--hover-color) !important;
}
.wrapper-1Rf91z .unread-2OHH1w:before {
  box-shadow: 0 0 15px var(--hover-color);
  transition: all .2s ease;
}
.wrapper-1Rf91z .selected-nT-gM3:before {
  box-shadow:0 0 12px black;
}
.wrapper-1Rf91z .selected-nT-gM3:before,
.wrapper-1Rf91z .unread-2OHH1w:hover:before {
  border-radius: 20px;
  height: 40px;
  margin-top: -20px;
}

.selected-nT-gM3:before,
.unread-2OHH1w:before {
    border-radius:5px !important;
    width:8px !important;
}
.guild-1EfMGQ:first-child.selected-ML3OIq:before {
    display:none !important;
}
.selected-nT-gM3:before {
	background:var(--main-color) !important;
}

/*5.d. Canary HomeIcon*/
.wrapper-232cHJ {
	background:var(--main-color) !important;
}
.homeIcon-tEMBK1 defs,
.homeIcon-tEMBK1 g {
	display: none;
}
#app-mount .wrapper-1Rf91z .guilds-1q_RqH>.container-2td-dC:first-child .wrapper-2lTRaf {
  border-radius: 0px !important;
  background:transparent !important;
  box-shadow:none !important;
}
.homeIcon-tEMBK1 {
	background: var(--main-color);
	-webkit-mask: url('data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmZmZmIiBoZWlnaHQ9IjQ4IiB2aWV3Qm94PSIwIDAgMjQgMjQiIHdpZHRoPSI0OCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj48cGF0aCBkPSJNMCAwaDI0djI0SDB6IiBmaWxsPSJub25lIi8+PHBhdGggZD0iTTIxIDZoLTJ2OUg2djJjMCAuNTUuNDUgMSAxIDFoMTFsNCA0VjdjMC0uNTUtLjQ1LTEtMS0xem0tNCA2VjNjMC0uNTUtLjQ1LTEtMS0xSDNjLS41NSAwLTEgLjQ1LTEgMXYxNGw0LTRoMTBjLjU1IDAgMS0uNDUgMS0xeiIvPjwvc3ZnPg==');
	-webkit-mask-size: 30px;
	-webkit-mask-repeat: no-repeat;
	-webkit-mask-position: center;
	transition:250ms all ease;
}

/*============== END OF SECTION ============== */

/*6. Members List*/
/*6.a. Transparency*/
.members-1998pB {
	background:transparent !important;
}

/*6.b. Selected and Hovered Content*/
.members-1998pB .content-OzHfo4 {
	transition: 100ms all linear;
}
.member-3W1lQa:hover .content-OzHfo4,
.popout-open .content-OzHfo4 {
	background:rgba(0,0,0,0.5) !important;
}
.mulitplePlaceholderUsername-pogq9I,
.placeholderUsername-2B_OA9,
.placeholderAvatar-damqh6 {
    background:rgba(0,0,0,0.75);
}
.memberGroupsPlaceholder-3mwPub {
  margin-left:55px;
  margin-top:-5px;
  background:var(--main-color);
}
.membersGroup-v9BXpm {
  color: var(--hover-color) !important;
  border-bottom: 3px solid;
  border-image: linear-gradient(90deg, transparent, var(--gradient1), var(--gradient2), transparent);
  border-image-slice: 1;
  padding: 19px 16px 6px 16px;
  margin: 4px 0px 10px 15px;
  text-align: center;
}

/*6.c. User Status*/
.status-oxiHuE:not(.status-3fQvEa).online-2S838R {
	border-color: var(--online) !important;
}
.status-oxiHuE:not(.status-3fQvEa).idle-3DEnRT {
	border-color: var(--idle) !important;
}
.status-oxiHuE:not(.status-3fQvEa).dnd-1_xrcq {
	border-color: var(--dnd) !important;
}
.status-oxiHuE:not(.status-3fQvEa).streaming-2_dnHe {
	border-color: var(--streaming) !important;
}
.status-oxiHuE:not(.status-3fQvEa).offline-3qoTek {
	border-color: var(--offline) !important;
}
.status-oxiHuE:not(.status-3fQvEa).invisible-1kp8Z0 {
	border-color: var(--invisible) !important;
}
.status-oxiHuE:not(.status-3fQvEa) {
  height: calc(100% - 1px);
  width: calc(100% - 1px);
  margin: 0;
  bottom:-2px;
  right: -2px;
  background: transparent;
  border:2px solid;
  box-shadow: none;
  pointer-events: none;
}
:root {
	--online: #43b581;
	--idle: #faa61a;
	--dnd: #f04747;
	--offline: #636b75;
	--invisible: #747f8d;
	--streaming: #643da7;
}
.mask-3OgeRz,
.image-33JSyf {
  -webkit-mask: none;
  mask: none;
}
.status-oxiHuE.typing-1KJk_j {
  background-color: rgba(0, 0, 0, .6) !important;
  height: calc(100% - 1px) !important;
  width: calc(100% - 1px) !important;
  left:-2px;
}
.status-oxiHuE.animate-iYrs3- {
    transition: none !important;
}
.status-oxiHuE.typing-1KJk_j .pulsingEllipsisItem-32hhWL {
	border-radius:var(--media-roundness) !important;
}
.status-oxiHuE.typing-1KJk_j.online-2S838R.typing-1KJk_j .pulsingEllipsisItem-32hhWL {
	background-color: var(--online) !important;
}
.status-oxiHuE.typing-1KJk_j.idle-3DEnRT.typing-1KJk_j .pulsingEllipsisItem-32hhWL {
	background-color: var(--idle) !important;
}
.status-oxiHuE.typing-1KJk_j.dnd-1_xrcq.typing-1KJk_j .pulsingEllipsisItem-32hhWL {
	background-color: var(--dnd) !important;
}
.status-oxiHuE.typing-1KJk_j.streaming-2_dnHe.typing-1KJk_j .pulsingEllipsisItem-32hhWL {
	background-color: var(--streaming) !important;
}
.status-oxiHuE.typing-1KJk_j.offliasne-3qoTek.typing-1KJk_j .pulsingEllipsisItem-32hhWL {
	background-color: var(--offline) !important;
}
.status-oxiHuE.typing-1KJk_j.invisible-1kp8Z0.typing-1KJk_j .pulsingEllipsisItem-32hhWL {
	background-color: var(--invisible) !important;
}

/*============== END OF SECTION ============== */

/*7. Popouts and Dropdowns*/
/*7.a. Server Dropdown*/
.icon-2doZ3q {
	opacity:0;
}
.da-menu .da-item {
	height:33px !important;
}
.icon-2doZ3q:hover {
	opacity:1;
}
.menu-Sp6bN1 .item-1GzJrl {
	margin-left:-30px;
}
.menu-Sp6bN1 .item-1GzJrl:hover {
	margin:0;
}
.menu-Sp6bN1.alt-3btY0e .item-1GzJrl {
	margin-left:0px;
}
.menu-Sp6bN1 {
	background:var(--backdrop) !important;
	background-repeat:no-repeat;
	background-size:cover !important;
}
.popoutBottom-1YbShG[style*="z-index: 1001; overflow: hidden; visibility: visible"]{
    left:234px!important;
}
.item-1GzJrl {
	transition:75ms all linear;
}
.item-1GzJrl:hover {
	background:rgba(0,0,0,0.5) !important; 
	border-radius:5px !important;
}
.separator-2zcjq8 {
	display:none !important;
}
 .item-1GzJrl.invite-271nFU {
	 color:var(--hover-color) !important;
}
.item-1GzJrl.invite-271nFU .icon-2doZ3q {
  background-image: none !important;
  -webkit-mask-repeat: no-repeat;
  -webkit-mask-position: right;
  -webkit-mask: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxOCIgaGVpZ2h0PSIxOCIgdmlld0JveD0iMCAwIDE2IDE2Ij4gIDxwYXRoIGZpbGw9IiM3Mjg5REEiIGQ9Ik0xMC41LDcgQzEyLjE4MzgwOTUsNyAxNCw1LjI4NjY2NjY3IDE0LDMuNTQ1NDU0NTUgQzE0LDEuODA0MjQyNDIgMTIuMTgzODA5NSwwIDEwLjUsMCBDOC44MTYxOTA0OCwwIDcsMS44MDQyNDI0MiA3LDMuNTQ1NDU0NTUgQzcsNS4yODY2NjY2NyA4LjgxNjE5MDQ4LDcgMTAuNSw3IFogTTMsNiBMMyw0IEwyLDQgTDIsNiBMMCw2IEwwLDcgTDIsNyBMMiw5IEwzLDkgTDMsNyBMNSw3IEw1LDYgTDMsNiBaIE0xMC41LDggQzguNDY1NzE0MjksOCA1LDkuMzI4NDg0ODUgNSwxMS40MjQyNDI0IEw1LDEzIEwxNiwxMyBMMTYsMTEuNDI0MjQyNCBDMTYsOS4zMjg0ODQ4NSAxMi41MzQyODU3LDggMTAuNSw4IFoiIHRyYW5zZm9ybT0ibWF0cml4KC0xIDAgMCAxIDE2IDIpIi8+PC9zdmc+");
  background: var(--main-color) !important;
  color: var(--hover-color) !important;
}

/*7.b. Status Picker*/
@keyframes anim-status {
	from {
		transform: scale(0);
		opacity: 0;}
}
.item-1GzJrl .online-2S838R,
.item-1GzJrl .idle-3DEnRT,
.item-1GzJrl .dnd-1_xrcq,
.item-1GzJrl .invisible-1kp8Z0 {
    border:5px solid rgba(0,0,0,0.6) !important;
}
.alt-3btY0e .item-1GzJrl:nth-of-type(1){
	animation-delay: 0ms;
}
.alt-3btY0e .item-1GzJrl:first-of-type {
	padding-left: 0px !important;
}
.alt-3btY0e .item-1GzJrl:nth-of-type(3){
	animation-delay: 100ms;
}
.alt-3btY0e .item-1GzJrl:nth-of-type(4){
	animation-delay: 200ms;
}
.alt-3btY0e .item-1GzJrl:nth-of-type(5){
	animation-delay: 300ms;
}
.alt-3btY0e .da-item:hover {
	background:transparent !important;
}
.alt-3btY0e .statusIconText-3b4TkH > div {
	color:transparent;
}
.popoutTopLeft-b5Eb3O  {
	left:110px !important;
}
.alt-3btY0e .item-1GzJrl:first-of-type {
	padding-left: 0px !important;
}
.popoutTopLeft-b5Eb3O {
	margin-top:-22.5px;
}
.alt-3btY0e .helper-2c73HK {
	display:none;
}
.alt-3btY0e.menu-Sp6bN1:hover::before {
	pointer-events: initial;
}
body:active .alt-3btY0e.menu-Sp6bN1:not(:active) {
	opacity: 0;
	transition:150ms ease;
}
.alt-3btY0e .separator-2zcjq8  {
	border-bottom: 0px;
}
.alt-3btY0e.menu-Sp6bN1 {
    border-radius: 0 !important;
    width: 240px !important;
    bottom: 60px !important;
    top: initial !important;
    height: 70px !important;
    overflow:visible;
    cursor: initial;
    background:var(--backdrop) !important;
    background-position:center !important;
    background-size:cover !important;
}
.alt-3btY0e .item-1GzJrl {
    transition: all 200ms ease;
    color: transparent;
    pointer-events: auto;
    float: left;
    width: 55px;
    height: 70px;
    padding: 0 !important;
    left: 5px;
    bottom: 0;
    transform: none;
    position: relative;
    z-index:2;
    -webkit-backface-visibility:hidden;
    background: transparent !important;
    animation: anim-status 400ms cubic-bezier(.4,0,0,1) backwards;
}
.da-menu.da-alt {
    border:2px solid var(--main-color-faded);
    box-shadow:inset 0px 0px 0px 1000px rgba(0,0,0,0.5) !important;
}
.alt-3btY0e .item-1GzJrl .online-2S838R,
.alt-3btY0e .item-1GzJrl .idle-3DEnRT,
.alt-3btY0e .item-1GzJrl .dnd-1_xrcq,
.alt-3btY0e .item-1GzJrl .invisible-1kp8Z0 {
    margin-top:10px !important;
}
.alt-3btY0e .item-1GzJrl:nth-of-type(5) .status-oxiHuE {
  background-image: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz48c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkNhbHF1ZV8xIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB4PSIwcHgiIHk9IjBweCIgdmlld0JveD0iLTk0NyA1MjkgMjQgMjQiIHN0eWxlPSJlbmFibGUtYmFja2dyb3VuZDpuZXcgLTk0NyA1MjkgMjQgMjQ7IiB4bWw6c3BhY2U9InByZXNlcnZlIj48c3R5bGUgdHlwZT0idGV4dC9jc3MiPi5zdDB7ZmlsbDojRkZGRkZGO308L3N0eWxlPjxnPjxwYXRoIGNsYXNzPSJzdDAiIGQ9Ik0tOTM0LjEsNTQzLjZoLTEuOHYtMC45YzAtMC41LDAuMS0xLDAuMy0xLjRjMC4yLTAuNCwwLjYtMC45LDEuMi0xLjRjMC42LTAuNSwxLTEsMS4yLTEuM2MwLjItMC4zLDAuMy0wLjcsMC4zLTEuMWMwLTAuNi0wLjItMS4xLTAuNi0xLjRjLTAuNC0wLjMtMC45LTAuNS0xLjUtMC41Yy0xLjEsMC0xLjgsMC42LTIuMiwxLjhsLTEuNi0wLjdjMC4zLTAuOCwwLjgtMS41LDEuNS0yYzAuNy0wLjUsMS41LTAuOCwyLjQtMC44YzEuMSwwLDIsMC4zLDIuOCwxYzAuNywwLjcsMS4xLDEuNSwxLjEsMi42YzAsMC41LTAuMSwxLTAuNCwxLjVjLTAuMywwLjUtMC44LDEuMS0xLjUsMS43Yy0wLjcsMC43LTEuMSwxLjMtMS4xLDJWNTQzLjZ6IE0tOTMzLjgsNTQ2LjZjMCwwLjQtMC4xLDAuNi0wLjQsMC45Yy0wLjIsMC4yLTAuNSwwLjQtMC45LDAuNGMtMC4zLDAtMC42LTAuMS0wLjktMC40Yy0wLjItMC4yLTAuNC0wLjUtMC40LTAuOWMwLTAuNCwwLjEtMC43LDAuNC0wLjljMC4yLTAuMiwwLjUtMC40LDAuOS0wLjRjMC40LDAsMC43LDAuMSwwLjksMC40Qy05MzMuOSw1NDYtOTMzLjgsNTQ2LjMtOTMzLjgsNTQ2LjZ6Ii8+PC9nPjwvc3ZnPg==);
  background-repeat: no-repeat;
  background-position: 50%;
  background-size:60%;
  background-color:var(--invisible) !important;
}
.alt-3btY0e.menu-Sp6bN1 {
	box-shadow:inset 0px 0px 0px 1000px rgba(0,0,0,0.7);
}
.alt-3btY0e .item-1GzJrl:first-of-type {
	padding-left:0px !important;
	box-sizing: content-box !important;
}
.alt-3btY0e .item-1GzJrl .online-2S838R,.alt-3btY0e .item-1GzJrl .idle-3DEnRT,.alt-3btY0e .item-1GzJrl .dnd-1_xrcq,.alt-3btY0e .item-1GzJrl .invisible-1kp8Z0{
  position:absolute;
  width: 100%;
  height: 100%;
  top: 0;
  left: 0;
  border-radius: 50%;
  width: 40px !important;
  height: 40px !important;
  left:0px !important;
  margin-left: 7.50px !important;
  bottom: 0;
  margin-top: 15px;
  transition: all 200ms ease;
  margin-right: 0 !important;
}
.alt-3btY0e .item-1GzJrl:hover .online-2S838R,
.alt-3btY0e .item-1GzJrl:hover .idle-3DEnRT,
.alt-3btY0e .item-1GzJrl:hover .dnd-1_xrcq,
.alt-3btY0e .item-1GzJrl:hover .invisible-1kp8Z0 {
    color: transparent;
    opacity: 1;
    transform:scale(1.2);
    transition: all 200ms cubic-bezier(0,0,0,1);
    z-index: 2;
}
.alt-3btY0e .item-1GzJrl:active online-2S838R,
.alt-3btY0e .item-1GzJrl:active .idle-3DEnRT,
.alt-3btY0e .item-1GzJrl:active .dnd-1_xrcq,
.alt-3btY0e .item-1GzJrl:active .invisible-1kp8Z0 {
    -ms-transform: scale(0.7);
    transform: scale(0.7);
    transition: all 100ms cubic-bezier(0,0,0,1),box-shadow 0ms;
    opacity: 1;
    box-shadow: 0 -10px 20px rgba(0,0,0,.15) inset,0 1px 1px rgba(255,255,255,.05) inset;
}
.alt-3btY0e:active {
	opacity: 0; 
	transition: all 100ms ease 100ms;
}
.alt-3btY0e .item-1GzJrl:nth-of-type(1) .online-2S838R {
    background-image: url(data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjRkZGRkZGIiBoZWlnaHQ9IjI0IiB2aWV3Qm94PSIwIDAgMjQgMjQiIHdpZHRoPSIyNCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4gICAgPHBhdGggZD0iTTAgMGgyNHYyNEgweiIgZmlsbD0ibm9uZSIvPiAgICA8cGF0aCBkPSJNOSAxNi4yTDQuOCAxMmwtMS40IDEuNEw5IDE5IDIxIDdsLTEuNC0xLjRMOSAxNi4yeiIvPjwvc3ZnPg==);
    background-size: 60%;
    background-repeat: no-repeat;
    background-position: 50%;
    left: auto;
    background-color:var(--online) !important;
}
.alt-3btY0e .item-1GzJrl:nth-of-type(3) .idle-3DEnRT {
  background-image: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz48c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkNhbHF1ZV8xIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB4PSIwcHgiIHk9IjBweCIgdmlld0JveD0iLTk0NyA1MjkgMjQgMjQiIHN0eWxlPSJlbmFibGUtYmFja2dyb3VuZDpuZXcgLTk0NyA1MjkgMjQgMjQ7IiB4bWw6c3BhY2U9InByZXNlcnZlIj48c3R5bGUgdHlwZT0idGV4dC9jc3MiPi5zdDB7ZmlsbDojRkZGRkZGO308L3N0eWxlPjxwb2x5Z29uIGNsYXNzPSJzdDAiIHBvaW50cz0iLTkyOSw1NDQuNSAtOTMwLDU0NiAtOTM2LjIsNTQyLjIgLTkzNi4yLDUzNSAtOTM0LjQsNTM1IC05MzQuNCw1NDEuMiAiLz48L3N2Zz4=);
    background-size: 70%;
    background-repeat: no-repeat;
    background-position: 50%;
    background-color:var(--idle) !important;
}
.alt-3btY0e .item-1GzJrl:nth-of-type(4) .dnd-1_xrcq {
  background-image: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz48c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkNhbHF1ZV8xIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB4PSIwcHgiIHk9IjBweCIgdmlld0JveD0iLTk0NyA1MjkgMjQgMjQiIHN0eWxlPSJlbmFibGUtYmFja2dyb3VuZDpuZXcgLTk0NyA1MjkgMjQgMjQ7IiB4bWw6c3BhY2U9InByZXNlcnZlIj48c3R5bGUgdHlwZT0idGV4dC9jc3MiPi5zdDB7ZmlsbDojRkZGRkZGO308L3N0eWxlPjxyZWN0IHg9Ii05NDAuNCIgeT0iNTQwLjEiIGNsYXNzPSJzdDAiIHdpZHRoPSIxMC45IiBoZWlnaHQ9IjEuOCIvPjwvc3ZnPg==);
    background-size: 70%;
    background-repeat: no-repeat;
    background-position: 50%;
    background-color:var(--dnd) !important;
}

/*6.c. Context Menus*/
.container-3cGP6G {
	background:rgba(0,0,0,0.5) !important;
}
.item-1Yvehc.brand-3igrJY,
.item-1Yvehc.brand-3igrJY:hover {
	color:var(--hover-color) !important;
}
.itemSubMenu-1vN_Yn:hover {
	background: rgba(255,255,255,0.05) url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9Im5vIj8+PHN2ZyB3aWR0aD0iN3B4IiBoZWlnaHQ9IjEwcHgiIHZpZXdCb3g9IjAgMCA3IDEwIiB2ZXJzaW9uPSIxLjEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHhtbG5zOnNrZXRjaD0iaHR0cDovL3d3dy5ib2hlbWlhbmNvZGluZy5jb20vc2tldGNoL25zIj4gICAgICAgIDx0aXRsZT5pY29uLWFycm93PC90aXRsZT4gICAgPGRlc2M+Q3JlYXRlZCB3aXRoIFNrZXRjaC48L2Rlc2M+ICAgIDxkZWZzPjwvZGVmcz4gICAgPGcgaWQ9IkNvbnRleHQtTWVudXMiIHN0cm9rZT0ibm9uZSIgc3Ryb2tlLXdpZHRoPSIxIiBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiIHNrZXRjaDp0eXBlPSJNU1BhZ2UiPiAgICAgICAgPGcgaWQ9IkNvbnRleHQtTWVudXMtLS1MaWdodCIgc2tldGNoOnR5cGU9Ik1TQXJ0Ym9hcmRHcm91cCIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoLTU2My4wMDAwMDAsIC0xNzguMDAwMDAwKSIgZmlsbD0iIzlGQTZCMCI+ICAgICAgICAgICAgPGcgaWQ9IlVzZXItTWVudSIgc2tldGNoOnR5cGU9Ik1TTGF5ZXJHcm91cCIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDExLjAwMDAwMCwgOTUuMDAwMDAwKSI+ICAgICAgICAgICAgICAgIDxnIGlkPSJHcm91cC0xMyIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoMC45NjgwMDAsIDcxLjAwMDAwMCkiIHNrZXRjaDp0eXBlPSJNU1NoYXBlR3JvdXAiPiAgICAgICAgICAgICAgICAgICAgPHBhdGggZD0iTTE1MC4zMDQyMDcsMTUuNzA3MTA2OCBMMTU0LjI0MDIwNywxOS43MDcxMDY4IEMxNTQuNjI0NDgzLDIwLjA5NzYzMTEgMTU1LjI0NzUxNywyMC4wOTc2MzExIDE1NS42MzE3OTMsMTkuNzA3MTA2OCBMMTU5LjU2Nzc5MywxNS43MDcxMDY4IEMxNTkuOTUyMDY5LDE1LjMxNjU4MjUgMTU5Ljk1MjA2OSwxNC42ODM0MTc1IDE1OS41Njc3OTMsMTQuMjkyODkzMiBDMTU5LjE4MzUxNywxMy45MDIzNjg5IDE1OC41NjA0ODMsMTMuOTAyMzY4OSAxNTguMTc2MjA3LDE0LjI5Mjg5MzIgTDE1NC4yNDAyMDcsMTguMjkyODkzMiBMMTU1LjYzMTc5MywxOC4yOTI4OTMyIEwxNTEuNjk1NzkzLDE0LjI5Mjg5MzIgQzE1MS4zMTE1MTcsMTMuOTAyMzY4OSAxNTAuNjg4NDgzLDEzLjkwMjM2ODkgMTUwLjMwNDIwNywxNC4yOTI4OTMyIEMxNDkuOTE5OTMxLDE0LjY4MzQxNzUgMTQ5LjkxOTkzMSwxNS4zMTY1ODI1IDE1MC4zMDQyMDcsMTUuNzA3MTA2OCBMMTUwLjMwNDIwNywxNS43MDcxMDY4IFoiIGlkPSJpY29uLWFycm93IiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgxNTQuOTM2MDAwLCAxNy4wMDAwMDApIHJvdGF0ZSgtOTAuMDAwMDAwKSB0cmFuc2xhdGUoLTE1NC45MzYwMDAsIC0xNy4wMDAwMDApICI+PC9wYXRoPiAgICAgICAgICAgICAgICA8L2c+ICAgICAgICAgICAgPC9nPiAgICAgICAgPC9nPiAgICA8L2c+PC9zdmc+)150px 50% no-repeat;
}
.itemGroup-1tL0uz {
	border:none;
}
.da-contextMenu .da-item {
	transition:250ms all ease;
}
.da-contextMenu,
.contextMenu-HLZMGh {
	border-radius:2px !important;
	background:rgba(0,0,0,0.75) !important;
	padding:7px;
}
@keyframes context-open-new {
  0% {
    transform: scale(1, 0);
  }
}
.contextMenu-HLZMGh {
  animation: opacity 100ms ease, context-open-new 300ms cubic-bezier(0, 0, 0, 1);
  transform-origin: top;
}
.contextMenu-HLZMGh .item-1Yvehc:hover {
  background:var(--main-color-faded);
  border-radius:3px;
}
.contextMenu-HLZMGh .item-1Yvehc {
  margin: 0px;
  padding: 7px 15px;
}
/*6.d. User Popouts*/
.body-3iLsc4,
.footer-1fjuF6 {
    background:transparent !important;
}
.headerSpotify-zpWxgT {
    background:rgba(22,178,136,0.2);
}
.headerSpotify-zpWxgT .anchor-3Z-8Bb {
    color:#fff !important;
}
.quickMessage-2XpSaN,
.note-3kmerW textarea:focus,
.da-selectorSelected {
    background:rgba(0,0,0,0.6) !important;
    border:none;
}
.headerPlaying-j0WQBV {
    background:var(--main-color-faded) !important;
}
.headerStreaming-2FjmGz {
	background:rgba(89, 54, 149, 0.35) !important;
}
.da-userPopout {
    background-image:var(--backdrop) !important;
    box-shadow:inset 0px 0px 0px 1000px rgba(0,0,0,0.6), 0px 0px 10px black;
    background-size:cover !important;
    background-repeat:no-repeat;
}
.headerNormal-T_seeN {
    background:transparent !important;
}
.da-userPopout::before {
    content: '';
    display: block;
    position: absolute;
    right: 0;
    left: 0;
    bottom: 0;
    top: 0;
    z-index: 1 !important;
    background-image: url('data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz48IURPQ1RZUEUgc3ZnIFBVQkxJQyAiLS8vVzNDLy9EVEQgU1ZHIDEuMS8vRU4iICJodHRwOi8vd3d3LnczLm9yZy9HcmFwaGljcy9TVkcvMS4xL0RURC9zdmcxMS5kdGQiPjxzdmcgdmVyc2lvbj0iMS4xIiBpZD0iQ2FscXVlXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IiB2aWV3Qm94PSIwIDAgMjAwMCAyMDAwIiBlbmFibGUtYmFja2dyb3VuZD0ibmV3IDAgMCAyMDAwIDIwMDAiIHhtbDpzcGFjZT0icHJlc2VydmUiPjxnIG9wYWNpdHk9IjAuMSI+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTYzOC4zLDU4MGMtNS45LTUuOS0xNS40LTUuOS0yMS4yLDB2MGwtMjYsMjZsLTI2LTI2Yy01LjktNS45LTE1LjQtNS45LTIxLjIsMHMtNS45LDE1LjQsMCwyMS4ybDI2LDI2ICAgbC0yNiwyNmMtNS45LDUuOS01LjksMTUuNCwwLDIxLjJzMTUuNCw1LjksMjEuMiwwbDI2LTI2bDI2LDI2YzUuOSw1LjksMTUuNCw1LjksMjEuMiwwczUuOS0xNS40LDAtMjEuMmwtMjYtMjZsMjYtMjYgICBDNjQ0LjIsNTk1LjMsNjQ0LjIsNTg1LjgsNjM4LjMsNTgweiIvPjxwYXRoIGZpbGw9IiNGRkZGRkYiIGQ9Ik0xNDc5LjYsMTQzNy4yYy01LjktNS45LTE1LjQtNS45LTIxLjIsMGwwLDBsLTI2LDI2bC0yNi0yNmMtNS45LTUuOS0xNS40LTUuOS0yMS4yLDAgICBjLTUuOSw1LjktNS45LDE1LjQsMCwyMS4yaDBsMjYsMjZsLTI2LDI2Yy01LjksNS45LTUuOSwxNS40LDAsMjEuMmM1LjksNS45LDE1LjQsNS45LDIxLjIsMGwyNi0yNmwyNiwyNmM1LjksNS45LDE1LjQsNS45LDIxLjIsMCAgIGM1LjktNS45LDUuOS0xNS40LDAtMjEuMmwtMjYtMjZsMjYtMjZDMTQ4NS41LDE0NTIuNSwxNDg1LjUsMTQ0MywxNDc5LjYsMTQzNy4yeiIvPjxwYXRoIGZpbGw9IiNGRkZGRkYiIGQ9Ik02MDEuNywxNzM4LjdjLTUuOS01LjktMTUuNC01LjktMjEuMiwwdjBsLTI2LDI2bC0yNi0yNmMtNS45LTUuOS0xNS40LTUuOS0yMS4yLDAgICBjLTUuOSw1LjktNS45LDE1LjQsMCwyMS4yaDBsMjYsMjZsLTI2LDI2Yy01LjksNS45LTUuOSwxNS40LDAsMjEuMmM1LjksNS45LDE1LjQsNS45LDIxLjIsMGwyNi0yNmwyNiwyNmM1LjksNS45LDE1LjQsNS45LDIxLjIsMCAgIGM1LjktNS45LDUuOS0xNS40LDAtMjEuMmwtMjYtMjZsMjYtMjZDNjA3LjYsMTc1NC4xLDYwNy42LDE3NDQuNiw2MDEuNywxNzM4Ljd6Ii8+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTE3MzYuMiwzMDUuOGM1LjksNS45LDE1LjQsNS45LDIxLjIsMGM1LjktNS45LDUuOS0xNS40LDAtMjEuMmwtMjYtMjZsMjYtMjZjNS45LTUuOSw1LjktMTUuNCwwLTIxLjIgICBjLTUuOS01LjktMTUuNC01LjktMjEuMiwwaDBsLTI2LDI2bC0yNi0yNmMtNS45LTUuOS0xNS40LTUuOS0yMS4yLDBjLTUuOSw1LjktNS45LDE1LjQsMCwyMS4yaDBsMjYsMjZsLTI2LDI2ICAgYy01LjksNS45LTUuOSwxNS40LDAsMjEuMmM1LjksNS45LDE1LjQsNS45LDIxLjIsMGwyNi0yNkwxNzM2LjIsMzA1Ljh6Ii8+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTExNzQuOSw1MzljLTUtMy40LTEwLjUtNi0xNi4zLTcuOGMtNS45LTEuOC0xMi4xLTIuOC0xOC41LTIuOGMtOC42LDAtMTYuOCwxLjctMjQuMiw0LjkgICBjLTExLjIsNC43LTIwLjcsMTIuNi0yNy40LDIyLjVjLTMuNCw1LTYsMTAuNS03LjgsMTYuM2MtMS44LDUuOS0yLjgsMTIuMS0yLjgsMTguNWMwLDguNiwxLjcsMTYuOCw0LjksMjQuMiAgIGM0LjcsMTEuMiwxMi42LDIwLjcsMjIuNSwyNy40YzUsMy40LDEwLjUsNiwxNi4zLDcuOGM1LjksMS44LDEyLjEsMi44LDE4LjUsMi44YzguNiwwLDE2LjgtMS43LDI0LjItNC45ICAgYzExLjItNC43LDIwLjctMTIuNiwyNy40LTIyLjVjMy40LTUsNi0xMC41LDcuOC0xNi4zYzEuOC01LjksMi44LTEyLjEsMi44LTE4LjVjMC04LjYtMS43LTE2LjgtNC45LTI0LjIgICBDMTE5Mi43LDU1NS4yLDExODQuOCw1NDUuNywxMTc0LjksNTM5eiBNMTE2OS44LDYwMy4xYy0yLjQsNS44LTYuNSwxMC43LTExLjcsMTQuMmMtMi42LDEuNy01LjQsMy4xLTguNCw0LjEgICBjLTMsMC45LTYuMiwxLjQtOS42LDEuNGMtNC41LDAtOC43LTAuOS0xMi42LTIuNWMtNS44LTIuNC0xMC43LTYuNS0xNC4yLTExLjdjLTEuNy0yLjYtMy4xLTUuNC00LjEtOC40Yy0wLjktMy0xLjQtNi4yLTEuNC05LjYgICBjMC00LjUsMC45LTguNywyLjUtMTIuNmMyLjQtNS44LDYuNS0xMC43LDExLjctMTQuMmMyLjYtMS43LDUuNC0zLjEsOC40LTQuMWMzLTAuOSw2LjItMS40LDkuNi0xLjRjNC41LDAsOC43LDAuOSwxMi42LDIuNSAgIGM1LjgsMi40LDEwLjcsNi41LDE0LjIsMTEuN2MxLjcsMi42LDMuMSw1LjQsNC4xLDguNGMwLjksMywxLjQsNi4yLDEuNCw5LjZDMTE3Mi4zLDU5NS4xLDExNzEuNCw1OTkuMywxMTY5LjgsNjAzLjF6Ii8+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTE4MDQuOSwxODAyLjVjLTUtMy40LTEwLjUtNi0xNi4zLTcuOGMtNS45LTEuOC0xMi4xLTIuOC0xOC41LTIuOGMtOC42LDAtMTYuOCwxLjctMjQuMiw0LjkgICBjLTExLjIsNC43LTIwLjcsMTIuNi0yNy40LDIyLjVjLTMuNCw1LTYsMTAuNS03LjgsMTYuM2MtMS44LDUuOS0yLjgsMTIuMS0yLjgsMTguNWMwLDguNiwxLjcsMTYuOCw0LjksMjQuMiAgIGM0LjcsMTEuMiwxMi42LDIwLjcsMjIuNSwyNy40YzUsMy40LDEwLjUsNiwxNi4zLDcuOGM1LjksMS44LDEyLjEsMi44LDE4LjUsMi44YzguNiwwLDE2LjgtMS43LDI0LjItNC45ICAgYzExLjItNC43LDIwLjctMTIuNiwyNy40LTIyLjVjMy40LTUsNi0xMC41LDcuOC0xNi4zYzEuOC01LjksMi44LTEyLjEsMi44LTE4LjVjMC04LjYtMS43LTE2LjgtNC45LTI0LjIgICBDMTgyMi43LDE4MTguNywxODE0LjgsMTgwOS4zLDE4MDQuOSwxODAyLjV6IE0xNzk5LjgsMTg2Ni43Yy0yLjQsNS44LTYuNSwxMC43LTExLjcsMTQuMmMtMi42LDEuNy01LjQsMy4xLTguNCw0LjEgICBjLTMsMC45LTYuMiwxLjQtOS42LDEuNGMtNC41LDAtOC43LTAuOS0xMi42LTIuNWMtNS44LTIuNC0xMC43LTYuNS0xNC4yLTExLjdjLTEuNy0yLjYtMy4xLTUuNC00LjEtOC40Yy0wLjktMy0xLjQtNi4yLTEuNC05LjYgICBjMC00LjUsMC45LTguNywyLjUtMTIuNmMyLjQtNS44LDYuNS0xMC43LDExLjctMTQuMmMyLjYtMS43LDUuNC0zLjEsOC40LTQuMWMzLTAuOSw2LjItMS40LDkuNi0xLjRjNC41LDAsOC43LDAuOSwxMi42LDIuNSAgIGM1LjgsMi40LDEwLjcsNi41LDE0LjIsMTEuN2MxLjcsMi42LDMuMSw1LjQsNC4xLDguNGMwLjksMywxLjQsNi4yLDEuNCw5LjZDMTgwMi4zLDE4NTguNywxODAxLjQsMTg2Mi45LDE3OTkuOCwxODY2Ljd6Ii8+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTkxNC43LDE0MTEuNGMtNS0zLjQtMTAuNS02LTE2LjMtNy44Yy01LjktMS44LTEyLjEtMi44LTE4LjUtMi44Yy04LjYsMC0xNi44LDEuNy0yNC4yLDQuOSAgIGMtMTEuMiw0LjctMjAuNywxMi42LTI3LjQsMjIuNWMtMy40LDUtNiwxMC41LTcuOCwxNi4zYy0xLjgsNS45LTIuOCwxMi4xLTIuOCwxOC41YzAsOC42LDEuNywxNi44LDQuOSwyNC4yICAgYzQuNywxMS4yLDEyLjYsMjAuNywyMi41LDI3LjRjNSwzLjQsMTAuNSw2LDE2LjMsNy44YzUuOSwxLjgsMTIuMSwyLjgsMTguNSwyLjhjOC42LDAsMTYuOC0xLjcsMjQuMi00LjkgICBjMTEuMi00LjcsMjAuNy0xMi42LDI3LjQtMjIuNWMzLjQtNSw2LTEwLjUsNy44LTE2LjNjMS44LTUuOSwyLjgtMTIuMSwyLjgtMTguNWMwLTguNi0xLjctMTYuOC00LjktMjQuMiAgIEM5MzIuNSwxNDI3LjYsOTI0LjYsMTQxOC4xLDkxNC43LDE0MTEuNHogTTkwOS42LDE0NzUuNmMtMi40LDUuOC02LjUsMTAuNy0xMS43LDE0LjJjLTIuNiwxLjctNS40LDMuMS04LjQsNC4xICAgYy0zLDAuOS02LjIsMS40LTkuNiwxLjRjLTQuNSwwLTguNy0wLjktMTIuNi0yLjVjLTUuOC0yLjQtMTAuNy02LjUtMTQuMi0xMS43Yy0xLjctMi42LTMuMS01LjQtNC4xLTguNGMtMC45LTMtMS40LTYuMi0xLjQtOS42ICAgYzAtNC41LDAuOS04LjcsMi41LTEyLjZjMi40LTUuOCw2LjUtMTAuNywxMS43LTE0LjJjMi42LTEuNyw1LjQtMy4xLDguNC00LjFjMy0wLjksNi4yLTEuNCw5LjYtMS40YzQuNSwwLDguNywwLjksMTIuNiwyLjUgICBjNS44LDIuNCwxMC43LDYuNSwxNC4yLDExLjdjMS43LDIuNiwzLjEsNS40LDQuMSw4LjRjMC45LDMsMS40LDYuMiwxLjQsOS42QzkxMi4xLDE0NjcuNiw5MTEuMiwxNDcxLjgsOTA5LjYsMTQ3NS42eiIvPjxwYXRoIGZpbGw9IiNGRkZGRkYiIGQ9Ik0xOTQ2LjksNTY2LjNjLTQuNy0xMS4yLTEyLjYtMjAuNy0yMi41LTI3LjRjLTUtMy40LTEwLjUtNi0xNi4zLTcuOGMtNS45LTEuOC0xMi4xLTIuOC0xOC41LTIuOCAgIGMtOC42LDAtMTYuOCwxLjctMjQuMiw0LjljLTExLjIsNC43LTIwLjcsMTIuNi0yNy40LDIyLjVjLTMuNCw1LTYsMTAuNS03LjgsMTYuM2MtMS44LDUuOS0yLjgsMTIuMS0yLjgsMTguNSAgIGMwLDguNiwxLjcsMTYuOCw0LjksMjQuMmM0LjcsMTEuMiwxMi42LDIwLjcsMjIuNSwyNy40YzUsMy40LDEwLjUsNiwxNi4zLDcuOGM1LjksMS44LDEyLjEsMi44LDE4LjUsMi44YzguNiwwLDE2LjgtMS43LDI0LjItNC45ICAgYzExLjItNC43LDIwLjctMTIuNiwyNy40LTIyLjVjMy40LTUsNi0xMC41LDcuOC0xNi4zYzEuOC01LjksMi44LTEyLjEsMi44LTE4LjVDMTk1MS44LDU4MiwxOTUwLDU3My44LDE5NDYuOSw1NjYuM3ogICAgTTE5MTkuMyw2MDMuMWMtMi40LDUuOC02LjUsMTAuNy0xMS43LDE0LjJjLTIuNiwxLjctNS40LDMuMS04LjQsNC4xYy0zLDAuOS02LjIsMS40LTkuNiwxLjRjLTQuNSwwLTguNy0wLjktMTIuNi0yLjUgICBjLTUuOC0yLjQtMTAuNy02LjUtMTQuMi0xMS43Yy0xLjctMi42LTMuMS01LjQtNC4xLTguNGMtMC45LTMtMS40LTYuMi0xLjQtOS42YzAtNC41LDAuOS04LjcsMi41LTEyLjZjMi40LTUuOCw2LjUtMTAuNywxMS43LTE0LjIgICBjMi42LTEuNyw1LjQtMy4xLDguNC00LjFjMy0wLjksNi4yLTEuNCw5LjYtMS40YzQuNSwwLDguNywwLjksMTIuNiwyLjVjNS44LDIuNCwxMC43LDYuNSwxNC4yLDExLjdjMS43LDIuNiwzLjEsNS40LDQuMSw4LjQgICBjMC45LDMsMS40LDYuMiwxLjQsOS42QzE5MjEuOCw1OTUuMSwxOTIwLjksNTk5LjMsMTkxOS4zLDYwMy4xeiIvPjxwYXRoIGZpbGw9IiNGRkZGRkYiIGQ9Ik0yOTIuOCwyMDYuOWMtNS0zLjQtMTAuNS02LTE2LjMtNy44Yy01LjktMS44LTEyLjEtMi44LTE4LjUtMi44Yy04LjYsMC0xNi44LDEuNy0yNC4yLDQuOSAgIGMtMTEuMiw0LjctMjAuNywxMi42LTI3LjQsMjIuNWMtMy40LDUtNiwxMC41LTcuOCwxNi4zYy0xLjgsNS45LTIuOCwxMi4xLTIuOCwxOC41YzAsOC42LDEuNywxNi44LDQuOSwyNC4yICAgYzQuNywxMS4yLDEyLjYsMjAuNywyMi41LDI3LjRjNSwzLjQsMTAuNSw2LDE2LjMsNy44YzUuOSwxLjgsMTIuMSwyLjgsMTguNSwyLjhjOC42LDAsMTYuOC0xLjcsMjQuMi00LjkgICBjMTEuMi00LjcsMjAuNy0xMi42LDI3LjQtMjIuNWMzLjQtNSw2LTEwLjUsNy44LTE2LjNjMS44LTUuOSwyLjgtMTIuMSwyLjgtMTguNWMwLTguNi0xLjctMTYuOC00LjktMjQuMiAgIEMzMTAuNiwyMjMuMSwzMDIuNywyMTMuNiwyOTIuOCwyMDYuOXogTTI4Ny43LDI3MS4xYy0yLjQsNS44LTYuNSwxMC43LTExLjcsMTQuMmMtMi42LDEuNy01LjQsMy4xLTguNCw0LjFjLTMsMC45LTYuMiwxLjQtOS42LDEuNCAgIGMtNC41LDAtOC43LTAuOS0xMi42LTIuNWMtNS44LTIuNC0xMC43LTYuNS0xNC4yLTExLjdjLTEuNy0yLjYtMy4xLTUuNC00LjEtOC40Yy0wLjktMy0xLjQtNi4yLTEuNC05LjZjMC00LjUsMC45LTguNywyLjUtMTIuNiAgIGMyLjQtNS44LDYuNS0xMC43LDExLjctMTQuMmMyLjYtMS43LDUuNC0zLjEsOC40LTQuMWMzLTAuOSw2LjItMS40LDkuNi0xLjRjNC41LDAsOC43LDAuOSwxMi42LDIuNWM1LjgsMi40LDEwLjcsNi41LDE0LjIsMTEuNyAgIGMxLjcsMi42LDMuMSw1LjQsNC4xLDguNGMwLjksMywxLjQsNi4yLDEuNCw5LjZDMjkwLjIsMjYzLjEsMjg5LjMsMjY3LjMsMjg3LjcsMjcxLjF6Ii8+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTQ2NC44LDEwOTEuOWMtMi0xLjQtNC4zLTIuNS02LjctMy4yYy0yLjQtMC43LTUtMS4xLTcuNi0xLjFjLTMuNSwwLTYuOSwwLjctOS45LDIgICBjLTQuNiwxLjktOC41LDUuMi0xMS4yLDkuMmMtMS40LDItMi41LDQuMy0zLjIsNi43Yy0wLjcsMi40LTEuMSw1LTEuMSw3LjZjMCwzLjUsMC43LDYuOSwyLDkuOWMxLjksNC42LDUuMiw4LjUsOS4yLDExLjIgICBjMiwxLjQsNC4zLDIuNSw2LjcsMy4yYzIuNCwwLjcsNSwxLjEsNy42LDEuMWMzLjUsMCw2LjktMC43LDkuOS0yYzQuNi0xLjksOC41LTUuMiwxMS4yLTkuMmMxLjQtMiwyLjUtNC4zLDMuMi02LjcgICBjMC43LTIuNCwxLjEtNSwxLjEtNy42YzAtMy41LTAuNy02LjktMi05LjlDNDcyLDEwOTguNSw0NjguOCwxMDk0LjYsNDY0LjgsMTA5MS45eiBNNDUwLjUsMTExM0w0NTAuNSwxMTEzbDQuMy0xLjNMNDUwLjUsMTExM3ogICAgTTQ1MC41LDExMTNMNDUwLjUsMTExM2wtMS4zLTQuM0w0NTAuNSwxMTEzeiBNNDUwLjUsMTExM0w0NTAuNSwxMTEzbC0zLjcsMi41TDQ1MC41LDExMTN6IE00NTAuNSwxMTEzbDIuNSwzLjdMNDUwLjUsMTExMyAgIGw0LjEsMS44TDQ1MC41LDExMTN6Ii8+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTExOTEuMSwxNzc1LjNjLTItMS40LTQuMy0yLjUtNi43LTMuMmMtMi40LTAuNy01LTEuMS03LjYtMS4xYy0zLjUsMC02LjksMC43LTkuOSwyICAgYy00LjYsMS45LTguNSw1LjItMTEuMiw5LjJjLTEuNCwyLTIuNSw0LjMtMy4yLDYuN2MtMC43LDIuNC0xLjEsNS0xLjEsNy42YzAsMy41LDAuNyw2LjksMiw5LjljMS45LDQuNiw1LjIsOC41LDkuMiwxMS4yICAgYzIsMS40LDQuMywyLjUsNi43LDMuMmMyLjQsMC43LDUsMS4xLDcuNiwxLjFjMy41LDAsNi45LTAuNyw5LjktMmM0LjYtMS45LDguNS01LjIsMTEuMi05LjJjMS40LTIsMi41LTQuMywzLjItNi43ICAgYzAuNy0yLjQsMS4xLTUsMS4xLTcuNmMwLTMuNS0wLjctNi45LTItOS45QzExOTguNCwxNzgxLjksMTE5NS4yLDE3NzguMSwxMTkxLjEsMTc3NS4zeiBNMTE3Ni45LDE3OTYuNEwxMTc2LjksMTc5Ni40bDEuOC00LjEgICBMMTE3Ni45LDE3OTYuNHogTTExNzYuOSwxNzk2LjRMMTE3Ni45LDE3OTYuNGwtMi41LTMuN0wxMTc2LjksMTc5Ni40eiBNMTE3Ni45LDE3OTYuNEwxMTc2LjksMTc5Ni40bDEuMyw0LjNMMTE3Ni45LDE3OTYuNHoiLz48cGF0aCBmaWxsPSIjRkZGRkZGIiBkPSJNMTI4Ny4zLDIwMC44Yy0yLTEuNC00LjMtMi41LTYuNy0zLjJjLTIuNC0wLjctNS0xLjEtNy42LTEuMWMtMy41LDAtNi45LDAuNy05LjksMiAgIGMtNC42LDEuOS04LjUsNS4yLTExLjIsOS4yYy0xLjQsMi0yLjUsNC4zLTMuMiw2LjdjLTAuNywyLjQtMS4xLDUtMS4xLDcuNmMwLDMuNSwwLjcsNi45LDIsOS45YzEuOSw0LjYsNS4yLDguNSw5LjIsMTEuMiAgIGMyLDEuNCw0LjMsMi41LDYuNywzLjJjMi40LDAuNyw1LDEuMSw3LjYsMS4xYzMuNSwwLDYuOS0wLjcsOS45LTJjNC42LTEuOSw4LjUtNS4yLDExLjItOS4yYzEuNC0yLDIuNS00LjMsMy4yLTYuNyAgIGMwLjctMi40LDEuMS01LDEuMS03LjZjMC0zLjUtMC43LTYuOS0yLTkuOUMxMjk0LjUsMjA3LjQsMTI5MS4zLDIwMy42LDEyODcuMywyMDAuOHogTTEyNzMsMjIxLjlMMTI3MywyMjEuOWwxLjgtNC4xTDEyNzMsMjIxLjl6ICAgIE0xMjczLDIyMkwxMjczLDIyMmwtNC4zLDEuM0wxMjczLDIyMnogTTEyNzMsMjIyTDEyNzMsMjIybC0xLjgsNC4xTDEyNzMsMjIyeiBNMTI3MywyMjJMMTI3MywyMjJsMS4zLDQuM0wxMjczLDIyMnogTTEyNzMsMjIyICAgTDEyNzMsMjIybDQuMSwxLjhMMTI3MywyMjJ6Ii8+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTE1OTAuMSw3NzAuMmMtMi0xLjQtNC4zLTIuNS02LjctMy4yYy0yLjQtMC43LTUtMS4xLTcuNi0xLjFjLTMuNSwwLTYuOSwwLjctOS45LDIgICBjLTQuNiwxLjktOC41LDUuMi0xMS4yLDkuMmMtMS40LDItMi41LDQuMy0zLjIsNi43Yy0wLjcsMi40LTEuMSw1LTEuMSw3LjZjMCwzLjUsMC43LDYuOSwyLDkuOWMxLjksNC42LDUuMiw4LjUsOS4yLDExLjIgICBjMiwxLjQsNC4zLDIuNSw2LjcsMy4yYzIuNCwwLjcsNSwxLjEsNy42LDEuMWMzLjUsMCw2LjktMC43LDkuOS0yYzQuNi0xLjksOC41LTUuMiwxMS4yLTkuMmMxLjQtMiwyLjUtNC4zLDMuMi02LjcgICBjMC43LTIuNCwxLjEtNSwxLjEtNy42YzAtMy41LTAuNy02LjktMi05LjlDMTU5Ny40LDc3Ni44LDE1OTQuMiw3NzIuOSwxNTkwLjEsNzcwLjJ6IE0xNTc1LjksNzkxLjNMMTU3NS45LDc5MS4zbDQuMy0xLjMgICBMMTU3NS45LDc5MS4zeiBNMTU3NS45LDc5MS4zTDE1NzUuOSw3OTEuM2wtMi41LTMuN0wxNTc1LjksNzkxLjN6IE0xNTc1LjksNzkxLjNMMTU3NS45LDc5MS4zbC0xLjgsNC4xTDE1NzUuOSw3OTEuM3ogICAgTTE1NzUuOSw3OTEuM2wyLjUsMy43TDE1NzUuOSw3OTEuM2w0LjEsMS44TDE1NzUuOSw3OTEuM3oiLz48cGF0aCBmaWxsPSIjRkZGRkZGIiBkPSJNMTExMS4yLDk5NC41bC04Ni40LTUuOWMtNS4zLTAuNC0xMC41LDIuMi0xMy41LDYuNmMtMyw0LjQtMy40LDEwLjItMSwxNWwzOC4xLDc3LjggICBjMi40LDQuOCw3LjEsOCwxMi40LDguNHMxMC41LTIuMiwxMy41LTYuNmw0OC4zLTcxLjljMy00LjQsMy40LTEwLjIsMS0xNVMxMTE2LjYsOTk0LjksMTExMS4yLDk5NC41eiBNMTA2NCwxMDUxLjRsLTE1LjItMzEuMSAgIGwzNC42LDIuNEwxMDY0LDEwNTEuNHoiLz48cGF0aCBmaWxsPSIjRkZGRkZGIiBkPSJNMjQ0LjUsODI3LjljNS4xLDEuNywxMC43LDAuNiwxNC43LTNjNC0zLjUsNS44LTksNC44LTE0LjJsLTE3LjEtODQuOWMtMS4xLTUuMy00LjgtOS41LTkuOS0xMS4zICAgcy0xMC43LTAuNi0xNC43LDNsLTY1LDU3LjJjLTQsMy41LTUuOCw5LTQuOCwxNC4yczQuOCw5LjUsOS45LDExLjNMMjQ0LjUsODI3Ljl6IE0yMjIuNiw3NTcuMmw2LjgsMzRsLTMyLjgtMTEuMUwyMjIuNiw3NTcuMnoiLz48cGF0aCBmaWxsPSIjRkZGRkZGIiBkPSJNMjU2LjIsMTQ5MS44bC03Ny44LTM4LjFjLTQuOC0yLjQtMTAuNS0yLTE1LDFzLTcsOC4xLTYuNiwxMy41bDUuOSw4Ni40YzAuNCw1LjMsMy41LDEwLjEsOC40LDEyLjUgICBjNC44LDIuNCwxMC41LDIsMTUtMWw3MS45LTQ4LjNjNC40LTMsNy04LjEsNi42LTEzLjVDMjY0LjIsMTQ5OC45LDI2MSwxNDk0LjEsMjU2LjIsMTQ5MS44eiBNMTkwLjksMTUyNi42bC0yLjMtMzQuNmwzMS4xLDE1LjMgICBMMTkwLjksMTUyNi42eiIvPjxwYXRoIGZpbGw9IiNGRkZGRkYiIGQ9Ik05MzkuOCwxODkuOGwtNjYuNC01NS42Yy00LjEtMy40LTkuNy00LjQtMTQuOC0yLjZjLTUsMS44LTguNyw2LjItOS42LDExLjVsLTE1LDg1LjMgICBjLTAuOSw1LjMsMSwxMC42LDUuMSwxNC4xYzQuMSwzLjQsOS43LDQuNCwxNC44LDIuNmw4MS4zLTI5LjdjNS0xLjgsOC43LTYuMiw5LjYtMTEuNVM5NDMuOSwxOTMuMiw5MzkuOCwxODkuOHogTTg2OC4xLDIwOGw2LTM0LjEgICBsMjYuNiwyMi4yTDg2OC4xLDIwOHoiLz48cGF0aCBmaWxsPSIjRkZGRkZGIiBkPSJNMTc1MiwxMTYzLjRsLTM4LjUsNzcuNmMtMi40LDQuOC0yLDEwLjUsMC45LDE1YzMsNC41LDguMSw3LDEzLjQsNi43bDg2LjQtNS40YzUuMy0wLjMsMTAuMS0zLjUsMTIuNS04LjMgICBjMi40LTQuOCwyLTEwLjUtMC45LTE1bC00Ny45LTcyLjJjLTMtNC41LTguMS03LTEzLjQtNi43QzE3NTkuMSwxMTU1LjUsMTc1NC4zLDExNTguNiwxNzUyLDExNjMuNHogTTE3NTEuOCwxMjMxLjFsMTUuNC0zMSAgIGwxOS4yLDI4LjlMMTc1MS44LDEyMzEuMXoiLz48L2c+PHN0eWxlIGlkPSJzdHlsaXNoLTIiIGNsYXNzPSJzdHlsaXNoIiB0eXBlPSJ0ZXh0L2NzcyI+LyogNGNoYW4gLSBNaWRuaWdodCBDYWVrICovQG5hbWVzcGFjZSB1cmwoaHR0cDovL3d3dy53My5vcmcvMTk5OS94aHRtbCk7PC9zdHlsZT48L3N2Zz4=');
    background-size: 12em !important;
}
.header-2BwW8b,
.body-3iLsc4,
.footer-1fjuF6 {
	z-index:2 !important;
	position:relative;
}
.role-2irmRk {
  border-width: 1px;
  border-style: solid;
  border-radius: 2px;
  box-sizing: content-box;
  height: 16px;
  margin: 3px;
  padding: 2px;
  position: relative;
  line-height: 16px;
  font-size: 10px;
  font-weight: 400;
  text-transform: uppercase;
  overflow: visible;
}
.role-2irmRk::before {
  content: '';
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  border-width: calc(0.65em + 4px) .5em;
  border-style: solid;
  border-color: inherit;
  box-sizing: border-box;
  opacity: 0.5;
}
.roleName-32vpEy {
  margin: 0 4px;
}
.roleCircleButton-377y0l {
  padding: 0;
  position: absolute;
  z-index: 2;
  height: 22px;
  top: -1px;
  left: -1px;
  border-radius: 2px 0 0 2px;
  width: 0px;
  display: flex !important;
  transition: width 200ms;
}
.roleCircle-3xAZ1j {
  display: none;
}
.addButton-pcyyf6 {
  line-height: 10px;
  width: 22px;
  box-sizing: border-box;
  height: 22px;
}
.roleRemoveIcon-2-TeGW {
  display: block;
}
.role-2irmRk:hover .roleCircleButton-377y0l {
  transition: width 0.2s;
  width: 22px;
}
.addButtonIcon-1NMJ8u {
  height: 7px;
  width: 7px;
}

/*7.e. Pinned Messages/Mentions*/
.themedPopout-25DgLi {
    background:var(--backdropblurred) !important;
    background-size:cover !important;
    background-repeat:no-repeat;
    box-shadow:inset 0 0 0 1000px rgba(0,0,0,0.5) !important;
    border:none !important;
    animation: slide-down 200ms ease !important;
}
@keyframes slide-up {
  from {
      transform: translate(0%, 10%);
  }
}
@keyframes slide-down {
  from {
      transform: translate(0%, -5%);
  }
}
.iconBadge-2dji3k {
    border-color:rgba(0,0,0,0.8) !important;
}
.messagesPopoutWrap-1MQ1bW {
    background:var(--backdrop) !important;
    background-repeat:no-repeat;
    box-shadow:inset 0px 0px 1000px rgba(0,0,0,0.5) !important;
    background-size:cover !important;
    border:none;
}
.messagesPopoutWrap-1MQ1bW .da-containerCozy {
    background:transparent !important;
}
.header-ykumBX,
.footer-1kmXd4 {
    background:rgba(0,0,0,0.5) !important;
}
.messageGroupWrapper-o-Zw7G {
    background:rgba(0,0,0,0.6) !important;
    border:none;
    transition:250ms ease-in-out border;
}
.messageGroupWrapper-o-Zw7G:hover {
    border:2px solid var(--hover-color) !important;
}
.jumpButton-3DTcS_,
.jump-button {
    background:var(--main-color) !important;
}
.actionButtons-1sUUug {
    background:transparent !important;
    box-shadow:none !important;
}

/*6.f. Search Popout*/
.searchAnswer-3Dz2-q, .searchFilter-2ESiM3 {
	background:rgba(255,255,255,0.05);
}
.container-3ayLPN {
    background:var(--backdrop) !important;
    background-repeat:no-repeat !important;
    background-size:cover !important;
    box-shadow:0px 0px 1000px inset rgba(0,0,0,0.7) !important;
}
.option-96V44q:after {
	display:none !important;
}
.option-96V44q.selected-rZcOL-,
.focused-2bY0OD,
.da-searchHeader,
.search-header,
.da-searchAnswer,
.da-searchFilter {
	background:rgba(0,0,0,0.5) !important;
	border:none !important;
}
.dim-1l4L4y span,
.keybindShortcut-1BD6Z1 span {
	background:var(--main-color) !important;
	color:#fff !important;
}
.calendarPicker-2yf6Ci .react-datepicker__navigation.react-datepicker__navigation--next,
.calendarPicker-2yf6Ci .react-datepicker__navigation.react-datepicker__navigation--previous,
.searchAnswer-3Dz2-q {
    background-color:rgba(0,0,0,0.7) !important;
}
/*empathy banana by devilbro omegalul*/
.noResultsImage-JbSWtu.alt-1RXaBT:before,
.noResultsImage-JbSWtu.alt-1RXaBT:after {
	content: "";
	position: absolute;
	width: 160px;
	height: 160px;
	left: 20px;
}
.noResultsImage-JbSWtu.alt-1RXaBT:before {
	background: var(--main-color) !important;
	-webkit-mask: url('data:image/svg+xml; utf8, <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="160" height="160" viewBox="0 0 160 160"><g fill="none" fill-rule="evenodd"><g transform="translate(10 7)"><g transform="translate(12 .573)"><path fill="#7187DD" d="M49.8635,70.2091 C51.5655,76.7781 49.8455,82.9061 46.0245,83.8961 C42.2015,84.8861 37.7235,80.3641 36.0225,73.7941 C34.3205,67.2261 36.0395,61.0981 39.8615,60.1071 C43.6835,59.1181 48.1615,63.6401 49.8635,70.2091"/></g></g><rect width="160" height="160"/></g></svg>') center/cover no-repeat;
}
.noResultsImage-JbSWtu.alt-1RXaBT:after {
	background: url('data:image/svg+xml; utf8, <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="160" height="160" viewBox="0 0 160 160"><g fill="none" fill-rule="evenodd"><g transform="translate(10 7)"><g transform="translate(12 .573)"><path xmlns="http://www.w3.org/2000/svg" stroke="#1E2126" stroke-width="2" d="M49.8635 70.2091C51.5655 76.7781 49.8455 82.9061 46.0245 83.8961 42.2015 84.8861 37.7235 80.3641 36.0225 73.7941 34.3205 67.2261 36.0395 61.0981 39.8615 60.1071 43.6835 59.1181 48.1615 63.6401 49.8635 70.2091zM74.6131 102.5616C76.9551 105.2676 79.6021 108.0356 82.5881 110.8036M57.7942 73.6031C57.7942 73.6031 60.7322 85.1711 71.8182 99.1851M65.9788 8.3199C66.1898 8.3969 66.4068 8.4719 66.6318 8.5459" stroke-linecap="round" stroke-linejoin="round"/></g></g><rect width="160" height="160"/></g></svg>') center/cover no-repeat;
}
/*thanks devilbro*/
.calendarPicker-2yf6Ci,
.react-datepicker,
.react-datepicker__header,
.da-channelName,
.da-resultsWrapper .da-containerCozy,
.da-searchResultsWrap,
.search-results-wrap,
.channel-name,
.results-wrapper .da-containerCozy {
    background:transparent !important;
}
.da-resultsWrapper .containerCozy-jafyvG,
.results-wrapper {
    padding-bottom:15px;
}
.results-wrapper .da-containerCozy {
	padding-bottom:5px;
}
.hintValue-29ny8Z,
.react-datepicker__day--selected:after,
.react-datepicker__day:hover,
.searchFilter-2ESiM3,
.jumpButton-Ia2hRJ {
     background:var(--main-color) !important;
}
.react-datepicker__day {
    border:none !important;
    background:rgba(0,0,0,0.5) !important;
    transition:150ms ease all !important;
}
.da-searchResultMessage.da-hit,
.search-results-wrap .search-result .hit {
    box-shadow:none !important;
    border-color:rgba(0,0,0,0.5) !important;
    background:rgba(0,0,0,0.3) !important;
}
.da-searchResult:before,
.da-searchResult:after,
.search-result:after,
.search-result:before {
    display:none;
}
.da-searchResultsWrap,
.search-results-wrap {
    background:var(--backdropblurred) !important;
    background-size:cover !important;
    background-repeat:no-repeat !important;
    background-attachment: fixed !important;
}

/*7.g. Add to Group DM*/
.da-searchBarTag {
	background:var(--main-color) !important;
}
.friendSelected-wQP3f {
	background:rgba(0,0,0,0.25) !important;
}

/*7.h. Select Menus*/
.Select-menu-outer {
    background:rgba(0,0,0,0.7) !important;
    border:none;
    animation: menu .3s cubic-bezier(.2,.6,.5,1.1);
    transform-origin: 50% 0;
}
@keyframes menu {
    0% {
        -webkit-transform: rotateX(-90deg);
        transform: rotateX(-90deg);
        opacity: 0;
    }
    100% {
        -webkit-transform: none;
        transform: none;
        opacity: 1;
    }
}

/*7.i. Emoji Picker*/
.da-emojiPicker .da-scroller::-webkit-scrollbar-thumb {
	background:var(--hover-color) !important;
}
.da-emojiPicker .da-scroller::-webkit-scrollbar {
	width:7px !important;
}
#bda-qem {
	background:transparent !important;
}
/*emoji picker scrollbar and shit*/
.da-emojiPicker .da-scroller::-webkit-scrollbar-track-piece {
	background:rgba(0,0,0,0.5);
}
.fav {
    background-color:rgba(0,0,0,0.5) !important;
    border-color:rgba(0,0,0,0.75) !important;
}
.da-emojiPicker,
#bda-qem-twitch-container,
#bda-qem-favourite-container{
    background:var(--backdrop) !important;
    padding:10px 10px 10px 10px;
    border-radius:0px !important;
    border:4px solid rgba(0,0,0,0.75) !important;
    background-size:cover !important;
    box-shadow:inset 0px 0px 0px 1000px rgba(0,0,0,0.75);
}
.da-emojiPicker .da-stickyHeader {
    border-radius:5px;
    background:rgba(0,0,0,0.75) !important;
}
.da-emojiPicker .da-category {
    color:var(--hover-color) !important;
    font-weight:bold;
    background-color:transparent !important;
}
.da-emojiPicker .da-emojiItem {
    transition:250ms all linear;
}
.da-emojiPicker .da-searchBar .da-searchBarInner,
.da-emojiItem.da-selected,
.da-diversitySelector .da-popout,
.da-emojiPicker .da-scroller::-webkit-scrollbar-track {
    background-color:rgba(0,0,0,0.5) !important;
    border:none !important;
}
#bda-qem button.active, #bda-qem button:hover {
	background:rgba(0,0,0,0.85) !important;
}
#bda-qem-twitch,
#bda-qem-favourite,
#bda-qem-emojis,
#bda-qem button {
    color:#fff !important;
    background:rgba(0,0,0,0.75) !important;
    box-shadow:none;
    border:none !important;
}
.da-emojiPicker .da-categories .da-item,
.da-emojiPicker .da-sadImage {
    opacity:0.6;
    filter:invert(100) brightness(10);
}
.da-emojiPicker .da-categories .da-item.da-selected {
    border-bottom-color:var(--hover-color) !important;
}
.da-emojiPicker .da-item:hover,
.da-emojiPicker .da-item.da-selected {
    filter:none !important;
}

/*7.j. Gif Picker*/
.result-3w1ZcL:hover:after {
	box-shadow:inset 0 0 0 2px var(--hover-color) !important;
}
.autocomplete-1vrmpx {
    background:var(--backdrop) !important;
    background-repeat:no-repeat;
    background-size:cover !important;
    box-shadow:inset 0 0 0 1000px rgba(0,0,0,0.75);
}
.result-3w1ZcL {
  background-color:rgba(0,0,0,0.5) !important;
}
.autocomplete-1vrmpx {
    animation: slide-up 150ms ease;
}
.da-categoryFadeBlurple {
    background:var(--main-color) !important;
    opacity:0.6 !important;
}

/*7.k. RTC Connection Popout*/
.container-2x5lvQ {
	background:var(--backdrop) !important;
	background-size:cover !important;
	background-repeat:no-repeat !important;
}
.sparkline-3A-8OK svg g polyline {
	stroke:var(--hover-color) !important;
}
.description-3_Ncsb g path {
	stroke:var(--hover-color) !important;
}
.container-2x5lvQ header {
	background:rgba(0,0,0,0.5) !important;
}
.container-2x5lvQ section {
	background:rgba(0,0,0,0.25) !important;
}
.emptyHintCard-2mUdMe {
	background:var(--main-color-faded) !important;
}
.da-result[style*="rgb(179, 174, 255)"],
.searchSuggestion-2K8OBX.searchSuggestion-2K8OBX:hover  {
	background:var(--main-color) !important;
}
.da-result[style*="rgb(146, 154, 250)"],
.da-result[style*="rgb(115, 142, 245)"] {
	background:var(--hover-color) !important;
}
.searchSuggestion-2K8OBX.searchSuggestion-2K8OBX:hover {
	border-color:var(--hover-color) !important;
}

/*7.l. Toasts*/
.toast, .bd-toast {
	background:var(--main-color);
}

/*7.m. @Everyone Popout*/
.everyonePopout-nEbJY3{
	background-color: rgba(0,0,0,0.6) !important;
}
.everyonePopout-nEbJY3 .footer-2aTx0s{
	background-color: rgba(0,0,0,0.8) !important;
}
.everyonePopout-nEbJY3 .lookOutlined-3sRXeN.colorBrand-3pXr91 {
	color: var(--hover-color);
	border-color: var(--hover-color);
}
/*============== END OF SECTION ============== */

/*8. Modals*/
/*8.a. Transparency*/
.modal-3HD5ck,
.bd-modal-inner,
.bd-modal-body,
.bd-modal-wrapper .header {
	background:var(--backdrop) !important;
	background-size:cover !important;
	background-repeat:no-repeat;
	box-shadow:inset 0px 0px 10000px rgba(0,0,0,0.8), 0px 0px 10px rgba(0,0,0,0.5) !important;
}
.bd-modalHeader .bd-modalX:hover {
  background:var(--main-color-faded) !important;
}
.bd-modal-wrapper .footer button {
	background:var(--main-color) !important;
}
.bd-modalFooter .bd-footerAlert {
  background:rgba(0,0,0,0.5) !important;
}
.footer-2yfCgX {
	background:transparent !important;
	box-shadow:none !important;
}
.option-1l2vXE {
    background-color:rgba(0,0,0,0.5) !important;
}

/*8.b. Upload Modal*/
.uploadModal-2ifh8j {
	background: var(--main-color);
}
.uploadModal-2ifh8j .footer-3mqk7D {
	color: white;
}
.theme-brand .content-Qb0rXO {
	color: white;
}
.uploadModal-2ifh8j .footer-3mqk7D {
	background:rgba(0,0,0,0.3) !important;
}
.uploadModal-2ifh8j .inner-3nWsbo {
	border-color:var(--main-color) !important;
}
.uploadModal-2ifh8j .inner-3nWsbo .file-34mY5K .icon-kyxXVr.image-2yrs5j {
  border-color: var(--hover-color) !important;
  margin-top: 0;
  transform: translateY(-50%);
  transition: all .3s ease-in-out;
}
.uploadModal-2ifh8j .inner-3nWsbo .file-34mY5K .icon-kyxXVr.image-2yrs5j:hover {
  height: 208px;
  width: calc(100% - 28px);
  transform: translateY(calc(-50% - 10px));
}
.uploadModal-2ifh8j .footer-3mqk7D .button {
	background:var(--main-color) !important;
	color:white !important;
}
.uploadModalIn-1z07Bv .uploadDropModal-2kTwbc .bgScale-1otPtc {
    background:var(--main-color);
}
.da-attachment {
    background:rgba(0,0,0,0.5) !important;
    box-shadow:0px 0px 5px rgba(0,0,0,0.5) !important;
    border:none !important;
    border-radius:5px !important;
}
.progressBar-3u8FBM {
	background:var(--hover-color) !important;
}
.attachment-33OFj0 {
	position: relative !important;
}
.attachment-33OFj0 .icon-1kp3fr {
	box-sizing: border-box !important;
	height: 40px !important;
	width: 30px !important;
	padding-right: 30px !important;
	background: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMCwzLjAwNzQxOTg4IEMwLDEuMzQ2NDY3NzUgMS4zNDI1MjQxNSwwIDIuOTk5OTg1ODgsMCBMMTUuMTE2NjQ4MywwIEMxNy4wODA3MzU0LDAgMjQsNi45MTg4NTcyNSAyNCw4Ljg3NDU3NTkzIEwyNCwzMy4wMDM1NTc0IEMyNCwzNC42NTg0NDY5IDIyLjY1ODIyOTQsMzYgMjEuMDA4OTA5NiwzNiBMMi45OTEwOTA0MiwzNiBDMS4zMzkxNTY3OSwzNiAwLDM0LjY1NDQ2MDcgMCwzMi45OTI1ODAxIEwwLDMuMDA3NDE5ODggWiIgc3Ryb2tlPSJ3aGl0ZSIgZmlsbD0id2hpdGUiLz48cGF0aCBkPSJNMTcsMS4wOTY3NzMzNiBDMTcsMC41NDIwNDAzMTYgMTcuMzE0Nzk2NCwwLjQwNzA5Nzc5MSAxNy43MTMzMTE4LDAuODA1NTYzNzkgTDIzLjE5NTIwMzEsNi4yODY3NzY1NCBDMjMuNTg5MTU0Myw2LjY4MDY3ODk4IDIzLjQ1NTIyNzksNyAyMi45MDM5NTc1LDcgTDE4LjAwNDU1NzQsNyBDMTcuNDQ5NzU1Nyw3IDE3LDYuNTQ2NzY5MTYgMTcsNS45OTU1NjY5OCBMMTcsMS4wOTY3NzMzNiBaIiBzdHJva2U9IndoaXRlIiBmaWxsPSIjRjRGNkZDIi8+PC9nPjwvZz48L2c+PC9nPjwvZz48L3N2Zz4=') center/cover no-repeat !important;
}
.audioMetadata-3zOuGv {
	padding-left: 30px !important;
}
.audioMetadata-3zOuGv > *:first-child:after {
	content: "";
	height: 40px !important;
	width: 30px !important;
	position: absolute !important;
	top: 10px;
	left: 10px;
	background: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMCwzLjAwNzQxOTg4IEMwLDEuMzQ2NDY3NzUgMS4zNDI1MjQxNSwwIDIuOTk5OTg1ODgsMCBMMTUuMTE2NjQ4MywwIEMxNy4wODA3MzU0LDAgMjQsNi45MTg4NTcyNSAyNCw4Ljg3NDU3NTkzIEwyNCwzMy4wMDM1NTc0IEMyNCwzNC42NTg0NDY5IDIyLjY1ODIyOTQsMzYgMjEuMDA4OTA5NiwzNiBMMi45OTEwOTA0MiwzNiBDMS4zMzkxNTY3OSwzNiAwLDM0LjY1NDQ2MDcgMCwzMi45OTI1ODAxIEwwLDMuMDA3NDE5ODggWiIgc3Ryb2tlPSJ3aGl0ZSIgZmlsbD0id2hpdGUiLz48cGF0aCBkPSJNMTcsMS4wOTY3NzMzNiBDMTcsMC41NDIwNDAzMTYgMTcuMzE0Nzk2NCwwLjQwNzA5Nzc5MSAxNy43MTMzMTE4LDAuODA1NTYzNzkgTDIzLjE5NTIwMzEsNi4yODY3NzY1NCBDMjMuNTg5MTU0Myw2LjY4MDY3ODk4IDIzLjQ1NTIyNzksNyAyMi45MDM5NTc1LDcgTDE4LjAwNDU1NzQsNyBDMTcuNDQ5NzU1Nyw3IDE3LDYuNTQ2NzY5MTYgMTcsNS45OTU1NjY5OCBMMTcsMS4wOTY3NzMzNiBaIiBzdHJva2U9IndoaXRlIiBmaWxsPSIjRjRGNkZDIi8+PC9nPjwvZz48L2c+PC9nPjwvZz48L3N2Zz4=') center/cover no-repeat !important;
}
.audioMetadata-3zOuGv:before,
.audioMetadata-3zOuGv:after,
.attachment-33OFj0 .icon-1kp3fr + *:before,
.attachment-33OFj0 .icon-1kp3fr + *:after {
	content: "";
	height: 40px;
	width: 30px;
	top: 10px;
	left: 10px;
	position: absolute;
	z-index: 1;
	-webkit-mask-size: cover;
	background: var(--main-color);
}
.audioMetadata-3zOuGv:after,
.attachment-33OFj0 .icon-1kp3fr + *:after {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMCwzLjAwNzQxOTg4IEMwLDEuMzQ2NDY3NzUgMS4zNDI1MjQxNSwwIDIuOTk5OTg1ODgsMCBMMTUuMTE2NjQ4MywwIEMxNy4wODA3MzU0LDAgMjQsNi45MTg4NTcyNSAyNCw4Ljg3NDU3NTkzIEwyNCwzMy4wMDM1NTc0IEMyNCwzNC42NTg0NDY5IDIyLjY1ODIyOTQsMzYgMjEuMDA4OTA5NiwzNiBMMi45OTEwOTA0MiwzNiBDMS4zMzkxNTY3OSwzNiAwLDM0LjY1NDQ2MDcgMCwzMi45OTI1ODAxIEwwLDMuMDA3NDE5ODggWiIgc3Ryb2tlPSIjNzI4OURBIiBmaWxsPSJub25lIi8+PHBhdGggZD0iTTE3LDEuMDk2NzczMzYgQzE3LDAuNTQyMDQwMzE2IDE3LjMxNDc5NjQsMC40MDcwOTc3OTEgMTcuNzEzMzExOCwwLjgwNTU2Mzc5IEwyMy4xOTUyMDMxLDYuMjg2Nzc2NTQgQzIzLjU4OTE1NDMsNi42ODA2Nzg5OCAyMy40NTUyMjc5LDcgMjIuOTAzOTU3NSw3IEwxOC4wMDQ1NTc0LDcgQzE3LjQ0OTc1NTcsNyAxNyw2LjU0Njc2OTE2IDE3LDUuOTk1NTY2OTggTDE3LDEuMDk2NzczMzYgWiIgc3Ryb2tlPSIjNzI4OURBIiBmaWxsPSJub25lIi8+PC9nPjwvZz48L2c+PC9nPjwvZz48L3N2Zz4=') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="acrobat"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIGQ9Ik0yLDkgTDEyLDkgTDEyLDEwIEwyLDEwIEwyLDkgWiBNMiw3IEwxMiw3IEwxMiw4IEwyLDggTDIsNyBaIE0yMC43MDc5MTQ3LDMxLjk5ODk0MTMgTDMuODgzMTU2MzQsMzEuOTk4MTQ3MyBMMi4wMTIwMDc2NCwzMS45OTg5NDEzIEMyLjAxMjAwNzY0LDI5LjQzMTg3OTggMS42MTEyOTIwMywyMy41Mjk0MTE4IDUuNDM5NTkwNiwyMy41Mjk0MTE4IEM5LjI2Nzg4OTE4LDIzLjUyOTQxMTggNy42NjMxNTcxNSwyNS44NDU1NjM0IDExLjY3MTU1OTYsMjguMDI4ODQ5MyBDMTEuNzIyMzUwMiwyOC4wNTYzNzUzIDExLjc3NDY5ODcsMjguMDgzMTA3MyAxMS44MjU4MDA5LDI4LjExMDYzMzIgTDExLjk5MDAxMzMsMjguMDI3MjYxMyBMMTIuMjU1ODA2NywyOC4xNjMzMDMxIEMxNS45OTMxMTg2LDI2LjMyMjc2ODUgMTQuNDg5NjU2LDIzLjUyOTQxMTggMTguNTI2NzI1NiwyMy41Mjk0MTE4IEMyMi42NTk3Njc0LDIzLjUyOTQxMTggMjEuOTU0MzA4NSwzMS45OTg5NDEzIDIxLjk1NDMwODUsMzEuOTk4OTQxMyBMMjAuNzA3OTE0NywzMS45OTg5NDEzIFogTTUuMjY2MDA2MzEsMjQuNTg4MTAzIEMyLjU1NDc2MDY3LDI0LjU4ODEwMyAzLjAzMjQyNzQ2LDMwLjk0MDI1MDEgMy4wMzI0Mjc0NiwzMC45NDAyNTAxIEw1LjYwNjQ2NzU0LDMwLjk0MDI1MDEgTDYuMDE4MDg0MjEsMzAuOTM4Mzk3NCBDNy4yNTc0MDEzOSwzMC4zODA5OTY1IDguODY5MDg4MDcsMjkuNjU5NzYzMSAxMC41NzY4MTg2LDI4LjkwNTQ0NTYgTDEwLjM5MjA2OTgsMjguODEyMDE2MSBMMTAuNTMyNDY2MSwyOC43NDI0MDcyIEM3LjM1OTE4ODc3LDI3LjEyMzQwMzcgNy45MzI4OTk0NSwyNC41ODgxMDMgNS4yNjYwMDYzMSwyNC41ODgxMDMgWiBNMTguNzcxODM3NywyNC41ODgxMDMgQzE2LjI2NzcwMzUsMjQuNTg4MTAzIDE2LjE0MjUxMjYsMjcuMzYzOTkxMyAxMy41NTQyODU1LDI4Ljc0MDgxOTIgTDEzLjcyMjc4NzQsMjguODI2MDQzOCBMMTMuNTUzMDIxLDI4LjkwOTY4MDQgQzE1LjE5NDA5NjcsMjkuNzAyNjQwMSAxNi44NTYzNTM3LDMwLjQwNTA4MTcgMTguMTk1ODMzMSwzMC45NDAyNTAxIEwxNS4yOTQzMTI2LDMwLjk0MDI1MDEgQzE1LjI5NDMxMjYsMzAuOTQwMjUwMSAxNC41MTUwMzA5LDMwLjU4NDI2NTIgMTIuMzExNTQ0NSwyOS41MjEzMzkyIEwxMi4xMzMyNDIzLDI5LjYwOTIxMDYgTDExLjk2MjIxMTMsMjkuNTIxODY4NiBDMTAuMDg3ODI1MywzMC40MjgxMDgzIDguOTgyOTIwNzQsMzAuOTM0OTU2NyA4Ljk3MzQzNjU4LDMwLjkzOTQ1NjEgTDE4LjIwMTUyMzYsMzAuOTQyNjMyMiBDMTguMTk5NjI2OCwzMC45NDE4MzgyIDE4LjE5NzcyOTksMzAuOTQxMDQ0MSAxOC4xOTU4MzMxLDMwLjk0MDI1MDEgTDIwLjk4NDgwODIsMzAuOTQwMjUwMSBDMjAuOTg0ODA4MiwzMC45NDAyNTAxIDIxLjMyNjIzNzksMjQuNTg4MTAzIDE4Ljc3MTgzNzcsMjQuNTg4MTAzIFogTTIsMTMgTDIyLDEzIEwyMiwxNCBMMiwxNCBMMiwxMyBaIE0yLDExIEwxMiwxMSBMMTIsMTIgTDIsMTIgTDIsMTEgWiBNMiwxNSBMMjIsMTUgTDIyLDE2IEwyLDE2IEwyLDE1IFogTTIsMTcgTDIyLDE3IEwyMiwxOCBMMiwxOCBMMiwxNyBaIE0yLDE5IEwyMiwxOSBMMjIsMjAgTDIsMjAgTDIsMTkgWiIgb3BhY2l0eT0iMC42IiBmaWxsPSIjNjk3RUM0Ii8+PC9nPjwvZz48L2c+PC9nPjwvZz48L3N2Zz4=') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="ae"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMTMsMyBMNC40OTcxMDEwNCwzIEMzLjY3MDI3NDk3LDMgMywzLjY2NTc5NzIzIDMsNC41IEwzLDYiIHN0cm9rZT0iI0M5RDJGMCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBvcGFjaXR5PSIwLjQiLz48L2c+PHRleHQgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiBpZD0iQWUiIG9wYWNpdHk9IjAuOCIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIGZvbnQtZmFtaWx5PSJTb3VyY2UgQ29kZSBQcm8iIGZvbnQtc2l6ZT0iMTIiIGZvbnQtd2VpZ2h0PSJib2xkIiBza2V0Y2g6YWxpZ25tZW50PSJtaWRkbGUiIGxpbmUtc3BhY2luZz0iMTgiIGxldHRlci1zcGFjaW5nPSItMC4zIiBmaWxsPSIjNjk3RUM0Ij48dHNwYW4geD0iNS4yNjkwMTQxIiB5PSIyNi40NzA1ODgyIj5BZTwvdHNwYW4+PC90ZXh0PjwvZz48L2c+PC9nPjwvZz48L3N2Zz4=') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="ai"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMTMsMyBMNC40OTcxMDEwNCwzIEMzLjY3MDI3NDk3LDMgMywzLjY2NTc5NzIzIDMsNC41IEwzLDYiIHN0cm9rZT0iI0M5RDJGMCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBvcGFjaXR5PSIwLjQiLz48L2c+PHRleHQgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiBpZD0iQWkiIG9wYWNpdHk9IjAuOCIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIGZvbnQtZmFtaWx5PSJTb3VyY2UgQ29kZSBQcm8iIGZvbnQtc2l6ZT0iMTIiIGZvbnQtd2VpZ2h0PSJib2xkIiBza2V0Y2g6YWxpZ25tZW50PSJtaWRkbGUiIGxpbmUtc3BhY2luZz0iMTgiIGxldHRlci1zcGFjaW5nPSItMC4zIiBmaWxsPSIjNjk3RUM0Ij48dHNwYW4geD0iNS4yNjkwMTQxIiB5PSIyNi40NzA1ODgyIj5BaTwvdHNwYW4+PC90ZXh0PjwvZz48L2c+PC9nPjwvZz48L3N2Zz4=') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="archive"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMTMsMyBMNC40OTcxMDEwNCwzIEMzLjY3MDI3NDk3LDMgMywzLjY2NTc5NzIzIDMsNC41IEwzLDYiIHN0cm9rZT0iI0M5RDJGMCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBvcGFjaXR5PSIwLjQiLz48ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHRyYW5zZm9ybT0idHJhbnNsYXRlKDEwLCAxNCkiIGZpbGw9IiM4NTk2Q0YiPjxnIGlkPSJHcm91cCI+PHBhdGggZD0iTTAsMCBMNCwwIEw0LDIyIEwwLDIyIEwwLDAgWiBNMiwyMSBMMSwyMSBMMSwyMCBMMiwyMCBMMiwyMSBaIE0zLDIwIEwyLDIwIEwyLDE5IEwzLDE5IEwzLDIwIFogTTIsMTkgTDEsMTkgTDEsMTggTDIsMTggTDIsMTkgWiBNMywxOCBMMiwxOCBMMiwxNyBMMywxNyBMMywxOCBaIE0yLDE3IEwxLDE3IEwxLDE2IEwyLDE2IEwyLDE3IFogTTMsMTYgTDIsMTYgTDIsMTUgTDMsMTUgTDMsMTYgWiBNMiwxNSBMMSwxNSBMMSwxNCBMMiwxNCBMMiwxNSBaIE0zLDE0IEwyLDE0IEwyLDEzIEwzLDEzIEwzLDE0IFogTTIsMTMgTDEsMTMgTDEsMTIgTDIsMTIgTDIsMTMgWiBNMywxMiBMMiwxMiBMMiwxMSBMMywxMSBMMywxMiBaIE0yLDExIEwxLDExIEwxLDEwIEwyLDEwIEwyLDExIFogTTMsMTAgTDIsMTAgTDIsOSBMMyw5IEwzLDEwIFogTTIsOSBMMSw5IEwxLDggTDIsOCBMMiw5IFogTTMsOCBMMiw4IEwyLDcgTDMsNyBMMyw4IFogTTIsNyBMMSw3IEwxLDYgTDIsNiBMMiw3IFogTTMsNiBMMiw2IEwyLDUgTDMsNSBMMyw2IFogTTIsNSBMMSw1IEwxLDQgTDIsNCBMMiw1IFogTTMsNCBMMiw0IEwyLDMgTDMsMyBMMyw0IFogTTIsMyBMMSwzIEwxLDIgTDIsMiBMMiwzIFogTTMsMiBMMiwyIEwyLDEgTDMsMSBMMywyIFoiLz48L2c+PC9nPjwvZz48L2c+PC9nPjwvZz48L2c+PC9zdmc+') center/cover no-repeat;
}
.audioMetadata-3zOuGv:before,
.attachment-33OFj0 .icon-1kp3fr[title="audio"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMjYiIGhlaWdodD0iMzgiIHZpZXdCb3g9Ii0yIDAgMjYgMzgiPjxnIGZpbGw9Im5vbmUiIGZpbGwtcnVsZT0iZXZlbm9kZCI+PHBhdGggc3Ryb2tlPSIjQzlEMkYwIiBzdHJva2Utd2lkdGg9IjIiIGQ9Ik0xNCw0IEw1LjUsNCBDNC43LDQgNCw0LjcgNCw1LjUgTDQsNyIgb3BhY2l0eT0iLjQiIHN0cm9rZS1saW5lY2FwPSJyb3VuZCIgc3Ryb2tlLWxpbmVqb2luPSJyb3VuZCIvPjxwYXRoIGZpbGw9IiM4NTk2Q0YiIGZpbGwtcnVsZT0ibm9uemVybyIgb3BhY2l0eT0iMC44IiBkPSJNMTIuNiwxNy43IEwxMi42LDI0LjQgQzEyLjIsMjQuMyAxMS45LDI0LjIgMTEuNSwyNC4yIEM5LjcsMjQuMiA4LjMsMjUuNiA4LjMsMjcuNCBDOC4zLDI5LjIgOS43LDMwLjYgMTEuNSwzMC42IEMxMy4zLDMwLjYgMTQuNywyOS4yIDE0LjcsMjcuNCBMMTQuNywxOS44IEwxNy42LDE5LjggTDE3LjYsMTcuNiBMMTIuNiwxNy42IEwxMi42LDE3LjcgWiIvPjwvZz48L3N2Zz4=') !important;
}
.attachment-33OFj0 .icon-1kp3fr[title="code"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMTMsMyBMNC40OTcxMDEwNCwzIEMzLjY3MDI3NDk3LDMgMywzLjY2NTc5NzIzIDMsNC41IEwzLDYiIHN0cm9rZT0iI0M5RDJGMCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBvcGFjaXR5PSIwLjQiLz48L2c+PHRleHQgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiBpZD0ie30iIG9wYWNpdHk9IjAuOCIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIGZvbnQtZmFtaWx5PSJTb3VyY2UgQ29kZSBQcm8iIGZvbnQtc2l6ZT0iMTIiIGZvbnQtd2VpZ2h0PSI0MjAiIHNrZXRjaDphbGlnbm1lbnQ9Im1pZGRsZSIgbGluZS1zcGFjaW5nPSIxOCIgbGV0dGVyLXNwYWNpbmc9Ii0wLjMiIGZpbGw9IiM2OTdFQzQiPjx0c3BhbiB4PSI1LjI2OTAxNDEiIHk9IjI2LjQ3MDU4ODIiPnt9PC90c3Bhbj48L3RleHQ+PC9nPjwvZz48L2c+PC9nPjwvc3ZnPg==') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="document"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnPjxwYXRoIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgZD0iTTIsOSBMMTIsOSBMMTIsMTAgTDIsMTAgTDIsOSBaIE0yLDcgTDEyLDcgTDEyLDggTDIsOCBMMiw3IFogTTIsMTMgTDIyLDEzIEwyMiwxNCBMMiwxNCBMMiwxMyBaIE0yLDExIEwxMiwxMSBMMTIsMTIgTDIsMTIgTDIsMTEgWiBNMiwxNSBMMjIsMTUgTDIyLDE2IEwyLDE2IEwyLDE1IFogTTIsMTcgTDIyLDE3IEwyMiwxOCBMMiwxOCBMMiwxNyBaIE0yLDE5IEwyMiwxOSBMMjIsMjAgTDIsMjAgTDIsMTkgWiBNMiwyMSBMMjIsMjEgTDIyLDIyIEwyLDIyIEwyLDIxIFogTTIsMjMgTDIyLDIzIEwyMiwyNCBMMiwyNCBMMiwyMyBaIE0yLDI1IEwyMiwyNSBMMjIsMjYgTDIsMjYgTDIsMjUgWiBNMiwyNyBMMjIsMjcgTDIyLDI4IEwyLDI4IEwyLDI3IFogTTIsMjkgTDIyLDI5IEwyMiwzMCBMMiwzMCBMMiwyOSBaIE0yLDMxIEwyMiwzMSBMMjIsMzIgTDIsMzIgTDIsMzEgWiIgb3BhY2l0eT0iMC42IiBmaWxsPSIjNjk3RUM0Ii8+PC9nPjwvZz48L2c+PC9nPjwvZz48L3N2Zz4=') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="photoshop"] + *:before,
.attachment-33OFj0 .icon-1kp3fr[title="ps"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMTMsMyBMNC40OTcxMDEwNCwzIEMzLjY3MDI3NDk3LDMgMywzLjY2NTc5NzIzIDMsNC41IEwzLDYiIHN0cm9rZT0iI0M5RDJGMCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBvcGFjaXR5PSIwLjQiLz48L2c+PHRleHQgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiBpZD0iUHMiIG9wYWNpdHk9IjAuOCIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIGZvbnQtZmFtaWx5PSJTb3VyY2UgQ29kZSBQcm8iIGZvbnQtc2l6ZT0iMTIiIGZvbnQtd2VpZ2h0PSJib2xkIiBza2V0Y2g6YWxpZ25tZW50PSJtaWRkbGUiIGxpbmUtc3BhY2luZz0iMTgiIGxldHRlci1zcGFjaW5nPSItMC4zIiBmaWxsPSIjNjk3RUM0Ij48dHNwYW4geD0iNS4yNjkwMTQxIiB5PSIyNi40NzA1ODgyIj5QczwvdHNwYW4+PC90ZXh0PjwvZz48L2c+PC9nPjwvZz48L3N2Zz4=') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="sketch"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMTMsMyBMNC40OTcxMDEwNCwzIEMzLjY3MDI3NDk3LDMgMywzLjY2NTc5NzIzIDMsNC41IEwzLDYiIHN0cm9rZT0iI0M5RDJGMCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBvcGFjaXR5PSIwLjQiLz48cGF0aCB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIGQ9Ik0xOCwxOS44NzYxNDY4IEwxMiwyOCBMNiwxOS44NzYxNDY4IEw4LjkwOTA5MDkxLDE3IEwxNS4wOTA5MDkxLDE3IEwxOCwxOS44NzYxNDY4IFoiIHN0cm9rZT0iIzg1OTZDRiIgZmlsbD0ibm9uZSIvPjwvZz48L2c+PC9nPjwvZz48L2c+PC9zdmc+') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="spreadsheet"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnPjxwYXRoIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgZD0iTTIsMTIgTDcsMTIgTDcsMTQgTDIsMTQgTDIsMTIgWiBNMiw0IEw3LDQgTDcsNiBMMiw2IEwyLDQgWiBNMiw4IEw3LDggTDcsMTAgTDIsMTAgTDIsOCBaIE05LDEyIEwxNCwxMiBMMTQsMTQgTDksMTQgTDksMTIgWiBNOSw0IEwxNCw0IEwxNCw2IEw5LDYgTDksNCBaIE05LDggTDE0LDggTDE0LDEwIEw5LDEwIEw5LDggWiBNMTYsMTIgTDIxLDEyIEwyMSwxNCBMMTYsMTQgTDE2LDEyIFogTTIsMTYgTDcsMTYgTDcsMTggTDIsMTggTDIsMTYgWiBNOSwxNiBMMTQsMTYgTDE0LDE4IEw5LDE4IEw5LDE2IFogTTE2LDE2IEwyMSwxNiBMMjEsMTggTDE2LDE4IEwxNiwxNiBaIE0yLDIwIEw3LDIwIEw3LDIyIEwyLDIyIEwyLDIwIFogTTksMjAgTDE0LDIwIEwxNCwyMiBMOSwyMiBMOSwyMCBaIE0xNiwyMCBMMjEsMjAgTDIxLDIyIEwxNiwyMiBMMTYsMjAgWiBNMiwyNCBMNywyNCBMNywyNiBMMiwyNiBMMiwyNCBaIE05LDI0IEwxNCwyNCBMMTQsMjYgTDksMjYgTDksMjQgWiBNMTYsMjQgTDIxLDI0IEwyMSwyNiBMMTYsMjYgTDE2LDI0IFogTTIsMjggTDcsMjggTDcsMzAgTDIsMzAgTDIsMjggWiBNOSwyOCBMMTQsMjggTDE0LDMwIEw5LDMwIEw5LDI4IFogTTE2LDI4IEwyMSwyOCBMMjEsMzAgTDE2LDMwIEwxNiwyOCBaIiBvcGFjaXR5PSIwLjYiIGZpbGw9IiM2OTdFQzQiLz48L2c+PC9nPjwvZz48L2c+PC9nPjwvc3ZnPg==') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="unknown"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMTMsMyBMNC40OTcxMDEwNCwzIEMzLjY3MDI3NDk3LDMgMywzLjY2NTc5NzIzIDMsNC41IEwzLDYiIHN0cm9rZT0iI0M5RDJGMCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBvcGFjaXR5PSIwLjQiLz48L2c+PC9nPjwvZz48L2c+PC9nPjwvc3ZnPg==') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="video"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMTMsMyBMNC40OTcxMDEwNCwzIEMzLjY3MDI3NDk3LDMgMywzLjY2NTc5NzIzIDMsNC41IEwzLDYiIHN0cm9rZT0iI0M5RDJGMCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBvcGFjaXR5PSIwLjQiLz48L2c+PHRleHQgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiBpZD0idmlkZW8iIHRyYW5zZm9ybT0idHJhbnNsYXRlKDMsMCkiIG9wYWNpdHk9IjAuOCIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIGZvbnQtZmFtaWx5PSJTb3VyY2UgQ29kZSBQcm8iIGZvbnQtc2l6ZT0iMTIiIGZvbnQtd2VpZ2h0PSI0MjAiIHNrZXRjaDphbGlnbm1lbnQ9Im1pZGRsZSIgbGluZS1zcGFjaW5nPSIxOCIgbGV0dGVyLXNwYWNpbmc9Ii0wLjMiIGZpbGw9IiM2OTdFQzQiPjx0c3BhbiB4PSI1LjI2OTAxNDEiIHk9IjI2LjQ3MDU4ODIiPiYjeDI1YjY7PC90c3Bhbj48L3RleHQ+PC9nPjwvZz48L2c+PC9nPjwvc3ZnPg==') center/cover no-repeat;
}
.attachment-33OFj0 .icon-1kp3fr[title="webcode"] + *:before {
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjQwcHgiIHZpZXdCb3g9IjAgMCAyOCA0MCIgdmVyc2lvbj0iMS4xIj48ZyBzdHJva2U9Im5vbmUiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDcwLCAtNTI0KSI+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDA0LCA1MjYpIj48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg2OCwgMCkiPjxnIHN0cm9rZS13aWR0aD0iMS41Ij48cGF0aCBkPSJNMTMsMyBMNC40OTcxMDEwNCwzIEMzLjY3MDI3NDk3LDMgMywzLjY2NTc5NzIzIDMsNC41IEwzLDYiIHN0cm9rZT0iI0M5RDJGMCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBvcGFjaXR5PSIwLjQiLz48L2c+PHRleHQgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiBpZD0iLyZndDsiIG9wYWNpdHk9IjAuOCIgeG1sbnM6c2tldGNoPSJodHRwOi8vd3d3LmJvaGVtaWFuY29kaW5nLmNvbS9za2V0Y2gvbnMiIGZvbnQtZmFtaWx5PSJTb3VyY2UgQ29kZSBQcm8iIGZvbnQtc2l6ZT0iMTIiIGZvbnQtd2VpZ2h0PSJib2xkIiBza2V0Y2g6YWxpZ25tZW50PSJtaWRkbGUiIGxpbmUtc3BhY2luZz0iMTgiIGxldHRlci1zcGFjaW5nPSItMC4zIiBmaWxsPSIjNjk3RUM0Ij48dHNwYW4geD0iNS4xMTkwMTQwOSIgeT0iMjYuNDcwNTg4MiI+LzwvdHNwYW4+PHRzcGFuIHg9IjEyLjAxOTAxNDEiIHk9IjI2LjQ3MDU4ODIiPiZndDs8L3RzcGFuPjwvdGV4dD48L2c+PC9nPjwvZz48L2c+PC9zdmc+') center/cover no-repeat;
}

/*8.c. Keyboard Shortcuts Modal*/
.keyboardShortcutsModal-3piNz7 {
	background:var(--backdropblurred) !important;
	background-size:cover  !important;
	background-repeat: no-repeat !important;
	background-attachment: fixed !important;
}
.ragingDemon-bDcoXE img[src="/assets/bb7f752540c7f4c7039c6dd6b5dd052e.svg"] {
	box-sizing: border-box !important;
	padding-right: 80vw !important;
}
.ragingDemon-bDcoXE img[src="/assets/bb7f752540c7f4c7039c6dd6b5dd052e.svg"],
.ragingDemon-bDcoXE .symbol-3ffeCr:before,
.ragingDemon-bDcoXE .symbol-3ffeCr:after {
	width: 80vw !important;
	height: 60vh !important;
}
.ragingDemon-bDcoXE .symbol-3ffeCr:before,
.ragingDemon-bDcoXE .symbol-3ffeCr:after {
	content: "";
	position: absolute;
}
.ragingDemon-bDcoXE .symbol-3ffeCr:before {
	background: var(--main-color) !important;
	-webkit-mask-size: cover;
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMzYwIiBoZWlnaHQ9IjI4MCI+PGcgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48cGF0aCBmaWxsPSIjNzI4OURBIiBkPSJNNzMuNTA2MiAzNC42NTE3czUuMzg1IDMwLjY5MyAzNi44NTYgMjcuNTQyYzMwLjE0NC0zLjAxNyA2MC4zOC0xMC41NzQgOTQuMTQ0LTEwLjU0MiAyOCAuMDI3IDU3Ljc0MiAxMS40MDMgNjAuNjc3LTguMzgzIDIuNjI1LTE3LjY5Ni0xMC4yNzItMzUuMjY5LTQ2LjIyNi0zNS4yNjlzLTg1LjExNSAxNS40ODQtMTA2LjM5NCAxOS43ODVjLTIxLjI3OCA0LjMwMS0zOS4wNTcgNi44NjctMzkuMDU3IDYuODY3Ii8+PHBhdGggZmlsbD0iIzcyODlEQSIgZD0iTTEyNy4yMzg3IDExNS44NDAzbDIuMjAxLTEwLjI1MXMtMTUuODM3LTQuMy04LjgwNS0yMC41MDFjNS44NzItMTMuNTI2IDQ1LjQ5My0xNS43NyA1OC43LTcuMDk2IDEzLjIwOCA4LjY3MyAxMy45NDEgMjEuMjg5IDEzLjk0MSAyMS4yODlzMTA3LjEyOC0xOC4xMzUgMTE4LjEzNCAxOC45MjVjMTEuMDA2IDM3LjA1OS0yNy4xNDkgMjIuMDc4LTU0LjI5OCAyMi4wNzgtMjcuMTQ4IDAtNDQuMDI0IDMuOTQyLTQ0LjAyNCAzLjk0MnM1MC42MjggMTguOTI1IDgyLjkxMyAzOS40MjYgNzAuODQ2IDQ3LjU5NCA0Ny42OTQgNzcuMjc0Yy0yMy4xODggMjkuNzI1LTU0LjU4LTIuNDEtOTYuMTIxLTMwLjc1Mi01Mi4wNjctMzUuNTIzLTc0LjA2Ny00Ny41MjMtNzQuMDY3LTQ3LjUyM3MtMTkgNDEtNDUgNjYuMjI2Yy0zNS4xNDkgMzQuMS05MC43ODUgMjkuMzk2LTExOS40MDItMjQuMjIzIDAgMCAzMi41MzIuMTMzIDU1Ljc2NS0xNC45ODEgMjUuNjM3LTE2LjY3NyA0Mi41NTgtNDEuNzkxIDQyLjU1OC00MS43OTFzLTUzLjU2NCAyOS45NjMtODAuNzEzIDEwLjI1Yy0yNy4xNDgtMTkuNzEyLTIxLjI3OC0yNy41OTgtNC40MDItMzEuNTQgMTQuNS0zLjM4OCAxMDQuOTI2LTMwLjc1MiAxMDQuOTI2LTMwLjc1MiIvPjxwYXRoIGZpbGw9IiMzNjM5M0UiIGQ9Ik0xMjcuMjM4NyAxMTUuODQwM2wtNS43MzIgMTYuOTc2Ii8+PHBhdGggZmlsbD0iIzM2MzkzRSIgZD0iTTIxMy4wODczIDE0NC4yMjY3bC02LjU4MSAxLjQ4NSIvPjxwYXRoIGQ9Ik0wIDBoMzYwdjI4MEgweiIvPjwvZz48L3N2Zz4=') center/contain no-repeat !important;
}
.ragingDemon-bDcoXE .symbol-3ffeCr:after {
	background: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMzYwIiBoZWlnaHQ9IjI4MCI+PGcgZmlsbD0ibm9uZSIgZmlsbC1ydWxlPSJldmVub2RkIj48cGF0aCBzdHJva2U9IiMyMzFGMUYiIHN0cm9rZS13aWR0aD0iNiIgZD0iTTczLjUwNjIgMzQuNjUxN3M1LjM4NSAzMC42OTMgMzYuODU2IDI3LjU0MmMzMC4xNDQtMy4wMTcgNjAuMzgtMTAuNTc0IDk0LjE0NC0xMC41NDIgMjggLjAyNyA1Ny43NDIgMTEuNDAzIDYwLjY3Ny04LjM4MyAyLjYyNS0xNy42OTYtMTAuMjcyLTM1LjI2OS00Ni4yMjYtMzUuMjY5cy04NS4xMTUgMTUuNDg0LTEwNi4zOTQgMTkuNzg1Yy0yMS4yNzggNC4zMDEtMzkuMDU3IDYuODY3LTM5LjA1NyA2Ljg2N3oiIHN0cm9rZS1saW5lY2FwPSJyb3VuZCIgc3Ryb2tlLWxpbmVqb2luPSJyb3VuZCIgc3Ryb2tlLWRhc2hhcnJheT0iMjYwIDI5Ii8+PHBhdGggc3Ryb2tlPSIjMjMxRjFGIiBzdHJva2Utd2lkdGg9IjYiIGQ9Ik0xMjcuMjM4NyAxMTUuODQwM2wyLjIwMS0xMC4yNTFzLTE1LjgzNy00LjMtOC44MDUtMjAuNTAxYzUuODcyLTEzLjUyNiA0NS40OTMtMTUuNzcgNTguNy03LjA5NiAxMy4yMDggOC42NzMgMTMuOTQxIDIxLjI4OSAxMy45NDEgMjEuMjg5czEwNy4xMjgtMTguMTM1IDExOC4xMzQgMTguOTI1YzExLjAwNiAzNy4wNTktMjcuMTQ5IDIyLjA3OC01NC4yOTggMjIuMDc4LTI3LjE0OCAwLTQ0LjAyNCAzLjk0Mi00NC4wMjQgMy45NDJzNTAuNjI4IDE4LjkyNSA4Mi45MTMgMzkuNDI2IDcwLjg0NiA0Ny41OTQgNDcuNjk0IDc3LjI3NGMtMjMuMTg4IDI5LjcyNS01NC41OC0yLjQxLTk2LjEyMS0zMC43NTItNTIuMDY3LTM1LjUyMy03NC4wNjctNDcuNTIzLTc0LjA2Ny00Ny41MjNzLTE5IDQxLTQ1IDY2LjIyNmMtMzUuMTQ5IDM0LjEtOTAuNzg1IDI5LjM5Ni0xMTkuNDAyLTI0LjIyMyAwIDAgMzIuNTMyLjEzMyA1NS43NjUtMTQuOTgxIDI1LjYzNy0xNi42NzcgNDIuNTU4LTQxLjc5MSA0Mi41NTgtNDEuNzkxcy01My41NjQgMjkuOTYzLTgwLjcxMyAxMC4yNWMtMjcuMTQ4LTE5LjcxMi0yMS4yNzgtMjcuNTk4LTQuNDAyLTMxLjU0IDE0LjUtMy4zODggMTA0LjkyNi0zMC43NTIgMTA0LjkyNi0zMC43NTJ6IiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIHN0cm9rZS1kYXNoYXJyYXk9IjUxMCAyMCIvPjxwYXRoIGZpbGw9IiMzNjM5M0UiIGQ9Ik0xMjcuMjM4NyAxMTUuODQwM2wtNS43MzIgMTYuOTc2Ii8+PHBhdGggc3Ryb2tlPSIjMjMxRjFGIiBzdHJva2Utd2lkdGg9IjYiIGQ9Ik0xMjcuMjM4NyAxMTUuODQwM2wtNS43MzIgMTYuOTc2IiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIHN0cm9rZS1kYXNoYXJyYXk9IjUwMCAyMCIvPjxwYXRoIHN0cm9rZT0iIzIzMUYxRiIgc3Ryb2tlLXdpZHRoPSI2IiBkPSJNMTc3LjUwNjIgMTcxLjcyNzJzNi0xMi4wNDUgMTEtMzEuMzg4IiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIHN0cm9rZS1kYXNoYXJyYXk9IjIzIDEwIi8+PHBhdGggZmlsbD0iIzM2MzkzRSIgZD0iTTIxMy4wODczIDE0NC4yMjY3bC02LjU4MSAxLjQ4NSIvPjxwYXRoIHN0cm9rZT0iIzIzMUYxRiIgc3Ryb2tlLXdpZHRoPSI2IiBkPSJNMjEzLjA4NzMgMTQ0LjIyNjdsLTYuNTgxIDEuNDg1IiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIHN0cm9rZS1kYXNoYXJyYXk9IjUwMCAyMCIvPjxwYXRoIGQ9Ik0wIDBoMzYwdjI4MEgweiIvPjwvZz48L3N2Zz4=') center/contain no-repeat !important;
}
.ddrArrows-lSnH7P .arrow-2enltQ.down-2Ju7Q_ {
	transform: rotate(270deg);
}
.ddrArrows-lSnH7P .arrow-2enltQ.up-fkTose {
	transform: rotate(90deg);
}
.ddrArrows-lSnH7P .arrow-2enltQ.right-1AEPK3 {
	transform: rotate(180deg);
}
.ddrArrows-lSnH7P .arrow-2enltQ.active-2X6Ewx {
	filter: brightness(130%);
}
.ddrArrows-lSnH7P .arrow-2enltQ,
.ddrArrows-lSnH7P .arrow-2enltQ:before,
.ddrArrows-lSnH7P .arrow-2enltQ:after {
	height: 50px !important;
	width: 50px !important;
}
.ddrArrows-lSnH7P .arrow-2enltQ:before,
.ddrArrows-lSnH7P .arrow-2enltQ:after {
	content: "";
	position: absolute;
	top: 0;
	left: 0;
}
.ddrArrows-lSnH7P .arrow-2enltQ {
	position: relative !important;
	animation: none !important;
	background: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iNTAiIGhlaWdodD0iNTAiPjxnIGZpbGw9Im5vbmUiIGZpbGwtcnVsZT0iZXZlbm9kZCI+PHBhdGggZmlsbD0iI0ZGRiIgZD0iTTMuMjIzOCAyMi40NDE5bC0xLjIyNCAxLjIyNHYyLjY0MWwxLjIyNCAxLjIyNCA0LjQzOCA0LjQzOCAxNy4wMzEgMTcuMDMxaDQuOTc4bDMuNDc4LTMuNTg5LjAxMi00LjY5LTguNTMyLTguNTMxaDE3LjYwMWwzLjkzMi0zLjkzMyAyLjM2Ni0yLjM2NXYtMS43OTdsLTYuMjk4LTYuMjk5aC0xNy41ODdsOC41MTgtOC41MTctLjAxMi00LjY4OS0zLjQ3OC0zLjU5aC00Ljk3OCIvPjxwYXRoIHN0cm9rZT0iI0ZGRiIgc3Ryb2tlLXdpZHRoPSIyIiBkPSJNMy4yMjM4IDIyLjQ0MTlsLTEuMjI0IDEuMjI0djIuNjQxbDEuMjI0IDEuMjI0IDQuNDM4IDQuNDM4IDE3LjAzMSAxNy4wMzFoNC45NzhsMy40NzgtMy41ODkuMDEyLTQuNjktOC41MzItOC41MzFoMTcuNjAxbDMuOTMyLTMuOTMzIDIuMzY2LTIuMzY1di0xLjc5N2wtNi4yOTgtNi4yOTloLTE3LjU4N2w4LjUxOC04LjUxNy0uMDEyLTQuNjg5LTMuNDc4LTMuNTloLTQuOTc4eiIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIi8+PHBhdGggZmlsbD0iI0ZGRiIgZD0iTTEwLjIwNjEgMjAuNTQ4NGwtNC40MzggNC40MzggNC40MzggNC40MzggMTQuMzY3IDE0LjM2N2gzLjU5OHYtMi45N2wtOC42MzYtOC42MzZ2LTIuMzA4bC00LjE3MS00LjE3MXYtMS40NGw0LjE3MS00LjE3MXYtMi4zMDhsOC42MzYtOC42MzZ2LTIuOTdoLTMuNTk4Ii8+PHBhdGggZmlsbD0iI0ZGRiIgZD0iTTE3LjE2MjggMjQuMjczNHYxLjQzOWwyLjg3OSAyLjg3OWgxMC4yNTVsLTIuODc5LTIuODc5di0xLjQzOWwyLjg3OS0yLjg3OWgtMTAuMjU1Ii8+PHBhdGggZmlsbD0iI0ZGRiIgZD0iTTI5LjI3NzIgMjQuMjczNHYxLjQzOWwyLjQzMiAyLjQzMy40NDcuNDQ2aDcuODYzbDIuODc5LTIuODc5di0xLjQzOWwtMi44NzktMi44NzloLTcuODYzbC0uNDQ3LjQ0NyIvPjxwYXRoIGQ9Ik0wIDBoNTB2NTBIMHoiLz48cGF0aCBkPSJNMCAxMDBoNTB2NTBIMHoiLz48L2c+PC9zdmc+') center/contain no-repeat !important;
}
.ddrArrows-lSnH7P .arrow-2enltQ:before {
	-webkit-mask-size: cover;
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iNTAiIGhlaWdodD0iNTAiPjxnIGZpbGw9Im5vbmUiIGZpbGwtcnVsZT0iZXZlbm9kZCI+PHBhdGggb3BhY2l0eT0iLjYiIGZpbGw9IiNDNkQ4RjUiIGQ9Ik0zLjIyMzggMjIuNDQxOWwtMS4yMjQgMS4yMjR2Mi42NDFsMS4yMjQgMS4yMjQgNC40MzggNC40MzggMTcuMDMxIDE3LjAzMWg0Ljk3OGwzLjQ3OC0zLjU4OS4wMTItNC42OS04LjUzMi04LjUzMWgxNy42MDFsMy45MzItMy45MzMgMi4zNjYtMi4zNjV2LTEuNzk3bC02LjI5OC02LjI5OWgtMTcuNTg3bDguNTE4LTguNTE3LS4wMTItNC42ODktMy40NzgtMy41OWgtNC45NzgiLz48cGF0aCBzdHJva2U9IiMyRjQ3NzciIHN0cm9rZS13aWR0aD0iMiIgZD0iTTMuMjIzOCAyMi40NDE5bC0xLjIyNCAxLjIyNHYyLjY0MWwxLjIyNCAxLjIyNCA0LjQzOCA0LjQzOCAxNy4wMzEgMTcuMDMxaDQuOTc4bDMuNDc4LTMuNTg5LjAxMi00LjY5LTguNTMyLTguNTMxaDE3LjYwMWwzLjkzMi0zLjkzMyAyLjM2Ni0yLjM2NXYtMS43OTdsLTYuMjk4LTYuMjk5aC0xNy41ODdsOC41MTgtOC41MTctLjAxMi00LjY4OS0zLjQ3OC0zLjU5aC00Ljk3OHoiIHN0cm9rZS1saW5lY2FwPSJyb3VuZCIgc3Ryb2tlLWxpbmVqb2luPSJyb3VuZCIvPjwvZz48L3N2Zz4=') center/contain no-repeat !important;
	background: var(--main-color) !important;
}
.ddrArrows-lSnH7P .arrow-2enltQ:after {
	background: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iNTAiIGhlaWdodD0iNTAiPjxnIGZpbGw9Im5vbmUiIGZpbGwtcnVsZT0iZXZlbm9kZCI+PHBhdGggZmlsbD0iI0ZGRiIgZD0iTTEwLjIwNjEgMjAuNTQ4NGwtNC40MzggNC40MzggNC40MzggNC40MzggMTQuMzY3IDE0LjM2N2gzLjU5OHYtMi45N2wtOC42MzYtOC42MzZ2LTIuMzA4bC00LjE3MS00LjE3MXYtMS40NGw0LjE3MS00LjE3MXYtMi4zMDhsOC42MzYtOC42MzZ2LTIuOTdoLTMuNTk4Ii8+PHBhdGggZmlsbD0iI0ZGRiIgZD0iTTE3LjE2MjggMjQuMjczNHYxLjQzOWwyLjg3OSAyLjg3OWgxMC4yNTVsLTIuODc5LTIuODc5di0xLjQzOWwyLjg3OS0yLjg3OWgtMTAuMjU1Ii8+PHBhdGggZmlsbD0iI0ZGRiIgZD0iTTI5LjI3NzIgMjQuMjczNHYxLjQzOWwyLjQzMiAyLjQzMy40NDcuNDQ2aDcuODYzbDIuODc5LTIuODc5di0xLjQzOWwtMi44NzktMi44NzloLTcuODYzbC0uNDQ3LjQ0NyIvPjxwYXRoIGQ9Ik0wIDBoNTB2NTBIMHoiLz48L2c+PC9zdmc+') center/contain no-repeat !important;
}

/*8.d. Quick Switcher*/
.quickswitcher-3JagVE {
	background:var(--backdropblurred) !important;
	background-size:cover  !important;
	background-repeat: no-repeat !important;
	background-attachment: fixed !important;
}
.input-2VB9rf {
	background:rgba(0,0,0,0.75) !important;
}
.resultFocused-3aIoYe {
	background:rgba(0,0,0,0.5) !important;
}

/*8.e. Screenshare Modal*/
.tiles-2aXG_k {
	background:transparent !important;
	box-shadow:none !important;
}
.imageSelected-4Kl81J {
	border-radius:5px !important;
	border-color:var(--hover-color) !important;
}
.selectorButtonSelected-1j4DmC {
	background:var(--main-color) !important;
}

/*8.f. Add/Create Guilds Modal*/
.header-3ZP1MY,
.actionHeader-2CT5c7,
.or-3THJsp,
.title-2Dc-Cb,
.sampleLink-KPFu3I,
.regionSelectModalHeader-21khC1,
.lookLink-9FtZy-.colorBrand-3pXr91 {
	color:var(--hover-color) !important;
}
.wrapper-2ZbzR9 {
	background:transparent !important;
}
.footer-2yfCgX {
	background:rgba(0,0,0,0.25) !important;
	box-shadow:none !important
}
.input-1mgnkM,
.input-UJ9Tr3 {
	border-color:var(--hover-color) !important;
}
.action-1lSjCi,
.or-3THJsp {
	background:transparent !important;
	box-shadow:none !important;
	border:none !important;
}
.create-3jownz .actionIcon-2IISM_ {
	-webkit-mask-size: cover;
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgdmlld0JveD0iLTI5MCAzODIgNDAgMzAiIHZlcnNpb249IjEuMSI+PHBhdGggZD0iTS0yNzMsNDA5LjVMLTI3Myw0MDkuNWMtNC4xLDAtNi44LTAuNi03LjktMS43Yy0wLjUtMC42LTAuNi0xLjEtMC42LTEuM2MwLTAuNywwLjEtMi45LDAuNi0zLjhjMC4xLTAuMywwLjUtMSw0LjUtMi40Yy0xLjYtMS40LTIuNi00LTIuNi03LjFjMC00LjIsMi4zLTcsNS45LTcuMWwwLjEsMGMzLjYsMC4xLDUuOSwyLjgsNS45LDcuMWMwLDMuMS0xLDUuNy0yLjYsNy4xYzQsMS40LDQuNCwyLjEsNC41LDIuNGMwLjQsMC45LDAuNSwzLjEsMC42LDMuOGMwLDAuMiwwLDAuNy0wLjYsMS4zQy0yNjYuMyw0MDguOS0yNjguOSw0MDkuNS0yNzMsNDA5LjV6IE0tMjczLDQwNy41TC0yNzMsNDA3LjVjNS4xLDAsNi4yLTAuOSw2LjQtMS4xYy0wLjEtMS4xLTAuMi0yLjMtMC4zLTIuN2MtMC42LTAuNC0yLjktMS4zLTQuOC0xLjlsLTAuNy0wLjJsLTAuMS0ybDAuNy0wLjNjMS43LTAuNiwyLjgtMy4xLDIuOC02LjFjMC0zLjEtMS41LTUtMy45LTUuMWMtMi41LDAtNCwyLTQsNS4xYzAsMywxLjEsNS41LDIuOCw2LjFsMC43LDAuM2wtMC4xLDJsLTAuNywwLjJjLTEuOSwwLjYtNC4yLDEuNS00LjgsMS45Yy0wLjEsMC40LTAuMywxLjYtMC4zLDIuN0MtMjc5LjIsNDA2LjYtMjc4LDQwNy41LTI3Myw0MDcuNXoiLz48ZyBvcGFjaXR5PSIwLjYiPjxwYXRoIGNsYXNzPSJzdDAiIGQ9Ik0tMjU3LDQwMi44YzAtMC43LTAuMS0yLjktMC42LTMuOGMtMC4xLTAuMy0wLjUtMS00LjUtMi40YzEuNi0xLjQsMi42LTQsMi42LTcuMWMwLTQuMi0yLjMtNy01LjktNy4xbC0wLjEsMGMtMS45LDAtMy41LDAuOC00LjUsMi4yYzAuNiwwLjMsMS4yLDAuNiwxLjgsMWMwLjctMC44LDEuNi0xLjMsMi44LTEuM2MyLjQsMCwzLjksMiwzLjksNS4xYzAsMy0xLjEsNS41LTIuOCw2LjFsLTAuNywwLjNsMC4xLDJsMC43LDAuMmMxLjksMC42LDQuMywxLjUsNC44LDEuOWMwLjEsMC40LDAuMywxLjYsMC4zLDIuN2MtMC4yLDAuMi0xLDAuOC0zLjgsMWMwLjEsMC42LDAuMiwxLjIsMC4yLDJjMi41LTAuMiw0LjItMC44LDUtMS42Qy0yNTcsNDAzLjUtMjU3LDQwMy0yNTcsNDAyLjh6Ii8+PHBhdGggZD0iTS0yODcsNDAyLjdjMC4xLTEuMSwwLjItMi4zLDAuMy0yLjdjMC42LTAuNCwyLjktMS4zLDQuOC0xLjlsMC43LTAuMmwwLjEtMmwtMC43LTAuM2MtMS42LTAuNi0yLjgtMy4xLTIuOC02LjFjMC0zLjEsMS41LTUsNC01LjFjMS4yLDAsMi4xLDAuNSwyLjgsMS4zYzAuNS0wLjQsMS4xLTAuOCwxLjgtMWMtMS0xLjQtMi42LTIuMi00LjUtMi4ybC0wLjEsMGMtMy42LDAtNS45LDIuOC01LjksNy4xYzAsMy4xLDEsNS43LDIuNiw3LjFjLTQsMS40LTQuNCwyLjEtNC41LDIuNGMtMC40LDAuOS0wLjUsMy4xLTAuNiwzLjhjMCwwLjIsMCwwLjcsMC42LDEuM2MwLjgsMC45LDIuNSwxLjQsNS4xLDEuNmMwLTAuNywwLjEtMS40LDAuMi0yQy0yODYsNDAzLjUtMjg2LjgsNDAyLjktMjg3LDQwMi43eiIvPjwvZz48cGF0aCB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIGQ9Ik0tMjYwLDM4NyBsNCwwIGwwLC00IGwyLDAgbDAsNCBsNCwwIGwwLDIgbC00LDAgbDAsNCBsLTIsMCBsMCwtNCBsLTQsMCBsMCwtMiIvPjwvc3ZnPg==') 58% no-repeat !important;
	background: var(--main-color) !important;
}
.join-33Tr-7 .actionIcon-2IISM_ {
	-webkit-mask-size: cover;
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgdmlld0JveD0iLTMzMCAzODIgODAgMzAiIHZlcnNpb249IjEuMSI+PHBhdGggeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiBkPSJNLTI3Myw0MDkuNUwtMjczLDQwOS41Yy00LjEsMC02LjgtMC42LTcuOS0xLjdjLTAuNS0wLjYtMC42LTEuMS0wLjYtMS4zYzAtMC43LDAuMS0yLjksMC42LTMuOGMwLjEtMC4zLDAuNS0xLDQuNS0yLjRjLTEuNi0xLjQtMi42LTQtMi42LTcuMWMwLTQuMiwyLjMtNyw1LjktNy4xbDAuMSwwYzMuNiwwLjEsNS45LDIuOCw1LjksNy4xYzAsMy4xLTEsNS43LTIuNiw3LjFjNCwxLjQsNC40LDIuMSw0LjUsMi40YzAuNCwwLjksMC41LDMuMSwwLjYsMy44YzAsMC4yLDAsMC43LTAuNiwxLjNDLTI2Ni4zLDQwOC45LTI2OC45LDQwOS41LTI3Myw0MDkuNXogTS0yNzMsNDA3LjVMLTI3Myw0MDcuNWM1LjEsMCw2LjItMC45LDYuNC0xLjFjLTAuMS0xLjEtMC4yLTIuMy0wLjMtMi43Yy0wLjYtMC40LTIuOS0xLjMtNC44LTEuOWwtMC43LTAuMmwtMC4xLTJsMC43LTAuM2MxLjctMC42LDIuOC0zLjEsMi44LTYuMWMwLTMuMS0xLjUtNS0zLjktNS4xYy0yLjUsMC00LDItNCw1LjFjMCwzLDEuMSw1LjUsMi44LDYuMWwwLjcsMC4zbC0wLjEsMmwtMC43LDAuMmMtMS45LDAuNi00LjIsMS41LTQuOCwxLjljLTAuMSwwLjQtMC4zLDEuNi0wLjMsMi43Qy0yNzkuMiw0MDYuNi0yNzgsNDA3LjUtMjczLDQwNy41eiIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoLTQzLC0yKSIvPjxwYXRoIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgZD0iTS0zMDcsMzk1IGwxNSwwIGwtNCwtNCBsMi42NiwwIGw1LDUgbC01LDUgbC0yLjY2LDAgbDQtNCBsLTE1LDAgbDAsLTIiLz48cGF0aCBkPSJNLTI3Myw0MDkuNUwtMjczLDQwOS41Yy00LjEsMC02LjgtMC42LTcuOS0xLjdjLTAuNS0wLjYtMC42LTEuMS0wLjYtMS4zYzAtMC43LDAuMS0yLjksMC42LTMuOGMwLjEtMC4zLDAuNS0xLDQuNS0yLjRjLTEuNi0xLjQtMi42LTQtMi42LTcuMWMwLTQuMiwyLjMtNyw1LjktNy4xbDAuMSwwYzMuNiwwLjEsNS45LDIuOCw1LjksNy4xYzAsMy4xLTEsNS43LTIuNiw3LjFjNCwxLjQsNC40LDIuMSw0LjUsMi40YzAuNCwwLjksMC41LDMuMSwwLjYsMy44YzAsMC4yLDAsMC43LTAuNiwxLjNDLTI2Ni4zLDQwOC45LTI2OC45LDQwOS41LTI3Myw0MDkuNXogTS0yNzMsNDA3LjVMLTI3Myw0MDcuNWM1LjEsMCw2LjItMC45LDYuNC0xLjFjLTAuMS0xLjEtMC4yLTIuMy0wLjMtMi43Yy0wLjYtMC40LTIuOS0xLjMtNC44LTEuOWwtMC43LTAuMmwtMC4xLTJsMC43LTAuM2MxLjctMC42LDIuOC0zLjEsMi44LTYuMWMwLTMuMS0xLjUtNS0zLjktNS4xYy0yLjUsMC00LDItNCw1LjFjMCwzLDEuMSw1LjUsMi44LDYuMWwwLjcsMC4zbC0wLjEsMmwtMC43LDAuMmMtMS45LDAuNi00LjIsMS41LTQuOCwxLjljLTAuMSwwLjQtMC4zLDEuNi0wLjMsMi43Qy0yNzkuMiw0MDYuNi0yNzgsNDA3LjUtMjczLDQwNy41eiIvPjxnIG9wYWNpdHk9IjAuNiI+PHBhdGggY2xhc3M9InN0MCIgZD0iTS0yNTcsNDAyLjhjMC0wLjctMC4xLTIuOS0wLjYtMy44Yy0wLjEtMC4zLTAuNS0xLTQuNS0yLjRjMS42LTEuNCwyLjYtNCwyLjYtNy4xYzAtNC4yLTIuMy03LTUuOS03LjFsLTAuMSwwYy0xLjksMC0zLjUsMC44LTQuNSwyLjJjMC42LDAuMywxLjIsMC42LDEuOCwxYzAuNy0wLjgsMS42LTEuMywyLjgtMS4zYzIuNCwwLDMuOSwyLDMuOSw1LjFjMCwzLTEuMSw1LjUtMi44LDYuMWwtMC43LDAuM2wwLjEsMmwwLjcsMC4yYzEuOSwwLjYsNC4zLDEuNSw0LjgsMS45YzAuMSwwLjQsMC4zLDEuNiwwLjMsMi43Yy0wLjIsMC4yLTEsMC44LTMuOCwxYzAuMSwwLjYsMC4yLDEuMiwwLjIsMmMyLjUtMC4yLDQuMi0wLjgsNS0xLjZDLTI1Nyw0MDMuNS0yNTcsNDAzLTI1Nyw0MDIuOHoiLz48cGF0aCBkPSJNLTI4Nyw0MDIuN2MwLjEtMS4xLDAuMi0yLjMsMC4zLTIuN2MwLjYtMC40LDIuOS0xLjMsNC44LTEuOWwwLjctMC4ybDAuMS0ybC0wLjctMC4zYy0xLjYtMC42LTIuOC0zLjEtMi44LTYuMWMwLTMuMSwxLjUtNSw0LTUuMWMxLjIsMCwyLjEsMC41LDIuOCwxLjNjMC41LTAuNCwxLjEtMC44LDEuOC0xYy0xLTEuNC0yLjYtMi4yLTQuNS0yLjJsLTAuMSwwYy0zLjYsMC01LjksMi44LTUuOSw3LjFjMCwzLjEsMSw1LjcsMi42LDcuMWMtNCwxLjQtNC40LDIuMS00LjUsMi40Yy0wLjQsMC45LTAuNSwzLjEtMC42LDMuOGMwLDAuMiwwLDAuNywwLjYsMS4zYzAuOCwwLjksMi41LDEuNCw1LjEsMS42YzAtMC43LDAuMS0xLjQsMC4yLTJDLTI4Niw0MDMuNS0yODYuOCw0MDIuOS0yODcsNDAyLjd6Ii8+PC9nPjwvc3ZnPg==') center/cover no-repeat !important;
	background: #3ca374 !important;
}
.item-1GzJrl.leave-1DRJfn .icon-2doZ3q {
  background-image: none !important;
  -webkit-mask-repeat: no-repeat;
  -webkit-mask-position: right;
  -webkit-mask: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxOCIgaGVpZ2h0PSIxOCI+ICA8ZyBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPiAgICA8cGF0aCBkPSJNMCAwaDE4djE4SDB6Ii8+ICAgIDxwYXRoIGZpbGw9IiM3MzdGOEQiIGQ9Ik0xNC4yNSAyLjI1SDMuNzVjLS44MzI1IDAtMS41LjY2NzUtMS41IDEuNXYzaDEuNXYtM2gxMC41djEwLjVIMy43NXYtM2gtMS41djNjMCAuODI4NDI3MS42NzE1NzI4NyAxLjUgMS41IDEuNWgxMC41Yy44Mjg0MjcxIDAgMS41LS42NzE1NzI5IDEuNS0xLjVWMy43NWMwLS44MzI1LS42NzUtMS41LTEuNS0xLjV6bS02LjY5IDkuNDM1bDEuMDY1IDEuMDY1TDEyLjM3NSA5bC0zLjc1LTMuNzVMNy41NiA2LjMwNzUgOS41MDI1IDguMjVIMi4yNXYxLjVoNy4yNTI1TDcuNTYgMTEuNjg1eiIvPiAgPC9nPjwvc3ZnPg==");
  background-color: #f04747 !important;
  color: #f04747 !important;
}
.regionSelect-3lf4eE button,
.regionSelectInner-24f4Ce {
	border:none !important;
	color:var(--hover-color);
	transition:100ms all linear;
}
.regionSelect-3lf4eE:hover button,
.regionSelectInner-24f4Ce:hover {
	background:rgba(0,0,0,0.25) !important;
}
.actionButton-2PeQbJ {
	background:var(--main-color) !important;
}
.topLayer-1eMqbv.hover-3nZwuJ,
.bottomLayer-XCk80b.hover-3nZwuJ,
.secondaryAccent-24W-RJ.hover-3nZwuJ.green-1kY_LT {
	fill:var(--hover-color) !important;
}
.regionSelect-3lf4eE:hover .regionSelectInner-24f4Ce,
.regionSelect-3lf4eE:hover button {
	border-color:var(--hover-color) !important;
}
.regionSelectModal-12e-57,
.contentWrapper-3WC1ID {
	background:var(--backdrop) !important;
	background-size:cover !important;
	background-repeat:no-repeat;
	box-shadow:inset 0px 0px 10000px rgba(0,0,0,0.8), 0px 0px 10px rgba(0,0,0,0.5) !important;
}
.regionSelectModal-12e-57 .regionSelectModalOption-2DSIZ3:hover {
	background:rgba(0,0,0,0.5) !important;
	border-color:var(--hover-color) !important;
}
.regionSelectModal-12e-57 .regionSelectModalOption-2DSIZ3 {
	background:rgba(0,0,0,0.3) !important;
	transition:100ms linear all;
	border-color:transparent;
}
.regionSelect-3lf4eE .regionSelectInner-24f4Ce,
.regionSelect-3lf4eE button {
	border:none;
	background:rgba(0,0,0,0.5) !important;
}

/*8.g. Reactions Modal*/
#app-mount .sidebar-1-SQro {
	width:100px !important;
	background:var(--backdropblurred);
	background-position:fixed !important;
}
.reactors-Blmlhw {
	background:var(--backdrop) !important;
	background-attachment:fixed !important;
	background-size:cover !important;
	box-shadow:inset 0 0 10000px rgba(0,0,0,0.99);
}

/*8.h. Profile Modal*/
.verified-3uJH7V g path:nth-child(2),
.connectedAccountVerifiedIcon-3aZz_K g path:nth-child(2),
.verifiedIcon-2TCIsJ g path:nth-child(2),
.verified-2-ja4L g path:nth-child(2) {
  fill: var(--hover-color) !important;
}
.userInfoSection-2acyCx+.userInfoSection-2acyCx,
.connectedAccount-36nQx7 {
    border:none !important;
}
.tabBarContainer-1s1u-z .tab-bar.TOP .tab-bar-item {
	transition:150ms all ease-in-out;
}
.topSectionNormal-2-vo2m .lookFilled-1Gx00P:hover {
	box-shadow:0px 5px 20px rgba(0,0,0,0.75);
}
.topSectionNormal-2-vo2m .lookFilled-1Gx00P {
	box-shadow:0px 2px 16px rgba(0,0,0,0.75);
	transition:150ms all ease-in-out;
	background:#43b581 !important;
}
.headerFill-adLl4x {
  background:transparent !important;
}
.tabBarContainer-1s1u-z {
	border:none !important;
	height:65px;
}
.modal-1UGdnR .tab-bar-item.selected {
	background:transparent !important;
}
.topSectionNormal-2-vo2m {
	background:var(--hover-color) !important;
}
.body-3ND3kc {
	background:var(--backdropblurred) !important;
	background-size:cover !important;
	background-attachment: fixed !important;
	background-position:center !important;
}
.header-QKLPzZ {
    height:125px;
    background:var(--backdrop) !important;
    background-size:cover !important;
    background-position:center !important;
    box-shadow: inset 0 -90px 130px 10px var(--hover-color) !important;
}
.body-3ND3kc {
    border-top:4px solid rgba(0,0,0,0.5) !important;
}
.root-SR8cQa,
.root-SR8cQa .scroller-2FKFPG{
	border-radius: 4px;
}
.root-SR8cQa .header-QKLPzZ {
	height: 150px;
	animation: profile 700ms cubic-bezier(.5, 0, 0, 1) 200ms backwards;
}
.userInfoSection-2acyCx,
.listRow-hutiT_,
.empty-2WtT5s {
    	animation: profile2 400ms cubic-bezier(.5, 0, 0, 1) 200ms backwards;
}
.topSectionSpotify-1lI0-P,
.topSectionPlaying-1J5E4n,
.topSectionStreaming-1Tpf5X {
    background:var(--hover-color) !important;
}
.da-activityProfile {
    height:unset !important;
    max-height:6px;
    overflow:hidden;
    background:rgba(0,0,0,0.25);
    box-shadow:0 0 10px rgba(0,0,0,0.25);
    transition:500ms ease-out max-height;
}
.activityProfile-2bJRaP .assetsLargeImageProfile-3YXDex {
  margin-top:5px;
}
.activityProfile-2bJRaP .details-38sfDr {
  margin-top:2px;
}
.activityProfile-2bJRaP:hover .headerText-1HLrL7:before {
  transform:rotate(90deg);
}
.activityProfile-2bJRaP .headerText-1HLrL7:before {
  content:'';
  width:20px;
  height:20px;
  position:absolute;
  filter:brightness(2);
  transform:rotate(180deg);
  background-repeat:no-repeat !important;
  background-size:cover;
  margin-left:650px;
  margin-top:-10px !important;
  transition:250ms transform ease;
  background:url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9Im5vIj8+PHN2ZyB3aWR0aD0iN3B4IiBoZWlnaHQ9IjEwcHgiIHZpZXdCb3g9IjAgMCA3IDEwIiB2ZXJzaW9uPSIxLjEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHhtbG5zOnNrZXRjaD0iaHR0cDovL3d3dy5ib2hlbWlhbmNvZGluZy5jb20vc2tldGNoL25zIj4gICAgICAgIDx0aXRsZT5pY29uLWFycm93PC90aXRsZT4gICAgPGRlc2M+Q3JlYXRlZCB3aXRoIFNrZXRjaC48L2Rlc2M+ICAgIDxkZWZzPjwvZGVmcz4gICAgPGcgaWQ9IkNvbnRleHQtTWVudXMiIHN0cm9rZT0ibm9uZSIgc3Ryb2tlLXdpZHRoPSIxIiBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiIHNrZXRjaDp0eXBlPSJNU1BhZ2UiPiAgICAgICAgPGcgaWQ9IkNvbnRleHQtTWVudXMtLS1MaWdodCIgc2tldGNoOnR5cGU9Ik1TQXJ0Ym9hcmRHcm91cCIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoLTU2My4wMDAwMDAsIC0xNzguMDAwMDAwKSIgZmlsbD0iIzlGQTZCMCI+ICAgICAgICAgICAgPGcgaWQ9IlVzZXItTWVudSIgc2tldGNoOnR5cGU9Ik1TTGF5ZXJHcm91cCIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNDExLjAwMDAwMCwgOTUuMDAwMDAwKSI+ICAgICAgICAgICAgICAgIDxnIGlkPSJHcm91cC0xMyIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoMC45NjgwMDAsIDcxLjAwMDAwMCkiIHNrZXRjaDp0eXBlPSJNU1NoYXBlR3JvdXAiPiAgICAgICAgICAgICAgICAgICAgPHBhdGggZD0iTTE1MC4zMDQyMDcsMTUuNzA3MTA2OCBMMTU0LjI0MDIwNywxOS43MDcxMDY4IEMxNTQuNjI0NDgzLDIwLjA5NzYzMTEgMTU1LjI0NzUxNywyMC4wOTc2MzExIDE1NS42MzE3OTMsMTkuNzA3MTA2OCBMMTU5LjU2Nzc5MywxNS43MDcxMDY4IEMxNTkuOTUyMDY5LDE1LjMxNjU4MjUgMTU5Ljk1MjA2OSwxNC42ODM0MTc1IDE1OS41Njc3OTMsMTQuMjkyODkzMiBDMTU5LjE4MzUxNywxMy45MDIzNjg5IDE1OC41NjA0ODMsMTMuOTAyMzY4OSAxNTguMTc2MjA3LDE0LjI5Mjg5MzIgTDE1NC4yNDAyMDcsMTguMjkyODkzMiBMMTU1LjYzMTc5MywxOC4yOTI4OTMyIEwxNTEuNjk1NzkzLDE0LjI5Mjg5MzIgQzE1MS4zMTE1MTcsMTMuOTAyMzY4OSAxNTAuNjg4NDgzLDEzLjkwMjM2ODkgMTUwLjMwNDIwNywxNC4yOTI4OTMyIEMxNDkuOTE5OTMxLDE0LjY4MzQxNzUgMTQ5LjkxOTkzMSwxNS4zMTY1ODI1IDE1MC4zMDQyMDcsMTUuNzA3MTA2OCBMMTUwLjMwNDIwNywxNS43MDcxMDY4IFoiIGlkPSJpY29uLWFycm93IiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgxNTQuOTM2MDAwLCAxNy4wMDAwMDApIHJvdGF0ZSgtOTAuMDAwMDAwKSB0cmFuc2xhdGUoLTE1NC45MzYwMDAsIC0xNy4wMDAwMDApICI+PC9wYXRoPiAgICAgICAgICAgICAgICA8L2c+ICAgICAgICAgICAgPC9nPiAgICAgICAgPC9nPiAgICA8L2c+PC9zdmc+);
}
.activityProfile-2bJRaP .nameNormal-2lqVQK {
  margin-top:-23px;
  z-index:10000;
  position:absolute;
}
.da-activityProfile:hover {
  height:unset !important;
  max-height:125px;
}
.da-modal .bodyAlignCenter-1KzvJk {
  margin-top:15px;
}
.da-activityProfile .bodyAlignCenter-1KzvJk .activityName-1IaRLn,
.da-activityProfile .bodyAlignCenter-1KzvJk .nameNormal-2lqVQK,
.da-activityProfile .lookOutlined-3sRXeN.colorWhite-rEQuAQ,
.da-activityProfile .detailsWrap-22pigg,
.da-activityProfile .da-timestamp,
.da-activityProfile .da-playTime,
.da-activityProfile .da-gameIcon,
.da-activityProfile .details-38sfDr,
.da-activityProfile .assets-VMAukC,
.da-activityProfile .state-Tt0LO3,
.da-activityProfile .nameWrap-3Z4G_9 {
  opacity:0;
  transition:opacity 250ms;
}
.da-activityProfile .da-anchor:not(.bodyAlignCenter-1KzvJk) {
  margin-left:30px;
  color:#fff !important;
}
.da-activityProfile .bodyAlignCenter-1KzvJk .activityName-1IaRLn {
  margin-top:10px;
}
.activityProfile-2bJRaP .contentGameImageProfile-WTVbI0 {
  margin-bottom:-25px !important;
}
.da-activityProfile:hover .bodyAlignCenter-1KzvJk .activityName-1IaRLn,
.da-activityProfile:hover .bodyAlignCenter-1KzvJk .nameNormal-2lqVQK,
.da-activityProfile:hover .lookOutlined-3sRXeN.colorWhite-rEQuAQ,
.da-activityProfile:hover .detailsWrap-22pigg,
.da-activityProfile:hover .da-timestamp,
.da-activityProfile:hover .da-playTime,
.da-activityProfile:hover .da-gameIcon,
.da-activityProfile:hover .details-38sfDr,
.da-activityProfile:hover .assets-VMAukC,
.da-activityProfile:hover .state-Tt0LO3,
.da-activityProfile:hover .nameWrap-3Z4G_9 {
  opacity:1 !important;
}
.da-activityProfile .da-contentNoImagesProfile .nameNormal-2lqVQK {
    margin-left:110px;
}
.activityProfile-2bJRaP .headerText-1HLrL7 {
    margin-top:-3px;
}
.activityProfile-2bJRaP .headerText-1HLrL7:after {
    content:'-';
    font-weight:bold;
    margin-left:5px;
}
@keyframes profile2 {
	from {
		transform: translate(0, 100px);
		opacity: 0;
	}
}
@keyframes profile {
	from {
		transform: translate(0, -10px);
		opacity: 0;}
}
.root-SR8cQa {
	width: 700px;
}
@keyframes float {
	0% {
		box-shadow:0 5px 15px 0 rgba(0,0,0,1);
		transform: translatey(0px)
	}
	50% {
		box-shadow:0 5px 15px 0 rgba(0,0,0,.5);
		transform: translatey(-10px)
	}
	100% {
		box-shadow:0 5px 15px 0 rgba(0,0,0,1);
		transform: translatey(0px)
	}
}
.header-QKLPzZ .wrapper-2F3Zv8 {
    animation:float 3s infinite;
    cursor: zoom-in;
    transition:100ms width ease;
}
.header-QKLPzZ .da-avatar {
  box-shadow:none !important;
}
.header-QKLPzZ .wrapper-2F3Zv8:active {
  cursor:zoom-out !important;
}
#app-mount .header-QKLPzZ .wrapper-2F3Zv8:active .da-image {
  transform:scale(4);
  position:absolute;
  border-radius:20px !important;
  left:82px !important;
  top:-22% !important;
  z-index:100000000 !important;
  border:200px solid rgba(0,0,0,0.5);
  animation:opacity .5s ease;
}
@keyframes opacity {
  0% {opacity:0;}
  100% {opacity:1;}
}
.header-QKLPzZ .wrapper-2F3Zv8:active {
  animation:none;
  width:0px;
}
.header-QKLPzZ .wrapper-2F3Zv8:active .da-status {
  display:none;
  border:none !important;
}

/*8.i. Download Apps Screen*/
.backdrop-1wrmKB {
	background:rgba(0,0,0,0.75) !important;
}
.downloadApps-wbBFdZ {
	background:var(--backdropblurred);
	background-size:cover;
	border:3px solid var(--hover-color);
}
.platform-iik236.active-iLSdWQ {
	border-color:var(--hover-color) !important;
}
.platform-iik236.active-iLSdWQ .downloadButton-1bWXpg {
	background:var(--main-color) !important;
	color:#fff !important;
}
.platform-iik236 .icon-2Pk7pb,
.downloadButton-1bWXpg {
	background:rgba(0,0,0,0.5) !important;
}
.platform-iik236 {
	border-color:rgba(0,0,0,0.5) !important;
}
.platform-iik236 p {
	color:rgba(0,0,0,0.5) !important;
}
.downloadApps-wbBFdZ .platforms-28Rb-3 .platform-iik236.active-iLSdWQ .icon-2Pk7pb {
	background:var(--main-color) !important;
}
.downloadApps-wbBFdZ .platforms-28Rb-3 .platform-iik236 .icon-2Pk7pb.apple-1fKN59 {
  -webkit-mask-image: url(https://discordapp.com/assets/57568e1cfc37c81cf56db9498b4f128a.svg);
}
.downloadApps-wbBFdZ .platforms-28Rb-3 .platform-iik236 .icon-2Pk7pb.windows-29yOum {
  -webkit-mask-image: url(https://discordapp.com/assets/d6221c5e88f5cb89f125868c077e9859.svg)
}
.downloadApps-wbBFdZ .platforms-28Rb-3 .platform-iik236 .icon-2Pk7pb.linux-15cW1y {
  -webkit-mask-image: url(https://discordapp.com/assets/a3bee2061afed80c5bd76ff38cd18f0e.svg);
}
.downloadApps-wbBFdZ .platforms-28Rb-3 .platform-iik236 .icon-2Pk7pb.ios-Z7K-rr {
  -webkit-mask-image: url(https://discordapp.com/assets/0c460e9b848f5c4cc964ae9c62c0f9b9.svg);
}
.downloadApps-wbBFdZ .platforms-28Rb-3 .platform-iik236 .icon-2Pk7pb.android-gGrHJu {
  -webkit-mask-image: url(https://discordapp.com/assets/676bfec9f4343f6fcdf0a12ae313a3de.svg);
}
.platform-iik236.active-iLSdWQ p,
.header-nJMe-Q {
	color:var(--hover-color) !important;
}
/*============== END OF SECTION ============== */

/*9. Settings*/
/*9.a. Transparency and Sidebar*/
.ui-tab-bar-item.selected,
body #app-mount .side-8zPYf6 .itemSelected-1qLhcL,
body #app-mouont .side-8zPYf6 .itemSelected-1qLhcL:hover {
    background:var(--main-color) !important;
}
.sidebarScrollable-1qPI87 .cardPrimary-1Hv-to {
    margin-bottom:35px;
}
.ui-tab-bar-item:hover,
.side-8zPYf6 .item-PXvHYJ:hover {
    background:var(--main-color-faded) !important;
}
.ui-tab-bar-item,
.item-PXvHYJ {
    transition: 100ms all linear;
}
.closeButton-1tv5uR {
    border:none;
    transition:200ms all linear;
}
.da-sidebarRegion,
.contentRegion-3nDuYy {
    background:var(--backdropblurred) !important;
    background-size:cover !important;
    background-attachment:fixed !important;
}
.da-sidebar:hover {
	width:300px !important;
}
.standardSidebarView-3F1I7i .side-8zPYf6 [style*="color: rgb(114, 137, 218)"] {
    color:var(--hover-color) !important;
}
.standardSidebarView-3F1I7i .side-8zPYf6 [style*="background-color: rgb(114, 137, 218)"] {
    background:var(--main-color) !important;
    color:#fff !important;
}
.separator-gCa7yv {
    background:rgba(255,255,255,0.05) !important;
}
.da-sidebar {
	transition:.3s width ease;
}
.da-sidebarRegion {
	margin-right: 25px;
}
.da-sidebarRegion,
.contentRegion-3nDuYy {
    border-radius:6px;
}
.standardSidebarView-3F1I7i .sidebarRegion-VFTUkN,
.standardSidebarView-3F1I7i .sidebarRegion-VFTUkN .sidebarRegionScroller-3MXcoP {
  justify-content: flex-start;
}
.sidebarRegion-VFTUkN {
  -ms-flex: 0;
  -ms-flex-pack: end;
  flex: 0;
  z-index: 1;
}
.container-1sFeqf .da-keybind {
    color:#fff;
    font-weight:100;
}
.standardSidebarView-3F1I7i .contentColumnDefault-1VQkGM {
  padding: 20px 40px 80px;
}
.divider-3573oO {
    background:transparent !important;
}
.standardSidebarView-3F1I7i .contentRegionScroller-26nc1e {
  width: 100%;
}
.standardSidebarView-3F1I7i .contentColumn-2hrIYH,
.standardSidebarView-3F1I7i .customColumn-Rb6toI {
  -ms-flex: 1 1 auto;
  -webkit-box-flex: 1;
  flex: 1 1 auto;
  max-width: 100%;
  min-height: 100%;
  min-width: 460px;
}
.standardSidebarView-3F1I7i .customScroller-26gWhv>div {
  max-width: 100%;
  margin-right: 98px;
}
.standardSidebarView-3F1I7i .contentRegion-3nDuYy {
  width: calc(100% - 226px);
  min-width: 553px;
  padding: 0;
}
.sidebarScrollable-1qPI87 {
  width: 24%;
}
.sidebarScrollable-1qPI87+.content-1rPSz4 {
  max-width: 100%;
  margin-left: 25%;
}
.standardSidebarView-3F1I7i .noticeRegion-1YviSH {
  transform: translateX(25%) !important;
}
.premium-settings .premium-header,
.premium-settings .features-vNGwn7 {
  max-width: 98%;
}
.side-8zPYf6 {
    margin-top:-25px;
}

/*9.b.  Buttons and Checkboxes and Switches*/
.lookFilled-1Gx00P.colorBrand-3pXr91,
.lookFilled-1Gx00P.colorPrimary-3b3xI6,
.valueChecked-m-4IJZ,
.ui-switch.checked {
    background:var(--main-color) !important;
}
[stroke*="114, 137, 218"],
[stroke*="#7289da"] {
    stroke:var(--hover-color) !important;
}
.checked-3_4uQ9 {
    background:transparent !important;
}
.checkbox-1ix_J3[style*="114, 137, 218"] {
    border-color:var(--hover-color) !important;
}
.checkbox-1ix_J3 {
    border-width:2px;
    transition:150ms all ease;
}
.option-1l2vXE .lookFilled-1Gx00P.colorGreen-29iAKY {
    background:var(--main-color) !important;
}
#bd-settingspane-container .ui-switch-item .ui-switch-wrapper .ui-switch,
.themeDefault-24hCdX {
    background:rgba(255,255,255,0.25);
}
.lookInverted-2D7oAl.colorBrand-3pXr91 {
    color:var(--hover-color) !important;
}
.lookFilled-1Gx00P.hoverBrand-1_Fxlk.hasHover-3X1-zV {
	background:rgba(0,0,0,0.5) !important;
}
.lookFilled-1Gx00P.hoverBrand-1_Fxlk.hasHover-3X1-zV:hover {
	background:var(--hover-color) !important;
}
.lookFilled-1Gx00P.hoverGreen-1gjdJc {
    background:rgba(0,0,0,0.5);
}
.lookOutlined-3sRXeN.colorBrand-3pXr91 {
    color:var(--hover-color);
    transition:100ms all linear;
    border-color:var(--hover-color) !important;
}
.lookOutlined-3sRXeN.colorBrand-3pXr91:hover {
    opacity:.5;
}
.standardSidebarView-3F1I7i {
	background:transparent !important;
}
.ui-switch {
	background:rgba(255,255,255,0.05);
}

/*9.c. My Account*/
.da-cardPrimary,
.cardPrimaryEditable-3KtE4g,
.codeRedemptionRedirect-1wVR4b,
.lookOutlined-3sRXeN.colorTransparent-1ewNp9 {
    background:rgba(0,0,0,0.5) !important;
    border:none !important;
    box-shadow:0px 0px 5px black;
    transition: 200ms linear all;
}
.da-cardPrimary:hover,
.cardPrimaryEditable-3KtE4g:hover,
.codeRedemptionRedirect-1wVR4b:hover,
.lookOutlined-3sRXeN.colorTransparent-1ewNp9:hover {
    transform: scale(1.02) !important;
}
.avatar-uploader-inner {
    background-color:var(--hover-color) !important;
}
.input-cIJ7To:hover,
.input-cIJ7To:focus,
.input-cIJ7To.da-focused {
    border-color:var(--hover-color) !important;
}

/*9.d. Authorized Apps*/
.cardPrimaryOutline-29Ujqw {
    background:rgba(0,0,0,0.3);
    border:none;
}

/*9.e. Connections*/
.accountBtnInner-sj5jLs {
    border:none !important;
    background-color:transparent !important;
}

/*9.f. Billing*/
.da-paymentPane,
.pageButtonPrev-1Y-47D,
.pageButtonNext-V2kUq0,
.pageIndicator-1gAbyA,
.expandedInfo-3kfShd{
    background:rgba(0,0,0,0.5) !important;
    border:none !important;
}
.tab-1kx2RU {
    background:transparent !important;
    border-radius:5px;
}
.paginator-166-09,
.payment-xT17Mq,
.paymentHeader-3QlZQi{
    background:transparent !important;
    border:none !important;
}
.paymentRow-2e7VM6 {
    border-width:2px !important;
    border-color:var(--hover-color) !important;
}

/*9.g. Nitro*/
.container-2Zlzt0,
.tier1Banner-1B_WXY {
    background:rgba(0,0,0,0.5) !important;
}
.da-notSelected[style*="rgb(114, 137, 218)"] {
	color:var(--hover-color) !important;
}
.da-finePrint {
	color:#fff !important;
}
.banner-3Kac2g {
	background:var(--main-color) !important;
}
.feature-1n9XFi .animatedIcon-3voig8 {
	-webkit-mask: url(https://discordapp.com/assets/7fe83c179ad0b8a37b90bf06676becd5.svg);
}
.feature-1n9XFi .badgeIcon-1sJyLH {
	-webkit-mask: url(https://discordapp.com/assets/df0e29b16d71bdad333880b2488075be.svg);
}
.feature-1n9XFi .badgeIcon-1sJyLH,
.feature-1n9XFi .animatedIcon-3voig8 {
	-webkit-mask-size: cover;
	background: var(--main-color) !important;
}

/*9.h. HypeSquad*/
.description-1W0DiL {
	color:#fff !important;
}

/*9.i. Voice and Video*/
.da-barFill {
	background:var(--main-color);
}
.notches-1sAcEM {
	display:none;
}
.container-3PXSwK {
	border-radius:5px;
}
.media-engine-video {
	background:transparent !important;
}
.bar-2Qqk5Z,
.da-previewOverlay,
.progress-1IcQ3A {
    background:rgba(0,0,0,0.5) !important;
    border:none !important;
}
.bubble-3we2di {
    background:var(--main-color);
    background-color:transparent !important;
    border-radius:5px;
    box-shadow:none !important;
}
.bubble-3we2di::before {
    display:none;
}

/*9.j. Overlay/Streamer Mode*/
.selected-mKYnfr.option-n0icdO {background:var(--main-color);}
.option-n0icdO:hover {background:var(--hover-color);}
.wrapper-3jrx9n {border-color:var(--hover-color);}
.option-n0icdO {
    background:var(--main-color-faded);
    transition:250ms linear all;
}

.icon-4lJsMQ[src="/assets/616e078b351d0df460971441949c53a3.svg"] + *:before {
	content: '';
	position: absolute;
	top: 20px;
	right: 20px;
	width: 184px;
	height: 100px;
	-webkit-mask-size: cover;
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgd2lkdGg9IjE4NCIgaGVpZ2h0PSIxMTAiIHZpZXdCb3g9IjAgMCAxODQgMTEwIj48ZyBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPjxnIHRyYW5zZm9ybT0idHJhbnNsYXRlKDEgMSkiPjxwb2x5Z29uIGZpbGw9IiM3Njg3QjIiIHBvaW50cz0iNTguMDQ5IDE0LjQ4NyA4MS43MDMgMTQuNDg3IDgxLjcwMyA2Ljg4MyA1OC4wNDkgNi44ODMiLz48ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSgwIC42MTcpIj48cG9seWdvbiBmaWxsPSIjNzY4N0IyIiBwb2ludHM9IjcuOTU3IDg0Ljc1MyAxMzMuMTg2IDg0Ljc1MyAxMzMuMTg2IDI2LjMxNCA3Ljk1NyAyNi4zMTQiLz48L2c+PC9nPjwvZz48L3N2Zz4=') !important;
	background:var(--main-color) !important;
}
.icon-4lJsMQ[src="/assets/616e078b351d0df460971441949c53a3.svg"] + * > *:first-child:before {
	content: '';
	position: absolute;
	z-index: 1;
	top: 20px;
	right: 20px;
	width: 184px;
	height: 100px;
	-webkit-mask-size: cover;
	-webkit-mask: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgd2lkdGg9IjE4NCIgaGVpZ2h0PSIxMTAiIHZpZXdCb3g9IjAgMCAxODQgMTEwIj48ZyBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPjxnIHRyYW5zZm9ybT0idHJhbnNsYXRlKDEgMSkiPjxnIHRyYW5zZm9ybT0idHJhbnNsYXRlKDAgLjYxNykiPjxwYXRoIGZpbGw9IiM3Njg3QjIiIGQ9Ik03Mi4zMTA5LDEwLjA2ODEgQzcyLjMxMDksMTEuNDEzMSA3MS4yMTk5LDEyLjUwNDEgNjkuODc0OSwxMi41MDQxIEM2OC41MzA5LDEyLjUwNDEgNjcuNDQwOSwxMS40MTMxIDY3LjQ0MDksMTAuMDY4MSBDNjcuNDQwOSw4LjcyMzEgNjguNTMwOSw3LjYzMzEgNjkuODc0OSw3LjYzMzEgQzcxLjIxOTksNy42MzMxIDcyLjMxMDksOC43MjMxIDcyLjMxMDksMTAuMDY4MSBaIi8+PHBhdGggZmlsbD0iIzc2ODdCMiIgZD0iTTEyOC4yOTI0LDY0LjYxNSBDMTI4LjI5MjQsNTUuOTY5IDEzNS4zMDE0LDQ4Ljk2MSAxNDMuOTQ1NCw0OC45NjEgQzE1Mi41OTE0LDQ4Ljk2MSAxNTkuNjAwNCw1NS45NjkgMTU5LjYwMDQsNjQuNjE1IEMxNTkuNjAwNCw3My4yNiAxNTIuNTkxNCw4MC4yNjggMTQzLjk0NTQsODAuMjY4IEMxMzUuMzAxNCw4MC4yNjggMTI4LjI5MjQsNzMuMjYgMTI4LjI5MjQsNjQuNjE1IiAvPjwvZz48L2c+PC9nPjwvc3ZnPg==') !important;
	background: var(--main-color) !important;
}
.icon-4lJsMQ[src="/assets/616e078b351d0df460971441949c53a3.svg"] + *:after {
	position: absolute;
	top: 20px;
	right: 20px;
	width: 184px;
	height: 100px;
	content: url('data:image/svg+xml;base64,IDxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgd2lkdGg9IjE4NCIgaGVpZ2h0PSIxMTAiIHZpZXdCb3g9IjAgMCAxODQgMTEwIj48ZyBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPjxnIHRyYW5zZm9ybT0idHJhbnNsYXRlKDEgMSkiPjxwb2x5Z29uIGZpbGw9IiNFNEU5RjgiIHBvaW50cz0iNjcuNzg4IDI1LjM4OSA3MS45NjMgMjUuMzg5IDcxLjk2MyAxMy44MzYgNjcuNzg4IDEzLjgzNiIvPjxwb2x5Z29uIHN0cm9rZT0iIzFFMjEyNiIgc3Ryb2tlLXdpZHRoPSIyIiBwb2ludHM9IjY3Ljc4OCAyNS4zODkgNzEuOTYzIDI1LjM4OSA3MS45NjMgMTMuODM2IDY3Ljc4OCAxMy44MzYiIHN0cm9rZS1saW5lY2FwPSJyb3VuZCIgc3Ryb2tlLWxpbmVqb2luPSJyb3VuZCIvPjxwb2x5Z29uIHN0cm9rZT0iIzFFMjEyNiIgc3Ryb2tlLXdpZHRoPSIyIiBwb2ludHM9IjU4LjA0OSAxNC40ODcgODEuNzAzIDE0LjQ4NyA4MS43MDMgNi44ODMgNTguMDQ5IDYuODgzIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiLz48cG9seWdvbiBmaWxsPSIjRkZGRkZGIiBwb2ludHM9IjY0LjM4NSAxNi4xNzYgNzUuMzY3IDE2LjE3NiA3NS4zNjcgNS4xOTQgNjQuMzg1IDUuMTk0Ii8+PGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoMCAuNjE3KSI+PHBhdGggc3Ryb2tlPSIjMUUyMTI2IiBzdHJva2Utd2lkdGg9IjIiIGQ9Ik03Mi40MTA1LDEwLjA2ODEgQzcyLjQxMDUsMTEuNDY4MSA3MS4yNzU1LDEyLjYwMjEgNjkuODc1NSwxMi42MDIxIEM2OC40NzU1LDEyLjYwMjEgNjcuMzQxNSwxMS40NjgxIDY3LjM0MTUsMTAuMDY4MSBDNjcuMzQxNSw4LjY2OTEgNjguNDc1NSw3LjUzNDEgNjkuODc1NSw3LjUzNDEgQzcxLjI3NTUsNy41MzQxIDcyLjQxMDUsOC42NjkxIDcyLjQxMDUsMTAuMDY4MSBaIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiLz48cG9seWdvbiBzdHJva2U9IiMxRTIxMjYiIHN0cm9rZS13aWR0aD0iMiIgcG9pbnRzPSI2NC4zODUgMTUuNTU5IDc1LjM2NyAxNS41NTkgNzUuMzY3IDQuNTc3IDY0LjM4NSA0LjU3NyIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBtYXNrPSJ1cmwoI2IpIi8+PHBvbHlnb24gc3Ryb2tlPSIjMUUyMTI2IiBzdHJva2Utd2lkdGg9IjIiIHBvaW50cz0iNy45NTcgODQuNzUzIDEzMy4xODYgODQuNzUzIDEzMy4xODYgMjYuMzE0IDcuOTU3IDI2LjMxNCIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBtYXNrPSJ1cmwoI2IpIi8+PHBvbHlnb24gZmlsbD0iI0Q1REJFRCIgcG9pbnRzPSIxMTkuMzE2IDEwMS4yMDcgMTI1LjYzOSAxMDEuMjA3IDEyNS42MzkgODEuMDA5IDExOS4zMTYgODEuMDA5IiBtYXNrPSJ1cmwoI2IpIi8+PHBvbHlnb24gc3Ryb2tlPSIjMUUyMTI2IiBzdHJva2Utd2lkdGg9IjIiIHBvaW50cz0iMTE5LjMxNiAxMDEuMjA3IDEyNS42MzkgMTAxLjIwNyAxMjUuNjM5IDgxLjAwOSAxMTkuMzE2IDgxLjAwOSIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBtYXNrPSJ1cmwoI2IpIi8+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTEyNy44NTE5LDEwNS44NTAzIEwxMTcuMTAyOSwxMDUuODUwMyBDMTE1Ljg3OTksMTA1Ljg1MDMgMTE0Ljg4OTksMTA0Ljg1OTMgMTE0Ljg4OTksMTAzLjYzNzMgQzExNC44ODk5LDEwMi40MTQzIDExNS44Nzk5LDEwMS40MjQzIDExNy4xMDI5LDEwMS40MjQzIEwxMjcuODUxOSwxMDEuNDI0MyBDMTI5LjA3NDksMTAxLjQyNDMgMTMwLjA2NDksMTAyLjQxNDMgMTMwLjA2NDksMTAzLjYzNzMgQzEzMC4wNjQ5LDEwNC44NTkzIDEyOS4wNzQ5LDEwNS44NTAzIDEyNy44NTE5LDEwNS44NTAzIiBtYXNrPSJ1cmwoI2IpIi8+PHBhdGggc3Ryb2tlPSIjMUUyMTI2IiBzdHJva2Utd2lkdGg9IjIiIGQ9Ik0xMjcuODUxOSAxMDUuODUwM0wxMTcuMTAyOSAxMDUuODUwM0MxMTUuODc5OSAxMDUuODUwMyAxMTQuODg5OSAxMDQuODU5MyAxMTQuODg5OSAxMDMuNjM3MyAxMTQuODg5OSAxMDIuNDE0MyAxMTUuODc5OSAxMDEuNDI0MyAxMTcuMTAyOSAxMDEuNDI0M0wxMjcuODUxOSAxMDEuNDI0M0MxMjkuMDc0OSAxMDEuNDI0MyAxMzAuMDY0OSAxMDIuNDE0MyAxMzAuMDY0OSAxMDMuNjM3MyAxMzAuMDY0OSAxMDQuODU5MyAxMjkuMDc0OSAxMDUuODUwMyAxMjcuODUxOSAxMDUuODUwM3pNMTMwLjA2NDggODQuMjgzTDExNC44ODk4IDg0LjI4MyAxMTQuODg5OCA2My40MTdDMTE0Ljg4OTggNTkuMjI2IDExOC4yODY4IDU1LjgyOSAxMjIuNDc2OCA1NS44MjkgMTI2LjY2ODggNTUuODI5IDEzMC4wNjQ4IDU5LjIyNiAxMzAuMDY0OCA2My40MTdMMTMwLjA2NDggODQuMjgzeiIgc3Ryb2tlLWxpbmVjYXA9InJvdW5kIiBzdHJva2UtbGluZWpvaW49InJvdW5kIiBtYXNrPSJ1cmwoI2IpIi8+PHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTEyMy43ODI2LDkxLjIwMTkgTDEyMS4xNzI2LDkxLjIwMTkgQzExNi42NTQ2LDkxLjIwMTkgMTEyLjk5MjYsODcuNTM5OSAxMTIuOTkyNiw4My4wMjE5IEwxMTIuOTkyNiw3My40NTQ5IEMxMTIuOTkyNiw3Mi40NTA5IDExMy44MDU2LDcxLjYzNjkgMTE0LjgwOTYsNzEuNjM2OSBMMTMwLjE0MzYsNzEuNjM2OSBDMTMxLjE0NzYsNzEuNjM2OSAxMzEuOTYyNiw3Mi40NTA5IDEzMS45NjI2LDczLjQ1NDkgTDEzMS45NjI2LDgzLjAyMTkgQzEzMS45NjI2LDg3LjUzOTkgMTI4LjMwMDYsOTEuMjAxOSAxMjMuNzgyNiw5MS4yMDE5IiBtYXNrPSJ1cmwoI2IpIi8+PHBhdGggc3Ryb2tlPSIjMUUyMTI2IiBzdHJva2Utd2lkdGg9IjIiIGQ9Ik0xMjMuNzgyNiw5MS4yMDE5IEwxMjEuMTcyNiw5MS4yMDE5IEMxMTYuNjU0Niw5MS4yMDE5IDExMi45OTI2LDg3LjUzOTkgMTEyLjk5MjYsODMuMDIxOSBMMTEyLjk5MjYsNzMuNDU0OSBDMTEyLjk5MjYsNzIuNDUwOSAxMTMuODA1Niw3MS42MzY5IDExNC44MDk2LDcxLjYzNjkgTDEzMC4xNDM2LDcxLjYzNjkgQzEzMS4xNDc2LDcxLjYzNjkgMTMxLjk2MjYsNzIuNDUwOSAxMzEuOTYyNiw3My40NTQ5IEwxMzEuOTYyNiw4My4wMjE5IEMxMzEuOTYyNiw4Ny41Mzk5IDEyOC4zMDA2LDkxLjIwMTkgMTIzLjc4MjYsOTEuMjAxOSBaIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIG1hc2s9InVybCgjYikiLz48cGF0aCBmaWxsPSIjRUZFRkY0IiBkPSJNMTI2LjI3MDksODAuNTQ0NyBDMTI2LjI3MDksODIuNjQwNyAxMjQuNTcyOSw4NC4zMzg3IDEyMi40NzY5LDg0LjMzODcgQzEyMC4zODE5LDg0LjMzODcgMTE4LjY4MjksODIuNjQwNyAxMTguNjgyOSw4MC41NDQ3IEMxMTguNjgyOSw3OC40NDg3IDEyMC4zODE5LDc2Ljc1MDcgMTIyLjQ3NjksNzYuNzUwNyBDMTI0LjU3MjksNzYuNzUwNyAxMjYuMjcwOSw3OC40NDg3IDEyNi4yNzA5LDgwLjU0NDciIG1hc2s9InVybCgjYikiLz48cGF0aCBzdHJva2U9IiMxRTIxMjYiIHN0cm9rZS13aWR0aD0iMiIgZD0iTTEyNi4yNzA5IDgwLjU0NDdDMTI2LjI3MDkgODIuNjQwNyAxMjQuNTcyOSA4NC4zMzg3IDEyMi40NzY5IDg0LjMzODcgMTIwLjM4MTkgODQuMzM4NyAxMTguNjgyOSA4Mi42NDA3IDExOC42ODI5IDgwLjU0NDcgMTE4LjY4MjkgNzguNDQ4NyAxMjAuMzgxOSA3Ni43NTA3IDEyMi40NzY5IDc2Ljc1MDcgMTI0LjU3MjkgNzYuNzUwNyAxMjYuMjcwOSA3OC40NDg3IDEyNi4yNzA5IDgwLjU0NDd6TTExNC44OSA2My4wMTA1TDEyNC4yMzQgNzEuNjM2NU0xMTcuNDMzIDU3LjEwODJMMTMwLjA3NSA2OC43NzcyTTE0My45NDU3IDg4LjE3MjZMMTQzLjk0NTcgOTAuMTI0NkMxNDMuOTQ1NyA5My42MTY2IDE0MS4xMTQ3IDk2LjQ0NzYgMTM3LjYyMjcgOTYuNDQ3NkwxMTkuMzE1NyA5Ni40NDc2IiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIG1hc2s9InVybCgjYikiLz48cGF0aCBmaWxsPSIjRTRFOUY4IiBkPSJNMTQwLjE1MTcsNzUuMjg3OCBMMTQ3LjczOTcsNzUuMjg3OCBMMTQ3LjczOTcsODcuNjA0OCBDMTQ3LjczOTcsODguMTA2OCAxNDcuMzMzNyw4OC41MTQ4IDE0Ni44MzE3LDg4LjUxNDggTDE0MS4wNjA3LDg4LjUxNDggQzE0MC41NTg3LDg4LjUxNDggMTQwLjE1MTcsODguMTA2OCAxNDAuMTUxNyw4Ny42MDQ4IEwxNDAuMTUxNyw3NS4yODc4IFoiIG1hc2s9InVybCgjYikiLz48cGF0aCBzdHJva2U9IiMxRTIxMjYiIHN0cm9rZS13aWR0aD0iMiIgZD0iTTE0MC4xNTE3LDc1LjI4NzggTDE0Ny43Mzk3LDc1LjI4NzggTDE0Ny43Mzk3LDg3LjYwNDggQzE0Ny43Mzk3LDg4LjEwNjggMTQ3LjMzMzcsODguNTE0OCAxNDYuODMxNyw4OC41MTQ4IEwxNDEuMDYwNyw4OC41MTQ4IEMxNDAuNTU4Nyw4OC41MTQ4IDE0MC4xNTE3LDg4LjEwNjggMTQwLjE1MTcsODcuNjA0OCBMMTQwLjE1MTcsNzUuMjg3OCBaIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIG1hc2s9InVybCgjYikiLz48cGF0aCBmaWxsPSIjRkZGRkZGIiBkPSJNMTIzLjc2OTksNjQuNjE1IEMxMjMuNzY5OSw1My40NzEgMTMyLjgwMjksNDQuNDM5IDE0My45NDU5LDQ0LjQzOSBDMTU1LjA4ODksNDQuNDM5IDE2NC4xMjE5LDUzLjQ3MSAxNjQuMTIxOSw2NC42MTUgQzE2NC4xMjE5LDc1Ljc1OCAxNTUuMDg4OSw4NC43OSAxNDMuOTQ1OSw4NC43OSBDMTMyLjgwMjksODQuNzkgMTIzLjc2OTksNzUuNzU4IDEyMy43Njk5LDY0LjYxNSIgbWFzaz0idXJsKCNiKSIvPjxwYXRoIHN0cm9rZT0iIzFFMjEyNiIgc3Ryb2tlLXdpZHRoPSIyIiBkPSJNMTIzLjc2OTksNjQuNjE1IEMxMjMuNzY5OSw1My40NzEgMTMyLjgwMjksNDQuNDM5IDE0My45NDU5LDQ0LjQzOSBDMTU1LjA4ODksNDQuNDM5IDE2NC4xMjE5LDUzLjQ3MSAxNjQuMTIxOSw2NC42MTUgQzE2NC4xMjE5LDc1Ljc1OCAxNTUuMDg4OSw4NC43OSAxNDMuOTQ1OSw4NC43OSBDMTMyLjgwMjksODQuNzkgMTIzLjc2OTksNzUuNzU4IDEyMy43Njk5LDY0LjYxNSBaIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIG1hc2s9InVybCgjYikiLz48cGF0aCBzdHJva2U9IiMxRTIxMjYiIHN0cm9rZS13aWR0aD0iMiIgZD0iTTE0Ny43Njc5IDQ5LjQzMTRDMTQ2LjU0NDkgNDkuMTIzNCAxNDUuMjYzOSA0OC45NjA0IDE0My45NDU5IDQ4Ljk2MDQgMTM1LjMwMDkgNDguOTYwNCAxMjguMjkxOSA1NS45Njk0IDEyOC4yOTE5IDY0LjYxNTQgMTI4LjI5MTkgNzMuMjU5NCAxMzUuMzAwOSA4MC4yNjg0IDE0My45NDU5IDgwLjI2ODQgMTUyLjU5MDkgODAuMjY4NCAxNTkuNTk5OSA3My4yNTk0IDE1OS41OTk5IDY0LjYxNTQgMTU5LjU5OTkgNjAuNTUxNCAxNTguMDUwOSA1Ni44NTA0IDE1NS41MTI5IDU0LjA2ODRNMTUxLjY4NTkgNTEuMDA0NkMxNTIuMjY2OSA1MS4zMzY2IDE1Mi44MjQ5IDUxLjcwMzYgMTUzLjM1NTkgNTIuMTA0Nk0xNzkuMjUzMyA3OS40NDMxTDE3OS4yNTMzIDgyLjkzNTFNMTgxLjAwMDQgODEuMTg5MkwxNzcuNTA3NCA4MS4xODkyTTEzOS4wNTMxIDEuMzgyNkwxMzkuMDUzMSA0Ljg3NDZNMTQwLjc5OTIgMy4xMjg3TDEzNy4zMDcyIDMuMTI4N00xMDIuODgyMiAzNS44MDU0TDEwMi4wNTkyIDM2LjYyODRNOTguNzY2IDM5LjkyMTZMOTcuOTQzIDQwLjc0NDZNMTAyLjg4MjIgNDAuNzQ0OUwxMDIuMDU5MiAzOS45MjE5TTk4Ljc2NiAzNi42Mjg3TDk3Ljk0MyAzNS44MDU3TTE1Ny4wODI0IDEyLjc4OThDMTU3LjA4MjQgMTMuNzU0OCAxNTYuMzAwNCAxNC41MzY4IDE1NS4zMzY0IDE0LjUzNjggMTU0LjM3MTQgMTQuNTM2OCAxNTMuNTkwNCAxMy43NTQ4IDE1My41OTA0IDEyLjc4OTggMTUzLjU5MDQgMTEuODI1OCAxNTQuMzcxNCAxMS4wNDM4IDE1NS4zMzY0IDExLjA0MzggMTU2LjMwMDQgMTEuMDQzOCAxNTcuMDgyNCAxMS44MjU4IDE1Ny4wODI0IDEyLjc4OTh6IiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIG1hc2s9InVybCgjYikiLz48L2c+PC9nPjwvZz48L3N2Zz4=') !important;
}

/*9.k. Notifications*/
.notificationsSound-27jFSh {
    box-shadow:none !important;
}

/*9.l. Keybinds*/
.row-2okwlC {
	box-shadow:none !important;
}
.card-FDVird:before {
    background:rgba(0,0,0,0.5) !important;
    border:none !important;
    box-shadow:0px 0px 10px rgba(0,0,0,0.5);
}

/*9.m. Game Activity*/
.game-1ipmAa {
	box-shadow:none !important;
}
.da-notDetected {
	background:var(--main-color-faded) !important;
}
.addGamePopout-2RY8Ju,
.da-gameNameInput:hover,
.da-gameNameInput:focus,
.button-mM-y8i {
    background-color:rgba(0,0,0,0.75) !important;
    border:none;
}

/*9.n. Game Library*/
.installationPath-24giJj {
	box-shadow:none !important;
}
.background-yZEZik {
	stroke:rgba(0,0,0,0.5) !important;
}
.foreground-2aE44H {
	stroke:var(--hover-color) !important;
}
.da-defaultIndicator {
	background:var(--main-color);
}

/*9.o. Language*/
.item-3eFBNF {
    box-shadow:none !important;
}

/*9.p. Change Log*/
.improved-1F5LIN {
	color:var(--hover-color) !important;
}

/*9.q. Dev Options*/
.lookGhost-2Fn_0-.colorBrand-3pXr91 {
    background:var(--main-color-faded);
    color:var(--hover-color);
}

/*9.r. BD Settings*/
.bda-slist .bda-footer a {
	color:var(--hover-color);
}
h2.ui-form-title {
    text-transform:none !important;
}
#bd-settingspane-container .ui-switch-item .style-description {
	border:none;
}
.bd-pfbtn,
.bda-slist .bda-footer button {
    background:var(--main-color);
}
.bda-slist li {
    background:rgba(0,0,0,0.5) !important;
    transition:250ms all linear;
    border:none;
    box-shadow:0px 0px 10px rgba(0,0,0,0.7);
}
.bda-slist li:hover {
    transform:scale(1.02);
}
.barFill-23-gu- {
    background:var(--main-color) !important;
}
.bd-pfbtn {
    width:150px;
    height:25px;
    transition:250ms box-shadow;
}
.bd-pfbtn:hover {
    box-shadow:0px 2px 10px rgba(0,0,0,0.5);
}

/*9.s. Server Settings*/
.selectableItem-1MP3MQ.selected-31soGA {
    background:var(--main-color) !important;
}
.da-avatarUploaderInner {
	background-color:var(--hover-color) !important;
}
.emojiInput-1aLNse {
	background:transparent !important;
}
.autocompleteHeaderBackground-30T70q {
	background:transparent !important;
}
.autocompleteScroller-iInVqR::-webkit-scrollbar {
	display:none;
}
.da-auditLog,
.elevationHigh-1PneE4,
.da-colorPickerCustom,
.colorPickerSwatch-5GX3Ve.noColor-1pdBDm,
.popoutList-T9CKZQ,
.da-selectableItem:hover,
.header-2bNvm4,
.sectionTag-pXyto9,
.row-rrHHJU.selected-1pIgLL {
    background:rgba(0,0,0,0.5) !important;
    border:none !important;
    border-radius:5px !important;
}
img[src="/assets/5fb477ca84edd15d9a2888ac28365acd.svg"] {
    filter:hue-rotate(1000deg) !important;
}
.actionButton-VzECiy {
  border-color:var(--hover-color) !important;
}
.divider-1pnAR2 {
  display:none;
}
.headerExpanded-CUEwZ5 {
  background:rgba(0,0,0,0.25) !important;
}

/*9.t. Ace CSS Editor*/
#bd-customcss-detach-container {
	width: calc(27% - 10px);
}
.ace_selection, #editor-detached button {
	background:var(--hover-color) !important;
}
.ace_content {
	background:rgba(0,0,0,0.4) !important;
}
.ace-monokai .ace_marker-layer .ace_active-line {
	background:rgba(0,0,0,0.7) !important;
}
.ace-monokai .ace_gutter {
	background:transparent !important;
	color:var(--hover-color) !important;
}
.ace-monokai, #bd-customcss-detach-container {
	background:transparent !important;
}
.ace_gutter-layer {
	background:rgba(0,0,0,0.75) !important;
}
.ace-monokai {
	border-radius:5px 5px 0px 0px !important;
}
#bd-customcss-attach-controls {
    background: rgba(0,0,0,0.7) !important;
    box-shadow: none !important;
}
.bd-detached-css-editor #bd-customcss-attach-controls button, .standardSidebarView-3F1I7i #bd-customcss-attach-controls button {
    background: var(--main-color) !important;
    border-right:none !important;
    border-radius: 3px !important;
    border:none !important;
    margin-left: 5px !important;
}
.ace_scrollbar-h::-webkit-scrollbar {
    background:rgba(0,0,0,0.99) !important;
    height:6px !important;
    border-radius:50px !important;
}
.ace_scrollbar-h::-webkit-scrollbar-thumb, .ace_text-input {
    background:var(--hover-color) !important;
    border-radius:50px !important;
}
#ace_settingsmenu {
	position: absolute;
	top: 10vh;
	right: 20vw;
	bottom: 10vh;
	left: 20vw;
	background-color: #36393f;
	border-radius: 5px;
	padding-right: 20px;
    box-shadow: 0 0 0 1px rgba(32,34,37,.6), 0 2px 10px 0 rgba(0,0,0,.2);
}
#ace_settingsmenu::-webkit-scrollbar {
    height: 8px;
    width: 8px;
}
#ace_settingsmenu::-webkit-scrollbar-thumb {
    background-color: rgba(32,34,37,.6);
    border: 2px solid transparent;
    border-radius: 4px;
}
#ace_settingsmenu::-webkit-scrollbar-track {
    background-color: transparent;
    border: 2px solid transparent;
}
#ace_settingsmenu .ace_optionsMenuEntry {
    height: 40px;
	display: flex;
	align-items: center;
	justify-content: flex-start;
	margin-bottom: 10px;
}
#ace_settingsmenu .ace_optionsMenuEntry:hover {
	background: none;
}
#ace_settingsmenu > *:last-child {
    color: #f6f6f7;
	float: right;
}
#ace_settingsmenu .ace_optionsMenuEntry label {
    color: #f6f6f7;
    font-size: 16px;
    line-height: 24px;
    cursor: pointer;
    flex: 1 0 auto;
    font-weight: 500;
	margin-right: 10px;
}
#ace_settingsmenu .ace_optionsMenuEntry input[type="text"],
#ace_settingsmenu .ace_optionsMenuEntry select {
	box-sizing: border-box;
    flex: 0 1 auto;
	width: 200px;
	float: none !important;
    background-color: rgba(0,0,0,.1);
    border-color: rgba(0,0,0,.3);
    color: #f6f6f7;
    height: 40px;
    padding: 10px;
    border-radius: 3px;
    border-style: solid;
    border-width: 1px;
    transition: background-color .15s ease,border .15s ease;
    font-size: 16px;
}
#ace_settingsmenu .ace_optionsMenuEntry input[type="text"]:hover,
#ace_settingsmenu .ace_optionsMenuEntry select:hover {
	border-color: #040405;
}
#ace_settingsmenu .ace_optionsMenuEntry input[type="text"]:focus,
#ace_settingsmenu .ace_optionsMenuEntry select:focus {
	border-color: #7289da;
}
#ace_settingsmenu .ace_optionsMenuEntry select option {
    background-color: #303339;
    color: #f6f6f7;
}
#ace_settingsmenu input[type="checkbox"] {
    position: relative;
		cursor:pointer;
    width: 44px;
    height: 24px;
	float: none !important;
}
#ace_settingsmenu input[type="checkbox"]:before {
    content: "";
    display: block;
    position: relative;
    width: 44px;
    height: 24px;
    background: #72767d;
    border-radius: 14px;
    transition: background .15s ease-in-out,box-shadow .15s ease-in-out,border .15s ease-in-out;
}
#ace_settingsmenu input[type="checkbox"]:checked:before {
    background: #7289da;
}
#ace_settingsmenu input[type="checkbox"]:after {
    content: "";
    display: block;
    width: 18px;
    height: 18px;
    position: absolute;
    top: 3px;
    left: 3px;
    bottom: 3px;
    background: #f6f6f7;
    border-radius: 10px;
    transition: all .15s ease;
    box-shadow: 0 3px 1px 0 rgba(0,0,0,.05), 0 2px 2px 0 rgba(0,0,0,.1), 0 3px 3px 0 rgba(0,0,0,.05);
}
#ace_settingsmenu input[type="checkbox"]:checked:after {
    transform: translateX(20px);
}
.ace_closeButton {
	position: absolute;
	height: 35px;
	width: 35px;
	top: calc(10vh - 13px);
	right: calc(20vw - 13px);
	z-index: 10000;
	background-color: #36393f;
    border-radius: 50%;
    border: 2px solid #72767d;
	padding: 0;
	cursor: pointer;
}
.ace_closeButton:before {
	content: "✖";
	color: #dcddde;
	margin-left: 11px;
	line-height: 34px;
	text-align: center;
	vertical-align: middle;
}
.ace_closeButton:hover {
	filter: brightness(120%);
}

/*9.u Changelog*/
#bd-settingspane-container .bda-slist::before {
  content:"What's new in Aurora 2.x\A -Collapsed Search bar \A -Many new addons \A-Light Theme Blocker \A-New Unread/Selected Indicators \A-Redesigned User Profile Modal\A-New Titlebar \A-Remove Compatibility Tags \A-Changed Server Dropdown \A-New Context Menu Animations \A-Redesigned Account Details Container \A-Members List Tweaks \A-Rework Variable System for var(--main-color); \A-Color Discords Grey SVG's\A-New Group DM Icon \A-Category Animations \A-Redesign Reactions \A-Tall Emoji Picker \A-New Loading Screen Container \A Support server:https://bit.ly/derealised.";
  display: block;
  line-height:22px;
  font-size:18px;
  position: relative;
  background: var(--main-color);
  padding: 10px 15px;
  white-space: pre;
  margin-bottom: 15px;
  border-radius: 4px;
  box-shadow: 0 0 10px rgba(0,0,0,0.4);
  font-weight: 500;
  margin-top:-10px;
  color: #fff;
  text-transform: none;
  overflow:hidden;
  width:fit-content;
}
/*============== END OF SECTION ============== */

/*10. Tag Animations*/
/*10.a. Keyframes*/

@keyframes fadeFromTop {
  0% {
      opacity: 0;
      transform: translateY(-50%)
  }
  100% {
      opacity: 0.9;
      transform: none
  }
}

@keyframes fadeFromRight {
  0% {
      opacity: 0;
      transform: translateX(50%)
  }
  100% {
      opacity: 0.9;
      transform: none
  }
}

@keyframes fadeFromBottom {
  0% {
      opacity: 0;
      transform: translateY(50%)
  }
  100% {
      opacity: 0.9;
      transform: none
  }
}

@keyframes fadeFromLeft {
  0% {
      opacity: 0;
      transform: translateX(-50%)
  }
  100% {
      opacity: 0.9;
      transform: none
  }
}

@keyframes slide-left {
  from {
    transform: translate(-100);
  }
}

@keyframes slide-right {
  from {
    transform: translate(100%);
  }
}

@-webkit-keyframes mentionpulse {
  0% {
    -webkit-box-shadow: 0 0 0 0 var(--hover-color);
  }
  70% {
    -webkit-box-shadow: 0 0 0 5px rgba(204, 169, 44, 0);
  }
  100% {
    -webkit-box-shadow: 0 0 0 0 rgba(204, 169, 44, 0);
  }
}

@keyframes show-status {
  from {
    transform: translateY(100%) translateX(0%) translateZ(0px);
  }
}

@keyframes status {
  from {
    transform: scale(0);
    opacity: 0
  }
}

@keyframes context-open-invertY {
  0% {
    padding-top: 0px;
    padding-bottom: 0px;
    margin-top: 0px;
  }
}

@keyframes context-open-new {
  0% {
    transform: scale(1, 0.8);
  }
}

@keyframes context-open {
  0% {
    padding-top: 0px;
    padding-bottom: 0px;
  }
}

@keyframes popoutanim-inner {
  0% {
    transform: scale(2);
  }
  100% {
    transform: scale(1);
  }
}

@keyframes popoutanim {
  0% {
    transform: scale(0);
  }
  100% {
    transform: scale(1);
  }
}
/*============== END OF SECTION ============== */

/*11. Store, Activity, Library Friends, and Server Discovery*/
/*11. Store*/
.tileMedia-24cT6_,
.tile-QA_yMc,
.tileMedia-1q3guD {
  background-color:rgba(0,0,0,0.5) !important;
}
.categoryHeader-1D7Tqy {
	 border-bottom:2px solid var(--hover-color) !important;
}
.gradientOverlayLeft-3w159C,
.gradientOverlayRight-3vMuS8 {
  display:none;
}
.genreTag-3QLRUJ {
  color:#fff !important;
}
.genreTag-3QLRUJ,
.perkTag-2O4dx4 {
	background:var(--main-color) !important;
}
.perkTag-2O4dx4 {
	border-radius:3px !important;
}
.applicationStore-1pNvnv,
.popout-2xBvMR {
	background:var(--backdropblurred) !important;
	background-size:cover  !important;
	background-repeat: no-repeat !important;
	background-attachment: fixed !important;
}
.tileMedia-24cT6_ {
  background-color:rgba(0,0,0,0.5) !important;
}
.itemBackground-2vEldQ:before,
.itemBackground-2vEldQ {
	border-radius:10px !important;
}
.article-3kb3qm {
    background-color:rgba(0,0,0,0.25) !important;
}
.section-7tu4tu {
	border:none !important;
}
.mediaFade-1SdEfL {
	background: linear-gradient(180deg,transparent 90%,rgba(0,0,0,0.75)) !important;
}
.description-3rB3Rp {
	background: linear-gradient(180deg,transparent,rgba(0,0,0,.75) 45%,rgba(0,0,0,0.75)) !important;
}
.announcingNitro-3Ptg6m,
.arrow-1QsYio,
.purchaseUnitOperatingSystem-cnbJPz {
	color:var(--hover-color) !important;
}
.distributionApplicationsActions-3D2_kD,
.premiumApplicationsHeader-Zmkm5e,
.sortFilterBar-3hePOV {
	 border-bottom:2px solid var(--hover-color) !important;
}
.da-playerOverflow {
    background-color:var(--hover-color) !important;
}
.focused-1Yu0L3,
.tile-367QuY,
.browseSearchInput-Jt8kg0,
.whyYouMightLikeIt-2zZIIj,
.bodySection-jqkkIP,
.content-35aVm0,
.item-2yFVoY,
.row-1bU71H,
.card-NB61oR,
.searchBox-3Y2Vi7,
.popout-2sKjHu {
	background:rgba(0,0,0,0.5) !important;
	border:none !important;
}
.mediaBarGrabber-1FqnbN,
.mediaBarProgress-1xaPtl,
.mediaBarProgress-1xaPtl:after,
.mediaBarProgress-1xaPtl:before {
    background:var(--hover-color) !important;
}
.headerFancy-1AcCLF,
.entitledHeader-3LRNDT,
.tag-HanR-9,
.premium-39U29H {
	background:var(--main-color) !important;
}
.carouselContainer-1cw6QH {
	margin-top:20px !important;
}
.footer-3oZnEF {
    opacity:.6 !important;
background:url(data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxOTAiIGhlaWdodD0iMTY0IiB2aWV3Qm94PSIwIDAgMTkwIDE2NCI+ICA8ZyBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPiAgICA8cGF0aCBmaWxsPSIjNEY1NDVDIiBmaWxsLW9wYWNpdHk9Ii4zIiBkPSJNNDcuNDg1LDE2NC4xNTkyIEwxNjAuMDc5LDE2NC4xNTkyIEMxNjcuNjkzLDE2NC4xNTkyIDE5MCwxNTkuMjE5MiAxOTAsMTM0Ljk0NTIgQzE5MCwxMTAuNTM4MiAxNTUuMDI0LDEwNi45MDMyIDE0NS45NzQsMTA0LjkxNTIgQzEzMy4wNzIsMTAyLjA3OTIgMTIwLjM4Miw4OS4yNjUyIDExMi4zNTMsNzIuMzYzMiBDMTA3LjQ2Niw2Mi4wNzYyIDEwMy4zMTQsNTAuNzEzMiA5Ny42NTQsNDEuNjEzMiBDOTAuNDE4LDI5Ljk3OTIgNzguODM1LDIxLjkxNDIgNjkuMzQsMzAuNTI5MiBDNjMuMjQ0LDM2LjA2MDIgNTkuNzE0LDQ3LjAzODIgNTQuNjE0LDU0LjkxNDIgQzQ2Ljc1NSw2Ny4wNTIyIDM1LjczNiw3MS4wOTQyIDI1LjI5MSw3NC44MTcyIEMxOS42OTIsNzYuODEzMiAxMy45NjEsNzguOTQ0MiA5LjE1Myw4NC4xNjAyIEMzLjU4Miw5MC4yMDUyIC0xLjA5NiwxMDQuNjkxMiAwLjIyNiwxMTYuMDA3MiBDNC45MzEsMTU2LjI3MTIgNDUuNzI4LDE2My4zODYyIDQ3LjQ4NSwxNjQuMTU5MiIvPiAgICA8cGF0aCBmaWxsPSIjNEY1NDVDIiBmaWxsLW9wYWNpdHk9Ii4zIiBkPSJNMTgxLjIzOTksNzcuMDU1NyBDMTgxLjg5NjksNjQuMzQ0NyAxNjYuMzI4OSw1MC4yMzY3IDE1Ni40MjE5LDQ1LjMwNDcgQzE0OC40NTQ5LDQxLjMzODcgMTM2Ljk4NjksNDAuMDQ0NyAxMzAuOTQzOSw0OC4yNDE3IEMxMjQuNzY5OSw1Ni42MTU3IDEyOS43OTI5LDcwLjIxODcgMTM1LjgyOTksNzcuMTg5NyBDMTQ0LjAwNjksODYuNjMwNyAxNjIuMDMzOSw5OC4wNDY3IDE3NC4wODI5LDg5LjExOTcgQzE3OC45MTc5LDg1LjUzNjcgMTgxLjAxNTksODEuMzc2NyAxODEuMjM5OSw3Ny4wNTU3Ii8+ICAgIDxwb2x5Z29uIGZpbGw9IiM0RjU0NUMiIHBvaW50cz0iNDcuNDg1IDE2NC4xNTkgMTE4LjEgMTY0LjE1OSAxMTguMSAxMTEuNzE4IDQ3LjQ4NSAxMTEuNzE4Ii8+ICAgIDxwb2x5Z29uIGZpbGw9IiM0RjU0NUMiIHBvaW50cz0iNjcuODgzIDM3LjQzNiA4NC4wNDkgMzcuNDM2IDY4LjU3NSA5Mi43MDcgNTEuOTg0IDkyLjcwNyIvPiAgICA8cG9seWdvbiBmaWxsPSIjMjAyMjI1IiBwb2ludHM9IjExNy41MSAxMi45ODcgMTE3LjUxIDM3LjQzNSAxMzEuNDY1IDM3LjQzNSA5OS42MTEgNzQuNjMxIDk3LjYxNSA5MS41NCA5OS41ODkgMTA3LjgwNiAxMTMuNDkxIDExMS44NDQgMTEzLjQ5MSAxNjQuMTU5IDE1NC42OTEgMTY0LjE1OSAxNTQuNjkxIDEyLjk4NyIvPiAgICA8cG9seWdvbiBmaWxsPSIjQjlCQkJFIiBwb2ludHM9IjU5Ljc1NyA5MS4yNjkgMTE1Ljk4IDkxLjI2OSAxMzEuNDY1IDM3LjQzNiAxMTcuNTEgMzcuNDM2IDc1LjMyOCAzNy40MzYiLz4gICAgPGcgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoNyAtLjg0MSkiPiAgICAgIDxwYXRoIGZpbGw9IiNGNkY2RjciIGQ9Ik0xMTkuODY5OCwxMDUuODk0NyBMMTMzLjkzMzgsMTA2LjAwODcgQzEzNC44NzY4LDEwNC42MTM3IDEzNS4zNzI4LDEwMy4wMDI3IDEzNS4zNzI4LDEwMS4zMjA3IEMxMzUuMzcyOCw5Ni42NzA3IDEzMS41ODk4LDkyLjg4NzcgMTI2LjkzOTgsOTIuODg3NyBDMTIyLjI4OTgsOTIuODg3NyAxMTguNTA2OCw5Ni42NzA3IDExOC41MDY4LDEwMS4zMjA3IEMxMTguNTA2OCwxMDIuOTUxNyAxMTguOTc1OCwxMDQuNTIyNyAxMTkuODY5OCwxMDUuODk0NyBaIE0xMzQuOTM1OCwxMDguMDE2NyBMMTE4LjgzNDgsMTA3Ljg4NTcgTDExOC41Mzc4LDEwNy40ODI3IEMxMTcuMjA4OCwxMDUuNjczNyAxMTYuNTA2OCwxMDMuNTQyNyAxMTYuNTA2OCwxMDEuMzIwNyBDMTE2LjUwNjgsOTUuNTY4NyAxMjEuMTg2OCw5MC44ODc3IDEyNi45Mzk4LDkwLjg4NzcgQzEzMi42OTI4LDkwLjg4NzcgMTM3LjM3MjgsOTUuNTY4NyAxMzcuMzcyOCwxMDEuMzIwNyBDMTM3LjM3MjgsMTAzLjYwNjcgMTM2LjYzNTgsMTA1Ljc4NDcgMTM1LjIzOTgsMTA3LjYxODcgTDEzNC45MzU4LDEwOC4wMTY3IFoiLz4gICAgICA8cG9seWdvbiBmaWxsPSIjMjAyMjI1IiBwb2ludHM9Ijc2Ljk5MyAxNDQuODk5IDgyLjMyMyAxNDQuODk5IDgyLjMyMyAxMjEuOTczIDc2Ljk5MyAxMjEuOTczIi8+ICAgICAgPHBvbHlnb24gZmlsbD0iIzRGNTQ1QyIgcG9pbnRzPSI1MC41NTcgMTM0LjM5NyA3NS4zNDYgMTM0LjM5NyA3NS4zNDYgMTIzLjU5IDUwLjU1NyAxMjMuNTkiLz4gICAgICA8cGF0aCBmaWxsPSIjQjlCQkJFIiBkPSJNNzQuNzA3NywxMzMuMTM4OSBMNjMuMDYzNywxMzMuMTM4OSBMNjIuMTgzNywxMzMuMTM4OSBMNTAuOTM2NywxMzMuMTM4OSBMNTAuOTM2NywxMjQuMjU2OSBMNjIuMjUxNywxMjQuMjU2OSBMNjMuMDU1NywxMjQuMjU2OSBMNzQuNzA3NywxMjQuMjU2OSBMNzQuNzA3NywxMzMuMTM4OSBaIE03NC42NjU3LDEyMS45NzI5IEw2My4wNTU3LDEyMS45NzI5IEw2Mi4yNTE3LDEyMS45NzI5IEw0OC42NTA3LDEyMS45NzI5IEw0OC42NTA3LDE0NC44OTg5IEw2Mi4yNTE3LDE0NC44OTg5IEw2My4wNjM3LDE0NC44OTg5IEw3NC42NjU3LDE0NC44OTg5IEw3Ni45OTE3LDE0NC44OTg5IEw3Ni45OTE3LDEyMS45NzI5IEw3NC42NjU3LDEyMS45NzI5IFoiLz4gICAgICA8cG9seWdvbiBmaWxsPSIjMzYzOTNGIiBwb2ludHM9IjEyMC41ODYgMTAyLjA2MyAxMTguMzA0IDEwOS43NyAxNDAuOTM2IDExNi40NzQgMTQzLjIxOCAxMDguNzY3Ii8+ICAgICAgPHBvbHlnb24gZmlsbD0iI0Y2RjZGNyIgcG9pbnRzPSI2NC4xOTggOTIuMTA5IDY1LjYzNSA5Mi4xMDkgNjUuNjM1IDg0LjExOCA2NC4xOTggODQuMTE4Ii8+ICAgICAgPHBvbHlnb24gZmlsbD0iI0Y2RjZGNyIgcG9pbnRzPSIzNC4zNTUgOTIuMTA5IDM1Ljc5MiA5Mi4xMDkgMzUuNzkyIDg0LjExOCAzNC4zNTUgODQuMTE4Ii8+ICAgICAgPHBhdGggZmlsbD0iIzcyNzY3RCIgZD0iTTY0LjkxNjcsODUuMzY2NCBDNjYuNzU5Nyw4NS4zNjY0IDY4LjI1ODcsODMuODY2NCA2OC4yNTg3LDgyLjAyNDQgQzY4LjI1ODcsODAuMTgxNCA2Ni43NTk3LDc4LjY4MTQgNjQuOTE2Nyw3OC42ODE0IEM2My4wNzM3LDc4LjY4MTQgNjEuNTc0Nyw4MC4xODE0IDYxLjU3NDcsODIuMDI0NCBDNjEuNTc0Nyw4My44NjY0IDYzLjA3MzcsODUuMzY2NCA2NC45MTY3LDg1LjM2NjQiLz4gICAgICA8cGF0aCBmaWxsPSIjMzYzOTNGIiBkPSJNNDUuOTAyIDg5LjQ0MjZMNDEuODQxIDg5LjQ0MjZDNDEuNDkyIDg5LjQ0MjYgNDEuMjA3IDg5LjcyNjYgNDEuMjA3IDkwLjA3NzZMNDEuMjA3IDkyLjEwOTYgNDYuNTM3IDkyLjEwOTYgNDYuNTM3IDkwLjA3NzZDNDYuNTM3IDg5LjcyNjYgNDYuMjUzIDg5LjQ0MjYgNDUuOTAyIDg5LjQ0MjZNNTEuMzU5IDkyLjEwOTZMNTYuNjg5IDkyLjEwOTYgNTYuNjg5IDkwLjA3NzZDNTYuNjg5IDg5LjcyNjYgNTYuNDA0IDg5LjQ0MjYgNTYuMDU0IDg5LjQ0MjZMNTEuOTkzIDg5LjQ0MjZDNTEuNjQzIDg5LjQ0MjYgNTEuMzU5IDg5LjcyNjYgNTEuMzU5IDkwLjA3NzZMNTEuMzU5IDkyLjEwOTZ6TTc2Ljk5MjggOTIuMTA5Nkw3Ni45OTI4IDkwLjA3NzZDNzYuOTkyOCA4OS43MjY2IDc2LjcwNzggODkuNDQyNiA3Ni4zNTY4IDg5LjQ0MjZMNzIuMjk2OCA4OS40NDI2QzcxLjk0NjggODkuNDQyNiA3MS42NjE4IDg5LjcyNjYgNzEuNjYxOCA5MC4wNzc2TDcxLjY2MTggOTIuMTA5NiA3Ni45OTI4IDkyLjEwOTZ6TTg3LjE0NDIgOTIuMTA5Nkw4Ny4xNDQyIDkwLjA3NzZDODcuMTQ0MiA4OS43MjY2IDg2Ljg1OTIgODkuNDQyNiA4Ni41MDkyIDg5LjQ0MjZMODIuNDQ5MiA4OS40NDI2QzgyLjA5ODIgODkuNDQyNiA4MS44MTQyIDg5LjcyNjYgODEuODE0MiA5MC4wNzc2TDgxLjgxNDIgOTIuMTA5NiA4Ny4xNDQyIDkyLjEwOTZ6Ii8+ICAgICAgPHBvbHlnb24gZmlsbD0iIzRGNTQ1QyIgcG9pbnRzPSI1MC45MzYgMTQxLjk2MiA1Ni4xMjEgMTQxLjk2MiA1Ni4xMjEgMTM1Ljc4NiA1MC45MzYgMTM1Ljc4NiIvPiAgICAgIDxwb2x5Z29uIGZpbGw9IiM0RjU0NUMiIHBvaW50cz0iNjEuNzc0IDE0MS45NjIgNzQuMzQ4IDE0MS45NjIgNzQuMzQ4IDEzNS43ODYgNjEuNzc0IDEzNS43ODYiLz4gICAgICA8cGF0aCBmaWxsPSIjQjlCQkJFIiBkPSJNMTMwLjc2MDQsMTkuODQzIEMxMzEuMjYyNCwxOS44NDMgMTMxLjY3MTQsMjAuMjUyIDEzMS42NzE0LDIwLjc1NCBDMTMxLjY3MTQsMjEuMjU2IDEzMS4yNjI0LDIxLjY2NSAxMzAuNzYwNCwyMS42NjUgQzEzMC4yNTg0LDIxLjY2NSAxMjkuODQ5NCwyMS4yNTYgMTI5Ljg0OTQsMjAuNzU0IEMxMjkuODQ5NCwyMC4yNTIgMTMwLjI1ODQsMTkuODQzIDEzMC43NjA0LDE5Ljg0MyBNMTMwLjc2MDQsMjIuODY1IEMxMzEuOTI0NCwyMi44NjUgMTMyLjg3MTQsMjEuOTE4IDEzMi44NzE0LDIwLjc1NCBDMTMyLjg3MTQsMTkuNTkgMTMxLjkyNDQsMTguNjQzIDEzMC43NjA0LDE4LjY0MyBDMTI5LjU5NjQsMTguNjQzIDEyOC42NDk0LDE5LjU5IDEyOC42NDk0LDIwLjc1NCBDMTI4LjY0OTQsMjEuOTE4IDEyOS41OTY0LDIyLjg2NSAxMzAuNzYwNCwyMi44NjUiLz4gICAgICA8cGF0aCBmaWxsPSIjNzI3NjdEIiBkPSJNMzYuMjI5MSw2OS42MDA4IEMzNi4yMjkxLDY5Ljg4MjggMzYuNDU3MSw3MC4xMTE4IDM2LjczOTEsNzAuMTExOCBDMzcuMDIyMSw3MC4xMTE4IDM3LjI1MDEsNjkuODgyOCAzNy4yNTAxLDY5LjYwMDggQzM3LjI1MDEsNjguNTA3OCAzOC4xMzUxLDY3LjYyMTggMzkuMjI4MSw2Ny42MjE4IEwzOS4yMjkxLDY3LjYyMTggQzM5LjUxMTEsNjcuNjIxOCAzOS43NDAxLDY3LjM5MzggMzkuNzQwMSw2Ny4xMTE4IEMzOS43NDAxLDY2LjgyOTggMzkuNTExMSw2Ni42MDA4IDM5LjIyOTEsNjYuNjAwOCBMMzkuMjI4MSw2Ni42MDA4IEMzOC4xMzUxLDY2LjYwMDggMzcuMjUwMSw2NS43MTQ4IDM3LjI1MDEsNjQuNjIxOCBDMzcuMjUwMSw2NC4zMzk4IDM3LjAyMjEsNjQuMTExOCAzNi43MzkxLDY0LjExMTggQzM2LjQ1NzEsNjQuMTExOCAzNi4yMjkxLDY0LjMzOTggMzYuMjI5MSw2NC42MjE4IEMzNi4yMjkxLDY1LjcxNDggMzUuMzQzMSw2Ni42MDA4IDM0LjI1MDEsNjYuNjAwOCBDMzMuOTY4MSw2Ni42MDA4IDMzLjc0MDEsNjYuODI5OCAzMy43NDAxLDY3LjExMTggQzMzLjc0MDEsNjcuMzkzOCAzMy45NjgxLDY3LjYyMTggMzQuMjUwMSw2Ny42MjE4IEMzNS4zNDMxLDY3LjYyMTggMzYuMjI5MSw2OC41MDc4IDM2LjIyOTEsNjkuNjAwOCIvPiAgICAgIDxwYXRoIGZpbGw9IiM0RjU0NUMiIGQ9Ik0xMTkuMjgzOCAzLjE0MThDMTE5LjUwNzggMy4xNDE4IDExOS43MTU4IDMuMDQxOCAxMTkuODU1OCAyLjg2NzhMMTIwLjUyNDggMi4wMzQ4QzEyMC43Nzg4IDEuNzE4OCAxMjAuNzI4OCAxLjI1NTggMTIwLjQxMzggMS4wMDE4IDEyMC4yNjE4Ljg3OTggMTIwLjA3NDguODIzOCAxMTkuODczOC44NDQ4IDExOS42Nzg4Ljg2NjggMTE5LjUwMzguOTYxOCAxMTkuMzgxOCAxLjExNThMMTE4LjcxMTggMS45NDc4QzExOC41ODg4IDIuMTAwOCAxMTguNTMyOCAyLjI5MTggMTE4LjU1NDggMi40ODc4IDExOC41NzQ4IDIuNjgyOCAxMTguNjcxOCAyLjg1NzggMTE4LjgyNDggMi45ODA4IDExOC45NTQ4IDMuMDg0OCAxMTkuMTE3OCAzLjE0MTggMTE5LjI4MzggMy4xNDE4TTExNi4wMTMzIDQuNTk0OUwxMTUuMzQzMyA1LjQyNzlDMTE1LjIyMDMgNS41Nzk5IDExNS4xNjQzIDUuNzcyOSAxMTUuMTg2MyA1Ljk2NzkgMTE1LjIwNzMgNi4xNjI5IDExNS4zMDMzIDYuMzM3OSAxMTUuNDU1MyA2LjQ1ODkgMTE1LjU4NTMgNi41NjM5IDExNS43NDgzIDYuNjIxOSAxMTUuOTE1MyA2LjYyMTkgMTE2LjEzOTMgNi42MjE5IDExNi4zNDgzIDYuNTIxOSAxMTYuNDg4MyA2LjM0NjlMMTE3LjE1ODMgNS41MTM5QzExNy40MDkzIDUuMTk4OSAxMTcuMzYwMyA0LjczNjkgMTE3LjA0NDMgNC40ODE5IDExNi43MjkzIDQuMjI5OSAxMTYuMjY2MyA0LjI3OTkgMTE2LjAxMzMgNC41OTQ5TTEyMC42MzU0IDUuMjg5M0wxMTkuOTEzNCA0LjQ5MjNDMTE5Ljc4MjQgNC4zNDczIDExOS42MDM0IDQuMjYxMyAxMTkuNDA3NCA0LjI1MTMgMTE5LjE5ODQgNC4yMzQzIDExOS4wMjI0IDQuMzA4MyAxMTguODc0NCA0LjQzOTMgMTE4LjcyOTQgNC41NzEzIDExOC42NDQ0IDQuNzUyMyAxMTguNjM0NCA0Ljk0NzMgMTE4LjYyNDQgNS4xNDMzIDExOC42OTI0IDUuMzMyMyAxMTguODIzNCA1LjQ3NjNMMTE5LjU0NTQgNi4yNzIzQzExOS42ODM0IDYuNDI3MyAxMTkuODgyNCA2LjUxNjMgMTIwLjA5MDQgNi41MTYzIDEyMC4yNzM0IDYuNTE2MyAxMjAuNDQ4NCA2LjQ0ODMgMTIwLjU4MzQgNi4zMjYzIDEyMC43Mjk0IDYuMTk0MyAxMjAuODE1NCA2LjAxNDMgMTIwLjgyNDQgNS44MTczIDEyMC44MzM0IDUuNjIxMyAxMjAuNzY2NCA1LjQzNDMgMTIwLjYzNTQgNS4yODkzTTExNS45NTY3IDIuOTcwOUMxMTYuMDk1NyAzLjEyMzkgMTE2LjI5MzcgMy4yMTE5IDExNi41MDA3IDMuMjExOSAxMTYuNjgzNyAzLjIxMTkgMTE2Ljg1ODcgMy4xNDQ5IDExNi45OTM3IDMuMDIyOSAxMTcuMjkzNyAyLjc1MDkgMTE3LjMxNjcgMi4yODU5IDExNy4wNDU3IDEuOTg1OUwxMTYuMzIxNyAxLjE4NzlDMTE2LjA1MDcuODg4OSAxMTUuNTg1Ny44NjU5IDExNS4yODQ3IDEuMTM1OSAxMTQuOTg0NyAxLjQwNzkgMTE0Ljk2MTcgMS44NzE5IDExNS4yMzI3IDIuMTcyOUwxMTUuOTU2NyAyLjk3MDl6Ii8+ICAgICAgPHBhdGggZmlsbD0iIzcyNzY3RCIgZD0iTTMxLjczMjEsODIuMDI0NiBDMzEuNzMyMSw4My44NjY2IDMzLjIzMTEsODUuMzY2NiAzNS4wNzQxLDg1LjM2NjYgQzM2LjkxNzEsODUuMzY2NiAzOC40MTYxLDgzLjg2NjYgMzguNDE2MSw4Mi4wMjQ2IEMzOC40MTYxLDgwLjE4MTYgMzYuOTE3MSw3OC42ODE2IDM1LjA3NDEsNzguNjgxNiBDMzMuMjMxMSw3OC42ODE2IDMxLjczMjEsODAuMTgxNiAzMS43MzIxLDgyLjAyNDYiLz4gICAgICA8cGF0aCBmaWxsPSIjQjlCQkJFIiBkPSJNMC4yMzIxLDE0Mi4yMTYgQzAuMjMyMSwxNDQuMDU5IDEuNzMxMSwxNDUuNTU4IDMuNTc0MSwxNDUuNTU4IEM1LjQxNzEsMTQ1LjU1OCA2LjkxNjEsMTQ0LjA1OSA2LjkxNjEsMTQyLjIxNiBDNi45MTYxLDE0MC4zNzMgNS40MTcxLDEzOC44NzQgMy41NzQxLDEzOC44NzQgQzEuNzMxMSwxMzguODc0IDAuMjMyMSwxNDAuMzczIDAuMjMyMSwxNDIuMjE2Ii8+ICAgICAgPHBvbHlnb24gZmlsbD0iIzcyNzY3RCIgcG9pbnRzPSIyNy43MjkgMTEyLjU1OSA5MC42MTUgMTEyLjU1OSA5MC42MTUgOTEuODg4IDI3LjcyOSA5MS44ODgiLz4gICAgICA8cG9seWdvbiBmaWxsPSIjMjAyMjI1IiBwb2ludHM9Ijg5LjI0NCAxMTIuNTU5IDExMS4xIDExMi41NTkgMTExLjEgOTEuODg4IDg5LjI0NCA5MS44ODgiLz4gICAgICA8cGF0aCBmaWxsPSIjMjAyMjI1IiBkPSJNNjQuMDAyNiA2My4zNTg2TDY1LjI1NDYgNjkuMDkzNk02NS4yNTA2IDcyLjY4ODdDNjMuNTk4NiA3Mi42ODg3IDYyLjExMDYgNzEuNTQxNyA2MS43NDM2IDY5Ljg2MDdMNjAuNDkwNiA2NC4xMjU3QzYwLjA2NzYgNjIuMTg2NyA2MS4yOTY2IDYwLjI3MDcgNjMuMjM1NiA1OS44NDc3IDY1LjE3NTYgNTkuNDI1NyA2Ny4wOTA2IDYwLjY1MjcgNjcuNTEzNiA2Mi41OTE3TDY4Ljc2NTYgNjguMzI2N0M2OS4xODg2IDcwLjI2NTcgNjcuOTYwNiA3Mi4xODE3IDY2LjAyMTYgNzIuNjA0NyA2NS43NjI2IDcyLjY2MTcgNjUuNTA1NiA3Mi42ODg3IDY1LjI1MDYgNzIuNjg4NyIvPiAgICAgIDxwYXRoIGZpbGw9IiMyMDIyMjUiIGQ9Ik03My4zMDQ0IDc0LjI0NzNDNzMuMTM3NCA3NC4yNDczIDcyLjk3MDQgNzQuMTg5MyA3Mi44MzQ0IDc0LjA3MjNMNjcuMzk1NCA2OS4zNzQzQzY3LjA5NDQgNjkuMTE1MyA2Ny4wNjA0IDY4LjY2MTMgNjcuMzIwNCA2OC4zNjAzIDY3LjU3OTQgNjguMDYwMyA2OC4wMzQ0IDY4LjAyODMgNjguMzMzNCA2OC4yODYzTDczLjc3NDQgNzIuOTg0M0M3NC4wNzU0IDczLjI0MzMgNzQuMTA4NCA3My42OTczIDczLjg0ODQgNzMuOTk4MyA3My43MDY0IDc0LjE2MjMgNzMuNTA1NCA3NC4yNDczIDczLjMwNDQgNzQuMjQ3M002NC43ODg3IDc5LjA1QzY0LjQzMzcgNzkuMDUgNjQuMTI0NyA3OC43ODYgNjQuMDc2NyA3OC40MjVMNjIuOTM3NyA2OS44NDVDNjIuODg2NyA2OS40NTEgNjMuMTYyNyA2OS4wOSA2My41NTY3IDY5LjAzOCA2My45NTE3IDY4Ljk4OCA2NC4zMTA3IDY5LjI2MyA2NC4zNjI3IDY5LjY1Nkw2NS41MDE3IDc4LjIzN0M2NS41NTM3IDc4LjYzIDY1LjI3NjcgNzguOTkxIDY0Ljg4NDcgNzkuMDQzIDY0Ljg1MDcgNzkuMDQ3IDY0LjgxOTcgNzkuMDUgNjQuNzg4NyA3OS4wNU02Mi4xODMzIDY3LjExMTVDNjIuMTY3MyA2Ny4xMTE1IDYyLjE1MjMgNjcuMTExNSA2Mi4xMzYzIDY3LjEwOTVMNTYuOTEzMyA2Ni43Nzk1QzU2LjUxODMgNjYuNzU0NSA1Ni4yMTczIDY2LjQxMjUgNTYuMjQzMyA2Ni4wMTU1IDU2LjI2NzMgNjUuNjIwNSA1Ni42MTczIDY1LjMyMDUgNTcuMDA1MyA2NS4zNDM1TDYyLjIyODMgNjUuNjc0NUM2Mi42MjMzIDY1LjcwMDUgNjIuOTI0MyA2Ni4wNDI1IDYyLjkwMDMgNjYuNDM4NSA2Mi44NzUzIDY2LjgxODUgNjIuNTU5MyA2Ny4xMTE1IDYyLjE4MzMgNjcuMTExNU02Ny4wOTgzIDY2LjAzODNDNjYuOTE4MyA2Ni4wMzgzIDY2LjczOTMgNjUuOTcxMyA2Ni41OTgzIDY1LjgzNzMgNjYuMzEzMyA2NS41NjAzIDY2LjMwNDMgNjUuMTA1MyA2Ni41ODAzIDY0LjgyMDNMNzAuMTgwMyA2MS4wOTEzQzcwLjQ1NjMgNjAuODA1MyA3MC45MTEzIDYwLjc5ODMgNzEuMTk3MyA2MS4wNzMzIDcxLjQ4MjMgNjEuMzQ5MyA3MS40OTEzIDYxLjgwNDMgNzEuMjE0MyA2Mi4wODkzTDY3LjYxNTMgNjUuODE4M0M2Ny40NzQzIDY1Ljk2NTMgNjcuMjg1MyA2Ni4wMzgzIDY3LjA5ODMgNjYuMDM4MyIvPiAgICAgIDxwb2x5Z29uIGZpbGw9IiM3Mjc2N0QiIHBvaW50cz0iNDQuMTg1IDM4LjI3NyAxMTEuMSAzOC4yNzcgMTExLjEgMTMuODI5IDQ0LjE4NSAxMy44MjkiLz4gICAgICA8cGF0aCBmaWxsPSIjMzYzOTNGIiBkPSJNNDkuNjQxMywyNi4wNTIgQzQ5LjY0MTMsMjkuMzkzIDUyLjM0OTMsMzIuMTAyIDU1LjY5MDMsMzIuMTAyIEw5OS4wMDQzLDMyLjEwMiBDMTAyLjM0NTMsMzIuMTAyIDEwNS4wNTMzLDI5LjM5MyAxMDUuMDUzMywyNi4wNTIgQzEwNS4wNTMzLDIyLjcxMSAxMDIuMzQ1MywyMC4wMDMgOTkuMDA0MywyMC4wMDMgTDU1LjY5MDMsMjAuMDAzIEM1Mi4zNDkzLDIwLjAwMyA0OS42NDEzLDIyLjcxMSA0OS42NDEzLDI2LjA1MiIvPiAgICAgIDxwYXRoIGZpbGw9IiNGRkZGRkYiIGQ9Ik00NS43NjcyLDEuOTE5MiBMMzkuNzQ0MiwxMi4zNTIyIEMzOS40MDIyLDEyLjk0NDIgMzkuODMwMiwxMy42ODUyIDQwLjUxMzIsMTMuNjg1MiBMNTIuNTYwMiwxMy42ODUyIEM1My4yNDUyLDEzLjY4NTIgNTMuNjcyMiwxMi45NDQyIDUzLjMzMDIsMTIuMzUyMiBMNDcuMzA2MiwxLjkxOTIgQzQ2Ljk2NDIsMS4zMjYyIDQ2LjExMDIsMS4zMjYyIDQ1Ljc2NzIsMS45MTkyIi8+ICAgIDwvZz4gIDwvZz48L3N2Zz4=) no-repeat bottom,none !important;
}

.itemBackground-2vEldQ:before {
	background:radial-gradient(ellipse at top,rgba(54,57,63,0),rgba(0,0,0,0.7)),linear-gradient(90deg,rgba(0,0,0,0.7) 0,rgba(54,57,63,0) 40%,rgba(54,57,63,0) 60%,rgba(0,0,0,0.7)),linear-gradient(0deg,rgba(0,0,0,0.7) 0,rgba(54,57,63,0) 25%) !important;
}
.overlappingBorder-3aFng4,
.overlappingBorder-1-XPGl {
	border-color:var(--hover-color) !important;
}
.result-2S5Awv:after,
.tag-HanR-9:before,
.premium-39U29H:before,
.divider-21LyPb,
.applicationStore-1pNvnv .scroller-2FKFPG::-webkit-scrollbar {
	display:none;
}

/*11.b. Activity*/
.da-activityFeed {
	background:var(--backdropblurred) !important;
	background-size:cover  !important;
	background-repeat: no-repeat !important;
	background-attachment: fixed !important;
}
.paginationItem-2lUq0s:after {
	background:linear-gradient(270deg,transparent 0,rgba(0,0,0,0.8)) !important;
}
.card-7JP0BX, .newsLink-38Naqi {
	background:transparent !important;
}
.carousel-2WxMes,
.article-3BkSTW,
.header-1RC2Wb,
.da-activityFeed .scroller-2FKFPG::-webkit-scrollbar-track {
    background:rgba(0,0,0,0.5) !important;
}
.da-personalizationNotice {
    border:none;
    background:rgba(0,0,0,0.25) !important;
}
.da-activityFeed .scroller-2FKFPG::-webkit-scrollbar {
	width:8px;
}
.da-activityFeed .scroller-2FKFPG::-webkit-scrollbar-thumb {
	background:var(--hover-color) !important;
}
.exclusive-3zP8if,
.paginationItem-2lUq0s:before {
	background:var(--main-color) !important;
}
.carousel-2WxMes,
.article-3BkSTW,
.dockItem-2kQDqg:hover,
.body-SKIE6r,
.news-2GDtLJ {
	background:rgba(0,0,0,0.25) !important;
}

/*11.c. Library*/
.gameLibrary-TTDw4Y,
.root-1BQpZw,
.root-26DmKJ {
	background:var(--backdropblurred) !important;
	background-size:cover  !important;
	background-repeat: no-repeat !important;
	background-attachment: fixed !important;
	border-radius:7px;
}
.item-PXvHYJ {
	color:#fff;
}
.da-rowWrapperActive {
	background:rgba(0,0,0,0.5) !important;
}
.header-39GIC8 {
	background:transparent !important;
}
.gameUpdates-2GPqBU {
	background:rgba(0,0,0,0.8) !important;
}
.progress-2XXRYo,
.small-4dgL9e {
	background:rgba(255,255,255,0.075);
}
.gamePreview-9weYR2,
.body-1SVoBw,
.newsLink-38Naqi {
    box-shadow:inset 0px 1000px rgba(0,0,0,0.8) !important;
    background:var(--backdrop)
    background-size:cover !important;
}
.dotSelected-3RYKgX,
.dot-2Q_mMZ,
.installSize-1eXbBX {
	 background:var(--main-color) !important;
}
.info-P9dFwH,
.news-2KwXHF {
    background:transparent !important;
}
.root-26DmKJ {
	background:transparent;
}
.focused-1Yu0L3 {
	background:rgba(255,255,255,0.1);
}
.gameLibrary-TTDw4Y .topPill-30KHOu .item-PXvHYJ:hover:not(.side-8zPYf6 .itemSelected-1qLhcL) {
	background:rgba(255,255,255,0.06)
}
.gameLibrary-TTDw4Y .topPill-30KHOu .itemSelected-1qLhcL {
	background:var(--main-color);
	color:#fff;
}
.topPill-30KHOu .itemSelected-1qLhcL {
    background:var(--main-color) !important;
}
.topPill-30KHOu .item-PXvHYJ:hover:not(.itemSelected-1qLhcL) {
    background:var(--main-color-faded) !important;
}

/*11.d. Friends*/
#friends {
	background:var(--backdropblurred) !important;
	background-size:cover  !important;
	background-repeat: no-repeat !important;
	background-attachment: fixed !important;
}
.tab-bar-item {
	transition:250ms all linear;
}
.tab-bar-item.tab-bar-item-primary {
	background:var(--main-color) !important;
}
.tab-bar-item:hover:not(.selected) {
	background:var(--main-color-faded) !important;
}
.tab-bar-item.selected {
	background:var(--hover-color) !important;
}
.tab-bar-item-primary.selected {
	color:#fff !important;
}
.friends-column-actions .friends-action {
	background-color:var(--hover-color) !important;
}
.friends-table .friends-row:hover {
	background:rgba(0,0,0,0.5) !important;
}
.friend-table-add-header {
	background:transparent !important;
	border:none !important;
}
.da-friendsTable .scroller-2FKFPG::-webkit-scrollbar-thumb {
    border:none;
    background:var(--main-color) !important;
}
.da-friendsTable .scroller-2FKFPG::-webkit-scrollbar-track {
    background-color:rgba(0,0,0,0.5) !important;
    border:none;
}
.da-friendsTable .scroller-2FKFPG::-webkit-scrollbar {
    width: 10px !important;
}
.container-3gCOGc {
	background:var(--backdropblurred) !important;
	background-size:cover  !important;
	background-repeat: no-repeat !important;
	background-attachment: fixed !important;
}
.tabBar-1E2ExX .primary-3j8BhM {
    background:var(--main-color) !important;
}
.tabBar-1E2ExX .primarySelected-3uHKZn,
.itemSelected-1qLhcL {
    color:#fff !important;
}
.da-friendsRow:hover {
    background:rgba(0,0,0,0.5) !important;
}
.wrapper-1cBijl {
  background:rgba(0,0,0,0.2) !important;
}
.friendsAction-__WNE9 {
    background-color:var(--hover-color) !important;
}
.friendTableAddHeader-m9bzFr {
	background:transparent !important;
	border:none !important;
}
.friendsRow-2yicud {
    transition:250ms linear all;
}
.friendsRow-2yicud:hover {
    border-radius:5px !important;
    padding:20px !important;
}

/*11.e. Server Discovery*/
.pageWrapper-1PgVDX {
    background:var(--backdropblurred) !important;
    background-size:cover !important;
    background-position:fixed !important;
}
img[src*="/assets/9e8f566e6d49e8f4bba138e1d6a50578.svg"] {
	object-position: -999px -999px !important;
	background: var(--main-color) !important;
	-webkit-mask: url('data:image/png;base64,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') center/contain no-repeat !important;
}
.emptySearchResults-1ba__I {
    background:transparent !important;
    margin-top:300px;
}
.bg-AYqtMd {
    background:var(--main-color);
    border-radius:0px !important;
    box-shadow: 0 4px 100px -2px black;
}
.loading-17PYl_ {
  background:rgba(0,0,0,0.5) !important;
}
.searchBox-3Y2Vi7 {
    border-radius:50px;
    transition:250ms background;
    padding:7px 30px;
}
.guildList-1ItbxP .lookFilled-1Gx00P.colorGreen-29iAKY {
    background:var(--main-color);
}
.searchBox-3Y2Vi7:hover {
    background:rgba(0,0,0,0.65) !important;
}
.searchBox-3Y2Vi7:hover .searchBoxInput-uJtBcv::-webkit-input-placeholder,
.searchBox-3Y2Vi7:hover .searchIcon-1a1-yA {
    color:rgba(255,255,255,0.6);
}
.searchBoxInput-uJtBcv::-webkit-input-placeholder,
.searchIcon-1a1-yA {
    transition:250ms color;
}
.verifiedIcon-1vpk3S path:nth-of-type(2) {
    fill:var(--hover-color);
}
.outer-s4sY2_ {
    box-shadow:0 0 30px rgba(0,0,0,0.5);
}
/*============== END OF SECTION ============== */

/*12. Out of App Areas*/
/*12.a. Login Screen*/
.leftSplit-1qOwnR .wrapper-6URcxg {
	right:0px !important;
}
.rightSplit-2US0xy,
.canvas-3XuBXe {
	display:none !important;
}
.da-authBox {
	background:rgba(0,0,0,0.75) !important;
	box-shadow:0px 10px 20px rgba(0,0,0,0.5);
	border:2px solid rgba(0,0,0,0.5);
}

/*12.b. Crash Screen*/
.errorPage-u8SYh4 {
	background:var(--backdropblurred) !important;
	background-repeat:no-repeat !important;
	background-size:cover !important;
}

/*12.c. Loading Screen*/
.container-16j22k {
    background:var(--backdropblurred) !important;
    background-size:cover !important;
    background-repeat:no-repeat !important;
    box-shadow:0 0 0 10000px rgba(0,0,0,0.5) !important;
}
.problemsText-1Yx-Kl {
  color:transparent;
}
.problemsText-1Yx-Kl:after {
  content:'Oopsie whoopsie! uwu did we do a fucky wucky? Pwease let us know OwO!';
  white-space:pre;
  position:absolute;
  color:#f04747;
  font-weight:inherit;
  left:38%;
}
.content-1-zrf2 {
  background:rgba(0,0,0,0.25) !important;
  transition:150ms all linear;
  box-shadow:inset 0 0 1000px rgba(0,0,0,0.5), 0 0 15px rgba(0,0,0,0.75);
  border:2px solid rgba(0,0,0,0.5);
	background-repeat:no-repeat !important;
  background-position:fixed !important;
  padding:40px;
  border-radius:10px;
  padding-top:10px;
}
.content-1-zrf2:hover {
  transform:scale(1.04);
}
.anchor-3Z-8Bb {
  color:var(--hover-color) !important;
}
/*============== END OF SECTION ============== */

/*13. Plugins*/
/*13.a. Theme and PluginRepo*/
.themerepo-loadingicon path:nth-of-type(1),
.pluginrepo-loadingicon path:nth-of-type(1) {
    fill:var(--hover-color) !important;
}

/*13.b. BetterFormattingRedux*/
.bf-toolbar.bf-visible:before, .bf-toolbar.bf-hover:hover:before {
    background:var(--backdropblurred);
    background-size:cover !important;
    background-position:right center !important;
		box-shadow:inset 0 0 0 1000px rgba(0,0,0,0.25) !important;
}

.bf-toolbar .format:hover {
    background:rgba(0,0,0,0.5) !important;
    border-radius:5px !important;
}
.da-guildsError {
    border-color:var(--hover-color) !important;
    background:var(--main-color-faded) !important;
    color:var(--hover-color) !important;
}

/*13.c. Translate*/
.popout-3sVMXz.popout-googletranslate .themedPopout-25DgLi {
    padding:22px 22px 22px 22px !important;
    animation: slide-up 250ms cubic-bezier(0,0,0,1) !important;
}
.reverse-button {
    transition:250ms all fill;
}
.reverse-button:hover {
    fill:var(--hover-color) !important;
}

/*13.d. Share Button*/
.sb-menu-scroller-wrapper {
	background:var(--backdrop) !important;
	background-size:cover !important;
}

/*13.e. Read All Notifications*/
.RANbutton {
    /*width:68px;
    font-size:11px !important;*/
}

/*13.f. Compatibility Tags [DISCONTINUED]*/
/*.bda-slist li[data-name="BetterFormattingRedux"]:after,
.bda-slist li[data-name="Discord Experiments"]:after,
.bda-slist li[data-name="GoogleTranslateOption"]:after,
.bda-slist li[data-name="PersonalPins"]:after,
.bda-slist li[data-name="PluginRepo"]:after,
.bda-slist li[data-name="ReadAllNotificationsButton"]:after,
.bda-slist li[data-name="ServerFolders"]:after,
.bda-slist li[data-name="Share Button"]:after,
.bda-slist li[data-name="ShowHiddenChannels"]:after,
.bda-slist li[data-name="ThemeRepo"]:after,
.bda-slist li[data-name="CreationDate"]:after,
.bda-slist li[data-name="Friends List Restyle"]:after,
.bda-slist li[data-name="FullSizePfp"]:after,
.bda-slist li[data-name="Large Chat Avatars"]:after,
.bda-slist li[data-name="ServerColumns"]:after {
    content:'Compatible with Aurora';
    background:var(--main-color);
    padding:2px;
    width:160px;
    height:18px;
    border-radius:3px;
    display:block;
    position:absolute;
}
.bda-slist li[data-name="BetterFormattingRedux"]:after {
    margin-top:-93px;
    margin-left:220px;
}
.bda-slist li[data-name="Discord Experiments"]:after {
    margin-top:-65px;
    margin-left:200px;
}
.bda-slist li[data-name="GoogleTranslateOption"]:after {
    margin-top:-140px;
    margin-left:265px;
}
.bda-slist li[data-name="CreationDate"]:after {
    margin-top:-124px;
    margin-left:175px;
}
.bda-slist li[data-name="PersonalPins"]:after {
    margin-top:-125px;
    margin-left:165px;
}
.bda-slist li[data-name="PluginRepo"]:after {
    margin-top:-125px;
    margin-left:160px;
}
.bda-slist li[data-name="ThemeRepo"]:after {
    margin-top:-125px;
    margin-left:170px;
}
.bda-slist li[data-name="ReadAllNotificationsButton"]:after {
    margin-top:-125px;
    margin-left:245px;
}
.bda-slist li[data-name="ServerFolders"]:after {
    margin-top:-155px;
    margin-left:180px;
}
.bda-slist li[data-name="Share Button"]:after {
    margin-top:-92px;
    margin-left:183px;
}
.bda-slist li[data-name="ShowHiddenChannels"]:after {
    margin-top:-125px;
    margin-left:215px;
}
.bda-slist li[data-name="Friends List Restyle"]:after {
    margin-top:-82px;
    margin-left:195px;
}
.bda-slist li[data-name="FullSizePfp"]:after {
    margin-top:-80px;
    margin-left:140px;
}
.bda-slist li[data-name="Large Chat Avatars"]:after {
    margin-top:-82px;
    margin-left:180px;
}
.bda-slist li[data-name="ServerColumns"]:after {
    margin-top:-82px;
    margin-left:180px;
}*/

/*13.g. DetailedServerTooltips*/
.metalloriff-changelog-scroller::-webkit-scrollbar, .dst-tooltip:after {
	display:none;
}
.tooltip-1OS-Ti.right-KM_vfY {
	animation:faderight 150ms;
}
.dst-tooltip {
	background-image:var(--main-color);
}
.metalloriff-changelog-scroller {
	background:var(--backdrop) !important;
	background-size:cover !important;
	box-shadow:inset 0 0 0 1000px rgba(0,0,0,0.5);
}

/*13.h. Reply System*/
.reply-list {
	background:rgba(0,0,0,0.85);
}
.reply-item {
	background:var(--main-color);
}
.reply-clear {
	top:10px;
	right:5px;
}

/*13.i. Permissions Viewer*/
#permissions-modal-wrapper .modal-body {
	background:var(--backdrop) !important;
	background-size:cover !important;
	box-shadow:inset 0 0 0 1000px rgba(0,0,0,0.5);
}
#permissions-modal-wrapper .header,
#permissions-modal-wrapper .role-side,
#permissions-modal-wrapper .perm-side {
	background:transparent;
}

/*13.j. StatusEverywhere*/
#app-mount .da-messageCozy .da-status {
	border-radius:var(--chat-avatar-roundness) !important;
}

/*13.k. Date Viewer*/
#dv-mount {
    background:transparent !important;
}
/*============== END OF SECTION ============== */

/*14. Roundness*/
:root {
	--chat-avatar-roundness:5px;
	--media-roundness:50px;
	--guild-hovered-roundness:12px;
}
.da-guildsWrapper .guildInner-3DSoA4:hover,
.da-guild.da-selected .da-guildInner,
#app-mount .guildsWrapper-5TJh6A.foldercontent .da-guildIcon:hover,
#app-mount .guildsWrapper-5TJh6A.foldercontent .guildInner-3DSoA4:hover,
#app-mount .da-guildsWrapper .inner-1W0Bkn {
	border-radius:var(--guild-hovered-roundness) !important;
}
.da-guildInner {
	border-radius:var(--media-roundness) !important;
	transition:350ms all ease;
}
.mask-3OgeRz,
.image-33JSyf,
.status-oxiHuE:not(.status-3fQvEa),
.avatar-small,
.avatar-xxlarge,
.inner-1W0Bkn,
.avatar-large,
.da-guildsError,
.da-guildsAdd,
.da-iconCircle,
#app-mount .da-privateChannels .inner-1W0Bkn,
.da-guildPlaceholder,
.callAvatarBorder-1D_KaE,
.da-callAvatar {
	border-radius:var(--media-roundness) !important;
}
/*============== END OF SECTION ============== */

/*15. Overwrite Grey SVG's*/
.image-1GzsFd,
.emptyIconFriends-BrjhY9,
.emptyIconGuilds-3OViNh,
.emptyIconStreamerMode-3RfWOW,
.noResultsImage-JbSWtu,
.userSettingsSecurityImage-21pI_Q,
.emptyStateImage-2eMp68,
.image-1GzsFd {
    filter:brightness(0.2) saturate(2) !important;
}
.userSettingsSecurityImage-21pI_Q,
.image-1GzsFd {
    opacity:.75;
}
.empty-3sCt5f {
    background:none !important;
    margin-top:-120px;
}
.emptyStateImage-2eMp68, .image-1GzsFd {opacity:0.7;}
.emptyIconFriends-BrjhY9,
.emptyIconGuilds-3OViNh,
.emptyIconStreamerMode-3RfWOW,
.noResultsImage-JbSWtu {
    opacity:.6;
}
/*Made with ♥ by Tropical edited by Gabrielo and the Derealised Community.
Also, Thank you DevilBro, for letting me use his SVG's to improve the theme!*/

