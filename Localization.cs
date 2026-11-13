using System;
using System.Collections.Generic;

// The English text passed to TrainerForm.T is the stable key. Order: ru, es, ja, ar, fr, de, ko.
internal static class Localization
{
    static readonly Dictionary<string,string[]> Text=new Dictionary<string,string[]>(StringComparer.Ordinal)
    {
        {"Activity log",new[]{"Журнал действий","Registro de actividad","アクティビティログ","سجل النشاط","Journal d’activité","Aktivitätsprotokoll","활동 로그"}},
        {" processing...",new[]{" — обработка..."," en curso...","を処理中..."," جارٍ التنفيذ..."," en cours..."," wird verarbeitet..."," 처리 중..."}},
        {" set to ",new[]{" установлено: "," establecido en ","："," ضُبط على "," défini à "," gesetzt auf "," 설정: "}},
        {")",new[]{")",")","）",")",")",")",")"}},
        {"Adapted for Build 188329\r\nSingle-player use only",new[]{"Для Build 188329\r\nТолько одиночная игра","Para Build 188329\r\nSolo un jugador","Build 188329 対応\r\nシングルプレイ専用","متوافق مع Build 188329\r\nللعب الفردي فقط","Pour le build 188329\r\nSolo uniquement","Für Build 188329\r\nNur Einzelspieler","Build 188329 지원\r\n싱글 플레이 전용"}},
        {"AI units and buildings set to 1 HP",new[]{"Здоровье ИИ установлено на 1","Unidades y edificios de IA a 1 PV","AIユニット・建物をHP1に設定","صحة وحدات ومباني الذكاء الاصطناعي: 1","Unités et bâtiments IA à 1 PV","KI-Einheiten und Gebäude auf 1 LP","AI 유닛과 건물 체력 1로 설정"}},
        {"APPLY",new[]{"OK","APLICAR","適用","تطبيق","OK","OK","적용"}},
        {"Cannot open project page: ",new[]{"Не открыть страницу проекта: ","No se puede abrir la página: ","プロジェクトページを開けません：","تعذر فتح صفحة المشروع: ","Impossible d'ouvrir la page : ","Projektseite kann nicht geöffnet werden: ","프로젝트 페이지를 열 수 없음: "}},
        {"Checking for updates...",new[]{"Проверка обновлений...","Buscando actualizaciones...","更新を確認中...","جارٍ التحقق من التحديث...","Recherche de mises à jour...","Suche nach Updates...","업데이트 확인 중..."}},
        {"Copy",new[]{"Копировать","Copiar","コピー","نسخ","Copier","Kopieren","복사"}},
        {"Current construction completed",new[]{"Текущее строительство завершено","Construcción actual completada","現在の建設が完了","اكتمل البناء الحالي","Construction en cours terminée","Aktueller Bau abgeschlossen","현재 건설 완료"}},
        {"Current population set to 0",new[]{"Текущее население: 0","Población actual: 0","現在人口を0に設定","عدد السكان الحالي: 0","Population actuelle : 0","Aktuelle Bevölkerung: 0","현재 인구 0으로 설정"}},
        {"Current production queue completed",new[]{"Очередь производства завершена","Cola de producción completada","現在の生産キューが完了","اكتمل طابور الإنتاج الحالي","File de production terminée","Produktionswarteschlange abgeschlossen","현재 생산 대기열 완료"}},
        {"Current research queue completed",new[]{"Очередь исследований завершена","Cola de investigación completada","現在の研究キューが完了","اكتمل طابور الأبحاث الحالي","File de recherche terminée","Forschungswarteschlange abgeschlossen","현재 연구 대기열 완료"}},
        {"Detected / waiting for match",new[]{"Обнаружена / ожидание матча","Detectado / esperando partida","検出済み / 対戦待ち","تم الكشف / انتظار المباراة","Détecté / attente de partie","Erkannt / warte auf Partie","감지됨 / 경기 대기"}},
        {"Disable game speed override",new[]{"Отключить изменение скорости","Desactivar velocidad personalizada","速度変更をオフ","إيقاف تعديل سرعة اللعبة","Désactiver la vitesse modifiée","Spieltempo-Änderung ausschalten","게임 속도 변경 끄기"}},
        {"Edit Food",new[]{"Изменить еду","Editar comida","食料を変更","تعديل الطعام","Modifier nourriture","Nahrung ändern","식량 변경"}},
        {"Edit Gold",new[]{"Изменить золото","Editar oro","金を変更","تعديل الذهب","Modifier or","Gold ändern","금 변경"}},
        {"Edit Stone",new[]{"Изменить камень","Editar piedra","石を変更","تعديل الحجر","Modifier pierre","Stein ändern","석재 변경"}},
        {"Edit Wood",new[]{"Изменить дерево","Editar madera","木材を変更","تعديل الخشب","Modifier bois","Holz ändern","목재 변경"}},
        {"Empty AI Health",new[]{"Здоровье ИИ: 1","Salud de IA: 1","AIのHPを1に","صحة الذكاء الاصطناعي: 1","Santé IA : 1","KI-Lebenspunkte: 1","AI 체력 1로"}},
        {"Enable game speed override",new[]{"Включить изменение скорости","Activar velocidad personalizada","速度変更をオン","تشغيل تعديل سرعة اللعبة","Activer la vitesse modifiée","Spieltempo-Änderung einschalten","게임 속도 변경 켜기"}},
        {"Enter a valid game speed",new[]{"Укажите допустимую скорость","Introduce una velocidad válida","有効なゲーム速度を入力","أدخل سرعة لعبة صالحة","Saisissez une vitesse valide","Gültiges Spieltempo eingeben","올바른 게임 속도를 입력하세요"}},
        {"Error: ",new[]{"Ошибка: ","Error: ","エラー：","خطأ: ","Erreur : ","Fehler: ","오류: "}},
        {"Error details",new[]{"Подробности ошибки","Detalles del error","エラーの詳細","تفاصيل الخطأ","Détails de l’erreur","Fehlerdetails","오류 세부 정보"}},
        {"Export",new[]{"Экспорт","Exportar","エクスポート","تصدير","Exporter","Exportieren","내보내기"}},
        {"Feature hotkeys disabled",new[]{"Горячие клавиши отключены","Atajos desactivados","機能ホットキーを無効化","تم إيقاف الاختصارات","Raccourcis désactivés","Funktions-Hotkeys deaktiviert","기능 단축키 꺼짐"}},
        {"Feature hotkeys enabled",new[]{"Горячие клавиши включены","Atajos activados","機能ホットキーを有効化","تم تشغيل الاختصارات","Raccourcis activés","Funktions-Hotkeys aktiviert","기능 단축키 켜짐"}},
        {"Food",new[]{"Еда","Comida","食料","الطعام","Nourriture","Nahrung","식량"}},
        {"Game detected; waiting for a single-player match...",new[]{"Игра найдена; ожидание одиночной партии...","Juego detectado; esperando partida individual...","ゲームを検出。シングルプレイ待機中...","تم كشف اللعبة؛ في انتظار مباراة فردية...","Jeu détecté ; attente d'une partie solo...","Spiel erkannt; warte auf Einzelspieler-Partie...","게임 감지됨; 싱글 플레이 경기 대기 중..."}},
        {"Game hooked, object cache: ",new[]{"Игра подключена, объектов: ","Juego conectado, objetos: ","ゲームに接続、オブジェクト数：","تم الاتصال باللعبة، عدد العناصر: ","Jeu connecté, objets : ","Spiel verbunden, Objekte: ","게임 연결됨, 객체 수: "}},
        {"Game Process Name:",new[]{"Процесс игры:","Proceso del juego:","ゲームプロセス名：","اسم عملية اللعبة:","Processus du jeu :","Spielprozess:","게임 프로세스 이름:"}},
        {"Game Speed (0.5–10x)",new[]{"Скорость игры (0,5–10×)","Velocidad (0,5–10×)","ゲーム速度（0.5～10倍）","سرعة اللعبة (0.5–10×)","Vitesse du jeu (0,5–10×)","Spieltempo (0,5–10×)","게임 속도 (0.5~10배)"}},
        {"Game speed enabled: ",new[]{"Изменение скорости включено: ","Velocidad activada: ","ゲーム速度を変更：","تم تشغيل سرعة اللعبة: ","Vitesse activée : ","Spieltempo aktiviert: ","게임 속도 변경 켜짐: "}},
        {"Game speed range: 0.5–10x",new[]{"Диапазон скорости: 0,5–10×","Rango de velocidad: 0,5–10×","速度範囲：0.5～10倍","نطاق السرعة: 0.5–10×","Plage de vitesse : 0,5–10×","Tempo-Bereich: 0,5–10×","속도 범위: 0.5~10배"}},
        {"Game speed set to ",new[]{"Скорость установлена: ","Velocidad ajustada a ","ゲーム速度を設定：","تم ضبط سرعة اللعبة على ","Vitesse réglée à ","Spieltempo gesetzt auf ","게임 속도 설정: "}},
        {"Gold",new[]{"Золото","Oro","金","الذهب","Or","Gold","금"}},
        {"Health restored",new[]{"Здоровье восстановлено","Salud restaurada","HPを回復しました","تمت استعادة الصحة","Santé restaurée","Gesundheit wiederhergestellt","체력 회복 완료"}},
        {"Restored: ",new[]{"Восстановлено: ","Recuperadas: ","回復: ","تمت الاستعادة: ","Restaurés : ","Wiederhergestellt: ","회복됨: "}},
        {"AI health set to 1 HP: ",new[]{"Здоровье ИИ установлено на 1: ","Salud de IA establecida en 1: ","AIのHPを1に設定: ","تم ضبط صحة الذكاء الاصطناعي على 1: ","Santé de l’IA réglée à 1 : ","KI-Lebenspunkte auf 1 gesetzt: ","AI 체력을 1로 설정: "}},
        {" units, ",new[]{" юнитов, "," unidades, "," ユニット、"," وحدة، "," unités, "," Einheiten, "," 유닛, "}},
        {" buildings",new[]{" зданий"," edificios"," 建物"," مبانٍ"," bâtiments"," Gebäude"," 건물"}},
        {"Hooked / Ready",new[]{"Подключено / готово","Conectado / listo","接続済み / 準備完了","متصل / جاهز","Connecté / prêt","Verbunden / bereit","연결됨 / 준비됨"}},
        {"Hotkeys",new[]{"Клавиши","Atajos","ホットキー","الاختصارات","Raccourcis","Hotkeys","단축키"}},
        {"Hotkeys: Ctrl+Shift+Home to toggle (currently: ",new[]{"Клавиши: Ctrl+Shift+Home (сейчас: ","Atajos: Ctrl+Shift+Home (ahora: ","ホットキー：Ctrl+Shift+Home（現在：","الاختصارات: Ctrl+Shift+Home (الآن: ","Raccourcis : Ctrl+Shift+Home (actuel : ","Hotkeys: Ctrl+Shift+Home (aktuell: ","단축키: Ctrl+Shift+Home (현재: "}},
        {"Instant Buildings",new[]{"Мгновенная стройка","Construcción instantánea","即時建設","بناء فوري","Construction instantanée","Sofortiger Bau","즉시 건설"}},
        {"Instant Buildings (Once)",new[]{"Мгновенная стройка (раз)","Construcción instantánea (una vez)","即時建設（1回）","بناء فوري (مرة واحدة)","Construction instantanée (1 fois)","Sofortiger Bau (einmal)","즉시 건설 (1회)"}},
        {"Instant Recruit Units",new[]{"Мгновенный набор","Reclutamiento instantáneo","即時生産","تجنيد فوري","Recrutement instantané","Sofortige Rekrutierung","즉시 유닛 생산"}},
        {"Instant Recruit Units (Once)",new[]{"Мгновенный набор (раз)","Reclutar al instante (una vez)","ユニット即時生産（1回）","تجنيد الوحدات فورًا (مرة)","Recrutement immédiat (1 fois)","Sofortige Rekrutierung (einmal)","유닛 즉시 생산 (1회)"}},
        {"Instant Research",new[]{"Мгновенное исследование","Investigación instantánea","即時研究","بحث فوري","Recherche instantanée","Sofortige Forschung","즉시 연구"}},
        {"Instant Research (Once)",new[]{"Мгновенное исследование (раз)","Investigar al instante (una vez)","即時研究（1回）","بحث فوري (مرة واحدة)","Recherche instantanée (1 fois)","Sofortige Forschung (einmal)","즉시 연구 (1회)"}},
        {"Language:",new[]{"Язык:","Idioma:","言語：","اللغة:","Langue :","Sprache:","언어:"}},
        {"Local test build not released",new[]{"Локальная сборка не выпущена","Versión local sin publicar","ローカル版は未公開","نسخة الاختبار المحلية لم تُنشر","Version locale non publiée","Lokale Testversion unveröffentlicht","로컬 테스트 버전 미출시"}},
        {"Log copied to clipboard",new[]{"Журнал скопирован в буфер обмена","Registro copiado al portapapeles","ログをクリップボードにコピーしました","تم نسخ السجل إلى الحافظة","Journal copié dans le presse-papiers","Protokoll in die Zwischenablage kopiert","로그를 클립보드에 복사했습니다"}},
        {"Log exported",new[]{"Журнал экспортирован","Registro exportado","ログをエクスポートしました","تم تصدير السجل","Journal exporté","Protokoll exportiert","로그를 내보냈습니다"}},
        {"Max Population",new[]{"Лимит населения","Población máxima","最大人口","الحد الأقصى للسكان","Population maximale","Max. Bevölkerung","최대 인구"}},
        {"Max Population Cap: 200",new[]{"Предел населения: 200","Límite de población: 200","最大人口上限：200","الحد الأقصى للسكان: 200","Population max. : 200","Bevölkerungsgrenze: 200","최대 인구 제한: 200"}},
        {"off",new[]{"выкл.","desactivado","オフ","متوقف","désactivés","aus","꺼짐"}},
        {"on",new[]{"вкл.","activado","オン","يعمل","activés","ein","켜짐"}},
        {"Only game version 101.103.57257.0 is supported. Detected: ",new[]{"Поддерживается только версия 101.103.57257.0. Найдена: ","Solo se admite la versión 101.103.57257.0. Detectada: ","対応バージョンは 101.103.57257.0 のみ。検出：","الإصدار المدعوم فقط 101.103.57257.0. المكتشف: ","Seule la version 101.103.57257.0 est prise en charge. Détectée : ","Nur Version 101.103.57257.0 wird unterstützt. Erkannt: ","지원 버전은 101.103.57257.0뿐입니다. 감지: "}},
        {"Options",new[]{"Параметры","Opciones","機能","الخيارات","Options","Optionen","기능"}},
        {"Original game speed restored",new[]{"Исходная скорость восстановлена","Velocidad original restaurada","元のゲーム速度に戻しました","تمت استعادة سرعة اللعبة الأصلية","Vitesse initiale restaurée","Ursprüngliches Spieltempo wiederhergestellt","원래 게임 속도로 복원됨"}},
        {"Population cap set to 200",new[]{"Предел населения: 200","Límite de población: 200","人口上限を200に設定","تم ضبط حد السكان على 200","Population maximale fixée à 200","Bevölkerungsgrenze auf 200 gesetzt","인구 제한 200으로 설정"}},
        {"Process ID: ",new[]{"ID процесса: ","ID del proceso: ","プロセスID：","معرّف العملية: ","ID du processus : ","Prozess-ID: ","프로세스 ID: "}},
        {"Project page: GitHub",new[]{"Проект: GitHub","Proyecto: GitHub","プロジェクト：GitHub","صفحة المشروع: GitHub","Projet : GitHub","Projektseite: GitHub","프로젝트: GitHub"}},
        {"Restore Health",new[]{"Восстановить здоровье","Restaurar salud","HP回復","استعادة الصحة","Restaurer la santé","Gesundheit wiederherstellen","체력 회복"}},
        {"Restore Units & Buildings Health",new[]{"Лечить войска и здания","Curar unidades y edificios","ユニットと建物のHPを回復","استعادة صحة الوحدات والمباني","Soigner unités et bâtiments","Einheiten und Gebäude heilen","유닛과 건물 체력 회복"}},
        {"Set ",new[]{"Установить ","Establecer ","","ضبط ","Définir ","Setze ","설정: "}},
        {"Set AI Units & Buildings to 1 HP",new[]{"Здоровье войск и зданий ИИ: 1","Unidades y edificios de IA a 1 PV","AIユニット・建物をHP1に","جعل صحة وحدات ومباني AI تساوي 1","Unités et bâtiments IA à 1 PV","KI-Einheiten und Gebäude auf 1 LP","AI 유닛과 건물 체력 1로"}},
        {"Set Population To 0 (Infinite Population)",new[]{"Население: 0 (без лимита)","Población: 0 (ilimitada)","人口を0に（無限人口）","السكان: 0 (غير محدود)","Population : 0 (illimitée)","Bevölkerung: 0 (unbegrenzt)","인구 0으로 (무한 인구)"}},
        {"Some hotkeys failed; close other trainers.",new[]{"Некоторые клавиши недоступны; закройте другие трейнеры.","Algunos atajos fallaron; cierra otros trainers.","一部のホットキーを登録できません。他のツールを終了してください。","تعذر تسجيل بعض الاختصارات؛ أغلق أدوات التعديل الأخرى.","Certains raccourcis ont échoué ; fermez les autres trainers.","Einige Hotkeys fehlgeschlagen; andere Trainer schließen.","일부 단축키 등록 실패; 다른 트레이너를 닫으세요."}},
        {"Sound effects",new[]{"Звуки","Sonidos","効果音","الأصوات","Sons","Töne","효과음"}},
        {"Sound effects toggle",new[]{"Переключить звуки","Activar o desactivar sonidos","効果音の切り替え","تبديل الأصوات","Activer/désactiver les sons","Töne ein-/ausschalten","효과음 켜기/끄기"}},
        {"Special Notes: Enter a single-player match before use!",new[]{"Важно: сначала войдите в одиночную игру!","Aviso: entra en una partida individual antes de usarlo.","注意：先にシングルプレイを開始してください！","تنبيه: ادخل مباراة فردية قبل الاستخدام!","Attention : lancez une partie solo avant utilisation !","Hinweis: Erst ein Einzelspieler-Spiel starten!","주의: 먼저 싱글 플레이 경기를 시작하세요!"}},
        {"Status: ",new[]{"Статус: ","Estado: ","状態：","الحالة: ","État : ","Status: ","상태: "}},
        {"Stone",new[]{"Камень","Piedra","石","الحجر","Pierre","Stein","석재"}},
        {"Trainer is up to date",new[]{"Трейнер обновлён","Trainer actualizado","最新版です","أداة التعديل محدّثة","Trainer à jour","Trainer ist aktuell","최신 버전입니다"}},
        {"Trainer update required",new[]{"Требуется обновление","Actualización necesaria","更新が必要です","يلزم تحديث الأداة","Mise à jour requise","Update erforderlich","업데이트가 필요합니다"}},
        {"Update check unavailable",new[]{"Проверка недоступна","No se pudo comprobar","更新を確認できません","تعذّر التحقق من التحديث","Vérification indisponible","Prüfung nicht verfügbar","업데이트 확인 불가"}},
        {"Text files (*.txt)|*.txt|All files (*.*)|*.*",new[]{"Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*","Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*","テキスト ファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*","ملفات نصية (*.txt)|*.txt|كل الملفات (*.*)|*.*","Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*","Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*","텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*"}},
        {"Unable to copy log: ",new[]{"Не удалось скопировать журнал: ","No se pudo copiar el registro: ","ログをコピーできません：","تعذر نسخ السجل: ","Impossible de copier le journal : ","Protokoll kann nicht kopiert werden: ","로그를 복사할 수 없습니다: "}},
        {"Unable to export log: ",new[]{"Не удалось экспортировать журнал: ","No se pudo exportar el registro: ","ログをエクスポートできません：","تعذر تصدير السجل: ","Impossible d’exporter le journal : ","Protokoll kann nicht exportiert werden: ","로그를 내보낼 수 없습니다: "}},
        {"Waiting for game",new[]{"Ожидание игры","Esperando juego","ゲーム待機中","انتظار اللعبة","En attente du jeu","Warte auf Spiel","게임 대기 중"}},
        {"Waiting for game process...",new[]{"Ожидание процесса игры...","Esperando el proceso del juego...","ゲームプロセスを待機中...","بانتظار عملية اللعبة...","En attente du processus du jeu...","Warte auf Spielprozess...","게임 프로세스 대기 중..."}},
        {"Wood",new[]{"Дерево","Madera","木材","الخشب","Bois","Holz","목재"}},
        {"Zero Population",new[]{"Обнулить население","Población a cero","人口を0に","تصفير السكان","Population à zéro","Bevölkerung auf null","인구 0으로"}}
    };

    // Engine diagnostics remain in Chinese internally; translate them only at the UI boundary.
    static readonly Dictionary<string,string> EnglishErrors=new Dictionary<string,string>(StringComparer.Ordinal)
    {
        {"请先启动一局游戏","Start a game first"},
        {"仅支持游戏版本","Only game version "},
        {"无法打开游戏进程","Unable to open the game process"},
        {"当前不在有效的单人对局","The current game is not a valid single-player match"},
        {"当前版本的动态根特征不唯一","The dynamic root signature is not unique for this game version"},
        {"游戏速度字段未通过校验","The game speed field failed validation"},
        {"无法定位游戏速度管理器","Unable to locate the game speed manager"},
        {"无法定位游戏速度字段","Unable to locate the game speed field"},
        {"游戏速度必须在","Game speed must be between"},
        {"游戏速度写入后校验失败","Game speed verification failed after writing"},
        {"健康值写入后校验失败","Health verification failed after writing"},
        {"未找到可恢复的己方单位或建筑。","No allied units or buildings were found to restore health."},
        {"未找到可修改的 AI 单位或建筑。","No AI units or buildings were found to change health."},
        {"健康值写入失败：","Health update failed:"},
        {"研发速度原值未通过校验","The original research speed failed validation"},
        {"建造速度原值未通过校验","The original construction speed failed validation"},
        {"读取游戏内存失败","Failed to read game memory"},
        {"写入游戏内存失败","Failed to write game memory"},
        {"对局已改变，无法恢复先前速度","The game has changed; the previous speed cannot be restored"},
        {"对局已改变，无法继续修改速度","The game has changed; speed can no longer be modified"}
    };

    static readonly Dictionary<string,string[]> Errors=new Dictionary<string,string[]>(StringComparer.Ordinal)
    {
        {"请先启动一局游戏",new[]{"Сначала запустите игру.","Inicia una partida primero.","先にゲームを開始してください。","ابدأ مباراة أولاً.","Lancez d'abord une partie.","Bitte zuerst ein Spiel starten.","먼저 게임을 시작하세요."}},
        {"仅支持游戏版本",new[]{"Версия игры не поддерживается.","Versión del juego no compatible.","ゲームのバージョンが未対応です。","إصدار اللعبة غير مدعوم.","Version du jeu non prise en charge.","Spielversion nicht unterstützt.","지원하지 않는 게임 버전입니다."}},
        {"无法打开游戏进程",new[]{"Не удалось открыть процесс игры.","No se pudo abrir el proceso del juego.","ゲームプロセスを開けません。","تعذر فتح عملية اللعبة.","Impossible d'ouvrir le processus du jeu.","Spielprozess konnte nicht geöffnet werden.","게임 프로세스를 열 수 없습니다."}},
        {"当前不在有效的单人对局",new[]{"Нет допустимой одиночной партии.","No hay una partida individual válida.","有効なシングルプレイ中ではありません。","لا توجد مباراة فردية صالحة.","Aucune partie solo valide.","Keine gültige Einzelspieler-Partie.","유효한 싱글 플레이 경기가 아닙니다."}},
        {"当前版本的动态根特征不唯一",new[]{"Неоднозначная сигнатура текущей версии.","Firma de memoria ambigua en esta versión.","現在のバージョンのメモリ特定に失敗しました。","توقيع الذاكرة غير فريد لهذا الإصدار.","Signature mémoire ambiguë pour cette version.","Speichersignatur dieser Version nicht eindeutig.","현재 버전의 메모리 서명이 고유하지 않습니다."}},
        {"游戏速度字段未通过校验",new[]{"Проверка поля скорости не пройдена.","Falló la validación de velocidad.","ゲーム速度フィールドの検証に失敗しました。","فشل التحقق من حقل السرعة.","Validation de la vitesse échouée.","Prüfung des Spielfeldes für Tempo fehlgeschlagen.","게임 속도 필드 검증 실패."}},
        {"无法定位游戏速度管理器",new[]{"Не найден менеджер скорости.","No se encontró el gestor de velocidad.","速度マネージャーが見つかりません。","تعذر العثور على مدير السرعة.","Gestionnaire de vitesse introuvable.","Tempo-Manager nicht gefunden.","게임 속도 관리자를 찾을 수 없습니다."}},
        {"无法定位游戏速度字段",new[]{"Не найдено поле скорости.","No se encontró el campo de velocidad.","速度フィールドが見つかりません。","تعذر العثور على حقل السرعة.","Champ de vitesse introuvable.","Tempo-Feld nicht gefunden.","게임 속도 필드를 찾을 수 없습니다."}},
        {"游戏速度必须在",new[]{"Скорость должна быть в пределах 0,5–10×.","La velocidad debe estar entre 0,5 y 10×.","速度は0.5～10倍にしてください。","يجب أن تكون السرعة بين 0.5 و10×.","La vitesse doit être entre 0,5 et 10×.","Tempo muss zwischen 0,5 und 10× liegen.","게임 속도는 0.5~10배여야 합니다."}},
        {"游戏速度写入后校验失败",new[]{"Запись скорости не прошла проверку; исходное значение восстановлено.","Falló la verificación de velocidad; se intentó restaurar el valor original.","速度の書き込み検証に失敗し、元の値への復元を試みました。","فشل التحقق بعد ضبط السرعة؛ جرت محاولة استعادة القيمة الأصلية.","Validation après écriture échouée ; restauration tentée.","Tempo-Prüfung nach Schreiben fehlgeschlagen; Wiederherstellung versucht.","속도 변경 후 검증 실패; 원래 값 복원 시도."}},
        {"健康値写入后校验失败",new[]{"Проверка записи здоровья не пройдена","Falló la verificación de salud","体力の書き込み検証に失敗しました","فشل التحقق من كتابة الصحة","Échec de la vérification de l’écriture de santé","Prüfung des Gesundheitswerts fehlgeschlagen","체력 기록 검증 실패"}},
        {"未找到可恢复的己方单位或建筑。",new[]{"Не найдены свои юниты или здания для лечения.","No se encontraron unidades o edificios propios para curar.","回復対象の自軍ユニット・建物が見つかりません。","لم يتم العثور على وحدات أو مبانٍ صديقة لاستعادة صحتها.","Aucune unité ou bâtiment allié à soigner.","Keine eigenen Einheiten oder Gebäude zum Heilen gefunden.","회복할 아군 유닛이나 건물을 찾지 못했습니다."}},
        {"未找到可修改的 AI 单位或建筑。",new[]{"Не найдены юниты или здания ИИ для изменения.","No se encontraron unidades o edificios de IA para modificar.","変更対象のAIユニット・建物が見つかりません。","لم يتم العثور على وحدات أو مبانٍ للذكاء الاصطناعي لتعديلها.","Aucune unité ou bâtiment IA à modifier.","Keine KI-Einheiten oder -Gebäude zum Ändern gefunden.","변경할 AI 유닛이나 건물을 찾지 못했습니다."}},
        {"健康值写入失败：",new[]{"Запись здоровья не удалась: ","Falló la escritura de salud: ","体力の書き込みに失敗しました: ","فشلت كتابة الصحة: ","Échec de l’écriture de santé : ","Schreiben des Gesundheitswerts fehlgeschlagen: ","체력 기록 실패: "}},
        {"研发速度原值未通过校验",new[]{"Проверка исходной скорости исследования не пройдена; без изменений.","Falló la validación del valor de investigación; sin cambios.","研究速度の元の値を検証できず、変更しませんでした。","فشل التحقق من سرعة البحث الأصلية؛ لم تُجرَ تغييرات.","Vitesse de recherche initiale invalide ; aucune modification.","Ursprünglicher Forschungswert ungültig; nichts geändert.","연구 속도 원래 값 검증 실패; 변경하지 않았습니다."}},
        {"建造速度原值未通过校验",new[]{"Проверка исходной скорости строительства не пройдена; без изменений.","Falló la validación del valor de construcción; sin cambios.","建設速度の元の値を検証できず、変更しませんでした。","فشل التحقق من سرعة البناء الأصلية؛ لم تُجرَ تغييرات.","Vitesse de construction initiale invalide ; aucune modification.","Ursprünglicher Bauwert ungültig; nichts geändert.","건설 속도 원래 값 검증 실패; 변경하지 않았습니다."}},
        {"读取游戏内存失败",new[]{"Не удалось прочитать память игры.","No se pudo leer la memoria del juego.","ゲームメモリを読み取れません。","تعذرت قراءة ذاكرة اللعبة.","Lecture de la mémoire du jeu impossible.","Spiel-Speicher konnte nicht gelesen werden.","게임 메모리를 읽을 수 없습니다."}},
        {"写入游戏内存失败",new[]{"Не удалось записать память игры.","No se pudo escribir en la memoria del juego.","ゲームメモリに書き込めません。","تعذرت الكتابة في ذاكرة اللعبة.","Écriture dans la mémoire du jeu impossible.","Spiel-Speicher konnte nicht beschrieben werden.","게임 메모리에 쓸 수 없습니다."}},
        {"对局已改变，无法恢复先前速度",new[]{"Партия сменилась; исходную скорость не восстановить.","La partida cambió; no se puede restaurar la velocidad.","対戦が変わったため、元の速度に戻せません。","تغيرت المباراة؛ تعذرت استعادة السرعة السابقة.","La partie a changé ; vitesse précédente non restaurable.","Partie gewechselt; vorheriges Tempo nicht wiederherstellbar.","경기가 변경되어 이전 속도를 복원할 수 없습니다."}},
        {"对局已改变，无法继续修改速度",new[]{"Партия сменилась; скорость больше не меняется.","La partida cambió; no se puede seguir ajustando la velocidad.","対戦が変わったため、速度を変更できません。","تغيرت المباراة؛ تعذر متابعة تعديل السرعة.","La partie a changé ; vitesse non modifiable.","Partie gewechselt; Tempo kann nicht weiter geändert werden.","경기가 변경되어 속도를 계속 변경할 수 없습니다."}}
    };

    internal static string Get(string english,int language)
    {
        string[] translations;
        if(language<3||language>9||!Text.TryGetValue(english,out translations))return english;
        return translations[language-3];
    }

    internal static bool HasKey(string english){return Text.ContainsKey(english);}

    internal static string Error(string detail,int language)
    {
        if(language==2)
        {
            foreach(KeyValuePair<string,string> entry in EnglishErrors)
            {
                if(!detail.StartsWith(entry.Key,StringComparison.Ordinal))continue;
                string suffix=detail.Substring(entry.Key.Length);
                const string firstError="首个错误：";
                int firstErrorIndex=suffix.IndexOf(firstError,StringComparison.Ordinal);
                if(firstErrorIndex>=0)
                {
                    string nestedDetail=suffix.Substring(firstErrorIndex+firstError.Length);
                    suffix=suffix.Substring(0,firstErrorIndex+firstError.Length)+Error(nestedDetail,language);
                }
                return TranslateEnglishError(entry.Value+suffix);
            }
            return detail;
        }

        if(language<3||language>9)return detail;
        foreach(KeyValuePair<string,string[]> entry in Errors)
            if(detail.StartsWith(entry.Key,StringComparison.Ordinal))return entry.Value[language-3]+detail.Substring(entry.Key.Length);
        return detail;
    }

    static string TranslateEnglishError(string detail)
    {
        return detail
            .Replace("（需要且只能有一个 AoE2DE_s 或 AoE2DE 进程）。"," (exactly one AoE2DE_s or AoE2DE process must be running).")
            .Replace("。检测到：",". Detected: ")
            .Replace("（命中 "," (matches ")
            .Replace("）。",").")
            .Replace(" 0.5–10 倍之间。"," 0.5x and 10x.")
            .Replace("，未写入。",", no write was performed.")
            .Replace("，未修改。",", no changes were made.")
            .Replace("，已尝试恢复原值。",", an attempt was made to restore the original value.")
            .Replace("扫描到的对象数："," Objects scanned: ")
            .Replace("。扫描诊断：提交区域 ",". Scan diagnostics: committed regions ")
            .Replace("，读取字节 ",", bytes read ")
            .Replace("，不完整读取 ",", incomplete reads ")
            .Replace("，部分读取 ",", partial reads ")
            .Replace("，vtable 命中 ",", vtable matches ")
            .Replace("已成功修改 ","")
            .Replace(" 个单位、"," units and ")
            .Replace(" 栋建筑；"," buildings were successfully updated; ")
            .Replace(" 个对象失败。首个错误："," objects failed. First error: ")
            .Replace("。",".");
    }
}
