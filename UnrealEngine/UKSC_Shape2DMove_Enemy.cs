using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E30 RID: 7728
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2DMove_Enemy")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UKSC_Shape2DMove_Enemy : UKSC_Move, IUnrealUObject, IUnrealObject, IKSC_Shape2DCustomMoveInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D72E RID: 120622 RVA: 0x002B7EBE File Offset: 0x002B60BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Shape2DMove_Enemy._ClassPtr;
		}

		// Token: 0x0601D72F RID: 120623 RVA: 0x002B7ECA File Offset: 0x002B60CA
		int IKSC_Shape2DCustomMoveInterface.InterfaceOffset()
		{
			return UKSC_Shape2DMove_Enemy.__InterfaceOffset_IKSC_Shape2DCustomMoveInterface;
		}

		// Token: 0x0601D730 RID: 120624 RVA: 0x002B7ED4 File Offset: 0x002B60D4
		public UKSC_Shape2DMove_Enemy() : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DMove_Enemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D731 RID: 120625 RVA: 0x002B7EFC File Offset: 0x002B60FC
		[NullableContext(1)]
		public UKSC_Shape2DMove_Enemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DMove_Enemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076B3 RID: 30387
		// (get) Token: 0x0601D732 RID: 120626 RVA: 0x002B7F2F File Offset: 0x002B612F
		// (set) Token: 0x0601D733 RID: 120627 RVA: 0x002B7F43 File Offset: 0x002B6143
		[Nullable(2)]
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove_Enemy.__PropertyOffset_KscShapeWorld);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove_Enemy.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x170076B4 RID: 30388
		// (get) Token: 0x0601D734 RID: 120628 RVA: 0x002B7F58 File Offset: 0x002B6158
		// (set) Token: 0x0601D735 RID: 120629 RVA: 0x002B7F6C File Offset: 0x002B616C
		[Nullable(2)]
		public unsafe UCurveFloat MovementCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove_Enemy.__PropertyOffset_MovementCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DMove_Enemy.__PropertyOffset_MovementCurve, value);
			}
		}

		// Token: 0x0601D736 RID: 120630 RVA: 0x002B7F81 File Offset: 0x002B6181
		static UKSC_Shape2DMove_Enemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2DMove_Enemy");
		}

		// Token: 0x0601D737 RID: 120631 RVA: 0x002B7F8F File Offset: 0x002B618F
		protected UKSC_Shape2DMove_Enemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF7E RID: 65406
		internal static int __InterfaceOffset_IKSC_Shape2DCustomMoveInterface;

		// Token: 0x0400FF7F RID: 65407
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2DMove_Enemy";

		// Token: 0x0400FF80 RID: 65408
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF81 RID: 65409
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF82 RID: 65410
		internal static int __PropertyOffset_KscShapeWorld;

		// Token: 0x0400FF83 RID: 65411
		internal static int __PropertyOffset_MovementCurve;
	}
}
