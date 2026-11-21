using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000668 RID: 1640
	[UnrealObjectPath("/Script/LGUI.LGUIBaseInputModule")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class ULGUIBaseInputModule : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DF2 RID: 36338 RVA: 0x000D5CB9 File Offset: 0x000D3EB9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBaseInputModule._ClassPtr;
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x000D5CC5 File Offset: 0x000D3EC5
		public void ClearEvent()
		{
			ULGUIBaseInputModule.__ClearEvent_Internal(base.NativePtr);
		}

		// Token: 0x06008DF4 RID: 36340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearEvent_Internal(IntPtr @this);

		// Token: 0x06008DF5 RID: 36341 RVA: 0x000D5CD2 File Offset: 0x000D3ED2
		static ULGUIBaseInputModule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBaseInputModule");
		}

		// Token: 0x06008DF6 RID: 36342 RVA: 0x000D5CE0 File Offset: 0x000D3EE0
		protected ULGUIBaseInputModule() : this(BuiltinUtils.AllocNativeUObject(ULGUIBaseInputModule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x000D5D08 File Offset: 0x000D3F08
		protected ULGUIBaseInputModule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E8E RID: 16014
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBaseInputModule";

		// Token: 0x04003E8F RID: 16015
		private static IntPtr _ClassPtr;

		// Token: 0x04003E90 RID: 16016
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
