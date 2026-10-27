using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200105A RID: 4186
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.QuartzClockSettings")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FQuartzClockSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EE22 RID: 60962 RVA: 0x001615D9 File Offset: 0x0015F7D9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQuartzClockSettings._ScriptStructPtr != 0) ? FQuartzClockSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.QuartzClockSettings", ref FQuartzClockSettings._ScriptStructPtr);
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0600EE23 RID: 60963 RVA: 0x00161600 File Offset: 0x0015F800
		// (set) Token: 0x0600EE24 RID: 60964 RVA: 0x00161643 File Offset: 0x0015F843
		public FQuartzTimeSignature TimeSignature
		{
			get
			{
				base.FastCheckIsValid();
				FQuartzTimeSignature result;
				if ((result = this._TimeSignature) == null)
				{
					result = (this._TimeSignature = new FQuartzTimeSignature(base.NativePtr + (IntPtr)FQuartzClockSettings.__PropertyOffset_TimeSignature, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQuartzTimeSignature.StaticStruct(), base.NativePtr + (IntPtr)FQuartzClockSettings.__PropertyOffset_TimeSignature, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0600EE25 RID: 60965 RVA: 0x00161664 File Offset: 0x0015F864
		// (set) Token: 0x0600EE26 RID: 60966 RVA: 0x00161674 File Offset: 0x0015F874
		public unsafe bool bIgnoreLevelChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQuartzClockSettings.__PropertyOffset_bIgnoreLevelChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQuartzClockSettings.__PropertyOffset_bIgnoreLevelChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600EE27 RID: 60967 RVA: 0x00161685 File Offset: 0x0015F885
		public FQuartzClockSettings()
		{
		}

		// Token: 0x0600EE28 RID: 60968 RVA: 0x0016168D File Offset: 0x0015F88D
		public FQuartzClockSettings(FQuartzTimeSignature TimeSignature, bool bIgnoreLevelChange)
		{
			this.TimeSignature = TimeSignature;
			this.bIgnoreLevelChange = bIgnoreLevelChange;
		}

		// Token: 0x0600EE29 RID: 60969 RVA: 0x001616A3 File Offset: 0x0015F8A3
		protected override IntPtr GetUStructPtr()
		{
			return FQuartzClockSettings.StaticStruct();
		}

		// Token: 0x0600EE2A RID: 60970 RVA: 0x001616AF File Offset: 0x0015F8AF
		[NullableContext(2)]
		public FQuartzClockSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EE2B RID: 60971 RVA: 0x001616B9 File Offset: 0x0015F8B9
		public FQuartzClockSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EE2C RID: 60972 RVA: 0x001616C4 File Offset: 0x0015F8C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQuartzClockSettings(Pointer, false, true);
		}

		// Token: 0x0600EE2D RID: 60973 RVA: 0x001616CE File Offset: 0x0015F8CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQuartzClockSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040080F0 RID: 33008
		public const string __ObjectPath = "/Script/Engine.QuartzClockSettings";

		// Token: 0x040080F1 RID: 33009
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080F2 RID: 33010
		internal static int __PropertyOffset_TimeSignature;

		// Token: 0x040080F3 RID: 33011
		[Nullable(2)]
		private FQuartzTimeSignature _TimeSignature;

		// Token: 0x040080F4 RID: 33012
		internal static int __PropertyOffset_bIgnoreLevelChange;
	}
}
