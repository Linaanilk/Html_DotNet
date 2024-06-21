interface Librarian
{
    doWork: ()=>void;
}

class ElementarySchoolLibrarian implements Librarian
{
    doWork()
    {
        console.log('Reading to and teaching children...')
    }
}
