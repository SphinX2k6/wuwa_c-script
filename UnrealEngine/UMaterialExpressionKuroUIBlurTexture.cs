using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE6 RID: 3558
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroUIBlurTexture")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionKuroUIBlurTexture : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C094 RID: 49300 RVA: 0x00114D9A File Offset: 0x00112F9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroUIBlurTexture._ClassPtr;
		}

		// Token: 0x0600C095 RID: 49301 RVA: 0x00114DA8 File Offset: 0x00112FA8
		public UMaterialExpressionKuroUIBlurTexture() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroUIBlurTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C096 RID: 49302 RVA: 0x00114DD0 File Offset: 0x00112FD0
		public UMaterialExpressionKuroUIBlurTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroUIBlurTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x0600C097 RID: 49303 RVA: 0x00114E04 File Offset: 0x00113004
		// (set) Token: 0x0600C098 RID: 49304 RVA: 0x00114E3D File Offset: 0x0011303D
		public FExpressionInput ScreenUV
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ScreenUV) == null)
				{
					result = (this._ScreenUV = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroUIBlurTexture.__PropertyOffset_ScreenUV, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroUIBlurTexture.__PropertyOffset_ScreenUV, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C099 RID: 49305 RVA: 0x00114E5E File Offset: 0x0011305E
		static UMaterialExpressionKuroUIBlurTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroUIBlurTexture");
		}

		// Token: 0x0600C09A RID: 49306 RVA: 0x00114E6C File Offset: 0x0011306C
		protected UMaterialExpressionKuroUIBlurTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006632 RID: 26162
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroUIBlurTexture";

		// Token: 0x04006633 RID: 26163
		private static IntPtr _ClassPtr;

		// Token: 0x04006634 RID: 26164
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006635 RID: 26165
		internal static int __PropertyOffset_ScreenUV;

		// Token: 0x04006636 RID: 26166
		[Nullable(2)]
		private FExpressionInput _ScreenUV;
	}
}
