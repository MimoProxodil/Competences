import { List, ListItem, ListItemText, Typography } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react"

function App() {
  const title = 'Сервис компетенций'
  const [competenceTypes, setCompetenceTypes] = useState<CompetenceType[]>([]);

  useEffect(() =>{
    axios.get<CompetenceType[]>('http://localhost:5270/api/competencetypes')
    .then(response => setCompetenceTypes(response.data))
    return () => {}
  }, [])

  return (
    <>
        <Typography variant='h3'>{title}</Typography>
        <List>
          {competenceTypes.map((compType)=>(
            <ListItem key={compType.id}>
              <ListItemText>{compType.name}</ListItemText> 
            </ListItem>
          ))}

        </List>
    </>

  )
}

export default App
