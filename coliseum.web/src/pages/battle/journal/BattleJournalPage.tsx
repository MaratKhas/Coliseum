import { Button, Input, Modal } from "antd";
import { EditOutlined } from "@ant-design/icons"
import { Link, useNavigate } from "react-router-dom";
import { useState } from "react";
import {
    useCreateBattleMutation,
    useGetBattleJournalQuery
} from "../../../stores/api/battle.api";

export function BattleJournalPage() {
    const navigate = useNavigate();
    const [isModalOpen, setIsModalOpen] = useState(false);
    const [battleName, setBattleName] = useState("");

    // Хук для создания битвы
    const [createBattle] = useCreateBattleMutation();

    // Получение данных журнала
    const {
        data: journalData,
        isLoading,
        error
    } = useGetBattleJournalQuery(null);

    // Открытие модального окна для создания битвы
    const showCreateBattleModal = () => {
        setIsModalOpen(true);
    };

    // Обработчик изменения названия битвы
    const handleBattleNameChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        setBattleName(e.target.value);
    };

    // Создание битвы
    const handleCreateBattle = async () => {
        try {
            const result = await createBattle({ name: battleName }).unwrap();

            if (result.ok && result.value?.id) {
                navigate(`/battles/${result.value.id}`);
            }
        } catch (err) {
            console.error("Ошибка при создании битвы:", err);
        } finally {
            setIsModalOpen(false);
            setBattleName("");
        }
    };

    // Закрытие модального окна
    const handleCancel = () => {
        setIsModalOpen(false);
        setBattleName("");
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
                    onClick={showCreateBattleModal}
                >
                    Создать новую битву
                </Button>
            </div>

            <Modal
                title="Создание новой битвы"
                open={isModalOpen}
                onOk={handleCreateBattle}
                onCancel={handleCancel}
                okText="Создать"
                cancelText="Отмена"
            >
                <Input
                    placeholder="Введите название битвы"
                    value={battleName}
                    onChange={handleBattleNameChange}
                    onPressEnter={handleCreateBattle}
                />
            </Modal>

            {/* Отображение списка битв */}
            {journalData?.items?.length ? (
                <div>
                    <h3>История битв:</h3>
                    <ul>
                        {journalData.items.map(battle => (
                            <li key={battle.id}>
                                Битва #{battle.id} - {battle.status} {battle.name && `(${battle.name})`}
                                <Link to={`./${battle.id}` }>
                                    <Button
                                        type="link"
                                        icon={<EditOutlined />}
                                        size="small"
                                    />
                                </Link >
                            </li>
                        ))}
                    </ul>
                </div>
            ) : (
                <p>Нет битв</p>
            )}
        </div>
    );
}