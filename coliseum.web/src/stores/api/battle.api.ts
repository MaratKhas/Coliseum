import type { IBattleJournalDto, IBattleJournalItemDto } from "../types/battle.types";
import { api } from "./api"

const URL = "battles"

export const BattleApi = api.injectEndpoints({
    endpoints: builder => ({
        getBattleJournal: builder.query<null, IBattleJournalDto>({
            query: () => ({
                url: `/${URL}`,
                method: "GET"
            }),
            providesTags: () => [{
                type: "battle"
            }]
        }),
        createBattle: builder.mutation<null, IBattleJournalItemDto>({
            query: () => ({
                url: `/${URL}/create`,
                method: "POST"
            }),
            invalidatesTags: () => [
                {
                    type: "battle",
                }
            ]
        }),
    })
})

export const { useGetBattleJournalQuery, useCreateBattleMutation } = BattleApi