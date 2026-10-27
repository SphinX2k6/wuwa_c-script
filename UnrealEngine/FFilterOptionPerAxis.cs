using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C1 RID: 705
	[UnrealObjectPath("/Script/AnimationCore.FilterOptionPerAxis")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FFilterOptionPerAxis : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600271F RID: 10015 RVA: 0x0003ABA0 File Offset: 0x00038DA0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFilterOptionPerAxis._ScriptStructPtr != 0) ? FFilterOptionPerAxis._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.FilterOptionPerAxis", ref FFilterOptionPerAxis._ScriptStructPtr);
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x0003ABC4 File Offset: 0x00038DC4
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x0003ABD4 File Offset: 0x00038DD4
		public unsafe bool bX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFilterOptionPerAxis.__PropertyOffset_bX) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFilterOptionPerAxis.__PropertyOffset_bX) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x0003ABE5 File Offset: 0x00038DE5
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x0003ABF5 File Offset: 0x00038DF5
		public unsafe bool bY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFilterOptionPerAxis.__PropertyOffset_bY) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFilterOptionPerAxis.__PropertyOffset_bY) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x0003AC06 File Offset: 0x00038E06
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x0003AC16 File Offset: 0x00038E16
		public unsafe bool bZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFilterOptionPerAxis.__PropertyOffset_bZ) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFilterOptionPerAxis.__PropertyOffset_bZ) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x0003AC27 File Offset: 0x00038E27
		public FFilterOptionPerAxis()
		{
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x0003AC2F File Offset: 0x00038E2F
		public FFilterOptionPerAxis(bool bX, bool bY, bool bZ)
		{
			this.bX = bX;
			this.bY = bY;
			this.bZ = bZ;
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x0003AC4C File Offset: 0x00038E4C
		protected override IntPtr GetUStructPtr()
		{
			return FFilterOptionPerAxis.StaticStruct();
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x0003AC58 File Offset: 0x00038E58
		[NullableContext(2)]
		public FFilterOptionPerAxis(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x0003AC62 File Offset: 0x00038E62
		public FFilterOptionPerAxis(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0003AC6D File Offset: 0x00038E6D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFilterOptionPerAxis(Pointer, false, true);
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0003AC77 File Offset: 0x00038E77
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFilterOptionPerAxis(Pointer, MemoryOwner);
		}

		// Token: 0x04000F6A RID: 3946
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimationCore.FilterOptionPerAxis";

		// Token: 0x04000F6B RID: 3947
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F6C RID: 3948
		internal static int __PropertyOffset_bX;

		// Token: 0x04000F6D RID: 3949
		internal static int __PropertyOffset_bY;

		// Token: 0x04000F6E RID: 3950
		internal static int __PropertyOffset_bZ;
	}
}
