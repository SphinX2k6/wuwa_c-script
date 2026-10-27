using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E9D RID: 3741
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MatineeCameraShake")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UMatineeCameraShake : UCameraShakeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C9AF RID: 51631 RVA: 0x00125ACB File Offset: 0x00123CCB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMatineeCameraShake._ClassPtr;
		}

		// Token: 0x0600C9B0 RID: 51632 RVA: 0x00125AD8 File Offset: 0x00123CD8
		public UMatineeCameraShake() : this(BuiltinUtils.AllocNativeUObject(UMatineeCameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C9B1 RID: 51633 RVA: 0x00125B00 File Offset: 0x00123D00
		public UMatineeCameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMatineeCameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x0600C9B2 RID: 51634 RVA: 0x00125B33 File Offset: 0x00123D33
		// (set) Token: 0x0600C9B3 RID: 51635 RVA: 0x00125B43 File Offset: 0x00123D43
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

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x0600C9B4 RID: 51636 RVA: 0x00125B54 File Offset: 0x00123D54
		// (set) Token: 0x0600C9B5 RID: 51637 RVA: 0x00125B64 File Offset: 0x00123D64
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

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x0600C9B6 RID: 51638 RVA: 0x00125B75 File Offset: 0x00123D75
		// (set) Token: 0x0600C9B7 RID: 51639 RVA: 0x00125B85 File Offset: 0x00123D85
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

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x0600C9B8 RID: 51640 RVA: 0x00125B98 File Offset: 0x00123D98
		// (set) Token: 0x0600C9B9 RID: 51641 RVA: 0x00125BD1 File Offset: 0x00123DD1
		public FROscillator RotOscillation
		{
			get
			{
				base.FastCheckIsValid();
				FROscillator result;
				if ((result = this._RotOscillation) == null)
				{
					result = (this._RotOscillation = new FROscillator(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_RotOscillation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FROscillator.StaticStruct(), base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_RotOscillation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x0600C9BA RID: 51642 RVA: 0x00125BF4 File Offset: 0x00123DF4
		// (set) Token: 0x0600C9BB RID: 51643 RVA: 0x00125C2D File Offset: 0x00123E2D
		public FVOscillator LocOscillation
		{
			get
			{
				base.FastCheckIsValid();
				FVOscillator result;
				if ((result = this._LocOscillation) == null)
				{
					result = (this._LocOscillation = new FVOscillator(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_LocOscillation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVOscillator.StaticStruct(), base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_LocOscillation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x0600C9BC RID: 51644 RVA: 0x00125C50 File Offset: 0x00123E50
		// (set) Token: 0x0600C9BD RID: 51645 RVA: 0x00125C89 File Offset: 0x00123E89
		public FFOscillator FOVOscillation
		{
			get
			{
				base.FastCheckIsValid();
				FFOscillator result;
				if ((result = this._FOVOscillation) == null)
				{
					result = (this._FOVOscillation = new FFOscillator(base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_FOVOscillation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFOscillator.StaticStruct(), base.NativePtr + (IntPtr)UMatineeCameraShake.__PropertyOffset_FOVOscillation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0600C9BE RID: 51646 RVA: 0x00125CAA File Offset: 0x00123EAA
		// (set) Token: 0x0600C9BF RID: 51647 RVA: 0x00125CBA File Offset: 0x00123EBA
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

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x0600C9C0 RID: 51648 RVA: 0x00125CCB File Offset: 0x00123ECB
		// (set) Token: 0x0600C9C1 RID: 51649 RVA: 0x00125CDB File Offset: 0x00123EDB
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

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x0600C9C2 RID: 51650 RVA: 0x00125CEC File Offset: 0x00123EEC
		// (set) Token: 0x0600C9C3 RID: 51651 RVA: 0x00125CFC File Offset: 0x00123EFC
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

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x0600C9C4 RID: 51652 RVA: 0x00125D0D File Offset: 0x00123F0D
		// (set) Token: 0x0600C9C5 RID: 51653 RVA: 0x00125D1D File Offset: 0x00123F1D
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

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x0600C9C6 RID: 51654 RVA: 0x00125D2E File Offset: 0x00123F2E
		// (set) Token: 0x0600C9C7 RID: 51655 RVA: 0x00125D3E File Offset: 0x00123F3E
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

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x0600C9C8 RID: 51656 RVA: 0x00125D4F File Offset: 0x00123F4F
		// (set) Token: 0x0600C9C9 RID: 51657 RVA: 0x00125D5F File Offset: 0x00123F5F
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

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x0600C9CA RID: 51658 RVA: 0x00125D70 File Offset: 0x00123F70
		// (set) Token: 0x0600C9CB RID: 51659 RVA: 0x00125D80 File Offset: 0x00123F80
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

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x0600C9CC RID: 51660 RVA: 0x00125D91 File Offset: 0x00123F91
		// (set) Token: 0x0600C9CD RID: 51661 RVA: 0x00125DA5 File Offset: 0x00123FA5
		[Nullable(2)]
		public unsafe UCameraAnim Anim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraAnim>(base.NativePtr / (IntPtr)sizeof(void*) + UMatineeCameraShake.__PropertyOffset_Anim);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMatineeCameraShake.__PropertyOffset_Anim, value);
			}
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x0600C9CE RID: 51662 RVA: 0x00125DBA File Offset: 0x00123FBA
		// (set) Token: 0x0600C9CF RID: 51663 RVA: 0x00125DD3 File Offset: 0x00123FD3
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

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x0600C9D0 RID: 51664 RVA: 0x00125E03 File Offset: 0x00124003
		// (set) Token: 0x0600C9D1 RID: 51665 RVA: 0x00125E13 File Offset: 0x00124013
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

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x0600C9D2 RID: 51666 RVA: 0x00125E24 File Offset: 0x00124024
		// (set) Token: 0x0600C9D3 RID: 51667 RVA: 0x00125E34 File Offset: 0x00124034
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

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x0600C9D4 RID: 51668 RVA: 0x00125E45 File Offset: 0x00124045
		// (set) Token: 0x0600C9D5 RID: 51669 RVA: 0x00125E59 File Offset: 0x00124059
		[Nullable(2)]
		public unsafe UCameraAnimInst AnimInst
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraAnimInst>(base.NativePtr / (IntPtr)sizeof(void*) + UMatineeCameraShake.__PropertyOffset_AnimInst);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMatineeCameraShake.__PropertyOffset_AnimInst, value);
			}
		}

		// Token: 0x0600C9D6 RID: 51670 RVA: 0x00125E6E File Offset: 0x0012406E
		public virtual void ReceiveStopShake(bool bImmediately)
		{
			UMatineeCameraShake.__ReceiveStopShake_Internal(base.NativePtr, bImmediately);
		}

		// Token: 0x0600C9D7 RID: 51671 RVA: 0x00125E7C File Offset: 0x0012407C
		public virtual void ReceivePlayShake(float Scale)
		{
			UMatineeCameraShake.__ReceivePlayShake_Internal(base.NativePtr, Scale);
		}

		// Token: 0x0600C9D8 RID: 51672 RVA: 0x00125E8A File Offset: 0x0012408A
		public virtual bool ReceiveIsFinished()
		{
			return UMatineeCameraShake.__ReceiveIsFinished_Internal(base.NativePtr);
		}

		// Token: 0x0600C9D9 RID: 51673 RVA: 0x00125E97 File Offset: 0x00124097
		protected virtual bool ReceiveIsFinished_Implementation()
		{
			return UMatineeCameraShake.__ReceiveIsFinished_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0600C9DA RID: 51674 RVA: 0x00125EA4 File Offset: 0x001240A4
		[NullableContext(2)]
		public virtual void BlueprintUpdateCameraShake(float DeltaTime, float Alpha, in FMinimalViewInfo POV, ref FMinimalViewInfo ModifiedPOV)
		{
			UMatineeCameraShake.__BlueprintUpdateCameraShake_Internal(base.NativePtr, DeltaTime, Alpha, (POV ?? new FMinimalViewInfo()).NativePtr, (ModifiedPOV ?? new FMinimalViewInfo()).NativePtr);
		}

		// Token: 0x0600C9DB RID: 51675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveStopShake_Internal(IntPtr @this, bool bImmediately);

		// Token: 0x0600C9DC RID: 51676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePlayShake_Internal(IntPtr @this, float Scale);

		// Token: 0x0600C9DD RID: 51677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReceiveIsFinished_Internal(IntPtr @this);

		// Token: 0x0600C9DE RID: 51678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReceiveIsFinished_Implementation_Internal(IntPtr @this);

		// Token: 0x0600C9DF RID: 51679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintUpdateCameraShake_Internal(IntPtr @this, float DeltaTime, float Alpha, IntPtr POV, IntPtr ModifiedPOV);

		// Token: 0x0600C9E0 RID: 51680 RVA: 0x00125ED4 File Offset: 0x001240D4
		static UMatineeCameraShake()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MatineeCameraShake");
		}

		// Token: 0x0600C9E1 RID: 51681 RVA: 0x00125EE2 File Offset: 0x001240E2
		protected UMatineeCameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006C91 RID: 27793
		public new const string __ObjectPath = "/Script/Engine.MatineeCameraShake";

		// Token: 0x04006C92 RID: 27794
		private static IntPtr _ClassPtr;

		// Token: 0x04006C93 RID: 27795
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006C94 RID: 27796
		internal static int __PropertyOffset_OscillationDuration;

		// Token: 0x04006C95 RID: 27797
		internal static int __PropertyOffset_OscillationBlendInTime;

		// Token: 0x04006C96 RID: 27798
		internal static int __PropertyOffset_OscillationBlendOutTime;

		// Token: 0x04006C97 RID: 27799
		internal static int __PropertyOffset_RotOscillation;

		// Token: 0x04006C98 RID: 27800
		[Nullable(2)]
		private FROscillator _RotOscillation;

		// Token: 0x04006C99 RID: 27801
		internal static int __PropertyOffset_LocOscillation;

		// Token: 0x04006C9A RID: 27802
		[Nullable(2)]
		private FVOscillator _LocOscillation;

		// Token: 0x04006C9B RID: 27803
		internal static int __PropertyOffset_FOVOscillation;

		// Token: 0x04006C9C RID: 27804
		[Nullable(2)]
		private FFOscillator _FOVOscillation;

		// Token: 0x04006C9D RID: 27805
		internal static int __PropertyOffset_Priority;

		// Token: 0x04006C9E RID: 27806
		internal static int __PropertyOffset_Group;

		// Token: 0x04006C9F RID: 27807
		internal static int __PropertyOffset_AnimPlayRate;

		// Token: 0x04006CA0 RID: 27808
		internal static int __PropertyOffset_AnimScale;

		// Token: 0x04006CA1 RID: 27809
		internal static int __PropertyOffset_AnimBlendInTime;

		// Token: 0x04006CA2 RID: 27810
		internal static int __PropertyOffset_AnimBlendOutTime;

		// Token: 0x04006CA3 RID: 27811
		internal static int __PropertyOffset_RandomAnimSegmentDuration;

		// Token: 0x04006CA4 RID: 27812
		internal static int __PropertyOffset_Anim;

		// Token: 0x04006CA5 RID: 27813
		internal static int __PropertyOffset_bRandomAnimSegment;

		// Token: 0x04006CA6 RID: 27814
		internal static byte __PropertyMask_bRandomAnimSegment;

		// Token: 0x04006CA7 RID: 27815
		internal static int __PropertyOffset_OscillatorTimeRemaining;

		// Token: 0x04006CA8 RID: 27816
		internal static int __PropertyOffset_OscillatorEplasedTime;

		// Token: 0x04006CA9 RID: 27817
		internal static int __PropertyOffset_AnimInst;

		// Token: 0x02002D46 RID: 11590
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveStopShake_FunctionParams
		{
			// Token: 0x0401674E RID: 91982
			[FieldOffset(0)]
			public bool bImmediately;
		}

		// Token: 0x02002D47 RID: 11591
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ReceivePlayShake_FunctionParams
		{
			// Token: 0x0401674F RID: 91983
			[FieldOffset(0)]
			public float Scale;
		}

		// Token: 0x02002D48 RID: 11592
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveIsFinished_FunctionParams
		{
			// Token: 0x04016750 RID: 91984
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002D49 RID: 11593
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5488)]
		protected ref struct __BlueprintUpdateCameraShake_FunctionParams
		{
			// Token: 0x04016751 RID: 91985
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04016752 RID: 91986
			[FieldOffset(4)]
			public float Alpha;

			// Token: 0x04016753 RID: 91987
			[FieldOffset(16)]
			public byte POV;

			// Token: 0x04016754 RID: 91988
			[FieldOffset(2752)]
			public byte ModifiedPOV;
		}
	}
}
