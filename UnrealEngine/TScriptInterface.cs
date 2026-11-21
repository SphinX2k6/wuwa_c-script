using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000076 RID: 118
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.Interface)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.Interface, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public readonly struct TScriptInterface<[Nullable(0)] T> : IEqualityOperators<TScriptInterface<T>, TScriptInterface<T>, bool> where T : IUnrealInterface
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x00012F9D File Offset: 0x0001119D
		[NullableContext(2)]
		public TScriptInterface(IUnrealNativeInterface Object, int InterfaceOffset)
		{
			this.ScriptInterface = new FScriptInterface(Object, InterfaceOffset);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00012FAC File Offset: 0x000111AC
		[NullableContext(2)]
		public TScriptInterface(IUnrealBlueprintInterface Object)
		{
			this.ScriptInterface = new FScriptInterface(Object, 0);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00012FBB File Offset: 0x000111BB
		public TScriptInterface(in FScriptInterface InScriptInterface)
		{
			this.ScriptInterface = InScriptInterface;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00012FC9 File Offset: 0x000111C9
		[return: Nullable(2)]
		public V ToObject<[Nullable(0)] V>() where V : UnrealUObject, T
		{
			return this.ScriptInterface.ToObject<V>();
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00012FD6 File Offset: 0x000111D6
		[return: Nullable(2)]
		public V ToInterface<V>() where V : class, IUnrealInterface, T
		{
			return this.ScriptInterface.ToInterface<V>();
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00012FE3 File Offset: 0x000111E3
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TScriptInterface<T> other)
		{
			return this.ScriptInterface == other.ScriptInterface;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00012FF6 File Offset: 0x000111F6
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

		// Token: 0x06000B81 RID: 2945 RVA: 0x00013009 File Offset: 0x00011209
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

		// Token: 0x06000B82 RID: 2946 RVA: 0x00013018 File Offset: 0x00011218
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

		// Token: 0x06000B83 RID: 2947 RVA: 0x0001303D File Offset: 0x0001123D
		public override int GetHashCode()
		{
			return this.ScriptInterface.GetHashCode();
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00013050 File Offset: 0x00011250
		public static implicit operator FScriptInterface([Nullable(new byte[]
		{
			0,
			1
		})] in TScriptInterface<T> A)
		{
			return A.ScriptInterface;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00013058 File Offset: 0x00011258
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static explicit operator TScriptInterface<T>(in FScriptInterface A)
		{
			return new TScriptInterface<T>(ref A);
		}

		// Token: 0x040001B2 RID: 434
		private readonly FScriptInterface ScriptInterface;
	}
}
