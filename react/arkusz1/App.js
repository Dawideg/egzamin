import { useState } from "react";
import "./App.css";
import "bootstrap/dist/css/bootstrap.css";
import Component from "./Component";
//Do public/assets se dupnij te obrazy
function App() {
  const [dane, setDane] = useState([
    { id: 0, alt: "Mak", filename: "obraz1.jpg", category: 1, downloads: 35 },
    {
      id: 1,
      alt: "Bukiet",
      filename: "obraz2.jpg",
      category: 1,
      downloads: 43,
    },
    {
      id: 2,
      alt: "Dalmatyńczyk",
      filename: "obraz3.jpg",
      category: 2,
      downloads: 2,
    },
    {
      id: 3,
      alt: "Świnka morska",
      filename: "obraz4.jpg",
      category: 2,
      downloads: 53,
    },
    {
      id: 4,
      alt: "Rotwailer",
      filename: "obraz5.jpg",
      category: 2,
      downloads: 43,
    },
    { id: 5, alt: "Audi", filename: "obraz6.jpg", category: 3, downloads: 11 },
    { id: 6, alt: "kotki", filename: "obraz7.jpg", category: 2, downloads: 22 },
    { id: 7, alt: "Róża", filename: "obraz8.jpg", category: 1, downloads: 33 },
    {
      id: 8,
      alt: "Świnka morska",
      filename: "obraz9.jpg",
      category: 2,
      downloads: 123,
    },
    {
      id: 9,
      alt: "Foksterier",
      filename: "obraz10.jpg",
      category: 2,
      downloads: 22,
    },
    {
      id: 10,
      alt: "Szczeniak",
      filename: "obraz11.jpg",
      category: 2,
      downloads: 12,
    },
    {
      id: 11,
      alt: "Garbus",
      filename: "obraz12.jpg",
      category: 3,
      downloads: 321,
    },
  ]);

  const [kwaity, setKwiaty] = useState(true);
  const [zwierzeta, setZwierzeta] = useState(true);
  const [samochody, setSamochody] = useState(true);

  var daneFilter = dane.filter((el) => {
    if (el.category === 1 && !kwaity) return false;
    if (el.category === 2 && !zwierzeta) return false;
    if (el.category === 3 && !samochody) return false;
    return true;
  });
  return (
    <>
      <Component name={"sdfasdfasd"}></Component>
      <h1>Kategorie zdjęć</h1>
      <div className="cont">
        <div class="form-check form-switch">
          <input
            class="form-check-input"
            defaultChecked
            type="checkbox"
            onClick={() => setKwiaty(!kwaity)}
          />
          <label class="form-check-label" for="ctrId">
            Kwiaty
          </label>
        </div>
        <div class="form-check form-switch">
          <input
            class="form-check-input"
            defaultChecked
            type="checkbox"
            onClick={() => setZwierzeta(!zwierzeta)}
          />
          <label class="form-check-label" for="ctrId">
            Zwierzęta
          </label>
        </div>
        <div class="form-check form-switch">
          <input
            class="form-check-input"
            defaultChecked
            type="checkbox"
            onClick={() => setSamochody(!samochody)}
          />
          <label class="form-check-label" for="ctrId">
            Samochody
          </label>
        </div>
      </div>
      <div className="cont">
        {daneFilter.map((el) => (
          <div>
            <img src={`./assets/${el.filename}`}></img>
            <h4>Pobrań: {el.downloads}</h4>
            <input
              type="button"
              value="Pobierz"
              className="btn btn-success"
              onClick={() => {
                setDane(
                  dane.map((item) => {
                    if (item.id === el.id) {
                      return { ...item, downloads: item.downloads + 1 };
                    }
                    return item;
                  }),
                );
              }}
            />
          </div>
        ))}
      </div>
    </>
  );
}

export default App;
