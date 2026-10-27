using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D9A RID: 3482
	[UnrealObjectPath("/Script/Engine.MaterialExpressionChannelMaskParameter")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UMaterialExpressionChannelMaskParameter : UMaterialExpressionVectorParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDBF RID: 48575 RVA: 0x0010F8F1 File Offset: 0x0010DAF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionChannelMaskParameter._ClassPtr;
		}

		// Token: 0x0600BDC0 RID: 48576 RVA: 0x0010F900 File Offset: 0x0010DB00
		public UMaterialExpressionChannelMaskParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionChannelMaskParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x0010F928 File Offset: 0x0010DB28
		[NullableContext(1)]
		public UMaterialExpressionChannelMaskParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionChannelMaskParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x0600BDC2 RID: 48578 RVA: 0x0010F95B File Offset: 0x0010DB5B
		// (set) Token: 0x0600BDC3 RID: 48579 RVA: 0x0010F96F File Offset: 0x0010DB6F
		public unsafe TEnumAsByte<EChannelMaskParameterColor> MaskChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionChannelMaskParameter.__PropertyOffset_MaskChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionChannelMaskParameter.__PropertyOffset_MaskChannel) = value;
			}
		}

		// Token: 0x0600BDC4 RID: 48580 RVA: 0x0010F984 File Offset: 0x0010DB84
		static UMaterialExpressionChannelMaskParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionChannelMaskParameter");
		}

		// Token: 0x0600BDC5 RID: 48581 RVA: 0x0010F992 File Offset: 0x0010DB92
		protected UMaterialExpressionChannelMaskParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006435 RID: 25653
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionChannelMaskParameter";

		// Token: 0x04006436 RID: 25654
		private static IntPtr _ClassPtr;

		// Token: 0x04006437 RID: 25655
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006438 RID: 25656
		internal static int __PropertyOffset_MaskChannel;
	}
}
