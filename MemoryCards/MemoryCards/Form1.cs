using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCards
{
    public partial class FormMemCards : MetroFramework.Forms.MetroForm
    {
        static Random randNum = new Random();//генератор рандомных чисел

        int[] cards = new int[16];//Создаем массив, в котором будут храниться наши карты

        bool[] opened = new bool[16];//Создаем массив, который записывает, какие карточки уже открыты

        int done;//сколько уже открыто картинок

        int status = 0;//статус картинки: 0-закрыта, 1-открыта

        int card_a;//номер первой открытой картинки

        int card_b;//номер второй открытой картинки

        public FormMemCards()
        {
            InitializeComponent();
            init_game();
        }

        private void init_game() //инициализируем запуск игры
        {
            for (int i = 0; i < cards.Length; i++)//при инициализации игры из массива cards записываем номер картинки
            {
                cards[i] = i % (cards.Length / 2) + 1;//присваиваем массиву cards значения от 1 до 8, а еще раз от 1 до 8
            }
            for (int i = 0; i < 100; i++)//перемешиваем карты
            {
                shuffle_cards();
            }
            for (int i = 0; i < cards.Length; i++)
            {
                load_picture(i, 0);//создаем цикл, который загружает картинки в picturebox'ы
            }
            for (int i = 0; i < cards.Length; i++)
            {
                hide(i);//скрываем картинки после их загрузки
            }
            for (int i = 0; i < cards.Length; i++)
            {
                opened[i] = false;//записываем в картинки значение false после запуска игры, чтобы они были закрыты по умолчанию
            }
            done = 0;//по-дефолту открыто 0 картинок
            status = 0;//после запуска у всех картинок статус 0, то есть они закрыты

        }

        private void load_picture(int picture, int image) //функция для загрузки в указанный элемент указанной картинки. Передаем номер картинки от 0 до 15 и номер картинки, которую необходимо загрузить
        {
            //picturebox1.Image = Properties.Resuorces.resourceName
            //card1.Image = Properties.Resources._1;
            get_picture_box(picture).Image = get_image(image);//пока что не работает. Нужно разобраться
        }

        private PictureBox get_picture_box(int picture)//получаем номер pictureBox
        {
            switch (picture)
            {
                case 0: return card1;
                case 1: return card2;
                case 2: return card3;
                case 3: return card4;
                case 4: return card5;
                case 5: return card6;
                case 6: return card7;
                case 7: return card8;
                case 8: return card9;
                case 9: return card10;
                case 10: return card11;
                case 11: return card12;
                case 12: return card13;
                case 13: return card14;
                case 14: return card15;
                case 15: return card16;
            }
            return null; //если картинка не была выбрана, то ничего не возвращается
        }

        private Image get_image(int image) //функция для загрузки нужной картинки
        {
            switch (image)
            {
                case 0: return Properties.Resources._0;
                case 1: return Properties.Resources._1;
                case 2: return Properties.Resources._2;
                case 3: return Properties.Resources._3;
                case 4: return Properties.Resources._4;
                case 5: return Properties.Resources._5;
                case 6: return Properties.Resources._6;
                case 7: return Properties.Resources._7;
                case 8: return Properties.Resources._8;
            }
            return null;
        }

        private void shuffle_cards()//функция для перемешивания карт. Эта функция будет брать два случайных номера, генерируемых рандомно и менять их местами
        {
            int a = randNum.Next(0, cards.Length);
            int b = randNum.Next(0, cards.Length);
            if (a == b) return;//если а = б, то ничего не изменится
            int x = cards[a];//перемешиваем карты, используя еще одну переменную
            cards[a] = cards[b];
            cards[b] = x;
        }

        private void show(int picture_number)//передаем номер картинки, которую надо загружать
        {
            load_picture(picture_number, cards[picture_number]);//загружаем картинку из массива картинок
            get_picture_box(picture_number).Cursor = Cursors.Default;//меняем курсор на обычный
        }

        private void hide(int picture_number)//скрываем картинку
        {
            load_picture(picture_number, 0);//скрываем карточку, показывая нулевую картинку
            get_picture_box(picture_number).Cursor = Cursors.Hand;//меняем курсор на руку, чтобы было видно, что на картинку можно кликнуть
        }

        private void open(int picture_number)//функция, которая присваивает для указанной картинки, что она уже открыта
        {
            opened[picture_number] = true;//помечает галочкой картинку, что она уже открыта
            show(picture_number);//открывает картинку
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Do you really want to exit?",
                "Exit", MessageBoxButtons.YesNo);
            if (exitResult == DialogResult.No)
            {

            }
            if (exitResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game was created by Vladimir Krygin in purely educational purposes"
                , "About Us");
        }

        private void menuRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Rules are simple: 
   Turn over any two cards. 
   If the two cards match, keep them. If they don't match, turn them back over."
                , "Rules");
        }

        private void card11_MouseClick(object sender, MouseEventArgs e)
        {
            int number = int.Parse(((PictureBox)sender).Tag.ToString()); //Считает номер картинки, по которой был произведен клик с помощью названия объекта в панели элементов, сендера и тэга объекта. Тэг объекта задается в конструкторе форм (Свойство tag). Для того, чтобы сощдать событие для всех таких элементов (picturebox) были выделены все пикчербоксы, а потом выбрано событие mouse click
            //MessageBox.Show("Card number is: "+number.ToString()); Проверка, работает-ли счетчик
            if (opened[number]) return;//если картинка была уже открыта, то возвращаемся. Фикс бага с двойным кликом по одной и той же картинке
            switch (status)//по клику на картинку происходит проверка её статуса
            {
                case 0:
                    status_0(number);//при нулевом статусе картинки, не получаем её номера
                    break;
                case 1:
                    status_1(number);
                    break;
                case 2:
                    status_2(number);
                    break;
                case 3:
                    status_3(number);
                    break;
            }
        }

        private void status_0(int number)//открытие картинки и просвоение ей статуса
        {
            card_a = number;//показываем, какая была первая картинка
            show(card_a);//записываем в картинку её номер
            status = 1;//присваиваем статус 1, то есть картинка открыта
        }


        private void status_1(int number)//кликаем по второй картинке
        {
            card_b = number;//показываем, какая была вторая картинка
            if (card_a == card_b) return;//возвращаемся, если два раза была кликнута одна и та же картинка
            show(card_b);
            status = 2;//вторая картинка открыта, поэтому статус равен двум
            if (cards[card_a] == cards[card_b])//если картинки одинаковые, то оставляем карточки открытыми
            {
                open(card_a);
                open(card_b);
                done += 2;//увеличиваем на 2, так как две картинки открыты
                if (done == 16)//если количество открытых картинок равно 16(все картинки), то поздравляем с победой
                    MessageBox.Show("Gongratulations!", "You won!");
                else status = 0;//игра продолжается
            }
            else
            {
                status = 3;//если картинки не совпали, то вызываем статус 3
            }
        }

        private void status_2(int number)
        {

        }

        private void status_3(int number)//если карточки разные, то их скрываем и переходим к статусу 0
        {
            hide(cards[card_a]);
            hide(cards[card_b]);
            status_0(number);
        }
        private void menuNewGame_Click(object sender, EventArgs e)
        {
            init_game();
        }
    }
}
