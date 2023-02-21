import { Home } from "./components/Home";
import { ProtocolDocument } from "./components/ProtocolDocument/ProtocolDocument";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/protocolDocument',
    element: <ProtocolDocument />
  }
];

export default AppRoutes;
