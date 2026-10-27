using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000091 RID: 145
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.Interface)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.Interface, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public readonly struct TScriptInterface<[Nullable(0)] T> : IEqualityOperators<TScriptInterface<T>, TScriptInterface<T>, bool> where T : IUnrealInterface
	{
		// Token: 0x06000FE7 RID: 4071 RVA: 0x00018279 File Offset: 0x00016479
		[NullableContext(2)]
		public TScriptInterface(IUnrealNativeInterface Object, int InterfaceOffset)
		{
			this.ScriptInterface = new FScriptInterface(Object, InterfaceOffset);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00018288 File Offset: 0x00016488
		[NullableContext(2)]
		public TScriptInterface(IUnrealBlueprintInterface Object)
		{
			this.ScriptInterface = new FScriptInterface(Object, 0);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00018297 File Offset: 0x00016497
		public TScriptInterface(in FScriptInterface InScriptInterface)
		{
			this.ScriptInterface = InScriptInterface;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x000182A5 File Offset: 0x000164A5
		[return: Nullable(2)]
		public V ToObject<[Nullable(0)] V>() where V : UnrealUObject, T
		{
			return this.ScriptInterface.ToObject<V>();
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x000182B2 File Offset: 0x000164B2
		[return: Nullable(2)]
		public V ToInterface<V>() where V : class, IUnrealInterface, T
		{
			return this.ScriptInterface.ToInterface<V>();
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x000182BF File Offset: 0x000164BF
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TScriptInterface<T> other)
		{
			return this.ScriptInterface == other.ScriptInterface;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000182D2 File Offset: 0x000164D2
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] TScriptInterface<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TScriptInterface<T> right)
		{
			return left.ScriptInterface == right.ScriptInterface;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000182E5 File Offset: 0x000164E5
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] TScriptInterface<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TScriptInterface<T> right)
		{
			return !(left == right);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x000182F4 File Offset: 0x000164F4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is TScriptInterface<T>)
			{
				TScriptInterface<T> other = (TScriptInterface<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00018319 File Offset: 0x00016519
		public override int GetHashCode()
		{
			return this.ScriptInterface.GetHashCode();
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0001832C File Offset: 0x0001652C
		public static implicit operator FScriptInterface([Nullable(new byte[]
		{
			0,
			1
		})] in TScriptInterface<T> A)
		{
			return A.ScriptInterface;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00018334 File Offset: 0x00016534
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static explicit operator TScriptInterface<T>(in FScriptInterface A)
		{
			return new TScriptInterface<T>(ref A);
		}

		// Token: 0x040001F9 RID: 505
		private readonly FScriptInterface ScriptInterface;
	}
}
