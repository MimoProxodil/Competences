import { Button, Card, CardActions, CardContent, CardMedia, Typography } from "@mui/material"

type Props ={
    competenceType: CompetenceType
}

export default function CompetenceTypeDetails({competenceType}: Props) {
  return (
    <Card sx={{borderRadius: 3}}>
        <CardMedia 
            component='img'
            src={`/images/competenceTypeImages/asuTitle.png`}
        />
        <CardContent>
            <Typography variant="h5">{competenceType.name}</Typography>
            <Typography variant="subtitle1" fontWeight='light'>{competenceType.shortName}</Typography>
        </CardContent>
        <CardActions>
            <Button color="primary">Редактировать</Button>
            <Button color="inherit">Отмена</Button>

        </CardActions>
    </Card>
  )
}