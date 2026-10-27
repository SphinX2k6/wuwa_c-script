using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000009 RID: 9
public class ScriptPropertyDefine
{
	// Token: 0x06000020 RID: 32 RVA: 0x000037C4 File Offset: 0x000019C4
	[return: Nullable(1)]
	public unsafe static ScriptPropertyDefine CreatePropertyDefine(byte* buffer, ref int offset)
	{
		EScriptPropertyType escriptPropertyType;
		Unsafe.CopyBlock((void*)(&escriptPropertyType), (void*)(buffer + offset), 1U);
		offset++;
		ScriptPropertyDefine result;
		if (escriptPropertyType == EScriptPropertyType.EScriptPropertyType_String)
		{
			result = new StringPropertyDefine(true, null);
		}
		else
		{
			result = new ScriptPropertyDefine(escriptPropertyType);
		}
		return result;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000037FB File Offset: 0x000019FB
	public ScriptPropertyDefine()
	{
		this.Type = EScriptPropertyType.EScriptPropertyType_None;
		this.ElementCount = 0;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00003827 File Offset: 0x00001A27
	public ScriptPropertyDefine(EScriptPropertyType inType)
	{
		this.Type = inType;
		this.ElementCount = 0;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00003853 File Offset: 0x00001A53
	public bool IsValid()
	{
		return this.Type > EScriptPropertyType.EScriptPropertyType_None;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x0000385E File Offset: 0x00001A5E
	public bool IsContainerType()
	{
		return this.Type == EScriptPropertyType.EScriptPropertyType_Array || this.Type == EScriptPropertyType.EScriptPropertyType_Set || this.Type == EScriptPropertyType.EScriptPropertyType_Map || this.Type == EScriptPropertyType.EScriptPropertyType_String;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000388A File Offset: 0x00001A8A
	public bool IsString()
	{
		return this.Type == EScriptPropertyType.EScriptPropertyType_String;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00003896 File Offset: 0x00001A96
	public bool IsUObject()
	{
		return this.Type == EScriptPropertyType.EScriptPropertyType_UObject;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000038A2 File Offset: 0x00001AA2
	public bool IsSpecialStruct()
	{
		return this.Type == EScriptPropertyType.EScriptPropertyType_FKey || this.Type == EScriptPropertyType.EScriptPropertyType_FName || this.Type == EScriptPropertyType.EScriptPropertyType_FArrayBuffer;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000038C4 File Offset: 0x00001AC4
	public bool IsSpecialSerialize()
	{
		return this.IsContainerType() || this.IsString() || this.IsUObject() || this.IsSpecialStruct();
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000038E8 File Offset: 0x00001AE8
	public virtual int GetDefineSize()
	{
		int num = 1;
		if (this.Type == EScriptPropertyType.EScriptPropertyType_Array || this.Type == EScriptPropertyType.EScriptPropertyType_Set)
		{
			num += 4;
			num += this.HeadElementProperty0.GetDefineSize();
			for (int i = 0; i < this.ElementProperty0.Count; i++)
			{
				num += this.ElementProperty0[i].GetDefineSize();
			}
		}
		else if (this.Type == EScriptPropertyType.EScriptPropertyType_Map)
		{
			num += 4;
			num += this.HeadElementProperty0.GetDefineSize();
			num += this.HeadElementProperty1.GetDefineSize();
			for (int j = 0; j < this.ElementProperty0.Count; j++)
			{
				num += this.ElementProperty0[j].GetDefineSize();
			}
			for (int k = 0; k < this.ElementProperty1.Count; k++)
			{
				num += this.ElementProperty1[k].GetDefineSize();
			}
		}
		return num;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000039C8 File Offset: 0x00001BC8
	public unsafe virtual void Serialize(byte* buffer, ref int offset)
	{
		fixed (EScriptPropertyType* ptr = &this.Type)
		{
			void* source = (void*)ptr;
			Unsafe.CopyBlock((void*)(buffer + offset), source, 1U);
		}
		offset++;
		if (this.Type == EScriptPropertyType.EScriptPropertyType_Array || this.Type == EScriptPropertyType.EScriptPropertyType_Set)
		{
			fixed (int* ptr2 = &this.ElementCount)
			{
				void* source2 = (void*)ptr2;
				Unsafe.CopyBlock((void*)(buffer + offset), source2, 4U);
			}
			offset += 4;
			this.HeadElementProperty0.Serialize(buffer, ref offset);
			if (this.HeadElementProperty0.IsContainerType())
			{
				for (int i = 0; i < this.ElementProperty0.Count<ScriptPropertyDefine>(); i++)
				{
					this.ElementProperty0[i].Serialize(buffer, ref offset);
				}
				return;
			}
		}
		else if (this.Type == EScriptPropertyType.EScriptPropertyType_Map)
		{
			fixed (int* ptr2 = &this.ElementCount)
			{
				void* source3 = (void*)ptr2;
				Unsafe.CopyBlock((void*)(buffer + offset), source3, 4U);
			}
			offset += 4;
			this.HeadElementProperty0.Serialize(buffer, ref offset);
			if (this.HeadElementProperty0.IsContainerType())
			{
				for (int j = 0; j < this.ElementProperty0.Count<ScriptPropertyDefine>(); j++)
				{
					this.ElementProperty0[j].Serialize(buffer, ref offset);
				}
			}
			this.HeadElementProperty1.Serialize(buffer, ref offset);
			if (this.HeadElementProperty1.IsContainerType())
			{
				for (int k = 0; k < this.ElementProperty1.Count<ScriptPropertyDefine>(); k++)
				{
					this.ElementProperty1[k].Serialize(buffer, ref offset);
				}
			}
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00003B30 File Offset: 0x00001D30
	public unsafe virtual void Deserialize(byte* buffer, ref int offset)
	{
		if (this.Type == EScriptPropertyType.EScriptPropertyType_Array || this.Type == EScriptPropertyType.EScriptPropertyType_Set)
		{
			fixed (int* ptr = &this.ElementCount)
			{
				void* destination = (void*)ptr;
				Unsafe.CopyBlock(destination, (void*)(buffer + offset), 4U);
			}
			offset += 4;
			if (this.ElementCount == 0)
			{
				return;
			}
			this.HeadElementProperty0 = ScriptPropertyDefine.CreatePropertyDefine(buffer, ref offset);
			this.HeadElementProperty0.Deserialize(buffer, ref offset);
			this.ElementProperty0.Clear();
			if (this.HeadElementProperty0.IsContainerType())
			{
				for (int i = 0; i < this.ElementCount - 1; i++)
				{
					ScriptPropertyDefine scriptPropertyDefine = ScriptPropertyDefine.CreatePropertyDefine(buffer, ref offset);
					scriptPropertyDefine.Deserialize(buffer, ref offset);
					this.ElementProperty0.Add(scriptPropertyDefine);
				}
				return;
			}
		}
		else if (this.Type == EScriptPropertyType.EScriptPropertyType_Map)
		{
			fixed (int* ptr = &this.ElementCount)
			{
				void* destination2 = (void*)ptr;
				Unsafe.CopyBlock(destination2, (void*)(buffer + offset), 4U);
			}
			offset += 4;
			if (this.ElementCount == 0)
			{
				return;
			}
			this.HeadElementProperty0 = ScriptPropertyDefine.CreatePropertyDefine(buffer, ref offset);
			this.HeadElementProperty0.Deserialize(buffer, ref offset);
			this.ElementProperty0.Clear();
			if (this.HeadElementProperty0.IsContainerType())
			{
				for (int j = 0; j < this.ElementCount - 1; j++)
				{
					ScriptPropertyDefine scriptPropertyDefine2 = ScriptPropertyDefine.CreatePropertyDefine(buffer, ref offset);
					scriptPropertyDefine2.Deserialize(buffer, ref offset);
					this.ElementProperty0.Add(scriptPropertyDefine2);
				}
			}
			this.HeadElementProperty1 = ScriptPropertyDefine.CreatePropertyDefine(buffer, ref offset);
			this.HeadElementProperty1.Deserialize(buffer, ref offset);
			this.ElementProperty1.Clear();
			if (this.HeadElementProperty1.IsContainerType())
			{
				for (int k = 0; k < this.ElementCount - 1; k++)
				{
					ScriptPropertyDefine scriptPropertyDefine3 = ScriptPropertyDefine.CreatePropertyDefine(buffer, ref offset);
					scriptPropertyDefine3.Deserialize(buffer, ref offset);
					this.ElementProperty1.Add(scriptPropertyDefine3);
				}
			}
		}
	}

	// Token: 0x04000025 RID: 37
	public EScriptPropertyType Type;

	// Token: 0x04000026 RID: 38
	public int ElementCount;

	// Token: 0x04000027 RID: 39
	[Nullable(2)]
	public ScriptPropertyDefine HeadElementProperty0;

	// Token: 0x04000028 RID: 40
	[Nullable(2)]
	public ScriptPropertyDefine HeadElementProperty1;

	// Token: 0x04000029 RID: 41
	[Nullable(1)]
	public List<ScriptPropertyDefine> ElementProperty0 = new List<ScriptPropertyDefine>();

	// Token: 0x0400002A RID: 42
	[Nullable(1)]
	public List<ScriptPropertyDefine> ElementProperty1 = new List<ScriptPropertyDefine>();
}
