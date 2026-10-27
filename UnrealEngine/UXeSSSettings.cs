using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002AA3 RID: 10915
	[UnrealObjectPath("/Script/XeSSCore.XeSSSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UXeSSSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028397 RID: 164759 RVA: 0x003D2DE3 File Offset: 0x003D0FE3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXeSSSettings._ClassPtr;
		}

		// Token: 0x06028398 RID: 164760 RVA: 0x003D2DF0 File Offset: 0x003D0FF0
		public UXeSSSettings() : this(BuiltinUtils.AllocNativeUObject(UXeSSSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028399 RID: 164761 RVA: 0x003D2E18 File Offset: 0x003D1018
		[NullableContext(1)]
		public UXeSSSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UXeSSSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009975 RID: 39285
		// (get) Token: 0x0602839A RID: 164762 RVA: 0x003D2E4B File Offset: 0x003D104B
		// (set) Token: 0x0602839B RID: 164763 RVA: 0x003D2E5B File Offset: 0x003D105B
		public unsafe bool bEnableXeSSInEditorViewports
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXeSSSettings.__PropertyOffset_bEnableXeSSInEditorViewports) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXeSSSettings.__PropertyOffset_bEnableXeSSInEditorViewports) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602839C RID: 164764 RVA: 0x003D2E6C File Offset: 0x003D106C
		static UXeSSSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/XeSSCore.XeSSSettings");
		}

		// Token: 0x0602839D RID: 164765 RVA: 0x003D2E7A File Offset: 0x003D107A
		protected UXeSSSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040160F2 RID: 90354
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/XeSSCore.XeSSSettings";

		// Token: 0x040160F3 RID: 90355
		private static IntPtr _ClassPtr;

		// Token: 0x040160F4 RID: 90356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040160F5 RID: 90357
		internal static int __PropertyOffset_bEnableXeSSInEditorViewports;
	}
}
