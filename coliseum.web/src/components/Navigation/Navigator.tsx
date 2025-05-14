import { Menu, type MenuProps } from "antd";
import { useCallback, useEffect, useMemo, useState } from "react";
import { Link, useLocation } from "react-router-dom";

type MenuItem = Required<MenuProps>['items'][number];

export function Navigator() {
    const menuItems: MenuItem[] = useMemo(() => [
        {
            label: <Link to="/battles">Битвы</Link>,
            key: 'battles',
        },
        {
            label: <Link to="/warriors">Бойцы</Link>,
            key: 'warriors',
        },
    ], []);

    const location = useLocation();

    const findSelectedKey = useCallback((path: string): string => {
        // Обрабатываем корневой путь отдельно
        if (path === "/") return "/";

        // Ищем подходящий элемент меню
        const foundItem = menuItems.find(item => {
            const itemPath = `/${item?.key}`;
            return path === itemPath || path.startsWith(`${itemPath}/`);
        });

        return foundItem?.key ?? ""; // Более явный null-коалесцинг
    }, [menuItems]);

    const [selectedKey, setSelectedKey] = useState<string>(() => {
        const path = location?.pathname || "/";
        return findSelectedKey(path);
    });

    useEffect(() => {
        const path = location?.pathname || "/";
        setSelectedKey(findSelectedKey(path));
    }, [location?.pathname, findSelectedKey]);

    return (
        <Menu
            items={menuItems}
            mode="horizontal"
            selectedKeys={selectedKey ? [selectedKey] : []}
        />
    );
}