using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E05 RID: 7685
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_MultiStage")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class UKSC_Move_MultiStage : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D591 RID: 120209 RVA: 0x002B5382 File Offset: 0x002B3582
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_MultiStage._ClassPtr;
		}

		// Token: 0x0601D592 RID: 120210 RVA: 0x002B5390 File Offset: 0x002B3590
		public UKSC_Move_MultiStage() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_MultiStage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D593 RID: 120211 RVA: 0x002B53B8 File Offset: 0x002B35B8
		[NullableContext(1)]
		public UKSC_Move_MultiStage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_MultiStage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007673 RID: 30323
		// (get) Token: 0x0601D594 RID: 120212 RVA: 0x002B53EB File Offset: 0x002B35EB
		// (set) Token: 0x0601D595 RID: 120213 RVA: 0x002B53FF File Offset: 0x002B35FF
		public unsafe UKSC_Move_Stage CurrentStage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Move_Stage>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_MultiStage.__PropertyOffset_CurrentStage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_MultiStage.__PropertyOffset_CurrentStage, value);
			}
		}

		// Token: 0x17007674 RID: 30324
		// (get) Token: 0x0601D596 RID: 120214 RVA: 0x002B5414 File Offset: 0x002B3614
		// (set) Token: 0x0601D597 RID: 120215 RVA: 0x002B544D File Offset: 0x002B364D
		[Nullable(1)]
		public TArray<UKSC_Move_Stage> Stages
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_Move_Stage> result;
				if ((result = this._Stages) == null)
				{
					result = (this._Stages = new TArray<UKSC_Move_Stage>(base.NativePtr + (IntPtr)UKSC_Move_MultiStage.__PropertyOffset_Stages, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Stages.CopyAssign(value);
			}
		}

		// Token: 0x17007675 RID: 30325
		// (get) Token: 0x0601D598 RID: 120216 RVA: 0x002B545B File Offset: 0x002B365B
		// (set) Token: 0x0601D599 RID: 120217 RVA: 0x002B546F File Offset: 0x002B366F
		public unsafe UKSC_DA_Move_MultiStage DA_Stages
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Move_MultiStage>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_MultiStage.__PropertyOffset_DA_Stages);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_MultiStage.__PropertyOffset_DA_Stages, value);
			}
		}

		// Token: 0x17007676 RID: 30326
		// (get) Token: 0x0601D59A RID: 120218 RVA: 0x002B5484 File Offset: 0x002B3684
		// (set) Token: 0x0601D59B RID: 120219 RVA: 0x002B5498 File Offset: 0x002B3698
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

		// Token: 0x0601D59C RID: 120220 RVA: 0x002B54AD File Offset: 0x002B36AD
		public void SwitchStage(int index)
		{
			UKSC_Move_MultiStage.__SwitchStage_Internal(base.NativePtr, index);
		}

		// Token: 0x0601D59D RID: 120221 RVA: 0x002B54BB File Offset: 0x002B36BB
		public void SetWaypointLoop(bool Loop)
		{
			UKSC_Move_MultiStage.__SetWaypointLoop_Internal(base.NativePtr, Loop);
		}

		// Token: 0x0601D59E RID: 120222 RVA: 0x002B54C9 File Offset: 0x002B36C9
		public void SetTargetEntity(AKSC_Entity Entity)
		{
			UKSC_Move_MultiStage.__SetTargetEntity_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D59F RID: 120223 RVA: 0x002B54E6 File Offset: 0x002B36E6
		public void SetSpline(USplineComponent SplineComp)
		{
			UKSC_Move_MultiStage.__SetSpline_Internal(base.NativePtr, (SplineComp != null) ? SplineComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D5A0 RID: 120224 RVA: 0x002B5503 File Offset: 0x002B3703
		public void AddWaypoint(double X, double Y)
		{
			UKSC_Move_MultiStage.__AddWaypoint_Internal(base.NativePtr, X, Y);
		}

		// Token: 0x0601D5A1 RID: 120225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchStage_Internal(IntPtr @this, int index);

		// Token: 0x0601D5A2 RID: 120226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWaypointLoop_Internal(IntPtr @this, bool Loop);

		// Token: 0x0601D5A3 RID: 120227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetEntity_Internal(IntPtr @this, IntPtr Entity);

		// Token: 0x0601D5A4 RID: 120228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpline_Internal(IntPtr @this, IntPtr SplineComp);

		// Token: 0x0601D5A5 RID: 120229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddWaypoint_Internal(IntPtr @this, double X, double Y);

		// Token: 0x0601D5A6 RID: 120230 RVA: 0x002B5512 File Offset: 0x002B3712
		static UKSC_Move_MultiStage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_MultiStage");
		}

		// Token: 0x0601D5A7 RID: 120231 RVA: 0x002B5520 File Offset: 0x002B3720
		protected UKSC_Move_MultiStage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEB6 RID: 65206
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_MultiStage";

		// Token: 0x0400FEB7 RID: 65207
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEB8 RID: 65208
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEB9 RID: 65209
		internal static int __PropertyOffset_CurrentStage;

		// Token: 0x0400FEBA RID: 65210
		internal static int __PropertyOffset_Stages;

		// Token: 0x0400FEBB RID: 65211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_Move_Stage> _Stages;

		// Token: 0x0400FEBC RID: 65212
		internal static int __PropertyOffset_DA_Stages;

		// Token: 0x0400FEBD RID: 65213
		internal static int __PropertyOffset_SplineComponent;
	}
}
