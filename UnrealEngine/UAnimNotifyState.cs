using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082A RID: 2090
	[UnrealObjectPath("/Script/Engine.AnimNotifyState")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UAnimNotifyState : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007080 RID: 28800 RVA: 0x000A158F File Offset: 0x0009F78F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotifyState._ClassPtr;
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06007081 RID: 28801 RVA: 0x000A159B File Offset: 0x0009F79B
		// (set) Token: 0x06007082 RID: 28802 RVA: 0x000A15AB File Offset: 0x0009F7AB
		public unsafe bool bOnlyTriggerInMainAnim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_bOnlyTriggerInMainAnim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_bOnlyTriggerInMainAnim) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06007083 RID: 28803 RVA: 0x000A15BC File Offset: 0x0009F7BC
		// (set) Token: 0x06007084 RID: 28804 RVA: 0x000A15CC File Offset: 0x0009F7CC
		public unsafe bool NeedSimulateBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateBegin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateBegin) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06007085 RID: 28805 RVA: 0x000A15DD File Offset: 0x0009F7DD
		// (set) Token: 0x06007086 RID: 28806 RVA: 0x000A15ED File Offset: 0x0009F7ED
		public unsafe bool NeedSimulateTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06007087 RID: 28807 RVA: 0x000A15FE File Offset: 0x0009F7FE
		// (set) Token: 0x06007088 RID: 28808 RVA: 0x000A160E File Offset: 0x0009F80E
		public unsafe bool NeedSimulateEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06007089 RID: 28809 RVA: 0x000A161F File Offset: 0x0009F81F
		// (set) Token: 0x0600708A RID: 28810 RVA: 0x000A162F File Offset: 0x0009F82F
		public unsafe bool bRestartWithReplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_bRestartWithReplay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_bRestartWithReplay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x0600708B RID: 28811 RVA: 0x000A1640 File Offset: 0x0009F840
		// (set) Token: 0x0600708C RID: 28812 RVA: 0x000A1650 File Offset: 0x0009F850
		public unsafe float CurrentTimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_CurrentTimeLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_CurrentTimeLength) = value;
			}
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x000A1661 File Offset: 0x0009F861
		[NullableContext(2)]
		public virtual bool Received_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			return UAnimNotifyState.__Received_NotifyTick_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, FrameDeltaTime);
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x000A168F File Offset: 0x0009F88F
		[NullableContext(2)]
		public virtual bool Received_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UAnimNotifyState.__Received_NotifyEnd_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x000A16BC File Offset: 0x0009F8BC
		[NullableContext(2)]
		public virtual bool Received_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			return UAnimNotifyState.__Received_NotifyBegin_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, TotalDuration);
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x000A16EA File Offset: 0x0009F8EA
		[NullableContext(1)]
		public virtual string GetNotifyName()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimNotifyState.__GetNotifyName_Internal(base.NativePtr));
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x000A16FC File Offset: 0x0009F8FC
		[NullableContext(1)]
		protected virtual string GetNotifyName_Implementation()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimNotifyState.__GetNotifyName_Implementation_Internal(base.NativePtr));
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x000A170E File Offset: 0x0009F90E
		public float GetCurrentTriggerOffsetInThisNotifyTick()
		{
			return UAnimNotifyState.__GetCurrentTriggerOffsetInThisNotifyTick_Internal(base.NativePtr);
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x000A171B File Offset: 0x0009F91B
		public float GetCurrentTimeLength()
		{
			return UAnimNotifyState.__GetCurrentTimeLength_Internal(base.NativePtr);
		}

		// Token: 0x06007094 RID: 28820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Received_NotifyTick_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float FrameDeltaTime);

		// Token: 0x06007095 RID: 28821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Received_NotifyEnd_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06007096 RID: 28822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Received_NotifyBegin_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float TotalDuration);

		// Token: 0x06007097 RID: 28823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNotifyName_Internal(IntPtr @this);

		// Token: 0x06007098 RID: 28824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNotifyName_Implementation_Internal(IntPtr @this);

		// Token: 0x06007099 RID: 28825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentTriggerOffsetInThisNotifyTick_Internal(IntPtr @this);

		// Token: 0x0600709A RID: 28826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentTimeLength_Internal(IntPtr @this);

		// Token: 0x0600709B RID: 28827 RVA: 0x000A1728 File Offset: 0x0009F928
		static UAnimNotifyState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotifyState");
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x000A1738 File Offset: 0x0009F938
		protected UAnimNotifyState() : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x000A1760 File Offset: 0x0009F960
		protected UAnimNotifyState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003603 RID: 13827
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotifyState";

		// Token: 0x04003604 RID: 13828
		private static IntPtr _ClassPtr;

		// Token: 0x04003605 RID: 13829
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003606 RID: 13830
		internal static int __PropertyOffset_bOnlyTriggerInMainAnim;

		// Token: 0x04003607 RID: 13831
		internal static int __PropertyOffset_NeedSimulateBegin;

		// Token: 0x04003608 RID: 13832
		internal static int __PropertyOffset_NeedSimulateTick;

		// Token: 0x04003609 RID: 13833
		internal static int __PropertyOffset_NeedSimulateEnd;

		// Token: 0x0400360A RID: 13834
		internal static int __PropertyOffset_bRestartWithReplay;

		// Token: 0x0400360B RID: 13835
		internal static int __PropertyOffset_CurrentTimeLength;

		// Token: 0x02002C87 RID: 11399
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Received_NotifyTick_FunctionParams
		{
			// Token: 0x040165C2 RID: 91586
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040165C3 RID: 91587
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040165C4 RID: 91588
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x040165C5 RID: 91589
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02002C88 RID: 11400
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Received_NotifyEnd_FunctionParams
		{
			// Token: 0x040165C6 RID: 91590
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040165C7 RID: 91591
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040165C8 RID: 91592
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002C89 RID: 11401
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Received_NotifyBegin_FunctionParams
		{
			// Token: 0x040165C9 RID: 91593
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040165CA RID: 91594
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040165CB RID: 91595
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x040165CC RID: 91596
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02002C8A RID: 11402
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNotifyName_FunctionParams
		{
			// Token: 0x040165CD RID: 91597
			[FieldOffset(0)]
			public FString __Result;
		}
	}
}
