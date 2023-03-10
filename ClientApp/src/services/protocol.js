import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react'

export const protocolApi = createApi({
  reducerPath: 'protocolApi',
  tagTypes: ['ProtocolDocuments', 'ProtocolMission'],
  baseQuery: fetchBaseQuery({ baseUrl: 'https://localhost:44483/' }),
  endpoints: (builder) => ({
    getProtocolDocuments: builder.query({
      query: () => `getProtocolDocuments`,
      providesTags: (result) => result ?
        [
          ...result.map(({ id }) => ({ type: 'ProtocolDocuments', id })),
          { type: 'ProtocolDocuments', id: 'List' }
        ] :
        [{ type: 'ProtocolDocuments', id: 'List' }]
    }),
    getProtocolMains: builder.query({
      query: (protocolId) => `getProtocolMains?protocolId=${protocolId}`,
      providesTags: (result) => result ?
        [
          ...result.map(({ id }) => ({ type: 'ProtocolMains', id })),
          { type: 'ProtocolMains', id: 'List' }
        ] :
        [{ type: 'ProtocolMains', id: 'List' }]
    }),
    getProtocolMissions: builder.query({
      query: (protocolMainId) => `getProtocolMissions?protocolMainId=${protocolMainId}`,
      providesTags: (result) => result ?
        [
          ...result.map(({ id }) => ({ type: 'ProtocolMission', id })),
          { type: 'ProtocolMission', id: 'List' }
        ] :
        [{ type: 'ProtocolMission', id: 'List' }]
    }),
    addProtocolMission: builder.mutation({
      query: (body) => ({
        url: 'postProtocolMission',
        method: 'POST',
        body,
      }),
      invalidatesTags: [{ type: 'ProtocolMission', id: 'List' }]
    }),
  }),
})

export const {
  useGetProtocolDocumentsQuery,
  useGetProtocolMainsQuery, 
  useGetProtocolMissionsQuery, 
  useAddProtocolMissionMutation } = protocolApi;