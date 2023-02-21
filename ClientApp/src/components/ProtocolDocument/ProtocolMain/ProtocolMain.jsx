// import style from './ProtocolMain.module.css';
import styleDocument from '../../ProtocolDocument/ProtocolDocument.module.css';
import { useGetProtocolMissionsQuery } from "../../../services/protocol";
import {AddProtocolMission} from "../ProtocolMain/AddProtocolMission/AddProtocolMission";
import { useState } from 'react';

export const ProtocolMain = (props) => {
  const { mainId, title } = props;
  const { data, error, isLoading } = useGetProtocolMissionsQuery(mainId, { pollingInterval: 10000 });
  const [show, setShow] = useState(false);

  const addProtocolMission = () => setShow(true);
  const handleClose = () => setShow(false);

  return (
    <>
      <tr key={mainId}>
        <td colSpan={4} className={styleDocument["k-table-title"]}>
          <span>{title}</span>
          <button className={styleDocument["k-table-button"]} onClick={addProtocolMission}>Добавить</button>
        </td>
      </tr>
      {error ? (
        <>Oh no, there was an error</>
      ) : isLoading ? (
        <>Loading...</>
      ) : data ? (
        <>
          {data.map((mission) => (
            <tr key={mission.id}>
              <td>{mission.eventName}</td>
              <td>{mission.dedline}</td>
              <td>
                {/* <ProtocolExecutors missionId={mission.id}></ProtocolExecutors> */}
              </td>
            </tr>
          ))}
        </>
      ) : null}
      <AddProtocolMission handleClose={handleClose} show={show} mainId={mainId}></AddProtocolMission>
    </>
  );
};
