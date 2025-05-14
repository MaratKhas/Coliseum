import './App.css'
import { Route, RouterProvider, createBrowserRouter, createRoutesFromElements } from 'react-router-dom'
import { HomePage } from './pages/HomePage'
import { BattleJournalPage } from './pages/battle/journal/BattleJournalPage'
import { BattleCardPage } from './pages/battle/card/BattleCardPage'
import { Layout } from './components/Layout'
import { WarriorCardPage } from './pages/warriors/card/WarriorCardPage'
import { WarriorJournalPage } from './pages/warriors/journal/WarriorJournalPage'

function App() {
    const router = createBrowserRouter(
        createRoutesFromElements(
            <Route path="/" element={<Layout />}>
                <Route index element={<HomePage />} />
                <Route path="battles">
                    <Route index element={<BattleJournalPage />} />
                    <Route path=":id" element={<BattleCardPage />} />
                </Route>
                <Route path="warriors">
                    <Route index element={<WarriorJournalPage />} />
                    <Route path=":id" element={<WarriorCardPage />} />
                </Route>
            </Route>
        )
    )

    return <RouterProvider router={router} />
}

export default App