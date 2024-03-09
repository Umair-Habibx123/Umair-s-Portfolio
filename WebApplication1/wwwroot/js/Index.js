function DownloadPDF() {
    /*const path = "https://drive.google.com/file/d/1r5jrBe-iIq_P2b7HsbtFsgyjBgwgnTXq/view?usp=sharing";*/
    const path = "https://drive.usercontent.google.com/u/0/uc?id=1r5jrBe-iIq_P2b7HsbtFsgyjBgwgnTXq&export=download";
    const link = document.createElement('a');
    link.href = path;
    link.download = 'Umair_Habib Resume(CV).pdf';
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
