using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023F RID: 575
	[UnrealObjectPath("/Script/Engine.MatineeCameraShake")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UMatineeCameraShake : UCameraShakeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003141 RID: 12609 RVA: 0x000462DF File Offset: 0x000444DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMatineeCameraShake._ClassPtr;
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x000462EC File Offset: 0x000444EC
		public UMatineeCameraShake() : this(BuiltinUtils.AllocNativeUObject(UMatineeCameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x00046314 File Offset: 0x00044514
		[NullableContext(1)]
		public UMatineeCameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMatineeCameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x00046347 File Offset: 0x00044547
		// (set) Token: 0x06003145 RID: 12613 RVA: 0x00046357 File Offset: 0x00044557
		public unsafe float OscillationDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillationDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillationDuration) = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x00046368 File Offset: 0x00044568
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x00046378 File Offset: 0x00044578
		public unsafe float OscillationBlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillationBlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillationBlendInTime) = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x00046389 File Offset: 0x00044589
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x00046399 File Offset: 0x00044599
		public unsafe float OscillationBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillationBlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillationBlendOutTime) = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x000463AA File Offset: 0x000445AA
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x000463BA File Offset: 0x000445BA
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x000463CB File Offset: 0x000445CB
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x000463DB File Offset: 0x000445DB
		public unsafe int Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x000463EC File Offset: 0x000445EC
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x000463FC File Offset: 0x000445FC
		public unsafe float AnimPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_AnimPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_AnimPlayRate) = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x0004640D File Offset: 0x0004460D
		// (set) Token: 0x06003151 RID: 12625 RVA: 0x0004641D File Offset: 0x0004461D
		public unsafe float AnimScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_AnimScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_AnimScale) = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06003152 RID: 12626 RVA: 0x0004642E File Offset: 0x0004462E
		// (set) Token: 0x06003153 RID: 12627 RVA: 0x0004643E File Offset: 0x0004463E
		public unsafe float AnimBlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_AnimBlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_AnimBlendInTime) = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06003154 RID: 12628 RVA: 0x0004644F File Offset: 0x0004464F
		// (set) Token: 0x06003155 RID: 12629 RVA: 0x0004645F File Offset: 0x0004465F
		public unsafe float AnimBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_AnimBlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_AnimBlendOutTime) = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x00046470 File Offset: 0x00044670
		// (set) Token: 0x06003157 RID: 12631 RVA: 0x00046480 File Offset: 0x00044680
		public unsafe float RandomAnimSegmentDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_RandomAnimSegmentDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_RandomAnimSegmentDuration) = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06003158 RID: 12632 RVA: 0x00046491 File Offset: 0x00044691
		// (set) Token: 0x06003159 RID: 12633 RVA: 0x000464AA File Offset: 0x000446AA
		public unsafe bool bRandomAnimSegment
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_bRandomAnimSegment) & UMatineeCameraShake.__PropertyMask_bRandomAnimSegment) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_bRandomAnimSegment) = ((*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_bRandomAnimSegment) & ~UMatineeCameraShake.__PropertyMask_bRandomAnimSegment) | (value ? UMatineeCameraShake.__PropertyMask_bRandomAnimSegment : 0));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600315A RID: 12634 RVA: 0x000464DA File Offset: 0x000446DA
		// (set) Token: 0x0600315B RID: 12635 RVA: 0x000464EA File Offset: 0x000446EA
		public unsafe float OscillatorTimeRemaining
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillatorTimeRemaining);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillatorTimeRemaining) = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x000464FB File Offset: 0x000446FB
		// (set) Token: 0x0600315D RID: 12637 RVA: 0x0004650B File Offset: 0x0004470B
		public unsafe float OscillatorEplasedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillatorEplasedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_OscillatorEplasedTime) = value;
			}
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x0004651C File Offset: 0x0004471C
		public virtual void ReceiveStopShake(bool bImmediately)
		{
			UMatineeCameraShake.__ReceiveStopShake_Internal(base.NativePtr, bImmediately);
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0004652A File Offset: 0x0004472A
		public virtual void ReceivePlayShake(float Scale)
		{
			UMatineeCameraShake.__ReceivePlayShake_Internal(base.NativePtr, Scale);
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00046538 File Offset: 0x00044738
		public virtual bool ReceiveIsFinished()
		{
			return UMatineeCameraShake.__ReceiveIsFinished_Internal(base.NativePtr);
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00046545 File Offset: 0x00044745
		protected virtual bool ReceiveIsFinished_Implementation()
		{
			return UMatineeCameraShake.__ReceiveIsFinished_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06003162 RID: 12642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveStopShake_Internal(IntPtr @this, bool bImmediately);

		// Token: 0x06003163 RID: 12643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePlayShake_Internal(IntPtr @this, float Scale);

		// Token: 0x06003164 RID: 12644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReceiveIsFinished_Internal(IntPtr @this);

		// Token: 0x06003165 RID: 12645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReceiveIsFinished_Implementation_Internal(IntPtr @this);

		// Token: 0x06003166 RID: 12646 RVA: 0x00046552 File Offset: 0x00044752
		static UMatineeCameraShake()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MatineeCameraShake");
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00046560 File Offset: 0x00044760
		protected UMatineeCameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040010DF RID: 4319
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MatineeCameraShake";

		// Token: 0x040010E0 RID: 4320
		private static IntPtr _ClassPtr;

		// Token: 0x040010E1 RID: 4321
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040010E2 RID: 4322
		internal static int __PropertyOffset_OscillationDuration;

		// Token: 0x040010E3 RID: 4323
		internal static int __PropertyOffset_OscillationBlendInTime;

		// Token: 0x040010E4 RID: 4324
		internal static int __PropertyOffset_OscillationBlendOutTime;

		// Token: 0x040010E5 RID: 4325
		internal static int __PropertyOffset_Priority;

		// Token: 0x040010E6 RID: 4326
		internal static int __PropertyOffset_Group;

		// Token: 0x040010E7 RID: 4327
		internal static int __PropertyOffset_AnimPlayRate;

		// Token: 0x040010E8 RID: 4328
		internal static int __PropertyOffset_AnimScale;

		// Token: 0x040010E9 RID: 4329
		internal static int __PropertyOffset_AnimBlendInTime;

		// Token: 0x040010EA RID: 4330
		internal static int __PropertyOffset_AnimBlendOutTime;

		// Token: 0x040010EB RID: 4331
		internal static int __PropertyOffset_RandomAnimSegmentDuration;

		// Token: 0x040010EC RID: 4332
		internal static int __PropertyOffset_bRandomAnimSegment;

		// Token: 0x040010ED RID: 4333
		internal static byte __PropertyMask_bRandomAnimSegment;

		// Token: 0x040010EE RID: 4334
		internal static int __PropertyOffset_OscillatorTimeRemaining;

		// Token: 0x040010EF RID: 4335
		internal static int __PropertyOffset_OscillatorEplasedTime;

		// Token: 0x020009BF RID: 2495
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveStopShake_FunctionParams
		{
			// Token: 0x0400594A RID: 22858
			[FieldOffset(0)]
			public bool bImmediately;
		}

		// Token: 0x020009C0 RID: 2496
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ReceivePlayShake_FunctionParams
		{
			// Token: 0x0400594B RID: 22859
			[FieldOffset(0)]
			public float Scale;
		}

		// Token: 0x020009C1 RID: 2497
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveIsFinished_FunctionParams
		{
			// Token: 0x0400594C RID: 22860
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
