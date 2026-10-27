using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BBD RID: 7101
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSkyVolumetricCloudMPCParams")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FKuroSkyVolumetricCloudMPCParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B374 RID: 111476 RVA: 0x00281A84 File Offset: 0x0027FC84
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSkyVolumetricCloudMPCParams._ScriptStructPtr != 0) ? FKuroSkyVolumetricCloudMPCParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSkyVolumetricCloudMPCParams", ref FKuroSkyVolumetricCloudMPCParams._ScriptStructPtr);
		}

		// Token: 0x17006D40 RID: 27968
		// (get) Token: 0x0601B375 RID: 111477 RVA: 0x00281AA8 File Offset: 0x0027FCA8
		// (set) Token: 0x0601B376 RID: 111478 RVA: 0x00281AC1 File Offset: 0x0027FCC1
		public unsafe bool bOverride_FloatParameters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudMPCParams.__PropertyOffset_bOverride_FloatParameters) & FKuroSkyVolumetricCloudMPCParams.__PropertyMask_bOverride_FloatParameters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudMPCParams.__PropertyOffset_bOverride_FloatParameters) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudMPCParams.__PropertyOffset_bOverride_FloatParameters) & ~FKuroSkyVolumetricCloudMPCParams.__PropertyMask_bOverride_FloatParameters) | (value ? FKuroSkyVolumetricCloudMPCParams.__PropertyMask_bOverride_FloatParameters : 0));
			}
		}

		// Token: 0x17006D41 RID: 27969
		// (get) Token: 0x0601B377 RID: 111479 RVA: 0x00281AF4 File Offset: 0x0027FCF4
		// (set) Token: 0x0601B378 RID: 111480 RVA: 0x00281B37 File Offset: 0x0027FD37
		public TMap<FName, float> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, float>(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudMPCParams.__PropertyOffset_FloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006D42 RID: 27970
		// (get) Token: 0x0601B379 RID: 111481 RVA: 0x00281B45 File Offset: 0x0027FD45
		// (set) Token: 0x0601B37A RID: 111482 RVA: 0x00281B5E File Offset: 0x0027FD5E
		public unsafe bool bOverride_ColorParameters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudMPCParams.__PropertyOffset_bOverride_ColorParameters) & FKuroSkyVolumetricCloudMPCParams.__PropertyMask_bOverride_ColorParameters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudMPCParams.__PropertyOffset_bOverride_ColorParameters) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudMPCParams.__PropertyOffset_bOverride_ColorParameters) & ~FKuroSkyVolumetricCloudMPCParams.__PropertyMask_bOverride_ColorParameters) | (value ? FKuroSkyVolumetricCloudMPCParams.__PropertyMask_bOverride_ColorParameters : 0));
			}
		}

		// Token: 0x17006D43 RID: 27971
		// (get) Token: 0x0601B37B RID: 111483 RVA: 0x00281B90 File Offset: 0x0027FD90
		// (set) Token: 0x0601B37C RID: 111484 RVA: 0x00281BD3 File Offset: 0x0027FDD3
		public TMap<FName, FLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudMPCParams.__PropertyOffset_ColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x0601B37D RID: 111485 RVA: 0x00281BE1 File Offset: 0x0027FDE1
		public FKuroSkyVolumetricCloudMPCParams()
		{
		}

		// Token: 0x0601B37E RID: 111486 RVA: 0x00281BE9 File Offset: 0x0027FDE9
		public FKuroSkyVolumetricCloudMPCParams(bool bOverride_FloatParameters, TMap<FName, float> FloatParameters, bool bOverride_ColorParameters, TMap<FName, FLinearColor> ColorParameters)
		{
			this.bOverride_FloatParameters = bOverride_FloatParameters;
			this.FloatParameters = FloatParameters;
			this.bOverride_ColorParameters = bOverride_ColorParameters;
			this.ColorParameters = ColorParameters;
		}

		// Token: 0x0601B37F RID: 111487 RVA: 0x00281C0E File Offset: 0x0027FE0E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSkyVolumetricCloudMPCParams.StaticStruct();
		}

		// Token: 0x0601B380 RID: 111488 RVA: 0x00281C1A File Offset: 0x0027FE1A
		[NullableContext(2)]
		public FKuroSkyVolumetricCloudMPCParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B381 RID: 111489 RVA: 0x00281C24 File Offset: 0x0027FE24
		public FKuroSkyVolumetricCloudMPCParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B382 RID: 111490 RVA: 0x00281C2F File Offset: 0x0027FE2F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSkyVolumetricCloudMPCParams(Pointer, false, true);
		}

		// Token: 0x0601B383 RID: 111491 RVA: 0x00281C39 File Offset: 0x0027FE39
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSkyVolumetricCloudMPCParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400EA81 RID: 60033
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSkyVolumetricCloudMPCParams";

		// Token: 0x0400EA82 RID: 60034
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EA83 RID: 60035
		internal static int __PropertyOffset_bOverride_FloatParameters;

		// Token: 0x0400EA84 RID: 60036
		internal static byte __PropertyMask_bOverride_FloatParameters;

		// Token: 0x0400EA85 RID: 60037
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400EA86 RID: 60038
		[Nullable(2)]
		private TMap<FName, float> _FloatParameters;

		// Token: 0x0400EA87 RID: 60039
		internal static int __PropertyOffset_bOverride_ColorParameters;

		// Token: 0x0400EA88 RID: 60040
		internal static byte __PropertyMask_bOverride_ColorParameters;

		// Token: 0x0400EA89 RID: 60041
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400EA8A RID: 60042
		[Nullable(2)]
		private TMap<FName, FLinearColor> _ColorParameters;
	}
}
