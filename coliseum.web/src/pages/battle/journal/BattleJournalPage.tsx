import { Button } from "antd"; // Исправленный импорт
import { useNavigate } from "react-router-dom";
import {
    useCreateBattleMutation, // Правильный хук для создания
    useGetBattleJournalQuery // Хук для получения журнала
} from "../../../stores/api/battle.api";
import type { IBattleJournalDto } from "../../../stores/types/battle.types";
import { useEffect, useState } from "react";

export function BattleJournalPage() {
    const navigate = useNavigate();

    // Хук для создания битвы
    const [createBattle] = useCreateBattleMutation();

    // Получение данных журнала
    const {
        data: journalData,
        isLoading,
        error
    } = useGetBattleJournalQuery();

    // Создание битвы
    const handleCreateBattle = async () => {
        try {
            const result = await createBattle(null).unwrap();

            if (result.ok && result.value?.id) {
                navigate(`/battles/${result.value.id}`);
            }
        } catch (err) {
            console.error("Ошибка при создании битвы:", err);
        }
    };

    // Отображение состояния загрузки
    if (isLoading) return <div>Загрузка журнала...</div>;

    // Отображение ошибок
    if (error) return <div>Ошибка загрузки журнала!</div>;

    return (
        <div style={{ padding: "1rem" }}>
            <h1>Журнал битв</h1>

            <div style={{ marginBottom: "1rem" }}>
                <Button
                    type="primary"
                    onClick={handleCreateBattle}
                >
                    Создать новую битву
                </Button>
            </div>

            {/* Отображение списка битв */}
            {journalData?.battles?.length ? (
                <div>
                    <h3>История битв:</h3>
                    <ul>
                        {journalData.battles.map(battle => (
                            <li key={battle.id}>
                                Битва #{battle.id} - {battle.status}
                            </li>
                        ))}
                    </ul>
                </div>
            ) : (
                <p>Нет завершенных битв</p>
            )}
        </div>
    );
}