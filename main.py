import PyPDF2
from tkinter import filedialog
from tkinter import *


# Windows for file selection
class ChoosenFile:
    def __init__(self):
        while True:
            root1 = Tk()
            root1.withdraw()
            self.file_path = filedialog.askopenfilename()
            if 'pdf' in self.file_path:
                break

    # Print the name of the selected file
    def GetNameFile(self):
        print(self.file_path)


writer = PyPDF2.PdfFileWriter()

# Main window
root = Tk()
root.resizable(False, False)
canvas = Canvas(root, width=300, height=300)
canvas.grid(columnspan=3)
canvas.pack()


# Widgets functions
def AddPdf():
    file = ChoosenFile()
    pdfInput = PyPDF2.PdfFileReader(open(file.file_path, "rb"))
    for x in range(pdfInput.getNumPages()):
        writer.addPage(pdfInput.getPage(x))
    print(file.file_path)


def Saving():
    pdfOutput = filedialog.asksaveasfile(mode='wb', defaultextension='pdf')
    writer.write(pdfOutput)


# Widgets
request = Button(root, text='Add pdf', command=AddPdf, width=20, height=5, bg='misty rose')
request.pack(side=RIGHT, padx=10, pady=10)

save = Button(root, text='Fusion!', command=Saving, width=20, height=5, bg='light blue')
save.pack(side=LEFT, padx=10, pady=10)

minideveloper = Label(root, text='G.P.')
minideveloper.pack(side=TOP, padx=10, pady=10)

root.mainloop()
