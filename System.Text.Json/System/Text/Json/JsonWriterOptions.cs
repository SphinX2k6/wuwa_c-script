using System;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

namespace System.Text.Json
{
	// Token: 0x0200005A RID: 90
	[NullableContext(1)]
	[Nullable(0)]
	public struct JsonWriterOptions
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0001839E File Offset: 0x0001659E
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x000183A6 File Offset: 0x000165A6
		[Nullable(2)]
		public JavaScriptEncoder Encoder { [NullableContext(2)] readonly get; [NullableContext(2)] set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x000183AF File Offset: 0x000165AF
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x000183BC File Offset: 0x000165BC
		public bool Indented
		{
			get
			{
				return (this._optionsMask & 1) != 0;
			}
			set
			{
				if (value)
				{
					this._optionsMask |= 1;
					return;
				}
				this._optionsMask &= -2;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x000183DF File Offset: 0x000165DF
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x000183F0 File Offset: 0x000165F0
		public char IndentCharacter
		{
			readonly get
			{
				if ((this._optionsMask & 8) == 0)
				{
					return ' ';
				}
				return '\t';
			}
			set
			{
				JsonWriterHelper.ValidateIndentCharacter(value);
				if (value != ' ')
				{
					this._optionsMask |= 8;
					return;
				}
				this._optionsMask &= -9;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0001841B File Offset: 0x0001661B
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00018430 File Offset: 0x00016630
		public int IndentSize
		{
			readonly get
			{
				return JsonWriterOptions.EncodeIndentSize((this._optionsMask & 2032) >> 4);
			}
			set
			{
				JsonWriterHelper.ValidateIndentSize(value);
				this._optionsMask = ((this._optionsMask & -2033) | JsonWriterOptions.EncodeIndentSize(value) << 4);
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00018454 File Offset: 0x00016654
		private static int EncodeIndentSize(int value)
		{
			int result;
			if (value != 0)
			{
				if (value != 2)
				{
					result = value;
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = 2;
			}
			return result;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00018475 File Offset: 0x00016675
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0001847D File Offset: 0x0001667D
		public int MaxDepth
		{
			readonly get
			{
				return this._maxDepth;
			}
			set
			{
				if (value < 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException_MaxDepthMustBePositive("value");
				}
				this._maxDepth = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00018494 File Offset: 0x00016694
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000184A1 File Offset: 0x000166A1
		public bool SkipValidation
		{
			get
			{
				return (this._optionsMask & 2) != 0;
			}
			set
			{
				if (value)
				{
					this._optionsMask |= 2;
					return;
				}
				this._optionsMask &= -3;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000184C4 File Offset: 0x000166C4
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x000184DB File Offset: 0x000166DB
		public string NewLine
		{
			get
			{
				if ((this._optionsMask & 4) == 0)
				{
					return Environment.NewLine;
				}
				return JsonWriterOptions.s_alternateNewLine;
			}
			set
			{
				JsonWriterHelper.ValidateNewLine(value);
				if (value != Environment.NewLine)
				{
					this._optionsMask |= 4;
					return;
				}
				this._optionsMask &= -5;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001850E File Offset: 0x0001670E
		internal bool IndentedOrNotSkipValidation
		{
			get
			{
				return (this._optionsMask & 3) != 2;
			}
		}

		// Token: 0x040001DE RID: 478
		private static readonly string s_alternateNewLine = (Environment.NewLine.Length == 2) ? "\n" : "\r\n";

		// Token: 0x040001DF RID: 479
		private int _maxDepth;

		// Token: 0x040001E0 RID: 480
		private int _optionsMask;
	}
}
