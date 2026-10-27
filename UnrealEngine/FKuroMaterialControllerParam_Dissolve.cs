using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B41 RID: 6977
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Dissolve")]
	[UnrealStructLayout(2936, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2936)]
	public class FKuroMaterialControllerParam_Dissolve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A6AF RID: 108207 RVA: 0x0026F336 File Offset: 0x0026D536
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_Dissolve._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_Dissolve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Dissolve", ref FKuroMaterialControllerParam_Dissolve._ScriptStructPtr);
		}

		// Token: 0x17006A37 RID: 27191
		// (get) Token: 0x0601A6B0 RID: 108208 RVA: 0x0026F35A File Offset: 0x0026D55A
		// (set) Token: 0x0601A6B1 RID: 108209 RVA: 0x0026F36A File Offset: 0x0026D56A
		public unsafe EKuroCharacterControllerChannelSwitch DissolveChannel
		{
			get
			{
				return (EKuroCharacterControllerChannelSwitch)(*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveChannel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveChannel) = (byte)value;
			}
		}

		// Token: 0x17006A38 RID: 27192
		// (get) Token: 0x0601A6B2 RID: 108210 RVA: 0x0026F37C File Offset: 0x0026D57C
		// (set) Token: 0x0601A6B3 RID: 108211 RVA: 0x0026F3BF File Offset: 0x0026D5BF
		public FKuroMaterialCurveFloatGroup DissolveProgress
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._DissolveProgress) == null)
				{
					result = (this._DissolveProgress = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveProgress, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A39 RID: 27193
		// (get) Token: 0x0601A6B4 RID: 108212 RVA: 0x0026F3E0 File Offset: 0x0026D5E0
		// (set) Token: 0x0601A6B5 RID: 108213 RVA: 0x0026F423 File Offset: 0x0026D623
		public FKuroMaterialCurveFloatGroup DissolveSmooth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._DissolveSmooth) == null)
				{
					result = (this._DissolveSmooth = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveSmooth, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveSmooth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A3A RID: 27194
		// (get) Token: 0x0601A6B6 RID: 108214 RVA: 0x0026F444 File Offset: 0x0026D644
		// (set) Token: 0x0601A6B7 RID: 108215 RVA: 0x0026F487 File Offset: 0x0026D687
		public FKuroMaterialCurveFloatGroup DissolveColorIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._DissolveColorIntensity) == null)
				{
					result = (this._DissolveColorIntensity = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveColorIntensity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveColorIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A3B RID: 27195
		// (get) Token: 0x0601A6B8 RID: 108216 RVA: 0x0026F4A8 File Offset: 0x0026D6A8
		// (set) Token: 0x0601A6B9 RID: 108217 RVA: 0x0026F4EB File Offset: 0x0026D6EB
		public FKuroMaterialCurveColorGroup DissolveColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._DissolveColor) == null)
				{
					result = (this._DissolveColor = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Dissolve.__PropertyOffset_DissolveColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A6BA RID: 108218 RVA: 0x0026F50C File Offset: 0x0026D70C
		public FKuroMaterialControllerParam_Dissolve()
		{
		}

		// Token: 0x0601A6BB RID: 108219 RVA: 0x0026F514 File Offset: 0x0026D714
		public FKuroMaterialControllerParam_Dissolve(EKuroCharacterControllerChannelSwitch DissolveChannel, FKuroMaterialCurveFloatGroup DissolveProgress, FKuroMaterialCurveFloatGroup DissolveSmooth, FKuroMaterialCurveFloatGroup DissolveColorIntensity, FKuroMaterialCurveColorGroup DissolveColor)
		{
			this.DissolveChannel = DissolveChannel;
			this.DissolveProgress = DissolveProgress;
			this.DissolveSmooth = DissolveSmooth;
			this.DissolveColorIntensity = DissolveColorIntensity;
			this.DissolveColor = DissolveColor;
		}

		// Token: 0x0601A6BC RID: 108220 RVA: 0x0026F541 File Offset: 0x0026D741
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_Dissolve.StaticStruct();
		}

		// Token: 0x0601A6BD RID: 108221 RVA: 0x0026F54D File Offset: 0x0026D74D
		[NullableContext(2)]
		public FKuroMaterialControllerParam_Dissolve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A6BE RID: 108222 RVA: 0x0026F557 File Offset: 0x0026D757
		public FKuroMaterialControllerParam_Dissolve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A6BF RID: 108223 RVA: 0x0026F562 File Offset: 0x0026D762
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_Dissolve(Pointer, false, true);
		}

		// Token: 0x0601A6C0 RID: 108224 RVA: 0x0026F56C File Offset: 0x0026D76C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_Dissolve(Pointer, MemoryOwner);
		}

		// Token: 0x0400E50C RID: 58636
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Dissolve";

		// Token: 0x0400E50D RID: 58637
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E50E RID: 58638
		internal static int __PropertyOffset_DissolveChannel;

		// Token: 0x0400E50F RID: 58639
		internal static int __PropertyOffset_DissolveProgress;

		// Token: 0x0400E510 RID: 58640
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _DissolveProgress;

		// Token: 0x0400E511 RID: 58641
		internal static int __PropertyOffset_DissolveSmooth;

		// Token: 0x0400E512 RID: 58642
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _DissolveSmooth;

		// Token: 0x0400E513 RID: 58643
		internal static int __PropertyOffset_DissolveColorIntensity;

		// Token: 0x0400E514 RID: 58644
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _DissolveColorIntensity;

		// Token: 0x0400E515 RID: 58645
		internal static int __PropertyOffset_DissolveColor;

		// Token: 0x0400E516 RID: 58646
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _DissolveColor;
	}
}
