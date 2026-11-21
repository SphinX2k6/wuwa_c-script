using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000581 RID: 1409
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_MultiStage")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class UKSC_Move_MultiStage : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007FEB RID: 32747 RVA: 0x000BD2A2 File Offset: 0x000BB4A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_MultiStage._ClassPtr;
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x000BD2B0 File Offset: 0x000BB4B0
		public UKSC_Move_MultiStage() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_MultiStage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x000BD2D8 File Offset: 0x000BB4D8
		[NullableContext(1)]
		public UKSC_Move_MultiStage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_MultiStage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06007FEE RID: 32750 RVA: 0x000BD30B File Offset: 0x000BB50B
		// (set) Token: 0x06007FEF RID: 32751 RVA: 0x000BD31F File Offset: 0x000BB51F
		public unsafe USplineComponent SplineComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_MultiStage.__PropertyOffset_SplineComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_MultiStage.__PropertyOffset_SplineComponent, value);
			}
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x000BD334 File Offset: 0x000BB534
		public void SwitchStage(int index)
		{
			UKSC_Move_MultiStage.__SwitchStage_Internal(base.NativePtr, index);
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x000BD342 File Offset: 0x000BB542
		public void SetWaypointLoop(bool Loop)
		{
			UKSC_Move_MultiStage.__SetWaypointLoop_Internal(base.NativePtr, Loop);
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x000BD350 File Offset: 0x000BB550
		public void SetTargetEntity(AKSC_Entity Entity)
		{
			UKSC_Move_MultiStage.__SetTargetEntity_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x000BD36D File Offset: 0x000BB56D
		public void SetSpline(USplineComponent SplineComp)
		{
			UKSC_Move_MultiStage.__SetSpline_Internal(base.NativePtr, (SplineComp != null) ? SplineComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x000BD38A File Offset: 0x000BB58A
		public void AddWaypoint(double X, double Y)
		{
			UKSC_Move_MultiStage.__AddWaypoint_Internal(base.NativePtr, X, Y);
		}

		// Token: 0x06007FF5 RID: 32757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchStage_Internal(IntPtr @this, int index);

		// Token: 0x06007FF6 RID: 32758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWaypointLoop_Internal(IntPtr @this, bool Loop);

		// Token: 0x06007FF7 RID: 32759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetEntity_Internal(IntPtr @this, IntPtr Entity);

		// Token: 0x06007FF8 RID: 32760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpline_Internal(IntPtr @this, IntPtr SplineComp);

		// Token: 0x06007FF9 RID: 32761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddWaypoint_Internal(IntPtr @this, double X, double Y);

		// Token: 0x06007FFA RID: 32762 RVA: 0x000BD399 File Offset: 0x000BB599
		static UKSC_Move_MultiStage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_MultiStage");
		}

		// Token: 0x06007FFB RID: 32763 RVA: 0x000BD3A7 File Offset: 0x000BB5A7
		protected UKSC_Move_MultiStage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037DC RID: 14300
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_MultiStage";

		// Token: 0x040037DD RID: 14301
		private static IntPtr _ClassPtr;

		// Token: 0x040037DE RID: 14302
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037DF RID: 14303
		internal static int __PropertyOffset_SplineComponent;
	}
}
