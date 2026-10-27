using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AB RID: 939
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARImageUpdatePayload")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FARImageUpdatePayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003415 RID: 13333 RVA: 0x0004FA2C File Offset: 0x0004DC2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARImageUpdatePayload._ScriptStructPtr != 0) ? FARImageUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARImageUpdatePayload", ref FARImageUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x0004FA50 File Offset: 0x0004DC50
		// (set) Token: 0x06003417 RID: 13335 RVA: 0x0004FA93 File Offset: 0x0004DC93
		public FARSessionPayload SessionPayload
		{
			get
			{
				base.FastCheckIsValid();
				FARSessionPayload result;
				if ((result = this._SessionPayload) == null)
				{
					result = (this._SessionPayload = new FARSessionPayload(base.NativePtr + (IntPtr)FARImageUpdatePayload.__PropertyOffset_SessionPayload, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARSessionPayload.StaticStruct(), base.NativePtr + (IntPtr)FARImageUpdatePayload.__PropertyOffset_SessionPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x0004FAB4 File Offset: 0x0004DCB4
		// (set) Token: 0x06003419 RID: 13337 RVA: 0x0004FAC8 File Offset: 0x0004DCC8
		public unsafe FTransform WorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARImageUpdatePayload.__PropertyOffset_WorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARImageUpdatePayload.__PropertyOffset_WorldTransform) = value;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x0600341A RID: 13338 RVA: 0x0004FADD File Offset: 0x0004DCDD
		// (set) Token: 0x0600341B RID: 13339 RVA: 0x0004FAF1 File Offset: 0x0004DCF1
		[Nullable(2)]
		public unsafe UARCandidateImage DetectedImage
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UARCandidateImage>(base.NativePtr / (IntPtr)sizeof(void*) + FARImageUpdatePayload.__PropertyOffset_DetectedImage);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FARImageUpdatePayload.__PropertyOffset_DetectedImage, value);
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x0600341C RID: 13340 RVA: 0x0004FB06 File Offset: 0x0004DD06
		// (set) Token: 0x0600341D RID: 13341 RVA: 0x0004FB1A File Offset: 0x0004DD1A
		public unsafe FVector2D EstimatedSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARImageUpdatePayload.__PropertyOffset_EstimatedSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARImageUpdatePayload.__PropertyOffset_EstimatedSize) = value;
			}
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x0004FB2F File Offset: 0x0004DD2F
		public FARImageUpdatePayload()
		{
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x0004FB37 File Offset: 0x0004DD37
		public FARImageUpdatePayload(FARSessionPayload SessionPayload, FTransform WorldTransform, UARCandidateImage DetectedImage, FVector2D EstimatedSize)
		{
			this.SessionPayload = SessionPayload;
			this.WorldTransform = WorldTransform;
			this.DetectedImage = DetectedImage;
			this.EstimatedSize = EstimatedSize;
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x0004FB5C File Offset: 0x0004DD5C
		protected override IntPtr GetUStructPtr()
		{
			return FARImageUpdatePayload.StaticStruct();
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x0004FB68 File Offset: 0x0004DD68
		[NullableContext(2)]
		public FARImageUpdatePayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x0004FB72 File Offset: 0x0004DD72
		public FARImageUpdatePayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x0004FB7D File Offset: 0x0004DD7D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARImageUpdatePayload(Pointer, false, true);
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x0004FB87 File Offset: 0x0004DD87
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARImageUpdatePayload(Pointer, MemoryOwner);
		}

		// Token: 0x04001698 RID: 5784
		public const string __ObjectPath = "/Script/AugmentedReality.ARImageUpdatePayload";

		// Token: 0x04001699 RID: 5785
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400169A RID: 5786
		internal static int __PropertyOffset_SessionPayload;

		// Token: 0x0400169B RID: 5787
		[Nullable(2)]
		private FARSessionPayload _SessionPayload;

		// Token: 0x0400169C RID: 5788
		internal static int __PropertyOffset_WorldTransform;

		// Token: 0x0400169D RID: 5789
		internal static int __PropertyOffset_DetectedImage;

		// Token: 0x0400169E RID: 5790
		internal static int __PropertyOffset_EstimatedSize;
	}
}
