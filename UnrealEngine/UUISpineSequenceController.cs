using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021B8 RID: 8632
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpineSequenceController")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UUISpineSequenceController : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020D7F RID: 134527 RVA: 0x00308732 File Offset: 0x00306932
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpineSequenceController._ClassPtr;
		}

		// Token: 0x06020D80 RID: 134528 RVA: 0x00308740 File Offset: 0x00306940
		public UUISpineSequenceController() : this(BuiltinUtils.AllocNativeUObject(UUISpineSequenceController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D81 RID: 134529 RVA: 0x00308768 File Offset: 0x00306968
		[NullableContext(1)]
		public UUISpineSequenceController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpineSequenceController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700804B RID: 32843
		// (get) Token: 0x06020D82 RID: 134530 RVA: 0x0030879B File Offset: 0x0030699B
		// (set) Token: 0x06020D83 RID: 134531 RVA: 0x003087AF File Offset: 0x003069AF
		[Nullable(1)]
		public unsafe string AnimName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUISpineSequenceController.__PropertyOffset_AnimName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUISpineSequenceController.__PropertyOffset_AnimName)), value);
			}
		}

		// Token: 0x1700804C RID: 32844
		// (get) Token: 0x06020D84 RID: 134532 RVA: 0x003087C4 File Offset: 0x003069C4
		// (set) Token: 0x06020D85 RID: 134533 RVA: 0x003087D4 File Offset: 0x003069D4
		public unsafe float AnimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineSequenceController.__PropertyOffset_AnimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineSequenceController.__PropertyOffset_AnimTime) = value;
			}
		}

		// Token: 0x1700804D RID: 32845
		// (get) Token: 0x06020D86 RID: 134534 RVA: 0x003087E5 File Offset: 0x003069E5
		// (set) Token: 0x06020D87 RID: 134535 RVA: 0x003087F5 File Offset: 0x003069F5
		public unsafe float AnimDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineSequenceController.__PropertyOffset_AnimDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineSequenceController.__PropertyOffset_AnimDuration) = value;
			}
		}

		// Token: 0x1700804E RID: 32846
		// (get) Token: 0x06020D88 RID: 134536 RVA: 0x00308806 File Offset: 0x00306A06
		// (set) Token: 0x06020D89 RID: 134537 RVA: 0x00308816 File Offset: 0x00306A16
		public unsafe float MixDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineSequenceController.__PropertyOffset_MixDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineSequenceController.__PropertyOffset_MixDuration) = value;
			}
		}

		// Token: 0x1700804F RID: 32847
		// (get) Token: 0x06020D8A RID: 134538 RVA: 0x00308827 File Offset: 0x00306A27
		// (set) Token: 0x06020D8B RID: 134539 RVA: 0x00308837 File Offset: 0x00306A37
		public unsafe float MixTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineSequenceController.__PropertyOffset_MixTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineSequenceController.__PropertyOffset_MixTime) = value;
			}
		}

		// Token: 0x17008050 RID: 32848
		// (get) Token: 0x06020D8C RID: 134540 RVA: 0x00308848 File Offset: 0x00306A48
		// (set) Token: 0x06020D8D RID: 134541 RVA: 0x0030885C File Offset: 0x00306A5C
		public unsafe USpineSkeletonAnimationComponent SpineSkeletonAnimationComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineSkeletonAnimationComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineSequenceController.__PropertyOffset_SpineSkeletonAnimationComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineSequenceController.__PropertyOffset_SpineSkeletonAnimationComponent, value);
			}
		}

		// Token: 0x17008051 RID: 32849
		// (get) Token: 0x06020D8E RID: 134542 RVA: 0x00308871 File Offset: 0x00306A71
		// (set) Token: 0x06020D8F RID: 134543 RVA: 0x00308885 File Offset: 0x00306A85
		public unsafe UTrackEntry TrackEntry
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTrackEntry>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineSequenceController.__PropertyOffset_TrackEntry);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineSequenceController.__PropertyOffset_TrackEntry, value);
			}
		}

		// Token: 0x06020D90 RID: 134544 RVA: 0x0030889A File Offset: 0x00306A9A
		public void SetAnimTime(float NewAnimTime)
		{
			UUISpineSequenceController.__SetAnimTime_Internal(base.NativePtr, NewAnimTime);
		}

		// Token: 0x06020D91 RID: 134545 RVA: 0x003088A8 File Offset: 0x00306AA8
		public float GetAnimTime()
		{
			return UUISpineSequenceController.__GetAnimTime_Internal(base.NativePtr);
		}

		// Token: 0x06020D92 RID: 134546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimTime_Internal(IntPtr @this, float NewAnimTime);

		// Token: 0x06020D93 RID: 134547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimTime_Internal(IntPtr @this);

		// Token: 0x06020D94 RID: 134548 RVA: 0x003088B5 File Offset: 0x00306AB5
		static UUISpineSequenceController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpineSequenceController");
		}

		// Token: 0x06020D95 RID: 134549 RVA: 0x003088C3 File Offset: 0x00306AC3
		protected UUISpineSequenceController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040118B4 RID: 71860
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpineSequenceController";

		// Token: 0x040118B5 RID: 71861
		private static IntPtr _ClassPtr;

		// Token: 0x040118B6 RID: 71862
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040118B7 RID: 71863
		internal static int __PropertyOffset_AnimName;

		// Token: 0x040118B8 RID: 71864
		internal static int __PropertyOffset_AnimTime;

		// Token: 0x040118B9 RID: 71865
		internal static int __PropertyOffset_AnimDuration;

		// Token: 0x040118BA RID: 71866
		internal static int __PropertyOffset_MixDuration;

		// Token: 0x040118BB RID: 71867
		internal static int __PropertyOffset_MixTime;

		// Token: 0x040118BC RID: 71868
		internal static int __PropertyOffset_SpineSkeletonAnimationComponent;

		// Token: 0x040118BD RID: 71869
		internal static int __PropertyOffset_TrackEntry;
	}
}
