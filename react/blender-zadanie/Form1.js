import React, { useState } from "react";
import "bootstrap/dist/css/bootstrap.css";
function Form1() {
  const [tytul, setTytul] = useState("");
  const [rodzaj, setRodzaj] = useState(0);

  function pobierzDane() {
    console.log("tytuł: " + tytul + "; " + "rodzaj: " + rodzaj);
  }
  return (
    <>
      <form>
        <div className="form-group">
          <label htmlFor="exampleInputEmail1">Tytuł filmu</label>
          <input
            type="text"
            className="form-control"
            value={tytul}
            onChange={(e) => setTytul(e.target.value)}
          />
        </div>
        <div className="form-group">
          <label htmlFor="exampleInputEmail1">Rodzaj</label>
          <select onChange={(e) => setRodzaj(e.target.value)} value={rodzaj}>
            <option></option>
            <option value={1}>Komedia</option>
            <option value={2}>Obyczajowy</option>
            <option value={3}>Sensacyjny</option>
            <option value={4}>Horror</option>
          </select>
        </div>
        <input type="button" value="Dodaj" onClick={pobierzDane} />
      </form>
    </>
  );
}
export default Form1;
