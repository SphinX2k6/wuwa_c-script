using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028E1 RID: 10465
	[UnrealObjectPath("/Script/TapCommon.TapCommonRegionCode")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FTapCommonRegionCode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026D22 RID: 159010 RVA: 0x003B3590 File Offset: 0x003B1790
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapCommonRegionCode._ScriptStructPtr != 0) ? FTapCommonRegionCode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapCommonRegionCode", ref FTapCommonRegionCode._ScriptStructPtr);
		}

		// Token: 0x1700958D RID: 38285
		// (get) Token: 0x06026D23 RID: 159011 RVA: 0x003B35B4 File Offset: 0x003B17B4
		// (set) Token: 0x06026D24 RID: 159012 RVA: 0x003B35C4 File Offset: 0x003B17C4
		public unsafe bool isMainland
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapCommonRegionCode.__PropertyOffset_isMainland) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapCommonRegionCode.__PropertyOffset_isMainland) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026D25 RID: 159013 RVA: 0x003B35D5 File Offset: 0x003B17D5
		public FTapCommonRegionCode()
		{
		}

		// Token: 0x06026D26 RID: 159014 RVA: 0x003B35DD File Offset: 0x003B17DD
		public FTapCommonRegionCode(bool isMainland)
		{
			this.isMainland = isMainland;
		}

		// Token: 0x06026D27 RID: 159015 RVA: 0x003B35EC File Offset: 0x003B17EC
		protected override IntPtr GetUStructPtr()
		{
			return FTapCommonRegionCode.StaticStruct();
		}

		// Token: 0x06026D28 RID: 159016 RVA: 0x003B35F8 File Offset: 0x003B17F8
		[NullableContext(2)]
		public FTapCommonRegionCode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026D29 RID: 159017 RVA: 0x003B3602 File Offset: 0x003B1802
		public FTapCommonRegionCode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026D2A RID: 159018 RVA: 0x003B360D File Offset: 0x003B180D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapCommonRegionCode(Pointer, false, true);
		}

		// Token: 0x06026D2B RID: 159019 RVA: 0x003B3617 File Offset: 0x003B1817
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapCommonRegionCode(Pointer, MemoryOwner);
		}

		// Token: 0x04015505 RID: 87301
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TapCommon.TapCommonRegionCode";

		// Token: 0x04015506 RID: 87302
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015507 RID: 87303
		internal static int __PropertyOffset_isMainland;
	}
}
