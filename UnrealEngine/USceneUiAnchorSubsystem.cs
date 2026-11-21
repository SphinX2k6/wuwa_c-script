using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000521 RID: 1313
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSceneUI.SceneUiAnchorSubsystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class USceneUiAnchorSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007ACD RID: 31437 RVA: 0x000B41B1 File Offset: 0x000B23B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneUiAnchorSubsystem._ClassPtr;
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x000B41C0 File Offset: 0x000B23C0
		public USceneUiAnchorSubsystem() : this(BuiltinUtils.AllocNativeUObject(USceneUiAnchorSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x000B41E8 File Offset: 0x000B23E8
		public USceneUiAnchorSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneUiAnchorSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06007AD0 RID: 31440 RVA: 0x000B421C File Offset: 0x000B241C
		// (set) Token: 0x06007AD1 RID: 31441 RVA: 0x000B4255 File Offset: 0x000B2455
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

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06007AD2 RID: 31442 RVA: 0x000B4278 File Offset: 0x000B2478
		// (set) Token: 0x06007AD3 RID: 31443 RVA: 0x000B42B1 File Offset: 0x000B24B1
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

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06007AD4 RID: 31444 RVA: 0x000B42D4 File Offset: 0x000B24D4
		// (set) Token: 0x06007AD5 RID: 31445 RVA: 0x000B430D File Offset: 0x000B250D
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

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06007AD6 RID: 31446 RVA: 0x000B4330 File Offset: 0x000B2530
		// (set) Token: 0x06007AD7 RID: 31447 RVA: 0x000B4369 File Offset: 0x000B2569
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

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06007AD8 RID: 31448 RVA: 0x000B438C File Offset: 0x000B258C
		// (set) Token: 0x06007AD9 RID: 31449 RVA: 0x000B43C5 File Offset: 0x000B25C5
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

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06007ADA RID: 31450 RVA: 0x000B43E8 File Offset: 0x000B25E8
		// (set) Token: 0x06007ADB RID: 31451 RVA: 0x000B4421 File Offset: 0x000B2621
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

		// Token: 0x06007ADC RID: 31452 RVA: 0x000B4442 File Offset: 0x000B2642
		static USceneUiAnchorSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSceneUI.SceneUiAnchorSubsystem");
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x000B4450 File Offset: 0x000B2650
		protected USceneUiAnchorSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003434 RID: 13364
		public new const string __ObjectPath = "/Script/KuroSceneUI.SceneUiAnchorSubsystem";

		// Token: 0x04003435 RID: 13365
		private static IntPtr _ClassPtr;

		// Token: 0x04003436 RID: 13366
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003437 RID: 13367
		internal static int __PropertyOffset_OnPreloadRequest;

		// Token: 0x04003438 RID: 13368
		[Nullable(2)]
		private FSceneUiPreloadRequest _OnPreloadRequest;

		// Token: 0x04003439 RID: 13369
		internal static int __PropertyOffset_OnOpenRequest;

		// Token: 0x0400343A RID: 13370
		[Nullable(2)]
		private FSceneUiOpenRequest _OnOpenRequest;

		// Token: 0x0400343B RID: 13371
		internal static int __PropertyOffset_OnOpenWithMapRequest;

		// Token: 0x0400343C RID: 13372
		[Nullable(2)]
		private FSceneUiOpenWithMapRequest _OnOpenWithMapRequest;

		// Token: 0x0400343D RID: 13373
		internal static int __PropertyOffset_OnHideRequest;

		// Token: 0x0400343E RID: 13374
		[Nullable(2)]
		private FSceneUiAnchorRequest _OnHideRequest;

		// Token: 0x0400343F RID: 13375
		internal static int __PropertyOffset_OnCloseRequest;

		// Token: 0x04003440 RID: 13376
		[Nullable(2)]
		private FSceneUiAnchorRequest _OnCloseRequest;

		// Token: 0x04003441 RID: 13377
		internal static int __PropertyOffset_OnAnchorEndPlay;

		// Token: 0x04003442 RID: 13378
		[Nullable(2)]
		private FSceneUiAnchorRequest _OnAnchorEndPlay;
	}
}
