using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001137 RID: 4407
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundModulationDefaultSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSoundModulationDefaultSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060101FC RID: 66044 RVA: 0x0017C158 File Offset: 0x0017A358
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundModulationDefaultSettings._ScriptStructPtr != 0) ? FSoundModulationDefaultSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundModulationDefaultSettings", ref FSoundModulationDefaultSettings._ScriptStructPtr);
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x060101FD RID: 66045 RVA: 0x0017C17C File Offset: 0x0017A37C
		// (set) Token: 0x060101FE RID: 66046 RVA: 0x0017C1BF File Offset: 0x0017A3BF
		public FSoundModulationDestinationSettings VolumeModulationDestination
		{
			get
			{
				base.FastCheckIsValid();
				FSoundModulationDestinationSettings result;
				if ((result = this._VolumeModulationDestination) == null)
				{
					result = (this._VolumeModulationDestination = new FSoundModulationDestinationSettings(base.NativePtr + (IntPtr)FSoundModulationDefaultSettings.__PropertyOffset_VolumeModulationDestination, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundModulationDestinationSettings.StaticStruct(), base.NativePtr + (IntPtr)FSoundModulationDefaultSettings.__PropertyOffset_VolumeModulationDestination, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x060101FF RID: 66047 RVA: 0x0017C1E0 File Offset: 0x0017A3E0
		// (set) Token: 0x06010200 RID: 66048 RVA: 0x0017C223 File Offset: 0x0017A423
		public FSoundModulationDestinationSettings PitchModulationDestination
		{
			get
			{
				base.FastCheckIsValid();
				FSoundModulationDestinationSettings result;
				if ((result = this._PitchModulationDestination) == null)
				{
					result = (this._PitchModulationDestination = new FSoundModulationDestinationSettings(base.NativePtr + (IntPtr)FSoundModulationDefaultSettings.__PropertyOffset_PitchModulationDestination, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundModulationDestinationSettings.StaticStruct(), base.NativePtr + (IntPtr)FSoundModulationDefaultSettings.__PropertyOffset_PitchModulationDestination, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x06010201 RID: 66049 RVA: 0x0017C244 File Offset: 0x0017A444
		// (set) Token: 0x06010202 RID: 66050 RVA: 0x0017C287 File Offset: 0x0017A487
		public FSoundModulationDestinationSettings HighpassModulationDestination
		{
			get
			{
				base.FastCheckIsValid();
				FSoundModulationDestinationSettings result;
				if ((result = this._HighpassModulationDestination) == null)
				{
					result = (this._HighpassModulationDestination = new FSoundModulationDestinationSettings(base.NativePtr + (IntPtr)FSoundModulationDefaultSettings.__PropertyOffset_HighpassModulationDestination, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundModulationDestinationSettings.StaticStruct(), base.NativePtr + (IntPtr)FSoundModulationDefaultSettings.__PropertyOffset_HighpassModulationDestination, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x06010203 RID: 66051 RVA: 0x0017C2A8 File Offset: 0x0017A4A8
		// (set) Token: 0x06010204 RID: 66052 RVA: 0x0017C2EB File Offset: 0x0017A4EB
		public FSoundModulationDestinationSettings LowpassModulationDestination
		{
			get
			{
				base.FastCheckIsValid();
				FSoundModulationDestinationSettings result;
				if ((result = this._LowpassModulationDestination) == null)
				{
					result = (this._LowpassModulationDestination = new FSoundModulationDestinationSettings(base.NativePtr + (IntPtr)FSoundModulationDefaultSettings.__PropertyOffset_LowpassModulationDestination, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundModulationDestinationSettings.StaticStruct(), base.NativePtr + (IntPtr)FSoundModulationDefaultSettings.__PropertyOffset_LowpassModulationDestination, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010205 RID: 66053 RVA: 0x0017C30C File Offset: 0x0017A50C
		public FSoundModulationDefaultSettings()
		{
		}

		// Token: 0x06010206 RID: 66054 RVA: 0x0017C314 File Offset: 0x0017A514
		public FSoundModulationDefaultSettings(FSoundModulationDestinationSettings VolumeModulationDestination, FSoundModulationDestinationSettings PitchModulationDestination, FSoundModulationDestinationSettings HighpassModulationDestination, FSoundModulationDestinationSettings LowpassModulationDestination)
		{
			this.VolumeModulationDestination = VolumeModulationDestination;
			this.PitchModulationDestination = PitchModulationDestination;
			this.HighpassModulationDestination = HighpassModulationDestination;
			this.LowpassModulationDestination = LowpassModulationDestination;
		}

		// Token: 0x06010207 RID: 66055 RVA: 0x0017C339 File Offset: 0x0017A539
		protected override IntPtr GetUStructPtr()
		{
			return FSoundModulationDefaultSettings.StaticStruct();
		}

		// Token: 0x06010208 RID: 66056 RVA: 0x0017C345 File Offset: 0x0017A545
		[NullableContext(2)]
		public FSoundModulationDefaultSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010209 RID: 66057 RVA: 0x0017C34F File Offset: 0x0017A54F
		public FSoundModulationDefaultSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601020A RID: 66058 RVA: 0x0017C35A File Offset: 0x0017A55A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundModulationDefaultSettings(Pointer, false, true);
		}

		// Token: 0x0601020B RID: 66059 RVA: 0x0017C364 File Offset: 0x0017A564
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundModulationDefaultSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04008ABE RID: 35518
		public const string __ObjectPath = "/Script/Engine.SoundModulationDefaultSettings";

		// Token: 0x04008ABF RID: 35519
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008AC0 RID: 35520
		internal static int __PropertyOffset_VolumeModulationDestination;

		// Token: 0x04008AC1 RID: 35521
		[Nullable(2)]
		private FSoundModulationDestinationSettings _VolumeModulationDestination;

		// Token: 0x04008AC2 RID: 35522
		internal static int __PropertyOffset_PitchModulationDestination;

		// Token: 0x04008AC3 RID: 35523
		[Nullable(2)]
		private FSoundModulationDestinationSettings _PitchModulationDestination;

		// Token: 0x04008AC4 RID: 35524
		internal static int __PropertyOffset_HighpassModulationDestination;

		// Token: 0x04008AC5 RID: 35525
		[Nullable(2)]
		private FSoundModulationDestinationSettings _HighpassModulationDestination;

		// Token: 0x04008AC6 RID: 35526
		internal static int __PropertyOffset_LowpassModulationDestination;

		// Token: 0x04008AC7 RID: 35527
		[Nullable(2)]
		private FSoundModulationDestinationSettings _LowpassModulationDestination;
	}
}
