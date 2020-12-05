using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagerSevice;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace FinalProject
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
            LoadBill();
        }

        private void dtgBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDonService hoaDonService = new HoaDonService();
            int index = e.RowIndex;
            if (index < 0 || index >= dtgBill.RowCount)
            {
                return;
            }

            DataGridViewRow row = dtgBill.Rows[index];
            int id_bill = Convert.ToInt32(row.Cells[0].Value);
            DateTime checkin = Convert.ToDateTime(row.Cells[1].Value);
            String table = Convert.ToString(row.Cells[3].Value);
            

            tbIDBill.Text = id_bill.ToString();
            dtCheckIN.Value = checkin;
            tbTable.Text = table;

            getBillInfoByID(id_bill);

            tbSum.Text = hoaDonService.getSumPrice(id_bill).ToString();
        }

        private void dtgBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dtgBillInfo.RowCount)
            {
                return;
            }

            DataGridViewRow row = dtgBillInfo.Rows[index];
            int id_bill = Convert.ToInt32(row.Cells[0].Value);

            String nameNV = Convert.ToString(row.Cells[3].Value);
            String nameKH = Convert.ToString(row.Cells[2].Value);

            tbNameNV.Text = nameNV;
            tbNameKH.Text = nameKH;
        }

        private void getBillInfoByID(int id_bill)
        {
            HoaDonService hoaDonService = new HoaDonService();
            dtgBillInfo.DataSource = hoaDonService.getBillInfoByid(id_bill);
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            HoaDonService hoaDonService = new HoaDonService();
            TableService tableService = new TableService();

            int id_bill = Int32.Parse(tbIDBill.Text);
            DateTime checkin = dtCheckIN.Value;
            DateTime checkout = dtCheckOUT.Value;
            int id_table = Int32.Parse(tbTable.Text);


            Bill bill = new Bill { id_bill = id_bill, Datecheckin = checkin, Datecheckout = checkout, id_table = id_table, status = 1 };
            TalbleFood talble = new TalbleFood { id_table = id_table, status = false };
            hoaDonService.updateBill(bill);
            tableService.updateStatus(talble);

            LoadBill();
            dtgBillInfo.DataSource = null;

        }


        private void LoadBill()
        {
            HoaDonService hoaDonService = new HoaDonService();
            dtgBill.DataSource = hoaDonService.getBillStatus(0);
        }

        private void getBillByTable(int id_table)
        {
            HoaDonService hoaDonService = new HoaDonService();
            dtgBill.DataSource =  hoaDonService.GetBillsByTable(id_table);
        }

        private void tbSerachTable_TextChanged(object sender, EventArgs e)
        {
            if(tbSerachTable.Text == "")
            {
                LoadBill();
            }
            else
            {
                getBillByTable(Int32.Parse(tbSerachTable.Text));
            }
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            iTextSharp.text.Font fontHeader = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

            Document document = new Document(); // Create new object file

            PdfPTable infoTable = new PdfPTable(dtgBillInfo.Columns.Count-2); //Create table to add info

            for (int j = 0; j < dtgBillInfo.Columns.Count-2; j++) //Add header
            {
                infoTable.AddCell(new Phrase(dtgBillInfo.Columns[j].HeaderText));
            }

            infoTable.HeaderRows = 1;

            for (int i = 0; i < dtgBillInfo.Rows.Count; i++) // Add the actual rows 
            {
                for (int k = 0; k < dtgBillInfo.Columns.Count-2; k++)
                {
                    if (dtgBillInfo[k, i].Value != null)
                    {
                        infoTable.AddCell(dtgBillInfo[k, i].Value.ToString());
                    }
                }
            }

            PdfWriter.GetInstance(document, new FileStream("Bill/"+tbIDBill.Text+".pdf", FileMode.Create));
            
            document.Open();
            Paragraph nameRes = new Paragraph("Restaurant Managerment",fontHeader);
            document.Add(nameRes);//Add name Restaurant
            
            Paragraph idbill = new Paragraph("Bill so: "+tbIDBill.Text);
            document.Add(idbill);// Add id bill to PrintBill
            
            Paragraph clientName = new Paragraph("Ten khach hang: "+tbNameKH.Text);
            document.Add(clientName);//Add Client name to PrintBill
            
            Paragraph invoicedate = new Paragraph("Ngay tao: "+ dtCheckIN.Text);
            document.Add(invoicedate);//Add Invoice date to PrintBill
            
            Paragraph tbnumber = new Paragraph("Ban so: "+tbTable.Text);
            document.Add(tbnumber);//Add table number to PrintBill
            
            Paragraph staffname = new Paragraph("Ten nhan vien thanh toan: "+tbNameNV.Text);
            document.Add(staffname);//Add Staff to PrintBill

            Paragraph br = new Paragraph("\n");
            document.Add(br);
            document.Add(infoTable);//Add info buy from table data
            
            Paragraph sum = new Paragraph("Tong tien: "+tbSum.Text);
            document.Add(sum);//Add total price

            Paragraph thankyou = new Paragraph("Cam on quy khach");
            document.Add(thankyou);
            document.Close();

            MessageBox.Show("In hóa đơn thành công");
        }

        
    }
}
