using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001666 RID: 5734
	[UnrealObjectPath("/Script/KuroAnim.KuroIKRotationConstraint")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroIKRotationConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014C55 RID: 85077 RVA: 0x001E8C18 File Offset: 0x001E6E18
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroIKRotationConstraint._ScriptStructPtr != 0) ? FKuroIKRotationConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroIKRotationConstraint", ref FKuroIKRotationConstraint._ScriptStructPtr);
		}

		// Token: 0x17005228 RID: 21032
		// (get) Token: 0x06014C56 RID: 85078 RVA: 0x001E8C3C File Offset: 0x001E6E3C
		// (set) Token: 0x06014C57 RID: 85079 RVA: 0x001E8C4C File Offset: 0x001E6E4C
		public unsafe EKuroIKRotationConstraintType Type
		{
			get
			{
				return (EKuroIKRotationConstraintType)(*(base.NativePtr + (IntPtr)FKuroIKRotationConstraint.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroIKRotationConstraint.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17005229 RID: 21033
		// (get) Token: 0x06014C58 RID: 85080 RVA: 0x001E8C5D File Offset: 0x001E6E5D
		// (set) Token: 0x06014C59 RID: 85081 RVA: 0x001E8C71 File Offset: 0x001E6E71
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroIKRotationConstraint.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroIKRotationConstraint.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x1700522A RID: 21034
		// (get) Token: 0x06014C5A RID: 85082 RVA: 0x001E8C86 File Offset: 0x001E6E86
		// (set) Token: 0x06014C5B RID: 85083 RVA: 0x001E8C96 File Offset: 0x001E6E96
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroIKRotationConstraint.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroIKRotationConstraint.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x06014C5C RID: 85084 RVA: 0x001E8CA7 File Offset: 0x001E6EA7
		public FKuroIKRotationConstraint()
		{
		}

		// Token: 0x06014C5D RID: 85085 RVA: 0x001E8CAF File Offset: 0x001E6EAF
		public FKuroIKRotationConstraint(EKuroIKRotationConstraintType Type, FVector Axis, float Angle)
		{
			this.Type = Type;
			this.Axis = Axis;
			this.Angle = Angle;
		}

		// Token: 0x06014C5E RID: 85086 RVA: 0x001E8CCC File Offset: 0x001E6ECC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroIKRotationConstraint.StaticStruct();
		}

		// Token: 0x06014C5F RID: 85087 RVA: 0x001E8CD8 File Offset: 0x001E6ED8
		[NullableContext(2)]
		public FKuroIKRotationConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014C60 RID: 85088 RVA: 0x001E8CE2 File Offset: 0x001E6EE2
		public FKuroIKRotationConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014C61 RID: 85089 RVA: 0x001E8CED File Offset: 0x001E6EED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroIKRotationConstraint(Pointer, false, true);
		}

		// Token: 0x06014C62 RID: 85090 RVA: 0x001E8CF7 File Offset: 0x001E6EF7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroIKRotationConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x0400B533 RID: 46387
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.KuroIKRotationConstraint";

		// Token: 0x0400B534 RID: 46388
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B535 RID: 46389
		internal static int __PropertyOffset_Type;

		// Token: 0x0400B536 RID: 46390
		internal static int __PropertyOffset_Axis;

		// Token: 0x0400B537 RID: 46391
		internal static int __PropertyOffset_Angle;
	}
}
