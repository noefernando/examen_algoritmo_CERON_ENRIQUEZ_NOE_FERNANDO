using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace examen_algoritmo_CERON_ENRIQUEZ_NOE_FERNANDO
{
    public partial class Palabras : Form
    {
        public Palabras()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {                                    
                int[] calAlice = new int[3];
                int[] calBob = new int[3];
                int i = 0;

                do
                {
                    calAlice[i] = Convert.ToInt32(Interaction.InputBox("Escribe la puntuaci�n de Alice"));
                    calBob[i] = Convert.ToInt32(Interaction.InputBox("Escribe la puntuaci�n de Bob")); ;
                //agrega puntos a la lista
                    PuntosActuales.Items.Add((i+1) +".-Alice:"+calAlice[i]);
                    PuntosActuales.Items.Add((i+1) +".-Bob:"+calBob[i]);
                    i++;
                }
                while (i<3);

            int puntosAlice = 0;
            int puntosBob = 0;
            for (i = 0; i < calAlice.Length; i++)
            {
                if(calAlice[i] < calBob[i])
                {
                    puntosBob++;
                }
                if(calAlice[i] > calBob[i])
                {
                    puntosAlice++;
                }                
            }
            PuntosActuales.Items.Add("Bob: " + puntosBob + " VS Alice:" + puntosAlice);
            puntosBob = 0;
            puntosAlice = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String palabra;
            int conteo;

            palabra = Frase.Text;
            //palabra= "�rase una vez una ni�ita que luc�a una hermosa capa de color rojo.Como la ni�a la usaba muy a menudo, todos la llamaban Caperucita Roja. Un d�a, la mam� de Caperucita Roja la llam� y le dijo: �Abuelita no se siente muy bien, he horneado unas galletitas y quiero que t� se las lleves. �Claro que s�respondi� Caperucita Roja, poni�ndose su capa y llenando su canasta de galletas reci�n horneadas.Antes de salir, su mam� le dijo: � Esc�chame muy bien, qu�date en el camino y nunca hables con extra�os. �Yo s� mam� �respondi� Caperucita Roja y sali� inmediatamente hacia la casa de la abuelita.";            
           
            //Longitud de la frase a ingresar
            conteo = palabra.Length;

            //Iteradores para conteo
            
            int i = 0, c = 1;

            while(i< conteo)
            {
                if (palabra[i] == ' ')
                {
                    c=c+1;
                }
                i= i+1;
            }
            
            //Convertir frase a array
            
            String[] repetidas = palabra.Split(' ').ToArray();
            foreach(var grouping in repetidas.GroupBy(t => t).Where(t => t.Count() != 1))
            {
                //Agregar repetidos a la lista
                listPa.Items.Add(string.Format("'{0}' est� repetido {1} veces", grouping.Key, grouping.Count()));
            }
                //Agregar conteo a la lista
                listPa.Items.Add("Caracteres: " + conteo +" Total de: "+c+" frases");            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}