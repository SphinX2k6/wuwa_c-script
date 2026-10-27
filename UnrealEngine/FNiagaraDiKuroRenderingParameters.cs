using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C12 RID: 7186
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingParameters")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNiagaraDiKuroRenderingParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BB8D RID: 113549 RVA: 0x0028CBBC File Offset: 0x0028ADBC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDiKuroRenderingParameters._ScriptStructPtr != 0) ? FNiagaraDiKuroRenderingParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingParameters", ref FNiagaraDiKuroRenderingParameters._ScriptStructPtr);
		}

		// Token: 0x17006FC9 RID: 28617
		// (get) Token: 0x0601BB8E RID: 113550 RVA: 0x0028CBE0 File Offset: 0x0028ADE0
		// (set) Token: 0x0601BB8F RID: 113551 RVA: 0x0028CC23 File Offset: 0x0028AE23
		public TArray<FNiagaraDiKuroRenderingFloatParam> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDiKuroRenderingFloatParam> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TArray<FNiagaraDiKuroRenderingFloatParam>(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingParameters.__PropertyOffset_FloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006FCA RID: 28618
		// (get) Token: 0x0601BB90 RID: 113552 RVA: 0x0028CC34 File Offset: 0x0028AE34
		// (set) Token: 0x0601BB91 RID: 113553 RVA: 0x0028CC77 File Offset: 0x0028AE77
		public TArray<FNiagaraDiKuroRenderingVectorParam> VectorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDiKuroRenderingVectorParam> result;
				if ((result = this._VectorParameters) == null)
				{
					result = (this._VectorParameters = new TArray<FNiagaraDiKuroRenderingVectorParam>(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingParameters.__PropertyOffset_VectorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006FCB RID: 28619
		// (get) Token: 0x0601BB92 RID: 113554 RVA: 0x0028CC88 File Offset: 0x0028AE88
		// (set) Token: 0x0601BB93 RID: 113555 RVA: 0x0028CCCB File Offset: 0x0028AECB
		public TArray<FNiagaraDiKuroRenderingLinearColorParam> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDiKuroRenderingLinearColorParam> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TArray<FNiagaraDiKuroRenderingLinearColorParam>(base.NativePtr + (IntPtr)FNiagaraDiKuroRenderingParameters.__PropertyOffset_ColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x0601BB94 RID: 113556 RVA: 0x0028CCD9 File Offset: 0x0028AED9
		public FNiagaraDiKuroRenderingParameters()
		{
		}

		// Token: 0x0601BB95 RID: 113557 RVA: 0x0028CCE1 File Offset: 0x0028AEE1
		public FNiagaraDiKuroRenderingParameters(TArray<FNiagaraDiKuroRenderingFloatParam> FloatParameters, TArray<FNiagaraDiKuroRenderingVectorParam> VectorParameters, TArray<FNiagaraDiKuroRenderingLinearColorParam> ColorParameters)
		{
			this.FloatParameters = FloatParameters;
			this.VectorParameters = VectorParameters;
			this.ColorParameters = ColorParameters;
		}

		// Token: 0x0601BB96 RID: 113558 RVA: 0x0028CCFE File Offset: 0x0028AEFE
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDiKuroRenderingParameters.StaticStruct();
		}

		// Token: 0x0601BB97 RID: 113559 RVA: 0x0028CD0A File Offset: 0x0028AF0A
		[NullableContext(2)]
		public FNiagaraDiKuroRenderingParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BB98 RID: 113560 RVA: 0x0028CD14 File Offset: 0x0028AF14
		public FNiagaraDiKuroRenderingParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BB99 RID: 113561 RVA: 0x0028CD1F File Offset: 0x0028AF1F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDiKuroRenderingParameters(Pointer, false, true);
		}

		// Token: 0x0601BB9A RID: 113562 RVA: 0x0028CD29 File Offset: 0x0028AF29
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDiKuroRenderingParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE81 RID: 61057
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDiKuroRenderingParameters";

		// Token: 0x0400EE82 RID: 61058
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE83 RID: 61059
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400EE84 RID: 61060
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDiKuroRenderingFloatParam> _FloatParameters;

		// Token: 0x0400EE85 RID: 61061
		internal static int __PropertyOffset_VectorParameters;

		// Token: 0x0400EE86 RID: 61062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDiKuroRenderingVectorParam> _VectorParameters;

		// Token: 0x0400EE87 RID: 61063
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400EE88 RID: 61064
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDiKuroRenderingLinearColorParam> _ColorParameters;
	}
}
