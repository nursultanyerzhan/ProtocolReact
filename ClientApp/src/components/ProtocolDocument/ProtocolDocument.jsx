import style from './ProtocolDocument.module.css';
import { useLocation } from 'react-router-dom';
import { ProtocolMain } from '../ProtocolDocument/ProtocolMain/ProtocolMain';
import { useGetProtocolMainsQuery } from '../../services/protocol';

export const ProtocolDocument = () => {
  const location = useLocation();
  const { protocolId } = location.state;
  const { data, error, isLoading } = useGetProtocolMainsQuery(protocolId, { pollingInterval: 3000 });

  return (
    <>
      {error ? (
        <>Oh no, there was an error</>
      ) : isLoading ? (
        <>Загрузка...</>
      ) : data ? (
        <>
          <table className={style["k-table"]}>
            <thead>
              <tr key={protocolId}>
                <th>Наименование мероприятии</th>
                <th>Срок</th>
                <th>Исполнители</th>
              </tr>
            </thead>
            <tbody>
              {data.map((main) => (
                <ProtocolMain key={main.id} mainId={main.id} title={main.nameRu}></ProtocolMain>
              ))}
            </tbody>
          </table>
        </>
      ) : null}
    </>
  );
};
