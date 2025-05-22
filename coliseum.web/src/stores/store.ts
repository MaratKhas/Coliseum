import { combineReducers, configureStore } from '@reduxjs/toolkit';
import { createLogger } from 'redux-logger';
import { api } from './api/api';

const logger = createLogger({
    collapsed: true,
});

export const store = configureStore({
    reducer: {
        // Remove the combineReducers wrapper - configureStore already combines reducers
        [api.reducerPath]: api.reducer,
        // Add other reducers here if needed
    },
    middleware: (getDefaultMiddleware) =>
        getDefaultMiddleware()
            .concat(api.middleware)  // Add RTK Query middleware
            .concat(logger),        // Add logger middleware
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;