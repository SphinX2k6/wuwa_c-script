using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FB9 RID: 8121
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceCameraSettings")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FLevelSequenceCameraSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ED2D RID: 126253 RVA: 0x002DCFE2 File Offset: 0x002DB1E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequenceCameraSettings._ScriptStructPtr != 0) ? FLevelSequenceCameraSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequenceCameraSettings", ref FLevelSequenceCameraSettings._ScriptStructPtr);
		}

		// Token: 0x17007ABB RID: 31419
		// (get) Token: 0x0601ED2E RID: 126254 RVA: 0x002DD006 File Offset: 0x002DB206
		// (set) Token: 0x0601ED2F RID: 126255 RVA: 0x002DD016 File Offset: 0x002DB216
		public unsafe bool bOverrideAspectRatioAxisConstraint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceCameraSettings.__PropertyOffset_bOverrideAspectRatioAxisConstraint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceCameraSettings.__PropertyOffset_bOverrideAspectRatioAxisConstraint) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007ABC RID: 31420
		// (get) Token: 0x0601ED30 RID: 126256 RVA: 0x002DD027 File Offset: 0x002DB227
		// (set) Token: 0x0601ED31 RID: 126257 RVA: 0x002DD03B File Offset: 0x002DB23B
		public unsafe TEnumAsByte<EAspectRatioAxisConstraint> AspectRatioAxisConstraint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelSequenceCameraSettings.__PropertyOffset_AspectRatioAxisConstraint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelSequenceCameraSettings.__PropertyOffset_AspectRatioAxisConstraint) = value;
			}
		}

		// Token: 0x0601ED32 RID: 126258 RVA: 0x002DD050 File Offset: 0x002DB250
		public FLevelSequenceCameraSettings()
		{
		}

		// Token: 0x0601ED33 RID: 126259 RVA: 0x002DD058 File Offset: 0x002DB258
		public FLevelSequenceCameraSettings(bool bOverrideAspectRatioAxisConstraint, TEnumAsByte<EAspectRatioAxisConstraint> AspectRatioAxisConstraint)
		{
			this.bOverrideAspectRatioAxisConstraint = bOverrideAspectRatioAxisConstraint;
			this.AspectRatioAxisConstraint = AspectRatioAxisConstraint;
		}

		// Token: 0x0601ED34 RID: 126260 RVA: 0x002DD06E File Offset: 0x002DB26E
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequenceCameraSettings.StaticStruct();
		}

		// Token: 0x0601ED35 RID: 126261 RVA: 0x002DD07A File Offset: 0x002DB27A
		[NullableContext(2)]
		public FLevelSequenceCameraSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ED36 RID: 126262 RVA: 0x002DD084 File Offset: 0x002DB284
		public FLevelSequenceCameraSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ED37 RID: 126263 RVA: 0x002DD08F File Offset: 0x002DB28F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequenceCameraSettings(Pointer, false, true);
		}

		// Token: 0x0601ED38 RID: 126264 RVA: 0x002DD099 File Offset: 0x002DB299
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequenceCameraSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04010A8B RID: 68235
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceCameraSettings";

		// Token: 0x04010A8C RID: 68236
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A8D RID: 68237
		internal static int __PropertyOffset_bOverrideAspectRatioAxisConstraint;

		// Token: 0x04010A8E RID: 68238
		internal static int __PropertyOffset_AspectRatioAxisConstraint;
	}
}
