using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF7 RID: 3575
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionMaterialProxyReplace")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionMaterialProxyReplace : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C167 RID: 49511 RVA: 0x001168E2 File Offset: 0x00114AE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionMaterialProxyReplace._ClassPtr;
		}

		// Token: 0x0600C168 RID: 49512 RVA: 0x001168F0 File Offset: 0x00114AF0
		public UMaterialExpressionMaterialProxyReplace() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMaterialProxyReplace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C169 RID: 49513 RVA: 0x00116918 File Offset: 0x00114B18
		public UMaterialExpressionMaterialProxyReplace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMaterialProxyReplace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x0600C16A RID: 49514 RVA: 0x0011694C File Offset: 0x00114B4C
		// (set) Token: 0x0600C16B RID: 49515 RVA: 0x00116985 File Offset: 0x00114B85
		public FExpressionInput Realtime
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Realtime) == null)
				{
					result = (this._Realtime = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMaterialProxyReplace.__PropertyOffset_Realtime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMaterialProxyReplace.__PropertyOffset_Realtime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x0600C16C RID: 49516 RVA: 0x001169A8 File Offset: 0x00114BA8
		// (set) Token: 0x0600C16D RID: 49517 RVA: 0x001169E1 File Offset: 0x00114BE1
		public FExpressionInput MaterialProxy
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._MaterialProxy) == null)
				{
					result = (this._MaterialProxy = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMaterialProxyReplace.__PropertyOffset_MaterialProxy, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMaterialProxyReplace.__PropertyOffset_MaterialProxy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C16E RID: 49518 RVA: 0x00116A02 File Offset: 0x00114C02
		static UMaterialExpressionMaterialProxyReplace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionMaterialProxyReplace");
		}

		// Token: 0x0600C16F RID: 49519 RVA: 0x00116A10 File Offset: 0x00114C10
		protected UMaterialExpressionMaterialProxyReplace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066D2 RID: 26322
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionMaterialProxyReplace";

		// Token: 0x040066D3 RID: 26323
		private static IntPtr _ClassPtr;

		// Token: 0x040066D4 RID: 26324
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040066D5 RID: 26325
		internal static int __PropertyOffset_Realtime;

		// Token: 0x040066D6 RID: 26326
		[Nullable(2)]
		private FExpressionInput _Realtime;

		// Token: 0x040066D7 RID: 26327
		internal static int __PropertyOffset_MaterialProxy;

		// Token: 0x040066D8 RID: 26328
		[Nullable(2)]
		private FExpressionInput _MaterialProxy;
	}
}
