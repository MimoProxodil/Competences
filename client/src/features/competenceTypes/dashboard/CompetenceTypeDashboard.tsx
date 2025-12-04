import { Grid2 } from "@mui/material";
import CompetenceTypeList from "./CompetenceTypeList";
import CompetenceTypeDetails from "../details/CompetenceTypeDetails";

type Props ={
    competenceTypes: CompetenceType[]
}

export default function CompetenceTypeDashboard({competenceTypes}: Props) {
  return (
    <Grid2 container spacing={3}>
        <Grid2 size={7}>
            <CompetenceTypeList competenceTypes={competenceTypes}/>
        </Grid2>
        <Grid2 size={5}>
            {competenceTypes[0] && <CompetenceTypeDetails competenceType={competenceTypes[0]}/>}
        </Grid2>
    </Grid2>

  )
}
