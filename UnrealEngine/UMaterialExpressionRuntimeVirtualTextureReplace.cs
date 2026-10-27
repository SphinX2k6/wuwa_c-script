using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E2E RID: 3630
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRuntimeVirtualTextureReplace")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionRuntimeVirtualTextureReplace : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C32C RID: 49964 RVA: 0x00119BF9 File Offset: 0x00117DF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRuntimeVirtualTextureReplace._ClassPtr;
		}

		// Token: 0x0600C32D RID: 49965 RVA: 0x00119C08 File Offset: 0x00117E08
		public UMaterialExpressionRuntimeVirtualTextureReplace() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRuntimeVirtualTextureReplace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C32E RID: 49966 RVA: 0x00119C30 File Offset: 0x00117E30
		public UMaterialExpressionRuntimeVirtualTextureReplace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRuntimeVirtualTextureReplace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x0600C32F RID: 49967 RVA: 0x00119C64 File Offset: 0x00117E64
		// (set) Token: 0x0600C330 RID: 49968 RVA: 0x00119C9D File Offset: 0x00117E9D
		public FExpressionInput Default
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Default) == null)
				{
					result = (this._Default = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureReplace.__PropertyOffset_Default, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureReplace.__PropertyOffset_Default, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x0600C331 RID: 49969 RVA: 0x00119CC0 File Offset: 0x00117EC0
		// (set) Token: 0x0600C332 RID: 49970 RVA: 0x00119CF9 File Offset: 0x00117EF9
		public FExpressionInput VirtualTextureOutput
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._VirtualTextureOutput) == null)
				{
					result = (this._VirtualTextureOutput = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureReplace.__PropertyOffset_VirtualTextureOutput, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureReplace.__PropertyOffset_VirtualTextureOutput, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C333 RID: 49971 RVA: 0x00119D1A File Offset: 0x00117F1A
		static UMaterialExpressionRuntimeVirtualTextureReplace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRuntimeVirtualTextureReplace");
		}

		// Token: 0x0600C334 RID: 49972 RVA: 0x00119D28 File Offset: 0x00117F28
		protected UMaterialExpressionRuntimeVirtualTextureReplace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006808 RID: 26632
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRuntimeVirtualTextureReplace";

		// Token: 0x04006809 RID: 26633
		private static IntPtr _ClassPtr;

		// Token: 0x0400680A RID: 26634
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400680B RID: 26635
		internal static int __PropertyOffset_Default;

		// Token: 0x0400680C RID: 26636
		[Nullable(2)]
		private FExpressionInput _Default;

		// Token: 0x0400680D RID: 26637
		internal static int __PropertyOffset_VirtualTextureOutput;

		// Token: 0x0400680E RID: 26638
		[Nullable(2)]
		private FExpressionInput _VirtualTextureOutput;
	}
}
