from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
class FrmLayang_Layang:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("700x400")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        # pasang Label
        Label(mainFrame, text='Diagonal_1:').grid(row=1, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Diagonal_2:').grid(row=2, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_a:').grid(row=3, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_b:').grid(row=4, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_c:').grid(row=5, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_d:').grid(row=6, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=8, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=9, column=0,sticky=W, padx=5, pady=5)
        # pasang textbox
        self.txtDiagonal_1 = Entry(mainFrame) 
        self.txtDiagonal_1.grid(row=1, column=1, padx=5, pady=5)
        self.txtDiagonal_2 = Entry(mainFrame) 
        self.txtDiagonal_2.grid(row=2, column=1, padx=5, pady=5)
        self.txtSisi_a = Entry(mainFrame) 
        self.txtSisi_a.grid(row=3, column=1, padx=5, pady=5)
        self.txtSisi_b = Entry(mainFrame) 
        self.txtSisi_b.grid(row=4, column=1, padx=5, pady=5)
        self.txtSisi_c = Entry(mainFrame) 
        self.txtSisi_c.grid(row=5, column=1, padx=5, pady=5)
        self.txtSisi_d = Entry(mainFrame) 
        self.txtSisi_d.grid(row=6, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame) 
        self.txtLuas.grid(row=8, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame) 
        self.txtKeliling.grid(row=9, column=1, padx=5, pady=5) 
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',command=self.onHitung)
        self.btnHitung.grid(row=7, column=1, padx=5, pady=5)
        # fungsi untuk menghitung luas dan keliling persegi panjang 
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur 
        diagonal1 = int(self.txtDiagonal_1.get())
        diagonal2 = int(self.txtDiagonal_2.get())
        sisi_a = int(self.txtSisi_a.get())
        sisi_b = int(self.txtSisi_b.get())
        sisi_c = int(self.txtSisi_c.get())
        sisi_d = int(self.txtSisi_d.get())

        luas = 1.5 * diagonal1 * diagonal2
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))

        
        kel = sisi_a + sisi_b + sisi_c + sisi_d
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))
    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()
if __name__ == '__main__':
    root = Tk() 
    aplikasi = FrmLayang_Layang(root, "Program Luas dan Keliling Layang-Layang")
    root.mainloop()
