using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C3 RID: 963
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelGhost")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UEffectModelGhost : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005E1B RID: 24091 RVA: 0x000850A6 File Offset: 0x000832A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelGhost._ClassPtr;
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x000850B4 File Offset: 0x000832B4
		public UEffectModelGhost() : this(BuiltinUtils.AllocNativeUObject(UEffectModelGhost.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x000850DC File Offset: 0x000832DC
		public UEffectModelGhost(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06005E1E RID: 24094 RVA: 0x0008510F File Offset: 0x0008330F
		// (set) Token: 0x06005E1F RID: 24095 RVA: 0x00085123 File Offset: 0x00083323
		[Nullable(2)]
		public unsafe UMaterialInstance MaterialRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelGhost.__PropertyOffset_MaterialRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelGhost.__PropertyOffset_MaterialRef, value);
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06005E20 RID: 24096 RVA: 0x00085138 File Offset: 0x00083338
		// (set) Token: 0x06005E21 RID: 24097 RVA: 0x00085171 File Offset: 0x00083371
		public TArray<FName> CustomComponentNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._CustomComponentNames) == null)
				{
					result = (this._CustomComponentNames = new TArray<FName>(base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_CustomComponentNames, this));
				}
				return result;
			}
			set
			{
				this.CustomComponentNames.CopyAssign(value);
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06005E22 RID: 24098 RVA: 0x00085180 File Offset: 0x00083380
		// (set) Token: 0x06005E23 RID: 24099 RVA: 0x000851B9 File Offset: 0x000833B9
		public FKuroCurveFloat AlphaCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._AlphaCurve) == null)
				{
					result = (this._AlphaCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_AlphaCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_AlphaCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06005E24 RID: 24100 RVA: 0x000851DC File Offset: 0x000833DC
		// (set) Token: 0x06005E25 RID: 24101 RVA: 0x00085215 File Offset: 0x00083415
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_FloatParameters, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06005E26 RID: 24102 RVA: 0x00085224 File Offset: 0x00083424
		// (set) Token: 0x06005E27 RID: 24103 RVA: 0x0008525D File Offset: 0x0008345D
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_ColorParameters, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x0008526B File Offset: 0x0008346B
		static UEffectModelGhost()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelGhost");
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x00085279 File Offset: 0x00083479
		protected UEffectModelGhost(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002748 RID: 10056
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelGhost";

		// Token: 0x04002749 RID: 10057
		private static IntPtr _ClassPtr;

		// Token: 0x0400274A RID: 10058
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400274B RID: 10059
		internal static int __PropertyOffset_MaterialRef;

		// Token: 0x0400274C RID: 10060
		internal static int __PropertyOffset_CustomComponentNames;

		// Token: 0x0400274D RID: 10061
		[Nullable(2)]
		private TArray<FName> _CustomComponentNames;

		// Token: 0x0400274E RID: 10062
		internal static int __PropertyOffset_AlphaCurve;

		// Token: 0x0400274F RID: 10063
		[Nullable(2)]
		private FKuroCurveFloat _AlphaCurve;

		// Token: 0x04002750 RID: 10064
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x04002751 RID: 10065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x04002752 RID: 10066
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x04002753 RID: 10067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;
	}
}
