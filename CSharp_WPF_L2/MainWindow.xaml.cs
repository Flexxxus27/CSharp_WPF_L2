﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharp_WPF_L2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    // Текстовый элементы управления: textBlock,TextBox,RichTextBox, PasswordBox
    //    TextBlock - предназначен для вывода текстовой информации. Свойсвто text позволяет задать текстовое содержимое элемента. Можно исп. св-ва для настройки шрифтов.
    //      Элемент TextBlock может содержать вложенные элементы Run, для разбиения текста на составляющие.
    //      Св-во LineHeight - позволяет указывать высоту строк.
    //      Св-во TextWrapping - позволяет переносить текст. Может принимать значения:
    //        Wrap - текст всегда разрывается на краю элемента управления, даже если придется переносить слишком длинные слова.
    //        WrapWithOverflow - позволяет некоторым строкам выйти за правый край, если не найдет подходящее место для разбиения строки
    //      Св-во TextAlignment выравнивает текст по центру(center),правому(right) или левому краю (left)
    //      Элемент LineBreak позволяет перенести текст на новую строку.
    //    Элемент TextBox - предназначен для вывода или ввода текстовой информации. Поддерживает все св-ва, доступные TextBlock.
    //      Св-ва MaxLength позволяют задать максимальное число вводимых символов.
    //      Св-во MinLines и MaxLines определяют минимальное и максимальное кол-во строк, которые должны отображаться в текстовом поле.
    //      Св-во AcceptReturn позволяет активировать переход на следующую строку при нажатии Enter.
    //      Св-во AcceptTab позволяет активировать возможность создания табуляции при помощи клавиши Tab.
    //      Св-во VerticalScrollBarVisibility и HorizontalScrollBarVisibility отображают вертикальную и горизонтальную полосы прокрутки.
    //      Св-во IsReadOnly позволяет заблокировать TextBox для редактирования, оставив только возможность чтения.
    //    Элемент PasswordBox - предназначен для ввода парольной информации, введенный текст скрывается при помощи маски(символов).
    //      Св-во PasswordChar устанавливает символ маски, отображаемый при вводе пароля.
    // Wpf Содержит множество элементов управления, работающих с коллекциями элементов.Самые простые: Listbox? ComboBox и более специализированые:DataGrid, ListView, TreeView, ToolBar.
    //    У всех списков есть два способа заполнения:
    //      -добавление элементов прямо в коллекцию items с помощью кода или XAML.
    //   Элемент ListBox предназначен для создания списков переменной длинны, в которой пользователь может выбирать элементы.
    //     Св-во SelectionMode позволяет активировать множественный выбор:
    //          - режим Multiply - можно выбрать любой элемент или отменить его выбор, щелкнув на нем.
    //          - режим Extended - необходимо зажать клавишу Ctrl и Shift, для выбора нескольких элементов.
    //          - режим Single допускает выделение только одного элемента.
    //   Элемент ComboBox предназначен для отображения коллекции элементов в виде выпадающего списка.
    //      В качестве элементов ComboBox также, как и ListBox поддерживает практически любые элементы WPF. Наиболее Эффективным является применение элемента ComboBoxItem.
    //          Св-во IsSelected позволяет выделить данный элемент как выбранный при запуске приложения.
    //          Св-во IsEnable позволяет установить данный элемент как недоступный для выбора.
    //
    //-------- Элементы выбора из диапазона-----\
    //
    //Данные элементы принимают числовое значение, которое находится в диапазоне между заданными минимальными и максимальными значениями.Данные элементы наследуются от класса RangeBase и имеют
    //общий св-ва:
    //  1. Value - текущее значение элемента.
    //  2. Maximum и Minimum - верхний и нижний предел допустимых значений.
    //  3.SmallChange и LargeChange - величина, на которую увеличивается или уменьшается значение Value при изменении.
    //      Элемент Slider - ползунок. Позволяет устанавливать числовое значение используя ползунок.
    //        Св-во Orientation - устанавливает ореинтацию элемента.
    //        Св-во IsSnapToTipPlacment - позволяет при перемещении ползунка активировать автоматическую привязку к ближайшей отметке.
    //      Элемент ProgressBar - индикатор прогресса. Отображает ход выполнения длительной задачи, является не интерактивным элементом. То есть пользователи не могут с ним взаимодействовать.
    //      Элемент Calendar - календарь.
    //      Св-во DisplayDateStart и DisplayDateEnd - задают начальную и конечную дату диапазона, который будет отображаться в календаре.
    //      Св-во IsTodayHighlighted - позволяет выделить текущую дату.
    //      Св-во DisplayMode - задает формат отображения дат. Может принимать значения:
    //          Month (Выбрано по умолчанию, отображает все дни текущего месяца)
    //          Decade (отображает все года текущего десятилетия)
    //          Year (отображает все месяцы текущего года)
    //      Св-во SelectionMode - определяет способ выделения дат, может принимать следующие значения:
    //          SingleDate(можно выбрать только 1 дату)
    //          None(нельзя выбрать дату) 
    //          SingleRange(по нажатию Ctrl выделяет несколько последовательных дат)
    //          MiltypleRange (по нажатию на Ctrl выделяет несколько не последовтельно идущих диапазонов дат)
    //     Элемент DatePicker - ввод даты.
    //      Св-во IsDropDownOpen - позволяет оставить календарь открытым после выбора даты.
    //      Св-во SelectedDateFormat - определяет формат даты:
    //          Short -дд.мм.гггг
    //          Long - с полным названием месяцев.
    //     Элемент ScrollViewer - прокрутка. Обеспечивает прокрутку содержимого. Можем вмещать в себя только один элемент, поэтому все элементы, помещаем внутрь ScrollViewer необходимо облачить в еще один контейнер.
    //          Св-во HorizontalScrollBarVisibility и VerticalScrollBarVisibility задают активность горизонтальной и вертикальной прокрутки.
    //          Св-во CanContentScroll - активирует прокрутку по элементам, то есть при прокрутке контент сдвигается не на несколько пикселей, а к началу следующего элемента.
    //     Элемент ViewBox - масштабирование. Может содержать один дочерний элемент и масштабирует его в зависимости от размеров окна.
    //          Св-во Stretch - позволяет указать, как в занимаемой области должен масштабироваться дочерний элемент.
    //     Элемент Image - изображение. Предназначен для работы с изображениями.
    //          Св-во Source - позволяет задать путь к изображению.
    //       Для начала работы с изображениями их нужно разместить внутри проекта и каждому изображению в св-вах настроить тип действия при сборке - ресурс.
    //     Элемент TabControl - вкладки. Позволяет разделить интерфейс на несколько разных зон, которые можно выбрать, нажав на заголовок, который обычно находится сверху элемента управления.
    //     Элемент ToolBar - панель инструментов. Представляет собой панель инструментов: набор команд, обычно расположенный непосредственно под строкой меню в стандартном приложении Windows.
    //     Элемент WPFToolBar обычно помещается внутри контейнера ToolBarTray. Этот контейнер позволяет перемещать элементы пользователю.
    //     Элемент Menu - меню приложения. Данный элемент служит для создания стандартных меню. Элемент Menu включает набор элементов MenuItem. Так эе допускается вкладыать в меню и другие элементы.
    //     Элемент ContextMenu - контекстное меню элемента. Класс ContextMenu служит для создания контекстных всплывающих меню, отображающихся после нажатия на правую кнопку мыши.
    //     

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}