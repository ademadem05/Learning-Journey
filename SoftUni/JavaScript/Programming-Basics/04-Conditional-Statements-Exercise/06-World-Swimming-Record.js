function record_swimming(record_seconds, length_of_meter, Time_for_one_meter) {
  let gecilmesi_gereken = length_of_meter * Time_for_one_meter;
  let gecen_sure = Math.floor(length_of_meter / 15);
  let her_15m = gecen_sure * 12.5;
  let total = gecilmesi_gereken + her_15m;
  if (total >= record_seconds) {
    let eger_dusuk_ise = total - record_seconds;
    console.log(
      `No, he failed! He was ${eger_dusuk_ise.toFixed(2)} seconds slower.`
    );
  }else{
    console.log(
      `Yes, he succeeded! The new world record is ${total.toFixed(2)} seconds.`
    );
  }
}

