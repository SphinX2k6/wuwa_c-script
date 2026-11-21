using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018A RID: 394
	[UnrealObjectPath("/Script/Engine.BasedMovementInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FBasedMovementInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060019B0 RID: 6576 RVA: 0x000269C6 File Offset: 0x00024BC6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBasedMovementInfo._ScriptStructPtr != 0) ? FBasedMovementInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BasedMovementInfo", ref FBasedMovementInfo._ScriptStructPtr);
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x000269EA File Offset: 0x00024BEA
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x000269FE File Offset: 0x00024BFE
		[Nullable(2)]
		public unsafe UPrimitiveComponent MovementBase
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FBasedMovementInfo.__PropertyOffset_MovementBase);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBasedMovementInfo.__PropertyOffset_MovementBase, value);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x00026A13 File Offset: 0x00024C13
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x00026A27 File Offset: 0x00024C27
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x00026A3C File Offset: 0x00024C3C
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x00026A50 File Offset: 0x00024C50
		public unsafe FVector_NetQuantize100 Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00026A65 File Offset: 0x00024C65
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x00026A79 File Offset: 0x00024C79
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00026A8E File Offset: 0x00024C8E
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x00026A9E File Offset: 0x00024C9E
		public unsafe bool bServerHasBaseComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bServerHasBaseComponent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bServerHasBaseComponent) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x00026AAF File Offset: 0x00024CAF
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x00026ABF File Offset: 0x00024CBF
		public unsafe bool bRelativeRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bRelativeRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bRelativeRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00026AD0 File Offset: 0x00024CD0
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x00026AE0 File Offset: 0x00024CE0
		public unsafe bool bServerHasVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bServerHasVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedMovementInfo.__PropertyOffset_bServerHasVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00026AF1 File Offset: 0x00024CF1
		public FBasedMovementInfo()
		{
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00026AF9 File Offset: 0x00024CF9
		protected override IntPtr GetUStructPtr()
		{
			return FBasedMovementInfo.StaticStruct();
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00026B05 File Offset: 0x00024D05
		[NullableContext(2)]
		public FBasedMovementInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00026B0F File Offset: 0x00024D0F
		public FBasedMovementInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00026B1A File Offset: 0x00024D1A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBasedMovementInfo(Pointer, false, true);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00026B24 File Offset: 0x00024D24
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBasedMovementInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04000832 RID: 2098
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BasedMovementInfo";

		// Token: 0x04000833 RID: 2099
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000834 RID: 2100
		internal static int __PropertyOffset_MovementBase;

		// Token: 0x04000835 RID: 2101
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04000836 RID: 2102
		internal static int __PropertyOffset_Location;

		// Token: 0x04000837 RID: 2103
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04000838 RID: 2104
		internal static int __PropertyOffset_bServerHasBaseComponent;

		// Token: 0x04000839 RID: 2105
		internal static int __PropertyOffset_bRelativeRotation;

		// Token: 0x0400083A RID: 2106
		internal static int __PropertyOffset_bServerHasVelocity;
	}
}
