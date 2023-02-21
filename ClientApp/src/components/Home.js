import React from 'react';
import { useGetProtocolDocumentsQuery } from '../services/protocol';
import { Link } from 'react-router-dom';

export const Home = () => {
  const { data, error, isLoading } = useGetProtocolDocumentsQuery();

  return (
    <>
      {error ? (
        <>Oh no, there was an error</>
      ) : isLoading ? (
        <>Loading...</>
      ) : data ? (
        <>
          <table className='table table-hover table-bordered'>
            <thead>
              <tr>
                <th>Id</th>
                <th>Title</th>
                <th>StartDate</th>
                <th>EndDate</th>
              </tr>

            </thead>
            <tbody>
              {data.map((document) => (
                <tr key={document.id}>
                  <td>
                    <Link to="/protocolDocument" state={{ protocolId: document.id }}>{document.id}</Link>
                  </td>
                  <td>
                    {document.name}
                  </td>
                  <td>
                    {document.startDate}
                  </td>
                  <td>
                    {document.endDate}
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </>
      ) : null}
    </>
  );
}
