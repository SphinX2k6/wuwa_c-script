using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FA6 RID: 8102
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LaunchDaemonMessages.IOSLaunchDaemonLaunchApp")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FIOSLaunchDaemonLaunchApp : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EBE5 RID: 125925 RVA: 0x002DB4E2 File Offset: 0x002D96E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIOSLaunchDaemonLaunchApp._ScriptStructPtr != 0) ? FIOSLaunchDaemonLaunchApp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LaunchDaemonMessages.IOSLaunchDaemonLaunchApp", ref FIOSLaunchDaemonLaunchApp._ScriptStructPtr);
		}

		// Token: 0x17007A77 RID: 31351
		// (get) Token: 0x0601EBE6 RID: 125926 RVA: 0x002DB506 File Offset: 0x002D9706
		// (set) Token: 0x0601EBE7 RID: 125927 RVA: 0x002DB51A File Offset: 0x002D971A
		public unsafe string AppID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonLaunchApp.__PropertyOffset_AppID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonLaunchApp.__PropertyOffset_AppID)), value);
			}
		}

		// Token: 0x17007A78 RID: 31352
		// (get) Token: 0x0601EBE8 RID: 125928 RVA: 0x002DB52F File Offset: 0x002D972F
		// (set) Token: 0x0601EBE9 RID: 125929 RVA: 0x002DB543 File Offset: 0x002D9743
		public unsafe string Parameters
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonLaunchApp.__PropertyOffset_Parameters)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonLaunchApp.__PropertyOffset_Parameters)), value);
			}
		}

		// Token: 0x0601EBEA RID: 125930 RVA: 0x002DB558 File Offset: 0x002D9758
		public FIOSLaunchDaemonLaunchApp()
		{
		}

		// Token: 0x0601EBEB RID: 125931 RVA: 0x002DB560 File Offset: 0x002D9760
		public FIOSLaunchDaemonLaunchApp(string AppID, string Parameters)
		{
			this.AppID = AppID;
			this.Parameters = Parameters;
		}

		// Token: 0x0601EBEC RID: 125932 RVA: 0x002DB576 File Offset: 0x002D9776
		protected override IntPtr GetUStructPtr()
		{
			return FIOSLaunchDaemonLaunchApp.StaticStruct();
		}

		// Token: 0x0601EBED RID: 125933 RVA: 0x002DB582 File Offset: 0x002D9782
		[NullableContext(2)]
		public FIOSLaunchDaemonLaunchApp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EBEE RID: 125934 RVA: 0x002DB58C File Offset: 0x002D978C
		public FIOSLaunchDaemonLaunchApp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EBEF RID: 125935 RVA: 0x002DB597 File Offset: 0x002D9797
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIOSLaunchDaemonLaunchApp(Pointer, false, true);
		}

		// Token: 0x0601EBF0 RID: 125936 RVA: 0x002DB5A1 File Offset: 0x002D97A1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIOSLaunchDaemonLaunchApp(Pointer, MemoryOwner);
		}

		// Token: 0x040109F9 RID: 68089
		public const string __ObjectPath = "/Script/LaunchDaemonMessages.IOSLaunchDaemonLaunchApp";

		// Token: 0x040109FA RID: 68090
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040109FB RID: 68091
		internal static int __PropertyOffset_AppID;

		// Token: 0x040109FC RID: 68092
		internal static int __PropertyOffset_Parameters;
	}
}
