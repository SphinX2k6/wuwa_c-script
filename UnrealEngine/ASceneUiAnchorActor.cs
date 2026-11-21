using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200051F RID: 1311
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSceneUI.SceneUiAnchorActor")]
	[UnrealStructLayout(1328, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1328)]
	public class ASceneUiAnchorActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007AAA RID: 31402 RVA: 0x000B3E65 File Offset: 0x000B2065
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASceneUiAnchorActor._ClassPtr;
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x000B3E74 File Offset: 0x000B2074
		public ASceneUiAnchorActor() : this(BuiltinUtils.AllocNativeUObject(ASceneUiAnchorActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x000B3E9C File Offset: 0x000B209C
		public ASceneUiAnchorActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASceneUiAnchorActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06007AAD RID: 31405 RVA: 0x000B3ECF File Offset: 0x000B20CF
		// (set) Token: 0x06007AAE RID: 31406 RVA: 0x000B3EE3 File Offset: 0x000B20E3
		public unsafe string DefaultViewName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ASceneUiAnchorActor.__PropertyOffset_DefaultViewName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ASceneUiAnchorActor.__PropertyOffset_DefaultViewName)), value);
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06007AAF RID: 31407 RVA: 0x000B3EF8 File Offset: 0x000B20F8
		// (set) Token: 0x06007AB0 RID: 31408 RVA: 0x000B3F08 File Offset: 0x000B2108
		public unsafe bool bLockFaceCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ASceneUiAnchorActor.__PropertyOffset_bLockFaceCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ASceneUiAnchorActor.__PropertyOffset_bLockFaceCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06007AB1 RID: 31409 RVA: 0x000B3F1C File Offset: 0x000B211C
		// (set) Token: 0x06007AB2 RID: 31410 RVA: 0x000B3F55 File Offset: 0x000B2155
		public TMap<string, string> PendingOpenParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._PendingOpenParams) == null)
				{
					result = (this._PendingOpenParams = new TMap<string, string>(base.NativePtr + (IntPtr)ASceneUiAnchorActor.__PropertyOffset_PendingOpenParams, this));
				}
				return result;
			}
			set
			{
				this.PendingOpenParams.CopyAssign(value);
			}
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x000B3F64 File Offset: 0x000B2164
		public unsafe void Preload(string ViewName)
		{
			FString fstring = FString.AllocTemp(ViewName);
			ASceneUiAnchorActor.__Preload_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x000B3F90 File Offset: 0x000B2190
		public unsafe void OpenWithMap(string ViewName, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TMap<string, string> Params)
		{
			FString fstring = FString.AllocTemp(ViewName);
			ASceneUiAnchorActor.__OpenWithMap_Internal(base.NativePtr, fstring, (Params ?? new TMap<string, string>()).NativeMapPtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x000B3FCA File Offset: 0x000B21CA
		public void OpenDefault()
		{
			ASceneUiAnchorActor.__OpenDefault_Internal(base.NativePtr);
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x000B3FD8 File Offset: 0x000B21D8
		public unsafe void Open(string ViewName, string Param)
		{
			FString fstring = FString.AllocTemp(ViewName);
			FString fstring2 = FString.AllocTemp(Param);
			ASceneUiAnchorActor.__Open_Internal(base.NativePtr, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x000B4014 File Offset: 0x000B2214
		public void Hide()
		{
			ASceneUiAnchorActor.__Hide_Internal(base.NativePtr);
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x000B4021 File Offset: 0x000B2221
		public void DestroyUi()
		{
			ASceneUiAnchorActor.__DestroyUi_Internal(base.NativePtr);
		}

		// Token: 0x06007AB9 RID: 31417 RVA: 0x000B402E File Offset: 0x000B222E
		public void CloseUi()
		{
			ASceneUiAnchorActor.__CloseUi_Internal(base.NativePtr);
		}

		// Token: 0x06007ABA RID: 31418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Preload_Internal(IntPtr @this, in FString ViewName);

		// Token: 0x06007ABB RID: 31419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenWithMap_Internal(IntPtr @this, in FString ViewName, IntPtr Params);

		// Token: 0x06007ABC RID: 31420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenDefault_Internal(IntPtr @this);

		// Token: 0x06007ABD RID: 31421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Open_Internal(IntPtr @this, in FString ViewName, in FString Param);

		// Token: 0x06007ABE RID: 31422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Hide_Internal(IntPtr @this);

		// Token: 0x06007ABF RID: 31423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyUi_Internal(IntPtr @this);

		// Token: 0x06007AC0 RID: 31424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CloseUi_Internal(IntPtr @this);

		// Token: 0x06007AC1 RID: 31425 RVA: 0x000B403B File Offset: 0x000B223B
		static ASceneUiAnchorActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSceneUI.SceneUiAnchorActor");
		}

		// Token: 0x06007AC2 RID: 31426 RVA: 0x000B4049 File Offset: 0x000B2249
		protected ASceneUiAnchorActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400342A RID: 13354
		public new const string __ObjectPath = "/Script/KuroSceneUI.SceneUiAnchorActor";

		// Token: 0x0400342B RID: 13355
		private static IntPtr _ClassPtr;

		// Token: 0x0400342C RID: 13356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400342D RID: 13357
		internal static int __PropertyOffset_DefaultViewName;

		// Token: 0x0400342E RID: 13358
		internal static int __PropertyOffset_bLockFaceCamera;

		// Token: 0x0400342F RID: 13359
		internal static int __PropertyOffset_PendingOpenParams;

		// Token: 0x04003430 RID: 13360
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _PendingOpenParams;
	}
}
