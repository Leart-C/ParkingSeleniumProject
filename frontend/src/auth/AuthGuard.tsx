import { Navigate, Outlet } from "react-router-dom";
import useAuth from "../hooks/useAuth.hook";

import { PATH_PUBLIC } from "../routes/paths";
import AuthSpinner from "../components/general/AuthSpinner";

interface IProps {
  roles: string[];
}

const AuthGuard = ({ roles }: IProps) => {
  const { isAuthenticated, user, isAuthLoading } = useAuth();
  const hasAccess =
    isAuthenticated && user?.roles?.find((q) => roles.includes(q));
  if (isAuthLoading) {
    return <AuthSpinner />;
  }
  return hasAccess ? <Outlet /> : <Navigate to={PATH_PUBLIC.unauthorized} />;
};
export default AuthGuard;
