using System;

namespace System.Text.Json
{
	// Token: 0x02000035 RID: 53
	public readonly struct JsonReaderState
	{
		// Token: 0x06000340 RID: 832 RVA: 0x0000B7DC File Offset: 0x000099DC
		public JsonReaderState(JsonReaderOptions options = default(JsonReaderOptions))
		{
			this._lineNumber = 0L;
			this._bytePositionInLine = 0L;
			this._inObject = false;
			this._isNotPrimitive = false;
			this._valueIsEscaped = false;
			this._trailingCommaBeforeComment = false;
			this._tokenType = JsonTokenType.None;
			this._previousTokenType = JsonTokenType.None;
			this._readerOptions = options;
			this._bitStack = default(BitStack);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000B838 File Offset: 0x00009A38
		internal JsonReaderState(long lineNumber, long bytePositionInLine, bool inObject, bool isNotPrimitive, bool valueIsEscaped, bool trailingCommaBeforeComment, JsonTokenType tokenType, JsonTokenType previousTokenType, JsonReaderOptions readerOptions, BitStack bitStack)
		{
			this._lineNumber = lineNumber;
			this._bytePositionInLine = bytePositionInLine;
			this._inObject = inObject;
			this._isNotPrimitive = isNotPrimitive;
			this._valueIsEscaped = valueIsEscaped;
			this._trailingCommaBeforeComment = trailingCommaBeforeComment;
			this._tokenType = tokenType;
			this._previousTokenType = previousTokenType;
			this._readerOptions = readerOptions;
			this._bitStack = bitStack;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000B892 File Offset: 0x00009A92
		public JsonReaderOptions Options
		{
			get
			{
				return this._readerOptions;
			}
		}

		// Token: 0x04000099 RID: 153
		internal readonly long _lineNumber;

		// Token: 0x0400009A RID: 154
		internal readonly long _bytePositionInLine;

		// Token: 0x0400009B RID: 155
		internal readonly bool _inObject;

		// Token: 0x0400009C RID: 156
		internal readonly bool _isNotPrimitive;

		// Token: 0x0400009D RID: 157
		internal readonly bool _valueIsEscaped;

		// Token: 0x0400009E RID: 158
		internal readonly bool _trailingCommaBeforeComment;

		// Token: 0x0400009F RID: 159
		internal readonly JsonTokenType _tokenType;

		// Token: 0x040000A0 RID: 160
		internal readonly JsonTokenType _previousTokenType;

		// Token: 0x040000A1 RID: 161
		internal readonly JsonReaderOptions _readerOptions;

		// Token: 0x040000A2 RID: 162
		internal readonly BitStack _bitStack;
	}
}
