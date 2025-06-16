Se va realiza o aplicație Windows Forms pentru a gestiona angajații unei companii.
Fiecare angajat este caracterizat de:

* cod angajat (unic, autogenerat)
* nume
* salariu
* codManager
Toți angajații raportează, direct sau indirect, unui singur manager general.

- Sa se construiască o clasă Angajat pentru gestionarea datelor. - DONE

- Aplicația WindowsForms care afiseaza in forma principal liste de angajați sub forma arborescenta.

- La selectarea unui angajat in tree view, sa se afiseze intr-un list view toți angajații care 
raporteaza direct angajatului selectat. Fiecare angajat va avea in dreptul sau afișate, pe coloane 
separate, salariul si numele -managerului.

- Un formular secundar care ne permite adăugarea unui nou angajat. Managerul se va selecta dintr-un 
combobox, din lista tuturor angajaților, in ordine alfabetica dupa nume.

- Aplicația trebuie sa persiste datele intr-o baza de date SQL. DONE

- Aplicația poate exporta datele in format XML, binar si CSV.

- Sa se adauge o opțiune de tiparire a listei de angajați, pe trei coloane nume si prenume manager, 
salariu, nume si prenume manager. Tiparirea se va executa in forma arborescenta, indentata corespunzator.

- Sa se deseneze un grafic de tip pie chart unde sa fie afișate nume salarii tuturor angajaților care 
au oameni in subordine, respectiv suma salariilor angajaților care nu au oameni in subordine.

- Cu list view-ul in focus, la apasarea tastei DELETE, sa se șterge toți angajații selectati in list view,
dar doar daca sunt manageri. Daca sunt, sa se afișeze un mesaj de eroare, intr-un message box, cu iconița si titlul potrivite.

- Cu list view-ul in focus, la apasarea tastei F6, sa se afișeze in list view toți angajații din baza de date, descrescator dupa salariu.