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

# Копируем файлы в директории, названные по имени владельца

find "$1" -type f -print0 | while IFS= read -r -d $'' file; do

  owner=$(stat -c '%U' "$file")

  dir="$1/$owner"

  mkdir -p "$dir" && cp "$file" "$dir"

done

echo "Files in $1 have been copied to directories named after their