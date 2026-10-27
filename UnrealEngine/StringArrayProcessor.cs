using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200005A RID: 90
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class StringArrayProcessor : NativeArrayProcessorBase<string>
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x00010D54 File Offset: 0x0000EF54
		public StringArrayProcessor()
		{
			this.RequireConstructAndDestruct = true;
			this.HasGetTypeHash = true;
			UnrealStructLayoutAttribute customAttribute = typeof(FString).GetCustomAttribute<UnrealStructLayoutAttribute>();
			this.Size = customAttribute.Size;
			this.MinAlignment = customAttribute.Pack;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00010D9D File Offset: 0x0000EF9D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override string Get(IntPtr Data, int Index)
		{
			return FString.ToString((void*)(Data + (byte*)((IntPtr)(Index * this.Size))));
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00010DAF File Offset: 0x0000EFAF
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void Set(IntPtr Data, int Index, string Value)
		{
			FString.CopyFrom((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Value);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override int FindIndex(IntPtr Data, int Num, string Value)
		{
			if (Value == null)
			{
				Value = string.Empty;
			}
			char* ptr;
			if (Value == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = Value.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr2, Value.Length);
			return FString.FindIndex(Data, Num, fcsharpStringView);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00010E02 File Offset: 0x0000F002
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			FString.NativeConstruct(Data / (IntPtr)sizeof(FString) + Index * this.Size, Count);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00010E15 File Offset: 0x0000F015
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void DestructValues(IntPtr Data, int Index, int Count)
		{
			FString.NativeDestruct(Data / (IntPtr)sizeof(FString) + Index * this.Size, Count);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00010E28 File Offset: 0x0000F028
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			FString.NativeCopy(Dest, Data, Num);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00010E34 File Offset: 0x0000F034
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref string Value, ref bool bRequireToDelete)
		{
			bRequireToDelete = true;
			FCSharpStringView fcsharpStringView;
			if (Value == null || Value.Length == 0)
			{
				fcsharpStringView = default(FCSharpStringView);
				return (void*)FString.Alloc(fcsharpStringView);
			}
			string text = Value;
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = text.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			fcsharpStringView = new FCSharpStringView(ptr, Value.Length);
			return (void*)FString.Alloc(fcsharpStringView);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00010E86 File Offset: 0x0000F086
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void DeleteElementPtr(void* Data)
		{
			FString.Delete((FString*)Data);
		}
	}
}
