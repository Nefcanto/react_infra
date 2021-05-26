const EntityList = (props) => { 
};

const entity = 'Entity';

const ListActions =
<React.Fragment>
    <ListAction icon={} onClick={}>List action</ListAction>
    <ListAction icon={} onClick={}>List action</ListAction>
</React.Fragment>

const Filters =
<React.Fragment>
    <Filter>Filter</Filter>
    <Filter>Filter</Filter>
</React.Fragment>

const Sorts =
<React.Fragment>
    <Sort>Sort</Sort>
    <Sort>Sort</Sort>
</React.Fragment>

const Headers = 
<React.Fragment>
    <td>
        Property Name
    </td>
    <td> 
        Property Name
    </td>
</React.Fragment>;

const Rows =
<React.Fragment>
    <td>
        {item.PropertyValue}
    </td>
    <td>
        {item.PropertyValue}
    </td>
</React.Fragment>;

const Cards = 
<React.Fragment>
    <Card>
        <div>Property title: { item.Property }</div>
        <div>Property title: { item.Property }</div>
    </Card>
</React.Fragment>

const ItemActions =
<React.Fragment>
    <Action icon={} onClick={}>Action</Action>
    <Action icon={} onClick={}>Action</Action>
</React.Fragment>

// Tokenization can be done with convention. Each section should start on a separate line, and each section's content can be found using <React.Fragment> boundary.
// List.js should have some handy utility methods, like setItemProgress that can be called by developers to set progress on an item while performing ajax operations on it.
// List.js should include and repeat Item.js in it, so that we can manage state updates easier.
// Developers either provide `entity` and we create all urls by convention, or they provide each CRUD urls separately.