SELECT 'Alumnos registrados' = COUNT(R.Id)
  FROM Registrations AS R

SELECT 'Alumnos registrados de ISC' = COUNT(R.Id)
  FROM Registrations AS R
  INNER JOIN Students AS S ON S.Id = R.Id
  WHERE S.IsGuest = 0

SELECT 'Alumnos invitados' = COUNT(R.Id)
  FROM Registrations AS R
  INNER JOIN Students AS S ON S.Id = R.Id
  WHERE S.IsGuest = 1

SELECT 'Semestre' = S.Semester, Alumnos = COUNT(S.Id)
  FROM Registrations AS R
  INNER JOIN Students AS S ON S.Id = R.Id
  GROUP BY S.Semester

SELECT 'Alumnos con talleres' = COUNT(Id)
	FROM Registrations AS R
	WHERE R.WorkshopId IS NOT NULL

SELECT 'Taller' = W.Topic, Alumnos = COUNT(R.WorkshopId)
	FROM Registrations AS R
	INNER JOIN Workshops AS W ON W.Id = R.WorkshopId
	GROUP BY W.Topic

SELECT 'Team' = T.Name
	  ,E.Name
	  ,'IsLeader' =  CAST(CASE WHEN S.Id = T.LeaderId THEN 1 ELSE 0 END AS BIT)
	  ,S.ControlNumber
	  ,S.FullName
	  ,S.Semester
FROM Students AS S
INNER JOIN TeamMembers AS TM ON TM.StudentId = S.Id
INNER JOIN Teams AS T ON T.Id = TM.TeamId
INNER JOIN [Events] AS E ON E.Id = T.EventId
ORDER BY T.Id

SELECT S.*
FROM Students AS S
INNER JOIN Registrations AS R ON R.Id = S.Id
ORDER BY S.Id ASC