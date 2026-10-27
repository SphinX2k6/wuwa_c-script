using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E3 RID: 2019
	[UnrealObjectPath("/Script/Engine.AnimationRecordingSettings")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FAnimationRecordingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B7D RID: 27517 RVA: 0x0009AAF1 File Offset: 0x00098CF1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationRecordingSettings._ScriptStructPtr != 0) ? FAnimationRecordingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationRecordingSettings", ref FAnimationRecordingSettings._ScriptStructPtr);
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06006B7E RID: 27518 RVA: 0x0009AB15 File Offset: 0x00098D15
		// (set) Token: 0x06006B7F RID: 27519 RVA: 0x0009AB25 File Offset: 0x00098D25
		public unsafe bool bRecordInWorldSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bRecordInWorldSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bRecordInWorldSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06006B80 RID: 27520 RVA: 0x0009AB36 File Offset: 0x00098D36
		// (set) Token: 0x06006B81 RID: 27521 RVA: 0x0009AB46 File Offset: 0x00098D46
		public unsafe bool bRemoveRootAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bRemoveRootAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bRemoveRootAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06006B82 RID: 27522 RVA: 0x0009AB57 File Offset: 0x00098D57
		// (set) Token: 0x06006B83 RID: 27523 RVA: 0x0009AB67 File Offset: 0x00098D67
		public unsafe bool bAutoSaveAsset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bAutoSaveAsset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bAutoSaveAsset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x06006B84 RID: 27524 RVA: 0x0009AB78 File Offset: 0x00098D78
		// (set) Token: 0x06006B85 RID: 27525 RVA: 0x0009AB88 File Offset: 0x00098D88
		public unsafe float SampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_SampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_SampleRate) = value;
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06006B86 RID: 27526 RVA: 0x0009AB99 File Offset: 0x00098D99
		// (set) Token: 0x06006B87 RID: 27527 RVA: 0x0009ABA9 File Offset: 0x00098DA9
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06006B88 RID: 27528 RVA: 0x0009ABBA File Offset: 0x00098DBA
		// (set) Token: 0x06006B89 RID: 27529 RVA: 0x0009ABCE File Offset: 0x00098DCE
		public unsafe TEnumAsByte<ERichCurveInterpMode> InterpMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_InterpMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_InterpMode) = value;
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x06006B8A RID: 27530 RVA: 0x0009ABE3 File Offset: 0x00098DE3
		// (set) Token: 0x06006B8B RID: 27531 RVA: 0x0009ABF7 File Offset: 0x00098DF7
		public unsafe TEnumAsByte<ERichCurveTangentMode> TangentMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_TangentMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_TangentMode) = value;
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06006B8C RID: 27532 RVA: 0x0009AC0C File Offset: 0x00098E0C
		// (set) Token: 0x06006B8D RID: 27533 RVA: 0x0009AC1C File Offset: 0x00098E1C
		public unsafe bool bRecordTransforms
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bRecordTransforms) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bRecordTransforms) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06006B8E RID: 27534 RVA: 0x0009AC2D File Offset: 0x00098E2D
		// (set) Token: 0x06006B8F RID: 27535 RVA: 0x0009AC3D File Offset: 0x00098E3D
		public unsafe bool bRecordCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bRecordCurves) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationRecordingSettings.__PropertyOffset_bRecordCurves) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x0009AC4E File Offset: 0x00098E4E
		public FAnimationRecordingSettings()
		{
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x0009AC58 File Offset: 0x00098E58
		public FAnimationRecordingSettings(bool bRecordInWorldSpace, bool bRemoveRootAnimation, bool bAutoSaveAsset, float SampleRate, float Length, TEnumAsByte<ERichCurveInterpMode> InterpMode, TEnumAsByte<ERichCurveTangentMode> TangentMode, bool bRecordTransforms, bool bRecordCurves)
		{
			this.bRecordInWorldSpace = bRecordInWorldSpace;
			this.bRemoveRootAnimation = bRemoveRootAnimation;
			this.bAutoSaveAsset = bAutoSaveAsset;
			this.SampleRate = SampleRate;
			this.Length = Length;
			this.InterpMode = InterpMode;
			this.TangentMode = TangentMode;
			this.bRecordTransforms = bRecordTransforms;
			this.bRecordCurves = bRecordCurves;
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x0009ACB0 File Offset: 0x00098EB0
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationRecordingSettings.StaticStruct();
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x0009ACBC File Offset: 0x00098EBC
		[NullableContext(2)]
		public FAnimationRecordingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x0009ACC6 File Offset: 0x00098EC6
		public FAnimationRecordingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x0009ACD1 File Offset: 0x00098ED1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationRecordingSettings(Pointer, false, true);
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x0009ACDB File Offset: 0x00098EDB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationRecordingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040033B7 RID: 13239
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimationRecordingSettings";

		// Token: 0x040033B8 RID: 13240
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040033B9 RID: 13241
		internal static int __PropertyOffset_bRecordInWorldSpace;

		// Token: 0x040033BA RID: 13242
		internal static int __PropertyOffset_bRemoveRootAnimation;

		// Token: 0x040033BB RID: 13243
		internal static int __PropertyOffset_bAutoSaveAsset;

		// Token: 0x040033BC RID: 13244
		internal static int __PropertyOffset_SampleRate;

		// Token: 0x040033BD RID: 13245
		internal static int __PropertyOffset_Length;

		// Token: 0x040033BE RID: 13246
		internal static int __PropertyOffset_InterpMode;

		// Token: 0x040033BF RID: 13247
		internal static int __PropertyOffset_TangentMode;

		// Token: 0x040033C0 RID: 13248
		internal static int __PropertyOffset_bRecordTransforms;

		// Token: 0x040033C1 RID: 13249
		internal static int __PropertyOffset_bRecordCurves;
	}
}
