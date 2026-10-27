using System;
using System.Runtime.CompilerServices;

// Token: 0x0200001C RID: 28
[NullableContext(1)]
[Nullable(0)]
public class EventParameter<[Nullable(2)] T>
{
	// Token: 0x0600005C RID: 92 RVA: 0x00004EFE File Offset: 0x000030FE
	public EventParameter(T value)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600005D RID: 93 RVA: 0x00004F12 File Offset: 0x00003112
	public ScriptPropertyDefine Define
	{
		get
		{
			return this._Define;
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00004F1A File Offset: 0x0000311A
	public int GetParameterBufferSize()
	{
		return this._Define.GetDefineSize() + GameScriptPropertyConverterUtils.GetScriptPropertyTypeSize(this._Define);
	}

	// Token: 0x04000049 RID: 73
	private readonly ScriptPropertyDefine _Define = GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine<T>(value);
}
