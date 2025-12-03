import { Container, CssBaseline } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react"
import NavBar from "./NavBar";
import CompetenceTypeDashboard from "../../features/competenceTypes/CompetenceTypeDashboard";

function App() {
  const [competenceTypes, setCompetenceTypes] = useState<CompetenceType[]>([]);

  useEffect(() =>{
    axios.get<CompetenceType[]>('http://localhost:5270/api/competencetypes')
    .then(response => setCompetenceTypes(response.data))
    return () => {}
  }, [])

  return (
    <>
      <CssBaseline />
      <NavBar />
      <Container maxWidth='xl' sx={{mt:3}}>
        <CompetenceTypeDashboard competenceTypes ={competenceTypes} />
      </Container>


    </>

  )
}

export default App
