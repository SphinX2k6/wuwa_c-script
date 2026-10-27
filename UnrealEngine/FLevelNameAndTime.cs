using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D33 RID: 3379
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LevelNameAndTime")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLevelNameAndTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B4ED RID: 46317 RVA: 0x001021BE File Offset: 0x001003BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelNameAndTime._ScriptStructPtr != 0) ? FLevelNameAndTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LevelNameAndTime", ref FLevelNameAndTime._ScriptStructPtr);
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x0600B4EE RID: 46318 RVA: 0x001021E2 File Offset: 0x001003E2
		// (set) Token: 0x0600B4EF RID: 46319 RVA: 0x001021F6 File Offset: 0x001003F6
		public unsafe string LevelName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLevelNameAndTime.__PropertyOffset_LevelName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLevelNameAndTime.__PropertyOffset_LevelName)), value);
			}
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x0600B4F0 RID: 46320 RVA: 0x0010220B File Offset: 0x0010040B
		// (set) Token: 0x0600B4F1 RID: 46321 RVA: 0x0010221B File Offset: 0x0010041B
		public unsafe uint LevelChangeTimeInMS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelNameAndTime.__PropertyOffset_LevelChangeTimeInMS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelNameAndTime.__PropertyOffset_LevelChangeTimeInMS) = (int)value;
			}
		}

		// Token: 0x0600B4F2 RID: 46322 RVA: 0x0010222C File Offset: 0x0010042C
		public FLevelNameAndTime()
		{
		}

		// Token: 0x0600B4F3 RID: 46323 RVA: 0x00102234 File Offset: 0x00100434
		public FLevelNameAndTime(string LevelName, uint LevelChangeTimeInMS)
		{
			this.LevelName = LevelName;
			this.LevelChangeTimeInMS = LevelChangeTimeInMS;
		}

		// Token: 0x0600B4F4 RID: 46324 RVA: 0x0010224A File Offset: 0x0010044A
		protected override IntPtr GetUStructPtr()
		{
			return FLevelNameAndTime.StaticStruct();
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x00102256 File Offset: 0x00100456
		[NullableContext(2)]
		public FLevelNameAndTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B4F6 RID: 46326 RVA: 0x00102260 File Offset: 0x00100460
		public FLevelNameAndTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B4F7 RID: 46327 RVA: 0x0010226B File Offset: 0x0010046B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelNameAndTime(Pointer, false, true);
		}

		// Token: 0x0600B4F8 RID: 46328 RVA: 0x00102275 File Offset: 0x00100475
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelNameAndTime(Pointer, MemoryOwner);
		}

		// Token: 0x04005F1D RID: 24349
		public const string __ObjectPath = "/Script/Engine.LevelNameAndTime";

		// Token: 0x04005F1E RID: 24350
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005F1F RID: 24351
		internal static int __PropertyOffset_LevelName;

		// Token: 0x04005F20 RID: 24352
		internal static int __PropertyOffset_LevelChangeTimeInMS;
	}
}
