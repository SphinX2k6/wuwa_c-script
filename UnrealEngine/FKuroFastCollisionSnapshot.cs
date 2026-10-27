using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001836 RID: 6198
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionSnapshot")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FKuroFastCollisionSnapshot : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016D9E RID: 93598 RVA: 0x00215CE1 File Offset: 0x00213EE1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFastCollisionSnapshot._ScriptStructPtr != 0) ? FKuroFastCollisionSnapshot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroFastCollision.KuroFastCollisionSnapshot", ref FKuroFastCollisionSnapshot._ScriptStructPtr);
		}

		// Token: 0x17005C34 RID: 23604
		// (get) Token: 0x06016D9F RID: 93599 RVA: 0x00215D05 File Offset: 0x00213F05
		// (set) Token: 0x06016DA0 RID: 93600 RVA: 0x00215D15 File Offset: 0x00213F15
		public unsafe ECollisionShapeKind Kind
		{
			get
			{
				return (ECollisionShapeKind)(*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Kind));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Kind) = (byte)value;
			}
		}

		// Token: 0x17005C35 RID: 23605
		// (get) Token: 0x06016DA1 RID: 93601 RVA: 0x00215D26 File Offset: 0x00213F26
		// (set) Token: 0x06016DA2 RID: 93602 RVA: 0x00215D3A File Offset: 0x00213F3A
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17005C36 RID: 23606
		// (get) Token: 0x06016DA3 RID: 93603 RVA: 0x00215D4F File Offset: 0x00213F4F
		// (set) Token: 0x06016DA4 RID: 93604 RVA: 0x00215D5F File Offset: 0x00213F5F
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005C37 RID: 23607
		// (get) Token: 0x06016DA5 RID: 93605 RVA: 0x00215D70 File Offset: 0x00213F70
		// (set) Token: 0x06016DA6 RID: 93606 RVA: 0x00215D84 File Offset: 0x00213F84
		public unsafe FVector HalfExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_HalfExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_HalfExtent) = value;
			}
		}

		// Token: 0x17005C38 RID: 23608
		// (get) Token: 0x06016DA7 RID: 93607 RVA: 0x00215D99 File Offset: 0x00213F99
		// (set) Token: 0x06016DA8 RID: 93608 RVA: 0x00215DAD File Offset: 0x00213FAD
		public unsafe FQuat BoxRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_BoxRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_BoxRot) = value;
			}
		}

		// Token: 0x17005C39 RID: 23609
		// (get) Token: 0x06016DA9 RID: 93609 RVA: 0x00215DC2 File Offset: 0x00213FC2
		// (set) Token: 0x06016DAA RID: 93610 RVA: 0x00215DD6 File Offset: 0x00213FD6
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x17005C3A RID: 23610
		// (get) Token: 0x06016DAB RID: 93611 RVA: 0x00215DEB File Offset: 0x00213FEB
		// (set) Token: 0x06016DAC RID: 93612 RVA: 0x00215DFB File Offset: 0x00213FFB
		public unsafe float HalfLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_HalfLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_HalfLength) = value;
			}
		}

		// Token: 0x17005C3B RID: 23611
		// (get) Token: 0x06016DAD RID: 93613 RVA: 0x00215E0C File Offset: 0x0021400C
		// (set) Token: 0x06016DAE RID: 93614 RVA: 0x00215E20 File Offset: 0x00214020
		public unsafe FVector ConeAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_ConeAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_ConeAxis) = value;
			}
		}

		// Token: 0x17005C3C RID: 23612
		// (get) Token: 0x06016DAF RID: 93615 RVA: 0x00215E35 File Offset: 0x00214035
		// (set) Token: 0x06016DB0 RID: 93616 RVA: 0x00215E45 File Offset: 0x00214045
		public unsafe float ConeHalfAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_ConeHalfAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_ConeHalfAngle) = value;
			}
		}

		// Token: 0x17005C3D RID: 23613
		// (get) Token: 0x06016DB1 RID: 93617 RVA: 0x00215E56 File Offset: 0x00214056
		// (set) Token: 0x06016DB2 RID: 93618 RVA: 0x00215E66 File Offset: 0x00214066
		public unsafe float ConeHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_ConeHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_ConeHeight) = value;
			}
		}

		// Token: 0x17005C3E RID: 23614
		// (get) Token: 0x06016DB3 RID: 93619 RVA: 0x00215E77 File Offset: 0x00214077
		// (set) Token: 0x06016DB4 RID: 93620 RVA: 0x00215E87 File Offset: 0x00214087
		public unsafe bool bEnableCCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_bEnableCCD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_bEnableCCD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C3F RID: 23615
		// (get) Token: 0x06016DB5 RID: 93621 RVA: 0x00215E98 File Offset: 0x00214098
		// (set) Token: 0x06016DB6 RID: 93622 RVA: 0x00215EA8 File Offset: 0x002140A8
		public unsafe bool IsObstacle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_IsObstacle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_IsObstacle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C40 RID: 23616
		// (get) Token: 0x06016DB7 RID: 93623 RVA: 0x00215EB9 File Offset: 0x002140B9
		// (set) Token: 0x06016DB8 RID: 93624 RVA: 0x00215EC9 File Offset: 0x002140C9
		public unsafe bool NeedContactInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_NeedContactInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_NeedContactInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C41 RID: 23617
		// (get) Token: 0x06016DB9 RID: 93625 RVA: 0x00215EDA File Offset: 0x002140DA
		// (set) Token: 0x06016DBA RID: 93626 RVA: 0x00215EEE File Offset: 0x002140EE
		public unsafe TEnumAsByte<ECollisionChannel> Channel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Channel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_Channel) = value;
			}
		}

		// Token: 0x17005C42 RID: 23618
		// (get) Token: 0x06016DBB RID: 93627 RVA: 0x00215F03 File Offset: 0x00214103
		// (set) Token: 0x06016DBC RID: 93628 RVA: 0x00215F13 File Offset: 0x00214113
		public unsafe int QueryMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_QueryMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFastCollisionSnapshot.__PropertyOffset_QueryMask) = value;
			}
		}

		// Token: 0x06016DBD RID: 93629 RVA: 0x00215F24 File Offset: 0x00214124
		public FKuroFastCollisionSnapshot()
		{
		}

		// Token: 0x06016DBE RID: 93630 RVA: 0x00215F2C File Offset: 0x0021412C
		public FKuroFastCollisionSnapshot(ECollisionShapeKind Kind, FVector Center, float Radius, FVector HalfExtent, FQuat BoxRot, FVector Axis, float HalfLength, FVector ConeAxis, float ConeHalfAngle, float ConeHeight, bool bEnableCCD, bool IsObstacle, bool NeedContactInfo, TEnumAsByte<ECollisionChannel> Channel, int QueryMask)
		{
			this.Kind = Kind;
			this.Center = Center;
			this.Radius = Radius;
			this.HalfExtent = HalfExtent;
			this.BoxRot = BoxRot;
			this.Axis = Axis;
			this.HalfLength = HalfLength;
			this.ConeAxis = ConeAxis;
			this.ConeHalfAngle = ConeHalfAngle;
			this.ConeHeight = ConeHeight;
			this.bEnableCCD = bEnableCCD;
			this.IsObstacle = IsObstacle;
			this.NeedContactInfo = NeedContactInfo;
			this.Channel = Channel;
			this.QueryMask = QueryMask;
		}

		// Token: 0x06016DBF RID: 93631 RVA: 0x00215FB4 File Offset: 0x002141B4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFastCollisionSnapshot.StaticStruct();
		}

		// Token: 0x06016DC0 RID: 93632 RVA: 0x00215FC0 File Offset: 0x002141C0
		[NullableContext(2)]
		public FKuroFastCollisionSnapshot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016DC1 RID: 93633 RVA: 0x00215FCA File Offset: 0x002141CA
		public FKuroFastCollisionSnapshot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016DC2 RID: 93634 RVA: 0x00215FD5 File Offset: 0x002141D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFastCollisionSnapshot(Pointer, false, true);
		}

		// Token: 0x06016DC3 RID: 93635 RVA: 0x00215FDF File Offset: 0x002141DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFastCollisionSnapshot(Pointer, MemoryOwner);
		}

		// Token: 0x0400C6C3 RID: 50883
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionSnapshot";

		// Token: 0x0400C6C4 RID: 50884
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C6C5 RID: 50885
		internal static int __PropertyOffset_Kind;

		// Token: 0x0400C6C6 RID: 50886
		internal static int __PropertyOffset_Center;

		// Token: 0x0400C6C7 RID: 50887
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C6C8 RID: 50888
		internal static int __PropertyOffset_HalfExtent;

		// Token: 0x0400C6C9 RID: 50889
		internal static int __PropertyOffset_BoxRot;

		// Token: 0x0400C6CA RID: 50890
		internal static int __PropertyOffset_Axis;

		// Token: 0x0400C6CB RID: 50891
		internal static int __PropertyOffset_HalfLength;

		// Token: 0x0400C6CC RID: 50892
		internal static int __PropertyOffset_ConeAxis;

		// Token: 0x0400C6CD RID: 50893
		internal static int __PropertyOffset_ConeHalfAngle;

		// Token: 0x0400C6CE RID: 50894
		internal static int __PropertyOffset_ConeHeight;

		// Token: 0x0400C6CF RID: 50895
		internal static int __PropertyOffset_bEnableCCD;

		// Token: 0x0400C6D0 RID: 50896
		internal static int __PropertyOffset_IsObstacle;

		// Token: 0x0400C6D1 RID: 50897
		internal static int __PropertyOffset_NeedContactInfo;

		// Token: 0x0400C6D2 RID: 50898
		internal static int __PropertyOffset_Channel;

		// Token: 0x0400C6D3 RID: 50899
		internal static int __PropertyOffset_QueryMask;
	}
}
