import { Button, Card, CardActions, CardContent, Typography } from "@mui/material"

type Props ={
    competenceType: CompetenceType
}

export default function CompetenceTypeCard({competenceType}: Props) {
  return (
    <Card sx={{borderRadius: 3}}>
        <CardContent>
            <Typography variant="h5">{competenceType.name}</Typography>
            <Typography sx={{color: 'text.secondary', mb:1}}>{competenceType.shortName}</Typography>

        </CardContent>
        <CardActions sx ={{display: 'flex', justifyContent: 'right', pb:2}}>
            <Button size="medium" variant="contained">Просмотр</Button>
        </CardActions>

    </Card>
  )
}