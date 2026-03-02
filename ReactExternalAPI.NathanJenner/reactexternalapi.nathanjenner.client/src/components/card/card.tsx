import Card from 'react-bootstrap/Card';
import { useNavigate } from 'react-router-dom';

export type Image = {
    id?: string | number;
    title: string;
    description: string;
    imageUrl: string;
    author: string;
}

//Prop (extending Image) for show/hide the details link on the component
type BasicCardProps = Image & {
    showDetailsLink?: boolean;
}

function BasicCard({
    id,
    title,
    description,
    imageUrl,
    author,
    showDetailsLink = true, // default: show it
}: BasicCardProps) {
    const navigate = useNavigate();

    const handleCardClick = () => {
        if (id !== undefined) {
            navigate(`/image/${id}`);
        }
    };

    return (
        <Card border="dark" style={{ width: "100%" }}>
            <Card.Img variant="top" src={imageUrl} />

            <Card.Body>
                <Card.Title>{title}</Card.Title>
                <Card.Text>{description}.</Card.Text>
                {showDetailsLink && ( //if true will render Details link
                    <Card.Link role="button" onClick={handleCardClick}>
                        Details
                    </Card.Link>
                )}
            </Card.Body>

            <Card.Footer className="text-muted">Author: {author}</Card.Footer>
        </Card>
    );
}

export default BasicCard;