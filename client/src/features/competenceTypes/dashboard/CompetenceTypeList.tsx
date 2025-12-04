import { Box } from "@mui/material";
import CompetenceTypeCard from "./CompetenceTypeCard";

type Props ={
    competenceTypes: CompetenceType[]
}

export default function CompetenceTypeList({competenceTypes}: Props) {
  return (
    <Box sx = {{display:'flex', flexDirection:'column', gap:3}}>
        {competenceTypes.map(competenceType =>(
            <CompetenceTypeCard key={competenceType.id} competenceType={competenceType}/>
        ))}
    </Box>

  )
}