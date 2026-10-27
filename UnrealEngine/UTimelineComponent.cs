using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011EB RID: 4587
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TimelineComponent")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UTimelineComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010E5F RID: 69215 RVA: 0x0018D0E8 File Offset: 0x0018B2E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTimelineComponent._ClassPtr;
		}

		// Token: 0x06010E60 RID: 69216 RVA: 0x0018D0F4 File Offset: 0x0018B2F4
		public UTimelineComponent() : this(BuiltinUtils.AllocNativeUObject(UTimelineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010E61 RID: 69217 RVA: 0x0018D11C File Offset: 0x0018B31C
		public UTimelineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTimelineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x06010E62 RID: 69218 RVA: 0x0018D150 File Offset: 0x0018B350
		// (set) Token: 0x06010E63 RID: 69219 RVA: 0x0018D189 File Offset: 0x0018B389
		public FTimeline TheTimeline
		{
			get
			{
				base.FastCheckIsValid();
				FTimeline result;
				if ((result = this._TheTimeline) == null)
				{
					result = (this._TheTimeline = new FTimeline(base.NativePtr + (IntPtr)UTimelineComponent.__PropertyOffset_TheTimeline, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimeline.StaticStruct(), base.NativePtr + (IntPtr)UTimelineComponent.__PropertyOffset_TheTimeline, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x06010E64 RID: 69220 RVA: 0x0018D1AA File Offset: 0x0018B3AA
		// (set) Token: 0x06010E65 RID: 69221 RVA: 0x0018D1C3 File Offset: 0x0018B3C3
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

		// Token: 0x06010E66 RID: 69222 RVA: 0x0018D1F3 File Offset: 0x0018B3F3
		public void Stop()
		{
			UTimelineComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06010E67 RID: 69223 RVA: 0x0018D200 File Offset: 0x0018B400
		[NullableContext(2)]
		public void SetVectorCurve(UCurveVector NewVectorCurve, FName VectorTrackName)
		{
			UTimelineComponent.__SetVectorCurve_Internal(base.NativePtr, (NewVectorCurve != null) ? NewVectorCurve.NativePtr : IntPtr.Zero, VectorTrackName);
		}

		// Token: 0x06010E68 RID: 69224 RVA: 0x0018D21E File Offset: 0x0018B41E
		public void SetTimelineLengthMode(ETimelineLengthMode NewLengthMode)
		{
			UTimelineComponent.__SetTimelineLengthMode_Internal(base.NativePtr, NewLengthMode);
		}

		// Token: 0x06010E69 RID: 69225 RVA: 0x0018D231 File Offset: 0x0018B431
		public void SetTimelineLength(float NewLength)
		{
			UTimelineComponent.__SetTimelineLength_Internal(base.NativePtr, NewLength);
		}

		// Token: 0x06010E6A RID: 69226 RVA: 0x0018D23F File Offset: 0x0018B43F
		public void SetPlayRate(float NewRate)
		{
			UTimelineComponent.__SetPlayRate_Internal(base.NativePtr, NewRate);
		}

		// Token: 0x06010E6B RID: 69227 RVA: 0x0018D24D File Offset: 0x0018B44D
		public void SetPlaybackPosition(float NewPosition, bool bFireEvents, bool bFireUpdate = true)
		{
			UTimelineComponent.__SetPlaybackPosition_Internal(base.NativePtr, NewPosition, bFireEvents, bFireUpdate);
		}

		// Token: 0x06010E6C RID: 69228 RVA: 0x0018D25D File Offset: 0x0018B45D
		public void SetNewTime(float NewTime)
		{
			UTimelineComponent.__SetNewTime_Internal(base.NativePtr, NewTime);
		}

		// Token: 0x06010E6D RID: 69229 RVA: 0x0018D26B File Offset: 0x0018B46B
		public void SetLooping(bool bNewLooping)
		{
			UTimelineComponent.__SetLooping_Internal(base.NativePtr, bNewLooping);
		}

		// Token: 0x06010E6E RID: 69230 RVA: 0x0018D279 File Offset: 0x0018B479
		[NullableContext(2)]
		public void SetLinearColorCurve(UCurveLinearColor NewLinearColorCurve, FName LinearColorTrackName)
		{
			UTimelineComponent.__SetLinearColorCurve_Internal(base.NativePtr, (NewLinearColorCurve != null) ? NewLinearColorCurve.NativePtr : IntPtr.Zero, LinearColorTrackName);
		}

		// Token: 0x06010E6F RID: 69231 RVA: 0x0018D297 File Offset: 0x0018B497
		public void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation)
		{
			UTimelineComponent.__SetIgnoreTimeDilation_Internal(base.NativePtr, bNewIgnoreTimeDilation);
		}

		// Token: 0x06010E70 RID: 69232 RVA: 0x0018D2A5 File Offset: 0x0018B4A5
		[NullableContext(2)]
		public void SetFloatCurve(UCurveFloat NewFloatCurve, FName FloatTrackName)
		{
			UTimelineComponent.__SetFloatCurve_Internal(base.NativePtr, (NewFloatCurve != null) ? NewFloatCurve.NativePtr : IntPtr.Zero, FloatTrackName);
		}

		// Token: 0x06010E71 RID: 69233 RVA: 0x0018D2C3 File Offset: 0x0018B4C3
		public void ReverseFromEnd()
		{
			UTimelineComponent.__ReverseFromEnd_Internal(base.NativePtr);
		}

		// Token: 0x06010E72 RID: 69234 RVA: 0x0018D2D0 File Offset: 0x0018B4D0
		public void Reverse()
		{
			UTimelineComponent.__Reverse_Internal(base.NativePtr);
		}

		// Token: 0x06010E73 RID: 69235 RVA: 0x0018D2DD File Offset: 0x0018B4DD
		public void PlayFromStart()
		{
			UTimelineComponent.__PlayFromStart_Internal(base.NativePtr);
		}

		// Token: 0x06010E74 RID: 69236 RVA: 0x0018D2EA File Offset: 0x0018B4EA
		public void Play()
		{
			UTimelineComponent.__Play_Internal(base.NativePtr);
		}

		// Token: 0x06010E75 RID: 69237 RVA: 0x0018D2F7 File Offset: 0x0018B4F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void OnRep_Timeline()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTimelineComponent.__OnRep_Timeline_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06010E76 RID: 69238 RVA: 0x0018D30C File Offset: 0x0018B50C
		public void MoveInterpFloatForLastKey(FName FloatTrackName, float Time)
		{
			UTimelineComponent.__MoveInterpFloatForLastKey_Internal(base.NativePtr, FloatTrackName, Time);
		}

		// Token: 0x06010E77 RID: 69239 RVA: 0x0018D31B File Offset: 0x0018B51B
		public bool IsReversing()
		{
			return UTimelineComponent.__IsReversing_Internal(base.NativePtr);
		}

		// Token: 0x06010E78 RID: 69240 RVA: 0x0018D328 File Offset: 0x0018B528
		public bool IsPlaying()
		{
			return UTimelineComponent.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x06010E79 RID: 69241 RVA: 0x0018D335 File Offset: 0x0018B535
		public bool IsLooping()
		{
			return UTimelineComponent.__IsLooping_Internal(base.NativePtr);
		}

		// Token: 0x06010E7A RID: 69242 RVA: 0x0018D342 File Offset: 0x0018B542
		public float GetTimelineLength()
		{
			return UTimelineComponent.__GetTimelineLength_Internal(base.NativePtr);
		}

		// Token: 0x06010E7B RID: 69243 RVA: 0x0018D34F File Offset: 0x0018B54F
		public float GetPlayRate()
		{
			return UTimelineComponent.__GetPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x06010E7C RID: 69244 RVA: 0x0018D35C File Offset: 0x0018B55C
		public float GetPlaybackPosition()
		{
			return UTimelineComponent.__GetPlaybackPosition_Internal(base.NativePtr);
		}

		// Token: 0x06010E7D RID: 69245 RVA: 0x0018D369 File Offset: 0x0018B569
		public bool GetIgnoreTimeDilation()
		{
			return UTimelineComponent.__GetIgnoreTimeDilation_Internal(base.NativePtr);
		}

		// Token: 0x06010E7E RID: 69246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06010E7F RID: 69247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorCurve_Internal(IntPtr @this, IntPtr NewVectorCurve, FName VectorTrackName);

		// Token: 0x06010E80 RID: 69248
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimelineLengthMode_Internal(IntPtr @this, TEnumAsByte<ETimelineLengthMode> NewLengthMode);

		// Token: 0x06010E81 RID: 69249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimelineLength_Internal(IntPtr @this, float NewLength);

		// Token: 0x06010E82 RID: 69250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRate_Internal(IntPtr @this, float NewRate);

		// Token: 0x06010E83 RID: 69251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackPosition_Internal(IntPtr @this, float NewPosition, bool bFireEvents, bool bFireUpdate);

		// Token: 0x06010E84 RID: 69252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNewTime_Internal(IntPtr @this, float NewTime);

		// Token: 0x06010E85 RID: 69253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLooping_Internal(IntPtr @this, bool bNewLooping);

		// Token: 0x06010E86 RID: 69254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearColorCurve_Internal(IntPtr @this, IntPtr NewLinearColorCurve, FName LinearColorTrackName);

		// Token: 0x06010E87 RID: 69255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreTimeDilation_Internal(IntPtr @this, bool bNewIgnoreTimeDilation);

		// Token: 0x06010E88 RID: 69256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatCurve_Internal(IntPtr @this, IntPtr NewFloatCurve, FName FloatTrackName);

		// Token: 0x06010E89 RID: 69257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReverseFromEnd_Internal(IntPtr @this);

		// Token: 0x06010E8A RID: 69258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Reverse_Internal(IntPtr @this);

		// Token: 0x06010E8B RID: 69259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayFromStart_Internal(IntPtr @this);

		// Token: 0x06010E8C RID: 69260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x06010E8D RID: 69261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveInterpFloatForLastKey_Internal(IntPtr @this, FName FloatTrackName, float Time);

		// Token: 0x06010E8E RID: 69262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsReversing_Internal(IntPtr @this);

		// Token: 0x06010E8F RID: 69263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x06010E90 RID: 69264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLooping_Internal(IntPtr @this);

		// Token: 0x06010E91 RID: 69265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimelineLength_Internal(IntPtr @this);

		// Token: 0x06010E92 RID: 69266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayRate_Internal(IntPtr @this);

		// Token: 0x06010E93 RID: 69267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlaybackPosition_Internal(IntPtr @this);

		// Token: 0x06010E94 RID: 69268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIgnoreTimeDilation_Internal(IntPtr @this);

		// Token: 0x06010E95 RID: 69269 RVA: 0x0018D376 File Offset: 0x0018B576
		static UTimelineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TimelineComponent");
		}

		// Token: 0x06010E96 RID: 69270 RVA: 0x0018D384 File Offset: 0x0018B584
		protected UTimelineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040090EB RID: 37099
		public new const string __ObjectPath = "/Script/Engine.TimelineComponent";

		// Token: 0x040090EC RID: 37100
		private static IntPtr _ClassPtr;

		// Token: 0x040090ED RID: 37101
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040090EE RID: 37102
		internal static int __PropertyOffset_TheTimeline;

		// Token: 0x040090EF RID: 37103
		[Nullable(2)]
		private FTimeline _TheTimeline;

		// Token: 0x040090F0 RID: 37104
		internal static int __PropertyOffset_bIgnoreTimeDilation;

		// Token: 0x040090F1 RID: 37105
		internal static byte __PropertyMask_bIgnoreTimeDilation;

		// Token: 0x040090F2 RID: 37106
		private static IntPtr __OnRep_Timeline_NativeFunctionPtr;
	}
}
