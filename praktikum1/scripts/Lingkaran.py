from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
class FrmLingkaran:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("400x200")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        # pasang Label
        Label(mainFrame, text='Jari_Jari:').grid(row=1, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=3, column=0,sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=4, column=0,sticky=W, padx=5, pady=5)
        # pasang textbox
        self.txtJari_Jari = Entry(mainFrame) 
        self.txtJari_Jari.grid(row=1, column=1, padx=5, pady=5) 
        self.txtLuas = Entry(mainFrame) 
        self.txtLuas.grid(row=3, column=1, padx=5, pady=5) 
        self.txtKeliling = Entry(mainFrame) 
        self.txtKeliling.grid(row=4, column=1, padx=5, pady=5) 
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',command=self.onHitung)
        self.btnHitung.grid(row=2, column=1, padx=5, pady=5)
        # fungsi untuk menghitung luas dan keliling persegi panjang 
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur 
        jari_jari = int(self.txtJari_Jari.get())

        luas = 3.14 * jari_jari * jari_jari
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))

        kel = 2 * 3.14 * jari_jari
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))
    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()
if __name__ == '__main__':
    root = Tk() 
    aplikasi = FrmLingkaran(root, "Program Luas dan Keliling Lingkaran")
    root.mainloop()
