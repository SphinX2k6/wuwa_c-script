using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DDE RID: 3550
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroMainLightColor")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionKuroMainLightColor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C048 RID: 49224 RVA: 0x00114372 File Offset: 0x00112572
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroMainLightColor._ClassPtr;
		}

		// Token: 0x0600C049 RID: 49225 RVA: 0x00114380 File Offset: 0x00112580
		public UMaterialExpressionKuroMainLightColor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroMainLightColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C04A RID: 49226 RVA: 0x001143A8 File Offset: 0x001125A8
		[NullableContext(1)]
		public UMaterialExpressionKuroMainLightColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroMainLightColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x0600C04B RID: 49227 RVA: 0x001143DB File Offset: 0x001125DB
		// (set) Token: 0x0600C04C RID: 49228 RVA: 0x001143F4 File Offset: 0x001125F4
		public unsafe bool bDivPi
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionKuroMainLightColor.__PropertyOffset_bDivPi) & UMaterialExpressionKuroMainLightColor.__PropertyMask_bDivPi) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionKuroMainLightColor.__PropertyOffset_bDivPi) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionKuroMainLightColor.__PropertyOffset_bDivPi) & ~UMaterialExpressionKuroMainLightColor.__PropertyMask_bDivPi) | (value ? UMaterialExpressionKuroMainLightColor.__PropertyMask_bDivPi : 0));
			}
		}

		// Token: 0x0600C04D RID: 49229 RVA: 0x00114424 File Offset: 0x00112624
		static UMaterialExpressionKuroMainLightColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroMainLightColor");
		}

		// Token: 0x0600C04E RID: 49230 RVA: 0x00114432 File Offset: 0x00112632
		protected UMaterialExpressionKuroMainLightColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065F7 RID: 26103
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroMainLightColor";

		// Token: 0x040065F8 RID: 26104
		private static IntPtr _ClassPtr;

		// Token: 0x040065F9 RID: 26105
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065FA RID: 26106
		internal static int __PropertyOffset_bDivPi;

		// Token: 0x040065FB RID: 26107
		internal static byte __PropertyMask_bDivPi;
	}
}
