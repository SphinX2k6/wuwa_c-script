using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CDB RID: 3291
	[UnrealObjectPath("/Script/Engine.KTaperedCapsuleElem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKTaperedCapsuleElem : FKShapeElem, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AE73 RID: 44659 RVA: 0x000F76BA File Offset: 0x000F58BA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKTaperedCapsuleElem._ScriptStructPtr != 0) ? FKTaperedCapsuleElem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KTaperedCapsuleElem", ref FKTaperedCapsuleElem._ScriptStructPtr);
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x0600AE74 RID: 44660 RVA: 0x000F76DE File Offset: 0x000F58DE
		// (set) Token: 0x0600AE75 RID: 44661 RVA: 0x000F76F2 File Offset: 0x000F58F2
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x0600AE76 RID: 44662 RVA: 0x000F7707 File Offset: 0x000F5907
		// (set) Token: 0x0600AE77 RID: 44663 RVA: 0x000F771B File Offset: 0x000F591B
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x0600AE78 RID: 44664 RVA: 0x000F7730 File Offset: 0x000F5930
		// (set) Token: 0x0600AE79 RID: 44665 RVA: 0x000F7740 File Offset: 0x000F5940
		public unsafe float Radius0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Radius0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Radius0) = value;
			}
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x0600AE7A RID: 44666 RVA: 0x000F7751 File Offset: 0x000F5951
		// (set) Token: 0x0600AE7B RID: 44667 RVA: 0x000F7761 File Offset: 0x000F5961
		public unsafe float Radius1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Radius1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Radius1) = value;
			}
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x0600AE7C RID: 44668 RVA: 0x000F7772 File Offset: 0x000F5972
		// (set) Token: 0x0600AE7D RID: 44669 RVA: 0x000F7782 File Offset: 0x000F5982
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKTaperedCapsuleElem.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x0600AE7E RID: 44670 RVA: 0x000F7793 File Offset: 0x000F5993
		public FKTaperedCapsuleElem()
		{
		}

		// Token: 0x0600AE7F RID: 44671 RVA: 0x000F779C File Offset: 0x000F599C
		public FKTaperedCapsuleElem(FVector Center, FRotator Rotation, float Radius0, float Radius1, float Length, float RestOffset, bool bIsGenerated, FName Name, bool bContributeToMass, TEnumAsByte<ECollisionEnabled> CollisionEnabled)
		{
			this.Center = Center;
			this.Rotation = Rotation;
			this.Radius0 = Radius0;
			this.Radius1 = Radius1;
			this.Length = Length;
			base.RestOffset = RestOffset;
			base.Name = Name;
			base.bContributeToMass = bContributeToMass;
			base.CollisionEnabled = CollisionEnabled;
		}

		// Token: 0x0600AE80 RID: 44672 RVA: 0x000F77F4 File Offset: 0x000F59F4
		protected override IntPtr GetUStructPtr()
		{
			return FKTaperedCapsuleElem.StaticStruct();
		}

		// Token: 0x0600AE81 RID: 44673 RVA: 0x000F7800 File Offset: 0x000F5A00
		[NullableContext(2)]
		public FKTaperedCapsuleElem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AE82 RID: 44674 RVA: 0x000F780A File Offset: 0x000F5A0A
		public FKTaperedCapsuleElem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AE83 RID: 44675 RVA: 0x000F7815 File Offset: 0x000F5A15
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKTaperedCapsuleElem(Pointer, false, true);
		}

		// Token: 0x0600AE84 RID: 44676 RVA: 0x000F781F File Offset: 0x000F5A1F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKTaperedCapsuleElem(Pointer, MemoryOwner);
		}

		// Token: 0x04005B66 RID: 23398
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KTaperedCapsuleElem";

		// Token: 0x04005B67 RID: 23399
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005B68 RID: 23400
		internal static int __PropertyOffset_Center;

		// Token: 0x04005B69 RID: 23401
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04005B6A RID: 23402
		internal static int __PropertyOffset_Radius0;

		// Token: 0x04005B6B RID: 23403
		internal static int __PropertyOffset_Radius1;

		// Token: 0x04005B6C RID: 23404
		internal static int __PropertyOffset_Length;
	}
}
