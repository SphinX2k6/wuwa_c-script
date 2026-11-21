using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E2 RID: 226
	[UnrealObjectPath("/Script/CinematicCamera.CameraFilmbackSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FCameraFilmbackSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000FCF RID: 4047 RVA: 0x000195B4 File Offset: 0x000177B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraFilmbackSettings._ScriptStructPtr != 0) ? FCameraFilmbackSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraFilmbackSettings", ref FCameraFilmbackSettings._ScriptStructPtr);
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x000195D8 File Offset: 0x000177D8
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x000195E8 File Offset: 0x000177E8
		public unsafe float SensorWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorWidth) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x000195F9 File Offset: 0x000177F9
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00019609 File Offset: 0x00017809
		public unsafe float SensorHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorHeight) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0001961A File Offset: 0x0001781A
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x0001962A File Offset: 0x0001782A
		public unsafe float SensorAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorAspectRatio) = value;
			}
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0001963B File Offset: 0x0001783B
		public FCameraFilmbackSettings()
		{
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00019643 File Offset: 0x00017843
		protected override IntPtr GetUStructPtr()
		{
			return FCameraFilmbackSettings.StaticStruct();
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0001964F File Offset: 0x0001784F
		[NullableContext(2)]
		public FCameraFilmbackSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00019659 File Offset: 0x00017859
		public FCameraFilmbackSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00019664 File Offset: 0x00017864
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraFilmbackSettings(Pointer, false, true);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0001966E File Offset: 0x0001786E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraFilmbackSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000398 RID: 920
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CinematicCamera.CameraFilmbackSettings";

		// Token: 0x04000399 RID: 921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400039A RID: 922
		internal static int __PropertyOffset_SensorWidth;

		// Token: 0x0400039B RID: 923
		internal static int __PropertyOffset_SensorHeight;

		// Token: 0x0400039C RID: 924
		internal static int __PropertyOffset_SensorAspectRatio;
	}
}
