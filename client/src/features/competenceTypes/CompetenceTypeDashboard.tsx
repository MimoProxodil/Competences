import { Grid2, List, ListItem, ListItemText } from "@mui/material";

type Props ={
    competenceTypes: CompetenceType[]
}

export default function CompetenceTypeDashboard(props: Props) {
  return (
    <Grid2 container>
        <Grid2 size={9}>
            <List>
                {props.competenceTypes.map((compType)=>(
                    <ListItem key={compType.id}>
                    <ListItemText>{compType.name}</ListItemText> 
                    </ListItem>
                ))}
            </List>
        </Grid2>
    </Grid2>

  )
}
