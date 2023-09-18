# !/bin/bash

# Проверяем, передан ли путь к директории

if [[ $# -ne 1 ]]; then

  echo "Usage: $0 /path/to/directory"

  exit 1

fi

# Проверяем, существует ли директория

if [[ ! -d "$1" ]]; then

  echo "Error: directory does not exist"

  exit 1

fi

# Удаляем файлы с расширениями .bak, .tmp, .backup

find "$1" -type f ( -name '*.bak' -o -name '*.tmp' -o -name '*.backup' ) -delete

echo "Directory $1 has been cleared of .bak, .tmp, and .backup files"

# Пример запуска скрипта: `./clean.sh /path/to/directory`.

