using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001136 RID: 4406
	[UnrealObjectPath("/Script/Engine.SoundModulationDefaultRoutingSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FSoundModulationDefaultRoutingSettings : FSoundModulationDefaultSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060101EC RID: 66028 RVA: 0x0017C022 File Offset: 0x0017A222
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundModulationDefaultRoutingSettings._ScriptStructPtr != 0) ? FSoundModulationDefaultRoutingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundModulationDefaultRoutingSettings", ref FSoundModulationDefaultRoutingSettings._ScriptStructPtr);
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x060101ED RID: 66029 RVA: 0x0017C046 File Offset: 0x0017A246
		// (set) Token: 0x060101EE RID: 66030 RVA: 0x0017C056 File Offset: 0x0017A256
		public unsafe EModulationRouting VolumeRouting
		{
			get
			{
				return (EModulationRouting)(*(base.NativePtr + (IntPtr)FSoundModulationDefaultRoutingSettings.__PropertyOffset_VolumeRouting));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundModulationDefaultRoutingSettings.__PropertyOffset_VolumeRouting) = (byte)value;
			}
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x060101EF RID: 66031 RVA: 0x0017C067 File Offset: 0x0017A267
		// (set) Token: 0x060101F0 RID: 66032 RVA: 0x0017C077 File Offset: 0x0017A277
		public unsafe EModulationRouting PitchRouting
		{
			get
			{
				return (EModulationRouting)(*(base.NativePtr + (IntPtr)FSoundModulationDefaultRoutingSettings.__PropertyOffset_PitchRouting));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundModulationDefaultRoutingSettings.__PropertyOffset_PitchRouting) = (byte)value;
			}
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x060101F1 RID: 66033 RVA: 0x0017C088 File Offset: 0x0017A288
		// (set) Token: 0x060101F2 RID: 66034 RVA: 0x0017C098 File Offset: 0x0017A298
		public unsafe EModulationRouting HighpassRouting
		{
			get
			{
				return (EModulationRouting)(*(base.NativePtr + (IntPtr)FSoundModulationDefaultRoutingSettings.__PropertyOffset_HighpassRouting));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundModulationDefaultRoutingSettings.__PropertyOffset_HighpassRouting) = (byte)value;
			}
		}

		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x060101F3 RID: 66035 RVA: 0x0017C0A9 File Offset: 0x0017A2A9
		// (set) Token: 0x060101F4 RID: 66036 RVA: 0x0017C0B9 File Offset: 0x0017A2B9
		public unsafe EModulationRouting LowpassRouting
		{
			get
			{
				return (EModulationRouting)(*(base.NativePtr + (IntPtr)FSoundModulationDefaultRoutingSettings.__PropertyOffset_LowpassRouting));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundModulationDefaultRoutingSettings.__PropertyOffset_LowpassRouting) = (byte)value;
			}
		}

		// Token: 0x060101F5 RID: 66037 RVA: 0x0017C0CA File Offset: 0x0017A2CA
		public FSoundModulationDefaultRoutingSettings()
		{
		}

		// Token: 0x060101F6 RID: 66038 RVA: 0x0017C0D4 File Offset: 0x0017A2D4
		[NullableContext(1)]
		public FSoundModulationDefaultRoutingSettings(EModulationRouting VolumeRouting, EModulationRouting PitchRouting, EModulationRouting HighpassRouting, EModulationRouting LowpassRouting, FSoundModulationDestinationSettings VolumeModulationDestination, FSoundModulationDestinationSettings PitchModulationDestination, FSoundModulationDestinationSettings HighpassModulationDestination, FSoundModulationDestinationSettings LowpassModulationDestination)
		{
			this.VolumeRouting = VolumeRouting;
			this.PitchRouting = PitchRouting;
			this.HighpassRouting = HighpassRouting;
			this.LowpassRouting = LowpassRouting;
			base.VolumeModulationDestination = VolumeModulationDestination;
			base.PitchModulationDestination = PitchModulationDestination;
			base.HighpassModulationDestination = HighpassModulationDestination;
			base.LowpassModulationDestination = LowpassModulationDestination;
		}

		// Token: 0x060101F7 RID: 66039 RVA: 0x0017C124 File Offset: 0x0017A324
		protected override IntPtr GetUStructPtr()
		{
			return FSoundModulationDefaultRoutingSettings.StaticStruct();
		}

		// Token: 0x060101F8 RID: 66040 RVA: 0x0017C130 File Offset: 0x0017A330
		[NullableContext(2)]
		public FSoundModulationDefaultRoutingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060101F9 RID: 66041 RVA: 0x0017C13A File Offset: 0x0017A33A
		public FSoundModulationDefaultRoutingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060101FA RID: 66042 RVA: 0x0017C145 File Offset: 0x0017A345
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundModulationDefaultRoutingSettings(Pointer, false, true);
		}

		// Token: 0x060101FB RID: 66043 RVA: 0x0017C14F File Offset: 0x0017A34F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundModulationDefaultRoutingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04008AB8 RID: 35512
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundModulationDefaultRoutingSettings";

		// Token: 0x04008AB9 RID: 35513
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008ABA RID: 35514
		internal static int __PropertyOffset_VolumeRouting;

		// Token: 0x04008ABB RID: 35515
		internal static int __PropertyOffset_PitchRouting;

		// Token: 0x04008ABC RID: 35516
		internal static int __PropertyOffset_HighpassRouting;

		// Token: 0x04008ABD RID: 35517
		internal static int __PropertyOffset_LowpassRouting;
	}
}
