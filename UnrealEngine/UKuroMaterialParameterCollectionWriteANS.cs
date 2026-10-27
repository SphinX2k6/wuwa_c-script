using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B6F RID: 7023
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialParameterCollectionWriteANS")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UKuroMaterialParameterCollectionWriteANS : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A939 RID: 108857 RVA: 0x00272FA8 File Offset: 0x002711A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialParameterCollectionWriteANS._ClassPtr;
		}

		// Token: 0x0601A93A RID: 108858 RVA: 0x00272FB4 File Offset: 0x002711B4
		public UKuroMaterialParameterCollectionWriteANS() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialParameterCollectionWriteANS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A93B RID: 108859 RVA: 0x00272FDC File Offset: 0x002711DC
		public UKuroMaterialParameterCollectionWriteANS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialParameterCollectionWriteANS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AC5 RID: 27333
		// (get) Token: 0x0601A93C RID: 108860 RVA: 0x00273010 File Offset: 0x00271210
		// (set) Token: 0x0601A93D RID: 108861 RVA: 0x00273049 File Offset: 0x00271249
		public TMap<FName, FKuroCurveFloat> FloatParam
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParam) == null)
				{
					result = (this._FloatParam = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UKuroMaterialParameterCollectionWriteANS.__PropertyOffset_FloatParam, this));
				}
				return result;
			}
			set
			{
				this.FloatParam.CopyAssign(value);
			}
		}

		// Token: 0x17006AC6 RID: 27334
		// (get) Token: 0x0601A93E RID: 108862 RVA: 0x00273058 File Offset: 0x00271258
		// (set) Token: 0x0601A93F RID: 108863 RVA: 0x00273091 File Offset: 0x00271291
		public TMap<FName, FKuroCurveLinearColor> ColorParam
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParam) == null)
				{
					result = (this._ColorParam = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UKuroMaterialParameterCollectionWriteANS.__PropertyOffset_ColorParam, this));
				}
				return result;
			}
			set
			{
				this.ColorParam.CopyAssign(value);
			}
		}

		// Token: 0x17006AC7 RID: 27335
		// (get) Token: 0x0601A940 RID: 108864 RVA: 0x0027309F File Offset: 0x0027129F
		// (set) Token: 0x0601A941 RID: 108865 RVA: 0x002730B3 File Offset: 0x002712B3
		[Nullable(2)]
		public unsafe UMaterialParameterCollection MPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialParameterCollectionWriteANS.__PropertyOffset_MPC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialParameterCollectionWriteANS.__PropertyOffset_MPC, value);
			}
		}

		// Token: 0x17006AC8 RID: 27336
		// (get) Token: 0x0601A942 RID: 108866 RVA: 0x002730C8 File Offset: 0x002712C8
		// (set) Token: 0x0601A943 RID: 108867 RVA: 0x002730D8 File Offset: 0x002712D8
		public unsafe bool KeepSetValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialParameterCollectionWriteANS.__PropertyOffset_KeepSetValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialParameterCollectionWriteANS.__PropertyOffset_KeepSetValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A944 RID: 108868 RVA: 0x002730E9 File Offset: 0x002712E9
		static UKuroMaterialParameterCollectionWriteANS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialParameterCollectionWriteANS");
		}

		// Token: 0x0601A945 RID: 108869 RVA: 0x002730F7 File Offset: 0x002712F7
		protected UKuroMaterialParameterCollectionWriteANS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E638 RID: 58936
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialParameterCollectionWriteANS";

		// Token: 0x0400E639 RID: 58937
		private static IntPtr _ClassPtr;

		// Token: 0x0400E63A RID: 58938
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E63B RID: 58939
		internal static int __PropertyOffset_FloatParam;

		// Token: 0x0400E63C RID: 58940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParam;

		// Token: 0x0400E63D RID: 58941
		internal static int __PropertyOffset_ColorParam;

		// Token: 0x0400E63E RID: 58942
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParam;

		// Token: 0x0400E63F RID: 58943
		internal static int __PropertyOffset_MPC;

		// Token: 0x0400E640 RID: 58944
		internal static int __PropertyOffset_KeepSetValue;
	}
}
