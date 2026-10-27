using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E35 RID: 7733
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Bar")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class AKSC_Shape2D_Entity_Bar : AKSC_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D774 RID: 120692 RVA: 0x002B83B2 File Offset: 0x002B65B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_Bar._ClassPtr;
		}

		// Token: 0x0601D775 RID: 120693 RVA: 0x002B83C0 File Offset: 0x002B65C0
		public AKSC_Shape2D_Entity_Bar() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Bar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D776 RID: 120694 RVA: 0x002B83E8 File Offset: 0x002B65E8
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_Bar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Bar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076C3 RID: 30403
		// (get) Token: 0x0601D777 RID: 120695 RVA: 0x002B841B File Offset: 0x002B661B
		// (set) Token: 0x0601D778 RID: 120696 RVA: 0x002B842B File Offset: 0x002B662B
		public unsafe EKSC_ShapeBarSide Side
		{
			get
			{
				return (EKSC_ShapeBarSide)(*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_Side));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_Side) = (byte)value;
			}
		}

		// Token: 0x170076C4 RID: 30404
		// (get) Token: 0x0601D779 RID: 120697 RVA: 0x002B843C File Offset: 0x002B663C
		// (set) Token: 0x0601D77A RID: 120698 RVA: 0x002B844C File Offset: 0x002B664C
		public unsafe bool IsShowLaunchDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_IsShowLaunchDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_IsShowLaunchDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x170076C5 RID: 30405
		// (get) Token: 0x0601D77B RID: 120699 RVA: 0x002B845D File Offset: 0x002B665D
		// (set) Token: 0x0601D77C RID: 120700 RVA: 0x002B8471 File Offset: 0x002B6671
		public unsafe FVector LaunchStartPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_LaunchStartPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_LaunchStartPoint) = value;
			}
		}

		// Token: 0x170076C6 RID: 30406
		// (get) Token: 0x0601D77D RID: 120701 RVA: 0x002B8486 File Offset: 0x002B6686
		// (set) Token: 0x0601D77E RID: 120702 RVA: 0x002B8496 File Offset: 0x002B6696
		public unsafe float LaunchRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_LaunchRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_LaunchRotation) = value;
			}
		}

		// Token: 0x170076C7 RID: 30407
		// (get) Token: 0x0601D77F RID: 120703 RVA: 0x002B84A7 File Offset: 0x002B66A7
		// (set) Token: 0x0601D780 RID: 120704 RVA: 0x002B84BB File Offset: 0x002B66BB
		[Nullable(2)]
		public unsafe UCurveFloat DirectionCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity_Bar.__PropertyOffset_DirectionCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity_Bar.__PropertyOffset_DirectionCurve, value);
			}
		}

		// Token: 0x0601D781 RID: 120705 RVA: 0x002B84D0 File Offset: 0x002B66D0
		public void TriggerBar()
		{
			AKSC_Shape2D_Entity_Bar.__TriggerBar_Internal(base.NativePtr);
		}

		// Token: 0x0601D782 RID: 120706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerBar_Internal(IntPtr @this);

		// Token: 0x0601D783 RID: 120707 RVA: 0x002B84DD File Offset: 0x002B66DD
		static AKSC_Shape2D_Entity_Bar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Bar");
		}

		// Token: 0x0601D784 RID: 120708 RVA: 0x002B84EB File Offset: 0x002B66EB
		protected AKSC_Shape2D_Entity_Bar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF9C RID: 65436
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Bar";

		// Token: 0x0400FF9D RID: 65437
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF9E RID: 65438
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF9F RID: 65439
		internal static int __PropertyOffset_Side;

		// Token: 0x0400FFA0 RID: 65440
		internal static int __PropertyOffset_IsShowLaunchDirection;

		// Token: 0x0400FFA1 RID: 65441
		internal static int __PropertyOffset_LaunchStartPoint;

		// Token: 0x0400FFA2 RID: 65442
		internal static int __PropertyOffset_LaunchRotation;

		// Token: 0x0400FFA3 RID: 65443
		internal static int __PropertyOffset_DirectionCurve;
	}
}
