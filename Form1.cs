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
                    calAlice[i] = Convert.ToInt32(Interaction.InputBox("Escribe la puntuación de Alice"));
                    calBob[i] = Convert.ToInt32(Interaction.InputBox("Escribe la puntuación de Bob")); ;
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
            //palabra= "Érase una vez una niñita que lucía una hermosa capa de color rojo.Como la niña la usaba muy a menudo, todos la llamaban Caperucita Roja. Un día, la mamá de Caperucita Roja la llamó y le dijo: —Abuelita no se siente muy bien, he horneado unas galletitas y quiero que tú se las lleves. —Claro que sí—respondió Caperucita Roja, poniéndose su capa y llenando su canasta de galletas recién horneadas.Antes de salir, su mamá le dijo: — Escúchame muy bien, quédate en el camino y nunca hables con extraños. —Yo sé mamá —respondió Caperucita Roja y salió inmediatamente hacia la casa de la abuelita.";            
           
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
                listPa.Items.Add(string.Format("'{0}' está repetido {1} veces", grouping.Key, grouping.Count()));
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