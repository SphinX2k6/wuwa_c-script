using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E07 RID: 7687
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Spline")]
	[UnrealStructLayout(592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKSC_Move_Spline : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5AD RID: 120237 RVA: 0x002B55AA File Offset: 0x002B37AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Spline._ClassPtr;
		}

		// Token: 0x0601D5AE RID: 120238 RVA: 0x002B55B8 File Offset: 0x002B37B8
		public UKSC_Move_Spline() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Spline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5AF RID: 120239 RVA: 0x002B55E0 File Offset: 0x002B37E0
		[NullableContext(1)]
		public UKSC_Move_Spline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Spline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007677 RID: 30327
		// (get) Token: 0x0601D5B0 RID: 120240 RVA: 0x002B5613 File Offset: 0x002B3813
		// (set) Token: 0x0601D5B1 RID: 120241 RVA: 0x002B5627 File Offset: 0x002B3827
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

		// Token: 0x0601D5B2 RID: 120242 RVA: 0x002B563C File Offset: 0x002B383C
		public void SetSplineWide(float Width)
		{
			UKSC_Move_Spline.__SetSplineWide_Internal(base.NativePtr, Width);
		}

		// Token: 0x0601D5B3 RID: 120243 RVA: 0x002B564A File Offset: 0x002B384A
		public void SetSplineHeight(float Height)
		{
			UKSC_Move_Spline.__SetSplineHeight_Internal(base.NativePtr, Height);
		}

		// Token: 0x0601D5B4 RID: 120244 RVA: 0x002B5658 File Offset: 0x002B3858
		public void SetSpline(USplineComponent SplineComp)
		{
			UKSC_Move_Spline.__SetSpline_Internal(base.NativePtr, (SplineComp != null) ? SplineComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D5B5 RID: 120245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineWide_Internal(IntPtr @this, float Width);

		// Token: 0x0601D5B6 RID: 120246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineHeight_Internal(IntPtr @this, float Height);

		// Token: 0x0601D5B7 RID: 120247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpline_Internal(IntPtr @this, IntPtr SplineComp);

		// Token: 0x0601D5B8 RID: 120248 RVA: 0x002B5675 File Offset: 0x002B3875
		static UKSC_Move_Spline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Spline");
		}

		// Token: 0x0601D5B9 RID: 120249 RVA: 0x002B5683 File Offset: 0x002B3883
		protected UKSC_Move_Spline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEC1 RID: 65217
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Spline";

		// Token: 0x0400FEC2 RID: 65218
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEC3 RID: 65219
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEC4 RID: 65220
		internal static int __PropertyOffset_SplineComp_;
	}
}
