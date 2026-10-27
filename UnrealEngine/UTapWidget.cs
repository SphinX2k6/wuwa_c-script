using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028F0 RID: 10480
	[UnrealObjectPath("/Script/TapCommon.TapWidget")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class UTapWidget : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026DF7 RID: 159223 RVA: 0x003B4C19 File Offset: 0x003B2E19
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapWidget._ClassPtr;
		}

		// Token: 0x06026DF8 RID: 159224 RVA: 0x003B4C28 File Offset: 0x003B2E28
		public UTapWidget() : this(BuiltinUtils.AllocNativeUObject(UTapWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026DF9 RID: 159225 RVA: 0x003B4C50 File Offset: 0x003B2E50
		[NullableContext(1)]
		public UTapWidget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapWidget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026DFA RID: 159226 RVA: 0x003B4C83 File Offset: 0x003B2E83
		static UTapWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapWidget");
		}

		// Token: 0x06026DFB RID: 159227 RVA: 0x003B4C91 File Offset: 0x003B2E91
		protected UTapWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401557D RID: 87421
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TapCommon.TapWidget";

		// Token: 0x0401557E RID: 87422
		private static IntPtr _ClassPtr;

		// Token: 0x0401557F RID: 87423
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
