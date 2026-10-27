using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E56 RID: 3670
	[UnrealObjectPath("/Script/Engine.MaterialExpressionStaticBoolParameter")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMaterialExpressionStaticBoolParameter : UMaterialExpressionParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C4C7 RID: 50375 RVA: 0x0011CAF3 File Offset: 0x0011ACF3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionStaticBoolParameter._ClassPtr;
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x0011CB00 File Offset: 0x0011AD00
		public UMaterialExpressionStaticBoolParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticBoolParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x0011CB28 File Offset: 0x0011AD28
		[NullableContext(1)]
		public UMaterialExpressionStaticBoolParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticBoolParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0600C4CA RID: 50378 RVA: 0x0011CB5B File Offset: 0x0011AD5B
		// (set) Token: 0x0600C4CB RID: 50379 RVA: 0x0011CB74 File Offset: 0x0011AD74
		public unsafe bool DefaultValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionStaticBoolParameter.__PropertyOffset_DefaultValue) & UMaterialExpressionStaticBoolParameter.__PropertyMask_DefaultValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionStaticBoolParameter.__PropertyOffset_DefaultValue) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionStaticBoolParameter.__PropertyOffset_DefaultValue) & ~UMaterialExpressionStaticBoolParameter.__PropertyMask_DefaultValue) | (value ? UMaterialExpressionStaticBoolParameter.__PropertyMask_DefaultValue : 0));
			}
		}

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x0600C4CC RID: 50380 RVA: 0x0011CBA4 File Offset: 0x0011ADA4
		// (set) Token: 0x0600C4CD RID: 50381 RVA: 0x0011CBDD File Offset: 0x0011ADDD
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<ERHIFeatureLevelStrip>> StripFeatureLevels
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<ERHIFeatureLevelStrip>> result;
				if ((result = this._StripFeatureLevels) == null)
				{
					result = (this._StripFeatureLevels = new TArray<TEnumAsByte<ERHIFeatureLevelStrip>>(base.NativePtr + (IntPtr)UMaterialExpressionStaticBoolParameter.__PropertyOffset_StripFeatureLevels, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.StripFeatureLevels.CopyAssign(value);
			}
		}

		// Token: 0x0600C4CE RID: 50382 RVA: 0x0011CBEB File Offset: 0x0011ADEB
		static UMaterialExpressionStaticBoolParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionStaticBoolParameter");
		}

		// Token: 0x0600C4CF RID: 50383 RVA: 0x0011CBF9 File Offset: 0x0011ADF9
		protected UMaterialExpressionStaticBoolParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006923 RID: 26915
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionStaticBoolParameter";

		// Token: 0x04006924 RID: 26916
		private static IntPtr _ClassPtr;

		// Token: 0x04006925 RID: 26917
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006926 RID: 26918
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x04006927 RID: 26919
		internal static byte __PropertyMask_DefaultValue;

		// Token: 0x04006928 RID: 26920
		internal static int __PropertyOffset_StripFeatureLevels;

		// Token: 0x04006929 RID: 26921
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ERHIFeatureLevelStrip>> _StripFeatureLevels;
	}
}
