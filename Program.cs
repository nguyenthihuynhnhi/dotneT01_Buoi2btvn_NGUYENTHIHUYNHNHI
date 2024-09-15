#region Tính số ngày trong tuần và số lẻ
Console.WriteLine("Nhập số ngày:");
int soNgay = Convert.ToInt32(Console.ReadLine());

int soTuan = soNgay / 7;
int ngayDu = soNgay % 7;

Console.WriteLine($"Số Tuần : {soTuan}, Số ngày dư là: {ngayDu}");
#endregion

#region Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
Console.WriteLine("Nhập vào giá trị đơn hàng vnđ (đơn vị: nghìn): ");
int giaTriBill = Convert.ToInt32(Console.ReadLine());
if (giaTriBill <= 0)
{
  Console.WriteLine("Giá trị đơn hàng không thể nhỏ hơn 0.");
  return;
}

Console.WriteLine("Nhập vào phần trăm (%) giảm giá: ");
int phanTramSale = Convert.ToInt32(Console.ReadLine());
if (phanTramSale < 0 || phanTramSale > 100)
{
  Console.WriteLine("Phần trăm giảm giá phải nằm trong khoảng từ 0% đến 100%.");
  return;
}

int soTienSale = giaTriBill / 100 * phanTramSale;

int soTienThanhToan = giaTriBill - soTienSale;

Console.WriteLine($"Giá trị đơn hàng: {giaTriBill}000 vnđ, Phần trăm giảm giá: {phanTramSale}%, Số tiền giảm: {soTienSale}000 vnđ, Số tiền phải thanh toán: {soTienThanhToan}000 vnđ.");
#endregion

#region Chuyển đổi thời gian từ giờ sang phút
Console.WriteLine("Nhập vào số phút: ");
int soPhut = Convert.ToInt32(Console.ReadLine());
if (soPhut <= 0)
{
  Console.WriteLine("Số phút không thể nhỏ hơn 0.");
  return;
}
int soGio = soPhut / 60;
int soPhutDu = soPhut % 60;

Console.WriteLine($"số phút nhập vào là: {soPhut} => {soGio} giờ, {soPhutDu} phút.");
#endregion

#region Tính tổng số tiền sau khi cộng thêm thuế VAT.
Console.WriteLine("Nhập vào số tiền gốc vnđ (đơn vị: nghìn): ");
int tienGoc = Convert.ToInt32(Console.ReadLine());
if (tienGoc <= 0)
{
  Console.WriteLine("Tiền gốc không thể nhỏ hơn 0.");
  return;
}

Console.WriteLine("Nhập vào tỉ lệ (%) thuế VAT: ");
int tiLeThue = Convert.ToInt32(Console.ReadLine());
if (tiLeThue < 0)
{
  Console.WriteLine("Tỉ lệ phải lớn hơn 0%.");
  return;
}

int soTienThue = tienGoc / 100 * tiLeThue;
int tongTien = tienGoc + soTienThue;

Console.WriteLine($"Tiền gốc là: {tienGoc}000 vnđ, tỉ lệ thuế là: {tiLeThue}%, tiền thuế là: {soTienThue}000 vnđ, tổng tiền là: {tongTien}000 vnđ");
#endregion

#region Chuyển đổi tiền tệ USD => VNĐ
Console.WriteLine("Nhập vào USD: ");
int tienUSD = Convert.ToInt32(Console.ReadLine());
if (tienUSD <= 0)
{
  Console.WriteLine("USD không thể nhỏ hơn 0.");
  return;
}

Console.WriteLine("Nhập vào tỉ giá (%) chuyển đổi: ");
int tiGia = Convert.ToInt32(Console.ReadLine());
if (tiGia < 0)
{
  Console.WriteLine("Tỉ giá phải lớn hơn 0%.");
  return;
}

int tienTuongUng = tienUSD * tiGia;

Console.WriteLine($"Tiền tương ứng là: {tienTuongUng} vnđ");
#endregion