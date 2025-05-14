import { Outlet } from "react-router-dom";
import { Navigator } from "../components/Navigation/Navigator"

export function Layout() {
    return (
        <>
            <div className="header">
                <Navigator />
            </div>

            <div className="main-content">
                <Outlet />
            </div>
        </>
    );
}