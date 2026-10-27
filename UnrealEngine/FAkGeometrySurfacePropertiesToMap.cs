using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200020B RID: 523
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkGeometrySurfacePropertiesToMap")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAkGeometrySurfacePropertiesToMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001F3C RID: 7996 RVA: 0x0002E29F File Offset: 0x0002C49F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkGeometrySurfacePropertiesToMap._ScriptStructPtr != 0) ? FAkGeometrySurfacePropertiesToMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkGeometrySurfacePropertiesToMap", ref FAkGeometrySurfacePropertiesToMap._ScriptStructPtr);
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x0002E2C3 File Offset: 0x0002C4C3
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x0002E2E2 File Offset: 0x0002C4E2
		public TSoftObjectPtr<UAkAcousticTexture> AcousticTexture
		{
			get
			{
				return new TSoftObjectPtr<UAkAcousticTexture>(base.NativePtr + (IntPtr)FAkGeometrySurfacePropertiesToMap.__PropertyOffset_AcousticTexture, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FAkGeometrySurfacePropertiesToMap.__PropertyOffset_AcousticTexture, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0002E307 File Offset: 0x0002C507
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x0002E317 File Offset: 0x0002C517
		public unsafe float OcclusionValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkGeometrySurfacePropertiesToMap.__PropertyOffset_OcclusionValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkGeometrySurfacePropertiesToMap.__PropertyOffset_OcclusionValue) = value;
			}
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x0002E328 File Offset: 0x0002C528
		public FAkGeometrySurfacePropertiesToMap()
		{
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x0002E330 File Offset: 0x0002C530
		public FAkGeometrySurfacePropertiesToMap(TSoftObjectPtr<UAkAcousticTexture> AcousticTexture, float OcclusionValue)
		{
			this.AcousticTexture = AcousticTexture;
			this.OcclusionValue = OcclusionValue;
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x0002E346 File Offset: 0x0002C546
		protected override IntPtr GetUStructPtr()
		{
			return FAkGeometrySurfacePropertiesToMap.StaticStruct();
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x0002E352 File Offset: 0x0002C552
		[NullableContext(2)]
		public FAkGeometrySurfacePropertiesToMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x0002E35C File Offset: 0x0002C55C
		public FAkGeometrySurfacePropertiesToMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0002E367 File Offset: 0x0002C567
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkGeometrySurfacePropertiesToMap(Pointer, false, true);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0002E371 File Offset: 0x0002C571
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkGeometrySurfacePropertiesToMap(Pointer, MemoryOwner);
		}

		// Token: 0x04000A46 RID: 2630
		public const string __ObjectPath = "/Script/AkAudio.AkGeometrySurfacePropertiesToMap";

		// Token: 0x04000A47 RID: 2631
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000A48 RID: 2632
		internal static int __PropertyOffset_AcousticTexture;

		// Token: 0x04000A49 RID: 2633
		internal static int __PropertyOffset_OcclusionValue;
	}
}
