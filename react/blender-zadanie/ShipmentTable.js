import React from "react";
import "bootstrap/dist/css/bootstrap.css";

function ShipmentTable(props) {
  return (
    <table className="table table-striped">
      <tbody>
        <tr>
          <th>ID</th>
          <th>Tracking</th>
          <th>Nadawca</th>
          <th>Odbiorca</th>
          <th>Miasto</th>
          <th>Waga</th>
          <th>Status</th>
          <th>ETA</th>
        </tr>
        {props.data.map((el) => (
          <>
            <tr>
              <td>{el.id}</td>
              <td>{el.trackingNumber}</td>
              <td>{el.sender}</td>
              <td>{el.recipient}</td>
              <td>{el.city}</td>
              <td>{el.weightKg}</td>
              <td>
                {el.status == "W_DRODZE" ? (
                  "W drodze"
                ) : el.status === "NADANA" ? (
                  "Nadana"
                ) : (
                  <button className="btn btn-success">Doręczona</button>
                )}
              </td>
              <td>{el.eta}</td>
            </tr>
          </>
        ))}
      </tbody>
    </table>
  );
}
export default ShipmentTable;
