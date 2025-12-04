import { Box, Container, CssBaseline } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react"
import NavBar from "./NavBar";
import CompetenceTypeDashboard from "../../features/competenceTypes/dashboard/CompetenceTypeDashboard";
import EduLevelTabSwitcher from "./EduLevelTabSwitcher";

function App() {
  const [competenceTypes, setCompetenceTypes] = useState<CompetenceType[]>([]);
  
  useEffect(() =>{
    axios.get<CompetenceType[]>('http://localhost:5270/api/competencetypes')
    .then(response => setCompetenceTypes(response.data))
    return () => {}
  }, [])

  return (
    <Box sx={{bgcolor:'#eeeeee'}}>
      <CssBaseline />
      <NavBar />
      <EduLevelTabSwitcher />
      <Container maxWidth='xl' sx={{mt:3}}>
        <CompetenceTypeDashboard competenceTypes ={competenceTypes} />
      </Container>


    </Box>

  )
}

export default App
