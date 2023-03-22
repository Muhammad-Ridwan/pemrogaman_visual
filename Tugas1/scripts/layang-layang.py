from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W
class FrmLayang:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("500x500")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.Keluar)
        self.aturKomponen()
    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
 # pasang Label
        Label(mainFrame, text='Diagonal 1 :').grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Diagonal 2 :').grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_a:').grid(row=2, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_b:').grid(row=3, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_c:').grid(row=4, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_d:').grid(row=5, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=7, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=8, column=0, sticky=W, padx=5, pady=5)

 # pasang textbox
        self.txtdiagonal1 = Entry(mainFrame)
        self.txtdiagonal1.grid(row=0, column=1, padx=5, pady=5)
        self.txtdiagonal2 = Entry(mainFrame)
        self.txtdiagonal2.grid(row=1, column=1, padx=5, pady=5)
        self.txtSisi_a = Entry(mainFrame) 
        self.txtSisi_a.grid(row=2, column=1, padx=5, pady=5)
        self.txtSisi_b = Entry(mainFrame) 
        self.txtSisi_b.grid(row=3, column=1, padx=5, pady=5)
        self.txtSisi_c = Entry(mainFrame) 
        self.txtSisi_c.grid(row=4, column=1, padx=5, pady=5)
        self.txtSisi_d = Entry(mainFrame) 
        self.txtSisi_d.grid(row=5, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=7, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=8, column=1, padx=5, pady=5)
 # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.Hitung)
        self.btnHitung.grid(row=6, column=1, padx=5, pady=5)
 # fungsi untuk menghitung luas dan keliling layang-layang
    def Hitung(self, event=None):
 # perhitungan dengan metode Pemrograman Terstruktur
        d1 = int(self.txtdiagonal1.get())
        d2 = int(self.txtdiagonal2.get())
        sisi_a = int(self.txtSisi_a.get())
        sisi_b = int(self.txtSisi_b.get())
        sisi_c = int(self.txtSisi_c.get())
        sisi_d = int(self.txtSisi_d.get())
        luas = 1.5 * d1 * d2
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        kel = sisi_a + sisi_b + sisi_c + sisi_d
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))
    def Keluar(self, event=None):
 # memberikan perintah menutup aplikasi
        self.parent.destroy()
class layang():
 # perhitungan dengan metode Pemrograman OOP
    def __init__(self, d1, d2, sisi_a, sisi_b, sisi_c, sisi_d):
        self.d1 = d1
        self.d2 = d2
        self.Sisi_a = sisi_a
        self.Sisi_b = sisi_b
        self.Sisi_c = sisi_c
        self.Sisi_d = sisi_d
    def luas(self):
        return 1.5 * (self.d1 * self.d2)
    def keliling(self):
        return (self.Sisi_a + self.Sisi_b + self.Sisi_c + self.Sisi_d)
if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmLayang(root, "OOP! Program Menghitung Luas dan Keliling Layang Layang")
    root.mainloop()