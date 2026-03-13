import http.server, socketserver, os, sys, re

# --- НАСТРОЙКИ ---
PORT = 2800
BASE_DIR = r"D:\SteamLibrary\steamapps\common\SimpleRockets2\TGettr 0.1.6.5"
SAVE_DIR = os.path.join(BASE_DIR, "rec")
os.makedirs(SAVE_DIR, exist_ok=True)

MAX_CHANNELS = 25  # Кол-во текстовых файлов для TGettr

def sanitize_int(s: str) -> int:
    """Оставляем только цифры и минус, возвращаем int."""
    try:
        clean = re.sub(r'[^0-9\-]', '', s.split('.')[0])
        return int(clean) if clean and clean != '-' else 0
    except:
        return 0

class TGettrHandler(http.server.BaseHTTPRequestHandler):
    def do_POST(self):
        try:
            length = int(self.headers.get('Content-Length', 0))
            raw_data = self.rfile.read(length).decode('utf-8', errors='ignore')
            if not raw_data:
                self.send_response(400)
                self.end_headers()
                return

            chunks = raw_data.split("ç")
            for i in range(min(MAX_CHANNELS, len(chunks))):
                val = str(sanitize_int(chunks[i])).ljust(10)
                file_path = os.path.join(SAVE_DIR, f"{i}.txt")
                try:
                    with open(file_path, "wb") as f:
                        f.write(val.encode('ascii'))
                        f.flush()
                        os.fsync(f.fileno())
                except OSError:
                    continue

            self.send_response(200)
            self.end_headers()
        except Exception:
            self.send_response(500)
            self.end_headers()

    def log_message(self, format, *args):
        return  # Отключаем стандартный лог

class FastTCPServer(socketserver.TCPServer):
    allow_reuse_address = True
    def server_bind(self):
        self.socket.setsockopt(socket.IPPROTO_TCP, socket.TCP_NODELAY, 1)
        super().server_bind()

print(f"--- TGettr {PORT} MEMORY-SYNC MODE READY ---")
with FastTCPServer(("", PORT), TGettrHandler) as httpd:
    try:
        httpd.serve_forever()
    except KeyboardInterrupt:
        sys.exit(0)
