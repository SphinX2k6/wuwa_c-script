using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000066 RID: 102
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.Interface)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.Interface, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public readonly struct FScriptInterface : IEquatable<FScriptInterface>, IEqualityOperators<FScriptInterface, FScriptInterface, bool>
	{
		// Token: 0x06000A68 RID: 2664 RVA: 0x000110B3 File Offset: 0x0000F2B3
		public FScriptInterface(IntPtr InObjectPointer, IntPtr InInterfacePointer)
		{
			this.ObjectPointer = InObjectPointer;
			this.InterfacePointer = InInterfacePointer;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000110C3 File Offset: 0x0000F2C3
		public FScriptInterface(IUnrealNativeInterface Object, int InterfaceOffset)
		{
			this.ObjectPointer = (IntPtr)0;
			this.InterfacePointer = (IntPtr)0;
			if (Object != null)
			{
				this.ObjectPointer = Object.NativePtr;
				this.InterfacePointer = this.ObjectPointer + (IntPtr)InterfaceOffset;
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000110F3 File Offset: 0x0000F2F3
		public FScriptInterface(IUnrealBlueprintInterface Object, int InterfaceOffset = 0)
		{
			this.ObjectPointer = (IntPtr)0;
			this.InterfacePointer = (IntPtr)0;
			if (Object != null)
			{
				this.ObjectPointer = Object.NativePtr;
				this.InterfacePointer = this.ObjectPointer;
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00011120 File Offset: 0x0000F320
		public FScriptInterface(UnrealObject Object, int InterfaceOffset)
		{
			this.ObjectPointer = (IntPtr)0;
			this.InterfacePointer = (IntPtr)0;
			if (Object != null)
			{
				this.ObjectPointer = Object.NativePtr;
				this.InterfacePointer = this.ObjectPointer;
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00011150 File Offset: 0x0000F350
		[NullableContext(0)]
		[return: Nullable(2)]
		public V ToObject<V>() where V : UnrealUObject
		{
			if (!this.IsValid())
			{
				return default(V);
			}
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<V>(this.ObjectPointer);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0001117C File Offset: 0x0000F37C
		[NullableContext(1)]
		[return: Nullable(2)]
		public V ToInterface<V>() where V : class, IUnrealInterface
		{
			if (!this.IsValid())
			{
				return default(V);
			}
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(this.ObjectPointer) as V;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000111B0 File Offset: 0x0000F3B0
		public UnrealUObject ToUObject()
		{
			if (!this.IsValid())
			{
				return null;
			}
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(this.ObjectPointer);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000111C7 File Offset: 0x0000F3C7
		public bool IsValid()
		{
			return this.ObjectPointer != IntPtr.Zero && this.InterfacePointer != IntPtr.Zero;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x000111E8 File Offset: 0x0000F3E8
		public bool Equals(FScriptInterface other)
		{
			return this.ObjectPointer == other.ObjectPointer && this.InterfacePointer == other.InterfacePointer;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00011208 File Offset: 0x0000F408
		public static bool operator ==(FScriptInterface left, FScriptInterface right)
		{
			return left.ObjectPointer == right.ObjectPointer && left.InterfacePointer == right.InterfacePointer;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00011228 File Offset: 0x0000F428
		public static bool operator !=(FScriptInterface left, FScriptInterface right)
		{
			return !(left == right);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00011234 File Offset: 0x0000F434
		public override bool Equals(object obj)
		{
			if (obj is FScriptInterface)
			{
				FScriptInterface other = (FScriptInterface)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00011259 File Offset: 0x0000F459
		public override int GetHashCode()
		{
			return HashCode.Combine<IntPtr, IntPtr>(this.ObjectPointer, this.InterfacePointer);
		}

		// Token: 0x04000183 RID: 387
		[FieldOffset(0)]
		internal readonly IntPtr ObjectPointer;

		// Token: 0x04000184 RID: 388
		[FieldOffset(8)]
		internal readonly IntPtr InterfacePointer;
	}
}
