using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E30 RID: 3632
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRuntimeVirtualTextureSampleParameter")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UMaterialExpressionRuntimeVirtualTextureSampleParameter : UMaterialExpressionRuntimeVirtualTextureSample, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C34C RID: 49996 RVA: 0x00119FA3 File Offset: 0x001181A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRuntimeVirtualTextureSampleParameter._ClassPtr;
		}

		// Token: 0x0600C34D RID: 49997 RVA: 0x00119FB0 File Offset: 0x001181B0
		public UMaterialExpressionRuntimeVirtualTextureSampleParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRuntimeVirtualTextureSampleParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C34E RID: 49998 RVA: 0x00119FD8 File Offset: 0x001181D8
		[NullableContext(1)]
		public UMaterialExpressionRuntimeVirtualTextureSampleParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRuntimeVirtualTextureSampleParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x0600C34F RID: 49999 RVA: 0x0011A00B File Offset: 0x0011820B
		// (set) Token: 0x0600C350 RID: 50000 RVA: 0x0011A01F File Offset: 0x0011821F
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSampleParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSampleParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x0600C351 RID: 50001 RVA: 0x0011A034 File Offset: 0x00118234
		// (set) Token: 0x0600C352 RID: 50002 RVA: 0x0011A048 File Offset: 0x00118248
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSampleParameter.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSampleParameter.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x0600C353 RID: 50003 RVA: 0x0011A05D File Offset: 0x0011825D
		// (set) Token: 0x0600C354 RID: 50004 RVA: 0x0011A071 File Offset: 0x00118271
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSampleParameter.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSampleParameter.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x0600C355 RID: 50005 RVA: 0x0011A086 File Offset: 0x00118286
		static UMaterialExpressionRuntimeVirtualTextureSampleParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRuntimeVirtualTextureSampleParameter");
		}

		// Token: 0x0600C356 RID: 50006 RVA: 0x0011A094 File Offset: 0x00118294
		protected UMaterialExpressionRuntimeVirtualTextureSampleParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400681E RID: 26654
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRuntimeVirtualTextureSampleParameter";

		// Token: 0x0400681F RID: 26655
		private static IntPtr _ClassPtr;

		// Token: 0x04006820 RID: 26656
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006821 RID: 26657
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04006822 RID: 26658
		internal static int __PropertyOffset_ExpressionGUID;

		// Token: 0x04006823 RID: 26659
		internal static int __PropertyOffset_Group;
	}
}
