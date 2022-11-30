.App {
  text-align: center;
}

.App nav{
  padding-left: 1%;
  background-color: #61dafb;
}

.App nav h1{
  text-align: left;
}

.App .row{
  display: flex;
  flex-direction: row;
}

.App .row .col-2{
  margin-left: 72%;
}

.App .row .col-2 button{
  width: 8rem;
  margin-top: 1.5rem;
  background: black;
  color: white;
 
  font-size: larger;
  border-radius: 5px;
  border: none;
  padding: 5%;
  cursor: pointer;
}

.App .row .col-2 button:hover{
  background-color: white;
  border: black 2px solid;
  color: black;
}

.App-logo {
  height: 40vmin;
  pointer-events: none;
}

@media (prefers-reduced-motion: no-preference) {
  .App-logo {
    animation: App-logo-spin infinite 20s linear;
  }
}

.App-header {
  background-color: #282c34;
  min-height: 100vh;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  font-size: calc(10px + 2vmin);
  color: white;
}

.App-link {
  color: #61dafb;
}

@keyframes App-logo-spin {
  from {
    transform: rotate(0deg);
  }
  to {
    transform: rotate(360deg);
  }
}
