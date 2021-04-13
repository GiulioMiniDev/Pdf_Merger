import javax.swing.*;
import javax.swing.filechooser.FileNameExtensionFilter;
import java.awt.datatransfer.DataFlavor;
import java.awt.dnd.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import org.pdfbox.exceptions.COSVisitorException;
import org.pdfbox.pdmodel.PDDocument;
import org.pdfbox.util.PDFMergerUtility;



public class Merger extends JDialog {
    private JPanel contentPane;
    private JButton button1;
    private JButton button2;
    private JPanel GUII;
    private JTextArea selected_pdfs;

    public Merger() {
        setContentPane(contentPane);
        setModal(true);



        selected_pdfs.setDropTarget(new DropTarget(){
            @Override
            public void dragEnter(DropTargetDragEvent dtde) { }

            @Override
            public void dragOver(DropTargetDragEvent dtde) { }

            @Override
            public void dropActionChanged(DropTargetDragEvent dtde) { }

            @Override
            public void dragExit(DropTargetEvent dte) { }

            @Override
            public void drop(DropTargetDropEvent e) {
                try
                {
                    e.acceptDrop(DnDConstants.ACTION_COPY_OR_MOVE);
                    java.util.List list=(java.util.List) e.getTransferable().getTransferData(DataFlavor.javaFileListFlavor);

                    File f = (File)list.get(0);

                    System.out.println(f.getPath());
                    selected_pdfs.append(f.getPath() + '\n');


                } catch(Exception ex){}
            }
        });

        button1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    MergePdf();
                } catch (IOException ioException) {
                    ioException.printStackTrace();
                } catch (COSVisitorException cosVisitorException) {
                    cosVisitorException.printStackTrace();
                }
            }
        });
        button2.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                AddPdf();
            }
        });
    }

    private void MergePdf() throws IOException, COSVisitorException {
        List<PDDocument> documents = new ArrayList<PDDocument>();
        List<File> files = new ArrayList<File>();


        PDFMergerUtility PDFmerger = new PDFMergerUtility();


        PDFmerger.setDestinationFileName(SavePdf());

        for (String x: selected_pdfs.getText().split("\\n"))
        {
            File f = new File(x);
            files.add(f);
            documents.add(PDDocument.load(f));
            PDFmerger.addSource(f);
        }

        PDFmerger.mergeDocuments();


        for (PDDocument d : documents)
        {
           d.close();
        }
    }
    private void AddPdf()
    {
        JFileChooser chooser = new JFileChooser();
        chooser.setFileFilter(new FileNameExtensionFilter("PDF: ", "pdf"));
        int result = chooser.showOpenDialog(this);
        if (result == JFileChooser.APPROVE_OPTION)
        {
            selected_pdfs.append(chooser.getSelectedFile().getPath() + '\n');
        }

    }
    private String SavePdf()
    {
        JFileChooser chooser = new JFileChooser();
        chooser.setFileFilter(new FileNameExtensionFilter("PDf: ", "pdf"));
        int result = chooser.showSaveDialog(this);
        if (result == JFileChooser.APPROVE_OPTION)
        {
            return chooser.getSelectedFile().getPath() + ".pdf";
        }
        return "";
    }
    public static void main(String[] args) {
        Merger dialog = new Merger();
        dialog.pack();
        dialog.setVisible(true);
        System.exit(0);
    }
}
