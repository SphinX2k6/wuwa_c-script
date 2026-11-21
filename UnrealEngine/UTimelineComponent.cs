using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A2 RID: 674
	[UnrealObjectPath("/Script/Engine.TimelineComponent")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UTimelineComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060049C0 RID: 18880 RVA: 0x000676E2 File Offset: 0x000658E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTimelineComponent._ClassPtr;
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x000676F0 File Offset: 0x000658F0
		public UTimelineComponent() : this(BuiltinUtils.AllocNativeUObject(UTimelineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00067718 File Offset: 0x00065918
		[NullableContext(1)]
		public UTimelineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTimelineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x0006774B File Offset: 0x0006594B
		// (set) Token: 0x060049C4 RID: 18884 RVA: 0x00067764 File Offset: 0x00065964
		public unsafe bool bIgnoreTimeDilation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTimelineComponent.__PropertyOffset_bIgnoreTimeDilation) & UTimelineComponent.__PropertyMask_bIgnoreTimeDilation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTimelineComponent.__PropertyOffset_bIgnoreTimeDilation) = ((*(base.NativePtr + (IntPtr)UTimelineComponent.__PropertyOffset_bIgnoreTimeDilation) & ~UTimelineComponent.__PropertyMask_bIgnoreTimeDilation) | (value ? UTimelineComponent.__PropertyMask_bIgnoreTimeDilation : 0));
			}
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x00067794 File Offset: 0x00065994
		public void Stop()
		{
			UTimelineComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x000677A1 File Offset: 0x000659A1
		[NullableContext(2)]
		public void SetVectorCurve(UCurveVector NewVectorCurve, FName VectorTrackName)
		{
			UTimelineComponent.__SetVectorCurve_Internal(base.NativePtr, (NewVectorCurve != null) ? NewVectorCurve.NativePtr : IntPtr.Zero, VectorTrackName);
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x000677BF File Offset: 0x000659BF
		public void SetTimelineLength(float NewLength)
		{
			UTimelineComponent.__SetTimelineLength_Internal(base.NativePtr, NewLength);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x000677CD File Offset: 0x000659CD
		public void SetPlayRate(float NewRate)
		{
			UTimelineComponent.__SetPlayRate_Internal(base.NativePtr, NewRate);
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x000677DB File Offset: 0x000659DB
		public void SetPlaybackPosition(float NewPosition, bool bFireEvents, bool bFireUpdate = true)
		{
			UTimelineComponent.__SetPlaybackPosition_Internal(base.NativePtr, NewPosition, bFireEvents, bFireUpdate);
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x000677EB File Offset: 0x000659EB
		public void SetNewTime(float NewTime)
		{
			UTimelineComponent.__SetNewTime_Internal(base.NativePtr, NewTime);
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x000677F9 File Offset: 0x000659F9
		public void SetLooping(bool bNewLooping)
		{
			UTimelineComponent.__SetLooping_Internal(base.NativePtr, bNewLooping);
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x00067807 File Offset: 0x00065A07
		public void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation)
		{
			UTimelineComponent.__SetIgnoreTimeDilation_Internal(base.NativePtr, bNewIgnoreTimeDilation);
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x00067815 File Offset: 0x00065A15
		[NullableContext(2)]
		public void SetFloatCurve(UCurveFloat NewFloatCurve, FName FloatTrackName)
		{
			UTimelineComponent.__SetFloatCurve_Internal(base.NativePtr, (NewFloatCurve != null) ? NewFloatCurve.NativePtr : IntPtr.Zero, FloatTrackName);
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x00067833 File Offset: 0x00065A33
		public void ReverseFromEnd()
		{
			UTimelineComponent.__ReverseFromEnd_Internal(base.NativePtr);
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00067840 File Offset: 0x00065A40
		public void Reverse()
		{
			UTimelineComponent.__Reverse_Internal(base.NativePtr);
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x0006784D File Offset: 0x00065A4D
		public void PlayFromStart()
		{
			UTimelineComponent.__PlayFromStart_Internal(base.NativePtr);
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x0006785A File Offset: 0x00065A5A
		public void Play()
		{
			UTimelineComponent.__Play_Internal(base.NativePtr);
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x00067867 File Offset: 0x00065A67
		[SkipLocalsInit]
		public void OnRep_Timeline()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTimelineComponent.__OnRep_Timeline_NativeFunctionPtr, null);
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x0006787B File Offset: 0x00065A7B
		public void MoveInterpFloatForLastKey(FName FloatTrackName, float Time)
		{
			UTimelineComponent.__MoveInterpFloatForLastKey_Internal(base.NativePtr, FloatTrackName, Time);
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x0006788A File Offset: 0x00065A8A
		public bool IsReversing()
		{
			return UTimelineComponent.__IsReversing_Internal(base.NativePtr);
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x00067897 File Offset: 0x00065A97
		public bool IsPlaying()
		{
			return UTimelineComponent.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x000678A4 File Offset: 0x00065AA4
		public bool IsLooping()
		{
			return UTimelineComponent.__IsLooping_Internal(base.NativePtr);
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x000678B1 File Offset: 0x00065AB1
		public float GetTimelineLength()
		{
			return UTimelineComponent.__GetTimelineLength_Internal(base.NativePtr);
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x000678BE File Offset: 0x00065ABE
		public float GetPlayRate()
		{
			return UTimelineComponent.__GetPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x000678CB File Offset: 0x00065ACB
		public float GetPlaybackPosition()
		{
			return UTimelineComponent.__GetPlaybackPosition_Internal(base.NativePtr);
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x000678D8 File Offset: 0x00065AD8
		public bool GetIgnoreTimeDilation()
		{
			return UTimelineComponent.__GetIgnoreTimeDilation_Internal(base.NativePtr);
		}

		// Token: 0x060049DB RID: 18907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060049DC RID: 18908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorCurve_Internal(IntPtr @this, IntPtr NewVectorCurve, FName VectorTrackName);

		// Token: 0x060049DD RID: 18909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimelineLength_Internal(IntPtr @this, float NewLength);

		// Token: 0x060049DE RID: 18910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRate_Internal(IntPtr @this, float NewRate);

		// Token: 0x060049DF RID: 18911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackPosition_Internal(IntPtr @this, float NewPosition, bool bFireEvents, bool bFireUpdate);

		// Token: 0x060049E0 RID: 18912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNewTime_Internal(IntPtr @this, float NewTime);

		// Token: 0x060049E1 RID: 18913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLooping_Internal(IntPtr @this, bool bNewLooping);

		// Token: 0x060049E2 RID: 18914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreTimeDilation_Internal(IntPtr @this, bool bNewIgnoreTimeDilation);

		// Token: 0x060049E3 RID: 18915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatCurve_Internal(IntPtr @this, IntPtr NewFloatCurve, FName FloatTrackName);

		// Token: 0x060049E4 RID: 18916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReverseFromEnd_Internal(IntPtr @this);

		// Token: 0x060049E5 RID: 18917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Reverse_Internal(IntPtr @this);

		// Token: 0x060049E6 RID: 18918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayFromStart_Internal(IntPtr @this);

		// Token: 0x060049E7 RID: 18919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x060049E8 RID: 18920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveInterpFloatForLastKey_Internal(IntPtr @this, FName FloatTrackName, float Time);

		// Token: 0x060049E9 RID: 18921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsReversing_Internal(IntPtr @this);

		// Token: 0x060049EA RID: 18922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x060049EB RID: 18923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLooping_Internal(IntPtr @this);

		// Token: 0x060049EC RID: 18924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimelineLength_Internal(IntPtr @this);

		// Token: 0x060049ED RID: 18925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayRate_Internal(IntPtr @this);

		// Token: 0x060049EE RID: 18926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlaybackPosition_Internal(IntPtr @this);

		// Token: 0x060049EF RID: 18927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIgnoreTimeDilation_Internal(IntPtr @this);

		// Token: 0x060049F0 RID: 18928 RVA: 0x000678E5 File Offset: 0x00065AE5
		static UTimelineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TimelineComponent");
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x000678F3 File Offset: 0x00065AF3
		protected UTimelineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D11 RID: 7441
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TimelineComponent";

		// Token: 0x04001D12 RID: 7442
		private static IntPtr _ClassPtr;

		// Token: 0x04001D13 RID: 7443
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D14 RID: 7444
		internal static int __PropertyOffset_bIgnoreTimeDilation;

		// Token: 0x04001D15 RID: 7445
		internal static byte __PropertyMask_bIgnoreTimeDilation;

		// Token: 0x04001D16 RID: 7446
		private static IntPtr __OnRep_Timeline_NativeFunctionPtr;
	}
}
