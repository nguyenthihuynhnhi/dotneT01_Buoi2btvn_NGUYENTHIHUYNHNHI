#region Tính số ngày trong tuần và số lẻ
// Console.WriteLine("Nhập số ngày:");
// int soNgay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Số ngày vừa nhập là: {soNgay}");

// int soTuan = soNgay / 7;
// int ngayDu = soNgay % 7;

// Console.WriteLine($"Số Tuần : {soTuan}, Số ngày dư là: {ngayDu}");
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