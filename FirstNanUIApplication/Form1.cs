using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstNanUIApplication
{
	using NetDimension.NanUI;

	public partial class Form1 : Formium
	{
		public Form1()
			: base("http://cn.bing.com", false)
			// 第一个参数使用Bing来作为初始的网址，
			// 第二个参数强制NanUI使用原生的窗体样式来呈现界面
		{
			InitializeComponent();
		}
	}
}
