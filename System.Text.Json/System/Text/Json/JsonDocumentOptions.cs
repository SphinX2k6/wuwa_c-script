using System;

namespace System.Text.Json
{
	// Token: 0x02000027 RID: 39
	public struct JsonDocumentOptions
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000966E File Offset: 0x0000786E
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00009676 File Offset: 0x00007876
		public JsonCommentHandling CommentHandling
		{
			readonly get
			{
				return this._commentHandling;
			}
			set
			{
				if (value > JsonCommentHandling.Skip)
				{
					throw new ArgumentOutOfRangeException("value", SR.JsonDocumentDoesNotSupportComments);
				}
				this._commentHandling = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00009693 File Offset: 0x00007893
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0000969B File Offset: 0x0000789B
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600028E RID: 654 RVA: 0x000096B2 File Offset: 0x000078B2
		// (set) Token: 0x0600028F RID: 655 RVA: 0x000096BA File Offset: 0x000078BA
		public bool AllowTrailingCommas { readonly get; set; }

		// Token: 0x06000290 RID: 656 RVA: 0x000096C4 File Offset: 0x000078C4
		internal JsonReaderOptions GetReaderOptions()
		{
			return new JsonReaderOptions
			{
				AllowTrailingCommas = this.AllowTrailingCommas,
				CommentHandling = this.CommentHandling,
				MaxDepth = this.MaxDepth
			};
		}

		// Token: 0x04000060 RID: 96
		private int _maxDepth;

		// Token: 0x04000061 RID: 97
		private JsonCommentHandling _commentHandling;
	}
}
