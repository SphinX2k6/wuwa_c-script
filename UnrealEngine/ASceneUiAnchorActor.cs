using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C85 RID: 7301
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSceneUI.SceneUiAnchorActor")]
	[UnrealStructLayout(1328, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1328)]
	public class ASceneUiAnchorActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C562 RID: 116066 RVA: 0x0029C2E1 File Offset: 0x0029A4E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASceneUiAnchorActor._ClassPtr;
		}

		// Token: 0x0601C563 RID: 116067 RVA: 0x0029C2F0 File Offset: 0x0029A4F0
		public ASceneUiAnchorActor() : this(BuiltinUtils.AllocNativeUObject(ASceneUiAnchorActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C564 RID: 116068 RVA: 0x0029C318 File Offset: 0x0029A518
		public ASceneUiAnchorActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASceneUiAnchorActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700728E RID: 29326
		// (get) Token: 0x0601C565 RID: 116069 RVA: 0x0029C34B File Offset: 0x0029A54B
		// (set) Token: 0x0601C566 RID: 116070 RVA: 0x0029C35F File Offset: 0x0029A55F
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

		// Token: 0x1700728F RID: 29327
		// (get) Token: 0x0601C567 RID: 116071 RVA: 0x0029C374 File Offset: 0x0029A574
		// (set) Token: 0x0601C568 RID: 116072 RVA: 0x0029C384 File Offset: 0x0029A584
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

		// Token: 0x17007290 RID: 29328
		// (get) Token: 0x0601C569 RID: 116073 RVA: 0x0029C398 File Offset: 0x0029A598
		// (set) Token: 0x0601C56A RID: 116074 RVA: 0x0029C3D1 File Offset: 0x0029A5D1
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

		// Token: 0x0601C56B RID: 116075 RVA: 0x0029C3E0 File Offset: 0x0029A5E0
		public unsafe void Preload(string ViewName)
		{
			FString fstring = FString.AllocTemp(ViewName);
			ASceneUiAnchorActor.__Preload_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601C56C RID: 116076 RVA: 0x0029C40C File Offset: 0x0029A60C
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

		// Token: 0x0601C56D RID: 116077 RVA: 0x0029C446 File Offset: 0x0029A646
		public void OpenDefault()
		{
			ASceneUiAnchorActor.__OpenDefault_Internal(base.NativePtr);
		}

		// Token: 0x0601C56E RID: 116078 RVA: 0x0029C454 File Offset: 0x0029A654
		public unsafe void Open(string ViewName, string Param)
		{
			FString fstring = FString.AllocTemp(ViewName);
			FString fstring2 = FString.AllocTemp(Param);
			ASceneUiAnchorActor.__Open_Internal(base.NativePtr, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601C56F RID: 116079 RVA: 0x0029C490 File Offset: 0x0029A690
		public void Hide()
		{
			ASceneUiAnchorActor.__Hide_Internal(base.NativePtr);
		}

		// Token: 0x0601C570 RID: 116080 RVA: 0x0029C49D File Offset: 0x0029A69D
		public void DestroyUi()
		{
			ASceneUiAnchorActor.__DestroyUi_Internal(base.NativePtr);
		}

		// Token: 0x0601C571 RID: 116081 RVA: 0x0029C4AA File Offset: 0x0029A6AA
		public void CloseUi()
		{
			ASceneUiAnchorActor.__CloseUi_Internal(base.NativePtr);
		}

		// Token: 0x0601C572 RID: 116082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Preload_Internal(IntPtr @this, in FString ViewName);

		// Token: 0x0601C573 RID: 116083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenWithMap_Internal(IntPtr @this, in FString ViewName, IntPtr Params);

		// Token: 0x0601C574 RID: 116084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenDefault_Internal(IntPtr @this);

		// Token: 0x0601C575 RID: 116085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Open_Internal(IntPtr @this, in FString ViewName, in FString Param);

		// Token: 0x0601C576 RID: 116086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Hide_Internal(IntPtr @this);

		// Token: 0x0601C577 RID: 116087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyUi_Internal(IntPtr @this);

		// Token: 0x0601C578 RID: 116088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CloseUi_Internal(IntPtr @this);

		// Token: 0x0601C579 RID: 116089 RVA: 0x0029C4B7 File Offset: 0x0029A6B7
		static ASceneUiAnchorActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSceneUI.SceneUiAnchorActor");
		}

		// Token: 0x0601C57A RID: 116090 RVA: 0x0029C4C5 File Offset: 0x0029A6C5
		protected ASceneUiAnchorActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F3BC RID: 62396
		public new const string __ObjectPath = "/Script/KuroSceneUI.SceneUiAnchorActor";

		// Token: 0x0400F3BD RID: 62397
		private static IntPtr _ClassPtr;

		// Token: 0x0400F3BE RID: 62398
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F3BF RID: 62399
		internal static int __PropertyOffset_DefaultViewName;

		// Token: 0x0400F3C0 RID: 62400
		internal static int __PropertyOffset_bLockFaceCamera;

		// Token: 0x0400F3C1 RID: 62401
		internal static int __PropertyOffset_PendingOpenParams;

		// Token: 0x0400F3C2 RID: 62402
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _PendingOpenParams;
	}
}
