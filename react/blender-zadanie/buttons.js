import React from "react";
import "bootstrap/dist/css/bootstrap.css";

export function AllButton({ onClick }) {
  return (
    <input
      type="button"
      onClick={onClick}
      className="btn btn-black"
      value="Wszystkie"
    />
  );
}
export function ShipmentButton({ onClick }) {
  return (
    <input
      type="button"
      onClick={onClick}
      className="btn btn-success"
      value="W drodze"
    />
  );
}
export function DeliveredButton({ onClick }) {
  return (
    <input
      type="button"
      onClick={onClick}
      className="btn btn-success"
      value="Doręczono"
    />
  );
}
