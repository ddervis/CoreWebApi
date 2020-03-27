using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApi.Models;
using FirstWebApi.Models.Entity;
using FirstWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("[controller]")]
    public class TodoItemController : Controller
    {
        private readonly ITodoRepository _todoitemRepository;
        public TodoItemController(ITodoRepository todoRepository)
        {
            _todoitemRepository = todoRepository;
        }

        // GET: book
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            var list = _todoitemRepository.GetALL();
            return list;
        }

        //Kar Oranları için Test
        [HttpPost()]
        [Route("ProfitRates")]
        public Data ProfitRates([FromBody] object date)
        {
            var response = new Data() {
                IsSuccess = true,
                EsbError=true,
                Response= "<Root><Tarih>20200208</Tarih><EUR><TutarAraligi><MinTutar>250,00</MinTutar><MaxTutar>24999,99</MaxTutar><KarPayi><Ay1>0,00</Ay1><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Ay6>134,23</Ay6><Ay12>291,90</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>139,00</Y1A6><Y1A12>291,90</Y1A12></KarPayi><KarOrani><Ay1>0,00</Ay1><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Ay6>27,22</Ay6><Ay12>29,11</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>27,28</Y1A6><Y1A12>29,11</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>25000,00</MinTutar><MaxTutar>99999,99</MaxTutar><KarPayi><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Ay6>134,23</Ay6><Ay12>0,00</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>139,00</Y1A6><Y1A12>291,90</Y1A12></KarPayi><KarOrani><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Ay6>27,22</Ay6><Ay12>0,00</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>27,28</Y1A6><Y1A12>29,11</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>100000,00</MinTutar><MaxTutar>999999,99</MaxTutar><KarPayi><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3></KarPayi><KarOrani><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3></KarOrani></TutarAraligi><TutarAraligi><MinTutar>250000,00</MinTutar><MaxTutar>999999,99</MaxTutar><KarPayi><Ay6>134,23</Ay6><Ay12>0,00</Ay12><Y1A6>139,00</Y1A6><Y1A12>291,90</Y1A12></KarPayi><KarOrani><Ay6>27,22</Ay6><Ay12>0,00</Ay12><Y1A6>27,28</Y1A6><Y1A12>29,11</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>1000000,00</MinTutar><MaxTutar>4999999,99</MaxTutar><KarPayi><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Ay6>134,23</Ay6><Ay12>0,00</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>139,00</Y1A6><Y1A12>291,90</Y1A12></KarPayi><KarOrani><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Ay6>27,22</Ay6><Ay12>0,00</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>27,28</Y1A6><Y1A12>29,11</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>5000000,00</MinTutar><MaxTutar>1000000000000,00</MaxTutar><KarPayi><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Ay6>134,23</Ay6><Ay12>291,90</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>139,00</Y1A6><Y1A12>291,90</Y1A12></KarPayi><KarOrani><Ay1>0,00</Ay1><Ay3>0,00</Ay3><Ay6>27,22</Ay6><Ay12>29,11</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>27,28</Y1A6><Y1A12>29,11</Y1A12></KarOrani></TutarAraligi></EUR><TL><TutarAraligi><MinTutar>250,00</MinTutar><MaxTutar>24999,99</MaxTutar><KarPayi><Ay1>28,28</Ay1><Ay3>85,31</Ay3><Ay6>175,77</Ay6><Ay12>389,93</Ay12><Y1A1>28,28</Y1A1><Y1A3>87,26</Y1A3><Y1A6>182,14</Y1A6><Y1A12>389,93</Y1A12></KarPayi><KarOrani><Ay1>33,30</Ay1><Ay3>34,22</Ay3><Ay6>35,64</Ay6><Ay12>38,89</Ay12><Y1A1>33,30</Y1A1><Y1A3>34,25</Y1A3><Y1A6>35,74</Y1A6><Y1A12>38,89</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>4900,00</MinTutar><MaxTutar>1000000000000,00</MaxTutar><KarPayi><Ay3>85,31</Ay3></KarPayi><KarOrani><Ay3>34,22</Ay3></KarOrani></TutarAraligi><TutarAraligi><MinTutar>24900,00</MinTutar><MaxTutar>1000000000000,00</MaxTutar><KarPayi><Ay3>85,31</Ay3></KarPayi><KarOrani><Ay3>34,22</Ay3></KarOrani></TutarAraligi><TutarAraligi><MinTutar>25000,00</MinTutar><MaxTutar>99999,99</MaxTutar><KarPayi><Ay1>28,28</Ay1><Ay3>85,31</Ay3><Ay6>175,77</Ay6><Ay12>389,93</Ay12><Y1A1>28,28</Y1A1><Y1A3>87,26</Y1A3><Y1A6>182,14</Y1A6><Y1A12>389,93</Y1A12></KarPayi><KarOrani><Ay1>33,30</Ay1><Ay3>34,22</Ay3><Ay6>35,64</Ay6><Ay12>38,89</Ay12><Y1A1>33,30</Y1A1><Y1A3>34,25</Y1A3><Y1A6>35,74</Y1A6><Y1A12>38,89</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>100000,00</MinTutar><MaxTutar>999999,99</MaxTutar><KarPayi><Ay1>28,28</Ay1><Ay3>85,31</Ay3><Y1A1>28,28</Y1A1><Y1A3>87,26</Y1A3></KarPayi><KarOrani><Ay1>33,30</Ay1><Ay3>34,22</Ay3><Y1A1>33,30</Y1A1><Y1A3>34,25</Y1A3></KarOrani></TutarAraligi><TutarAraligi><MinTutar>250000,00</MinTutar><MaxTutar>999999,99</MaxTutar><KarPayi><Ay6>175,77</Ay6><Ay12>389,93</Ay12><Y1A6>182,14</Y1A6><Y1A12>389,93</Y1A12></KarPayi><KarOrani><Ay6>35,64</Ay6><Ay12>38,89</Ay12><Y1A6>35,74</Y1A6><Y1A12>38,89</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>1000000,00</MinTutar><MaxTutar>4999999,99</MaxTutar><KarPayi><Ay1>28,28</Ay1><Ay3>85,31</Ay3><Ay6>175,77</Ay6><Ay12>389,93</Ay12><Y1A1>28,28</Y1A1><Y1A3>87,26</Y1A3><Y1A6>182,14</Y1A6><Y1A12>389,93</Y1A12></KarPayi><KarOrani><Ay1>33,30</Ay1><Ay3>34,22</Ay3><Ay6>35,64</Ay6><Ay12>38,89</Ay12><Y1A1>33,30</Y1A1><Y1A3>34,25</Y1A3><Y1A6>35,74</Y1A6><Y1A12>38,89</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>5000000,00</MinTutar><MaxTutar>1000000000000,00</MaxTutar><KarPayi><Ay1>28,28</Ay1><Ay3>85,31</Ay3><Ay6>175,77</Ay6><Ay12>389,93</Ay12><Y1A1>28,28</Y1A1><Y1A3>87,26</Y1A3><Y1A6>182,14</Y1A6><Y1A12>389,93</Y1A12></KarPayi><KarOrani><Ay1>33,30</Ay1><Ay3>34,22</Ay3><Ay6>35,64</Ay6><Ay12>38,89</Ay12><Y1A1>33,30</Y1A1><Y1A3>34,25</Y1A3><Y1A6>35,74</Y1A6><Y1A12>38,89</Y1A12></KarOrani></TutarAraligi></TL><USD><TutarAraligi><MinTutar>250,00</MinTutar><MaxTutar>24999,99</MaxTutar><KarPayi><Ay1>25,10</Ay1><Ay3>75,48</Ay3><Ay6>154,82</Ay6><Ay12>0,00</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>160,37</Y1A6><Y1A12>340,02</Y1A12></KarPayi><KarOrani><Ay1>29,55</Ay1><Ay3>30,27</Ay3><Ay6>31,39</Ay6><Ay12>0,00</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>31,47</Y1A6><Y1A12>33,91</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>25000,00</MinTutar><MaxTutar>99999,99</MaxTutar><KarPayi><Ay1>25,10</Ay1><Ay3>75,48</Ay3><Ay6>154,82</Ay6><Ay12>0,00</Ay12><Y1A1>25,10</Y1A1><Y1A3>0,00</Y1A3><Y1A6>160,37</Y1A6><Y1A12>340,02</Y1A12></KarPayi><KarOrani><Ay1>29,55</Ay1><Ay3>30,27</Ay3><Ay6>31,39</Ay6><Ay12>0,00</Ay12><Y1A1>29,55</Y1A1><Y1A3>0,00</Y1A3><Y1A6>31,47</Y1A6><Y1A12>33,91</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>100000,00</MinTutar><MaxTutar>999999,99</MaxTutar><KarPayi><Ay1>25,10</Ay1><Ay3>75,48</Ay3><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3></KarPayi><KarOrani><Ay1>29,55</Ay1><Ay3>30,27</Ay3><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3></KarOrani></TutarAraligi><TutarAraligi><MinTutar>250000,00</MinTutar><MaxTutar>999999,99</MaxTutar><KarPayi><Ay6>0,00</Ay6><Ay12>0,00</Ay12><Y1A6>160,37</Y1A6><Y1A12>340,02</Y1A12></KarPayi><KarOrani><Ay6>0,00</Ay6><Ay12>0,00</Ay12><Y1A6>31,47</Y1A6><Y1A12>33,91</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>1000000,00</MinTutar><MaxTutar>4999999,99</MaxTutar><KarPayi><Ay1>25,10</Ay1><Ay3>75,48</Ay3><Ay6>0,00</Ay6><Ay12>0,00</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>160,37</Y1A6><Y1A12>340,02</Y1A12></KarPayi><KarOrani><Ay1>29,55</Ay1><Ay3>30,27</Ay3><Ay6>0,00</Ay6><Ay12>0,00</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>31,47</Y1A6><Y1A12>33,91</Y1A12></KarOrani></TutarAraligi><TutarAraligi><MinTutar>5000000,00</MinTutar><MaxTutar>1000000000000,00</MaxTutar><KarPayi><Ay1>25,10</Ay1><Ay3>75,48</Ay3><Ay6>0,00</Ay6><Ay12>340,02</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>160,37</Y1A6><Y1A12>340,02</Y1A12></KarPayi><KarOrani><Ay1>29,55</Ay1><Ay3>30,27</Ay3><Ay6>0,00</Ay6><Ay12>33,91</Ay12><Y1A1>0,00</Y1A1><Y1A3>0,00</Y1A3><Y1A6>31,47</Y1A6><Y1A12>33,91</Y1A12></KarOrani></TutarAraligi></USD><XAU><TutarAraligi><MinTutar>100,00</MinTutar><MaxTutar>99999999999,99</MaxTutar><KarPayi><Ay1>18,77</Ay1><Ay3>56,10</Ay3><Ay6>0,00</Ay6><Ay12>245,50</Ay12></KarPayi><KarOrani><Ay1>22,10</Ay1><Ay3>22,50</Ay3><Ay6>0,00</Ay6><Ay12>24,48</Ay12></KarOrani></TutarAraligi></XAU></Root>"
            };

            return response;
        }
        //Exchange Servisi için Test
        [HttpGet()]
        [Route("ExchangeRates")]
        public Data ExchangeRates()
        {
            var response = new Data()
            {
                IsSuccess = true,
                EsbError = false,
                Response = "{\r\n  \"TranDate\": \"2020-02-17T09:55:19.2516511+03:00\",\r\n  \"CurrencyPrices\": [\r\n    {\r\n      \"CurrencyName\": \"USD\",\r\n      \"BID\": 5.45,\r\n      \"ASK\": 5.85\r\n    },\r\n    {\r\n      \"CurrencyName\": \"EUR\",\r\n      \"BID\": 6.119,\r\n      \"ASK\": 6.569\r\n    },\r\n    {\r\n      \"CurrencyName\": \"GBP\",\r\n      \"BID\": 7.17,\r\n      \"ASK\": 7.697\r\n    },\r\n    {\r\n      \"CurrencyName\": \"CHF\",\r\n      \"BID\": 5.468,\r\n      \"ASK\": 5.87\r\n    },\r\n    {\r\n      \"CurrencyName\": \"NOK\",\r\n      \"BID\": 0.636,\r\n      \"ASK\": 0.684\r\n    },\r\n    {\r\n      \"CurrencyName\": \"DKK\",\r\n      \"BID\": 0.82,\r\n      \"ASK\": 0.881\r\n    },\r\n    {\r\n      \"CurrencyName\": \"SEK\",\r\n      \"BID\": 0.587,\r\n      \"ASK\": 0.631\r\n    },\r\n    {\r\n      \"CurrencyName\": \"SAR\",\r\n      \"BID\": 1.453,\r\n      \"ASK\": 1.56\r\n    },\r\n    {\r\n      \"CurrencyName\": \"AUD\",\r\n      \"BID\": 3.879,\r\n      \"ASK\": 4.165\r\n    },\r\n    {\r\n      \"CurrencyName\": \"CAD\",\r\n      \"BID\": 4.091,\r\n      \"ASK\": 4.393\r\n    },\r\n    {\r\n      \"CurrencyName\": \"KWD\",\r\n      \"BID\": 17.925,\r\n      \"ASK\": 19.242\r\n    },\r\n    {\r\n      \"CurrencyName\": \"JPY\",\r\n      \"BID\": 0.0488,\r\n      \"ASK\": 0.0525\r\n    },\r\n    {\r\n      \"CurrencyName\": \"XAU\",\r\n      \"BID\": 224.0,\r\n      \"ASK\": 241.0\r\n    },\r\n    {\r\n      \"CurrencyName\": \"RUB\",\r\n      \"BID\": 0.0835,\r\n      \"ASK\": 0.0897\r\n    },\r\n    {\r\n      \"CurrencyName\": \"AED\",\r\n      \"BID\": 1.483,\r\n      \"ASK\": 1.593\r\n    },\r\n    {\r\n      \"CurrencyName\": \"QAR\",\r\n      \"BID\": 1.497,\r\n      \"ASK\": 1.607\r\n    },\r\n    {\r\n      \"CurrencyName\": \"XAG\",\r\n      \"BID\": 2.65,\r\n      \"ASK\": 2.84\r\n    },\r\n    {\r\n      \"CurrencyName\": \"CNY\",\r\n      \"BID\": 0.8121,\r\n      \"ASK\": 0.8718\r\n    },\r\n    {\r\n      \"CurrencyName\": \"BGN\",\r\n      \"BID\": 3.129,\r\n      \"ASK\": 3.359\r\n    },\r\n    {\r\n      \"CurrencyName\": \"RON\",\r\n      \"BID\": 1.288,\r\n      \"ASK\": 1.383\r\n    },\r\n    {\r\n      \"CurrencyName\": \"IQD\",\r\n      \"BID\": 0.00463,\r\n      \"ASK\": 0.00466\r\n    }\r\n  ]\r\n}"
            };
            //string removeChars = "\n\r\\";
            //string result = response.Response;
            //foreach (char c in removeChars)
            //{
            //    result = result.Replace(c.ToString(), string.Empty);
            //}
            return response;
        }


        [HttpGet("{id}", Name = "TodoItem")]
        public IActionResult Get(int id)
        {
            var todoItem = _todoitemRepository.GetById(id);
            if(todoItem == null)
            {
                return NotFound();
            }
            return Ok(todoItem);
        }
        [HttpPost]
        public IActionResult Post([FromBody]TodoItem value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            var createdTodoItem = _todoitemRepository.Add(value);

            return CreatedAtRoute("GetTodoItem", new { id = createdTodoItem.Id }, createdTodoItem);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]TodoItem value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            var note = _todoitemRepository.GetById(id);

            if (note == null)
            {
                return NotFound();
            }

            value.Id = id;
            _todoitemRepository.Update(value);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var productionorder = _todoitemRepository.GetById(id);
            if (productionorder == null)
            {
                return NotFound();
            }
            _todoitemRepository.Delete(productionorder);

            return NoContent();
        }

    }
}