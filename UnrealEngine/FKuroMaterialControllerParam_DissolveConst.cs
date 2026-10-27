using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B42 RID: 6978
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_DissolveConst")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroMaterialControllerParam_DissolveConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A6C1 RID: 108225 RVA: 0x0026F575 File Offset: 0x0026D775
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_DissolveConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_DissolveConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_DissolveConst", ref FKuroMaterialControllerParam_DissolveConst._ScriptStructPtr);
		}

		// Token: 0x17006A3C RID: 27196
		// (get) Token: 0x0601A6C2 RID: 108226 RVA: 0x0026F599 File Offset: 0x0026D799
		// (set) Token: 0x0601A6C3 RID: 108227 RVA: 0x0026F5A9 File Offset: 0x0026D7A9
		public unsafe EKuroCharacterControllerChannelSwitch DissolveChannel
		{
			get
			{
				return (EKuroCharacterControllerChannelSwitch)(*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveChannel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveChannel) = (byte)value;
			}
		}

		// Token: 0x17006A3D RID: 27197
		// (get) Token: 0x0601A6C4 RID: 108228 RVA: 0x0026F5BA File Offset: 0x0026D7BA
		// (set) Token: 0x0601A6C5 RID: 108229 RVA: 0x0026F5CA File Offset: 0x0026D7CA
		public unsafe float DissolveProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveProgress) = value;
			}
		}

		// Token: 0x17006A3E RID: 27198
		// (get) Token: 0x0601A6C6 RID: 108230 RVA: 0x0026F5DB File Offset: 0x0026D7DB
		// (set) Token: 0x0601A6C7 RID: 108231 RVA: 0x0026F5EB File Offset: 0x0026D7EB
		public unsafe float DissolveSmooth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveSmooth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveSmooth) = value;
			}
		}

		// Token: 0x17006A3F RID: 27199
		// (get) Token: 0x0601A6C8 RID: 108232 RVA: 0x0026F5FC File Offset: 0x0026D7FC
		// (set) Token: 0x0601A6C9 RID: 108233 RVA: 0x0026F60C File Offset: 0x0026D80C
		public unsafe float DissolveColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveColorIntensity) = value;
			}
		}

		// Token: 0x17006A40 RID: 27200
		// (get) Token: 0x0601A6CA RID: 108234 RVA: 0x0026F61D File Offset: 0x0026D81D
		// (set) Token: 0x0601A6CB RID: 108235 RVA: 0x0026F631 File Offset: 0x0026D831
		public unsafe FLinearColor DissolveColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DissolveConst.__PropertyOffset_DissolveColor) = value;
			}
		}

		// Token: 0x0601A6CC RID: 108236 RVA: 0x0026F646 File Offset: 0x0026D846
		public FKuroMaterialControllerParam_DissolveConst()
		{
		}

		// Token: 0x0601A6CD RID: 108237 RVA: 0x0026F64E File Offset: 0x0026D84E
		public FKuroMaterialControllerParam_DissolveConst(EKuroCharacterControllerChannelSwitch DissolveChannel, float DissolveProgress, float DissolveSmooth, float DissolveColorIntensity, FLinearColor DissolveColor)
		{
			this.DissolveChannel = DissolveChannel;
			this.DissolveProgress = DissolveProgress;
			this.DissolveSmooth = DissolveSmooth;
			this.DissolveColorIntensity = DissolveColorIntensity;
			this.DissolveColor = DissolveColor;
		}

		// Token: 0x0601A6CE RID: 108238 RVA: 0x0026F67B File Offset: 0x0026D87B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_DissolveConst.StaticStruct();
		}

		// Token: 0x0601A6CF RID: 108239 RVA: 0x0026F687 File Offset: 0x0026D887
		[NullableContext(2)]
		public FKuroMaterialControllerParam_DissolveConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A6D0 RID: 108240 RVA: 0x0026F691 File Offset: 0x0026D891
		public FKuroMaterialControllerParam_DissolveConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A6D1 RID: 108241 RVA: 0x0026F69C File Offset: 0x0026D89C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_DissolveConst(Pointer, false, true);
		}

		// Token: 0x0601A6D2 RID: 108242 RVA: 0x0026F6A6 File Offset: 0x0026D8A6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_DissolveConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E517 RID: 58647
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_DissolveConst";

		// Token: 0x0400E518 RID: 58648
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E519 RID: 58649
		internal static int __PropertyOffset_DissolveChannel;

		// Token: 0x0400E51A RID: 58650
		internal static int __PropertyOffset_DissolveProgress;

		// Token: 0x0400E51B RID: 58651
		internal static int __PropertyOffset_DissolveSmooth;

		// Token: 0x0400E51C RID: 58652
		internal static int __PropertyOffset_DissolveColorIntensity;

		// Token: 0x0400E51D RID: 58653
		internal static int __PropertyOffset_DissolveColor;
	}
}
