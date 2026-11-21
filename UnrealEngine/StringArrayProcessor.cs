using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200003F RID: 63
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class StringArrayProcessor : NativeArrayProcessorBase<string>
	{
		// Token: 0x06000874 RID: 2164 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		public StringArrayProcessor()
		{
			this.RequireConstructAndDestruct = true;
			this.HasGetTypeHash = true;
			UnrealStructLayoutAttribute customAttribute = typeof(FString).GetCustomAttribute<UnrealStructLayoutAttribute>();
			this.Size = customAttribute.Size;
			this.MinAlignment = customAttribute.Pack;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0000D609 File Offset: 0x0000B809
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override string Get(IntPtr Data, int Index)
		{
			return FString.ToString((void*)(Data + (byte*)((IntPtr)(Index * this.Size))));
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0000D61B File Offset: 0x0000B81B
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void Set(IntPtr Data, int Index, string Value)
		{
			FString.CopyFrom((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Value);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0000D630 File Offset: 0x0000B830
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

		// Token: 0x06000878 RID: 2168 RVA: 0x0000D66E File Offset: 0x0000B86E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			FString.NativeConstruct(Data / (IntPtr)sizeof(FString) + Index * this.Size, Count);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0000D681 File Offset: 0x0000B881
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void DestructValues(IntPtr Data, int Index, int Count)
		{
			FString.NativeDestruct(Data / (IntPtr)sizeof(FString) + Index * this.Size, Count);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0000D694 File Offset: 0x0000B894
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			FString.NativeCopy(Dest, Data, Num);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
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

		// Token: 0x0600087C RID: 2172 RVA: 0x0000D6F2 File Offset: 0x0000B8F2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void DeleteElementPtr(void* Data)
		{
			FString.Delete((FString*)Data);
		}
	}
}
