const listLayout = () => {
    if (typeof ListActions !== 'undefined') {
        {ListActions}
    }
    if (typeof Filters !== 'undefined') {
        {Filters}
    }
    if (typeof Sorts !== 'undefined') {
        {Sorts}
    }
    if (typeof Cards !== 'undefined') {
        <React.Fragment>
            {items?.map(item => {
                {Card(item)}
            })}
        </React.Fragment>
    }
    else {
        <table>
            <thead>
                <tr>
                    {Headers}
                </tr>
            </thead>
            <tbody>
                {items?.map(item => {
                    {Rows(item)}
                })}
            </tbody>
        </table>
    }
}