using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C87 RID: 7303
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSceneUI.SceneUiAnchorSubsystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class USceneUiAnchorSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C585 RID: 116101 RVA: 0x0029C62D File Offset: 0x0029A82D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneUiAnchorSubsystem._ClassPtr;
		}

		// Token: 0x0601C586 RID: 116102 RVA: 0x0029C63C File Offset: 0x0029A83C
		public USceneUiAnchorSubsystem() : this(BuiltinUtils.AllocNativeUObject(USceneUiAnchorSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C587 RID: 116103 RVA: 0x0029C664 File Offset: 0x0029A864
		public USceneUiAnchorSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneUiAnchorSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007291 RID: 29329
		// (get) Token: 0x0601C588 RID: 116104 RVA: 0x0029C698 File Offset: 0x0029A898
		// (set) Token: 0x0601C589 RID: 116105 RVA: 0x0029C6D1 File Offset: 0x0029A8D1
		public FSceneUiPreloadRequest OnPreloadRequest
		{
			get
			{
				base.FastCheckIsValid();
				FSceneUiPreloadRequest result;
				if ((result = this._OnPreloadRequest) == null)
				{
					result = (this._OnPreloadRequest = new FSceneUiPreloadRequest(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnPreloadRequest, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnPreloadRequest, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007292 RID: 29330
		// (get) Token: 0x0601C58A RID: 116106 RVA: 0x0029C6F4 File Offset: 0x0029A8F4
		// (set) Token: 0x0601C58B RID: 116107 RVA: 0x0029C72D File Offset: 0x0029A92D
		public FSceneUiOpenRequest OnOpenRequest
		{
			get
			{
				base.FastCheckIsValid();
				FSceneUiOpenRequest result;
				if ((result = this._OnOpenRequest) == null)
				{
					result = (this._OnOpenRequest = new FSceneUiOpenRequest(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnOpenRequest, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnOpenRequest, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007293 RID: 29331
		// (get) Token: 0x0601C58C RID: 116108 RVA: 0x0029C750 File Offset: 0x0029A950
		// (set) Token: 0x0601C58D RID: 116109 RVA: 0x0029C789 File Offset: 0x0029A989
		public FSceneUiOpenWithMapRequest OnOpenWithMapRequest
		{
			get
			{
				base.FastCheckIsValid();
				FSceneUiOpenWithMapRequest result;
				if ((result = this._OnOpenWithMapRequest) == null)
				{
					result = (this._OnOpenWithMapRequest = new FSceneUiOpenWithMapRequest(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnOpenWithMapRequest, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnOpenWithMapRequest, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007294 RID: 29332
		// (get) Token: 0x0601C58E RID: 116110 RVA: 0x0029C7AC File Offset: 0x0029A9AC
		// (set) Token: 0x0601C58F RID: 116111 RVA: 0x0029C7E5 File Offset: 0x0029A9E5
		public FSceneUiAnchorRequest OnHideRequest
		{
			get
			{
				base.FastCheckIsValid();
				FSceneUiAnchorRequest result;
				if ((result = this._OnHideRequest) == null)
				{
					result = (this._OnHideRequest = new FSceneUiAnchorRequest(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnHideRequest, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnHideRequest, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007295 RID: 29333
		// (get) Token: 0x0601C590 RID: 116112 RVA: 0x0029C808 File Offset: 0x0029AA08
		// (set) Token: 0x0601C591 RID: 116113 RVA: 0x0029C841 File Offset: 0x0029AA41
		public FSceneUiAnchorRequest OnCloseRequest
		{
			get
			{
				base.FastCheckIsValid();
				FSceneUiAnchorRequest result;
				if ((result = this._OnCloseRequest) == null)
				{
					result = (this._OnCloseRequest = new FSceneUiAnchorRequest(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnCloseRequest, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnCloseRequest, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007296 RID: 29334
		// (get) Token: 0x0601C592 RID: 116114 RVA: 0x0029C864 File Offset: 0x0029AA64
		// (set) Token: 0x0601C593 RID: 116115 RVA: 0x0029C89D File Offset: 0x0029AA9D
		public FSceneUiAnchorRequest OnAnchorEndPlay
		{
			get
			{
				base.FastCheckIsValid();
				FSceneUiAnchorRequest result;
				if ((result = this._OnAnchorEndPlay) == null)
				{
					result = (this._OnAnchorEndPlay = new FSceneUiAnchorRequest(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnAnchorEndPlay, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USceneUiAnchorSubsystem.__PropertyOffset_OnAnchorEndPlay, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601C594 RID: 116116 RVA: 0x0029C8BE File Offset: 0x0029AABE
		static USceneUiAnchorSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSceneUI.SceneUiAnchorSubsystem");
		}

		// Token: 0x0601C595 RID: 116117 RVA: 0x0029C8CC File Offset: 0x0029AACC
		protected USceneUiAnchorSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F3C6 RID: 62406
		public new const string __ObjectPath = "/Script/KuroSceneUI.SceneUiAnchorSubsystem";

		// Token: 0x0400F3C7 RID: 62407
		private static IntPtr _ClassPtr;

		// Token: 0x0400F3C8 RID: 62408
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F3C9 RID: 62409
		internal static int __PropertyOffset_OnPreloadRequest;

		// Token: 0x0400F3CA RID: 62410
		[Nullable(2)]
		private FSceneUiPreloadRequest _OnPreloadRequest;

		// Token: 0x0400F3CB RID: 62411
		internal static int __PropertyOffset_OnOpenRequest;

		// Token: 0x0400F3CC RID: 62412
		[Nullable(2)]
		private FSceneUiOpenRequest _OnOpenRequest;

		// Token: 0x0400F3CD RID: 62413
		internal static int __PropertyOffset_OnOpenWithMapRequest;

		// Token: 0x0400F3CE RID: 62414
		[Nullable(2)]
		private FSceneUiOpenWithMapRequest _OnOpenWithMapRequest;

		// Token: 0x0400F3CF RID: 62415
		internal static int __PropertyOffset_OnHideRequest;

		// Token: 0x0400F3D0 RID: 62416
		[Nullable(2)]
		private FSceneUiAnchorRequest _OnHideRequest;

		// Token: 0x0400F3D1 RID: 62417
		internal static int __PropertyOffset_OnCloseRequest;

		// Token: 0x0400F3D2 RID: 62418
		[Nullable(2)]
		private FSceneUiAnchorRequest _OnCloseRequest;

		// Token: 0x0400F3D3 RID: 62419
		internal static int __PropertyOffset_OnAnchorEndPlay;

		// Token: 0x0400F3D4 RID: 62420
		[Nullable(2)]
		private FSceneUiAnchorRequest _OnAnchorEndPlay;
	}
}
