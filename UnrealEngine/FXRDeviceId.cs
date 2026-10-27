using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200146F RID: 5231
	[UnrealObjectPath("/Script/HeadMountedDisplay.XRDeviceId")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FXRDeviceId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013148 RID: 78152 RVA: 0x001C1096 File Offset: 0x001BF296
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXRDeviceId._ScriptStructPtr != 0) ? FXRDeviceId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HeadMountedDisplay.XRDeviceId", ref FXRDeviceId._ScriptStructPtr);
		}

		// Token: 0x17004A1C RID: 18972
		// (get) Token: 0x06013149 RID: 78153 RVA: 0x001C10BA File Offset: 0x001BF2BA
		// (set) Token: 0x0601314A RID: 78154 RVA: 0x001C10CE File Offset: 0x001BF2CE
		public unsafe FName SystemName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRDeviceId.__PropertyOffset_SystemName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRDeviceId.__PropertyOffset_SystemName) = value;
			}
		}

		// Token: 0x17004A1D RID: 18973
		// (get) Token: 0x0601314B RID: 78155 RVA: 0x001C10E3 File Offset: 0x001BF2E3
		// (set) Token: 0x0601314C RID: 78156 RVA: 0x001C10F3 File Offset: 0x001BF2F3
		public unsafe int DeviceId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRDeviceId.__PropertyOffset_DeviceId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRDeviceId.__PropertyOffset_DeviceId) = value;
			}
		}

		// Token: 0x0601314D RID: 78157 RVA: 0x001C1104 File Offset: 0x001BF304
		public FXRDeviceId()
		{
		}

		// Token: 0x0601314E RID: 78158 RVA: 0x001C110C File Offset: 0x001BF30C
		public FXRDeviceId(FName SystemName, int DeviceId)
		{
			this.SystemName = SystemName;
			this.DeviceId = DeviceId;
		}

		// Token: 0x0601314F RID: 78159 RVA: 0x001C1122 File Offset: 0x001BF322
		protected override IntPtr GetUStructPtr()
		{
			return FXRDeviceId.StaticStruct();
		}

		// Token: 0x06013150 RID: 78160 RVA: 0x001C112E File Offset: 0x001BF32E
		[NullableContext(2)]
		public FXRDeviceId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013151 RID: 78161 RVA: 0x001C1138 File Offset: 0x001BF338
		public FXRDeviceId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013152 RID: 78162 RVA: 0x001C1143 File Offset: 0x001BF343
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXRDeviceId(Pointer, false, true);
		}

		// Token: 0x06013153 RID: 78163 RVA: 0x001C114D File Offset: 0x001BF34D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXRDeviceId(Pointer, MemoryOwner);
		}

		// Token: 0x0400A3AF RID: 41903
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HeadMountedDisplay.XRDeviceId";

		// Token: 0x0400A3B0 RID: 41904
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A3B1 RID: 41905
		internal static int __PropertyOffset_SystemName;

		// Token: 0x0400A3B2 RID: 41906
		internal static int __PropertyOffset_DeviceId;
	}
}
