using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLbonho
{
    public partial class ThreandAndProcess : Form
    {
        public ThreandAndProcess()
        {
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
        }

        const uint GMEM_MOVEABLE = 0x0002;

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GlobalAlloc(uint uFlags, UIntPtr dwBytes);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GlobalFree(IntPtr hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GlobalLock(IntPtr hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalUnlock(IntPtr hMem);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);


        [DllImport("psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessMemoryInfo(IntPtr hProcess, ref PROCESS_MEMORY_COUNTERS counters, uint size);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);

        // Structure for process memory counters
        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_MEMORY_COUNTERS
        {
            public uint cb;
            public uint PageFaultCount;
            public UIntPtr PeakWorkingSetSize;
            public UIntPtr WorkingSetSize;
            public UIntPtr QuotaPeakPagedPoolUsage;
            public UIntPtr QuotaPagedPoolUsage;
            public UIntPtr QuotaPeakNonPagedPoolUsage;
            public UIntPtr QuotaNonPagedPoolUsage;
            public UIntPtr PagefileUsage;
            public UIntPtr PeakPagefileUsage;
        }

        [Flags]
        public enum ProcessAccessFlags : uint
        {
            QueryInformation = 0x0400
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        //Lay thong tin bo nho
        private void button1_Click(object sender, EventArgs e)
        {
            MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
            memStatus.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));

            if (GlobalMemoryStatusEx(ref memStatus))
            {
                tongBN.Text = FormatBytes(memStatus.ullTotalPhys);
                BNkhadung.Text = FormatBytes(memStatus.ullAvailPhys);
                BNao.Text = FormatBytes(memStatus.ullAvailVirtual);
                BNaokhadung.Text = FormatBytes(memStatus.ullAvailVirtual);
            }
            else
            {
                MessageBox.Show("Không thể truy xuất thông tin bộ nhớ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cap phat vung nho Global
        private void button2_Click(object sender, EventArgs e)
        {
            const int bufferSize = 256;  // Kích thước của bộ nhớ cần cấp phát

            // Sử dụng hàm API GlobalAlloc để cấp phát bộ nhớ
            IntPtr globalAllocHandle = GlobalAlloc(GMEM_MOVEABLE, (UIntPtr)bufferSize);


            if (globalAllocHandle != IntPtr.Zero)
            {
                try
                {
                    // Chuyển con trỏ của bộ nhớ cấp phát thành con trỏ có thể sử dụng trong .NET
                    IntPtr globalLockPtr = GlobalLock(globalAllocHandle);

                    if (globalLockPtr != IntPtr.Zero)
                    {
                        try
                        {
                            // Sao chép chuỗi vào bộ nhớ cấp phát
                            string textToCopy = "Hello, GlobalAlloc!";
                            byte[] textBytes = Encoding.UTF8.GetBytes(textToCopy);
                            Marshal.Copy(textBytes, 0, globalLockPtr, Math.Min(bufferSize, textBytes.Length));

                            MessageBox.Show("Bộ nhớ đã được cấp phát và chuỗi đã được sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        finally
                        {
                            // Giải phóng con trỏ
                            GlobalUnlock(globalAllocHandle);
                        }
                    }
                }
                finally
                {
                    // Giải phóng bộ nhớ
                    GlobalFree(globalAllocHandle);
                }
            }
            else
            {
                MessageBox.Show("Không thể cấp phát bộ nhớ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Xem dung luong bo nho duoc phan bo cho cac tien trinh
        private void button3_Click(object sender, EventArgs e)
        {
            Process[] processes;
            processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                PROCESS_MEMORY_COUNTERS memoryCounters = GetMemoryInfo(process);
                dataGridView1.Rows.Add(process.Id, process.ProcessName, FormatBytes(memoryCounters.WorkingSetSize.ToUInt64()));
            }
        }

        private PROCESS_MEMORY_COUNTERS GetMemoryInfo(Process process)
        {
            IntPtr processHandle = IntPtr.Zero;

            try
            {
                processHandle = process.Handle;

                PROCESS_MEMORY_COUNTERS memoryCounters = new PROCESS_MEMORY_COUNTERS();
                memoryCounters.cb = (uint)Marshal.SizeOf(typeof(PROCESS_MEMORY_COUNTERS));

                if (GetProcessMemoryInfo(processHandle, ref memoryCounters, memoryCounters.cb))
                {
                    return memoryCounters;
                }
                else
                {
                    MessageBox.Show($"Không thể truy xuất thông tin bộ nhớ cho quá trình {process.ProcessName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new PROCESS_MEMORY_COUNTERS(); // Return an empty structure in case of failure
                }
            }
            finally
            {
                if (processHandle != IntPtr.Zero)
                {
                    CloseHandle(processHandle);
                }
            }
        }

        private string FormatBytes(ulong bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;

            while (bytes >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                bytes /= 1024;
                suffixIndex++;
            }

            return $"{bytes} {suffixes[suffixIndex]}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Lấy số lần thu gom rác cho từng thế hệ
            int gen0Count = GC.CollectionCount(0); // Số lần thu gom rác ở thế hệ 0
            int gen1Count = GC.CollectionCount(1); // Số lần thu gom rác ở thế hệ 1
            int gen2Count = GC.CollectionCount(2); // Số lần thu gom rác ở thế hệ 2

            Rac.Text = gen0Count.ToString();
            Rac1.Text = gen1Count.ToString();
            Rac2.Text = gen2Count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để chọn tập tin nguồn
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tập tin nguồn";
            openFileDialog.Filter = "Tất cả các tệp|*.*";
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;

                // Hiển thị hộp thoại để chọn thư mục đích
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Chọn thư mục đích";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFolderPath = folderBrowserDialog.SelectedPath;

                    try
                    {
                        // Thực hiện sao chép tập tin
                        string fileName = Path.GetFileName(sourceFilePath);
                        string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

                        File.Copy(sourceFilePath, destinationFilePath, true); // Tham số thứ ba là để ghi đè nếu tập tin đích đã tồn tại

                        MessageBox.Show("Sao chép tập tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
