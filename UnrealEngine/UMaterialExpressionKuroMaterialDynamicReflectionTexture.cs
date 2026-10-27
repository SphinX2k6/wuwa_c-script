using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE0 RID: 3552
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroMaterialDynamicReflectionTexture")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionKuroMaterialDynamicReflectionTexture : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C054 RID: 49236 RVA: 0x001144BA File Offset: 0x001126BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroMaterialDynamicReflectionTexture._ClassPtr;
		}

		// Token: 0x0600C055 RID: 49237 RVA: 0x001144C8 File Offset: 0x001126C8
		public UMaterialExpressionKuroMaterialDynamicReflectionTexture() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroMaterialDynamicReflectionTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C056 RID: 49238 RVA: 0x001144F0 File Offset: 0x001126F0
		public UMaterialExpressionKuroMaterialDynamicReflectionTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroMaterialDynamicReflectionTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x0600C057 RID: 49239 RVA: 0x00114524 File Offset: 0x00112724
		// (set) Token: 0x0600C058 RID: 49240 RVA: 0x0011455D File Offset: 0x0011275D
		public FExpressionInput UVs
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._UVs) == null)
				{
					result = (this._UVs = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroMaterialDynamicReflectionTexture.__PropertyOffset_UVs, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroMaterialDynamicReflectionTexture.__PropertyOffset_UVs, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C059 RID: 49241 RVA: 0x0011457E File Offset: 0x0011277E
		static UMaterialExpressionKuroMaterialDynamicReflectionTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroMaterialDynamicReflectionTexture");
		}

		// Token: 0x0600C05A RID: 49242 RVA: 0x0011458C File Offset: 0x0011278C
		protected UMaterialExpressionKuroMaterialDynamicReflectionTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065FF RID: 26111
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroMaterialDynamicReflectionTexture";

		// Token: 0x04006600 RID: 26112
		private static IntPtr _ClassPtr;

		// Token: 0x04006601 RID: 26113
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006602 RID: 26114
		internal static int __PropertyOffset_UVs;

		// Token: 0x04006603 RID: 26115
		[Nullable(2)]
		private FExpressionInput _UVs;
	}
}
