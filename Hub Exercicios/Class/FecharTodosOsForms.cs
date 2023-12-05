using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_Exercicios.Class
{
    internal class ClassClose
    {
        public static void CloseAllForms()
        {
            var fecharform = Application.OpenForms.Cast<Form>().ToList();
            foreach (Form frm in fecharform)
            {
                frm.Close();
            }
        }
        public static void Backbtn(Form thisForm)
        {
            Form1 frm_1 = new Form1();
            frm_1.Show();
            thisForm.Close();
        }

        /*Application.OpenForms: Isso pega todos os formulários que estão 
                                     atualmente abertos na aplicação.
              Cast<Form>(): Isso converte os itens na lista para o tipo Form 
                            (pois OpenForms retorna uma coleção de Form).
              ToList(): converte a coleção resultante em uma lista.
              foreach: é usado para executar o código dentro dele para cada 
                       formulário na lista de formulários abertos 
              frm.Close(): Isso fecha cada formulário na lista.*/
    }
}
