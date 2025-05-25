import type { IBattleCreateDto, IBattleJournalDto, IBattleJournalItemDto } from "../types/battle.types";
import { api } from "./api"

const URL = "battles"

export const BattleApi = api.injectEndpoints({
    endpoints: builder => ({
        getBattleJournal: builder.query<IBattleJournalDto, null>({
            query: () => ({
                url: `/${URL}`,
                method: "GET"
            }),
            providesTags: () => [{
                type: "battle"
            }]
        }),
        createBattle: builder.mutation<IBattleJournalItemDto, IBattleCreateDto>({
            query: (data) => ({
                url: `/${URL}/create`,
                method: "POST",
                body: data
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