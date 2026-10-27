using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DEB RID: 3563
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLensflareSceneSample")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionLensflareSceneSample : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0CD RID: 49357 RVA: 0x0011543A File Offset: 0x0011363A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLensflareSceneSample._ClassPtr;
		}

		// Token: 0x0600C0CE RID: 49358 RVA: 0x00115448 File Offset: 0x00113648
		public UMaterialExpressionLensflareSceneSample() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLensflareSceneSample.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C0CF RID: 49359 RVA: 0x00115470 File Offset: 0x00113670
		public UMaterialExpressionLensflareSceneSample(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLensflareSceneSample.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x0600C0D0 RID: 49360 RVA: 0x001154A4 File Offset: 0x001136A4
		// (set) Token: 0x0600C0D1 RID: 49361 RVA: 0x001154DD File Offset: 0x001136DD
		public FExpressionInput InputIndex
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._InputIndex) == null)
				{
					result = (this._InputIndex = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLensflareSceneSample.__PropertyOffset_InputIndex, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLensflareSceneSample.__PropertyOffset_InputIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C0D2 RID: 49362 RVA: 0x001154FE File Offset: 0x001136FE
		static UMaterialExpressionLensflareSceneSample()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLensflareSceneSample");
		}

		// Token: 0x0600C0D3 RID: 49363 RVA: 0x0011550C File Offset: 0x0011370C
		protected UMaterialExpressionLensflareSceneSample(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006659 RID: 26201
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLensflareSceneSample";

		// Token: 0x0400665A RID: 26202
		private static IntPtr _ClassPtr;

		// Token: 0x0400665B RID: 26203
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400665C RID: 26204
		internal static int __PropertyOffset_InputIndex;

		// Token: 0x0400665D RID: 26205
		[Nullable(2)]
		private FExpressionInput _InputIndex;
	}
}
