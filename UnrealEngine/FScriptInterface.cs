using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000081 RID: 129
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.Interface)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.Interface, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public readonly struct FScriptInterface : IEquatable<FScriptInterface>, IEqualityOperators<FScriptInterface, FScriptInterface, bool>
	{
		// Token: 0x06000ED3 RID: 3795 RVA: 0x00016337 File Offset: 0x00014537
		public FScriptInterface(IntPtr InObjectPointer, IntPtr InInterfacePointer)
		{
			this.ObjectPointer = InObjectPointer;
			this.InterfacePointer = InInterfacePointer;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00016347 File Offset: 0x00014547
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

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00016377 File Offset: 0x00014577
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

		// Token: 0x06000ED6 RID: 3798 RVA: 0x000163A4 File Offset: 0x000145A4
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

		// Token: 0x06000ED7 RID: 3799 RVA: 0x000163D4 File Offset: 0x000145D4
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

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00016400 File Offset: 0x00014600
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

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00016434 File Offset: 0x00014634
		public UnrealUObject ToUObject()
		{
			if (!this.IsValid())
			{
				return null;
			}
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(this.ObjectPointer);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0001644B File Offset: 0x0001464B
		public bool IsValid()
		{
			return this.ObjectPointer != IntPtr.Zero && this.InterfacePointer != IntPtr.Zero;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0001646C File Offset: 0x0001466C
		public bool Equals(FScriptInterface other)
		{
			return this.ObjectPointer == other.ObjectPointer && this.InterfacePointer == other.InterfacePointer;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0001648C File Offset: 0x0001468C
		public static bool operator ==(FScriptInterface left, FScriptInterface right)
		{
			return left.ObjectPointer == right.ObjectPointer && left.InterfacePointer == right.InterfacePointer;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000164AC File Offset: 0x000146AC
		public static bool operator !=(FScriptInterface left, FScriptInterface right)
		{
			return !(left == right);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000164B8 File Offset: 0x000146B8
		public override bool Equals(object obj)
		{
			if (obj is FScriptInterface)
			{
				FScriptInterface other = (FScriptInterface)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000164DD File Offset: 0x000146DD
		public override int GetHashCode()
		{
			return HashCode.Combine<IntPtr, IntPtr>(this.ObjectPointer, this.InterfacePointer);
		}

		// Token: 0x040001CA RID: 458
		[FieldOffset(0)]
		internal readonly IntPtr ObjectPointer;

		// Token: 0x040001CB RID: 459
		[FieldOffset(8)]
		internal readonly IntPtr InterfacePointer;
	}
}
