import { useParams } from "react-router-dom";

export function BattleCardPage() {
    const { id } = useParams()
    return (
        <p>{id}</p>
  );
}
