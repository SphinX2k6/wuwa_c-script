using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200170C RID: 5900
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.RectEmitterSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FRectEmitterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060154B9 RID: 87225 RVA: 0x001F4C8D File Offset: 0x001F2E8D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRectEmitterSettings._ScriptStructPtr != 0) ? FRectEmitterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.RectEmitterSettings", ref FRectEmitterSettings._ScriptStructPtr);
		}

		// Token: 0x1700542F RID: 21551
		// (get) Token: 0x060154BA RID: 87226 RVA: 0x001F4CB1 File Offset: 0x001F2EB1
		// (set) Token: 0x060154BB RID: 87227 RVA: 0x001F4CC5 File Offset: 0x001F2EC5
		public unsafe FIntPoint GridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRectEmitterSettings.__PropertyOffset_GridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRectEmitterSettings.__PropertyOffset_GridSize) = value;
			}
		}

		// Token: 0x17005430 RID: 21552
		// (get) Token: 0x060154BC RID: 87228 RVA: 0x001F4CDA File Offset: 0x001F2EDA
		// (set) Token: 0x060154BD RID: 87229 RVA: 0x001F4CEE File Offset: 0x001F2EEE
		public unsafe FVector2D GridSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRectEmitterSettings.__PropertyOffset_GridSpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRectEmitterSettings.__PropertyOffset_GridSpacing) = value;
			}
		}

		// Token: 0x17005431 RID: 21553
		// (get) Token: 0x060154BE RID: 87230 RVA: 0x001F4D04 File Offset: 0x001F2F04
		// (set) Token: 0x060154BF RID: 87231 RVA: 0x001F4D47 File Offset: 0x001F2F47
		public FEmitterStackSettings StackSettings
		{
			get
			{
				base.FastCheckIsValid();
				FEmitterStackSettings result;
				if ((result = this._StackSettings) == null)
				{
					result = (this._StackSettings = new FEmitterStackSettings(base.NativePtr + (IntPtr)FRectEmitterSettings.__PropertyOffset_StackSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEmitterStackSettings.StaticStruct(), base.NativePtr + (IntPtr)FRectEmitterSettings.__PropertyOffset_StackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060154C0 RID: 87232 RVA: 0x001F4D68 File Offset: 0x001F2F68
		public FRectEmitterSettings()
		{
		}

		// Token: 0x060154C1 RID: 87233 RVA: 0x001F4D70 File Offset: 0x001F2F70
		public FRectEmitterSettings(FIntPoint GridSize, FVector2D GridSpacing, FEmitterStackSettings StackSettings)
		{
			this.GridSize = GridSize;
			this.GridSpacing = GridSpacing;
			this.StackSettings = StackSettings;
		}

		// Token: 0x060154C2 RID: 87234 RVA: 0x001F4D8D File Offset: 0x001F2F8D
		protected override IntPtr GetUStructPtr()
		{
			return FRectEmitterSettings.StaticStruct();
		}

		// Token: 0x060154C3 RID: 87235 RVA: 0x001F4D99 File Offset: 0x001F2F99
		[NullableContext(2)]
		public FRectEmitterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060154C4 RID: 87236 RVA: 0x001F4DA3 File Offset: 0x001F2FA3
		public FRectEmitterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060154C5 RID: 87237 RVA: 0x001F4DAE File Offset: 0x001F2FAE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRectEmitterSettings(Pointer, false, true);
		}

		// Token: 0x060154C6 RID: 87238 RVA: 0x001F4DB8 File Offset: 0x001F2FB8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRectEmitterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B9B8 RID: 47544
		public const string __ObjectPath = "/Script/KuroBulletCore.RectEmitterSettings";

		// Token: 0x0400B9B9 RID: 47545
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B9BA RID: 47546
		internal static int __PropertyOffset_GridSize;

		// Token: 0x0400B9BB RID: 47547
		internal static int __PropertyOffset_GridSpacing;

		// Token: 0x0400B9BC RID: 47548
		internal static int __PropertyOffset_StackSettings;

		// Token: 0x0400B9BD RID: 47549
		[Nullable(2)]
		private FEmitterStackSettings _StackSettings;
	}
}
