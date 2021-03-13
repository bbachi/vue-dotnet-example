module.exports = {
    devServer: {
      proxy: {
        '^/api': {
          target: 'https://localhost:5001',
          changeOrigin: true
        },
      }
    }
  }