from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
class FrmTrapesium:
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
        Label(mainFrame, text='Alas_a:').grid(row=1, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Alas_b:').grid(row=2, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Alas_c:').grid(row=3, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Alas_d:').grid(row=4, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi:").grid(row=5, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=7, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=8, column=0,sticky=W, padx=5, pady=5)
        # pasang textbox
        self.txtAlas_a = Entry(mainFrame) 
        self.txtAlas_a.grid(row=1, column=1, padx=5, pady=5)
        self.txtAlas_b = Entry(mainFrame) 
        self.txtAlas_b.grid(row=2, column=1, padx=5, pady=5)
        self.txtAlas_c = Entry(mainFrame) 
        self.txtAlas_c.grid(row=3, column=1, padx=5, pady=5)
        self.txtAlas_d = Entry(mainFrame) 
        self.txtAlas_d.grid(row=4, column=1, padx=5, pady=5)
        self.txtTinggi = Entry(mainFrame) 
        self.txtTinggi.grid(row=5, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame) 
        self.txtLuas.grid(row=7, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame) 
        self.txtKeliling.grid(row=8, column=1, padx=5, pady=5) 
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',command=self.onHitung)
        self.btnHitung.grid(row=6, column=1, padx=5, pady=5)
        # fungsi untuk menghitung luas dan keliling persegi panjang 
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur 
        alas_a = int(self.txtAlas_a.get())
        alas_b = int(self.txtAlas_b.get())
        alas_c = int(self.txtAlas_c.get())
        alas_d = int(self.txtAlas_d.get())
        tinggi = int(self.txtTinggi.get())

        luas = 1.5 * (alas_a + alas_b) * tinggi
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))

        
        kel = alas_a + alas_b + alas_c + alas_d
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))
    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()
if __name__ == '__main__':
    root = Tk() 
    aplikasi = FrmTrapesium(root, "Program Luas dan Keliling Trapesium")
    root.mainloop()
