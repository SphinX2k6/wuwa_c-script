using System;

namespace System.Text.Json
{
	// Token: 0x02000034 RID: 52
	public struct JsonReaderOptions
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000B77A File Offset: 0x0000997A
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000B782 File Offset: 0x00009982
		public JsonCommentHandling CommentHandling
		{
			readonly get
			{
				return this._commentHandling;
			}
			set
			{
				if (value > JsonCommentHandling.Allow)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException_CommentEnumMustBeInRange("value");
				}
				this._commentHandling = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000B799 File Offset: 0x00009999
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000B7A1 File Offset: 0x000099A1
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000B7B8 File Offset: 0x000099B8
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0000B7C0 File Offset: 0x000099C0
		public bool AllowTrailingCommas { readonly get; set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000B7C9 File Offset: 0x000099C9
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0000B7D1 File Offset: 0x000099D1
		public bool AllowMultipleValues { readonly get; set; }

		// Token: 0x04000095 RID: 149
		private int _maxDepth;

		// Token: 0x04000096 RID: 150
		private JsonCommentHandling _commentHandling;
	}
}
