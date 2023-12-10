class tjtransaction {
    public string tjtransactionName = "";
    public float tjtransactionAmount = 0;
    public string tjcategoryType = "";
    public string tjtransactionDate = "";
    public string tjtransactionDetails = "";

    public string tjtransactionSerialization() {
       string tjtransactionDetails =  tjtransactionName + "," + tjcategoryType + "," + tjtransactionDate + "," + tjtransactionAmount;
       return tjtransactionDetails;
    }
}

/* 
{
    tjtransactionName = something,
    tjtransactionAmount = something,
    etc.
}
*/