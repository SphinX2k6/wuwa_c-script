using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000008 RID: 8
public class StringPropertyDefine : ScriptPropertyDefine
{
	// Token: 0x0600001A RID: 26 RVA: 0x0000361C File Offset: 0x0000181C
	public long GetValueAddress()
	{
		if (this._GCHandle.IsAllocated)
		{
			return this._CharPointer.ToInt64();
		}
		return 0L;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0000363C File Offset: 0x0000183C
	[NullableContext(2)]
	public unsafe StringPropertyDefine(bool isPassByPointer, string value)
	{
		this.Type = EScriptPropertyType.EScriptPropertyType_String;
		this.IsPassByPointer = isPassByPointer;
		if (this.IsPassByPointer)
		{
			if (value != null)
			{
				this._GCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
				fixed (char* pinnableReference = value.GetPinnableReference())
				{
					char* charPointer = pinnableReference;
					this._CharPointer = charPointer;
				}
				return;
			}
		}
		else if (value != null)
		{
			this.StringLength = value.Length;
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0000369C File Offset: 0x0000189C
	~StringPropertyDefine()
	{
		if (this._GCHandle.IsAllocated)
		{
			this._GCHandle.Free();
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000036DC File Offset: 0x000018DC
	public override int GetDefineSize()
	{
		int num = 1;
		num++;
		if (!this.IsPassByPointer)
		{
			num += 4;
		}
		return num;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000036FC File Offset: 0x000018FC
	public unsafe override void Serialize(byte* buffer, ref int offset)
	{
		fixed (EScriptPropertyType* ptr = &this.Type)
		{
			void* source = (void*)ptr;
			Unsafe.CopyBlock((void*)(buffer + offset), source, 1U);
		}
		offset++;
		fixed (bool* ptr2 = &this.IsPassByPointer)
		{
			void* source2 = (void*)ptr2;
			Unsafe.CopyBlock((void*)(buffer + offset), source2, 1U);
		}
		offset++;
		if (!this.IsPassByPointer)
		{
			fixed (int* ptr3 = &this.StringLength)
			{
				void* source3 = (void*)ptr3;
				Unsafe.CopyBlock((void*)(buffer + offset), source3, 4U);
			}
			offset += 4;
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003770 File Offset: 0x00001970
	public unsafe override void Deserialize(byte* buffer, ref int offset)
	{
		fixed (bool* ptr = &this.IsPassByPointer)
		{
			void* destination = (void*)ptr;
			Unsafe.CopyBlock(destination, (void*)(buffer + offset), 1U);
		}
		offset++;
		if (!this.IsPassByPointer)
		{
			fixed (int* ptr2 = &this.StringLength)
			{
				void* destination2 = (void*)ptr2;
				Unsafe.CopyBlock(destination2, (void*)(buffer + offset), 4U);
			}
			offset += 4;
		}
	}

	// Token: 0x04000021 RID: 33
	private GCHandle _GCHandle;

	// Token: 0x04000022 RID: 34
	public bool IsPassByPointer;

	// Token: 0x04000023 RID: 35
	public int StringLength;

	// Token: 0x04000024 RID: 36
	private IntPtr _CharPointer;
}
