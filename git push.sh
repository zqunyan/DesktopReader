now=$(date "+%Y-%m-%d %H:%M:%S")
echo "$now"
echo;

echo "DesktopReader"
echo "Change Directory to D:/Code/DesktopReader"
cd D:/Code/DesktopReader
echo "Start add-commit-pull-push..."
git add -A && git commit -m "$now" && git pull && git push

echo;
echo "Finish!"
read