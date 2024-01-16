import * as React from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Link from '@mui/material/Link';
import Typography from '@mui/material/Typography';
import { useState } from 'react';
import { Button } from '@mui/material';


export default function MediaCard({make, model, hp,imageUrl, description,wikiLink}) {
  const [showLongDescription, setShowLongDescription] = useState(description.length < 120);

  function handleShowLongDescription() {
    setShowLongDescription(!showLongDescription);
  }


  return (
    <Card sx={{ maxWidth: 345 }}>
      <CardMedia
        sx={{ height: 220 }}
        image={imageUrl}
        title={make}
      />
      <CardContent>
        <Typography gutterBottom variant="h5" component="div">
          {`${make} ${model}`}
        </Typography>
        <Typography variant="body2" color="text.secondary">
         {
            showLongDescription
          ? description
          : `${description.substring(0,140)}..`
          }
          {
            showLongDescription ?
          <Button style={{marginTop: '10px'}} variant='text'  onClick={() => handleShowLongDescription()}>Show less</Button>
          : <Button style={{marginTop: '10px'}} variant='text' onClick={() => handleShowLongDescription()}>Show more</Button>
          }
        </Typography>
      </CardContent>
            <CardActions>
        <Link  href={wikiLink} target="_blank">Learn more</Link>
      </CardActions>
    </Card>
  );
}
