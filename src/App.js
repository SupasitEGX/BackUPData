import { Switch, Route, Redirect } from "react-router-dom";
import Home from "./pages/Home";
import Teams from "./pages/Teams";
import Projects from "./pages/Projects";
import Billing from "./pages/Billing";
import Rtl from "./pages/Rtl";
import SQLInput from "./pages/SQLInput";
import SQLTest from "./pages/SQLTEST";
import SugestionPage from "./pages/Suggestion";
import UpdateStatusGR from "./pages/UpdateStatusGR";
import CheckDiffReserve from "./pages/CheckDiffReserve";
import Profile from "./pages/Profile";
import SignUp from "./pages/SignUp";
import SignIn from "./pages/SignIn";
import Main from "./components/layout/Main";
import "antd/dist/antd.css";
import "./assets/styles/main.css";
import "./assets/styles/responsive.css";
import ArchiveWMS from "./pages/ArchiveWMS"
import ArchiveOMS from "./pages/ArchiveOMS"
import ArchiveTMS from "./pages/ArchiveTMS"
import CheckStock from "./pages/CheckStock"
function App() {
  return (
    <div className="App">
      <Switch>
        <Route path="/sign-up" exact component={SignUp} />
        <Route path="/sign-in" exact component={SignIn} />
        <Main>
        <Route exact path="/sqlInput" component={SQLInput} />
        <Route exact path="/sqlTest" component={SQLTest} />
        
        <Route exact path="/suggestion" component={SugestionPage} />
        <Route exact path="/updateStatusGR" component={UpdateStatusGR} />
        <Route exact path="/CheckDiffReserve" component={CheckDiffReserve} />
        <Route exact path="/CheckStock" component={CheckStock} />
        <Route exact path="/SUPPORT-STD/ArchiveWMS" component={ArchiveWMS} />
        <Route exact path="/SUPPORT-STD/ArchiveOMS" component={ArchiveOMS} />
        <Route exact path="/SUPPORT-STD/ArchiveTMS" component={ArchiveTMS} />
          {/* <Route exact path="/dashboard" component={Home} />
          <Route exact path="/teams" component={Teams} />
          <Route exact path="/projects" component={Projects} />
          <Route exact path="/billing" component={Billing} />
          <Route exact path="/rtl" component={Rtl} />
          <Route exact path="/profile" component={Profile} />
          <Redirect from="*" to="/dashboard" /> */}
        </Main>
      </Switch>
    </div>
  );
}

export default App;
