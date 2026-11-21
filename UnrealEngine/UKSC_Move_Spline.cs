using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000582 RID: 1410
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Spline")]
	[UnrealStructLayout(592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKSC_Move_Spline : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007FFC RID: 32764 RVA: 0x000BD3B0 File Offset: 0x000BB5B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Spline._ClassPtr;
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x000BD3BC File Offset: 0x000BB5BC
		public UKSC_Move_Spline() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Spline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x000BD3E4 File Offset: 0x000BB5E4
		[NullableContext(1)]
		public UKSC_Move_Spline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Spline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06007FFF RID: 32767 RVA: 0x000BD417 File Offset: 0x000BB617
		// (set) Token: 0x06008000 RID: 32768 RVA: 0x000BD42B File Offset: 0x000BB62B
		public unsafe USplineComponent SplineComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_Spline.__PropertyOffset_SplineComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_Spline.__PropertyOffset_SplineComp_, value);
			}
		}

		// Token: 0x06008001 RID: 32769 RVA: 0x000BD440 File Offset: 0x000BB640
		public void SetSplineWide(float Width)
		{
			UKSC_Move_Spline.__SetSplineWide_Internal(base.NativePtr, Width);
		}

		// Token: 0x06008002 RID: 32770 RVA: 0x000BD44E File Offset: 0x000BB64E
		public void SetSplineHeight(float Height)
		{
			UKSC_Move_Spline.__SetSplineHeight_Internal(base.NativePtr, Height);
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x000BD45C File Offset: 0x000BB65C
		public void SetSpline(USplineComponent SplineComp)
		{
			UKSC_Move_Spline.__SetSpline_Internal(base.NativePtr, (SplineComp != null) ? SplineComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008004 RID: 32772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineWide_Internal(IntPtr @this, float Width);

		// Token: 0x06008005 RID: 32773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineHeight_Internal(IntPtr @this, float Height);

		// Token: 0x06008006 RID: 32774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpline_Internal(IntPtr @this, IntPtr SplineComp);

		// Token: 0x06008007 RID: 32775 RVA: 0x000BD479 File Offset: 0x000BB679
		static UKSC_Move_Spline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Spline");
		}

		// Token: 0x06008008 RID: 32776 RVA: 0x000BD487 File Offset: 0x000BB687
		protected UKSC_Move_Spline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037E0 RID: 14304
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Spline";

		// Token: 0x040037E1 RID: 14305
		private static IntPtr _ClassPtr;

		// Token: 0x040037E2 RID: 14306
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037E3 RID: 14307
		internal static int __PropertyOffset_SplineComp_;
	}
}
