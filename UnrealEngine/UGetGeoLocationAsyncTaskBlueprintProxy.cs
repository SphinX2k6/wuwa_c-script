using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000404 RID: 1028
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.GetGeoLocationAsyncTaskBlueprintProxy")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UGetGeoLocationAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600374F RID: 14159 RVA: 0x00053F60 File Offset: 0x00052160
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGetGeoLocationAsyncTaskBlueprintProxy._ClassPtr;
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x00053F6C File Offset: 0x0005216C
		public UGetGeoLocationAsyncTaskBlueprintProxy() : this(BuiltinUtils.AllocNativeUObject(UGetGeoLocationAsyncTaskBlueprintProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x00053F94 File Offset: 0x00052194
		public UGetGeoLocationAsyncTaskBlueprintProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGetGeoLocationAsyncTaskBlueprintProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x00053FC8 File Offset: 0x000521C8
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x00054001 File Offset: 0x00052201
		public FGetGeoLocationDelegate OnSuccess
		{
			get
			{
				base.FastCheckIsValid();
				FGetGeoLocationDelegate result;
				if ((result = this._OnSuccess) == null)
				{
					result = (this._OnSuccess = new FGetGeoLocationDelegate(base.NativePtr + (IntPtr)UGetGeoLocationAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGetGeoLocationAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x00054024 File Offset: 0x00052224
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x0005405D File Offset: 0x0005225D
		public FGetGeoLocationDelegate OnFailed
		{
			get
			{
				base.FastCheckIsValid();
				FGetGeoLocationDelegate result;
				if ((result = this._OnFailed) == null)
				{
					result = (this._OnFailed = new FGetGeoLocationDelegate(base.NativePtr + (IntPtr)UGetGeoLocationAsyncTaskBlueprintProxy.__PropertyOffset_OnFailed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGetGeoLocationAsyncTaskBlueprintProxy.__PropertyOffset_OnFailed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x0005407E File Offset: 0x0005227E
		[NullableContext(2)]
		public static UGetGeoLocationAsyncTaskBlueprintProxy GetGeoLocationAtWorldPosition(UObject WorldContextObject, in FVector WorldPosition)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGetGeoLocationAsyncTaskBlueprintProxy>(UGetGeoLocationAsyncTaskBlueprintProxy.__GetGeoLocationAtWorldPosition_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WorldPosition));
		}

		// Token: 0x06003757 RID: 14167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGeoLocationAtWorldPosition_Internal(IntPtr WorldContextObject, in FVector WorldPosition);

		// Token: 0x06003758 RID: 14168 RVA: 0x0005409B File Offset: 0x0005229B
		static UGetGeoLocationAsyncTaskBlueprintProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.GetGeoLocationAsyncTaskBlueprintProxy");
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x000540A9 File Offset: 0x000522A9
		protected UGetGeoLocationAsyncTaskBlueprintProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001928 RID: 6440
		public new const string __ObjectPath = "/Script/AugmentedReality.GetGeoLocationAsyncTaskBlueprintProxy";

		// Token: 0x04001929 RID: 6441
		private static IntPtr _ClassPtr;

		// Token: 0x0400192A RID: 6442
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400192B RID: 6443
		public static IntPtr __GetGeoLocationDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400192C RID: 6444
		internal static int __PropertyOffset_OnSuccess;

		// Token: 0x0400192D RID: 6445
		[Nullable(2)]
		private FGetGeoLocationDelegate _OnSuccess;

		// Token: 0x0400192E RID: 6446
		internal static int __PropertyOffset_OnFailed;

		// Token: 0x0400192F RID: 6447
		[Nullable(2)]
		private FGetGeoLocationDelegate _OnFailed;
	}
}
