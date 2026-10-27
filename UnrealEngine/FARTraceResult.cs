using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CE RID: 974
	[UnrealObjectPath("/Script/AugmentedReality.ARTraceResult")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FARTraceResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600367A RID: 13946 RVA: 0x00052A49 File Offset: 0x00050C49
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARTraceResult._ScriptStructPtr != 0) ? FARTraceResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARTraceResult", ref FARTraceResult._ScriptStructPtr);
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x00052A6D File Offset: 0x00050C6D
		// (set) Token: 0x0600367C RID: 13948 RVA: 0x00052A7D File Offset: 0x00050C7D
		public unsafe float DistanceFromCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARTraceResult.__PropertyOffset_DistanceFromCamera);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARTraceResult.__PropertyOffset_DistanceFromCamera) = value;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x00052A8E File Offset: 0x00050C8E
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x00052A9E File Offset: 0x00050C9E
		public unsafe EARLineTraceChannels TraceChannel
		{
			get
			{
				return (EARLineTraceChannels)(*(base.NativePtr + (IntPtr)FARTraceResult.__PropertyOffset_TraceChannel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARTraceResult.__PropertyOffset_TraceChannel) = (byte)value;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600367F RID: 13951 RVA: 0x00052AAF File Offset: 0x00050CAF
		// (set) Token: 0x06003680 RID: 13952 RVA: 0x00052AC3 File Offset: 0x00050CC3
		public unsafe FTransform LocalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARTraceResult.__PropertyOffset_LocalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARTraceResult.__PropertyOffset_LocalTransform) = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06003681 RID: 13953 RVA: 0x00052AD8 File Offset: 0x00050CD8
		// (set) Token: 0x06003682 RID: 13954 RVA: 0x00052AEC File Offset: 0x00050CEC
		[Nullable(2)]
		public unsafe UARTrackedGeometry TrackedGeometry
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UARTrackedGeometry>(base.NativePtr / (IntPtr)sizeof(void*) + FARTraceResult.__PropertyOffset_TrackedGeometry);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FARTraceResult.__PropertyOffset_TrackedGeometry, value);
			}
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00052B01 File Offset: 0x00050D01
		public FARTraceResult()
		{
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x00052B09 File Offset: 0x00050D09
		[NullableContext(1)]
		public FARTraceResult(float DistanceFromCamera, EARLineTraceChannels TraceChannel, FTransform LocalTransform, UARTrackedGeometry TrackedGeometry)
		{
			this.DistanceFromCamera = DistanceFromCamera;
			this.TraceChannel = TraceChannel;
			this.LocalTransform = LocalTransform;
			this.TrackedGeometry = TrackedGeometry;
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x00052B2E File Offset: 0x00050D2E
		protected override IntPtr GetUStructPtr()
		{
			return FARTraceResult.StaticStruct();
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x00052B3A File Offset: 0x00050D3A
		[NullableContext(2)]
		public FARTraceResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x00052B44 File Offset: 0x00050D44
		public FARTraceResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x00052B4F File Offset: 0x00050D4F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARTraceResult(Pointer, false, true);
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x00052B59 File Offset: 0x00050D59
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARTraceResult(Pointer, MemoryOwner);
		}

		// Token: 0x04001791 RID: 6033
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARTraceResult";

		// Token: 0x04001792 RID: 6034
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001793 RID: 6035
		internal static int __PropertyOffset_DistanceFromCamera;

		// Token: 0x04001794 RID: 6036
		internal static int __PropertyOffset_TraceChannel;

		// Token: 0x04001795 RID: 6037
		internal static int __PropertyOffset_LocalTransform;

		// Token: 0x04001796 RID: 6038
		internal static int __PropertyOffset_TrackedGeometry;
	}
}
