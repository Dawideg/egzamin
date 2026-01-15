#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

struct Album {
	string artistName;
	string albumTitle;
	int songsNumber;
	int year;
	int downloadNumber;
};
vector<Album> arr;

vector<Album> get(vector<Album>& arr) {
	fstream plik;
	plik.open("Data.txt");
	if (plik.good()) {
		while (!plik.eof()) {
			string artist;
			getline(plik,artist);

			string title;
			getline(plik,title);

			string songsCount;
			getline(plik,songsCount);

			string year;
			getline(plik,year);

			string downloads;
			getline(plik,downloads);

			string a;
			getline(plik,a);


			Album album = {
				artist,
				title,
				stoi(songsCount),
				stoi(year),
				stoi(downloads)
			};
			arr.push_back(album);
		}
		plik.close();
	}
	cout << "Pobrano dane" << endl;
	return arr;
};

void show(vector<Album>& arr) {
	cout << " " << endl;
	for (int i = 0; i < arr.size();i++) {
		cout << arr[i].artistName << endl;
		cout << arr[i].albumTitle << endl;
		cout << arr[i].songsNumber << endl;
		cout << arr[i].year << endl;
		cout << arr[i].downloadNumber << endl;
		cout << " " << endl;
	}
}

int main()
{
	get(arr);
	show(arr);
	return 0;
}



