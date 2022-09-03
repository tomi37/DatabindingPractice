using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingPractice.WinForm.Helpers
{
    // 自作のラジオボタン
    // ツール > オプション > Windows フォームデザイナー > 全般 > ツールボックスの自動取得 (AutoToolboxPopulate) を true に設定すると、
    // ツールボックスに自作のラジオボタンが追加されるので、既存のコンポーネントと同じようにドラッグドロップでデザイナに追加できる。
    public sealed class CustomRadioButton : RadioButton
    {
        public CustomRadioButton()
        {
            // 自動でほかのコントロールが変わらないように設定
            AutoCheck = false;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            // 自分自身のチェック状態を反転する
            this.Checked = !this.Checked;
        }
    }
}
