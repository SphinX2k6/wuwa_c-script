using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016E9 RID: 5865
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.EmitterCommonSettings")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FEmitterCommonSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060152CF RID: 86735 RVA: 0x001F1FDC File Offset: 0x001F01DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEmitterCommonSettings._ScriptStructPtr != 0) ? FEmitterCommonSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.EmitterCommonSettings", ref FEmitterCommonSettings._ScriptStructPtr);
		}

		// Token: 0x170053B4 RID: 21428
		// (get) Token: 0x060152D0 RID: 86736 RVA: 0x001F2000 File Offset: 0x001F0200
		// (set) Token: 0x060152D1 RID: 86737 RVA: 0x001F2043 File Offset: 0x001F0243
		public FEmitterBasicSettings BasicSettings
		{
			get
			{
				base.FastCheckIsValid();
				FEmitterBasicSettings result;
				if ((result = this._BasicSettings) == null)
				{
					result = (this._BasicSettings = new FEmitterBasicSettings(base.NativePtr + (IntPtr)FEmitterCommonSettings.__PropertyOffset_BasicSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEmitterBasicSettings.StaticStruct(), base.NativePtr + (IntPtr)FEmitterCommonSettings.__PropertyOffset_BasicSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170053B5 RID: 21429
		// (get) Token: 0x060152D2 RID: 86738 RVA: 0x001F2064 File Offset: 0x001F0264
		// (set) Token: 0x060152D3 RID: 86739 RVA: 0x001F20A7 File Offset: 0x001F02A7
		public FEmitterMovementSettings MovementSettings
		{
			get
			{
				base.FastCheckIsValid();
				FEmitterMovementSettings result;
				if ((result = this._MovementSettings) == null)
				{
					result = (this._MovementSettings = new FEmitterMovementSettings(base.NativePtr + (IntPtr)FEmitterCommonSettings.__PropertyOffset_MovementSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEmitterMovementSettings.StaticStruct(), base.NativePtr + (IntPtr)FEmitterCommonSettings.__PropertyOffset_MovementSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060152D4 RID: 86740 RVA: 0x001F20C8 File Offset: 0x001F02C8
		public FEmitterCommonSettings()
		{
		}

		// Token: 0x060152D5 RID: 86741 RVA: 0x001F20D0 File Offset: 0x001F02D0
		public FEmitterCommonSettings(FEmitterBasicSettings BasicSettings, FEmitterMovementSettings MovementSettings)
		{
			this.BasicSettings = BasicSettings;
			this.MovementSettings = MovementSettings;
		}

		// Token: 0x060152D6 RID: 86742 RVA: 0x001F20E6 File Offset: 0x001F02E6
		protected override IntPtr GetUStructPtr()
		{
			return FEmitterCommonSettings.StaticStruct();
		}

		// Token: 0x060152D7 RID: 86743 RVA: 0x001F20F2 File Offset: 0x001F02F2
		[NullableContext(2)]
		public FEmitterCommonSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060152D8 RID: 86744 RVA: 0x001F20FC File Offset: 0x001F02FC
		public FEmitterCommonSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060152D9 RID: 86745 RVA: 0x001F2107 File Offset: 0x001F0307
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEmitterCommonSettings(Pointer, false, true);
		}

		// Token: 0x060152DA RID: 86746 RVA: 0x001F2111 File Offset: 0x001F0311
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEmitterCommonSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B8C2 RID: 47298
		public const string __ObjectPath = "/Script/KuroBulletCore.EmitterCommonSettings";

		// Token: 0x0400B8C3 RID: 47299
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B8C4 RID: 47300
		internal static int __PropertyOffset_BasicSettings;

		// Token: 0x0400B8C5 RID: 47301
		[Nullable(2)]
		private FEmitterBasicSettings _BasicSettings;

		// Token: 0x0400B8C6 RID: 47302
		internal static int __PropertyOffset_MovementSettings;

		// Token: 0x0400B8C7 RID: 47303
		[Nullable(2)]
		private FEmitterMovementSettings _MovementSettings;
	}
}
