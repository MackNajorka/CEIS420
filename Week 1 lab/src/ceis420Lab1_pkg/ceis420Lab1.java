package ceis420Lab1_pkg;

import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Scanner;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

public class ceis420Lab1 {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);

		String countryCode = "";
		System.out.println("Please enter the country code: ");
		countryCode = input.nextLine().toUpperCase(); // Ask the user for the country code
		String postalCode = "";
		System.out.println("Please enter the postal/zip code: ");
		postalCode = input.nextLine().toUpperCase(); // Ask the user for the postal code
		String s3 = String.format(
				"http://api.geonames.org/postalCodeLookupJSON?postalcode=%s&country=%s&username=devry", postalCode,
				countryCode);

		URL url;
		try {
			url = new URL(s3);// Set up string as a URL

			HttpURLConnection connection = (HttpURLConnection) url.openConnection();
			connection.setRequestMethod("GET");

			InputStream content = (InputStream) connection.getInputStream();
			JSONParser jpar = new JSONParser();
			JSONObject obj = (JSONObject) jpar.parse(new InputStreamReader(content, "UTF-8"));

			//System.out.println("JSON Object: " + obj);

			JSONArray restResponse = (JSONArray) obj.get("postalcodes");
			// Iterate jsonArray using for loop
			for (Object o : restResponse) {
				if (o instanceof JSONObject) {

					String name = (String) ((JSONObject) o).get("adminCode1");
					System.out.println("State Code is " + name);
					name = (String) ((JSONObject) o).get("postalcode");
					System.out.println("Postal Code is " + name);
					name = (String) ((JSONObject) o).get("adminName2");
					if (name != null && !name.isEmpty())
						System.out.println("County is " + name);
					name = (String) ((JSONObject) o).get("adminName1");
					System.out.println("State Name is " + name);
					name = (String) ((JSONObject) o).get("placeName");
					System.out.println("City Name is " + name);
					System.out.println("---------------------- ");
				}
			}


		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}