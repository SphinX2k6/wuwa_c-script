using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000DA RID: 218
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AndroidPermission.AndroidPermissionCallbackProxy")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAndroidPermissionCallbackProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000F69 RID: 3945 RVA: 0x00017DAA File Offset: 0x00015FAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAndroidPermissionCallbackProxy._ClassPtr;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00017DB8 File Offset: 0x00015FB8
		public UAndroidPermissionCallbackProxy() : this(BuiltinUtils.AllocNativeUObject(UAndroidPermissionCallbackProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00017DE0 File Offset: 0x00015FE0
		public UAndroidPermissionCallbackProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAndroidPermissionCallbackProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00017E14 File Offset: 0x00016014
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00017E4D File Offset: 0x0001604D
		public FAndroidPermissionDynamicDelegate OnPermissionsGrantedDynamicDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FAndroidPermissionDynamicDelegate result;
				if ((result = this._OnPermissionsGrantedDynamicDelegate) == null)
				{
					result = (this._OnPermissionsGrantedDynamicDelegate = new FAndroidPermissionDynamicDelegate(base.NativePtr + (IntPtr)UAndroidPermissionCallbackProxy.__PropertyOffset_OnPermissionsGrantedDynamicDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAndroidPermissionCallbackProxy.__PropertyOffset_OnPermissionsGrantedDynamicDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00017E6E File Offset: 0x0001606E
		static UAndroidPermissionCallbackProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AndroidPermission.AndroidPermissionCallbackProxy");
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00017E7C File Offset: 0x0001607C
		protected UAndroidPermissionCallbackProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400036D RID: 877
		public new const string __ObjectPath = "/Script/AndroidPermission.AndroidPermissionCallbackProxy";

		// Token: 0x0400036E RID: 878
		private static IntPtr _ClassPtr;

		// Token: 0x0400036F RID: 879
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000370 RID: 880
		internal static int __PropertyOffset_OnPermissionsGrantedDynamicDelegate;

		// Token: 0x04000371 RID: 881
		[Nullable(2)]
		private FAndroidPermissionDynamicDelegate _OnPermissionsGrantedDynamicDelegate;
	}
}
