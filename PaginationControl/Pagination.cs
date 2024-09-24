using System.Windows;
using System.Windows.Controls;

namespace PaginationControl
{
    [TemplatePart(Name = "PART_PreviousPageButton", Type = typeof(Button))]
    [TemplatePart(Name = "PART_NextPageButton", Type = typeof(Button))]
    [TemplatePart(Name = "PART_PageButton1", Type = typeof(Button))]
    [TemplatePart(Name = "PART_PageButton2", Type = typeof(Button))]
    [TemplatePart(Name = "PART_PageButton3", Type = typeof(Button))]
    [TemplatePart(Name = "PART_PageButton4", Type = typeof(Button))]
    [TemplatePart(Name = "PART_PageButton5", Type = typeof(Button))]
    public class Pagination : Control
    {
        static Pagination()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Pagination), new FrameworkPropertyMetadata(typeof(Pagination)));
        }
        public int Pages
        {
            get { return (int)GetValue(PagesProperty); }
            set { SetValue(PagesProperty, value); }
        }
        public static readonly DependencyProperty PagesProperty =
            DependencyProperty.Register("Pages", typeof(int), 
                typeof(Pagination), new PropertyMetadata(0,OnPagesChanged));
        private static void OnPagesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is Pagination control)
            {
                control.CreatePagination(control.Pages, control.CurrentPage);
            }
        }
        public int CurrentPage
        {
            get { return (int)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register("CurrentPage", 
                typeof(int), typeof(Pagination), new PropertyMetadata(0,OnCurrentPageChanged));
        private static void OnCurrentPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is Pagination control)
            {
                control.CreatePagination(control.Pages, control.CurrentPage);
            }
        }
        public bool IsSecondPaginationVisible
        {
            get { return (bool)GetValue(IsSecondPaginationVisibleProperty); }
            set { SetValue(IsSecondPaginationVisibleProperty, value); }
        }
        public static readonly DependencyProperty IsSecondPaginationVisibleProperty =
            DependencyProperty.Register("IsSecondPaginationVisible", 
                typeof(bool), typeof(Pagination), new PropertyMetadata(false));
        public bool IsFirstPaginationVisible
        {
            get { return (bool)GetValue(IsFirstPaginationVisibleProperty); }
            set { SetValue(IsFirstPaginationVisibleProperty, value); }
        }
        public static readonly DependencyProperty IsFirstPaginationVisibleProperty =
            DependencyProperty.Register("IsFirstPaginationVisible", 
                typeof(bool), typeof(Pagination), new PropertyMetadata(false));
        public bool IsNextPageBtnVisible
        {
            get { return (bool)GetValue(IsNextPageBtnVisibleProperty); }
            set { SetValue(IsNextPageBtnVisibleProperty, value); }
        }
        public static readonly DependencyProperty IsNextPageBtnVisibleProperty =
            DependencyProperty.Register("IsNextPageBtnVisible",
                typeof(bool), typeof(Pagination), new PropertyMetadata(false));
        public bool IsPreviousPageBtnVisible
        {
            get { return (bool)GetValue(IsPreviousPageBtnVisibleProperty); }
            set { SetValue(IsPreviousPageBtnVisibleProperty, value); }
        }
        public static readonly DependencyProperty IsPreviousPageBtnVisibleProperty =
            DependencyProperty.Register("IsPreviousPageBtnVisible", 
                typeof(bool), typeof(Pagination), new PropertyMetadata(false));
        public int PageBtn1
        {
            get { return (int)GetValue(PageBtn1Property); }
            set { SetValue(PageBtn1Property, value); }
        }
        public static readonly DependencyProperty PageBtn1Property =
            DependencyProperty.Register("PageBtn1", 
                typeof(int), typeof(Pagination), new PropertyMetadata(1));
        public int PageBtn2
        {
            get { return (int)GetValue(PageBtn2Property); }
            set { SetValue(PageBtn2Property, value); }
        }
        public static readonly DependencyProperty PageBtn2Property =
            DependencyProperty.Register("PageBtn2", 
                typeof(int), typeof(Pagination), new PropertyMetadata(2));
        public int PageBtn3
        {
            get { return (int)GetValue(PageBtn3Property); }
            set { SetValue(PageBtn3Property, value); }
        }
        public static readonly DependencyProperty PageBtn3Property =
            DependencyProperty.Register("PageBtn3", 
                typeof(int), typeof(Pagination), new PropertyMetadata(3));
        public int PageBtn4
        {
            get { return (int)GetValue(PageBtn4Property); }
            set { SetValue(PageBtn4Property, value); }
        }
        public static readonly DependencyProperty PageBtn4Property =
            DependencyProperty.Register("PageBtn4", 
                typeof(int), typeof(Pagination), new PropertyMetadata(4));
        public int PageBtn5
        {
            get { return (int)GetValue(PageBtn5Property); }
            set { SetValue(PageBtn5Property, value); }
        }
        public static readonly DependencyProperty PageBtn5Property =
            DependencyProperty.Register("PageBtn5", 
                typeof(int), typeof(Pagination), new PropertyMetadata(5));
        public string PageBtnStyle1
        {
            get { return (string)GetValue(PageBtnStyle1Property); }
            set { SetValue(PageBtnStyle1Property, value); }
        }
        public static readonly DependencyProperty PageBtnStyle1Property =
            DependencyProperty.Register("PageBtnStyle1", 
                typeof(string), typeof(Pagination), new PropertyMetadata("pagingButton"));
        public string PageBtnStyle2
        {
            get { return (string)GetValue(PageBtnStyle2Property); }
            set { SetValue(PageBtnStyle2Property, value); }
        }
        public static readonly DependencyProperty PageBtnStyle2Property =
            DependencyProperty.Register("PageBtnStyle2",
                typeof(string), typeof(Pagination), new PropertyMetadata("pagingButton"));
        public string PageBtnStyle3
        {
            get { return (string)GetValue(PageBtnStyle3Property); }
            set { SetValue(PageBtnStyle3Property, value); }
        }
        public static readonly DependencyProperty PageBtnStyle3Property =
            DependencyProperty.Register("PageBtnStyle3",
                typeof(string), typeof(Pagination), new PropertyMetadata("pagingButton"));
        public string PageBtnStyle4
        {
            get { return (string)GetValue(PageBtnStyle4Property); }
            set { SetValue(PageBtnStyle4Property, value); }
        }
        public static readonly DependencyProperty PageBtnStyle4Property =
            DependencyProperty.Register("PageBtnStyle4",
                typeof(string), typeof(Pagination), new PropertyMetadata("pagingButton"));
        public string PageBtnStyle5
        {
            get { return (string)GetValue(PageBtnStyle5Property); }
            set { SetValue(PageBtnStyle5Property, value); }
        }
        public static readonly DependencyProperty PageBtnStyle5Property =
            DependencyProperty.Register("PageBtnStyle5",
                typeof(string), typeof(Pagination), new PropertyMetadata("pagingButton"));
        public bool IsPageBtnVisible1
        {
            get { return (bool)GetValue(IsPageBtnVisible1Property); }
            set { SetValue(IsPageBtnVisible1Property, value); }
        }
        public static readonly DependencyProperty IsPageBtnVisible1Property =
            DependencyProperty.Register("IsPageBtnVisible1", 
                typeof(bool), typeof(Pagination), new PropertyMetadata(false));
        public bool IsPageBtnVisible2
        {
            get { return (bool)GetValue(IsPageBtnVisible2Property); }
            set { SetValue(IsPageBtnVisible2Property, value); }
        }
        public static readonly DependencyProperty IsPageBtnVisible2Property =
            DependencyProperty.Register("IsPageBtnVisible2",
                typeof(bool), typeof(Pagination), new PropertyMetadata(false));
        public bool IsPageBtnVisible3
        {
            get { return (bool)GetValue(IsPageBtnVisible3Property); }
            set { SetValue(IsPageBtnVisible3Property, value); }
        }
        public static readonly DependencyProperty IsPageBtnVisible3Property =
            DependencyProperty.Register("IsPageBtnVisible3",
                typeof(bool), typeof(Pagination), new PropertyMetadata(false));
        public bool IsPageBtnVisible4
        {
            get { return (bool)GetValue(IsPageBtnVisible4Property); }
            set { SetValue(IsPageBtnVisible4Property, value); }
        }
        public static readonly DependencyProperty IsPageBtnVisible4Property =
            DependencyProperty.Register("IsPageBtnVisible4",
                typeof(bool), typeof(Pagination), new PropertyMetadata(false));
        public bool IsPageBtnVisible5
        {
            get { return (bool)GetValue(IsPageBtnVisible5Property); }
            set { SetValue(IsPageBtnVisible5Property, value); }
        }
        public static readonly DependencyProperty IsPageBtnVisible5Property =
            DependencyProperty.Register("IsPageBtnVisible5",
                typeof(bool), typeof(Pagination), new PropertyMetadata(false));
        private Button? _preiousPageButton;
        private Button? _nextPageButton;
        private Button? _pageButton1;
        private Button? _pageButton2;
        private Button? _pageButton3;
        private Button? _pageButton4;
        private Button? _pageButton5;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            // Find the template parts
            _preiousPageButton = GetTemplateChild("PART_PreviousPageButton") as Button;
            _nextPageButton = GetTemplateChild("PART_NextPageButton") as Button;
            _pageButton1 = GetTemplateChild("PART_PageButton1") as Button;
            _pageButton2 = GetTemplateChild("PART_PageButton2") as Button;
            _pageButton3 = GetTemplateChild("PART_PageButton3") as Button;
            _pageButton4 = GetTemplateChild("PART_PageButton4") as Button;
            _pageButton5 = GetTemplateChild("PART_PageButton5") as Button;

            if (_preiousPageButton != null) _preiousPageButton.Click += (s, e) => ExecutePreviousPage();
            if (_preiousPageButton != null) _preiousPageButton.Click += (s, e) => ExecutePreviousPage();
            if (_nextPageButton != null) _nextPageButton.Click += (s, e) => ExecuteNextPage();
            if (_pageButton1 != null) _pageButton1.Click += (s, e) => CurrentPage = PageBtn1;
            if (_pageButton2 != null) _pageButton2.Click += (s, e) => CurrentPage = PageBtn2;
            if (_pageButton3 != null) _pageButton3.Click += (s, e) => CurrentPage = PageBtn3;
            if (_pageButton4 != null) _pageButton4.Click += (s, e) => CurrentPage = PageBtn4;
            if (_pageButton5 != null) _pageButton5.Click += (s, e) => CurrentPage = PageBtn5;

        }
        private void ExecutePreviousPage()
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
            }
        }
        private void ExecuteNextPage()
        {
            if (Pages > CurrentPage)
            {
                CurrentPage++;
            }
        }

        private void CreatePagination(int pages, int page)
        {
            PageBtnStyle1 = "pagingButton";
            PageBtnStyle2 = "pagingButton";
            PageBtnStyle3 = "pagingButton";
            PageBtnStyle4 = "pagingButton";
            PageBtnStyle5 = "pagingButton";

            IsNextPageBtnVisible = page < pages;
            IsPreviousPageBtnVisible = page > 1;

            IsPageBtnVisible1 = false;
            IsPageBtnVisible2 = false;
            IsPageBtnVisible3 = false;
            IsPageBtnVisible4 = false;
            IsPageBtnVisible5 = false;

            IsFirstPaginationVisible = false;
            IsSecondPaginationVisible = false;

            if (pages <= 5)
            {
                for (int i = 1; i <= pages; i++)
                {
                    SetPageButton(i, i, page == i ? "pagingButtonActive" : "pagingButton", true);
                }
            }
            //Pages greater than 5
            else
            {
                if (page <= 3)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        SetPageButton(i, i, page == i ? "pagingButtonActive" : "pagingButton", true);
                    }
                    PageBtn5 = pages;
                    IsPageBtnVisible5 = true;
                    IsSecondPaginationVisible = true;
                }
                else if (page >= pages - 2)
                {
                    PageBtn1 = 1;
                    IsPageBtnVisible1 = true;
                    IsFirstPaginationVisible = true;
                    for (int i = pages - 3, btnIndex = 2; i <= pages; i++, btnIndex++)
                    {
                        SetPageButton(btnIndex, i, page == i ? "pagingButtonActive" : "pagingButton", true);
                    }
                }
                else
                {
                    PageBtn1 = 1;
                    IsPageBtnVisible1 = true;
                    IsFirstPaginationVisible = true;
                    PageBtn5 = pages;
                    IsPageBtnVisible5 = true;
                    IsSecondPaginationVisible = true;
                    SetPageButton(2, (page - 1), "pagingButton", true);
                    SetPageButton(3, (page), "pagingButtonActive", true);
                    SetPageButton(4, (page + 1), "pagingButton", true);
                }
            }
        }

        private void SetPageButton(int buttonNumber, int content, string style, bool isVisible)
        {
            switch (buttonNumber)
            {
                case 1:
                    PageBtn1 = content;
                    PageBtnStyle1 = style;
                    IsPageBtnVisible1 = isVisible;
                    break;
                case 2:
                    PageBtn2 = content;
                    PageBtnStyle2 = style;
                    IsPageBtnVisible2 = isVisible;
                    break;
                case 3:
                    PageBtn3 = content;
                    PageBtnStyle3 = style;
                    IsPageBtnVisible3 = isVisible;
                    break;
                case 4:
                    PageBtn4 = content;
                    PageBtnStyle4 = style;
                    IsPageBtnVisible4 = isVisible;
                    break;
                case 5:
                    PageBtn5 = content;
                    PageBtnStyle5 = style;
                    IsPageBtnVisible5 = isVisible;
                    break;
            }
        }
    }
}