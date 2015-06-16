<Query Kind="Program" />

void Main()
{
	var result = get_two_movies_to_fill_flight(120, new int[]{45,60,30,90});
	result.Dump();//expected true
}

// Define other methods and classes here
bool get_two_movies_to_fill_flight(int flight_length, int[] movie_lengths){
	var movieLengthsSeenHash = new Hashtable();
	for (int i = 0; i < movie_lengths.Length; i++)
	{
		var matching_second_movie_length = flight_length - movie_lengths[i];
		if (movieLengthsSeenHash.ContainsKey(matching_second_movie_length))
		{
			return true;
		}
		movieLengthsSeenHash.Add(movie_lengths[i],true);
	}
	return false;
}

