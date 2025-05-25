import {  configureStore } from '@reduxjs/toolkit';
import { createLogger } from 'redux-logger';
import { api } from './api/api';

const logger = createLogger({
    collapsed: true,
});

export const store = configureStore({
    reducer: {
        [api.reducerPath]: api.reducer,
    },
    middleware: (getDefaultMiddleware) =>
        getDefaultMiddleware()
            .concat(api.middleware)  
            .concat(logger),      
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;