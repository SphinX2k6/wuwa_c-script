using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D1C RID: 3356
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LaunchOnTestSettings")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLaunchOnTestSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B3EB RID: 46059 RVA: 0x00100945 File Offset: 0x000FEB45
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLaunchOnTestSettings._ScriptStructPtr != 0) ? FLaunchOnTestSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LaunchOnTestSettings", ref FLaunchOnTestSettings._ScriptStructPtr);
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x0600B3EC RID: 46060 RVA: 0x0010096C File Offset: 0x000FEB6C
		// (set) Token: 0x0600B3ED RID: 46061 RVA: 0x001009AF File Offset: 0x000FEBAF
		public FFilePath LaunchOnTestmap
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._LaunchOnTestmap) == null)
				{
					result = (this._LaunchOnTestmap = new FFilePath(base.NativePtr + (IntPtr)FLaunchOnTestSettings.__PropertyOffset_LaunchOnTestmap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FLaunchOnTestSettings.__PropertyOffset_LaunchOnTestmap, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x0600B3EE RID: 46062 RVA: 0x001009D0 File Offset: 0x000FEBD0
		// (set) Token: 0x0600B3EF RID: 46063 RVA: 0x001009E4 File Offset: 0x000FEBE4
		public unsafe string DeviceID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLaunchOnTestSettings.__PropertyOffset_DeviceID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLaunchOnTestSettings.__PropertyOffset_DeviceID)), value);
			}
		}

		// Token: 0x0600B3F0 RID: 46064 RVA: 0x001009F9 File Offset: 0x000FEBF9
		public FLaunchOnTestSettings()
		{
		}

		// Token: 0x0600B3F1 RID: 46065 RVA: 0x00100A01 File Offset: 0x000FEC01
		public FLaunchOnTestSettings(FFilePath LaunchOnTestmap, string DeviceID)
		{
			this.LaunchOnTestmap = LaunchOnTestmap;
			this.DeviceID = DeviceID;
		}

		// Token: 0x0600B3F2 RID: 46066 RVA: 0x00100A17 File Offset: 0x000FEC17
		protected override IntPtr GetUStructPtr()
		{
			return FLaunchOnTestSettings.StaticStruct();
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x00100A23 File Offset: 0x000FEC23
		[NullableContext(2)]
		public FLaunchOnTestSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x00100A2D File Offset: 0x000FEC2D
		public FLaunchOnTestSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x00100A38 File Offset: 0x000FEC38
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLaunchOnTestSettings(Pointer, false, true);
		}

		// Token: 0x0600B3F6 RID: 46070 RVA: 0x00100A42 File Offset: 0x000FEC42
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLaunchOnTestSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04005E91 RID: 24209
		public const string __ObjectPath = "/Script/Engine.LaunchOnTestSettings";

		// Token: 0x04005E92 RID: 24210
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005E93 RID: 24211
		internal static int __PropertyOffset_LaunchOnTestmap;

		// Token: 0x04005E94 RID: 24212
		[Nullable(2)]
		private FFilePath _LaunchOnTestmap;

		// Token: 0x04005E95 RID: 24213
		internal static int __PropertyOffset_DeviceID;
	}
}
