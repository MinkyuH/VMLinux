export default `
  type Tweet {
    _id: String
    text: String
  }

  type Query{
      getTweets: [Tweet]
  }

  schema {
      query: Query
  }
`

//text is coming from Tweet model
//schema model for query create schema