from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
class FrmBelah_Ketupat:
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
        Label(mainFrame, text='Sisi_1:').grid(row=3, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_2:').grid(row=4, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_3:').grid(row=5, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi_4:').grid(row=6, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=8, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=9, column=0,sticky=W, padx=5, pady=5)
        # pasang textbox
        self.txtDiagonal_1 = Entry(mainFrame) 
        self.txtDiagonal_1.grid(row=1, column=1, padx=5, pady=5)
        self.txtDiagonal_2 = Entry(mainFrame) 
        self.txtDiagonal_2.grid(row=2, column=1, padx=5, pady=5)
        self.txtSisi_1 = Entry(mainFrame) 
        self.txtSisi_1.grid(row=3, column=1, padx=5, pady=5)
        self.txtSisi_2 = Entry(mainFrame) 
        self.txtSisi_2.grid(row=4, column=1, padx=5, pady=5)
        self.txtSisi_3 = Entry(mainFrame) 
        self.txtSisi_3.grid(row=5, column=1, padx=5, pady=5)
        self.txtSisi_4 = Entry(mainFrame) 
        self.txtSisi_4.grid(row=6, column=1, padx=5, pady=5)
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
        sisi_1 = int(self.txtSisi_1.get())
        sisi_2 = int(self.txtSisi_2.get())
        sisi_3 = int(self.txtSisi_3.get())
        sisi_4 = int(self.txtSisi_4.get())

        luas = 1.5 * diagonal1 * diagonal2
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))

        
        kel = sisi_1 + sisi_2 + sisi_3 + sisi_4
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))
    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()
if __name__ == '__main__':
    root = Tk() 
    aplikasi = FrmBelah_Ketupat(root, "Program Luas dan Keliling Belah Ketupat")
    root.mainloop()
