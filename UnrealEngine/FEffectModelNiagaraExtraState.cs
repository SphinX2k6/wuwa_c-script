using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018A8 RID: 6312
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelNiagaraExtraState")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FEffectModelNiagaraExtraState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601743C RID: 95292 RVA: 0x0021F1A4 File Offset: 0x0021D3A4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEffectModelNiagaraExtraState._ScriptStructPtr != 0) ? FEffectModelNiagaraExtraState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.EffectModelNiagaraExtraState", ref FEffectModelNiagaraExtraState._ScriptStructPtr);
		}

		// Token: 0x17005DAA RID: 23978
		// (get) Token: 0x0601743D RID: 95293 RVA: 0x0021F1C8 File Offset: 0x0021D3C8
		// (set) Token: 0x0601743E RID: 95294 RVA: 0x0021F20B File Offset: 0x0021D40B
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)FEffectModelNiagaraExtraState.__PropertyOffset_FloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005DAB RID: 23979
		// (get) Token: 0x0601743F RID: 95295 RVA: 0x0021F21C File Offset: 0x0021D41C
		// (set) Token: 0x06017440 RID: 95296 RVA: 0x0021F25F File Offset: 0x0021D45F
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)FEffectModelNiagaraExtraState.__PropertyOffset_ColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005DAC RID: 23980
		// (get) Token: 0x06017441 RID: 95297 RVA: 0x0021F270 File Offset: 0x0021D470
		// (set) Token: 0x06017442 RID: 95298 RVA: 0x0021F2B3 File Offset: 0x0021D4B3
		public TMap<FName, FKuroCurveVector> VectorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveVector> result;
				if ((result = this._VectorParameters) == null)
				{
					result = (this._VectorParameters = new TMap<FName, FKuroCurveVector>(base.NativePtr + (IntPtr)FEffectModelNiagaraExtraState.__PropertyOffset_VectorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorParameters.CopyAssign(value);
			}
		}

		// Token: 0x06017443 RID: 95299 RVA: 0x0021F2C1 File Offset: 0x0021D4C1
		public FEffectModelNiagaraExtraState()
		{
		}

		// Token: 0x06017444 RID: 95300 RVA: 0x0021F2C9 File Offset: 0x0021D4C9
		public FEffectModelNiagaraExtraState(TMap<FName, FKuroCurveFloat> FloatParameters, TMap<FName, FKuroCurveLinearColor> ColorParameters, TMap<FName, FKuroCurveVector> VectorParameters)
		{
			this.FloatParameters = FloatParameters;
			this.ColorParameters = ColorParameters;
			this.VectorParameters = VectorParameters;
		}

		// Token: 0x06017445 RID: 95301 RVA: 0x0021F2E6 File Offset: 0x0021D4E6
		protected override IntPtr GetUStructPtr()
		{
			return FEffectModelNiagaraExtraState.StaticStruct();
		}

		// Token: 0x06017446 RID: 95302 RVA: 0x0021F2F2 File Offset: 0x0021D4F2
		[NullableContext(2)]
		public FEffectModelNiagaraExtraState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017447 RID: 95303 RVA: 0x0021F2FC File Offset: 0x0021D4FC
		public FEffectModelNiagaraExtraState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017448 RID: 95304 RVA: 0x0021F307 File Offset: 0x0021D507
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEffectModelNiagaraExtraState(Pointer, false, true);
		}

		// Token: 0x06017449 RID: 95305 RVA: 0x0021F311 File Offset: 0x0021D511
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEffectModelNiagaraExtraState(Pointer, MemoryOwner);
		}

		// Token: 0x0400CA03 RID: 51715
		public const string __ObjectPath = "/Script/KuroGameplay.EffectModelNiagaraExtraState";

		// Token: 0x0400CA04 RID: 51716
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CA05 RID: 51717
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400CA06 RID: 51718
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x0400CA07 RID: 51719
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400CA08 RID: 51720
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x0400CA09 RID: 51721
		internal static int __PropertyOffset_VectorParameters;

		// Token: 0x0400CA0A RID: 51722
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveVector> _VectorParameters;
	}
}
