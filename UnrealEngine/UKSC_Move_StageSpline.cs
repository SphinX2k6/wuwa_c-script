using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E0E RID: 7694
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_StageSpline")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UKSC_Move_StageSpline : UKSC_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5E4 RID: 120292 RVA: 0x002B5ABA File Offset: 0x002B3CBA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_StageSpline._ClassPtr;
		}

		// Token: 0x0601D5E5 RID: 120293 RVA: 0x002B5AC8 File Offset: 0x002B3CC8
		public UKSC_Move_StageSpline() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageSpline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5E6 RID: 120294 RVA: 0x002B5AF0 File Offset: 0x002B3CF0
		[NullableContext(1)]
		public UKSC_Move_StageSpline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700767E RID: 30334
		// (get) Token: 0x0601D5E7 RID: 120295 RVA: 0x002B5B23 File Offset: 0x002B3D23
		// (set) Token: 0x0601D5E8 RID: 120296 RVA: 0x002B5B37 File Offset: 0x002B3D37
		[Nullable(2)]
		public unsafe USplineComponent SplineComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_StageSpline.__PropertyOffset_SplineComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_StageSpline.__PropertyOffset_SplineComponent, value);
			}
		}

		// Token: 0x0601D5E9 RID: 120297 RVA: 0x002B5B4C File Offset: 0x002B3D4C
		static UKSC_Move_StageSpline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_StageSpline");
		}

		// Token: 0x0601D5EA RID: 120298 RVA: 0x002B5B5A File Offset: 0x002B3D5A
		protected UKSC_Move_StageSpline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEDF RID: 65247
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_StageSpline";

		// Token: 0x0400FEE0 RID: 65248
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEE1 RID: 65249
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEE2 RID: 65250
		internal static int __PropertyOffset_SplineComponent;
	}
}
