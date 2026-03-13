import http.server, socketserver, os, sys, mmap, re

# --- НАСТРОЙКИ ---
PORT = 2800
BASE_DIR = r"D:\SteamLibrary\steamapps\common\SimpleRockets2\TGettr 0.1.6.5"
SAVE_DIR = os.path.join(BASE_DIR, "rec")
if not os.path.exists(SAVE_DIR): os.makedirs(SAVE_DIR)

# Словарь для хранения открытых дескрипторов, чтобы не дергать диск
mmaps = {}

def get_clean_int(s):
    try:
        clean = re.sub(r'[^0-9\-]', '', s.split('.')[0])
        return clean if clean and clean != '-' else "0"
    except:
        return "0"

class TGettrHandler(http.server.BaseHTTPRequestHandler):
    def do_POST(self):
        try:
            content_length = int(self.headers.get('Content-Length', 0))
            raw_data = self.rfile.read(content_length).decode('utf-8', errors='ignore')
            if not raw_data: return
            chunks = raw_data.split("ç")
            
            for i in range(25):
                val = get_clean_int(chunks[i].strip()).ljust(10) # Добиваем пробелами для фикс. длины
                file_path = os.path.join(SAVE_DIR, f"{i}.txt")
                
                try:
                    # Используем обычную запись, но с принудительной очисткой буфера
                    with open(file_path, "wb") as f:
                        f.write(val.encode('ascii'))
                        f.flush()
                        os.fsync(f.fileno()) # Выталкиваем данные из кэша Windows прямо сейчас
                except OSError:
                    continue

            self.send_response(200)
            self.end_headers()
        except:
            pass

    def log_message(self, format, *args): return

class FastTCPServer(socketserver.TCPServer):
    allow_reuse_address = True
    def server_bind(self):
        self.socket.setsockopt(socket.IPPROTO_TCP, socket.TCP_NODELAY, 1)
        super().server_bind()

print("--- TGettr 0.1.6.5 MEMORY-SYNC MODE ---")
with FastTCPServer(("", PORT), TGettrHandler) as httpd:
    try:
        httpd.serve_forever()
    except KeyboardInterrupt: sys.exit(0)
