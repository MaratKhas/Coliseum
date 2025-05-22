import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react"

const env = import.meta.env
const API_URL = env.VITE_API_URL

export const api = createApi({
    reducerPath: "api",
    tagTypes: [
        "battle",
    ],
    baseQuery: fetchBaseQuery({
        baseUrl: `${API_URL}`,
    }),
    endpoints: () => ({}),
})
