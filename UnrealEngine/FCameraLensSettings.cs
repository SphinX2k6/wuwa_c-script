using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E4 RID: 228
	[UnrealObjectPath("/Script/CinematicCamera.CameraLensSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCameraLensSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000FF5 RID: 4085 RVA: 0x000198C6 File Offset: 0x00017AC6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraLensSettings._ScriptStructPtr != 0) ? FCameraLensSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraLensSettings", ref FCameraLensSettings._ScriptStructPtr);
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x000198EA File Offset: 0x00017AEA
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x000198FA File Offset: 0x00017AFA
		public unsafe float MinFocalLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinFocalLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinFocalLength) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0001990B File Offset: 0x00017B0B
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x0001991B File Offset: 0x00017B1B
		public unsafe float MaxFocalLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MaxFocalLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MaxFocalLength) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0001992C File Offset: 0x00017B2C
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x0001993C File Offset: 0x00017B3C
		public unsafe float MinFStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinFStop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinFStop) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0001994D File Offset: 0x00017B4D
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x0001995D File Offset: 0x00017B5D
		public unsafe float MaxFStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MaxFStop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MaxFStop) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0001996E File Offset: 0x00017B6E
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x0001997E File Offset: 0x00017B7E
		public unsafe float MinimumFocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinimumFocusDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_MinimumFocusDistance) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0001998F File Offset: 0x00017B8F
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x0001999F File Offset: 0x00017B9F
		public unsafe int DiaphragmBladeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_DiaphragmBladeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLensSettings.__PropertyOffset_DiaphragmBladeCount) = value;
			}
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000199B0 File Offset: 0x00017BB0
		public FCameraLensSettings()
		{
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000199B8 File Offset: 0x00017BB8
		protected override IntPtr GetUStructPtr()
		{
			return FCameraLensSettings.StaticStruct();
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x000199C4 File Offset: 0x00017BC4
		[NullableContext(2)]
		public FCameraLensSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000199CE File Offset: 0x00017BCE
		public FCameraLensSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x000199D9 File Offset: 0x00017BD9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraLensSettings(Pointer, false, true);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000199E3 File Offset: 0x00017BE3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraLensSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040003AC RID: 940
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CinematicCamera.CameraLensSettings";

		// Token: 0x040003AD RID: 941
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040003AE RID: 942
		internal static int __PropertyOffset_MinFocalLength;

		// Token: 0x040003AF RID: 943
		internal static int __PropertyOffset_MaxFocalLength;

		// Token: 0x040003B0 RID: 944
		internal static int __PropertyOffset_MinFStop;

		// Token: 0x040003B1 RID: 945
		internal static int __PropertyOffset_MaxFStop;

		// Token: 0x040003B2 RID: 946
		internal static int __PropertyOffset_MinimumFocusDistance;

		// Token: 0x040003B3 RID: 947
		internal static int __PropertyOffset_DiaphragmBladeCount;
	}
}
