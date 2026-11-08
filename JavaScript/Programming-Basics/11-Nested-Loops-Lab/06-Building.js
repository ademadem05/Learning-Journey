function buildings(floorCount, roomsPerFloor) {
  for (let currentFloor = floorCount; currentFloor >= 1; currentFloor--) {
    let allFloorRoom = "";
    for (let currentRoom = 0; currentRoom < roomsPerFloor; currentRoom++) {
      if (currentFloor === floorCount) {
        allFloorRoom += `L${currentFloor}${currentRoom} `;
      } else if (currentFloor % 2 === 0) {
        allFloorRoom += `O${currentFloor}${currentRoom} `;
      } else {
        allFloorRoom += `A${currentFloor}${currentRoom} `;
      }
    }
    console.log(allFloorRoom);
  }
}

