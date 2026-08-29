import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

export default defineConfig({
  plugins: [react()],
  server: {
    proxy: {
      '/api': {
        target: 'http://localhost:5270',
        changeOrigin: true,
        secure: false
      },
      '/images': {
        target: 'http://localhost:5270',
        secure: false
      },
    },
  },
})
