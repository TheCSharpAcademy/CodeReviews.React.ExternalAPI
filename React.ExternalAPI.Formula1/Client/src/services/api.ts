import type { Driver, LeaderboardEntry } from "../types/driver"

const BASE_URL = import.meta.env.VITE_API_URL || '/api'
const API_BASE_URL = import.meta.env.VITE_API_URL || 'http://localhost:5270'

async function handleResponse<T>(res : Response) : Promise<T> {
    if (!res.ok) {
        throw new Error(`API error: ${res.status} ${res.statusText}`)
    }
    return res.json() as Promise<T>
}

export const getDrivers = async (): Promise<Driver[]> => {
    const res = await fetch(`${BASE_URL}/drivers`)
    return handleResponse<Driver[]>(res)
}

export const getDriverByNumber = async (number : string): Promise<Driver> => {
    const res = await fetch(`${BASE_URL}/drivers/${number}`)
    return handleResponse<Driver>(res)
}

export const getLeaderboard = async (): Promise<LeaderboardEntry[]> => {
    const res = await fetch(`${BASE_URL}/leaderboard`)
    return handleResponse<LeaderboardEntry[]>(res)
}

export function getImageUrl(path: string) : string {
    if (!path) return ''
    if (path.startsWith('http')) return path 
    return `${API_BASE_URL}${path}`
}