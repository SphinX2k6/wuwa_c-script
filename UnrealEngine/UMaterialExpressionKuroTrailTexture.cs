using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE5 RID: 3557
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroTrailTexture")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionKuroTrailTexture : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C08B RID: 49291 RVA: 0x00114C9D File Offset: 0x00112E9D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroTrailTexture._ClassPtr;
		}

		// Token: 0x0600C08C RID: 49292 RVA: 0x00114CAC File Offset: 0x00112EAC
		public UMaterialExpressionKuroTrailTexture() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroTrailTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C08D RID: 49293 RVA: 0x00114CD4 File Offset: 0x00112ED4
		public UMaterialExpressionKuroTrailTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroTrailTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x0600C08E RID: 49294 RVA: 0x00114D08 File Offset: 0x00112F08
		// (set) Token: 0x0600C08F RID: 49295 RVA: 0x00114D41 File Offset: 0x00112F41
		public FExpressionInput WorldPosition
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldPosition) == null)
				{
					result = (this._WorldPosition = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroTrailTexture.__PropertyOffset_WorldPosition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroTrailTexture.__PropertyOffset_WorldPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x0600C090 RID: 49296 RVA: 0x00114D62 File Offset: 0x00112F62
		// (set) Token: 0x0600C091 RID: 49297 RVA: 0x00114D72 File Offset: 0x00112F72
		public unsafe EMaterialKuroInputType InputType
		{
			get
			{
				return (EMaterialKuroInputType)(*(base.NativePtr + (IntPtr)UMaterialExpressionKuroTrailTexture.__PropertyOffset_InputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionKuroTrailTexture.__PropertyOffset_InputType) = (byte)value;
			}
		}

		// Token: 0x0600C092 RID: 49298 RVA: 0x00114D83 File Offset: 0x00112F83
		static UMaterialExpressionKuroTrailTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroTrailTexture");
		}

		// Token: 0x0600C093 RID: 49299 RVA: 0x00114D91 File Offset: 0x00112F91
		protected UMaterialExpressionKuroTrailTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400662C RID: 26156
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroTrailTexture";

		// Token: 0x0400662D RID: 26157
		private static IntPtr _ClassPtr;

		// Token: 0x0400662E RID: 26158
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400662F RID: 26159
		internal static int __PropertyOffset_WorldPosition;

		// Token: 0x04006630 RID: 26160
		[Nullable(2)]
		private FExpressionInput _WorldPosition;

		// Token: 0x04006631 RID: 26161
		internal static int __PropertyOffset_InputType;
	}
}
