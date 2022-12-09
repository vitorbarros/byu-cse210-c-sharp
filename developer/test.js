const latitude = -22.000;
const longitude = -49.000;
const apiKey = '1d7bffed80c21a62856f00c87f60f8f5';
const baseUrl = 'https://api.openweathermap.org';

const fetchWeatherAPI = async () => {
  const url = `${baseUrl}/data/2.5/weather?lat=${latitude}&lon=${longitude}&appid=${apiKey}`;

  console.log('url', url);

  const response = await fetch(url);

  const result = await response.json();

  console.log('result', JSON.stringify(result, null, 2));
}

(async () => {
  await fetchWeatherAPI();
})();

