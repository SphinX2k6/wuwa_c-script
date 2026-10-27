using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A7 RID: 679
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AndroidPermission.AndroidPermissionCallbackProxy")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAndroidPermissionCallbackProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002581 RID: 9601 RVA: 0x000389FB File Offset: 0x00036BFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAndroidPermissionCallbackProxy._ClassPtr;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00038A08 File Offset: 0x00036C08
		public UAndroidPermissionCallbackProxy() : this(BuiltinUtils.AllocNativeUObject(UAndroidPermissionCallbackProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00038A30 File Offset: 0x00036C30
		public UAndroidPermissionCallbackProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAndroidPermissionCallbackProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x00038A64 File Offset: 0x00036C64
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x00038A9D File Offset: 0x00036C9D
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

		// Token: 0x06002586 RID: 9606 RVA: 0x00038ABE File Offset: 0x00036CBE
		static UAndroidPermissionCallbackProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AndroidPermission.AndroidPermissionCallbackProxy");
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00038ACC File Offset: 0x00036CCC
		protected UAndroidPermissionCallbackProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E6D RID: 3693
		public new const string __ObjectPath = "/Script/AndroidPermission.AndroidPermissionCallbackProxy";

		// Token: 0x04000E6E RID: 3694
		private static IntPtr _ClassPtr;

		// Token: 0x04000E6F RID: 3695
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E70 RID: 3696
		internal static int __PropertyOffset_OnPermissionsGrantedDynamicDelegate;

		// Token: 0x04000E71 RID: 3697
		[Nullable(2)]
		private FAndroidPermissionDynamicDelegate _OnPermissionsGrantedDynamicDelegate;
	}
}
