namespace Schizophrenia.Main.Pages {
    public enum PageID {
        Page1,
        Page2,
        Page3,
        Page4,
        Page5,
        Page6,
        Page7,
        Page8,
        Page9,
        Page10,
        Page11,
        Page12,
        Page13,
        Page14,
        Page15
    };

    public class AnyPage {
        protected AppForm appForm;
        public MyTableLayoutPanel mainTableLayout;
        public PageID ID;

        public AnyPage(AppForm appForm, PageID ID) {
            this.appForm = appForm;
            this.ID = ID;
        }

        public virtual PageID NextPage() {
            return ID + 1;
        }

        public virtual bool CanMoveOn() {
            return true;
        }
    }
}
